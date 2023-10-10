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
    public partial class frmAttendanceList : Form
    {
        QuanLyQuanAnEntities contextDB = new QuanLyQuanAnEntities();
        public frmAttendanceList()
        {
            InitializeComponent();
            columnRatio();
            loadListAttendance();

        }

        #region Method
        public void columnRatio()
        {
            int totalWidth = dgvAttendanceList.Width;
            int column1Width = (int)(totalWidth * 0.2);
            int column2Width = (int)(totalWidth * 0.4);
            int column3Width = (int)(totalWidth * 0.4);
            dgvAttendanceList.Columns[0].Width = column1Width;
            dgvAttendanceList.Columns[1].Width = column2Width;
            dgvAttendanceList.Columns[2].Width = column3Width;
        }

        // load du lieu tu csdl len dgv
        void loadListAttendance()
        {
            int insertRow = 0;
            dgvAttendanceList.Rows.Clear();

            // tao list luu ket qua truy van
            List<AttendanceList> attendanceLists = (from a in contextDB.AttendanceLists
                                                    select a).ToList();
            // duyet qua list
            foreach (var item in attendanceLists)
            {
                insertRow = dgvAttendanceList.Rows.Add();
                //dgvAttendanceList.Rows[insertRow].Cells[0].Value = item.id;
                dgvAttendanceList.Rows[insertRow].Cells[0].Value = item.idStaff;
                dgvAttendanceList.Rows[insertRow].Cells[1].Value = (from s in contextDB.Staffs
                                                                    where s.idStaff == item.idStaff
                                                                    select s.nameStaff).FirstOrDefault().ToString();
                dgvAttendanceList.Rows[insertRow].Cells[2].Value = item.dateCheckIn.ToString();
            }

            // fontSize 
            int desiredFontSize = 12;  

            // chinh font size cho toan bo dgv
            dgvAttendanceList.DefaultCellStyle.Font = new Font("Cambria", desiredFontSize);

            // chinh frontSize cho ten cot
            dgvAttendanceList.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 15, FontStyle.Bold);

            dgvAttendanceList.BorderStyle = BorderStyle.None;
            dgvAttendanceList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvAttendanceList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAttendanceList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvAttendanceList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvAttendanceList.BackgroundColor = Color.White;
            

            dgvAttendanceList.EnableHeadersVisualStyles = false;
            dgvAttendanceList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAttendanceList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvAttendanceList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        void showInfroStaff()
        {

            string idStaff = txtStaffID.Text.Trim();
            // select ra nhan vien co ma giong voi dau vao idStaff
            Staff staff = (from s in contextDB.Staffs
                           where s.idStaff == idStaff
                           select s).FirstOrDefault();
            if (staff != null)
            {
                // do du lieu nguoc lai textBox
                txtStaffName.Text = staff.nameStaff;
                txtSex.Text = staff.sex;
                txtPosition.Text = staff.Position.namePosition;
                txtDateOfBirth.Text = staff.dateOfBirth.ToString().Split(' ')[0];
                txtIdentityCard.Text = staff.identityCard;
                txtPhoneNumber.Text = staff.phoneNumber;
                rtbAddress.Text = staff.address;

            }
            else
            {
                msg.Show("Mã nhân viên không tồn tại", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
            }
        }
        void resetText()
        {
            txtStaffID.Text = string.Empty;
            txtStaffName.Text = string.Empty;
            txtDateOfBirth.Text = string.Empty;
            txtIdentityCard.Text = string.Empty;    
            txtPosition.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty; 
            txtSex.Text = string.Empty; 
            rtbAddress.Text = string.Empty;
        }
        #endregion

        #region Event
        // tiem kiem nhan vien 
        private void btnFindStaff_Click(object sender, EventArgs e)
        {
            showInfroStaff();
        }

        // diem danh 
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            string idStaff = txtStaffID.Text;
            string nameStaff = txtStaffName.Text;

            if (nameStaff == "")
            {
                msg.Show("Vui lòng kiểm tra thông tin nhân viên trước khi chấm công!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
            }
            else
            {
                if (contextDB.USP_CheckExitsAttendanceList(idStaff).Count() > 0)
                {
                    msg.Show("Nhân viên đã điểm danh", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Error);
                    ResetText();
                }
                else
                {
                    try
                    {
                        if (contextDB.USP_InsertAttendanceList(idStaff) > 0)
                        {
                            msg.Show("Điểm danh thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            loadListAttendance();
                        }
                    }
                    catch
                    {
                        msg.Show("Đã có lỗi xảy ra khi điểm danh", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
                    }
                }
            }
        }
        #endregion
    }
}
