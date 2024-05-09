using DBMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WHMS
{
    public partial class PictureViewer : Form
    {
        private static int width;
        private static int height;
        private static int depth;
        //DrawingSource
        private static int bitmapWidth = 0;
        private static int bitmapHeight = 0;
        private Bitmap? bitmap = null;
        private Graphics? graphics = null;
        private Pen pen = new Pen(Color.Black);
        private Pen dotPen = new Pen(Color.Black) { DashStyle = DashStyle.Dot };
        private Brush brush = new SolidBrush(Color.Blue);
        ///
        public PictureViewer()
        {
            InitializeComponent();
            this.Closed += (order, e) => ResetData();
        }
        private void ResetData()
        {
            width = 0;
            height = 0;
            depth = 0;
            bitmapWidth = 0;
            bitmapHeight = 0;
        }

        public void Mode_LoadPicture(string path)
        {
            if (this.Visible == false)
            {
                this.Show();
            }
            try
            {
                pictureBoxMain.Image = Image.FromFile(path);
                pictureBoxMain.SizeMode = PictureBoxSizeMode.Zoom;
                this.Size = pictureBoxMain.Size;
            }
            catch 
            {
                pictureBoxMain.Image = null;
            }
        }

        public void SetADefaultDataPictureBox(Form form)
        {
            this.Left = form.Right;
            this.Top = form.Top;
            this.TopMost = true;
            form.LocationChanged += (order, s) => { this.Left = form.Right; this.Top = form.Top; };
            form.Closed += (order, e) => this.Close();
        }

        public void SetAShelf(int w, int d, int h)
        {
            width = w;
            depth = d;
            height = h;
        }

        public void Preview_Shelf()
        {
            if (graphics != null)
            {
                int[] vertexA = { (bitmapWidth - 1) / 8, (bitmapHeight - 1) / 3 };
                int[] vertexB = { vertexA[0], vertexA[1] + height };
                int[] vertexC = { vertexA[0] + width, vertexA[1] + height };
                int[] vertexD = { vertexA[0] + width, vertexA[1] };

                graphics.DrawRectangle(pen, vertexA[0], vertexA[1], width, height);
                graphics.DrawLine(pen, vertexA[0], vertexA[1], vertexA[0] + (depth / 2), vertexA[1] - (depth / 2));
                graphics.DrawLine(pen, vertexC[0], vertexC[1], vertexC[0] + (depth / 2), vertexC[1] - (depth / 2));
                graphics.DrawLine(pen, vertexD[0], vertexD[1], vertexD[0] + (depth / 2), vertexD[1] - (depth / 2));

                graphics.DrawLine(pen, vertexA[0] + (depth / 2), vertexA[1] - (depth / 2), vertexD[0] + (depth / 2), vertexD[1] - (depth / 2));
                graphics.DrawLine(pen, vertexD[0] + (depth / 2), vertexD[1] - (depth / 2), vertexC[0] + (depth / 2), vertexC[1] - (depth / 2));

                graphics.DrawLine(dotPen, vertexB[0], vertexB[1], vertexB[0] + (depth / 2), vertexB[1] - (depth / 2));
                graphics.DrawLine(dotPen, vertexA[0] + (depth / 2), vertexA[1] - (depth / 2), vertexB[0] + (depth / 2), vertexB[1] - (depth / 2));
                graphics.DrawLine(dotPen, vertexB[0] + (depth / 2), vertexB[1] - (depth / 2), vertexC[0] + (depth / 2), vertexC[1] - (depth / 2));

                graphics.DrawString(height.ToString(), new Font("Arial", 10), Brushes.Black, new PointF(vertexA[0] - 30, vertexA[1] + height / 2));
                graphics.DrawString(width.ToString(), new Font("Arial", 10), Brushes.Black, new PointF(vertexB[0] + width / 2, vertexB[1] + 5));
                graphics.DrawString(depth.ToString(), new Font("Arial", 10), Brushes.Black, new PointF(vertexC[0] + depth / 3, vertexC[1] - depth / 4));

                pictureBoxMain.Image = bitmap;
            }
        }

        public void StartDrawShelf()
        {
            bitmapWidth = ((width + depth) * 2);
            bitmapHeight = ((height + depth) * 2);
            this.Size = new Size(bitmapWidth, bitmapHeight);
            pictureBoxMain.Size = new Size(bitmapWidth, bitmapHeight);
            bitmap = new Bitmap(bitmapWidth, bitmapHeight);
            graphics = Graphics.FromImage(bitmap);
        }
    }
}
