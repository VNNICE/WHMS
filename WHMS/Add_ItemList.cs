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
using Microsoft.EntityFrameworkCore;

namespace WHMS
{
    public partial class Add_ItemList : Form
    {
        private readonly DatabaseContext _context = new DatabaseContext();
        
        private bool onClickMemo = false;

        private string id;
        private string admin;
        private string obj;
        private string type;
        private string assetType;
        private string name;
        private string manufacturer;
        private string serialNumber;
        private int price;
        private int quantity;
        private string? memo;
        private string errmsg;

        public Add_ItemList()
        {
            InitializeComponent();
            this.Size = new Size(283, 444);
            
            button_DisplayMemo.Click += (sender, e) => DisplayMemo();
            button_Decide.Click += (sender, e) => AddData();
            button_RefAdmin.Click += (sender, e) => Ref_Admin();
            button_Object.Click += (sender, e) => Ref_Obj();
            DataBinding();

        }
        private void AddData()
        {
            SerializeText();
            AddItemData();
            this.Close();
        }
        private void DataBinding()
        {
            try
            {
                if (_context.ItemLists != null && _context.ItemLists.Any())
                {
                    comboBox_Manufacturer.DataSource = _context.ItemLists.Select(x => x._Manufacturer).Distinct().ToList();
                    comboBox_Manufacturer.SelectedIndex = -1;
                }
                Refresh_ItemObject();

            }
            catch(ArgumentException ae) 
            {
                MessageBox.Show(ae.ToString());
                return;
            }
        }
        public void Refresh_ItemObject() 
        {
            if (_context.Item_Objects != null && _context.Item_Objects.Any())
            {
                comboBox_Object.DataSource = _context.Item_Objects.Select(x=>x._Object).Distinct().ToList();
                comboBox_Object.SelectedIndex = -1;
            }
        }
        private void Refresh_ItemType() 
        {
            if (_context.Item_Types.Any())
            {
                comboBox_Type.DataSource = _context.Item_Types.Distinct().ToList();
                comboBox_Object.SelectedIndex = -1;
            }
        }
        private void Refresh_ItemAssetTypes() 
        {
            if (_context.Item_AssetTypes.Any())
            {
                comboBox_AssetType.DataSource = _context.Item_AssetTypes.Distinct().ToList();
                comboBox_Object.SelectedIndex = -1;
            }
        }


        private void DisplayMemo() 
        {
            
            if (!onClickMemo)
            {
                onClickMemo = true;
                button_DisplayMemo.Text = "＜＜備考登録";
                this.Size = new Size(524, 444);
                richTextBox_Memo.Enabled = true;
            }
            else
            {
                onClickMemo = false;
                button_DisplayMemo.Text = "備考登録＞＞";
                this.Size = new Size(283, 444);
                richTextBox_Memo.Enabled = false;
            }
        }
        private void AddItemData()
        {
            try
            {
                //ItemList itemList = new ItemList(id, admin, obj, type, assetType, name, manufacturer, serialNumber, price, quantity, memo);
                //_context.ItemLists.Add(itemList);
                _context.SaveChanges();
                MessageBox.Show("保存完了!! ID: "+ id);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.ToString());
                return;
            }
        }

        private void SerializeText()
        {
            errmsg = "次の入力値が無効です：\n";
            try
            {
                int idCnt;
                if (_context.ItemLists.Any())
                {
                    idCnt = _context.ItemLists.Count();
                }
                else
                {
                    idCnt = 0;
                }
                //id = + idCnt.ToString();
                //admin = 
                obj = comboBox_Object.Text.ToString();
                type = comboBox_Type.Text.ToString();
                assetType = comboBox_AssetType.Text.ToString();
                name = textBox_Name.Text.ToString();
                manufacturer = comboBox_Manufacturer.Text.ToString();
                serialNumber = textBox_SerialNumber.Text.ToString();
                if (obj == "" || type == "" || assetType == "" || name == "" || manufacturer == "" || serialNumber == "")
                {
                    throw new InvalidValues();
                }
                price = int.Parse(textBox_Price.Text);
                quantity = int.Parse(textBox_Quantity.Text);
                if (richTextBox_Memo.Text != null)
                {
                    memo = richTextBox_Memo.Text.ToString();
                }
            }
            catch (InvalidValues)
            {
                
                if (obj == "")
                {
                    errmsg += $"　{{{label_Object.Text}}}\n";
                }
                if (type == "")
                {
                    errmsg += $"　{{{label_Type.Text}}}\n";
                }
                if (assetType == "")
                {
                    errmsg += $"　{{{label_Name.Text}}}\n";
                }
                if (name == "")
                {
                    errmsg += $"　{{{label_Manufacturer.Text}}}\n";
                }
                if (serialNumber == "")
                {
                    errmsg += $"　{{{label_SerialNumber.Text}}}\n";
                }
                MessageBox.Show(errmsg);
                return;
            }
            catch (FormatException)
            {
                if (!int.TryParse(textBox_Price.Text, out int i))
                {
                    errmsg += $"　{{{label_Price.Text}}}\n";
                }
                if (!int.TryParse(textBox_Quantity.Text, out int j))
                {
                    errmsg += $"　{{{label_Quantity.Text}}}\n";
                }
                MessageBox.Show(errmsg);
                return;
            }
        }

        private void Ref_Admin() 
        {
            View_AdminList va = new View_AdminList(true);
            va.senderId += (o, s) => this.textBox_Admin.Text = s;
            va.Show();
        }
        private void Ref_Obj() 
        {
            Add_ItemProperty aip = new Add_ItemProperty(1, true);
            aip.FormClosing += (o, s) =>
            {
                DialogResult result = MessageBox.Show("入力値を入力しますか？", "確認", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Refresh_ItemObject();
                    aip.senderId += (o, s) => this.comboBox_Object.Text = s;
                    comboBox_Object.Enabled = false;
                }
                else
                {
                    Refresh_ItemObject();
                }
            };
            aip.Show();
        }
        private void Ref_Type()
        { 
        
        }
        private void Ref_AssetType() 
        {
            
        }
    }
    class InvalidValues() : Exception
    { 
    
    }

}