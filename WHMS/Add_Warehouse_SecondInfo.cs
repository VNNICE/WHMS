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
        private readonly DatabaseContext _context = new DatabaseContext();
        private static int searcher = 0;
        private string targetWarehouseId = Add_Warehouse_DefaultInfo.targetWarehouse;
        public Add_Warehouse_SecondInfo()
        {
            InitializeComponent();
            _context = new DatabaseContext();
            LoadWarehouseInfo();
        }


        private void LoadWarehouseInfo()
        {
            MessageBox.Show(targetWarehouseId);
            var targetWarehouse = _context.WarehouseLists.Include(x => x.WarehouseList_Areas).FirstOrDefault(x => x._Id == targetWarehouseId);
            if (targetWarehouse != null)
            {
                textBox_Name.Text = targetWarehouse._Name.ToString();
                var areaLists = targetWarehouse.WarehouseList_Areas.Select(x => x._Area).ToList();
                int nowCount = areaLists[searcher];
                textBox_SelectedArea.Text = nowCount.ToString();
            }
        }
        private void SetAArea2(string areaId, out string msg)
        {
            var selectedArea = _context.WarehouseLists.Find(areaId);
            int cnt = 1;
            if (textBox_SelectedArea.Text != null && selectedArea != null)
            {
                if (selectedArea.WarehouseList_Areas.Any() == false)
                {
                    textBox_Area2.Text = cnt.ToString();


                } 
                
                textBox_Width.Text
            }
            else
            {
                msg = "入力値エラー";
            }
        }

        private void MakeShelf(string shelfId, int width, int length, int height)
        {
            int imageWidth = 400;
            int imageHeight = 400;
            Bitmap bitmap = new Bitmap(imageWidth, imageHeight);
            Graphics graphics = Graphics.FromImage(bitmap);

            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Blue);
            int startX = 50;
            int startY = 50;
            int rectangleWidth = (int)(width * 10);
            int rectangleLength = (int)(length * 10); 
            int rectangleHeight = (int)(height * 10); 
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
            graphics.DrawString(lengthLabel, font, labelBrush, startX - 20, startY - rectangleHeight / 2 - 10);
            graphics.DrawString(heightLabel, font, labelBrush, startX + rectangleWidth + 5, startY - rectangleHeight / 2 - 10);
            string fileName = Path.Combine(DataPath.imagePath +shelfId +".png");
            bitmap.Save(fileName);
            MessageBox.Show("棚画像生成完了");
            graphics.Dispose();
            bitmap.Dispose();
        }

        private void AreaSearcher(int maxcount)
        {
            searcher++;
            if (searcher == maxcount - 1)
            {
                MessageBox.Show("全置場設定完了");
                this.Dispose();
            }
        }
    }
}
