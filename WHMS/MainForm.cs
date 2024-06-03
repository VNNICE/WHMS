using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WHMS
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            button_ItemManager.Click += (sender, e) => GoToItemManager(); 
        }


        private void button_Add_WarehouseList_Click(object sender, EventArgs e)
        {
            View_WarehouseList_Area wla = new View_WarehouseList_Area();
            wla.Closed += (order, s) => this.Visible = true;
            wla.Load += (order, s) => this.Visible = false;
            wla.Show();
        }
        private void GoToItemManager()
        {
            Add_ItemList itemForm = new Add_ItemList();
            itemForm.Closed += (order, s) => this.Visible = true;
            itemForm.Load += (order, s) => this.Visible = false;
            itemForm.Show();
        }

    }
}
