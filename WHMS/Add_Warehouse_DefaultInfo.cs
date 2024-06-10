using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DBMS;
using Microsoft.EntityFrameworkCore;

namespace WHMS
{
    public partial class Add_Warehouse_DefaultInfo : Form
    {
        private string? MakeUrl;
        public static string targetWarehouse { get; private set; } = "";
        private readonly DatabaseContext _context;
        private Functions fc = new Functions();
        PictureViewer pictureViewer = new PictureViewer();

        public Add_Warehouse_DefaultInfo()
        {
            InitializeComponent();
            _context = new DatabaseContext();
            LoadComboBoxData();
            comboBox_City.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_Add_Areas.KeyPress += KeyPressSettings;
            pictureViewer.SetADefaultDataPictureBox(this);
            
        }
        private void KeyPressSettings(object? sender, KeyPressEventArgs e)
        {
            TextBox? tb = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (tb != null && tb.Text.Length >= 4 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void LoadComboBoxData()
        {
            if (_context != null)
            {
                if (_context.CityLists != null)
                {
                    var cities = _context.CityLists.ToList();
                    comboBox_City.DataSource = cities;
                    comboBox_City.DisplayMember = "_City";
                    comboBox_City.ValueMember = "_Code";
                }
            }
        }
        private void button_Apply_Click(object sender, EventArgs e)
        {
            try
            {
                Add_Database();
                Add_Warehouse_SecondInfo secondInfoForm = new Add_Warehouse_SecondInfo();
                secondInfoForm.Owner = this.Owner;
                secondInfoForm.Load += (order, s) => this.Visible = false;
                secondInfoForm.Closed += (order, s) => { secondInfoForm.Owner.Enabled = true; this.Close(); };
                secondInfoForm.Show();
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void Add_Database()
        {
            string city = comboBox_City.SelectedValue.ToString();
            string name = textBox_Name.Text.ToString();
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("登録失敗、倉庫名が空欄です。");
            }
            else if (_context.WarehouseLists.Any(n => n._Name == name))
            {
                throw new ArgumentException($"登録失敗、'{name}'はすでに登録されています。");
            }
            int count = Counter(city);
            string id = city + (count).ToString("D2");
            int areas = fc.Try_IntParse(label_Add_Areas, textBox_Add_Areas);
            if (string.IsNullOrWhiteSpace(textBox_Show_ImagesPath.Text) && string.IsNullOrEmpty(textBox_Show_ImagesPath.Text))
            {
                MakeUrl = null;
                MessageBox.Show("画像なしで登録します。");
            }

            var warehouseList = new WarehouseList(id, count, city, name, MakeUrl);
            _context.WarehouseLists.Add(warehouseList);
            _context.SaveChanges();
            AreaMaker(id, areas);
            MessageBox.Show("登録成功");
            targetWarehouse = id;
        }
        private void MapAreaSelection()
        {
            PictureViewer areaSelection = new PictureViewer();
            
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_Add_Images_Click(object sender, EventArgs e)
        {
            ImageSelection();
        }
        private void ImageSelection()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                if (!Directory.Exists(DataPath.imagePath))
                {
                    Directory.CreateDirectory(DataPath.imagePath);
                }
                string fileExtension = Path.GetExtension(selectedFilePath);
                string filePath = Path.Combine(DataPath.imagePath, "WarehouseImg_" + textBox_Name.Text.ToString() + fileExtension);
                File.Copy(selectedFilePath, filePath, true);
                MakeUrl = filePath;
                textBox_Show_ImagesPath.Text = MakeUrl;
                pictureViewer.Show();
                pictureViewer.SetADefaultDataPictureBox(this);
                pictureViewer.Mode_LoadPicture(filePath);
            }
        }
        /*
         Functions
         */
        private void AreaMaker(string id, int count)
        {
            var warehouseAreas = new List<WarehouseList_Area>();
            for (int i = 0; i <= count; i++)
            {
                warehouseAreas.Add(new WarehouseList_Area(id + "-" + i.ToString("D2"), id, i, null, null));
            }
            _context.WarehouseList_Areas.AddRange(warehouseAreas);
            _context.SaveChanges();
        }
        private int Counter(string city)
        {
            if (_context.WarehouseLists.Any(x => x.CityList_Code == city))
            {
                return _context.WarehouseLists.Where(x => x.CityList_Code == city).Max(x => x._Count) + 1;
            }
            else
            {
                return 1;
            }
        }
    }
}