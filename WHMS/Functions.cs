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
    class Functions
    {
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
    }
}
