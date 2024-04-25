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

namespace WHMS
{
    public partial class Add_Warehouse_SecondInfo : Form
    {
        private string targetWarehouseId = Add_Warehouse_DefaultInfo.targetWarehouse;
        PictureViewer pictureViewer = new PictureViewer();
        private readonly DatabaseContext _context = new DatabaseContext();
        private WarehouseList_Area selectedArea;
        private WarehouseList targetWarehouse;
        private static List<WarehouseList_Area> selected_AreaLists = new List<WarehouseList_Area>();
        private string selectedAreaId;
        private string shelfId = "";
        private static int maxAreas = 0;
        private static int searcher = 1;
        private static int shelfCnt = 1;
        private static int width = 0;
        private static int depth = 0;
        private static int height = 0;


        public Add_Warehouse_SecondInfo()
        {
            InitializeComponent();
            targetWarehouse = _context.WarehouseLists.Include(x => x.WarehouseList_Areas).FirstOrDefault(x => x._Id == targetWarehouseId);
            selected_AreaLists.AddRange(targetWarehouse.WarehouseList_Areas);

            selectedArea = _context.WarehouseList_Areas.Find(textBox_SelectedArea.Text.ToString());

            textBox_Width.TextChanged += TextBox_Changed;
            textBox_Width.Leave += TextBox_Changed;
            textBox_Height.TextChanged += TextBox_Changed;
            textBox_Height.Leave += TextBox_Changed;
            textBox_Depth.TextChanged += TextBox_Changed;
            textBox_Depth.Leave += TextBox_Changed;
            maxAreas = selected_AreaLists.Select(x => x._Id).ToList().Count;
            MessageBox.Show(maxAreas - 1 + "まで登録可");
            LoadWarehouseInfo();
            SetADefaultDataPictureBox();
            this.FormClosing += (sender, e) => pictureViewer.Close();
        }//50, 150 150, 50

        private void SetADefaultDataPictureBox()
        {
            pictureViewer.Left = this.Right;
            pictureViewer.Top = this.Top;
        }
        private void TextBox_Changed(object sender, EventArgs e)
        {
            if (textBox_Width.Text != "" && textBox_Width.Text != "0" && textBox_Height.Text != "" && textBox_Height.Text != "0" && textBox_Depth.Text != "" && textBox_Depth.Text != "0")
            {
                SetADefaultDataPictureBox();
                width = Functions.Try_IntParse(label_W, textBox_Width);
                height = Functions.Try_IntParse(label_H, textBox_Height);
                depth = Functions.Try_IntParse(label_D, textBox_Depth);
                pictureViewer.SetAShelf(width, depth, height);
                pictureViewer.StartDraw();
                pictureViewer.Preview_Shelf();
                if (!pictureViewer.Visible)
                {
                    pictureViewer.Show();
                    SetADefaultDataPictureBox();
                }
            }
        }

        private void LoadWarehouseInfo()
        {
            if (targetWarehouse != null)
            {
                textBox_Name.Text = targetWarehouse._Name.ToString();
                var areaLists = selected_AreaLists[searcher];
                textBox_SelectedArea.Text = areaLists._Id.ToString() + " / " + (maxAreas - 1).ToString();
                textBox_Shelf.Text = shelfCnt.ToString();
            }
        }
        private void Add_Shelf()
        {
            if (textBox_SelectedArea.Text != null && selectedArea != null)
            {
                if (selectedArea.WarehouseList_Id.Any())
                {
                    selectedAreaId = selectedArea._Id.ToString();
                    shelfId = selectedArea._Id + "S" + shelfCnt.ToString();
                    if (!selectedArea.WarehouseList_Shelves.Any())
                    { 
                        var firstShelf = new WarehouseList_Shelf(selectedArea._Id + "S0", selectedArea._Id.ToString(), 0, 0, 0);
                        _context.Add(firstShelf);
                    }
                    var newShelf = new WarehouseList_Shelf(shelfId, textBox_SelectedArea.Text.ToString(), width, depth, height);
                    _context.Add(newShelf);
                    _context.SaveChanges();
                    shelfCnt++;
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

        private void label_W_Click(object sender, EventArgs e)
        {

        }

        private void button_Decide_Click(object sender, EventArgs e)
        {
            Add_Shelf();
            LoadWarehouseInfo();
        }

        private void button_Skip_Click(object sender, EventArgs e)
        {
            AreaSearcher();
            LoadWarehouseInfo();
        }

        private void textBox_Width_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
