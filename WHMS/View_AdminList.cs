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
    public partial class View_AdminList : Form
    {
        private readonly DatabaseContext _context = new DatabaseContext();
        private List<Join_AdminList> Join_AdminLists;
        public View_AdminList()
        {
            InitializeComponent();
            button_GoToAddAdmin.Click += (o, s) => GoToAddAdmin();
            LoadGridViewData();
        }

        private void GoToAddAdmin() 
        {
            Add_AdminList_Name aln = new Add_AdminList_Name();
            aln.StartPosition = FormStartPosition.Manual;
            aln.Location = this.Location;
            aln.Show();
        }
        private void LoadGridViewData() 
        {
            var data = _context.AdminLists.Include(a => a.AdminList_Names).ToList();
            Join_AdminLists = data.SelectMany(al => al.AdminList_Names.Select(an => new Join_AdminList(an._Id, al._Region, al._Group, an._Name))).ToList();
            dataGridView.DataSource = Join_AdminLists;

        }
        private void GridViewData() 
        {
            
            
        }
    }
}