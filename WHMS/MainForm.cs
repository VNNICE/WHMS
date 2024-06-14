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
            button_WhManager.Click += (sender, e) => GoToWarehouseManager();
            button_AdminManager.Click += (sender, e) => GoToAdminManager();
        }


        private void GoToWarehouseManager()
        {
            View_WarehouseList_Area wla = new View_WarehouseList_Area();
            wla.Closed += (order, s) => this.Visible = true;
            wla.Load += (order, s) => this.Visible = false;
            wla.StartPosition = FormStartPosition.Manual;
            wla.Location = this.Location;
            wla.Show();
        }
        private void GoToItemManager()
        {
            View_ItemList itemForm = new View_ItemList();
            itemForm.Closed += (order, s) => this.Visible = true;
            itemForm.Load += (order, s) => this.Visible = false;
            itemForm.StartPosition = FormStartPosition.Manual;
            itemForm.Location = this.Location;
            itemForm.Show();
        }
        private void GoToAdminManager()
        {
            View_AdminList AdminForm = new View_AdminList(false);
            AdminForm.Closed += (order, s) => this.Visible = true;
            AdminForm.Load += (order, s) => this.Visible = false;
            AdminForm.StartPosition = FormStartPosition.Manual;
            AdminForm.Location = this.Location;
            AdminForm.Show();
        }

    }
}
