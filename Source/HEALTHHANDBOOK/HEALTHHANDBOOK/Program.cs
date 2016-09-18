using System;
using HEALTHHANDBOOK.GUI;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYNHATHUOC.Database;
using HEALTHHANDBOOK.GUI;

namespace HEALTHHANDBOOK
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConnectServer());
            if (DatabaseManager.MasterConnection != null && DatabaseManager.MasterConnection.Open())
            {
                DatabaseManager.MasterConnection.Close();
                Application.Run(new ConnectDatabase());
                if (DatabaseManager.DbConnection != null && DatabaseManager.DbConnection.Open())
                {
                    DatabaseManager.DbConnection.Close();
                    Application.Run(new Main());
                }
            }
        }
    }
}
