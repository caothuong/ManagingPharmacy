using System;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Forms;
using QUANLYNHATHUOC.Database;
using System.Collections;

namespace QUANLYNHATHUOC.GUI
{
    public partial class FormDanhSachThuoc : DevExpress.XtraEditors.XtraUserControl
    {
        QUANLYNHATHUOCDATADataContext Data = new QUANLYNHATHUOCDATADataContext(DatabaseManager.DbConnection.SqlConn);
        List<THUOC> listThuoc;
        List<LOAITHUOC> listLoaiThuoc;
        DataTable _datatable;
        string _tenthuoc = "";
        THUOC _thuoc;
        FileStream stream;
        String _pathOld;
        public FormDanhSachThuoc()
        {
            listThuoc = Data.THUOCs.ToList();
            listLoaiThuoc = Data.LOAITHUOCs.ToList();
            InitializeComponent();
            cbx_LoaiThuoc.DataSource = listLoaiThuoc;
            cbx_LoaiThuoc.DisplayMember = "TENLOAITHUOC";
        }

        public void LoadData()
        {
            _datatable = new DataTable();
            _datatable.Columns.Add("STT");
            _datatable.Columns.Add("Tên Thuốc");
            _datatable.Columns.Add("Loại Thuốc");
            _datatable.Columns.Add("Nhà sản xuất");
            _datatable.Columns.Add("Số lượng");
            _datatable.Columns.Add("Đơn vị");
            _datatable.Columns.Add("Đơn giá");

            for (int i = 0; i < listThuoc.Count; i++)
            {
                DataRow Rows = _datatable.NewRow();
                Rows["STT"] = i + 1;
                Rows["Tên Thuốc"] = listThuoc[i].TENTHUOC;
                Rows["Loại Thuốc"] = listThuoc[i].LOAITHUOC;
                Rows["Nhà sản xuất"] = listThuoc[i].NHASANXUAT;
                Rows["Số lượng"] = listThuoc[i].SOLUONG;
                Rows["Đơn vị"] = listThuoc[i].DONVI;
                Rows["Đơn giá"] = listThuoc[i].GIABAN;

                _datatable.Rows.Add(Rows);

            }
            gridDSTHUOC.DataSource = _datatable;
        }
        private System.Drawing.Image GetHinhAnhTuPoster(string _Poster)
        {
            BitmapImage bImg = new BitmapImage();

            Stream bm_Stream = new FileStream("../Release/Image/Thuoc/" + _Poster + ".png", FileMode.Open);
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            MemoryStream memoryStream = new MemoryStream();
            encoder.Frames.Add(BitmapFrame.Create(bm_Stream));
            encoder.Interlace = PngInterlaceOption.On;
            encoder.Save(memoryStream);
            System.Drawing.Image img = System.Drawing.Image.FromStream(memoryStream);
            bm_Stream.Close();
            return img;
        }
        private void FormDanhSachThuoc_Load(object sender, EventArgs e)
        {
            LoadData();
            _thuoc = Data.THUOCs.Where(th => th.TENTHUOC == _tenthuoc).SingleOrDefault<THUOC>();
        }



