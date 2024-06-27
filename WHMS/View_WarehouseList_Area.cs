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
        private List<Join_Warehouse>? join_WarehouseLists;
        private List<WarehouseList>? allWarehouseData;
        PictureViewer pictureViewer = new PictureViewer();
        
        public View_WarehouseList_Area()
        {
            InitializeComponent();
            DefaultSettings();
            comboBox_Name.Enabled = false;
            comboBox_Area.Enabled = false;
            button_Add_Warehouse.Click += (o, e) => ShowWarehouseAdd();

            dataGridView_WarehouseLists.DataBindingComplete += (o, e) => dataGridView_Format();
            dataGridView_WarehouseLists.CellFormatting += dataGridView_CellFormatting;
            dataGridView_WarehouseLists.CellMouseMove += new DataGridViewCellMouseEventHandler(dataGridView_WarehouseLists_CellMouseMove);

            comboBox_City.SelectedIndexChanged += (o, e) => ComboBoxCityChanged();
            comboBox_Name.SelectedIndexChanged += (o, e) => ComboBoxNameChanged();
            comboBox_Area.SelectedIndexChanged += (o, e) => ComboBoxAreaChanged();

            pictureViewer.Show();
            pictureViewer.SetADefaultDataPictureBox(this);
        }
        private void DefaultSettings() 
        {
            AllWareHouseData();
            if (join_WarehouseLists != null && join_WarehouseLists.Any())
            {
                List<string> cityLists = join_WarehouseLists.Select(x => x._City).Distinct().ToList();
                cityLists.Insert(0, "全体");
                comboBox_City.DataSource = cityLists;
            }
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
                                stockItemLists._Id
                            ))
                    ))).ToList();
            }
        }

        private void ComboBoxCityChanged() 
        {
            if (comboBox_City.Text == "全体")
            {
                comboBox_Name.DataSource = null;
                comboBox_Name.Enabled = false;
                comboBox_Area.DataSource = null;
                comboBox_Area.Enabled = false;
                dataGridView_WarehouseLists.DataSource = join_WarehouseLists;
            }
            else
            {
                var nameLists = join_WarehouseLists.Where(x => x._City == comboBox_City.Text).Select(x => x._Name).Distinct().ToList();
                if (nameLists.Any() && nameLists != null) 
                {
                    nameLists.Insert(0, "全体");
                    comboBox_Name.DataSource = nameLists;
                    comboBox_Name.Enabled = true;
                    dataGridView_WarehouseLists.DataSource = join_WarehouseLists.Where(x => x._City == comboBox_City.Text).Distinct().ToList();
                }
            }
        }
        private void ComboBoxNameChanged()
        {
            if (comboBox_Name.Text == "全体")
            {
                comboBox_Area.DataSource = null;
                comboBox_Area.Enabled = false;
                ComboBoxCityChanged();
            }
            else 
            {
                var areaLists = join_WarehouseLists.Where(x => x._City == comboBox_City.Text && x._Name == comboBox_Name.Text).Select(x => x._AreaNo.ToString()).Distinct().ToList();
                if (areaLists.Any() && areaLists != null) 
                {
                    areaLists.Insert(0, "全体");
                    comboBox_Area.DataSource = areaLists;
                    comboBox_Area.Enabled = true;
                    dataGridView_WarehouseLists.DataSource = join_WarehouseLists.Where(x => x._City == comboBox_City.Text && x._Name == comboBox_Name.Text).ToList();
                }
            }
        }
        private void ComboBoxAreaChanged()
        {
            if (comboBox_Area.Text == "全体")
            {
                ComboBoxNameChanged();
            }
            else 
            {
                dataGridView_WarehouseLists.DataSource = join_WarehouseLists.Where(x => x._City == comboBox_City.Text && x._Name == comboBox_Name.Text && x._AreaNo == int.Parse(comboBox_Area.Text)).Distinct().ToList();
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

        private void ShowWarehouseAdd()
        {
            Add_Warehouse_DefaultInfo wl = new Add_Warehouse_DefaultInfo();
            wl.Owner = this;
            wl.FormClosed += (o, e) => DefaultSettings();
            wl.Show();
        }

        private void pictureBox_Image_Click(object sender, EventArgs e)
        {

        }

        //DataGridView Settings
        private void dataGridView_Format()
        {
            dataGridView_WarehouseLists.Columns["_Id"].HeaderText = "ID";
            dataGridView_WarehouseLists.Columns["_City"].HeaderText = "地域";
            dataGridView_WarehouseLists.Columns["_Name"].HeaderText = "倉庫名";
            dataGridView_WarehouseLists.Columns["_AreaNo"].HeaderText = "置場区分";
            dataGridView_WarehouseLists.Columns["_ShelfNo"].HeaderText = "棚";
            dataGridView_WarehouseLists.Columns["_AddedItem"].HeaderText = "保管物品";
        }
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_WarehouseLists.Columns[e.ColumnIndex].Name == "_AddedItem")
            {
                if (e.Value == null && e.CellStyle != null)
                {
                    e.CellStyle.BackColor = Color.Blue;
                    e.CellStyle.ForeColor = Color.Blue;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.Red;
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
