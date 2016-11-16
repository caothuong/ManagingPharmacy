namespace QUANLYNHATHUOC.GUI
{
    partial class FormDanhSachThuoc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridDSTHUOC = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grd_DSThuoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tenthuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_LoaiThuoc = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.ImageNV = new System.Windows.Forms.PictureBox();
            this.bteditImage = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tb_trinhbay = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tb_tuongtacthuoc = new System.Windows.Forms.RichTextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tb_phanungphu = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tb_thantrong = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_chongchidinh = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_chidinh = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_lieudung = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_NSX = new System.Windows.Forms.Label();
            this.lb_DVT = new System.Windows.Forms.Label();
            this.lb_SL = new System.Windows.Forms.Label();
            this.lb_Gia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_TenThuoc = new System.Windows.Forms.Label();
            this.gbThanhPhan = new System.Windows.Forms.GroupBox();
            this.tb_Thanhphan = new System.Windows.Forms.RichTextBox();
            this.Xoa = new System.Windows.Forms.Button();
            this.Capnhat = new System.Windows.Forms.Button();
            this.Luu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSTHUOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DSThuoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageNV)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbThanhPhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridDSTHUOC);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(3, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 574);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thuốc";
            // 
            // gridDSTHUOC
            // 
            this.gridDSTHUOC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gridDSTHUOC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDSTHUOC.Location = new System.Drawing.Point(3, 17);
            this.gridDSTHUOC.MainView = this.gridView1;
            this.gridDSTHUOC.Name = "gridDSTHUOC";
            this.gridDSTHUOC.Size = new System.Drawing.Size(545, 554);
            this.gridDSTHUOC.TabIndex = 0;
            this.gridDSTHUOC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.grd_DSThuoc});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridDSTHUOC;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // grd_DSThuoc
            // 
            this.grd_DSThuoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Tenthuoc,
            this.NSX,
            this.SL,
            this.DV,
            this.GB});
            this.grd_DSThuoc.GridControl = this.gridDSTHUOC;
            this.grd_DSThuoc.Name = "grd_DSThuoc";
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            // 
            // Tenthuoc
            // 
            this.Tenthuoc.Caption = "Tên Thuốc";
            this.Tenthuoc.Name = "Tenthuoc";
            this.Tenthuoc.Visible = true;
            this.Tenthuoc.VisibleIndex = 1;
            // 
            // NSX
            // 
            this.NSX.Caption = "Nhà sản xuất";
            this.NSX.Name = "NSX";
            this.NSX.Visible = true;
            this.NSX.VisibleIndex = 2;
            // 
            // SL
            // 
            this.SL.Caption = "Số Lượng";
            this.SL.Name = "SL";
            this.SL.Visible = true;
            this.SL.VisibleIndex = 3;
            // 
            // DV
            // 
            this.DV.Caption = "Đơn vị";
            this.DV.Name = "DV";
            this.DV.Visible = true;
            this.DV.VisibleIndex = 4;
            // 
            // GB
            // 
            this.GB.Caption = "Giá Bán";
            this.GB.Name = "GB";
            this.GB.Visible = true;
            this.GB.VisibleIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(301, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại thuốc";
            // 
            // cbx_LoaiThuoc
            // 
            this.cbx_LoaiThuoc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbx_LoaiThuoc.FormattingEnabled = true;
            this.cbx_LoaiThuoc.Location = new System.Drawing.Point(363, 16);
            this.cbx_LoaiThuoc.Name = "cbx_LoaiThuoc";
            this.cbx_LoaiThuoc.Size = new System.Drawing.Size(182, 21);
            this.cbx_LoaiThuoc.TabIndex = 1;
            this.cbx_LoaiThuoc.SelectedIndexChanged += new System.EventHandler(this.cbx_LoaiThuoc_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupControl3);
            this.groupBox2.Controls.Add(this.bteditImage);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.gbThanhPhan);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(554, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 598);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControl3.Appearance.Options.UseBackColor = true;
            this.groupControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.groupControl3.Controls.Add(this.ImageNV);
            this.groupControl3.Location = new System.Drawing.Point(6, 20);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(371, 166);
            this.groupControl3.TabIndex = 101;
            this.groupControl3.Text = "Ảnh thuốc";
            // 
            // ImageNV
            // 
            this.ImageNV.Location = new System.Drawing.Point(5, 24);
            this.ImageNV.Name = "ImageNV";
            this.ImageNV.Size = new System.Drawing.Size(361, 137);
            this.ImageNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageNV.TabIndex = 82;
            this.ImageNV.TabStop = false;
            // 
            // bteditImage
            // 
            this.bteditImage.Appearance.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bteditImage.Appearance.Options.UseForeColor = true;
            this.bteditImage.Location = new System.Drawing.Point(379, 159);
            this.bteditImage.Name = "bteditImage";
            this.bteditImage.Size = new System.Drawing.Size(83, 23);
            this.bteditImage.TabIndex = 10;
            this.bteditImage.Text = "Đổi hình";
            this.bteditImage.Click += new System.EventHandler(this.bteditImage_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Transparent;
            this.groupBox9.Controls.Add(this.tb_trinhbay);
            this.groupBox9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox9.Location = new System.Drawing.Point(3, 511);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(759, 80);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Trình bày và đóng gói";
            // 
            // tb_trinhbay
            // 
            this.tb_trinhbay.BackColor = System.Drawing.Color.White;
            this.tb_trinhbay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tb_trinhbay.Location = new System.Drawing.Point(6, 15);
            this.tb_trinhbay.Name = "tb_trinhbay";
            this.tb_trinhbay.ReadOnly = true;
            this.tb_trinhbay.Size = new System.Drawing.Size(755, 62);
            this.tb_trinhbay.TabIndex = 0;
            this.tb_trinhbay.Text = "";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.tb_tuongtacthuoc);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox7.Location = new System.Drawing.Point(388, 429);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(371, 80);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tương tác thuốc";
            // 
            // tb_tuongtacthuoc
            // 
            this.tb_tuongtacthuoc.BackColor = System.Drawing.Color.White;
            this.tb_tuongtacthuoc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tb_tuongtacthuoc.Location = new System.Drawing.Point(6, 15);
            this.tb_tuongtacthuoc.Name = "tb_tuongtacthuoc";
            this.tb_tuongtacthuoc.ReadOnly = true;
            this.tb_tuongtacthuoc.Size = new System.Drawing.Size(359, 62);
            this.tb_tuongtacthuoc.TabIndex = 0;
            this.tb_tuongtacthuoc.Text = "";
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.tb_phanungphu);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox8.Location = new System.Drawing.Point(3, 429);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(374, 80);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Phản ứng phụ";
            // 
            // tb_phanungphu
            // 
            this.tb_phanungphu.BackColor = System.Drawing.Color.White;
            this.tb_phanungphu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tb_phanungphu.Location = new System.Drawing.Point(6, 14);
            this.tb_phanungphu.Name = "tb_phanungphu";
            this.tb_phanungphu.ReadOnly = true;
            this.tb_phanungphu.Size = new System.Drawing.Size(365, 62);
            this.tb_phanungphu.TabIndex = 0;
            this.tb_phanungphu.Text = "";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.tb_thantrong);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox6.Location = new System.Drawing.Point(386, 348);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(373, 80);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thận trọng";
            // 
            // tb_thantrong
            // 
            this.tb_thantrong.BackColor = System.Drawing.Color.White;
            this.tb_thantrong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tb_thantrong.Location = new System.Drawing.Point(6, 15);
            this.tb_thantrong.Name = "tb_thantrong";
            this.tb_thantrong.ReadOnly = true;
            this.tb_thantrong.Size = new System.Drawing.Size(361, 62);
            this.tb_thantrong.TabIndex = 0;
            this.tb_thantrong.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.tb_chongchidinh);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox5.Location = new System.Drawing.Point(3, 348);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(374, 80);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chống chỉ định";
            // 
            // tb_chongchidinh
            // 
            this.tb_chongchidinh.BackColor = System.Drawing.Color.White;
            this.tb_chongchidinh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tb_chongchidinh.Location = new System.Drawing.Point(6, 15);
            this.tb_chongchidinh.Name = "tb_chongchidinh";
            this.tb_chongchidinh.ReadOnly = true;
            this.tb_chongchidinh.Size = new System.Drawing.Size(365, 62);
            this.tb_chongchidinh.TabIndex = 0;
            this.tb_chongchidinh.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.tb_chidinh);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(3, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(759, 80);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chỉ định";
            // 
            // tb_chidinh
            // 
            this.tb_chidinh.BackColor = System.Drawing.Color.White;
            this.tb_chidinh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tb_chidinh.Location = new System.Drawing.Point(6, 15);
            this.tb_chidinh.Name = "tb_chidinh";
            this.tb_chidinh.ReadOnly = true;
            this.tb_chidinh.Size = new System.Drawing.Size(747, 62);
            this.tb_chidinh.TabIndex = 0;
            this.tb_chidinh.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.tb_lieudung);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(388, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 80);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liều dùng và cách dùng";
            // 
            // tb_lieudung
            // 
            this.tb_lieudung.BackColor = System.Drawing.Color.White;
            this.tb_lieudung.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tb_lieudung.Location = new System.Drawing.Point(6, 15);
            this.tb_lieudung.Name = "tb_lieudung";
            this.tb_lieudung.ReadOnly = true;
            this.tb_lieudung.Size = new System.Drawing.Size(365, 62);
            this.tb_lieudung.TabIndex = 0;
            this.tb_lieudung.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_NSX);
            this.panel1.Controls.Add(this.lb_DVT);
            this.panel1.Controls.Add(this.lb_SL);
            this.panel1.Controls.Add(this.lb_Gia);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_TenThuoc);
            this.panel1.Location = new System.Drawing.Point(386, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 100);
            this.panel1.TabIndex = 6;
            // 
            // lb_NSX
            // 
            this.lb_NSX.AutoSize = true;
            this.lb_NSX.Location = new System.Drawing.Point(96, 82);
            this.lb_NSX.Name = "lb_NSX";
            this.lb_NSX.Size = new System.Drawing.Size(35, 13);
            this.lb_NSX.TabIndex = 6;
            this.lb_NSX.Text = "label3";
            // 
            // lb_DVT
            // 
            this.lb_DVT.AutoSize = true;
            this.lb_DVT.Location = new System.Drawing.Point(118, 54);
            this.lb_DVT.Name = "lb_DVT";
            this.lb_DVT.Size = new System.Drawing.Size(28, 13);
            this.lb_DVT.TabIndex = 7;
            this.lb_DVT.Text = "VNĐ";
            // 
            // lb_SL
            // 
            this.lb_SL.AutoSize = true;
            this.lb_SL.Location = new System.Drawing.Point(77, 26);
            this.lb_SL.Name = "lb_SL";
            this.lb_SL.Size = new System.Drawing.Size(35, 13);
            this.lb_SL.TabIndex = 4;
            this.lb_SL.Text = "label2";
            // 
            // lb_Gia
            // 
            this.lb_Gia.AutoSize = true;
            this.lb_Gia.Location = new System.Drawing.Point(77, 54);
            this.lb_Gia.Name = "lb_Gia";
            this.lb_Gia.Size = new System.Drawing.Size(35, 13);
            this.lb_Gia.TabIndex = 5;
            this.lb_Gia.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nhà sản xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Giá bán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số lượng:";
            // 
            // lb_TenThuoc
            // 
            this.lb_TenThuoc.AutoSize = true;
            this.lb_TenThuoc.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenThuoc.Location = new System.Drawing.Point(17, -2);
            this.lb_TenThuoc.Name = "lb_TenThuoc";
            this.lb_TenThuoc.Size = new System.Drawing.Size(55, 18);
            this.lb_TenThuoc.TabIndex = 3;
            this.lb_TenThuoc.Text = "label2";
            // 
            // gbThanhPhan
            // 
            this.gbThanhPhan.BackColor = System.Drawing.Color.Transparent;
            this.gbThanhPhan.Controls.Add(this.tb_Thanhphan);
            this.gbThanhPhan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbThanhPhan.Location = new System.Drawing.Point(3, 188);
            this.gbThanhPhan.Name = "gbThanhPhan";
            this.gbThanhPhan.Size = new System.Drawing.Size(374, 80);
            this.gbThanhPhan.TabIndex = 2;
            this.gbThanhPhan.TabStop = false;
            this.gbThanhPhan.Text = "Thành phần";
            // 
            // tb_Thanhphan
            // 
            this.tb_Thanhphan.BackColor = System.Drawing.Color.White;
            this.tb_Thanhphan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tb_Thanhphan.Location = new System.Drawing.Point(6, 15);
            this.tb_Thanhphan.Name = "tb_Thanhphan";
            this.tb_Thanhphan.ReadOnly = true;
            this.tb_Thanhphan.Size = new System.Drawing.Size(365, 62);
            this.tb_Thanhphan.TabIndex = 0;
            this.tb_Thanhphan.Text = "";
            // 
            // Xoa
            // 
            this.Xoa.Location = new System.Drawing.Point(1158, 619);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(75, 23);
            this.Xoa.TabIndex = 4;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = true;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Capnhat
            // 
            this.Capnhat.Location = new System.Drawing.Point(1077, 619);
            this.Capnhat.Name = "Capnhat";
            this.Capnhat.Size = new System.Drawing.Size(75, 23);
            this.Capnhat.TabIndex = 5;
            this.Capnhat.Text = "Cập nhật";
            this.Capnhat.UseVisualStyleBackColor = true;
            this.Capnhat.Click += new System.EventHandler(this.Capnhat_Click);
            // 
            // Luu
            // 
            this.Luu.Location = new System.Drawing.Point(996, 619);
            this.Luu.Name = "Luu";
            this.Luu.Size = new System.Drawing.Size(75, 23);
            this.Luu.TabIndex = 6;
            this.Luu.Text = "Lưu";
            this.Luu.UseVisualStyleBackColor = true;
            this.Luu.Visible = false;
            this.Luu.Click += new System.EventHandler(this.Luu_Click);
            // 
            // FormDanhSachThuoc
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Luu);
            this.Controls.Add(this.Capnhat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbx_LoaiThuoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDanhSachThuoc";
            this.Size = new System.Drawing.Size(1341, 663);
            this.Load += new System.EventHandler(this.FormDanhSachThuoc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDSTHUOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DSThuoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageNV)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbThanhPhan.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_LoaiThuoc;
        private DevExpress.XtraGrid.GridControl gridDSTHUOC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_DSThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Tenthuoc;
        private DevExpress.XtraGrid.Columns.GridColumn NSX;
        private DevExpress.XtraGrid.Columns.GridColumn SL;
        private DevExpress.XtraGrid.Columns.GridColumn DV;
        private DevExpress.XtraGrid.Columns.GridColumn GB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbThanhPhan;
        private System.Windows.Forms.RichTextBox tb_Thanhphan;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RichTextBox tb_trinhbay;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox tb_tuongtacthuoc;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox tb_phanungphu;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox tb_thantrong;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox tb_chongchidinh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox tb_chidinh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox tb_lieudung;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_NSX;
        private System.Windows.Forms.Label lb_TenThuoc;
        private System.Windows.Forms.Label lb_SL;
        private System.Windows.Forms.Label lb_Gia;
        private System.Windows.Forms.Label lb_DVT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Capnhat;
        private System.Windows.Forms.Button Luu;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.PictureBox ImageNV;
        private DevExpress.XtraEditors.SimpleButton bteditImage;
    }
}
