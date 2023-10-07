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

namespace quanLyNhaHang_Nhom4.Admin
{
    public partial class frmAdminAccount : Form
    {
        QuanLyQuanAnEntities contextDB = new QuanLyQuanAnEntities();
        public frmAdminAccount()
        {
            InitializeComponent();
            columnRatio();
            Load();
        }


        #region Method

        public void columnRatio()
        {
            int totalWidth = dgvAccount.Width;
            int column1Width = (int)(totalWidth * 0.3);
            int column2Width = (int)(totalWidth * 0.3);
            int column3Width = (int)(totalWidth * 0.3);
            int column4Width = (int)(totalWidth * 0.1);


            dgvAccount.Columns[0].Width = column1Width;
            dgvAccount.Columns[1].Width = column2Width;
            dgvAccount.Columns[2].Width = column3Width;
            dgvAccount.Columns[3].Width = column4Width;

        }

        void Load()
        {
            LoadAccount();
        }
        private void LoadAccount()
        {
            int n = 0;
            dgvAccount.Rows.Clear();
            foreach (var item in (from a in contextDB.Accounts select a).ToList())
            {
                n = dgvAccount.Rows.Add();
                dgvAccount.Rows[n].Cells[0].Value = item.userName;
                dgvAccount.Rows[n].Cells[1].Value = item.displayName;
                dgvAccount.Rows[n].Cells[2].Value = item.typeAccount;
                dgvAccount.Rows[n].Cells[3].Value = item.idStaff;
            }
            lblTotalAccount.Text = "Tổng số tài khoản: " + (dgvAccount.Rows.Count -1 ).ToString();

            setDataGridView(dgvAccount);
        }