        private void cbx_LoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listLoaiThuoc[cbx_LoaiThuoc.SelectedIndex].TENLOAITHUOC.ToString() != "")
            {
                listThuoc = Data.THUOCs.Where(thuoc => thuoc.LOAITHUOC == listLoaiThuoc[cbx_LoaiThuoc.SelectedIndex].TENLOAITHUOC.ToString()).ToList();
                LoadData();
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            _tenthuoc = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên Thuốc").ToString();
            _thuoc = new THUOC();
            if (_tenthuoc != "")
            {
                _thuoc = Data.THUOCs.Where(th => th.TENTHUOC == _tenthuoc).SingleOrDefault<THUOC>();
                if (_thuoc != null)
                {
                    try
                    {
                        MessageBox.Show(_thuoc.NHASANXUAT.ToString());
                        lb_TenThuoc.Text = _thuoc.TENTHUOC + " - " + _thuoc.LOAITHUOC;
                        lb_Gia.Text = _thuoc.GIABAN.ToString();
                        lb_NSX.Text = _thuoc.NHASANXUAT.ToString();
                        lb_SL.Text = Convert.ToString(_thuoc.SOLUONG).ToString();
                        lb_DVT.Text = Convert.ToString(_thuoc.DONVI).ToString();
                        tb_Thanhphan.Text = _thuoc.THANHPHAN;
                        tb_chidinh.Text = _thuoc.CHIDINH;
                        tb_chongchidinh.Text = _thuoc.CHONGCHIDINH;
                        tb_lieudung.Text = _thuoc.LIEUDUNG;
                        tb_phanungphu.Text = _thuoc.PHANUNGPHU;
                        tb_thantrong.Text = _thuoc.THANTRONG;
                        tb_trinhbay.Text = _thuoc.TRINHBAYDONGGOI;
                        tb_tuongtacthuoc.Text = _thuoc.TUONGTACTHUOC;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                _tenthuoc = gridView1.GetFocusedRowCellValue(gridView1.Columns["Tên Thuốc"]).ToString();
                _thuoc = new THUOC();
                if (_tenthuoc != null)
                {
                    _thuoc = Data.THUOCs.Where(th => th.TENTHUOC == _tenthuoc).SingleOrDefault<THUOC>();
                    lb_TenThuoc.Text = _thuoc.TENTHUOC + " - " + _thuoc.LOAITHUOC;
                    lb_Gia.Text = Convert.ToString(_thuoc.GIABAN);
                    lb_NSX.Text = _thuoc.NHASANXUAT;
                    lb_SL.Text = Convert.ToString(_thuoc.SOLUONG);
                    tb_Thanhphan.Text = _thuoc.THANHPHAN;
                    tb_chidinh.Text = _thuoc.CHIDINH;
                    tb_chongchidinh.Text = _thuoc.CHONGCHIDINH;
                    tb_lieudung.Text = _thuoc.LIEUDUNG;
                    tb_phanungphu.Text = _thuoc.PHANUNGPHU;
                    tb_thantrong.Text = _thuoc.THANTRONG;
                    tb_trinhbay.Text = _thuoc.TRINHBAYDONGGOI;
                    tb_tuongtacthuoc.Text = _thuoc.TUONGTACTHUOC;
                    _pathOld = _thuoc.HINHANH;
                    ImageNV.Image = GetHinhAnhTuPoster(_pathOld);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Capnhat_Click(object sender, EventArgs e)
        {
            Capnhat.Visible = false;
            Luu.Visible = true;
            Xoa.Visible = false;

            tb_tuongtacthuoc.ReadOnly = false;
            tb_trinhbay.ReadOnly = false;
            tb_thantrong.ReadOnly = false;
            tb_Thanhphan.ReadOnly = false;
            tb_phanungphu.ReadOnly = false;
            tb_lieudung.ReadOnly = false;
            tb_chongchidinh.ReadOnly = false;
            tb_chidinh.ReadOnly = false;

        }

        private void Luu_Click(object sender, EventArgs e)
        {
            try
            {

                if (_thuoc != null)
                {
                    _thuoc.TUONGTACTHUOC = tb_tuongtacthuoc.Text;
                    _thuoc.TRINHBAYDONGGOI = tb_trinhbay.Text;
                    _thuoc.THANTRONG = tb_thantrong.Text;
                    _thuoc.THANHPHAN = tb_Thanhphan.Text;
                    _thuoc.PHANUNGPHU = tb_phanungphu.Text;
                    _thuoc.LIEUDUNG = tb_lieudung.Text;
                    _thuoc.CHONGCHIDINH = tb_chongchidinh.Text;
                    _thuoc.CHIDINH = tb_chidinh.Text;
                    Data.SubmitChanges();
                    listThuoc = Data.THUOCs.ToList();
                    LoadData();
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Capnhat.Visible = true;
            Luu.Visible = false;
            Xoa.Visible = true;
            tb_tuongtacthuoc.ReadOnly = true;
            tb_trinhbay.ReadOnly = true;
            tb_thantrong.ReadOnly = true;
            tb_Thanhphan.ReadOnly = true;
            tb_phanungphu.ReadOnly = true;
            tb_lieudung.ReadOnly = true;
            tb_chongchidinh.ReadOnly = true;
            tb_chidinh.ReadOnly = true;

        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                _thuoc = Data.THUOCs.Where(th => th.TENTHUOC == _tenthuoc).SingleOrDefault<THUOC>();
                if (_thuoc != null)
                {
                    Data.THUOCs.DeleteOnSubmit(_thuoc);
                    Data.SubmitChanges();
                    MessageBox.Show("Xóa thông tin thuốc: " + _thuoc.TENTHUOC + " thành công!", "Thông báo");
                    listThuoc = Data.THUOCs.ToList();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        private void bteditImage_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif";
            Nullable<bool> result = dlg.ShowDialog();
            string ImagePath;
            if (result == true)
            {
                ImagePath = dlg.FileName;
                var uri = new Uri(ImagePath);
                stream = new FileStream("../Release/Image/Thuoc/" + _thuoc.HINHANH + ".png", FileMode.Create);
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Interlace = PngInterlaceOption.On;
                encoder.Frames.Add(BitmapFrame.Create(uri));
                encoder.Save(stream);
                stream.Flush();
                stream.Close();
                ImagePath = stream.Name;
                ImageNV.Image = System.Drawing.Image.FromFile(dlg.FileName);

            }
        }
    }
}
