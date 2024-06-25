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
using Microsoft.EntityFrameworkCore;


namespace WHMS
{
    public partial class View_ItemList : Form
    {
        private DataGridViewButtonColumn bc = new DataGridViewButtonColumn();
        private readonly DatabaseContext _context = new DatabaseContext();
        public View_ItemList()
        {
            InitializeComponent();
            button_New.Click += (o, s) => OpenAddItem();
            button_Close.Click += (o, s) => this.Close();
            GridViewRefresh();
        }
        public void GridViewRefresh()
        {
            if (_context.ItemLists != null && _context.ItemLists.Any())
            {
                dataGridView.ReadOnly = true;
                var itemLists = _context.ItemLists
                    .Include(x => x.AdminList_Name)
                    .Include(x => x.Item_Object)
                    .Include(x => x.Item_Type)
                    .Include(x => x.Item_AssetType)
                    .Include(x => x.WarehouseList_Shelf)
                    .Select(x => new
                    {
                        x._Id,
                        AdminList_Name = x.AdminList_Name.AdminList._Group + x.AdminList_Name._Name,
                        Item_Object = x.Item_Object._Object,
                        Item_Type = x.Item_Type._Type,
                        Item_AssetType = x.Item_AssetType._AssetType,
                        x._Name,
                        x._Manufacturer,
                        x._SerialNumber,
                        x._Price,
                        x._Quantity,
                        x._Memo,
                        WarehouseList_Shelf = x.WarehouseList_Shelf._Id
                    }).ToList();
                var viewLists =

                dataGridView.DataSource = itemLists;
                dataGridView.Columns["_Id"].HeaderText = "ID";
                dataGridView.Columns["AdminList_Name"].HeaderText = "使用目的";
                dataGridView.Columns["Item_Type"].HeaderText = "種類";
                dataGridView.Columns["Item_AssetType"].HeaderText = "資産管理";
                dataGridView.Columns["_Name"].HeaderText = "品目";
                dataGridView.Columns["_Manufacturer"].HeaderText = "メーカー";
                dataGridView.Columns["_SerialNumber"].HeaderText = "型番";
                dataGridView.Columns["_Price"].HeaderText = "価格";
                dataGridView.Columns["_Quantity"].HeaderText = "数量";
                dataGridView.Columns["_Memo"].HeaderText = "メモ";
                dataGridView.Columns["WarehouseList_Shelf"].HeaderText = "保管先";
            }
        }
        
        public void GridViewData() 
        {
            GridViewRefresh();
            dataGridView.CellClick += (s, e) =>
            {
                string? selectId;
                if (e.ColumnIndex == dataGridView.Columns["WarehouseShelf_Id"].Index && e.RowIndex >= 0)
                {
                    var cellValue = dataGridView.Rows[e.RowIndex].Cells["WarehouseShelf_Id"].Value;
                    if (cellValue == null || string.IsNullOrEmpty(cellValue.ToString()))
                    {
                        selectId = dataGridView.Rows[e.RowIndex].Cells["_Id"].Value.ToString();
                        if (!string.IsNullOrEmpty(selectId))
                        {
                            MessageBox.Show(selectId);
                        }
                    }
                }
            };
            dataGridView.CellFormatting += (o, e) =>
            {
                if (e.ColumnIndex == dataGridView.Columns["WarehouseShelf_Id"].Index)
                {
                    if (e.CellStyle != null && dataGridView.Rows[e.RowIndex].Cells["WarehouseShelf_Id"].Value == null)
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.SelectionForeColor = Color.Blue;
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Underline);
                    }
                }
            };
        }

        private void OpenAddItem()
        {
            Add_ItemList itemAddForm = new Add_ItemList();
            itemAddForm.FormClosed += (o, s) => GridViewRefresh();
            itemAddForm.Show();
        }
    }
}