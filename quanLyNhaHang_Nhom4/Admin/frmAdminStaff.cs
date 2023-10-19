using quanLyNhaHang_Nhom4.Database;
using quanLyNhaHang_Nhom4.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace quanLyNhaHang_Nhom4.Admin
{
    public partial class frmAdminStaff : Form
    {
        QuanLyQuanAnEntities contextDB = new QuanLyQuanAnEntities();
        public frmAdminStaff()
        {
            InitializeComponent();
            columnRatio();
            load();
        }
        #region Method
        public void columnRatio()
        {
            int totalWidth = dgvStaff.Width;
            int column1Width = (int)(totalWidth * 0.125);
            int column2Width = (int)(totalWidth * 0.125);
            int column3Width = (int)(totalWidth * 0.125);
            int column4Width = (int)(totalWidth * 0.125);
            int column5Width = (int)(totalWidth * 0.125);
            int column6Width = (int)(totalWidth * 0.125);
            int column7Width = (int)(totalWidth * 0.125);
            int column8Width = (int)(totalWidth * 0.125);
            dgvStaff.Columns[0].Width = column1Width;
            dgvStaff.Columns[1].Width = column2Width;
            dgvStaff.Columns[2].Width = column3Width;
            dgvStaff.Columns[3].Width = column4Width;
            dgvStaff.Columns[4].Width = column5Width;
            dgvStaff.Columns[5].Width = column6Width;
            dgvStaff.Columns[6].Width = column7Width;
            dgvStaff.Columns[7].Width = column8Width;
        }

        void setDataGirdView(DataGridView dataGrid)
        {
            // fontSize 
            int desiredFontSize = 12;

            // chinh font size cho toan bo dgv
            dataGrid.DefaultCellStyle.Font = new Font("Cambria", desiredFontSize);

            // chinh frontSize cho ten cot
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 15, FontStyle.Bold);

            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGrid.BackgroundColor = Color.White;


            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        void load()
        {
            loadStaff();
            fillComboboxPosition();
        }
        
        // fill chuc vu len combobox
        void fillComboboxPosition()
        {
            List<Position> positions = (from x in contextDB.Positions select x).ToList();
            cmbPosition.DataSource = positions;
            cmbPosition.DisplayMember = "namePosition";
        }
        void loadStaff()
        {
            int index = 0;
            dgvStaff.Rows.Clear();

            foreach(var item in(from st in contextDB.Staffs select st).ToList())
            {
                index = dgvStaff.Rows.Add();
                dgvStaff.Rows[index].Cells[0].Value = item.idStaff;
                dgvStaff.Rows[index].Cells[1].Value = item.nameStaff;
                dgvStaff.Rows[index].Cells[2].Value = item.sex;
                dgvStaff.Rows[index].Cells[3].Value = item.Position.namePosition;
                dgvStaff.Rows[index].Cells[4].Value = item.dateOfBirth.ToString().Split(' ')[0];
                dgvStaff.Rows[index].Cells[5].Value = item.identityCard;
                dgvStaff.Rows[index].Cells[6].Value = item.phoneNumber;
                dgvStaff.Rows[index].Cells[7].Value = item.address;
            }
            lblTotalStaff.Text = "Tổng số nhân viên: " + dgvStaff.Rows.Count.ToString();
            setDataGirdView(dgvStaff);
        }
        void loadStaffByName(string name)
        {
            int n = 0;
            dgvStaff.Rows.Clear();
            foreach (var item in (from s in contextDB.Staffs where s.nameStaff.Contains(name) select s).ToList())
            {
                n = dgvStaff.Rows.Add();
                dgvStaff.Rows[n].Cells[0].Value = item.idStaff;
                dgvStaff.Rows[n].Cells[1].Value = item.nameStaff;
                dgvStaff.Rows[n].Cells[2].Value = item.sex;
                dgvStaff.Rows[n].Cells[3].Value = item.Position.namePosition;
                dgvStaff.Rows[n].Cells[4].Value = item.dateOfBirth.ToString().Split(' ')[0];
                dgvStaff.Rows[n].Cells[5].Value = item.identityCard;
                dgvStaff.Rows[n].Cells[6].Value = item.phoneNumber;
                dgvStaff.Rows[n].Cells[7].Value = item.address;
            }
            lblTotalStaff.Text = "Tổng số nhân viên: " + dgvStaff.Rows.Count.ToString();
            setDataGirdView(dgvStaff);
        }

        // them nhan vien 
        void AddStaff()
        {
            string idStaff = txtStaffID.Text.Trim();
            string nameStaff = txtStaffName.Text.Trim();
            string sexStaff = txtSex.Text.Trim();
            Position position = (from x in contextDB.Positions where x.namePosition == cmbPosition.Text select x).FirstOrDefault();
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            string identityCard = txtIdentityCard.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string address = rtbAddress.Text.Trim();

            if(idStaff == "" || nameStaff == "" || sexStaff == "" || identityCard == "" || phoneNumber == "" || address == "")
            {
                msg.Show("Vui lòng nhập đầy đủ thông tin","THÔNG BÁO", msg.Buttons.No, msg.Icon.Info);
            }
            else
            {
                // kiem tra ma nhan vien co ton tai chua
                if((from x in contextDB.Staffs where x.idStaff == idStaff select x).FirstOrDefault() != null)
                {
                    msg.Show("Mã nhân viên đã tồn tại. Vui lòng lấy mã khác!","THÔNG BÁO", msg.Buttons.No,msg.Icon.Warning);
                }
                else
                {
                    try
                    {
                        contextDB.USP_InsertStaff(idStaff, nameStaff, sexStaff, position.idPosition, dateOfBirth, identityCard, phoneNumber, address);
                        msg.Show("Thêm thành công !", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        loadStaff();
                    }
                    catch
                    {
                        msg.Show("Đã xảy ra lỗi thi sửa, vui lòng kiểm tra lại !", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
        }

        // xoa nhan vien
        void DeleteStaff()
        {
            string idStaff = txtStaffID.Text.Trim();
            string nameStaff = txtStaffName.Text;
            Staff staffDelete = (from staff in contextDB.Staffs where staff.idStaff == idStaff select staff).FirstOrDefault();

            if (idStaff == "" || staffDelete == null)
            {
                msg.Show("Vui lòng chọn nhân viên cần xóa!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Info);
                return;
            }
            else
            {
                // huong dan nguoi dung xoa tai khoan roi moi xoa nhan vien
                if((from x in contextDB.Accounts where x.idStaff == idStaff select x).FirstOrDefault() != null)
                {
                    msg.Show("Vui lòng xóa tài khoản trước khi xóa nhân viên", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
                }
                else
                {
                    try
                    {
                        if(msg.Show("Bạn có chắc chắn muốn xóa nhân viên "+ nameStaff +" ?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                        {
                            contextDB.Staffs.Remove(staffDelete);
                            contextDB.SaveChanges();
                            loadStaff();
                            msg.Show("Xóa thành công !", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        }
                        
                    }catch
                    {
                        msg.Show("Bạn không thể xóa nhân viên này!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
        }

        // sua nhan vien
        void EditStaff()
        {
            string idStaff = txtStaffID.Text.Trim();
            string nameStaff = txtStaffName.Text.Trim();
            string sexStaff = txtSex.Text.Trim();
            Position position = (from x in contextDB.Positions where x.namePosition == cmbPosition.Text select x).FirstOrDefault();
            DateTime dateOfBirth = dtpDateOfBirth.Value;
            string identityCard = txtIdentityCard.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string address = rtbAddress.Text.Trim();

            Staff staffEdit = (from x in contextDB.Staffs where x.idStaff == idStaff select x).FirstOrDefault();
            if (idStaff == "" || staffEdit == null)
            {
                msg.Show("Vui lòng chọn nhân viên cần sửa!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Info);
                return;
            }
            if (nameStaff == "" || identityCard == "" || phoneNumber == "" || address == "")
            {
                msg.Show("Vui lòng nhập đầy đủ thông tin", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
            else
            {
                try
                {

                    staffEdit.idStaff = idStaff;
                    staffEdit.nameStaff = nameStaff;
                    staffEdit.identityCard = identityCard;
                    staffEdit.sex = sexStaff;
                    staffEdit.phoneNumber = phoneNumber;
                    staffEdit.phoneNumber = phoneNumber;
                    staffEdit.idPosition = position.idPosition;
                    staffEdit.dateOfBirth = dateOfBirth;
                    staffEdit.address = address;
                    if(contextDB.SaveChanges() > 0)
                    {
                        msg.Show("Sửa thành công !", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                    }
                    loadStaff();
                }catch
                {
                    msg.Show("Đã xảy ra lỗi khi sửa, vui lòng kiểm tra lại !", "THÀNH CÔNG", msg.Buttons.No, msg.Icon.Error);
                }
            }
        }
        #endregion
        #region Event
        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            loadStaff();
        }
        private void txtFindTableName_TextChanged(object sender, EventArgs e)
        {
            loadStaffByName(txtFindTableName.Text);
        }
        private void dgvStaff_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvStaff.Rows[rowIndex];
                txtStaffID.Text = row.Cells[0].Value.ToString();
                txtStaffName.Text = row.Cells[1].Value.ToString();
                txtSex.Text = row.Cells[2].Value.ToString();
                cmbPosition.Text = row.Cells[3].Value.ToString();
                txtIdentityCard.Text = row.Cells[5].Value.ToString();
                dtpDateOfBirth.Text = row.Cells[4].Value.ToString();
                txtPhoneNumber.Text = row.Cells[6].Value.ToString();
                rtbAddress.Text = row.Cells[7].Value.ToString();
            }
            catch
            {

            }
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaff();
        }
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            DeleteStaff();
        }
        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            EditStaff();
        }
        private void btnEditPosition_Click(object sender, EventArgs e)
        {
            frmEditPosition frmEditPosition = new frmEditPosition();
            if(frmEditPosition.ShowDialog() == DialogResult.OK)
            {
                fillComboboxPosition();
            }
        }
        private void txtStaffID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) )
            //{
            //    e.Handled = true;
            //    msg.Show("Chỉ cho phép nhập số và không vượt quá 5 kí tự.", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Warning);
            //}
        }
        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {
            if (txtStaffID.Text.Length > 5)
            {
                txtStaffID.Text = txtStaffID.Text.Substring(0, 5);
                msg.Show("Chỉ cho phép không vượt quá 5 kí tự.", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Warning);
            }
        }
        #endregion
    }
 }
