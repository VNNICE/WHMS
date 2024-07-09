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

        //public static string targetWarehouse { get; private set; } = "";
        private string city;
        private string warehouseName;
        private string warehouseId;
        private int areaCount;
        private readonly DatabaseContext _context = new DatabaseContext();
        private Functions fc = new Functions();
        private InputRules inputRules = new InputRules();

        public Add_Warehouse_DefaultInfo()
        {
            InitializeComponent();
            DefaultSettings();
            button_Add_Images.Click += (o, e) => ImageSelection();
            button_Cancel.Click += (o, e) => this.Close();

            this.Size = new Size(276, 241);

            

            button1.Click += (o, e) => 
            {
                string testcity = comboBox_City.SelectedValue.ToString(); ;
                int test;
                if (_context.WarehouseLists.Any(x => x.CityList_Code == testcity))
                {
                    test = _context.WarehouseLists.Where(x => x.CityList_Code == testcity).Count() + 1;
                }
                else
                {
                    test = 1;
                }
                MessageBox.Show(  test.ToString());
            };
        }

        private void DefaultSettings()
        {
            comboBox_City.DropDownStyle = ComboBoxStyle.DropDownList;
            inputRules.Rule_OnlyInt(textBox_Add_Areas);
            if (_context != null)
            {
                if (_context.CityLists != null)
                {
                    comboBox_City.DataSource = _context.CityLists.ToList();
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
                Add_Warehouse_SecondInfo secondInfoForm = new Add_Warehouse_SecondInfo(_context.WarehouseLists.Find(warehouseId));
                secondInfoForm.Owner = this.Owner;
                secondInfoForm.Load += (order, s) => this.Visible = false;
                secondInfoForm.Closed += (order, s) => this.Close(); 
                
                secondInfoForm.Show();
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void Add_Database()
        {
            int cityCount;
            city = comboBox_City.SelectedValue.ToString();
            areaCount = int.Parse(textBox_Add_Areas.Text);
            warehouseName = textBox_Name.Text.ToString();
            if (_context.WarehouseLists.Any(x => x.CityList_Code == city))
            {
                cityCount = _context.WarehouseLists.Where(x => x.CityList_Code == city).Count() + 1;
            }
            else
            {
                cityCount = 1;
            }
            warehouseId = city + (cityCount).ToString("D2");
            int areas = int.Parse(textBox_Add_Areas.Text);

            if (string.IsNullOrWhiteSpace(warehouseName))
            {
                throw new ArgumentException("登録失敗、倉庫名が空欄です。");
            }
            else if (_context.WarehouseLists.Any(n => n._Name == warehouseName))
            {
                throw new ArgumentException($"登録失敗、'{warehouseName}'はすでに登録されています。");
            }

            if (string.IsNullOrWhiteSpace(textBox_Show_ImagesPath.Text) && string.IsNullOrEmpty(textBox_Show_ImagesPath.Text))
            {
                MakeUrl = null;
                MessageBox.Show("画像なしで登録します。");
            }

            var warehouseList = new WarehouseList(warehouseId, areaCount, city, warehouseName, MakeUrl);
            _context.WarehouseLists.Add(warehouseList);
            _context.SaveChanges();
            AreaMaker();
            MessageBox.Show("登録成功");
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
                pictureBox1.Image = Image.FromFile(filePath);
                this.Size = new Size(509, 241);
            }
        }
        /*         Functions         */
        private void AreaMaker()
        {
            var warehouseAreas = new List<WarehouseList_Area>();
            for (int i = 0; i <= areaCount; i++)
            {
                warehouseAreas.Add(new WarehouseList_Area(warehouseId + "-" + i.ToString("D2"), warehouseId, i, null, null));
            }
            _context.WarehouseList_Areas.AddRange(warehouseAreas);
            _context.SaveChanges();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}