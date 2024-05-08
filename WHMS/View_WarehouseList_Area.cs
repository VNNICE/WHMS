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
            SetJoinWarehouseLists();
            LoadDefaultData();

            comboBox_City.SelectedIndexChanged += ComboBox_City_SelectedIndexChanged;
            comboBox_Name.SelectedIndexChanged += ComboBox_Name_SelectedIndexChanged;
            comboBox_Area.SelectedIndexChanged += ComboBox_Area_SelectedIndexChanged;
            comboBox_Shelf.SelectedIndexChanged += ComboBox_Shelf_SelectedIndexChanged;
        }

        private void ComboBox_City_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ComboBox_NameData();
        }

        private void ComboBox_Name_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ComboBox_AreaData();
        }
        private void ComboBox_Area_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ComboBox_ShelfData();
        }
        private void ComboBox_Shelf_SelectedIndexChanged(object? sender, EventArgs e)
        {
            
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
                    wa._Area,
                    ws._No
                    )))).ToList();
                }
            }
        }

        private void LoadGirdView()
        {
            if (comboBox_Name.Text != null && comboBox_Area != null && context.WarehouseLists.Any() && join_WarehouseLists != null)
            {
                dataGridView_WarehouseLists.DataSource = join_WarehouseLists;

            }
            else
            {
                MessageBox.Show("Null");
            }
        }

        private void LoadDefaultData()
        {
            LoadGirdView();
            LoadImages();
            ComboBox_CityData();
        }
        private void ComboBox_CityData() 
        {
            if (context.WarehouseLists.Any())
            {
                var codes = context.WarehouseLists.Select(x => x.CityList_Code).Distinct().ToList();
                var cityElements = context.CityLists.Where(x=> codes.Contains(x._Code)).ToList();

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
                var warehouseElements = context.WarehouseLists.Where(x=>x.CityList_Code == comboBox_City.SelectedValue.ToString()).Distinct().ToList();
                comboBox_Name.DataSource = warehouseElements;
                comboBox_Name.DisplayMember = "_Name";
                comboBox_Name.ValueMember = "_Id";
                ComboBox_AreaData();
            }
        }
        private void ComboBox_AreaData()
        {
            if (comboBox_Name.SelectedValue != null)
            {
                var areaElements = context.WarehouseList_Areas.Where(x => x.WarehouseList_Id == comboBox_Name.ValueMember.ToString()).ToList();
                comboBox_Area.DataSource = areaElements;
                comboBox_Area.DisplayMember = "_Area";
                comboBox_Area.ValueMember = "_Id";
                ComboBox_ShelfData();
            }
        }
        private void ComboBox_ShelfData()
        {
            if (comboBox_Area.SelectedValue != null)
            {
                var shelves = context.WarehouseList_Shelf.Where(x => x.WarehouseList_Area_Id == comboBox_Area.ValueMember.ToString()).Distinct().ToList();
                comboBox_Shelf.DataSource = shelves;
                comboBox_Area.DisplayMember = "_No";
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
    }
}
