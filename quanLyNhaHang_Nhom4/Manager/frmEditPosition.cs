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
    public partial class frmEditPosition : Form
    {
        QuanLyQuanAnEntities contextDB = new QuanLyQuanAnEntities();
        public frmEditPosition()
        {
            InitializeComponent();
            load();
        }
        #region Method
        void load()
        {
            loadListPosition();
            columnRatio();
        }
        void setDataGridView(DataGridView dataGrid)
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
        public void columnRatio()
        {
            int totalWidth = dgvPosition.Width;
            int column1Width = (int)(totalWidth * 0.2);
            int column2Width = (int)(totalWidth * 0.8);
            dgvPosition.Columns[0].Width = column1Width;
            dgvPosition.Columns[1].Width = column2Width;
        }
        void resetText()
        {
            txtPositionID.Text = string.Empty;
            txtPositionName.Text = string.Empty;
        }
        void loadListPosition()
        {
            int index = 0;
            dgvPosition.Rows.Clear();
            foreach (var item in (from ps in contextDB.Positions select ps).ToList())
            {

                index = dgvPosition.Rows.Add();
                dgvPosition.Rows[index].Cells[0].Value = item.idPosition;
                dgvPosition.Rows[index].Cells[1].Value = item.namePosition;
            }
            lblTotalPosition.Text = "Tổng chức vụ: " + (dgvPosition.Rows.Count - 1);
            setDataGridView(dgvPosition);
        }

        // load theo ten
        void loadListPositionByName(string name)
        {
            int index = 0;
            dgvPosition.Rows.Clear();
            foreach (var item in (from ps in contextDB.Positions where ps.namePosition.Contains(name) select ps).ToList())
            {
                index = dgvPosition.Rows.Add();
                dgvPosition.Rows[index].Cells[0].Value = item.idPosition;
                dgvPosition.Rows[index].Cells[1].Value = item.namePosition;
            }
            lblTotalPosition.Text = "Tổng chức vụ: " + (dgvPosition.Rows.Count - 1);
            setDataGridView(dgvPosition);
        }

        // them chuc vu
        void AddPosition()
        {
            string namePosition = txtPositionName.Text;

            if(namePosition != "")
            {
                // kiem tra chu vu da con chua
                if((from cv in contextDB.Positions where cv.namePosition == namePosition select cv).FirstOrDefault() != null)
                {
                    msg.Show("Chức vụ bạn vừa thêm đã tồn tại.", "THÔNG BÁO", msg.Buttons.No,msg.Icon.Warning);
                }
                else
                {
                    try
                    {
                        Position positionAdd = new Position() { namePosition = namePosition };
                        contextDB.Positions.Add(positionAdd);
                        if (contextDB.SaveChanges() > 0)
                        {
                            msg.Show("Thêm chức vụ thành công. ", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            loadListPosition();
                            resetText();
                        }
                    }
                    catch
                    {
                        msg.Show("Đã có lỗi gì xảy ra khi thêm chức vụ.", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);

                    }
                }
            }else
            {
                msg.Show("Vui lòng nhập đầy đủ thông tin trước khi thêm chức vụ.", "THÔNG BÁO",msg.Buttons.No, msg.Icon.Info);
            }
        }
        
        // xoa chuc vu
        void DeletePosition()
        {
            int idPosition = Int32.Parse(txtPositionID.Text);
            string namePosition = txtPositionName.Text;

            if(idPosition != 0 || txtPositionID.Text != "" || namePosition != "")
            {
                Position positionDelete = (from cv in contextDB.Positions where cv.namePosition == namePosition select cv).FirstOrDefault();
                if(positionDelete == null)
                {
                    msg.Show("Không tin thấy chức vụ bạn cần xóa. ", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Info);
                }
                else
                {
                    try
                    {   if (msg.Show("Bạn có chắc chắn muốn xóa chức vụ này không", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Success) == DialogResult.Yes)
                        {
                            contextDB.Positions.Remove(positionDelete);
                            contextDB.SaveChanges();
                            msg.Show("Đã xóa chức vụ thành công. ", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            loadListPosition();
                            resetText();
                        }
                    }
                    catch
                    {
                        msg.Show("Đã có lỗi gì xảy ra khi thêm chức vụ.", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);

                    }
                }
            }
            else
            {
                msg.Show("Chọn chức vụ cần xóa.", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Info); 
            }
        }

        // sua chuc vu
        void EditPosition()
        {
            int idPosition = Int32.Parse(txtPositionID.Text);
            string namePosition = txtPositionName.Text;


            if (idPosition != 0 || txtPositionID.Text != "" || namePosition != "")
            {
                // kiem tra chuc vu sua co ton tai hay khong 
                if ((from cv in contextDB.Positions where cv.namePosition == namePosition select cv).FirstOrDefault() != null)
                {
                    msg.Show("Chức vụ bạn vừa sửa đã tồn tại.", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
                }
                else
                {
                    try
                    {
                        Position positionEdit = (from cv in contextDB.Positions where cv.idPosition == idPosition select cv).FirstOrDefault();
                        positionEdit.namePosition = namePosition;
                        
                        if (contextDB.SaveChanges() > 0)
                        {
                            msg.Show("Đã sửa chức vụ thành công. ", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            resetText();
                            loadListPosition();
                        }
                    }
                    catch
                    {
                        msg.Show("Đã có lỗi gì xảy ra khi sửa chức vụ.", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);

                    }
                }
            }
            else
            {
                msg.Show("Chọn chức vụ cần sửa.", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Info);
            }
        }
        #endregion

        #region Event
        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            AddPosition();
        }

        private void btnDeletePosition_Click(object sender, EventArgs e)
        {
            DeletePosition();
        }
        private void btnEditPosition_Click(object sender, EventArgs e)
        {
            EditPosition();
        }
        private void btnShowPosition_Click(object sender, EventArgs e)
        {
            loadListPosition();
            txtFindPositionByName.Text = string.Empty;
        }
        private void txtFindPositionByName_TextChanged(object sender, EventArgs e)
        {
            loadListPositionByName(txtFindPositionByName.Text);
        }
        private void dgvPosition_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int indexRow = e.RowIndex;
                DataGridViewRow row = dgvPosition.Rows[indexRow];
                txtPositionID.Text = row.Cells[0].Value.ToString();
                txtPositionName.Text = row.Cells[1].Value.ToString();
                
            }catch
            {

            }
        }
        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }
        #endregion


    }
}
