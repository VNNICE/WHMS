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
    public partial class Add_WarehouseDefaultInfo : Form
    {
        public Add_WarehouseDefaultInfo()
        {
            InitializeComponent();
            LoadComboBoxData();
            comboBox_City.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadComboBoxData()
        {
            using (var context = new DBMS.DatabaseContext())
            {
                if (context != null)
                {
                    if (context.CityLists != null)
                    {
                        var cities = context.CityLists.ToList();
                        comboBox_City.DataSource = cities;
                        comboBox_City.DisplayMember = "_City";
                        comboBox_City.ValueMember = "_Code";
                    }
                }
            }
        }

        private void comboBox_City_TextUpdate(object sender, EventArgs e)
        {

        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
            {
                string city = comboBox_City.SelectedValue.ToString();
                string name = textBox_Name.Text.ToString();
                int count = Counter(city);
                string id = city + (count).ToString("D2");

                try
                {
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        throw new ArgumentException("登録失敗、倉庫名が空欄です。");
                    }
                    else if (context.WarehouseLists.Any(n => n._Name == name))
                    {
                        throw new ArgumentException($"登録失敗、'{name}'はすでに登録されています。");
                    }
                    int areas = Functions.Try_IntParse(label_Add_Areas, textBox_Add_Areas);
                    var warehouseList = new WarehouseList(id, count, city, name, MakeUrl);
                    context.WarehouseLists.Add(warehouseList);
                    context.SaveChanges();
                    AreaMaker(id, areas);
                    MessageBox.Show("登録成功", "登録成功", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (ArgumentException ae)
                {
                    MessageBox.Show(ae.Message, $"Error", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + $"Id: {id}, city : {city}, count: {count}, name: {name}", "登録失敗", MessageBoxButtons.OK);
                }
            }
        }

        private void comboBox_City_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }
        private static string MakeUrl = "";
        private void button_Add_Images_Click(object sender, EventArgs e)
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
                string filePath = Path.Combine(DataPath.imagePath, "WarehouseImg_"+textBox_Name.ToString()+fileExtension);
                File.Copy(selectedFilePath, filePath, true);
                MakeUrl = filePath;
                textBox_Show_ImagesPath.Text = MakeUrl;
            }
        }

        private void Add_WarehouseList_Load(object sender, EventArgs e)
        {

        }

        /*
         Functions
         */
        public void AreaMaker(string id, int count)
        {
            using (var context = new DBMS.DatabaseContext())
            {
                var warehouseareas = new List<WarehouseList_Area>();
                for (int i = 0; i <= count; i++)
                {
                    warehouseareas.Add(new WarehouseList_Area(id + "-"+ i.ToString("D2"), id, i, null, null));
                }
                context.WarehouseList_Areas.AddRange(warehouseareas);
                context.SaveChanges();
            }
        }
        public int Counter(string city)
        {
            using (var context = new DBMS.DatabaseContext())
            {
                if (context.WarehouseLists.Any(x => x.CityList_Code == city))
                {
                    return context.WarehouseLists.Where(x => x.CityList_Code == city).Max(x => x._Count) + 1;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
