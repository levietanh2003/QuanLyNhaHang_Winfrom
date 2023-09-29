﻿using quanLyNhaHang_Nhom4.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyNhaHang_Nhom4.Manager
{
    public partial class frmMain : Form
    {
        private Form currentchildform;
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; changeAccount(loginAccount.typeAccount); }
        }

        public frmMain()
        {
            InitializeComponent();
            customizeDesing();
            lblTitle.Text = "Giới thiệu";
            this.pnlDesktop.Controls.Clear();
            frmHome frmHome = new frmHome()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add(frmHome);
            frmHome.Show();
        }

        #region Method
        private void customizeDesing()
        {
            pnlSubAdmin.Visible = false;
            pnlSubWareHouse.Visible = false;
        }
       
        private void hideSubMenu()
        {
            if(pnlSubAdmin.Visible)
            {
                pnlSubAdmin.Visible = false;
            }
            if(pnlSubWareHouse.Visible)
            {
                pnlSubWareHouse.Visible = false;
            }
        }
        private void showSubMeNu(Panel subMenu)
        {
            if(!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        void changeAccount(int type)
        {
            btnAdmin.Enabled = type == 1;
            btnWareHouse.Enabled = type == 1;
            btnOpenFormAttendance.Enabled = type == 1;
            //lblXinChao.Text = "Xin chào " + loginAccount.DisplayName + " !";
            //btnDisplayName.Text = "Xin chào " + loginAccount.displayName + " !";
            //btnInfoAccount.Text += " (" + loginAccount.DisplayName + ")";
        }
        //private void openChildForm(Form childForm)
        //{
        //    if (currentchildform != null)
        //    {
        //        currentchildform.Close();
        //    }
        //    currentchildform = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    pnlDesktop.Controls.Add(childForm);
        //    pnlDesktop.Tag = childForm;
        //    childForm.Show();
        //    lblTitle.Text = childForm.Text;
        //}
        private void Reset()
        {
            hideSubMenu();
            this.pnlDesktop.Controls.Clear();
            frmHome frmHome = new frmHome()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmHome));
            frmHome.Show();
        }
        #endregion

        #region Event
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showSubMeNu(pnlSubAdmin);
        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            showSubMeNu(pnlSubWareHouse);
        }
        private void PtbLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            hideSubMenu();
           
        }

        private void btnOpenFromTable_Click(object sender, EventArgs e)
        {
            
            hideSubMenu();
            lblTitle.Text = "Quản lí bàn ăn";
            this.pnlDesktop.Controls.Clear();

            frmAdminTable frmAdminTable = new frmAdminTable()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmAdminTable)frmAdminTable);
            frmAdminTable.Show();
        }
        private void btnOpenFormAttendance_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //load giao dien cham cong len giao dien chinh
            //lblTitle.Text = "Chấm công";
            //this.pnlDesktop.Controls.Clear();

            //frmAttendanceList frmAttendance = new frmAttendanceList()
            //{
            //    Dock = DockStyle.Fill,
            //    TopLevel = false,
            //    TopMost = true
            //};
            //this.pnlDesktop.Controls.Add((frmAttendanceList)frmAttendance);

            //frmAttendance.Show();

            // fix loi sai font cua vy
        }

        private void btnOpenFormCategory_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            lblTitle.Text = "Danh mục";
            this.pnlDesktop.Controls.Clear();

            frmAdminCategory frmAdminCategory = new frmAdminCategory()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmAdminCategory)frmAdminCategory);
            frmAdminCategory.Show();

        }
        #endregion


    }
}
