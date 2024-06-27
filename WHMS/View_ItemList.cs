using System;
using System.Collections;
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
        private List<ItemList>? allItemListData;
        private List<Join_ItemLists> join_ItemLists = new List<Join_ItemLists>();

        public View_ItemList()
        {
            InitializeComponent();

            DefaultSettings();

            dataGridView.ReadOnly = true;
            dataGridView.DataBindingComplete += (o, e) => GridViewFormat();

            button_New.Click += (o, s) => OpenAddItem();
            button_Close.Click += (o, s) => this.Close();
            GridViewRefresh();
        }
        private void DefaultSettings() 
        {
            DataBindingAllItemListData();
            GridViewRefresh();
        }

        private void DataBindingAllItemListData()
        {
            if (_context.ItemLists != null && _context.ItemLists.Any())
            {
                allItemListData = _context.ItemLists.Include(x=>x.AdminList_Name).ThenInclude(x=>x.AdminList).Include(x=>x.Item_Object).Include(x=>x.Item_Type).Include(x=>x.Item_AssetType).Include(x=>x.AssetManagementList).Include(x=>x.StockItemLists).ToList();
                join_ItemLists = allItemListData.SelectMany(itemLists => itemLists.StockItemLists != null ?
                new[] { new Join_ItemLists(
                itemLists._Id,
                $"[{itemLists.AdminList_Name.AdminList._Group}] {itemLists.AdminList_Name._Name}",
                itemLists.Item_Object._Object,
                itemLists.Item_Type._Type,
                        itemLists.Item_AssetType._AssetType,
                        itemLists.AssetManagementList_Id,
                        itemLists._Name,
                        itemLists._Manufacturer,
                        itemLists._SerialNumber,
                        itemLists._PurchaseDate,
                        itemLists._Price,
                        itemLists._Quantity,
                        itemLists._Memo,
                        null
                    ) } :
                itemLists.StockItemLists.Select(stockItemLists =>
                                new Join_ItemLists(
                itemLists._Id,
                $"[{itemLists.AdminList_Name.AdminList._Group}] {itemLists.AdminList_Name._Name}",
                itemLists.Item_Object._Object,
                itemLists.Item_Type._Type,
                        itemLists.Item_AssetType._AssetType,
                        itemLists.AssetManagementList_Id,
                        itemLists._Name,
                        itemLists._Manufacturer,
                        itemLists._SerialNumber,
                        itemLists._PurchaseDate,
                        itemLists._Price,
                        itemLists._Quantity,
                        itemLists._Memo,
                        null
                    ))).ToList();    
                // foreach Ver.
                /* 
                foreach (var lists in allItemListData)
                {
                    if (!lists.StockItemLists.Any())
                    {
                        join_ItemLists.Add(new Join_ItemLists(
                        lists._Id,
                        $"[{lists.AdminList_Name.AdminList._Group}] {lists.AdminList_Name._Name}",
                        lists.Item_Object._Object,
                        lists.Item_Type._Type,
                        lists.Item_AssetType._AssetType,
                        lists.AssetManagementList_Id,
                        lists._Name,
                        lists._Manufacturer,
                        lists._SerialNumber,
                        lists._PurchaseDate,
                        lists._Price,
                        lists._Quantity,
                        lists._Memo,
                        null));
                    }
                    else
                    {
                        foreach (var stocks in lists.StockItemLists)
                        {
                            join_ItemLists.Add(new Join_ItemLists(
                            lists._Id,
                            $"[{lists.AdminList_Name.AdminList._Group}] {lists.AdminList_Name._Name}",
                            lists.Item_Object._Object,
                            lists.Item_Type._Type,
                            lists.Item_AssetType._AssetType,
                            lists.AssetManagementList_Id,
                            lists._Name,
                            lists._Manufacturer,
                            lists._SerialNumber,
                            lists._PurchaseDate,
                            lists._Price,
                            lists._Quantity,
                            lists._Memo,
                            stocks.ItemList_Id
                            ));
                        }
                    }
                }*/
            }
        }

        public void GridViewRefresh()
        {
            dataGridView.DataSource = join_ItemLists;
        }
        
        public void GridViewData() 
        {
            GridViewRefresh();
            dataGridView.CellClick += (s, e) =>
            {
                string? selectId;
                if (e.ColumnIndex == dataGridView.Columns["WarehouseShelf_Id"].Index && e.RowIndex >= 0)
                {
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
                    var cellValue = dataGridView.Rows[e.RowIndex].Cells["WarehouseShelf_Id"].Value;
                    if (cellValue == null || string.IsNullOrEmpty(cellValue.ToString()))
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

        private void GridViewFormat() 
        {
            dataGridView.Columns["_Id"].HeaderText = "ID";
            dataGridView.Columns["AdminGroupAndName"].HeaderText = "管理者";
            dataGridView.Columns["Item_Object"].HeaderText = "使用目的";
            dataGridView.Columns["Item_Type"].HeaderText = "種類";
            dataGridView.Columns["Item_AssetType"].HeaderText = "資産管理";
            dataGridView.Columns["AssetManagementList_Id"].HeaderText = "管理No.";
            dataGridView.Columns["_Name"].HeaderText = "品目";
            dataGridView.Columns["_Manufacturer"].HeaderText = "メーカー";
            dataGridView.Columns["_SerialNumber"].HeaderText = "型番";
            dataGridView.Columns["_Price"].HeaderText = "価格";
            dataGridView.Columns["_Quantity"].HeaderText = "数量";
            dataGridView.Columns["_Memo"].HeaderText = "メモ";
            dataGridView.Columns["StockedItemList_Area"].HeaderText = "保管先";
        }
    }
}