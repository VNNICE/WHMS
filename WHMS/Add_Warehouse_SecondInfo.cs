using DBMS;
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

namespace WHMS
{
    public partial class Add_Warehouse_SecondInfo : Form
    {
        private readonly DatabaseContext _context = new DatabaseContext();
        private static int searcher = 0;
        private string targetWarehouseId = Add_Warehouse_DefaultInfo.targetWarehouse;
        public Add_Warehouse_SecondInfo()
        {
            InitializeComponent();
            _context = new DatabaseContext();
            LoadWarehouseInfo();
        }


        public void LoadWarehouseInfo()
        {
            MessageBox.Show(targetWarehouseId);
            var targetWarehouse = _context.WarehouseLists.Include(x => x.WarehouseList_Areas).FirstOrDefault(x => x._Id == targetWarehouseId);
            if (targetWarehouse != null)
            {
                textBox_Name.Text = targetWarehouse._Name.ToString();
                var areaLists = targetWarehouse.WarehouseList_Areas.Select(x => x._Area).ToList();
                int nowCount = areaLists[searcher];
                textBox_SelectedArea.Text = nowCount.ToString();
            }
        }
        public void SetAArea2(string areaId, int counter, out string msg)
        {
            var selectedArea = _context.WarehouseList_Areas.Find(areaId);
            if (textBox_SelectedArea.Text != null && selectedArea != null)
            {
                for (int i = 0; i <= counter; i++)
                {
                    //selectedArea.WarehouseList_Area_Area2s.Add(new WarehouseList_Area_Area2(i, selectedArea._Id));
                }
                msg = $"置場区分2{counter}まで生成完了";
            }
            else
            {
                msg = "入力値エラー";
            }
        }
        public void AreaSearcher(int maxcount)
        {
            searcher++;
            if (searcher == maxcount + 1)
            {
                MessageBox.Show("全置場設定完了");
                this.Close();
            }
        }
    }
}
