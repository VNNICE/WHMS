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
    /* 
     SampleCodes
    ///////////////////////////////////////////////////////////////////////
    ///
        private void KeyPressSettings(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBox.Text.Length >= 4 && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }


    //
    */
    class Functions
    {
        public void SetDataGridViewColumns(DataGridView gridview, string data, string view)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = data;
            column.HeaderText = view;
            gridview.Columns.Add(column);
        }

        public int Try_IntParse(Label label, TextBox text)
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
        public void NoImageGenerator(string path)
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
                            graphics.Dispose();
                            bitmap.Dispose();
                        }
                    }
                }
                
            }
            MessageBox.Show("画像なしで登録");
        }   
    }
}
