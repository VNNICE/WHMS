using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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
        private readonly InputRules _inputRules = new InputRules();

        private bool onClickMemo = false;

        private string? id;
        AdminList_Name? selectedAdmin;
        Item_Object? selectedObject;
        Item_Type? selectedType;
        Item_AssetType? selectedAssetType;
        private int? assetNo;
        private string? name;
        private string? manufacturer;
        private string? serialNumber;
        private int price = 0;
        private int quantity = 0;
        private string? memo;

        public Add_ItemList()
        {
            InitializeComponent();
            this.Size = new Size(283, 444);
            
            button_DisplayMemo.Click += (sender, e) => DisplayMemo();
            
            button_RefAdmin.Click += (sender, e) => Ref_Admin();
            button_RefObject.Click += (sender, e) => Ref_Obj();
            button_RefType.Click += (sender, e) => Ref_Type();
            button_RefAssetType.Click += (sender, e) => Ref_AssetType();
            button_Decide.Click += (sender, e) => AddItemData();

            _inputRules.Rule_OnlyInt(textBox_AssetNo);
            _inputRules.Rule_OnlyInt(textBox_Price);
            _inputRules.Rule_OnlyInt(textBox_Quantity);

            textBox_AssetNo.Enabled = false;

            comboBox_AssetType.TextChanged += (sender, e) => 
            {
                if (comboBox_AssetType.Text == "管理")
                {
                    textBox_AssetNo.Enabled = true;
                }
                else 
                {
                    textBox_AssetNo.Enabled = false;
                }
            };
            DataBinding();

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
                Refresh_ItemType();
                Refresh_ItemAssetTypes();
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
                comboBox_Object.DataSource = _context.Item_Objects.ToList();
                comboBox_Object.DisplayMember = "_Object";
                comboBox_Object.ValueMember = "_ObjectCode";
                comboBox_Object.SelectedIndex = -1;
            }
        }
        private void Refresh_ItemType() 
        {
            if (_context.Item_Types != null &&_context.Item_Types.Any())
            {
                comboBox_Type.DataSource = _context.Item_Types.ToList();
                comboBox_Type.DisplayMember = "_Type";
                comboBox_Type.ValueMember = "_TypeCode";
                comboBox_Type.SelectedIndex = -1;
            }
        }
        private void Refresh_ItemAssetTypes() 
        {
            if (_context.Item_AssetTypes != null && _context.Item_AssetTypes.Any())
            {
                comboBox_AssetType.DataSource = _context.Item_AssetTypes.ToList();
                comboBox_AssetType.DisplayMember = "_AssetType";
                comboBox_AssetType.ValueMember = "_AssetTypeCode";
                comboBox_AssetType.SelectedIndex = -1;
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

                SerializeText();
                ItemList itemList = new ItemList(id, selectedAdmin._Id, selectedObject._ObjectCode, selectedType._TypeCode, selectedAssetType._AssetTypeCode, null, name, manufacturer, serialNumber, DateOnly.FromDateTime(dateTimePicker.Value), price, quantity, memo, null);
                _context.ItemLists.Add(itemList);
                _context.SaveChanges();
                MessageBox.Show("保存完了!! ID: "+ id);
                this.Close();
            }
            catch (CustomException)
            {
                
            }

        }

        private void SerializeText()
        {
            try
            {
                label_Admin.ForeColor = Color.Black;
                label_Object.ForeColor = Color.Black;
                label_Type.ForeColor = Color.Black;
                label_AssetType.ForeColor = Color.Black;
                label_AssetNo.ForeColor = Color.Black;
                label_Name.ForeColor = Color.Black;
                label_Manufacturer.ForeColor = Color.Black;
                label_SerialNumber.ForeColor = Color.Black;
                label_Price.ForeColor = Color.Black;
                label_Quantity.ForeColor = Color.Black;
                if (string.IsNullOrWhiteSpace(textBox_Admin.Text) || string.IsNullOrWhiteSpace(comboBox_Object.Text) ||
                    string.IsNullOrWhiteSpace(comboBox_Type.Text) || string.IsNullOrWhiteSpace(comboBox_AssetType.Text) ||
                    string.IsNullOrWhiteSpace(textBox_Name.Text) || string.IsNullOrWhiteSpace(textBox_SerialNumber.Text) ||
                    string.IsNullOrWhiteSpace(comboBox_Manufacturer.Text) ||
                    string.IsNullOrWhiteSpace(textBox_Price.Text) || string.IsNullOrWhiteSpace(textBox_Quantity.Text))
                {
                    if (string.IsNullOrWhiteSpace(textBox_Admin.Text))
                    {
                        label_Admin.ForeColor = Color.Red;
                    }
                    if (string.IsNullOrWhiteSpace(comboBox_Object.Text))
                    {
                        label_Object.ForeColor = Color.Red;
                    }
                    if (string.IsNullOrWhiteSpace(comboBox_Type.Text))
                    {
                        label_Type.ForeColor = Color.Red;
                    }
                    if (string.IsNullOrWhiteSpace(comboBox_AssetType.Text))
                    {
                        label_AssetType.ForeColor = Color.Red;
                    }
                    if (string.IsNullOrWhiteSpace(textBox_Name.Text))
                    {
                        label_Name.ForeColor = Color.Red;
                    }
                    if (string.IsNullOrWhiteSpace(comboBox_Manufacturer.Text)) 
                    {
                        label_Manufacturer.ForeColor = Color.Red;
                    }
                    if (string.IsNullOrWhiteSpace(textBox_SerialNumber.Text))
                    {
                        label_SerialNumber.ForeColor = Color.Red;
                    }
                    if (string.IsNullOrWhiteSpace(textBox_Price.Text))
                    {
                        label_Price.ForeColor = Color.Red;
                    }
                    if (string.IsNullOrWhiteSpace(textBox_Quantity.Text))
                    { 
                        label_Quantity.ForeColor = Color.Red;
                    }
                    throw new InvalidValues();
                }
                else 
                {
                    if (comboBox_AssetType.Text == "管理") 
                    {
                        if (string.IsNullOrEmpty(textBox_AssetNo.Text))
                        {
                            label_AssetNo.ForeColor = Color.Red;
                            throw new InvalidValues();
                        }
                        else 
                        {
                            assetNo = int.Parse(textBox_AssetNo.Text);
                        }
                    }
                    name = textBox_Name.Text.ToString();
                    manufacturer = comboBox_Manufacturer.Text.ToString();
                    serialNumber = textBox_SerialNumber.Text.ToString();
                    price = int.Parse(textBox_Price.Text);
                    quantity = int.Parse(textBox_Quantity.Text);

                    int idCnt;
                    bool already = _context.ItemLists.Where(x => x._Id.Contains(id)).Any();
                    if (already)
                    {
                        idCnt = _context.ItemLists.Where(x => x._Id.Contains(id)).Count() + 1;
                    }
                    else
                    {
                        idCnt = 1;
                    }
                    selectedObject = _context.Item_Objects.Where(x => x._ObjectCode == comboBox_Object.SelectedValue).FirstOrDefault();
                    selectedType = _context.Item_Types.Where(x => x._TypeCode == comboBox_Type.SelectedValue).FirstOrDefault();
                    selectedAssetType = _context.Item_AssetTypes.Where(x => x._AssetTypeCode == comboBox_AssetType.SelectedValue).FirstOrDefault();
                    id = selectedAdmin.AdminList._Id + selectedObject._ObjectCode + selectedType._TypeCode + selectedAssetType._AssetTypeCode + idCnt.ToString("D3");
                    if (richTextBox_Memo.Text != null)
                    {
                        memo = richTextBox_Memo.Text.ToString();
                    }
                }
            }
            catch (InvalidValues)
            {
                MessageBox.Show("Invalid Value");
                throw new CustomException();
            }
        }

        private void Ref_Admin() 
        {
            string adminId = "";
            bool yes = false;
            View_AdminList va = new View_AdminList(true);
            va.senderId += (o, s) => adminId = s;
            va.senderBool += (o, b) => yes = b;
            va.FormClosed += (o, s) =>
            {
                if (yes) 
                {
                    this.selectedAdmin = _context.AdminList_Names.Include(x => x.AdminList).Where(x => x._Id == adminId).FirstOrDefault();
                    textBox_Admin.Text = $"[{selectedAdmin.AdminList._Group}] {selectedAdmin._Name}";
                    button1.Click += (o, s) => { MessageBox.Show(this.selectedAdmin._Name); };
                }
                else 
                {
                    
                }
            };
            va.ShowDialog();
        }
        private void Ref_Obj() 
        {
            string property = "";
            bool submit = false;
            Add_ItemProperty aip = new Add_ItemProperty(1, true);
            aip.senderBool += (o, b) => submit = b;
            aip.senderId += (o, s) => property = s;
            aip.FormClosed += (o, s) =>
            {
                if (submit)
                {
                    Refresh_ItemObject();
                    selectedObject = _context.Item_Objects.Where(x => x._Object == property).FirstOrDefault();
                    comboBox_Object.SelectedIndex = _context.Item_Objects.Count() - 1;
                }
                else
                {
                    Refresh_ItemObject();
                }
            };
            aip.ShowDialog();
        }
        private void Ref_Type()
        {
            string property = "";
            bool submit = false;
            Add_ItemProperty aip = new Add_ItemProperty(2, true);
            aip.senderBool += (o, b) => submit = b;
            aip.senderId += (o, s) => property = s;
            aip.FormClosed += (o, s) =>
            {
                if (submit)
                {
                    Refresh_ItemType();
                    selectedType = _context.Item_Types.Where(x => x._Type == property).FirstOrDefault();
                    comboBox_Object.SelectedIndex = _context.Item_Types.Count() - 1;
                }
                else
                {
                    Refresh_ItemType();
                }
            };
            aip.ShowDialog();
        }
        private void Ref_AssetType() 
        {
            string property = "";
            bool submit = false;
            Add_ItemProperty aip = new Add_ItemProperty(3, true);
            aip.senderBool += (o, b) => submit = b;
            aip.senderId += (o, s) => property = s;
            aip.FormClosed += (o, s) =>
            {
                if (submit)
                {
                    Refresh_ItemAssetTypes();
                    selectedAssetType = _context.Item_AssetTypes.Where(x => x._AssetType == property).FirstOrDefault();
                    comboBox_AssetType.SelectedIndex = _context.Item_AssetTypes.Count() - 1;
                }
                else
                {
                    Refresh_ItemAssetTypes();
                }
            };
            aip.ShowDialog();
        }
    }
    class InvalidValues() : Exception
    { 
    
    }

}