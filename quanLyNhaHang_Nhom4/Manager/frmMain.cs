using quanLyNhaHang_Nhom4.Database;
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
        private void openChildForm(Form childForm)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
            }
            currentchildform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void Reset()
        {
            hideSubMenu();
            lblTitle.Text = "Home";
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
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            lblTitle.Text = "Đặt món";
        }
    }
}
