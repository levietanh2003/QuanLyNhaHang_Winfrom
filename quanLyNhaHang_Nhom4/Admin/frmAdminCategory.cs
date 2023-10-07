using quanLyNhaHang_Nhom4.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyNhaHang_Nhom4.Manager
{
    public partial class frmAdminCategory : Form
    {
        QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
        public frmAdminCategory()
        {
            InitializeComponent();
            columnRatio();
            Load();
      
        }
        #region Event
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvFoodCategory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvFoodCategory.Rows[rowIndex];
                txtCategoryID.Text = row.Cells[0].Value.ToString();
                txtCategoryName.Text = row.Cells[1].Value.ToString();

            }
            catch
            {

            }
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory();
        }

        #endregion

        #region Method
        public void columnRatio()
        {
            int totalWidth = dgvFoodCategory.Width;
            int column1Width = (int)(totalWidth * 0.2);  
            int column2Width = (int)(totalWidth * 0.4);  
            int column3Width = (int)(totalWidth * 0.4);

            dgvFoodCategory.Columns[0].Width = column1Width;
            dgvFoodCategory.Columns[1].Width = column2Width;
            dgvFoodCategory.Columns[2].Width = column3Width;
        }
        void Load()
        {
            LoadCategory();
        }


        private void LoadCategory()
        {
            int n = 0;
            dgvFoodCategory.Rows.Clear();
            foreach (var item in (from c in rm.FoodCategories select c).ToList())
            {
                n = dgvFoodCategory.Rows.Add();
                dgvFoodCategory.Rows[n].Cells[0].Value = item.idFC;
                dgvFoodCategory.Rows[n].Cells[1].Value = item.nameFC;
                dgvFoodCategory.Rows[n].Cells[2].Value = item.Foods.Count().ToString();
            }
            lblTotalCategory.Text = (dgvFoodCategory.Rows.Count - 1).ToString();

            setDataGirdView(dgvFoodCategory);
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

        // kiem tra danh muc co ton tai chua
        bool IsCategoryExists(string categoryName)
        {
            var existingCategory = rm.FoodCategories.FirstOrDefault(x => x.nameFC == categoryName);
            return existingCategory != null;
        }
        
        // them danh muc
        void AddCategory()
        {
            string nameCategory = txtCategoryName.Text;

            if(nameCategory != "")
            {
                // kiem tra ten danh muc co ton tai chua
                if (IsCategoryExists(nameCategory))
                {
                    // hoi nguoi dung da ton tai roi co van muon them khong
                    if (MessageBox.Show("Tên danh mục đã tồn tại. Bạn có muốn thêm?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rm.FoodCategories.Add(new FoodCategory() { nameFC = nameCategory });
                        if (rm.SaveChanges() > 0)
                        {
                            MessageBox.Show("Thêm danh mục thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                            LoadCategory();
                        }
                        else
                        {
                            MessageBox.Show("Đã xảy ra lỗi khi thêm!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }else
                {
                    rm.FoodCategories.Add(new FoodCategory() { nameFC = nameCategory });
                    if (rm.SaveChanges() > 0)
                    {
                        MessageBox.Show("Thêm danh mục thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                        LoadCategory();
                    }
                    else
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi thêm!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!", "THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        // sua danh muc
        void EditCategory()
        {
            int idCategory = Int32.Parse(txtCategoryID.Text);
            string nameCategory = txtCategoryName.Text;
            if(nameCategory != "")
            {

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
