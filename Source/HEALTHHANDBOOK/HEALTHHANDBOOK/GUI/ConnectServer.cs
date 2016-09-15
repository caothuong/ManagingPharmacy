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
using HEALTHHANDBOOK.Database;

namespace HEALTHHANDBOOK.GUI
{
    public partial class ConnectServer : DevExpress.XtraEditors.XtraForm
    {
        public ConnectServer()
        {
            InitializeComponent();
            cbx_auth.Properties.Items.Add("Windows Authentication");
            cbx_auth.Properties.Items.Add("SQL Server Authentication");
        }
        public void DisplayInstanceSqlServer()
        {
            List<string> serverNames = DatabaseManager.GetServerName();

            foreach (string serverName in serverNames)
                cbx_severname.Properties.Items.Add(serverName);

            if (cbx_severname.Properties.Items.Count > 1)
                cbx_severname.SelectedItem = cbx_severname.Properties.Items[1];
        }
        private void ConnectServer_Load(object sender, EventArgs e)
        {
            cbx_auth.SelectedItem = cbx_auth.Properties.Items[0];
            DisplayInstanceSqlServer();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string strConn;
            if (cbx_auth.SelectedItem == cbx_auth.Properties.Items[0])
                strConn = DatabaseManager.CreateConnectionString(cbx_severname.Text, "master", "True");
            else
                strConn = DatabaseManager.CreateConnectionString(cbx_severname.Text, "master", txt_name.Text, txt_pass.Text, "False");

            DatabaseConnection lastMasterConn = null;
            if (DatabaseManager.MasterConnection != null && DatabaseManager.MasterConnection.Open())
            {
                DatabaseManager.MasterConnection.Close();
                lastMasterConn = DatabaseManager.MasterConnection;
            }

            DatabaseManager.MasterConnection = new DatabaseConnection(strConn);
            if (DatabaseManager.MasterConnection != null && DatabaseManager.MasterConnection.Open())
            {
                DatabaseManager.MasterConnection.Close();
                if (cbx_auth.SelectedItem == cbx_auth.Properties.Items[0])
                    DatabaseManager.MasterConnection.SetContent(cbx_severname.Text, "master", "", "", "True");
                else
                    DatabaseManager.MasterConnection.SetContent(cbx_severname.Text, "master", txt_name.Text, txt_pass.Text, "False");
                this.Close();
            }
            else
            {
                MessageBox.Show("Kết nối thất bại");
                if (lastMasterConn != null)
                    DatabaseManager.MasterConnection = lastMasterConn;
            }
        }

        private void Authen_IndexChanged(object sender, EventArgs e)
        {
            if (cbx_auth.SelectedItem == cbx_auth.Properties.Items[0])
            {
                txt_name.Enabled = false;
                txt_pass.Enabled = false;
                l_pass.Enabled = false;
                L_name.Enabled = false;
                ckShowpass.Enabled = false;
            }
            else
            {

                txt_name.Enabled = true;
                txt_pass.Enabled = true;
                l_pass.Enabled = true;
                L_name.Enabled = true;
                ckShowpass.Enabled = true;
            }
        }

        private void ckShowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckShowpass.Checked)
                txt_pass.UseSystemPasswordChar = false;
            else
                txt_pass.UseSystemPasswordChar = true;
        }
    }
}