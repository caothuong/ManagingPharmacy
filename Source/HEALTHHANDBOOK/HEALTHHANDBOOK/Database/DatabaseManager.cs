using Microsoft.Win32;
using QUANLYNHATHUOC.Database;
using System;
using System.Data.OleDb;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;

namespace QUANLYNHATHUOC.Database
{
    public static class  DatabaseManager
    {
        //-----------------------------------------
        //Desc: biến static dùng để kết nối với server
        //-----------------------------------------
        private static DatabaseConnection _MasterConnection;
        public static DatabaseConnection MasterConnection
        {
            get { return DatabaseManager._MasterConnection; }
            set { DatabaseManager._MasterConnection = value; }
        }

        //-----------------------------------------
        //Desc: biến static dùng để kết nối với csdl
        //-----------------------------------------
        private static DatabaseConnection _DbConnection;
        public static DatabaseConnection DbConnection
        {
            get { return DatabaseManager._DbConnection; }
            set { DatabaseManager._DbConnection = value; }
        }

        //-----------------------------------------
        //Desc: Lấy tên thể hiện của sql server
        //-----------------------------------------
        public static List<string> GetInstanceName()
        {
            List<string> instanceNames = new List<string>();

            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        instanceNames.Add(instanceName);
                    }
                }
            }

            return instanceNames;
        }

        //-----------------------------------------
        //Desc: Lấy tên các server trong máy
        //-----------------------------------------
        public static List<string> GetServerName()
        {
            List<string> serverNames = new List<string>();

            string machineName = null;
            try
            {
                machineName = Environment.MachineName;
            }
            catch
            { }

            if (machineName != null)
            {
                serverNames.Add(machineName);

                List<string> instanceNames = GetInstanceName();
                foreach (string instanceName in instanceNames)
                    serverNames.Add(machineName + @"\" + instanceName);
            }

            return serverNames;
        }

        //-----------------------------------------
        //Desc: tạo connection string
        //-----------------------------------------
        public static string CreateConnectionString(string dataSource, string databaseName, string integratedSecurity)
        {
            return "Data Source=" + dataSource + ";Initial Catalog=" + databaseName + ";Integrated Security=" + integratedSecurity + ";";
        }
        public static string CreateConnectionString(string dataSource, string databaseName, string userName, string password, string integratedSecurity)
        {
            return "Data Source=" + dataSource + ";Initial Catalog=" + databaseName + ";user=" + userName + ";password=" + password + ";Integrated Security=" + integratedSecurity + ";";
        }

        //-----------------------------------------
        //Desc: lấy tên tất cả cơ sở dữ liệu trong sql server
        //-----------------------------------------
        public static List<string> GetAllDatabaseName()
        {
            if (DatabaseManager.MasterConnection == null)
                return null;
            string sql = "SELECT * FROM sys.databases d WHERE d.database_id > 6";
            DataTable data = DatabaseManager.MasterConnection.ExecuteQuery(sql);
            if (data == null)
                return null;
            else
            {
                List<string> databaseNames = new List<string>();
                for (int i = 0; i < data.Rows.Count; i++)
                    databaseNames.Add(data.Rows[i][0].ToString());
                return databaseNames;
            }

        }

        //-----------------------------------------
        //Desc: kiểm tra tồn tại database
        //-----------------------------------------
        public static int CheckDatabaseExist(string databaseName)
        {
            if (DatabaseManager.MasterConnection == null)
                return -1;

            string sql = "SELECT count (name) FROM master.sys.databases WHERE name = N'" + databaseName + "'";
            object obj = DatabaseManager.MasterConnection.ExecuteScalar(sql);
            if (obj == null)
                return -1;
            else
            {
                int dem;
                try
                {
                    dem = (int)obj;
                }
                catch { return -1; }

                return dem;
            }
        }

        //-----------------------------------------
        //Desc: Sao lưu cơ sở dữ liệu
        //-----------------------------------------
        public static bool BackupDatabase(string folderPath, string databaseName)
        {
            if (DatabaseManager.MasterConnection == null)
                return false;

            int i = 1;
            string fileName = folderPath + "\\" + databaseName + i.ToString("D3") + ".bak";
            //xem thư mục có tên đã được tạo chưa, nếu đã được tạo thì thay đổi tên
            while (File.Exists(fileName))
            {
                i++;
                fileName = folderPath + "\\" + databaseName + i.ToString("D3") + ".bak";
            }

            string sql = "BACKUP DATABASE " + databaseName
                       + " TO DISK ='" + fileName + "'";
            if (DatabaseManager.MasterConnection.ExecuteNonQuery(sql))
                return true;
            else
                return false;
        }

        //-----------------------------------------
        //Desc: phục hồi cơ sở dữ liệu
        //-----------------------------------------
        public static bool RestoreDatabase(string fileName, string databaseName)
        {
            if (DatabaseManager.MasterConnection == null)
                return false;

            int dbExist = CheckDatabaseExist(databaseName);
            string sql = "";
            if (dbExist > 0)
            {
                sql += "Alter Database " + databaseName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "Restore Database " + databaseName + " FROM DISK = '" + fileName + "' WITH REPLACE;";
                return DatabaseManager.MasterConnection.ExecuteNonQuery(sql);
            }
            else if (dbExist == 0)
            {
                sql += "Restore Database " + databaseName + " FROM DISK = '" + fileName + "' WITH REPLACE;";
                return DatabaseManager.MasterConnection.ExecuteNonQuery(sql);
            }
            else
                return false;


        }
      
    }
}
