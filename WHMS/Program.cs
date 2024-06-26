using DBMS;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Storage;
using TranslationToolClass;


namespace WHMS
{
    internal static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var dbManager = new DBManager();
            try
            {
                dbManager.MakeDefaultData();
                dbManager.SetACityLists();
            }
            catch 
            {
                MessageBox.Show("ãNìÆÉGÉâÅ[");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}