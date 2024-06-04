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

        public Add_ItemList()
        {
            InitializeComponent();
            this.Size = new Size(204, 348);
            button_DisplayMemo.Click += (sender, e) => DisplayMemo();
        }

        private void DisplayMemo() 
        {
            
            if (!onClickMemo)
            {
                onClickMemo = true;
                button_DisplayMemo.Text = "＜＜備考登録";
                this.Size = new Size(440, 348);
                
            }
            else
            {
                onClickMemo = false;
                button_DisplayMemo.Text = "備考登録＞＞";
                this.Size = new Size(204, 348);
            }
        }

        private void SerializeText()
        {
            obj = comboBox_Object.Text.ToString();
            type = comboBox_Type.Text.ToString();
            assetType = comboBox_AssetType.Text.ToString();
            name = textBox_Name.Text.ToString();
            manufacturer = comboBox_Manufacturer.Text.ToString();
            serialNumber = textBox_SerialNumber.Text.ToString();
            price = int.Parse(textBox_Price.Text);
            quantity = int.Parse(textBox_Quantity.Text);
            memo = text_Memo.Text.ToString();
        }
    }
}
