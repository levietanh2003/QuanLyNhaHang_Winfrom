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
    public partial class frmManagerFood : Form
    {
        public frmManagerFood()
        {
            InitializeComponent();
        }

        private void lblImage_Click(object sender, EventArgs e)
        {

        }

        public void CountFood() 
        {
            int countRow = dgvFoodInfo.Rows.Count - 1;
            txtTotalFood.Text = txtTotalFood.Text + "Tổng số món ăn: " + countRow;
        }

        private void frmManagerFood_Load(object sender, EventArgs e)
        {
            CountFood();
            cmbNameFC.Text = "---Select---";
        }

        public void GetFoodInfo(int selectedRow)
        {
            //DataGridViewRow row = dgvFoodInfo.Rows[selectedRow];
            //txtFoodID.Text = row.Cells[0].Value.ToString();
            //txtNameFood.Text = row.Cells[1].Value.ToString();
            ////lblFoodImage.Text = row.Cells[2].Value.ToString();
            //if (row.Cells[3].Value.ToString() == "Đang bán")
            //    rdbFoodStatus.Checked = true;
            //else rdbFoodStatus.Checked = false;
        }

        private void dgvFoodInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;
            //GetFoodInfo(i);
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if(txtSearchFood.Text == "")
            //    {
            //        MessageBox.Show("Vui lòng nhập tên món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else for (int i = 0; i < dgvFoodInfo.Rows.Count; i++)
            //         {
            //            if (dgvFoodInfo.Rows.Count == 1 && dgvFoodInfo.Rows[i].Cells[0].Value == null)
            //                MessageBox.Show("Chưa có dữ liệu món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            else if (txtSearchFood.Text == dgvFoodInfo.Rows[i].Cells[0].Value.ToString())
            //            {
            //                MessageBox.Show("Đã tìm thấy món ăn", "Thông báo", MessageBoxButtons.OK);
            //                GetFoodInfo(i);
            //            }
            //            else MessageBox.Show("không tìm thấy món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void txtSearchFood_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            //    e.Handled = true;
        }
    }
}
