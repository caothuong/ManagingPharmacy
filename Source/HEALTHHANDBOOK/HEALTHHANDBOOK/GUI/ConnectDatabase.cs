using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QUANLYNHATHUOC.Database;

namespace HEALTHHANDBOOK.GUI
{
    public partial class ConnectDatabase : DevExpress.XtraEditors.XtraForm
    {
        public ConnectDatabase()
        {
            InitializeComponent();
        }
        public void Showservername()
        {
            List<string> databaseNames = DatabaseManager.GetAllDatabaseName();
            if (databaseNames != null && databaseNames.Count > 0)
            {
                for (int i = 0; i < databaseNames.Count; i++)
                {
                    try
                    {
                        cbx_Sevename.Properties.Items.Add(databaseNames[i]);
                        
                    }
                    catch { }
                }
            }
        }

        private void colorPickerButton1_SelectedColorChanged(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConnectDatabase_Load(object sender, EventArgs e)
        {
            Showservername();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (DatabaseManager.MasterConnection == null)
            {
                MessageBox.Show("Chưa kết nối Server");
                return;
            }

            if (cbx_Sevename.Text == "")
            {
                MessageBox.Show("Chưa chọn tên cơ sở dữ liệu");
                return;
            }

            DatabaseConnection lastDbConnection = null;
            if (DatabaseManager.DbConnection != null && DatabaseManager.DbConnection.Open())
            {
                DatabaseManager.DbConnection.Close();
                lastDbConnection = DatabaseManager.DbConnection;
            }

            string strConn;
            if (DatabaseManager.MasterConnection.UserName != "" && DatabaseManager.MasterConnection.Password != "")
                strConn = DatabaseManager.CreateConnectionString(DatabaseManager.MasterConnection.DataSourceName, cbx_Sevename.Text
                    , DatabaseManager.MasterConnection.UserName, DatabaseManager.MasterConnection.Password, DatabaseManager.MasterConnection.IntegratedSecurity);
            else
                strConn = DatabaseManager.CreateConnectionString(DatabaseManager.MasterConnection.DataSourceName, cbx_Sevename.Text
                    , DatabaseManager.MasterConnection.IntegratedSecurity);

            DatabaseManager.DbConnection = new DatabaseConnection(strConn);
            if (DatabaseManager.DbConnection != null && DatabaseManager.DbConnection.Open())
            {
                DatabaseManager.DbConnection.Close();
                DatabaseManager.DbConnection.SetContent(DatabaseManager.MasterConnection.DataSourceName, cbx_Sevename.Text
                    , DatabaseManager.MasterConnection.UserName, DatabaseManager.MasterConnection.Password, DatabaseManager.MasterConnection.IntegratedSecurity);
                this.Close();

            }
            else
            {
                MessageBox.Show("Kết nối thất bại");
                if (lastDbConnection != null)
                    DatabaseManager.DbConnection = lastDbConnection;
            }
        }
    }
}