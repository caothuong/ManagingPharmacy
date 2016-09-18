using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace QUANLYNHATHUOC.Database
{
        public class DatabaseConnection
        {

            //-----------------------------------------
            //Desc: Kết nối với csdl sql
            //-----------------------------------------
            private SqlConnection _sqlConn;
            public SqlConnection SqlConn
            {
                get { return _sqlConn; }
                set { _sqlConn = value; }
            }

            private string _DataSourceName;
            public string DataSourceName
            {
                get { return _DataSourceName; }
            }

            private string _DatabaseName;
            public string DatabaseName
            {
                get { return _DatabaseName; }
                set { _DatabaseName = value; }
            }

            private string _UserName;
            public string UserName
            {
                get { return _UserName; }
                set { _UserName = value; }
            }

            private string _Password;
            public string Password
            {
                get { return _Password; }
                set { _Password = value; }
            }

            private string _IntegratedSecurity;
            public string IntegratedSecurity
            {
                get { return _IntegratedSecurity; }
                set { _IntegratedSecurity = value; }
            }

            //-----------------------------------------
            //Desc: Khởi tạo kết nối
            //-----------------------------------------
            public DatabaseConnection(string strConn)
            {
                _sqlConn = new SqlConnection(strConn);
            }

            //-----------------------------------------
            //Desc: thiết lập các giá trị
            //-----------------------------------------
            public void SetContent(string datasource, string databasename
                , string username, string password, string integratedSecurity)
            {
                _DataSourceName = datasource;
                _DatabaseName = databasename;
                _UserName = username;
                _Password = password;
                _IntegratedSecurity = integratedSecurity;
            }

            //-----------------------------------------
            //Desc: Mở kết nối
            //-----------------------------------------
            public bool Open()
            {
                try
                {
                    _sqlConn.Open();
                }
                catch
                {
                    return false;
                }
                return true;
            }

            //-----------------------------------------
            //Desc: Đóng kết nối
            //-----------------------------------------
            public bool Close()
            {
                try
                {
                    _sqlConn.Close();
                }
                catch
                {
                    return false;
                }
                return true;
            }
            //-----------------------------------------
            //Desc: lấy dữ liệu thông qua câu try vấn sql, thất bại trở về null
            //-----------------------------------------
            public DataTable ExecuteQuery(string sql)
            {
                SqlCommand sqlCmd = new SqlCommand(sql, _sqlConn) { CommandType = CommandType.Text };
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                if (Open())
                {
                    //đổ dữ liệu vào data table
                    try
                    {
                        sqlDa.Fill(dt);
                    }
                    catch
                    {
                        Close();
                        return null;
                    }
                    Close();
                }
                else
                    return null;
                return dt;
            }

            //-----------------------------------------
            //Desc: thực thi câu lệnh sql, dùng cho insert, update, delete
            //-----------------------------------------
            public bool ExecuteNonQuery(string sql)
            {
                SqlCommand sqlCmd = new SqlCommand(sql, _sqlConn) { CommandType = CommandType.Text };
                if (Open())
                {
                    try
                    {
                        sqlCmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        Close();
                        return false;
                    }
                    Close();
                    return true;
                }
                else
                    return false;
            }

            //-----------------------------------------
            //Desc: thực thi câu lệnh sql, dùng cho đếm số lượng, ...
            //-----------------------------------------
            public object ExecuteScalar(string sql)
            {
                SqlCommand sqlCmd = new SqlCommand(sql, _sqlConn) { CommandType = CommandType.Text };
                object obj;
                if (Open())
                {
                    try
                    {
                        obj = sqlCmd.ExecuteScalar();
                    }
                    catch
                    {
                        Close();
                        return null;
                    }
                    Close();
                    return obj;
                }
                else
                    return null;
            }
        }
    }
