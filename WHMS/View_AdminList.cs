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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WHMS
{
    public partial class View_AdminList : Form
    {
        private readonly DatabaseContext _context = new DatabaseContext();
        private List<Join_AdminList> Join_AdminLists = new List<Join_AdminList>();

        public event EventHandler<string>? senderId;
        public event EventHandler<bool>? senderBool;
        public View_AdminList(bool selectionMode)
        {
            InitializeComponent();
            DefaultSettings();
            comboBox_RegionList.SelectedIndexChanged += (o, e) =>
            {
                LoadComboBox_GroupData();
                LoadGridViewData();
            };
            comboBox_SortGroup.SelectedIndexChanged += (o, e) => LoadGridViewData();
            if (selectionMode)
            {
                SelectionMode();
            }
        }
        private void DefaultSettings()
        {
            button_GoToAddAdmin.Click += (o, s) =>
            {
                Add_AdminList_Name aln = new Add_AdminList_Name();
                aln.StartPosition = FormStartPosition.Manual;
                aln.Location = this.Location;
                aln.FormClosed += (o, e) =>
                {
                    LoadComboBox_RegionData();
                    LoadComboBox_GroupData();
                    LoadGridViewData();
                };
                aln.Show();
            };
            button_Back.Click += (o, e) => this.Close();
            // Default Load 
            LoadComboBox_RegionData();
            LoadGridViewData();

        }

        //Load ComboBox Data
        private void LoadComboBox_RegionData()
        {
            if (_context.AdminList_Names != null && _context.AdminList_Names.Any())
            {
                var RegionLists = _context.AdminLists.Select(x=>x._Region).Distinct().ToList();
                RegionLists.Insert(0, "全体");
                comboBox_RegionList.DataSource = RegionLists;
            }
        }
        private void LoadComboBox_GroupData()
        {
            if (comboBox_RegionList.Items != null)
            {
                if (comboBox_RegionList.Text == "全体")
                {
                    comboBox_SortGroup.Enabled = false;
                    comboBox_SortGroup.DataSource = null;
                }
                else
                {
                    comboBox_SortGroup.Enabled = true;
                    var GroupLists = _context.AdminLists.Where(x => x._Region == comboBox_RegionList.Text).Select(x => x._Group).Distinct().ToList();//Join_AdminLists.Where(x => x._Region == comboBox_RegionList.Text).Select(x => x._Group).Distinct().ToList();
                    GroupLists.Insert(0, "全体");
                    comboBox_SortGroup.DataSource = GroupLists;
                }
            }
        }
        //DataGridView
        private void LoadGridViewData()
        {
            if (_context.AdminList_Names.Any() && _context.AdminList_Names != null)
            {
                var allTargetLists = _context.AdminList_Names.Include(x => x.AdminList).Select(x => new
                {
                    x._Id,
                    x.AdminList._Region,
                    x.AdminList._Group,
                    x._Name
                }).ToList();
                if (comboBox_RegionList.Text == "全体" || string.IsNullOrWhiteSpace(comboBox_RegionList.Text))
                {
                    dataGridView.DataSource = allTargetLists;
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(comboBox_SortGroup.Text) || comboBox_SortGroup.Text == "全体")
                    {
                        dataGridView.DataSource = allTargetLists.Where(x => x._Region == comboBox_RegionList.Text).ToList();
                    }
                    else
                    {
                        dataGridView.DataSource = allTargetLists.Where(x => x._Region == comboBox_RegionList.Text && x._Group == comboBox_SortGroup.Text).ToList();
                    }
                }
                dataGridView.ReadOnly = true;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView.Columns["_Id"].HeaderText = "ID";
                dataGridView.Columns["_Region"].HeaderText = "管轄";
                dataGridView.Columns["_Group"].HeaderText = "グループ";
                dataGridView.Columns["_Name"].HeaderText = "氏名";
            }
        }
        private void GridViewDataBinding()
        {


        }

        private void SelectionMode()
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.CellDoubleClick += (sender, e) =>
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    int clicked = e.RowIndex;
                    string id = dataGridView.Rows[clicked].Cells["_Id"].Value.ToString();
                    string name = dataGridView.Rows[clicked].Cells["_Id"].Value.ToString();
                    DialogResult result = MessageBox.Show($"ID: {id}, 氏名:{name}の情報をを入力しますか？", "データ入力確認", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        senderId?.Invoke(this, id);
                        senderBool?.Invoke(this, true);
                        this.Close();
                    }
                    else if (result == DialogResult.No)
                    {
                    }
                    else if (result == DialogResult.Cancel)
                    {

                    }
                }

            };
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}