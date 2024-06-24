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

namespace WHMS
{
    public partial class Add_ItemProperty : Form
    {
        //mode 1: Object, mode 2: Type, mode3: Asset Type
        private readonly DatabaseContext _context = new DatabaseContext();
        InputRules inputRules = new InputRules();
        string? property;
        string? initial;
        public event EventHandler<string?>? senderId;

        public Add_ItemProperty(int mode, bool inputMode)
        {
            InitializeComponent();
            DefaultSettings(mode);
            inputRules.Rule_Initial(textBox_Initial);
            button_Add.Click += (o, s) => Add_Property(mode, inputMode);
        }
        public void DefaultSettings(int mode) 
        {
            if (mode == 1)
            {
                label_Property.Text = "使用目的";
                if (_context.Item_Objects.Any() && _context.Item_Objects != null)
                {
                    dataGridView.DataSource = _context.Item_Objects.ToList();
                    dataGridView.Columns["_Object"].HeaderText = "使用目的";
                    dataGridView.Columns["_ObjectCode"].HeaderText = "略字";
                }
            }
            else if (mode == 2)
            {
                label_Property.Text = "種類";
                if (_context.Item_Objects.Any() && _context.Item_Objects != null)
                {
                    dataGridView.DataSource = _context.Item_Objects.ToList();
                    dataGridView.Columns["_AssetType"].HeaderText = "種類";
                    dataGridView.Columns["_AssetTypeCode"].HeaderText = "略字";
                }
            }
            else if (mode == 3)
            {
                label_Property.Text = "資産管理";
                if (_context.Item_Objects.Any() && _context.Item_Objects != null)
                {
                    dataGridView.DataSource = _context.Item_Objects.ToList();
                    dataGridView.Columns["_Type"].HeaderText = "使用目的";
                    dataGridView.Columns["_TypeCode"].HeaderText = "略字";
                }
            }
            else
            {
                MessageBox.Show("Mode Error!");
            }
        }
        public void Add_Property(int mode, bool inputMode)
        {
            label_Property.ForeColor = Color.Black;
            label_Initial.ForeColor = Color.Black;
            
            property = textBox_Property.Text;
            initial = textBox_Initial.Text;

            try
            {
                //Check blank
                if (string.IsNullOrWhiteSpace(property) || string.IsNullOrWhiteSpace(initial))
                {
                    if (string.IsNullOrWhiteSpace(property))
                    {
                        label_Property.ForeColor = Color.Red;
                    }
                    if (string.IsNullOrWhiteSpace(initial))
                    {
                        label_Initial.ForeColor = Color.Red;
                    }
                    throw new InvalidValues();
                }
                if (initial.Count() < 2)
                {
                    label_Initial.ForeColor = Color.Red;
                    throw new CustomException();
                }
                // Try
                if (mode == 1)
                {
                    var data = new Item_Object(property, initial);
                    if (_context.Item_Objects.Any(x => x._Object == property || x._ObjectCode == initial))
                    {
                        if (_context.Item_Objects.Any(x => x._Object == property))
                        {
                            label_Property.ForeColor = Color.Red;
                        }
                        if (_context.Item_Objects.Any(x => x._ObjectCode == initial))
                        {
                            label_Initial.ForeColor = Color.Red;
                        }
                        throw new DuplicateNameException();
                    }
                    else
                    {
                        _context.Item_Objects.Add(data);
                    }
                }
                else if (mode == 2)
                {
                    var data = new Item_Type(property, initial);
                    if (_context.Item_Types.Any(x => x._Type == property || x._TypeCode == initial))
                    {
                        if (_context.Item_Types.Any(x => x._Type == property))
                        {
                            label_Property.ForeColor = Color.Red;
                        }
                        if (_context.Item_Types.Any(x => x._TypeCode == initial))
                        {
                            label_Initial.ForeColor = Color.Red;
                        }
                        throw new DuplicateNameException();
                    }
                    else
                    {
                        _context.Item_Types.Add(data);
                    }
                }
                else if (mode == 3)
                {
                    var data = new Item_AssetType(property, initial);
                    if (_context.Item_AssetTypes.Any(x => x._AssetType == property || x._AssetTypeCode == initial))
                    {
                        if (_context.Item_AssetTypes.Any(x => x._AssetType == property))
                        {
                            label_Property.ForeColor = Color.Red;
                        }
                        if (_context.Item_AssetTypes.Any(x => x._AssetTypeCode == initial))
                        {
                            label_Initial.ForeColor = Color.Red;
                        }
                        throw new DuplicateNameException();
                    }
                    else
                    {
                        _context.Item_AssetTypes.Add(data);
                    }

                }
                _context.SaveChanges();
                MessageBox.Show("登録完了");
                if (inputMode)
                {
                    DialogResult result = MessageBox.Show("", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        senderId?.Invoke(this, textBox_Property.Text);
                        ParentForm =
                    }
                    else
                    {

                    }
                }
                this.Close();
            }
            catch (InvalidValues)
            {
                MessageBox.Show("入力値に空白があります。", "入力値エラー");
            }
            catch (DuplicateNameException)
            {
                MessageBox.Show("すでに登録されている値があります。", "入力値エラー");
            }
            catch (CustomException) 
            {
                MessageBox.Show("コードは二文字にしてください。", "入力値エラー");
            }
            catch
            {
                MessageBox.Show("不明のエラーが起こりました。", "エラー");
            }

        }
        
    }
}
