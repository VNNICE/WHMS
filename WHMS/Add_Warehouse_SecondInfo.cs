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
        private static int searcher = 0;
        private string targetWarehouseId = Add_Warehouse_DefaultInfo.targetWarehouse;
        public Add_Warehouse_SecondInfo()
        {
            InitializeComponent();
        }
        

        public void LoadWarehouseInfo()
        {
            
            using (var context = new DatabaseContext())
            {
                var targetWarehouse = context.WarehouseLists.Include(x => x.WarehouseList_Areas).FirstOrDefault(x => x._Id == targetWarehouseId);
                if (targetWarehouse != null)
                {
                    textBox_Name.Text = targetWarehouse._Name.ToString();
                    var areaLists = targetWarehouse.WarehouseList_Areas.Select(x => x._Area).ToList();
                    int nowcount = areaLists[searcher];
                    textBox_SelectedArea.Text = nowcount.ToString();
                }
            }
        }
        public void SetAArea2(string areaId, int counter)
        {
            using (var context = new DatabaseContext())
            {
                var selectedArea = context.WarehouseList_Areas.Find(areaId);
                if (textBox_SelectedArea.Text != null)
                for (int i = 0; i <= counter; i++)
                {
                    selectedArea.
                }
            }

        }
        public void AreaSearcher(int maxcount)
        {
            searcher ++;
            if (searcher == maxcount - 1)
            {
                MessageBox.Show("全置場設定完了");
                this.Close();
            }
        }
        
    }
}
