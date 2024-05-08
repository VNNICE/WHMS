using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS;
using System.Security.Cryptography.X509Certificates;

namespace WHMS
{

    public partial class View_WarehouseList_Area : Form
    {
        private readonly DatabaseContext context = new DatabaseContext();
        private List<Join_Warehouse>? join_WarehouseLists;

        public View_WarehouseList_Area()
        {
            InitializeComponent();
            LoadDefaultData();
            dataGridView_WarehouseLists.DataBindingComplete += dataGridView_format;
            comboBox_Area.Format += (sender, e) =>
            {
                if (e.ListItem is WarehouseList_Area area && area._Area == -99)
                {
                    e.Value = "全体";
                }
            };
            comboBox_City.SelectedIndexChanged += ComboBox_City_SelectedIndexChanged;
            comboBox_Name.SelectedIndexChanged += ComboBox_Name_SelectedIndexChanged;
            comboBox_Area.SelectedIndexChanged += ComboBox_Area_SelectedIndexChanged;
        }

        private void ComboBox_City_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ComboBox_NameData();
            LoadGridViewCity();
        }

        private void ComboBox_Name_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ComboBox_AreaData();
            LoadGridViewWarehouse();
        }
        private void ComboBox_Area_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadGridViewArea();
        }

        private void SetJoinWarehouseLists()
        {
            if (context.WarehouseLists.Any())
            {
                var allWarehouseData = context.WarehouseLists
                    .Include(wl=>wl.CityList)
                    .Include(wl => wl.WarehouseList_Areas)
                    .ThenInclude(wa => wa.WarehouseList_Shelves)
                    .ToList();
                if (allWarehouseData != null)
                {
                    join_WarehouseLists = allWarehouseData.SelectMany(wl => wl.WarehouseList_Areas.SelectMany(wa =>wa.WarehouseList_Shelves.Select(ws =>
                    new Join_Warehouse(
                    wl.CityList._City,
                    wl._Id,
                    wl._Name,
                    wa._Id,
                    wa._Area,
                    ws._Id,
                    ws._No
                    )))).ToList();
                }
            }
            else
            {
                MessageBox.Show("登録された倉庫がありません、倉庫を登録してください。");
            }
        }

        private void LoadGridView()
        {
                SetJoinWarehouseLists();
                dataGridView_WarehouseLists.DataSource = join_WarehouseLists;
        }

        private void LoadGridViewCity()
        {
            if (join_WarehouseLists != null && comboBox_City.SelectedItem != null && comboBox_City.SelectedValue != null)
            {
                if (comboBox_City.SelectedValue.ToString() == "empty")
                {
                    dataGridView_WarehouseLists.DataSource = join_WarehouseLists.ToList();
                }
                else
                {
                    var code = comboBox_City.SelectedValue.ToString();
                    var city = context.CityLists.Where(x=>x._Code == code).Select(x=>x._City).FirstOrDefault();
                    dataGridView_WarehouseLists.DataSource = join_WarehouseLists.Where(x => x._City == city).ToList();
                }
            }
        }

        private void LoadGridViewWarehouse()
        {
            if (join_WarehouseLists != null && comboBox_Name.SelectedItem != null && comboBox_Name.SelectedValue != null)
            {
                if (comboBox_Name.SelectedValue.ToString() == "empty")
                {
                    LoadGridViewCity();
                }
                else
                {
                    dataGridView_WarehouseLists.DataSource = join_WarehouseLists.Where(x => x._Id == comboBox_Name.SelectedValue.ToString()).ToList();
                }
            }
        }

        private void LoadGridViewArea()
        {
            if (join_WarehouseLists != null && comboBox_Area.SelectedItem != null && comboBox_Area.SelectedValue != null)
            {
                if (comboBox_Area.SelectedValue.ToString() == "empty")
                {
                    LoadGridViewWarehouse();
                }
                else
                {
                    dataGridView_WarehouseLists.DataSource = join_WarehouseLists.Where(x => x._AreaId == comboBox_Area.SelectedValue.ToString()).ToList();
                }
            }
        }
        private void LoadGridViewShelf()
        {

        }


        private void LoadDefaultData()
        {
            LoadGridView();
            LoadImages();
            ComboBox_CityData();
        }
        private void ComboBox_CityData() 
        {
            if (context.WarehouseLists.Any())
            {
                var blank = new CityList("empty", "全体");
                var codes = context.WarehouseLists.Select(x => x.CityList_Code).Distinct().ToList();
                var cityElements = context.CityLists.Where(x=> codes.Contains(x._Code)).ToList();
                cityElements.Insert(0, blank);

                comboBox_City.DataSource = cityElements;
                comboBox_City.DisplayMember = "_City";
                comboBox_City.ValueMember = "_Code";
                ComboBox_NameData();
            }
        }
        private void ComboBox_NameData()
        {
            if (comboBox_City.SelectedValue != null)
            {
                List<WarehouseList> warehouseElements;
                var blank = new WarehouseList("empty", 0, "", "全体", "");
                if (comboBox_City.SelectedValue.ToString() == "empty")
                {
                    warehouseElements = context.WarehouseLists.ToList();
                }
                else
                {
                    
                    warehouseElements = context.WarehouseLists.Where(x => x.CityList_Code == comboBox_City.SelectedValue.ToString()).Distinct().ToList();
                }
                warehouseElements.Insert(0, blank);
                comboBox_Name.DataSource = warehouseElements;
                comboBox_Name.DisplayMember = "_Name";
                comboBox_Name.ValueMember = "_Id";
                ComboBox_AreaData();

            }

        }
        private void ComboBox_AreaData()
        {
            if (comboBox_City.SelectedValue != null && comboBox_Name.SelectedValue != null)
            {
                var blank = new WarehouseList_Area("empty", "", -99, "", "");
                var areaElements = context.WarehouseList_Areas.Where(x => x.WarehouseList_Id == comboBox_Name.SelectedValue.ToString()).ToList();
                areaElements.Insert(0, blank);

                comboBox_Area.DataSource = areaElements;
                comboBox_Area.DisplayMember = "_Area";
                comboBox_Area.ValueMember = "_Id";
            }
        }

        private void LoadImages()
        {
            if (comboBox_Name.SelectedValue != null)
            {
                string selectedWarehouseId = comboBox_Name.SelectedValue.ToString() ?? "wrongValue";
                var targetWarehouseListsAreas = context.WarehouseList_Areas.Where(x => x.WarehouseList_Id == selectedWarehouseId).ToList();
                comboBox_Area.DataSource = targetWarehouseListsAreas;
                comboBox_Area.DisplayMember = "_Area";
                comboBox_Area.ValueMember = "_Id";
                var selectedWarehouse = context.WarehouseLists.Find(selectedWarehouseId);
                if (selectedWarehouse != null && selectedWarehouse._ImagePath != null)
                {
                    try 
                    {
                        pictureBox_Image.Image = Image.FromFile(selectedWarehouse._ImagePath);
                        pictureBox_Image.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch
                    { 
                        pictureBox_Image.Image = null;
                    }
                }
            }
        }

        private void comboBox_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadImages();
        }
        private void comboBox_Name_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void button_Apply_Click(object sender, EventArgs e)
        {

        }

        private void label_Name_Click(object sender, EventArgs e)
        {

        }


        private void button_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void label_Err1_Click(object sender, EventArgs e)
        {

        }

        private void button_Add_Warehouse_Click(object sender, EventArgs e)
        {
            OpenWL();
        }

        private void OpenWL()
        {
            Add_Warehouse_DefaultInfo wl = new Add_Warehouse_DefaultInfo();
            wl.FormClosed += (sender, e) => { LoadDefaultData(); };
            wl.ShowDialog();
        }

        private void pictureBox_Image_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView_format(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView_WarehouseLists.Columns["_City"].HeaderText = "地域";
            dataGridView_WarehouseLists.Columns["_Id"].HeaderText = "ID";
            dataGridView_WarehouseLists.Columns["_Name"].HeaderText = "倉庫名";
            dataGridView_WarehouseLists.Columns["_AreaId"].Visible = false;
            dataGridView_WarehouseLists.Columns["_Area"].HeaderText = "置場区分";
            dataGridView_WarehouseLists.Columns["_ShelfId"].Visible = false;
            dataGridView_WarehouseLists.Columns["_ShelfNo"].HeaderText = "棚";
        }
    }
}
