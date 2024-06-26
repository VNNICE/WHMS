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
using System.Xml.Linq;

namespace WHMS
{

    public partial class View_WarehouseList_Area : Form
    {
        private readonly DatabaseContext context = new DatabaseContext();
        private List<Join_Warehouse> join_WarehouseLists;
        private List<WarehouseList> allWarehouseData;
        PictureViewer pictureViewer = new PictureViewer();
        
        public View_WarehouseList_Area()
        {
            InitializeComponent();
            DefaultSettings();/*
            dataGridView_WarehouseLists.DataBindingComplete += dataGridView_format;
            dataGridView_WarehouseLists.CellFormatting += dataGridView_CellFormatting;
            dataGridView_WarehouseLists.CellMouseMove += new DataGridViewCellMouseEventHandler(dataGridView_WarehouseLists_CellMouseMove);
            pictureViewer.Show();
            pictureViewer.SetADefaultDataPictureBox(this);
            comboBox_Area.Format += (sender, e) =>
            {
                if (e.ListItem is WarehouseList_Area area && area._Area == -99)
                {
                    e.Value = "全体";
                }
            };
            comboBox_City.SelectedIndexChanged += ComboBox_City_SelectedIndexChanged;
            comboBox_Name.SelectedIndexChanged += ComboBox_Name_SelectedIndexChanged;
            comboBox_Area.SelectedIndexChanged += ComboBox_Area_SelectedIndexChanged;*/
        }
        private void DefaultSettings() 
        {
            AllWareHouseData();
            
            comboBox_Name.Enabled = false;
            comboBox_Area.Enabled = false;
            if (join_WarehouseLists != null && join_WarehouseLists.Any())
            {
                List<string> cityLists = join_WarehouseLists.Select(x => x._City).Distinct().ToList();
                cityLists.Insert(0, "全体");
                comboBox_City.DataSource = cityLists;
                ComboBox_NameData();
            }

            comboBox_City.SelectedIndexChanged += (o, e) => ComboBox_NameData();
            comboBox_Name.SelectedIndexChanged += (o, e) => ComboBox_AreaData();
            dataGridView_WarehouseLists.DataSource = join_WarehouseLists;

        }

        private void AllWareHouseData()
        {
            allWarehouseData = context.WarehouseLists
                .Include(wl=>wl.CityList)
                .Include(wl => wl.WarehouseList_Areas)
                .ThenInclude(wa => wa.WarehouseList_Shelves)
                .ThenInclude(il => il.StockItemLists)
                .ToList();
             
            
            if (allWarehouseData != null) 
            {
                join_WarehouseLists = allWarehouseData
                    .SelectMany(warehouseLists => warehouseLists.WarehouseList_Areas
                    .SelectMany(warehouseList_Areas => warehouseList_Areas.WarehouseList_Shelves
                    .SelectMany(warehouseList_Shelves => warehouseList_Shelves.StockItemLists.Any() != true ?
                        new[] { new Join_Warehouse(
                            warehouseList_Shelves._Id,
                            warehouseLists.CityList._City,
                            warehouseLists._Name,
                            warehouseList_Areas._Area,
                            warehouseList_Shelves._No,
                            warehouseList_Shelves._IsStock,
                            null
                        )} :
                        warehouseList_Shelves.StockItemLists.Select(stockItemLists =>
                            new Join_Warehouse
                            (
                                warehouseList_Shelves._Id,
                                warehouseLists.CityList._City,
                                warehouseLists._Name,
                                warehouseList_Areas._Area,
                                warehouseList_Shelves._No,
                                warehouseList_Shelves._IsStock,
                                stockItemLists._Id
                            ))
                    ))).ToList();
            }
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
                    dataGridView_WarehouseLists.DataSource = join_WarehouseLists.Where(x => x._AreaNo == int.Parse(comboBox_Area.SelectedValue.ToString())).ToList();
                }
            }
        }
        private void ComboBoxCityChanged() 
        {
            ComboBox_NameData();
        }
        private void ComboBox_NameData()
        {
            if (comboBox_City.Text != "全体")
            {
                List<string> nameLists = join_WarehouseLists.Where(x => x._City == comboBox_City.Text).Select(x=> x._Name).Distinct().ToList();
                nameLists.Insert(0, "全体");
                comboBox_Name.DataSource = nameLists;
                comboBox_Name.Enabled = true;
                ComboBox_AreaData();
                dataGridView_WarehouseLists.DataSource = join_WarehouseLists.Where(x => x._Name == comboBox_Name.Text).Distinct().ToList();
            }
            else 
            {
                comboBox_Name.DataBindings.Clear();
                comboBox_Name.Enabled = false;
            }
        }
        private void ComboBox_AreaData()
        {
            if (comboBox_Name.Text != "全体")
            {
                List<int> areaLists = join_WarehouseLists.Where(x => x._City == comboBox_City.Text && x._Name == comboBox_Name.Text).Select(x => x._AreaNo).ToList();
                comboBox_Area.DataSource = areaLists;
            }
            else 
            {
                comboBox_Area.Enabled = false;
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
                if (selectedWarehouse != null)
                {
                    pictureViewer.Mode_LoadPicture(selectedWarehouse._ImagePath);
                }
                else
                {
                    pictureViewer.Mode_LoadPicture(null);
                }

            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button_Add_Warehouse_Click(object sender, EventArgs e)
        {
            OpenWL();
        }

        private void OpenWL()
        {
            Add_Warehouse_DefaultInfo wl = new Add_Warehouse_DefaultInfo();
            wl.Owner = this;
            /*
            wl.Load += (order, s) => this.Enabled = false;
            wl.FormClosed += (order, s) => this.Enabled = true;
            */
            wl.Show();
        }

        private void pictureBox_Image_Click(object sender, EventArgs e)
        {

        }

        //DataGridView Settings
        private void dataGridView_format(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView_WarehouseLists.Columns["_Id"].HeaderText = "ID";
            dataGridView_WarehouseLists.Columns["_City"].HeaderText = "地域";
            dataGridView_WarehouseLists.Columns["_Name"].HeaderText = "倉庫名";
            dataGridView_WarehouseLists.Columns["_AreaNo"].HeaderText = "置場区分";
            dataGridView_WarehouseLists.Columns["_ShelfNo"].HeaderText = "棚";
            dataGridView_WarehouseLists.Columns["_IsStock"].Visible = false;
            dataGridView_WarehouseLists.Columns["_AddedItem"].HeaderText = "使用状態";
        }
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_WarehouseLists.Columns[e.ColumnIndex].Name == "_AddedItem")
            {
                if (e.Value != null && e.CellStyle != null)
                {
                    int stockStatus = (int)e.Value;
                    if (stockStatus == 0)
                    {
                        e.CellStyle.BackColor = Color.Blue;
                        e.CellStyle.ForeColor = Color.Blue;
                    }
                    else if (stockStatus == 1)
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void dataGridView_WarehouseLists_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView_WarehouseLists.Cursor = Cursors.Hand;
            }
            else
            {
                dataGridView_WarehouseLists.Cursor = Cursors.Default;
            }
        }

        private void dataGridView_WarehouseLists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView_WarehouseLists.Columns[e.ColumnIndex].Name == "_Name")
                {
                    string clickedCellValue = dataGridView_WarehouseLists.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    MessageBox.Show(clickedCellValue);
                }
            }
        }
    }
}