        // load tai khoan theo ten
        private void loadAccountByName(string accountName)
        {
            int index = 0;
            dgvAccount.Rows.Clear();
            foreach(var item in 
                (from acc in contextDB.Accounts
                 where acc.displayName == accountName
                 select acc).ToList()
                 )
            {
                index = dgvAccount.Rows.Add();
                dgvAccount.Rows[index].Cells[0].Value = item.userName;
                dgvAccount.Rows[index].Cells[1].Value = item.displayName;
                dgvAccount.Rows[index].Cells[2].Value = item.typeAccount;
                dgvAccount.Rows[index].Cells[3].Value = item.idStaff;
            }
            lblTotalAccount.Text = "Tổng số tài khoản: " + (dgvAccount.Rows.Count-1).ToString();
            setDataGridView(dgvAccount);

        }
        public void setDataGridView(DataGridView dataGridView)
        {
            // fontSize 
            int desiredFontSize = 12;

            // chinh font size cho toan bo dgv
            dataGridView.DefaultCellStyle.Font = new Font("Cambria", desiredFontSize);

            // chinh frontSize cho ten cot
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 15, FontStyle.Bold);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        // them account
        void AddAccount()
        {
            string userName = txtAccountName.Text;
            string password = txtPassword.Text;
            string retypePassword = txtRetypePassword.Text;
            string displayName = txtDisplayName.Text;
            int typeAccount = Int32.Parse(nudTypeAccount.Text);
            string idStaff = txtIdStaff.Text;

            if(userName == "" || password == "" || retypePassword == "" || displayName == "" || idStaff == "" )
            {
                MessageBox.Show("Vui long nhap day du thong tin","THONG BAO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                // kiem tra tai khoan da ton tai hay chua
                if((from a in contextDB.Accounts where a.userName == userName select a).FirstOrDefault() != null)
                {
                    MessageBox.Show("Tai khoan da ton tai.","THONG BAO", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    if((from x in contextDB.Staffs where x.idStaff == idStaff select x).FirstOrDefault() == null)
                    {
                        MessageBox.Show("Ma nhan vien khong hop le.","THONG BAO", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            if(contextDB.USP_InsertAccount(userName, password, displayName, typeAccount, idStaff) > 0)
                            {
                                LoadAccount();
                                MessageBox.Show("Them tai khoan thanh cong.", "THONG BAO", MessageBoxButtons.OK);
                                resetText();
                            }
                        }catch
                        {
                            MessageBox.Show("Da xay ra loi gi do.", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        
        // sua tai khoan
        void EditAccount()
        {
            string userName = txtAccountName.Text;
            string password = txtPassword.Text;
            string retypePassword = txtRetypePassword.Text;
            string displayName = txtDisplayName.Text;
            int typeAccount = Int32.Parse(nudTypeAccount.Text);
            string idStaff = txtIdStaff.Text;
            if (userName == "" || displayName == "" || idStaff == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if ((from x in contextDB.Accounts where x.userName == userName select x).FirstOrDefault() == null)
                {
                    MessageBox.Show("Tài khoản không hợp lệ.\n Vui lòng chọn đúng tài khoản cần sửa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    if (password == "")
                    {
                        MessageBox.Show("Bạn không thể thay đổi mật khẩu tại đây !", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        // kiem tra ma nhan vien
                        if((from nv in contextDB.Staffs where nv.idStaff == idStaff select nv).FirstOrDefault() == null)
                        {
                            MessageBox.Show("Sửa thông tin khoản thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }else
                        {
                            try 
                            {
                                Account acc = (from s in contextDB.Accounts where s.userName == userName select s).FirstOrDefault();
                                acc.displayName = displayName;
                                acc.typeAccount = typeAccount;
                                acc.idStaff = idStaff;
                                acc.userName = userName;
                                if(contextDB.SaveChanges() > 0)
                                {
                                    MessageBox.Show("Sửa thông tin khoản thành công", "THÔNG BÁO",MessageBoxButtons.OK);
                                }
                                resetText();
                            }
                            catch
                            {
                                MessageBox.Show("Có lỗi khi sửa thông tin tài khoản", "THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }

        }

        // xoa tai khoan
        void DeleteAccount()
        {
            string userName = txtAccountName.Text.Trim();
            try
            {
                // kiem tra tai khoan co hop le hay khong va userName co bang khoang trong khong
                if(userName == "" || (from x in contextDB.Accounts where x.userName == userName select x).FirstOrDefault() == null)
                {
                    MessageBox.Show("Tài khoản không hợp lệ.\n Vui lòng chọn đúng tài khoản cần sửa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // hoi nguoi dung xem co chac chan khong
                    if(MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản ? ", "THÔNG BÁO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            // lay ra account tuong ung tren userName
                            Account acc = (from x in contextDB.Accounts where x.userName == userName select x).FirstOrDefault();
                            contextDB.Accounts.Remove(acc);
                            if(contextDB.SaveChanges() > 0)
                            {
                                MessageBox.Show("Xóa tài khoản thành công", "THÔNG BÁO",MessageBoxButtons.OK);
                            }
                        }catch
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi xóa tài khoản", "THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bạn không thể xóa tài khoản này!", "THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        // reset password thanh "1" phong ho khi quen mat khau
        void ResetPassword()
        {
            string userName = txtAccountName.Text.Trim();

            if (userName == "" || (from x in contextDB.Accounts where x.userName == userName select x).FirstOrDefault() == null)
            {
                MessageBox.Show("Tài khoản không hợp lệ.\n Vui lòng chọn đúng tài khoản cần sửa", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn đặt mật khẩu về mặc định?", "THÔNG BÁO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        // lay ra account tuong ung tren userName
                        Account acc = (from x in contextDB.Accounts where x.userName == userName select x).FirstOrDefault();
                        acc.passWord = "1";
                        if (contextDB.SaveChanges() > 0)
                        {
                            MessageBox.Show("Đặt lại mật khẩu thành công.\nMật khẩu mặc định của bạn là: 1", "THÔNG BÁO", MessageBoxButtons.OK);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa tài khoản", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        void resetText()
        {
            txtAccountName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtDisplayName.Text = string.Empty;
            txtRetypePassword.Text = string.Empty;
            txtIdStaff.Text = string.Empty;
        }
        #endregion

        #region Event
        private void dgvAccount_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvAccount.Rows[rowIndex];
                txtAccountName.Text = row.Cells[0].Value.ToString();
                txtDisplayName.Text = row.Cells[1].Value.ToString();
                nudTypeAccount.Text = row.Cells[2].Value.ToString();
                txtIdStaff.Text = row.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        private void txtFindAccountByName_TextChanged(object sender, EventArgs e)
        {
            loadAccountByName(txtFindAccountByName.Text);
        }
        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
            txtFindAccountByName.Text = "";
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            AddAccount();
            LoadAccount();
        }
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            EditAccount();
            LoadAccount();
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DeleteAccount();
            LoadAccount();
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword();
            LoadAccount();
        }
        #endregion
    }
}
