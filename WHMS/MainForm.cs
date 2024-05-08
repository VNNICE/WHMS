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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region DB Connection

        private void DBConnect(string strDBPath)
        {

        }

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_Add_WarehouseList_Click(object sender, EventArgs e)
        {
            View_WarehouseList_Area wla = new View_WarehouseList_Area();
            wla.ShowDialog();
        }
    }
}
