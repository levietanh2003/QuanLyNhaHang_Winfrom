using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyNhaHang_Nhom4.Manager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        #region Method
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion

        private void btnLogIn_Click(object sender, EventArgs e)
        {

        }

        #region Event

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "User";
                txtUserName.ForeColor = Color.Black;
            }
        }
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "User")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.DimGray;
            }
        }
        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            if (txtPassWord.Text == "Password")
            {
                txtPassWord.Text = "";
                txtPassWord.ForeColor = Color.DimGray;
                txtPassWord.UseSystemPasswordChar = true;
            }
        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            if (txtPassWord.Text == "")
            {
                txtPassWord.Text = "Pass";
                txtPassWord.ForeColor = Color.Black;
            }
        }
        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
