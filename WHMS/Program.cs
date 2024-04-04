using DBMS;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Storage;
using FunctionClass;


namespace WHMS
{
    internal static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            MessageBox.Show(DataPath.dbPath);
            string msg = "";
            DBManager.MakeDefaultData(out msg);
            MessageBox.Show(msg);
            DBManager.SetACityLists(out msg);
            MessageBox.Show(msg);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}