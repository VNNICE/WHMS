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
        private WarehouseList_Area? selectedArea = null;
        private WarehouseList? targetWarehouse = null;
        private static List<WarehouseList_Area> selected_AreaLists = new List<WarehouseList_Area>();

        private string shelfId = "";
        private static int maxAreas = 0;
        private static int searcher = 1;
        private static int shelfCnt = 1;

        private static int width = 0;
        private static int depth = 0;
        private static int height = 0;
        //DrawingSource
        private static Size nowSize;
        private static int bitmapWidth = 0;
        private static int bitmapHeight = 0;
        private Bitmap? bitmap = null;
        private Graphics? graphics = null;
        private Pen pen = new Pen(Color.Black);
        private Pen dotpen = new Pen(Color.Black) { DashStyle = DashStyle.Dot };
        private Brush brush = new SolidBrush(Color.Blue);
        ///


        public Add_Warehouse_SecondInfo()
        {
            InitializeComponent();
            textBox_Width.TextChanged += TextBox_Changed;
            textBox_Width.Leave += TextBox_Changed;
            textBox_Height.TextChanged += TextBox_Changed;
            textBox_Height.Leave += TextBox_Changed;
            textBox_Depth.TextChanged += TextBox_Changed;
            textBox_Depth.Leave += TextBox_Changed;
            LoadWarehouseInfo();
            maxAreas = selected_AreaLists.Select(x => x._Id).ToList().Count;
            MessageBox.Show(maxAreas - 1 + "まで登録可");
        }//50, 150 150, 50
        public void PictureViewerSetDefaultData()
        {
            if (!pictureViewer.Visible)
            {
                pictureViewer.Show();
            }
            pictureViewer.Left = this.Right;
            pictureViewer.Top = this.Top;
            this.FormClosing += (sender, e) => pictureViewer.Close();
        }

        private void TextBox_Changed(object sender, EventArgs e)
        {
            if (textBox_Width.Text != "" && textBox_Width.Text != "0" && textBox_Height.Text != "" && textBox_Height.Text != "0" && textBox_Depth.Text != "" && textBox_Depth.Text != "0")
            {
                width = Functions.Try_IntParse(label_W, textBox_Width);
                height = Functions.Try_IntParse(label_H, textBox_Height);
                depth = Functions.Try_IntParse(label_D, textBox_Depth);
                StartDraw();
                Preview_Shelf();
            }
        }
        private void Preview_Shelf()
        {
            int[] vertexA = { (bitmapWidth - 1) / 8, (bitmapHeight - 1) / 3 };
            int[] vertexB = { vertexA[0] , vertexA[1] + height };
            int[] vertexC = { vertexA[0] + width, vertexA[1] + height };
            int[] vertexD = { vertexA[0]+ width, vertexA[1] };

            graphics.DrawRectangle(pen, vertexA[0], vertexA[1], width, height);
            graphics.DrawLine(pen, vertexA[0], vertexA[1], vertexA[0] + (depth / 2 ), vertexA[1] - (depth / 2));
            graphics.DrawLine(pen, vertexC[0], vertexC[1], vertexC[0] + (depth / 2 ), vertexC[1] - (depth / 2));
            graphics.DrawLine(pen, vertexD[0], vertexD[1], vertexD[0] + (depth / 2 ), vertexD[1] - (depth / 2 ));

            graphics.DrawLine(pen, vertexA[0] + (depth / 2), vertexA[1] - (depth / 2), vertexD[0] + (depth / 2), vertexD[1] - (depth / 2));
            graphics.DrawLine(pen, vertexD[0] + (depth / 2), vertexD[1] - (depth / 2), vertexC[0] + (depth / 2), vertexC[1] - (depth / 2));

            graphics.DrawLine(dotpen, vertexB[0], vertexB[1], vertexB[0] + (depth / 2 ), vertexB[1] - (depth / 2));
            graphics.DrawLine(dotpen, vertexA[0] + (depth / 2), vertexA[1] - (depth / 2 ), vertexB[0] + (depth / 2), vertexB[1] - (depth / 2));
            graphics.DrawLine(dotpen, vertexB[0] + (depth / 2), vertexB[1] - (depth / 2 ), vertexC[0] + (depth / 2), vertexC[1] - (depth / 2));
            graphics.DrawString(width.ToString(), new Font("Arial", 10), Brushes.Black, new PointF(vertexB[0] + width / 2, vertexB[1] + 5));
            graphics.DrawString(height.ToString(), new Font("Arial", 10), Brushes.Black, new PointF(vertexA[0] - 30, vertexA[1] + height/2 ));
            graphics.DrawString(depth.ToString(), new Font("Arial", 10), Brushes.Black, new PointF(vertexC[0] + depth / 3, vertexC[1] - depth / 4));

            pictureViewer.pictureBoxMain.Image = bitmap;
            PictureViewerSetDefaultData();
        }
        
        private void StartDraw()
        {
            bitmapWidth = ((width + depth) * 2);
            bitmapHeight = ((height + depth) * 2);
            pictureViewer.Size =  new Size(bitmapWidth, bitmapHeight);
            pictureViewer.pictureBoxMain.Size = new Size(bitmapWidth, bitmapHeight);
            bitmap = new Bitmap(bitmapWidth, bitmapHeight);
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
                    var newShelf = new WarehouseList_Shelf(shelfId, textBox_SelectedArea.Text.ToString(), width, depth, height);
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
