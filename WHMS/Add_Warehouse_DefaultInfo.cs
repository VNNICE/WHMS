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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WHMS
{
    public partial class Add_Warehouse_DefaultInfo : Form
    {
        private string MakeUrl = "";
        public static string targetWarehouse { get; private set; } = "";
        private readonly DatabaseContext _context;
        private Functions fc = new Functions();

        public Add_Warehouse_DefaultInfo()
        {
            InitializeComponent();
            _context = new DatabaseContext();
            LoadComboBoxData();
            comboBox_City.DropDownStyle = ComboBoxStyle.DropDownList;
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
                Add_Warehouse_SecondInfo form2 = new Add_Warehouse_SecondInfo();
                this.Dispose();
                form2.ShowDialog();                
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void Add_Database()
        {
            string msg = "";
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
                MakeUrl = Path.Combine(DataPath.imagePath, "Blank_WarehouseImg_" + textBox_Name.Text.ToString() + ".bmp");
                fc.NoImageGenerator(MakeUrl);
            }

            var warehouseList = new WarehouseList(id, count, city, name, MakeUrl);
            _context.WarehouseLists.Add(warehouseList);
            _context.SaveChanges();
            MessageBox.Show("倉庫登録成功");
            AreaMaker(id, areas);
            MessageBox.Show("登録成功", "登録成功", MessageBoxButtons.OK);
            targetWarehouse = id;
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
            }
        }
        /*
         Functions
         */
        private void AreaMaker(string id, int count)
        {
            var warehouseareas = new List<WarehouseList_Area>();
            for (int i = 0; i <= count; i++)
            {
                warehouseareas.Add(new WarehouseList_Area(id + "-" + i.ToString("D2"), id, i, null, null));
            }
            _context.WarehouseList_Areas.AddRange(warehouseareas);
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