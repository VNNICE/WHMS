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

        private int id;
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
            this.Size = new Size(204, 348);
            button_DisplayMemo.Click += (sender, e) => DisplayMemo();
            button_Decide.Click += (sender, e) => AddData();
        }
        private void AddData()
        {
            SerializeText();
            AddItemData();
        }

        private void DisplayMemo() 
        {
            
            if (!onClickMemo)
            {
                onClickMemo = true;
                button_DisplayMemo.Text = "＜＜備考登録";
                this.Size = new Size(440, 348);
                richTextBox_Memo.Enabled = true;
            }
            else
            {
                onClickMemo = false;
                button_DisplayMemo.Text = "備考登録＞＞";
                this.Size = new Size(204, 348);
                richTextBox_Memo.Enabled = false;
            }
        }
        private void AddItemData()
        {
            int idCnt;
            if (_context.ItemLists.Any())
            {
                idCnt = _context.ItemLists.Select(x=>x._Id).LastOrDefault();
            }
            else
            {
                idCnt = 0;
            }
            try
            {
                ItemList itemList = new ItemList(idCnt, obj, type, assetType, name, manufacturer, serialNumber, price, quantity, memo);
                _context.ItemLists.Add(itemList);
                _context.SaveChanges();
                MessageBox.Show("保存完了!! ID: "+ idCnt);
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
                if (text_Memo.Text != null)
                {
                    memo = text_Memo.Text.ToString();
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
    }
    class InvalidValues() : Exception
    { 
    
    }
}