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

namespace WHMS
{
    public partial class Add_AdminList_Name : Form
    {
        private readonly DatabaseContext _context = new DatabaseContext();
        private AdminList selectedGroup;
        public Add_AdminList_Name()
        {
            InitializeComponent();
            LoadRegionData();
            button_AddAdmin.Click += (o, e) => GoToAddAdmin();
            comboBox_Group.Enabled = false;
            comboBox_Region.SelectedIndexChanged += (o, e) => LoadGroupData();
            LoadGroupData();
            button_Decide.Click += (o, e) => AddAdministrator();
            button_Cancel.Click += (o, e) => this.Close();
        }

        private void AddAdministrator() 
        {
            string name = textBox_Name.Text.ToString();
            int cnt = _context.AdminList_Names.Count() + 1;
            selectedGroup = _context.AdminLists.Find(comboBox_Group.SelectedValue.ToString());
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("名前を確認してください。");
                return;
            }
            else if (selectedGroup == null)
            {
                MessageBox.Show("正しいグループを選択してください。");
                return;
            }
            else
            {
                string groupId = selectedGroup._Id;
                string id = groupId + cnt.ToString("D3");
                AdminList_Name data = new AdminList_Name(id, groupId, name);
                _context.Add(data);
                _context.SaveChanges();
                this.Close();
            }
        }

        private void LoadRegionData() 
        {
            if (_context.AdminLists != null && _context.AdminLists.Any())
            {
                comboBox_Region.DataSource = _context.AdminLists.Select(x => x._Region).Distinct().ToList();
            }
            else 
            {
                comboBox_Region.Enabled = false;
                comboBox_Region.Text = "データなし";
            }
        }
        private void LoadGroupData()
        {
            if (_context.AdminLists != null && _context.AdminLists.Any())
            {
                var data = _context.AdminLists.Where(x => x._Region == comboBox_Region.Text).Distinct().ToList();
                if (data != null)
                {
                    comboBox_Group.Enabled = true;
                    comboBox_Group.DataSource = data;
                    comboBox_Group.DisplayMember = "_Group";
                    comboBox_Group.ValueMember = "_Id";
                }
                else
                {
                    comboBox_Group.Enabled = false;
                }
            }
        }
        private void GoToAddAdmin()
        {
            Add_AdminList al = new Add_AdminList();
            al.StartPosition = FormStartPosition.Manual;
            al.Location = this.Location;
            this.Enabled = false;
            al.Closed += (o, e) =>
            {
                LoadRegionData();
                LoadGroupData();
                this.Enabled = true;
            };
            al.Show();
        }
    }
}
