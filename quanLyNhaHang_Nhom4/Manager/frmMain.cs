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
        public frmMain()
        {
            InitializeComponent();
            customizeDesing();
        }


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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showSubMeNu(pnlSubAdmin);
        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            showSubMeNu(pnlSubWareHouse);
        }
    }
}
