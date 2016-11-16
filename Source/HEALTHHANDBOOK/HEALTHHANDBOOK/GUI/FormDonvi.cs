using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QUANLYNHATHUOC.Database;

namespace QUANLYNHATHUOC.GUI
{
    public partial class FormDonvi : DevExpress.XtraEditors.XtraUserControl
    {
        QUANLYNHATHUOCDATADataContext Data = new QUANLYNHATHUOCDATADataContext(DatabaseManager.DbConnection.SqlConn);
        DataTable _datatable;
        List<DONVITINH> _listdonvi;
        string _donvi;
        DONVITINH donvi;

        List<LOAITHUOC> _listLoaiThuoc;
        string _loaithuoc;
        LOAITHUOC loaithuoc;
        DataTable _dataLoaiThuoc;

        List<QUYDINH> _listquydinh;
        string _tenquydinh;
        QUYDINH quydinh;
        DataTable _dataQuyDinh;
        public FormDonvi()
        {
            InitializeComponent();
            _listdonvi = Data.DONVITINHs.ToList();
            _listLoaiThuoc = Data.LOAITHUOCs.ToList();
            _listquydinh = Data.QUYDINHs.ToList();
        }
        public void LoadData()
        {
            _datatable = new DataTable();
            _datatable.Columns.Add("STT");
            _datatable.Columns.Add("Tên đơn vị");

            _dataLoaiThuoc = new DataTable();
            _dataLoaiThuoc.Columns.Add("STT");
            _dataLoaiThuoc.Columns.Add("Tên loại thuốc");

            _dataQuyDinh = new DataTable();
            _dataQuyDinh.Columns.Add("STT");
            _dataQuyDinh.Columns.Add("Tên quy định");
            _dataQuyDinh.Columns.Add("Tỉ lệ chiết khấu");

            for (int i = 0; i < _listdonvi.Count; i++)
            {
                DataRow Rows = _datatable.NewRow();
                Rows["STT"] = i + 1;
                Rows["Tên đơn vị"] = _listdonvi[i].TEN;
                _datatable.Rows.Add(Rows);

            }
            for (int i = 0; i < _listLoaiThuoc.Count; i++)
            {
                DataRow Rows = _dataLoaiThuoc.NewRow();
                Rows["STT"] = i + 1;
                Rows["Tên loại thuốc"] = _listLoaiThuoc[i].TENLOAITHUOC;
                _dataLoaiThuoc.Rows.Add(Rows);
            }
            for (int i = 0; i < _listquydinh.Count; i++)
            {
                DataRow Rows = _dataQuyDinh.NewRow();
                Rows["STT"] = i + 1;
                Rows["Tên quy định"] = _listquydinh[i].TENQUYDINH;
                Rows["Tỉ lệ chiết khấu"] = _listquydinh[i].PHANTRAMCHIETKHAU;
                _dataQuyDinh.Rows.Add(Rows);

            }
            grd_Donvi.DataSource = _datatable;
            grd_LoaiThuoc.DataSource = _dataLoaiThuoc;
            grd_Quydinh.DataSource = _dataQuyDinh;


        }
        private void FormDonvi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                _donvi = gridView1.GetFocusedRowCellValue(gridView1.Columns["Tên đơn vị"]).ToString();
                donvi = new DONVITINH();
                if (_donvi != null)
                {
                    donvi = Data.DONVITINHs.Where(dv => dv.TEN == _donvi).SingleOrDefault<DONVITINH>();
                    txt_DonVi.Text = donvi.TEN;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                _loaithuoc = gridView2.GetFocusedRowCellValue(gridView2.Columns["Tên loại thuốc"]).ToString();
                loaithuoc = new LOAITHUOC();
                if (_loaithuoc != null)
                {
                    loaithuoc = Data.LOAITHUOCs.Where(lt => lt.TENLOAITHUOC == _loaithuoc).SingleOrDefault<LOAITHUOC>();
                    txtLoaiThuoc.Text = loaithuoc.TENLOAITHUOC;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (donvi != null)
                {
                    donvi.TEN = txt_DonVi.Text;

                    Data.SubmitChanges();
                    _listdonvi = Data.DONVITINHs.ToList();
                    LoadData();
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                }
                else
                {
                    donvi = new DONVITINH();
                    donvi.TEN = txt_DonVi.Text;
                    Data.DONVITINHs.InsertOnSubmit(donvi);
                    Data.SubmitChanges();
                    _listdonvi = Data.DONVITINHs.ToList();
                    LoadData();
                    MessageBox.Show("Thêm mới thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_DonVi.Text = "";
            donvi = null;
        }

        

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (donvi != null)
                {
                    Data.DONVITINHs.DeleteOnSubmit(donvi);
                    Data.SubmitChanges();
                    _listdonvi = Data.DONVITINHs.ToList();
                    LoadData();
                    MessageBox.Show("Xóa thông tin thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_XoaLT_Click(object sender, EventArgs e)
        {
            try
            {
                if (loaithuoc != null)
                {
                    Data.LOAITHUOCs.DeleteOnSubmit(loaithuoc);
                    Data.SubmitChanges();
                    _listLoaiThuoc = Data.LOAITHUOCs.ToList();
                    LoadData();
                    MessageBox.Show("Xóa thông tin thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_LuuLT_Click(object sender, EventArgs e)
        {
            try
            {
                if (loaithuoc != null)
                {
                    loaithuoc.TENLOAITHUOC = txtLoaiThuoc.Text;
                    Data.SubmitChanges();
                    _listLoaiThuoc = Data.LOAITHUOCs.ToList();
                    LoadData();
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                }
                else
                {
                    loaithuoc = new LOAITHUOC();
                    loaithuoc.TENLOAITHUOC = txtLoaiThuoc.Text;
                    Data.LOAITHUOCs.InsertOnSubmit(loaithuoc);
                    Data.SubmitChanges();
                    _listLoaiThuoc = Data.LOAITHUOCs.ToList();
                    LoadData();
                    MessageBox.Show("Thêm mới thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ThemLoaiThuoc_Click(object sender, EventArgs e)
        {
            txtLoaiThuoc.Text = "";
            loaithuoc = null;
        }

        private void gridView3_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                _tenquydinh = gridView3.GetFocusedRowCellValue(gridView3.Columns["Tên quy định"]).ToString();
                quydinh = new QUYDINH();
                if (_tenquydinh != null)
                {
                    quydinh = Data.QUYDINHs.Where(qd => qd.TENQUYDINH == _tenquydinh).SingleOrDefault<QUYDINH>();
                    txt_TenQD.Text = quydinh.TENQUYDINH;
                    txt_Tile.Text = Convert.ToString(quydinh.PHANTRAMCHIETKHAU);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_XoaQD_Click(object sender, EventArgs e)
        {
            try
            {
                if (quydinh != null)
                {
                    Data.QUYDINHs.DeleteOnSubmit(quydinh);
                    Data.SubmitChanges();
                    _listquydinh = Data.QUYDINHs.ToList();
                    LoadData(); MessageBox.Show("Xóa thông tin thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_LuuQD_Click(object sender, EventArgs e)
        {
            try
            {
                if (quydinh != null)
                {
                    quydinh.PHANTRAMCHIETKHAU = Convert.ToInt32(txt_Tile.Text);
                    quydinh.TENQUYDINH = txt_TenQD.Text;
                    Data.SubmitChanges();
                    _listquydinh = Data.QUYDINHs.ToList();
                    LoadData();
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                }
                else
                {
                    quydinh = new QUYDINH();
                    quydinh.TENQUYDINH = txt_TenQD.Text;
                    quydinh.PHANTRAMCHIETKHAU = Convert.ToInt32(txt_Tile.Text);
                    Data.QUYDINHs.InsertOnSubmit(quydinh);
                    Data.SubmitChanges();
                    _listquydinh = Data.QUYDINHs.ToList();
                    LoadData();
                    MessageBox.Show("Thêm mới thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ThemQD_Click(object sender, EventArgs e)
        {
            txt_Tile.Text = "";
            txt_TenQD.Text = "";
            quydinh = null;
        }
    }
}
