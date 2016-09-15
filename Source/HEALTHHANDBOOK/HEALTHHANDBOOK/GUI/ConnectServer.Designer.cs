namespace HEALTHHANDBOOK.GUI
{
    partial class ConnectServer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_name = new System.Windows.Forms.Label();
            this.l_pass = new System.Windows.Forms.Label();
            this.cbx_severname = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbx_auth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ckShowpass = new DevExpress.XtraEditors.CheckEdit();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_severname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_auth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckShowpass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Authentication: ";
            // 
            // L_name
            // 
            this.L_name.AutoSize = true;
            this.L_name.Location = new System.Drawing.Point(72, 85);
            this.L_name.Name = "L_name";
            this.L_name.Size = new System.Drawing.Size(62, 13);
            this.L_name.TabIndex = 2;
            this.L_name.Text = "User name:";
            // 
            // l_pass
            // 
            this.l_pass.AutoSize = true;
            this.l_pass.Location = new System.Drawing.Point(74, 112);
            this.l_pass.Name = "l_pass";
            this.l_pass.Size = new System.Drawing.Size(60, 13);
            this.l_pass.TabIndex = 3;
            this.l_pass.Text = "Password: ";
            // 
            // cbx_severname
            // 
            this.cbx_severname.Location = new System.Drawing.Point(140, 18);
            this.cbx_severname.Name = "cbx_severname";
            this.cbx_severname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_severname.Properties.Appearance.Options.UseFont = true;
            this.cbx_severname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_severname.Size = new System.Drawing.Size(246, 24);
            this.cbx_severname.TabIndex = 2;
            // 
            // cbx_auth
            // 
            this.cbx_auth.Location = new System.Drawing.Point(140, 55);
            this.cbx_auth.Name = "cbx_auth";
            this.cbx_auth.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_auth.Properties.Appearance.Options.UseFont = true;
            this.cbx_auth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_auth.Size = new System.Drawing.Size(246, 24);
            this.cbx_auth.TabIndex = 5;
            this.cbx_auth.SelectedIndexChanged += new System.EventHandler(this.Authen_IndexChanged);
            // 
            // ckShowpass
            // 
            this.ckShowpass.Location = new System.Drawing.Point(202, 139);
            this.ckShowpass.Name = "ckShowpass";
            this.ckShowpass.Properties.Caption = "Show password";
            this.ckShowpass.Size = new System.Drawing.Size(106, 19);
            this.ckShowpass.TabIndex = 6;
            this.ckShowpass.CheckedChanged += new System.EventHandler(this.ckShowpass_CheckedChanged);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(182, 173);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(84, 27);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Text = "Connect";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX2.Location = new System.Drawing.Point(302, 173);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(84, 27);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolColor = System.Drawing.Color.Red;
            this.buttonX2.TabIndex = 8;
            this.buttonX2.Text = "Cancel";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(202, 85);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(184, 21);
            this.txt_name.TabIndex = 9;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(202, 112);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(184, 21);
            this.txt_pass.TabIndex = 10;
            // 
            // ConnectServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 219);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.ckShowpass);
            this.Controls.Add(this.cbx_auth);
            this.Controls.Add(this.cbx_severname);
            this.Controls.Add(this.l_pass);
            this.Controls.Add(this.L_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConnectServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONNECT SERVER";
            this.Load += new System.EventHandler(this.ConnectServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbx_severname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_auth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckShowpass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_name;
        private System.Windows.Forms.Label l_pass;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_severname;
        private DevExpress.XtraEditors.ComboBoxEdit cbx_auth;
        private DevExpress.XtraEditors.CheckEdit ckShowpass;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pass;
    }
}