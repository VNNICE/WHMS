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
using DBMS;
using System.Security.Cryptography.X509Certificates;

namespace WHMS
{
    public class Functions
    {
        public static void SetDataGridViewColumns(DataGridView gridview, string data, string view)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = data;
            column.HeaderText = view;
            gridview.Columns.Add(column);
        }
        public static int Try_IntParse(Label label, TextBox text)
        {
            string s = text.Text.ToString();
            try
            {
                int i = int.Parse(s);
                return i;
            }
            catch
            {
                throw new ArgumentException($"{label.Text}には整数を入力してください。");
            }
        }
        public static void NoImageGenerator(string path)
        {
            int width = 200;
            int height = 200;
            using (Bitmap bitmap = new Bitmap(width, height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Font font = new Font("Arial", 12))
                    {
                        using (SolidBrush brush = new SolidBrush(Color.Black))
                        {
                            graphics.FillRectangle(Brushes.White, 0, 0, width, height);
                            graphics.DrawString("No Image", font, brush, new PointF(50, 40));
                            bitmap.Save(path);
                        }
                    }
                }
                
            }
            MessageBox.Show("画像なしで登録");
        }   
    }
}
