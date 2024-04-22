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

namespace WHMS
{
    public partial class Add_Warehouse_SecondInfo : Form
    {
        private string targetWarehouseId = Add_Warehouse_DefaultInfo.targetWarehouse;

        private readonly DatabaseContext _context = new DatabaseContext();
        private WarehouseList_Area? selectedArea = null;
        private WarehouseList? targetWarehouse = null;
        private static List<WarehouseList_Area> selected_AreaLists = new List<WarehouseList_Area>();

        private string shelfId = "";
        private static int maxAreas = 0;
        private static int searcher = 1;
        private static int shelfCnt = 1;

        private static int length = 0;
        private static int width = 0;
        private static int height = 0;
        //DrawingSource
        private Bitmap? bitmap = null;
        private Graphics? graphics = null;
        private Pen pen = new Pen(Color.Black);
        private Brush brush = new SolidBrush(Color.Blue);
        private int imageWidth = 400;
        private int imageHeight = 400;
        private int startX = 50;
        private int startY = 50;
        ///


        public Add_Warehouse_SecondInfo()
        {
            InitializeComponent();
            textBox_Width.TextChanged += TextBox_Changed;
            textBox_Width.Leave += TextBox_Changed;
            textBox_Length.TextChanged += TextBox_Changed;
            textBox_Length.Leave += TextBox_Changed;
            textBox_Height.TextChanged += TextBox_Changed;
            textBox_Height.Leave += TextBox_Changed;
            LoadWarehouseInfo();
            maxAreas = selected_AreaLists.Select(x => x._Id).ToList().Count;
            MessageBox.Show(maxAreas - 1 + "まで登録可");
        }
        private void TextBox_Changed(object sender, EventArgs e)
        {
            if (textBox_Width.Text != "" && textBox_Length.Text != "" && textBox_Height.Text != "")
            {
                StartDraw();
                width = Functions.Try_IntParse(label_W, textBox_Width);
                length = Functions.Try_IntParse(label_L, textBox_Length);
                height = Functions.Try_IntParse(label_H, textBox_Height);
                Preview_Shelf();
            }
        }
        private void Preview_Shelf()
        {
            int rectangleWidth = width * 10;
            int rectangleLength = length * 10;
            int rectangleHeight = height * 10;
            graphics.DrawRectangle(pen, startX, startY, rectangleWidth, rectangleLength);
            graphics.DrawLine(pen, startX, startY, startX, startY - rectangleHeight);
            graphics.DrawLine(pen, startX + rectangleWidth, startY, startX + rectangleWidth, startY - rectangleHeight);
            graphics.DrawLine(pen, startX, startY - rectangleHeight, startX + rectangleWidth, startY - rectangleHeight);

            string widthLabel = width.ToString();
            string lengthLabel = length.ToString();
            string heightLabel = height.ToString();

            Font font = new Font("Arial", 10);
            Brush labelBrush = new SolidBrush(Color.Black);

            graphics.DrawString(widthLabel, font, labelBrush, startX + rectangleWidth / 2 - 10, startY + 5);
            graphics.DrawString(lengthLabel, font, labelBrush, startX - 20, startY - rectangleLength / 2 - 10);
            graphics.DrawString(heightLabel, font, labelBrush, startX + rectangleWidth + 5, startY - rectangleLength / 2 - 10);

            pictureBox1.Image = bitmap;
        }
        
        private void StartDraw()
        {
            bitmap = new Bitmap(imageWidth, imageHeight);
            graphics = Graphics.FromImage(bitmap);
        }

        private void LoadWarehouseInfo()
        {
            targetWarehouse = _context.WarehouseLists.Include(x => x.WarehouseList_Areas).FirstOrDefault(x => x._Id == targetWarehouseId);
            if (targetWarehouse != null)
            {
                textBox_Name.Text = targetWarehouse._Name.ToString();
                selected_AreaLists.AddRange(targetWarehouse.WarehouseList_Areas);

                var areaLists = selected_AreaLists[searcher];

                textBox_SelectedArea.Text = areaLists._Id.ToString() + " / " + (maxAreas - 1).ToString();
                textBox_Shelf.Text = shelfCnt.ToString();
            }
        }
        private void SetAShelf()
        {
            selectedArea = _context.WarehouseList_Areas.Find(textBox_SelectedArea.Text.ToString());
            if (textBox_SelectedArea.Text != null && selectedArea != null)
            {
                if (selectedArea.WarehouseList_Id.Any())
                {
                    shelfId = selectedArea._Id + "S" + shelfCnt.ToString();
                    if (!selectedArea.WarehouseList_Shelves.Any())
                    { 
                        var firstShelf = new WarehouseList_Shelf(selectedArea._Id + "S0", selectedArea._Id.ToString(), 0, 0, 0);
                        _context.Add(firstShelf);
                    }
                    var newShelf = new WarehouseList_Shelf(shelfId, textBox_SelectedArea.Text.ToString(), length, width, height);
                    _context.Add(newShelf);
                    _context.SaveChanges();
                    shelfCnt++;
                }
            }
        }

        private void MakeShelf()
        {
            string fileName = Path.Combine(DataPath.imagePath + shelfId + ".png");
            bitmap.Save(fileName);
            MessageBox.Show("画像生成完了");
            graphics.Dispose();
            bitmap.Dispose();
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
            SetAShelf();
            MakeShelf();
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
