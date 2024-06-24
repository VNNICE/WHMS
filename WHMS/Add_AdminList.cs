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
        private readonly InputRules inputRules = new InputRules();
        string id;
        string region;
        string group;


        public Add_AdminList()
        {
            InitializeComponent();
            try
            {
                LoadRegionData();
                ButtonsSettings();
                LoadGridViewData();
                comboBox_Region.SelectedIndexChanged += (o, s) => LoadGridViewData();
                inputRules.Rule_Initial(textBox_Initial);
            }
            catch
            {
                MessageBox.Show("ERROR!");
            }

        }
        private void AddAdminList()
        {
            region = comboBox_Region.Text.ToString();
            group = textBox_Group.Text.ToString();
            string initial = textBox_Initial.Text.ToString();
            // Check the Group.
            if (region == "全体")
            {
                MessageBox.Show("正しい管轄を選んでください。");
                return;
            }
            if (string.IsNullOrWhiteSpace(group))
            {
                MessageBox.Show("グループが空欄です。");
                return;
            }
            else if (_context.AdminLists.Where(x => x._Region == region).Select(x => x._Group).Contains(group))
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
            else
            {
                id = comboBox_Region.SelectedValue.ToString().ToUpper().ToString() + initial;
                if (_context.AdminLists.Select(x => x._Id).Contains(id.Substring(0, 4)))
                {
                    MessageBox.Show("すでに登録されている略字です。");
                    return;
                }
                AdminList al = new AdminList(id, region, group);
                _context.Add(al);
                _context.SaveChanges();
                MessageBox.Show($"{{ID = {{{id}}}　として登録されました。}}");
                this.Close();
            }

        }
        private void LoadGridViewData()
        {
            if (_context.AdminLists != null && _context.AdminLists.Any())
            {
                if (string.IsNullOrWhiteSpace(comboBox_Region.SelectedValue.ToString()))
                {
                    dataGridView.DataSource = _context.AdminLists.ToList();
                }
                else
                {
                    dataGridView.DataSource = _context.AdminLists.Where(x => x._Region == comboBox_Region.Text.ToString()).ToList();
                }
                dataGridView.Columns["_Id"].HeaderText = "ID";
                dataGridView.Columns["_Region"].HeaderText = "地域";
                dataGridView.Columns["_Group"].HeaderText = "グループ";
                dataGridView.Columns["AdminList_Names"].Visible = false;

            }

        }
        private void LoadRegionData()
        {
            comboBox_Region.DropDownStyle = ComboBoxStyle.DropDownList;
            var data = _context.CityLists.ToList();
            data.Insert(0, new CityList("", "全体"));
            comboBox_Region.DataSource = data;
            comboBox_Region.DisplayMember = "_City";
            comboBox_Region.ValueMember = "_Code";

        }

        private void ButtonsSettings()
        {
            button_Decide.Click += (o, s) => AddAdminList();
            button_Cancel.Click += (o, s) => this.Close();
        }
    }
}
