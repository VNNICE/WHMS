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
    public partial class View_AdminList : Form
    {
        public View_AdminList()
        {
            InitializeComponent();
            button_GoToAddAdmin.Click += (o, s) => GoToAddAdmin();
        }

        private void GoToAddAdmin() 
        {
            Add_AdminList_Name aln = new Add_AdminList_Name();
            aln.StartPosition = FormStartPosition.Manual;
            aln.Location = this.Location;
            aln.Show();
        }

    }
}
