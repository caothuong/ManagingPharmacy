namespace QUANLYNHATHUOC.GUI
{
    partial class FormDonvi
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
            this.grd_Donvi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txt_DonVi = new System.Windows.Forms.TextBox();
            this.grd_LoaiThuoc = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtLoaiThuoc = new System.Windows.Forms.TextBox();
            this.btn_LuuLT = new System.Windows.Forms.Button();
            this.btn_XoaLT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ThemLoaiThuoc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grd_Quydinh = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_ThemQD = new System.Windows.Forms.Button();
            this.txt_TenQD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_LuuQD = new System.Windows.Forms.Button();
            this.btn_XoaQD = new System.Windows.Forms.Button();
            this.txt_Tile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Donvi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_LoaiThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Quydinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Donvi
            // 
            this.grd_Donvi.Location = new System.Drawing.Point(6, 97);
            this.grd_Donvi.MainView = this.gridView1;
            this.grd_Donvi.Name = "grd_Donvi";
            this.grd_Donvi.Size = new System.Drawing.Size(321, 299);
            this.grd_Donvi.TabIndex = 0;
            this.grd_Donvi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grd_Donvi;
            this.gridView1.GroupPanelText = "Danh sách đơn vị";
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // btn_Them
            // 
            this.btn_Them.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Them.Location = new System.Drawing.Point(264, 9);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(59, 23);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đơn vị:";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Xoa.Location = new System.Drawing.Point(264, 68);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(59, 23);
            this.btn_Xoa.TabIndex = 3;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_sua.Location = new System.Drawing.Point(264, 39);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(59, 23);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Lưu ";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txt_DonVi
            // 
            this.txt_DonVi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_DonVi.Location = new System.Drawing.Point(86, 31);
            this.txt_DonVi.Name = "txt_DonVi";
            this.txt_DonVi.Size = new System.Drawing.Size(121, 21);
            this.txt_DonVi.TabIndex = 5;
            // 
            // grd_LoaiThuoc
            // 
            this.grd_LoaiThuoc.Location = new System.Drawing.Point(6, 97);
            this.grd_LoaiThuoc.MainView = this.gridView2;
            this.grd_LoaiThuoc.Name = "grd_LoaiThuoc";
            this.grd_LoaiThuoc.Size = new System.Drawing.Size(321, 299);
            this.grd_LoaiThuoc.TabIndex = 6;
            this.grd_LoaiThuoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grd_LoaiThuoc;
            this.gridView2.GroupPanelText = "Danh sách loại thuốc";
            this.gridView2.Name = "gridView2";
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            // 
            // txtLoaiThuoc
            // 
            this.txtLoaiThuoc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtLoaiThuoc.Location = new System.Drawing.Point(110, 31);
            this.txtLoaiThuoc.Name = "txtLoaiThuoc";
            this.txtLoaiThuoc.Size = new System.Drawing.Size(121, 21);
            this.txtLoaiThuoc.TabIndex = 11;
            // 
            // btn_LuuLT
            // 
            this.btn_LuuLT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_LuuLT.Location = new System.Drawing.Point(257, 39);
            this.btn_LuuLT.Name = "btn_LuuLT";
            this.btn_LuuLT.Size = new System.Drawing.Size(59, 23);
            this.btn_LuuLT.TabIndex = 10;
            this.btn_LuuLT.Text = "Lưu ";
            this.btn_LuuLT.UseVisualStyleBackColor = true;
            this.btn_LuuLT.Click += new System.EventHandler(this.btn_LuuLT_Click);
            // 
            // btn_XoaLT
            // 
            this.btn_XoaLT.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_XoaLT.Location = new System.Drawing.Point(257, 68);
            this.btn_XoaLT.Name = "btn_XoaLT";
            this.btn_XoaLT.Size = new System.Drawing.Size(59, 23);
            this.btn_XoaLT.TabIndex = 9;
            this.btn_XoaLT.Text = "Xóa";
            this.btn_XoaLT.UseVisualStyleBackColor = true;
            this.btn_XoaLT.Click += new System.EventHandler(this.btn_XoaLT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(30, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên loại thuốc";
            // 
            // btn_ThemLoaiThuoc
            // 
            this.btn_ThemLoaiThuoc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ThemLoaiThuoc.Location = new System.Drawing.Point(257, 9);
            this.btn_ThemLoaiThuoc.Name = "btn_ThemLoaiThuoc";
            this.btn_ThemLoaiThuoc.Size = new System.Drawing.Size(59, 23);
            this.btn_ThemLoaiThuoc.TabIndex = 7;
            this.btn_ThemLoaiThuoc.Text = "Thêm";
            this.btn_ThemLoaiThuoc.UseVisualStyleBackColor = true;
            this.btn_ThemLoaiThuoc.Click += new System.EventHandler(this.btn_ThemLoaiThuoc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_DonVi);
            this.groupBox1.Controls.Add(this.grd_Donvi);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 399);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý đơn vị tính";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grd_LoaiThuoc);
            this.groupBox2.Controls.Add(this.btn_ThemLoaiThuoc);
            this.groupBox2.Controls.Add(this.txtLoaiThuoc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_LuuLT);
            this.groupBox2.Controls.Add(this.btn_XoaLT);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(385, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 399);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý thông tin loại thuốc";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_Tile);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.grd_Quydinh);
            this.groupBox3.Controls.Add(this.btn_ThemQD);
            this.groupBox3.Controls.Add(this.txt_TenQD);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btn_LuuQD);
            this.groupBox3.Controls.Add(this.btn_XoaQD);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(766, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 399);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quản lý thông tin quy định";
            // 
            // grd_Quydinh
            // 
            this.grd_Quydinh.Location = new System.Drawing.Point(6, 97);
            this.grd_Quydinh.MainView = this.gridView3;
            this.grd_Quydinh.Name = "grd_Quydinh";
            this.grd_Quydinh.Size = new System.Drawing.Size(321, 299);
            this.grd_Quydinh.TabIndex = 6;
            this.grd_Quydinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.grd_Quydinh;
            this.gridView3.GroupPanelText = "Danh sách quy định";
            this.gridView3.Name = "gridView3";
            this.gridView3.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView3_RowClick);
            // 
            // btn_ThemQD
            // 
            this.btn_ThemQD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_ThemQD.Location = new System.Drawing.Point(257, 9);
            this.btn_ThemQD.Name = "btn_ThemQD";
            this.btn_ThemQD.Size = new System.Drawing.Size(59, 23);
            this.btn_ThemQD.TabIndex = 7;
            this.btn_ThemQD.Text = "Thêm";
            this.btn_ThemQD.UseVisualStyleBackColor = true;
            this.btn_ThemQD.Click += new System.EventHandler(this.btn_ThemQD_Click);
            // 
            // txt_TenQD
            // 
            this.txt_TenQD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_TenQD.Location = new System.Drawing.Point(95, 23);
            this.txt_TenQD.Name = "txt_TenQD";
            this.txt_TenQD.Size = new System.Drawing.Size(121, 21);
            this.txt_TenQD.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên quy định";
            // 
            // btn_LuuQD
            // 
            this.btn_LuuQD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_LuuQD.Location = new System.Drawing.Point(257, 39);
            this.btn_LuuQD.Name = "btn_LuuQD";
            this.btn_LuuQD.Size = new System.Drawing.Size(59, 23);
            this.btn_LuuQD.TabIndex = 10;
            this.btn_LuuQD.Text = "Lưu ";
            this.btn_LuuQD.UseVisualStyleBackColor = true;
            this.btn_LuuQD.Click += new System.EventHandler(this.btn_LuuQD_Click);
            // 
            // btn_XoaQD
            // 
            this.btn_XoaQD.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_XoaQD.Location = new System.Drawing.Point(257, 68);
            this.btn_XoaQD.Name = "btn_XoaQD";
            this.btn_XoaQD.Size = new System.Drawing.Size(59, 23);
            this.btn_XoaQD.TabIndex = 9;
            this.btn_XoaQD.Text = "Xóa";
            this.btn_XoaQD.UseVisualStyleBackColor = true;
            this.btn_XoaQD.Click += new System.EventHandler(this.btn_XoaQD_Click);
            // 
            // txt_Tile
            // 
            this.txt_Tile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_Tile.Location = new System.Drawing.Point(95, 56);
            this.txt_Tile.Name = "txt_Tile";
            this.txt_Tile.Size = new System.Drawing.Size(77, 21);
            this.txt_Tile.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(15, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tỉ lệ chiết khấu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(176, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "(%)";
            // 
            // FormDonvi
            // 
            this.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDonvi";
            this.Size = new System.Drawing.Size(1109, 413);
            this.Load += new System.EventHandler(this.FormDonvi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Donvi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_LoaiThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Quydinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grd_Donvi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.TextBox txt_DonVi;
        private DevExpress.XtraGrid.GridControl grd_LoaiThuoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TextBox txtLoaiThuoc;
        private System.Windows.Forms.Button btn_LuuLT;
        private System.Windows.Forms.Button btn_XoaLT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ThemLoaiThuoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Tile;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl grd_Quydinh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Button btn_ThemQD;
        private System.Windows.Forms.TextBox txt_TenQD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_LuuQD;
        private System.Windows.Forms.Button btn_XoaQD;
    }
}
