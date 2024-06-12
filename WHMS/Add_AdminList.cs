using DBMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranslationToolClass;

namespace WHMS
{
    public partial class Add_AdminList : Form
    {
        private readonly DatabaseContext _context = new DatabaseContext();
        string id;
        string region;
        string group;
        

        public Add_AdminList()
        {
            InitializeComponent();
            try
            {
                LoadRegionData();
                LoadGroupData();
                ButtonsSettings();
                textBox_Initial.LostFocus += (o, s) => LoadInitial();
                textBox_Initial.KeyPress += InitialRule;
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }

        }
        private void AddAdminList()
        {
            region = comboBox_Region.Text.ToString();
            group = comboBox_Group.Text.ToString();
            string initial = textBox_Initial.Text.ToString();
            id = comboBox_Region.SelectedValue.ToString().ToUpper()[0].ToString() + initial;
            // Check the Group.
            if (string.IsNullOrWhiteSpace(group))
            {
                MessageBox.Show("グループが空欄です。");
                return;
            }
            else if (_context.AdminLists.Where(x=>x._Region == region).Select(x=>x._Group).Contains(group))
            {
                MessageBox.Show("すでに登録されているグループです。");
                return;
            }
            // Check the Initial.
            if (string.IsNullOrWhiteSpace(initial))
            {
                MessageBox.Show("略字が空欄です。");
                return;
            }
            else if (_context.AdminLists.Select(x => x._Id).Contains(id.Substring(0, 3 )))
            {
                MessageBox.Show("すでに登録されている略字です。");
                return;
            }
            else 
            {
                AdminList al = new AdminList(id, region, group);
                _context.Add(al);
                _context.SaveChanges();
                MessageBox.Show($"{{ID = {{{id}}}　として登録されました。}}");
                this.Close();
            }

        }

        private void LoadRegionData()
        {
            comboBox_Region.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Region.DataSource = _context.CityLists.ToList();
            comboBox_Region.DisplayMember = "_City";
            comboBox_Region.ValueMember = "_Code";
            
        }
        private void LoadGroupData() 
        {
            if (_context.AdminLists != null && _context.AdminLists.Any()) 
            {
                comboBox_Group.DataSource = _context.AdminLists.Select(x => x._Group).ToList();
            }
        }
        private void LoadInitial() 
        {
            if (!string.IsNullOrWhiteSpace(textBox_Initial.Text))
            {
                textBox_Initial.Text = textBox_Initial.Text.ToUpper();
                if (textBox_Initial.Text.Length == 3) 
                {
                    textBox_Initial.Text = textBox_Initial.Text.Substring(0, 2);
                }
            }
        }
        private void InitialRule(object sender, KeyPressEventArgs e) 
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (textBox_Initial.Text.Length > 2 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ButtonsSettings() 
        {
            button_Decide.Click += (o, s) => AddAdminList();
            button_Cancle.Click += (o, s) => this.Close();
        }
    }
}
