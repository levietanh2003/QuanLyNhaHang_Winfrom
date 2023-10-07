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
    public partial class frmAccount : Form
    {
        QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
        public frmAccount()
        {
            InitializeComponent();
        }

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; changeAccount(loginAccount.typeAccount); }
        }

        public object AccountDao { get; private set; }

        public frmAccount(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        #region Method
        void changeAccount(int type)
        {
            txtAccountName.Text = loginAccount.userName;
            txtDisplayName.Text = loginAccount.displayName;
        }
        void updateAccount()
        {
            string displayName = txtDisplayName.Text;
            string password = txtPassword.Text;
            string newpass = txtNewPassword.Text;
            string username = txtAccountName.Text;
            string retypepass = txtRetypePassword.Text;


            if (password == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu để cập nhật", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {   
                // kiem tra mat khau cu co dung khong
                if ((from x in rm.Accounts where x.userName == username && x.passWord == password select x).FirstOrDefault() == null)
                {
                    MessageBox.Show("Mat khau cu khong dung.", "THÔNG BÁO", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    if (!newpass.Equals(retypepass))
                    {
                        MessageBox.Show("Mật khẩu nhập lại không trùng với mật khẩu mới", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Account account = (from acc in rm.Accounts where acc.userName == username select acc).First();
                        account.userName = username;
                        account.passWord = newpass;
                        account.displayName = displayName;
                        if (rm.SaveChanges() > 0)
                        {
                            MessageBox.Show("Cập nhật thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                        }
                    }
                }
            }

        }
        #endregion

        #region Event
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            updateAccount();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
