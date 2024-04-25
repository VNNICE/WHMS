using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WHMS
{
    public partial class PictureViewer : Form
    {
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
        public PictureViewer()
        {
            InitializeComponent();
        }

        private void Preview_Shelf()
        {
            /*
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

            graphics.DrawLine(dotpen, vertexB[0], vertexB[1], vertexB[0] + (depth / 2), vertexB[1] - (depth / 2));
            graphics.DrawLine(dotpen, vertexA[0] + (depth / 2), vertexA[1] - (depth / 2), vertexB[0] + (depth / 2), vertexB[1] - (depth / 2));
            graphics.DrawLine(dotpen, vertexB[0] + (depth / 2), vertexB[1] - (depth / 2), vertexC[0] + (depth / 2), vertexC[1] - (depth / 2));
            graphics.DrawString(width.ToString(), new Font("Arial", 10), Brushes.Black, new PointF(vertexB[0] + width / 2, vertexB[1] + 5));
            graphics.DrawString(height.ToString(), new Font("Arial", 10), Brushes.Black, new PointF(vertexA[0] - 30, vertexA[1] + height / 2));
            graphics.DrawString(depth.ToString(), new Font("Arial", 10), Brushes.Black, new PointF(vertexC[0] + depth / 3, vertexC[1] - depth / 4));

            pictureViewer.pictureBoxMain.Image = bitmap;
            PictureViewerSetDefaultData();
            */
        }
    }
}
