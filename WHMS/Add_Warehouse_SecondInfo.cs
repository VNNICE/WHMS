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
using System.Drawing.Drawing2D;
using System.Configuration;

namespace WHMS
{
    public partial class Add_Warehouse_SecondInfo : Form
    {


        private Functions fc = new Functions();
        PictureViewer pictureViewer = new PictureViewer();
        private readonly DatabaseContext _context = new DatabaseContext();

        private WarehouseList targetWarehouse;
        private string? targetWarehouseId = Add_Warehouse_DefaultInfo.targetWarehouse;

        private List<WarehouseList_Area> targetAreaLists = new List<WarehouseList_Area>();
        private string? targetAreaId;
        WarehouseList_Area? targetArea;
        private string? shelfId;

        private int maxAreas = 0;
        private int searcher = 1;
        private int shelfCnt = 1;
        private int width = 0;
        private int depth = 0;
        private int height = 0;

        public Add_Warehouse_SecondInfo()
        {
            InitializeComponent();
            targetWarehouse = _context.WarehouseLists.Include(x => x.WarehouseList_Areas).FirstOrDefault(x => x._Id == targetWarehouseId);
            targetAreaLists.AddRange(targetWarehouse.WarehouseList_Areas);
            string viewAreaLists = "";
            foreach (string s in targetAreaLists.Select(x => x._Id))
            {
                viewAreaLists += s + "\n";
            }
            MessageBox.Show("TargetLists = " + viewAreaLists);
            textBox_Width.TextChanged += TextBox_Changed;
            textBox_Width.Leave += TextBox_Changed;
            textBox_Height.TextChanged += TextBox_Changed;
            textBox_Height.Leave += TextBox_Changed;
            textBox_Depth.TextChanged += TextBox_Changed;
            textBox_Depth.Leave += TextBox_Changed;
            textBox_Width.KeyPress += KeyPressSettings;
            textBox_Height.KeyPress += KeyPressSettings;
            textBox_Depth.KeyPress += KeyPressSettings;

            maxAreas = targetAreaLists.Select(x => x._Id).ToList().Count;
            MessageBox.Show(maxAreas - 1 + "まで登録可");
            LoadWarehouseInfo();
            pictureViewer.SetADefaultDataPictureBox(this);
            pictureViewer.Show();
            this.FormClosing += (sender, e) => ResetStaticData();
        }//50, 150 150, 50
        private void KeyPressSettings(object? sender, KeyPressEventArgs e)
        {
            TextBox? tb = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (tb.Text.Length >= 4 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void ResetStaticData()
        {
            maxAreas = 0;
            searcher = 1;
            shelfCnt = 1;
            width = 0;
            depth = 0;
            height = 0;
        }

        private void TextBox_Changed(object? sender, EventArgs e)
        {
            if (textBox_Width.Text != "" && textBox_Width.Text != "0" && textBox_Height.Text != "" && textBox_Height.Text != "0" && textBox_Depth.Text != "" && textBox_Depth.Text != "0")
            {
                pictureViewer.SetADefaultDataPictureBox(this);
                width = fc.Try_IntParse(label_W, textBox_Width);
                height = fc.Try_IntParse(label_H, textBox_Height);
                depth = fc.Try_IntParse(label_D, textBox_Depth);
                pictureViewer.SetAShelf(width, depth, height);
                pictureViewer.StartDrawShelf();
                pictureViewer.Preview_Shelf();
                this.Focus();
            }
        }

        private void LoadWarehouseInfo()
        {
            if (targetWarehouse != null)
            {
                var areaLists = targetAreaLists[searcher];
                targetAreaId = areaLists._Id.ToString();
                targetArea = _context.WarehouseList_Areas.Find(targetAreaId);
                MessageBox.Show(targetArea._Id);

                textBox_Name.Text = targetWarehouse._Name.ToString();
                textBox_SelectedArea.Text = targetArea._Id + " / " + (maxAreas - 1).ToString();
                textBox_Shelf.Text = shelfCnt.ToString();
            }
        }
        private void Test()
        {
            PictureViewer areaAdder = new PictureViewer();
            {
                int x = 0;
                int y = 0;
                int width = 0;
                int height = 0;
                areaAdder.Mode_CreateArea(this, _context.WarehouseLists.Find(targetWarehouseId)._ImagePath, ref x, ref y, ref width, ref height);
                textBox1.Text = width.ToString();
            }
        }

        private void Add_Shelf()
        {
            if (textBox_SelectedArea.Text != null && targetArea != null)
            {
                if (targetArea.WarehouseList_Id.Any())
                {
                    if (!targetArea.WarehouseList_Shelves.Any())
                    {
                        var firstShelf = new WarehouseList_Shelf(targetAreaId + "S0", 0, targetArea._Id.ToString(), 0, 0, 0, 0);
                        _context.Add(firstShelf);
                    }
                    shelfId = targetAreaId + "S" + shelfCnt.ToString();
                    var newShelf = new WarehouseList_Shelf(shelfId, shelfCnt, targetAreaId, width, depth, height, 0);
                    MessageBox.Show(shelfId);
                    MessageBox.Show(newShelf._Id);
                    _context.Add(newShelf);
                    _context.SaveChanges();
                    shelfCnt++;
                    LoadWarehouseInfo();
                }
            }
        }



        private void AreaSearcher()
        {
            if (targetWarehouse != null && targetWarehouse.WarehouseList_Areas != null)
            {
                shelfCnt = 1;
                searcher++;
                if (searcher == maxAreas)
                {
                    MessageBox.Show("全置場設定完了");
                    this.Dispose();
                }
            }
            else
            {
                throw new Exception("AreaSearcher Error");
            }

        }

        private void label_W_Click(object? sender, EventArgs e)
        {

        }

        private void button_Decide_Click(object? sender, EventArgs e)
        {
            Add_Shelf();
            LoadWarehouseInfo();
        }

        private void button_Skip_Click(object? sender, EventArgs e)
        {
            if (shelfCnt == 1)
            {
                MessageBox.Show("棚は最低1段以上作成してください。");
            }
            else
            {
                AreaSearcher();
                if (searcher != maxAreas)
                {
                    LoadWarehouseInfo();
                }
            }
        }

        private void textBox_Width_TextChanged(object? sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test();
        }
    }
}