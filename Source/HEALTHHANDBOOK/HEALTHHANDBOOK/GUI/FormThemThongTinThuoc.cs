using System;
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
using DevExpress.XtraEditors;
using QUANLYNHATHUOC.Database;

namespace QUANLYNHATHUOC.GUI
{
    public partial class FormThemThongTinThuoc : UserControl
    {
        QUANLYNHATHUOCDATADataContext Data = new QUANLYNHATHUOCDATADataContext(DatabaseManager.DbConnection.SqlConn);
        FileStream stream;
        String _pathOld;
        public FormThemThongTinThuoc()
        {
            InitializeComponent();
            cb_donvi.DataSource = Data.DONVITINHs.ToList();
            cb_donvi.DisplayMember = "TEN";
            cb_LoaiThuoc.DataSource = Data.LOAITHUOCs.ToList();
            cb_LoaiThuoc.DisplayMember = "TENLOAITHUOC";
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            txt_TenThuoc.Text = "";
            cb_LoaiThuoc.Text = "";
            txt_NSX.Text = "";
            cb_donvi.Text = "";
            txt_Giaban.Text="";
            tb_tuongtacthuoc.Text="";
            tb_trinhbay.Text="";
            tb_thantrong.Text="";
            tb_thanhphan.Text="";
            tb_phanungphu.Text="";
            tb_lieudung.Text="";
            tb_chongchidinh.Text="";
            tb_chidinh.Text="";
            txt_TenThuoc.Text="";
            ImageNV.Image = null;
        }

        private System.Drawing.Image GetHinhAnhTuPoster(string _Poster)
        {
            BitmapImage bImg = new BitmapImage();

            Stream bm_Stream = new FileStream("../Release/Image/Thuoc/" + _Poster, FileMode.Open);
            PngBitmapEncoder encoder = new PngBitmapEncoder();
            MemoryStream memoryStream = new MemoryStream();
            encoder.Frames.Add(BitmapFrame.Create(bm_Stream));
            encoder.Interlace = PngInterlaceOption.On;
            encoder.Save(memoryStream);
            System.Drawing.Image img = System.Drawing.Image.FromStream(memoryStream);
            bm_Stream.Close();
            return img;
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {

                THUOC _thuoc = new THUOC();
                _thuoc.TENTHUOC = txt_TenThuoc.Text;
                _thuoc.LOAITHUOC = cb_LoaiThuoc.Text;
                _thuoc.NHASANXUAT = txt_NSX.Text;
                _thuoc.DONVI = cb_donvi.Text;
                _thuoc.GIABAN = txt_Giaban.Text;
                _thuoc.TUONGTACTHUOC = tb_tuongtacthuoc.Text;
                _thuoc.TRINHBAYDONGGOI = tb_trinhbay.Text;
                _thuoc.THANTRONG = tb_thantrong.Text;
                _thuoc.THANHPHAN = tb_thanhphan.Text;
                _thuoc.PHANUNGPHU = tb_phanungphu.Text;
                _thuoc.LIEUDUNG = tb_lieudung.Text;
                _thuoc.CHONGCHIDINH = tb_chongchidinh.Text;
                _thuoc.CHIDINH = tb_chidinh.Text;
                _thuoc.HINHANH = txt_TenThuoc.Text;
                saveImage(txt_TenThuoc.Text);

                Data.THUOCs.InsertOnSubmit(_thuoc);
                Data.SubmitChanges();
                MessageBox.Show("Thêm thuốc mới thành công.", "Thông báo");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void saveImage(String path)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif";
            string ImagePath;
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                ImagePath = dlg.FileName;
                var uri = new Uri(ImagePath);
                stream = new FileStream("../Release/Image/Thuoc/" + path + ".png", FileMode.Create);
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Interlace = PngInterlaceOption.On;
                encoder.Frames.Add(BitmapFrame.Create(uri));
                encoder.Save(stream);
                stream.Flush();
                stream.Close();
                ImagePath = stream.Name;
                //ImageNV.Image = System.Drawing.Image.FromFile(dlg.FileName);

            }
        }
        private void bteditImage_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif";
            //string ImagePath;
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                //ImagePath = dlg.FileName;
                //var uri = new Uri(ImagePath);
                //stream = new FileStream("../Release/Image/Thuoc/" + txt_TenThuoc.Text + ".png", FileMode.Create);
                //PngBitmapEncoder encoder = new PngBitmapEncoder();
                //encoder.Interlace = PngInterlaceOption.On;
                //encoder.Frames.Add(BitmapFrame.Create(uri));
                //encoder.Save(stream);
                //stream.Flush();
                //stream.Close();
                //ImagePath = stream.Name;
                ImageNV.Image = System.Drawing.Image.FromFile(dlg.FileName);

            }
        }
    }
}
