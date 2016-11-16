using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraTabbedMdi;
using System.IO;
using QUANLYNHATHUOC.GUI;

namespace HEALTHHANDBOOK.GUI
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public Main()
        {
            InitializeComponent();
        }
        void navBarControl_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
           
        }
        public void AddTabControl(string TabNameAdd, Form UserControl)
        {
            DevExpress.XtraTab.XtraTabPage TAbAdd = new DevExpress.XtraTab.XtraTabPage();
            TAbAdd.Text = TabNameAdd;
            UserControl.TopLevel = false;
            UserControl.AutoScroll = true;
            tabControl.SelectedTabPageIndex = tabControl.TabPages.Count - 1;
            TAbAdd.Controls.Add(UserControl);
            UserControl.Dock = DockStyle.Fill;
            UserControl.Show();
            tabControl.TabPages.Add(TAbAdd);
        }
        public void AddTabControl(string TabNameAdd, UserControl UserControl)
        {
            DevExpress.XtraTab.XtraTabPage TAbAdd = new DevExpress.XtraTab.XtraTabPage();
            TAbAdd.Text = TabNameAdd;
            //UserControl.TopLevelControl = false;
            UserControl.AutoScroll = true;
            tabControl.SelectedTabPageIndex = tabControl.TabPages.Count - 1;
            TAbAdd.Controls.Add(UserControl);
            UserControl.Dock = DockStyle.Fill;
            UserControl.Show();
            tabControl.TabPages.Add(TAbAdd);
        }

        private bool checkTab(string name)
        {
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                if (tabControl.TabPages[i].Text == name)
                {
                    tabControl.SelectedTabPageIndex = i;
                    return true;
                }
            }
            return false;
        }
        //private void barBtnLoaiNV_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    if (checkTab("Loại nhân viên") == false)
        //    {
        //        AddTabControl("Loại nhân viên", new frmLoainhanvien());
        //    }
        //}
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
         
        }

        private void officeNavigationBar_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            tabControl.TabPages.RemoveAt(tabControl.SelectedTabPageIndex);
            tabControl.SelectedTabPageIndex = tabControl.TabPages.Count - 1;
        }

        private void barSubItemNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkTab("Quản lý thuốc") == false)
            {
                AddTabControl("Quản lý thuốc", new FormDanhSachThuoc());
            }
        }

        private void barBtn_ThemThuoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (checkTab("Thêm thuốc") == false)
            {
                AddTabControl("Thêm thuốc", new FormThemThongTinThuoc());
            }
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (checkTab("Quản lý đơn vị") == false)
            {
                AddTabControl("Quản lý đơn vị", new FormDonvi());
            }
        }
    }
}