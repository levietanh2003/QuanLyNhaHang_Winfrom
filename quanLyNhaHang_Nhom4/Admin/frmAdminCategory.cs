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
        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            EditCategory();
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            DeleteCategory();
        }
        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadCategory();
            txtFindCategoryByName.Text = "";
        }
        private void txtFindCategoryByName_TextChanged(object sender, EventArgs e)
        {
            LoadCategoryByName(txtFindCategoryByName.Text);
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

        // load category theo ten
        void LoadCategoryByName(string nameCategory)
        {
            int index = 0;
            dgvFoodCategory.Rows.Clear();  
            foreach(var item in (from x in rm.FoodCategories where x.nameFC.Contains(nameCategory) select x).ToList())
            {
                index = dgvFoodCategory.Rows.Add();
                dgvFoodCategory.Rows[index].Cells[0].Value = item.idFC;
                dgvFoodCategory.Rows[index].Cells[1].Value = item.nameFC;
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
            if (nameCategory != "")
            {
                if ((from c in rm.FoodCategories where c.nameFC == nameCategory select c).FirstOrDefault() != null)
                {
                    if (msg.Show("Tên danh mục đã tồn tại. Bạn có muốn thêm?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                    {
                        rm.FoodCategories.Add(new FoodCategory() { nameFC = nameCategory });
                        if (rm.SaveChanges() > 0)
                        {
                            msg.Show("Thêm danh mục thành công!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            Load();
                        }
                        else
                        {
                            msg.Show("Đã xảy ra lỗi khi thêm!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Error);
                        }
                    }
                }
                else
                {
                    rm.FoodCategories.Add(new FoodCategory() { nameFC = nameCategory });
                    if (rm.SaveChanges() > 0)
                    {
                        msg.Show("Thêm danh mục thành công!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        Load();
                    }
                    else
                    {
                        msg.Show("Đã xảy ra lỗi khi thêm!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
            else
            {
                msg.Show("Vui lòng nhập đầy đủ!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
        }

        // sua danh muc
        void EditCategory()
        {
            int idCategory = Int32.Parse(txtCategoryID.Text);
            string nameCategory = txtCategoryName.Text;
            if(nameCategory != "")
            {
                FoodCategory foodCategoryEdit = (from x in rm.FoodCategories where x.nameFC == nameCategory select x).FirstOrDefault();
                if(foodCategoryEdit != null)
                {
                    if(msg.Show("Tên danh mục đã tồn tại.\n Bạn có muốn sửa tên danh mục?", "Sửa danh mục món ăn", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                    {
                        foodCategoryEdit.nameFC = nameCategory;
                        if(rm.SaveChanges() > 0)
                        {
                            msg.Show("Sửa danh mục thành công!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            LoadCategory();
                        }
                    }
                }
                else
                {
                    FoodCategory cat = (from c in rm.FoodCategories where c.idFC == idCategory select c).FirstOrDefault();
                    cat.nameFC = nameCategory;
                    if (rm.SaveChanges() > 0)
                    {
                        msg.Show("Sửa danh mục thành công!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        Load();
                    }
                    else
                    {
                        msg.Show("Đã xảy ra lỗi khi sửa!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
            else
            {
                msg.Show("Vui lòng nhập đầy đủ!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
        }

        // xoa danh muc
        void DeleteCategory()
        {
            int idCategory = Int32.Parse(txtCategoryID.Text);
            string nameCategory = txtCategoryName.Text;

            FoodCategory foodCategoryDelete = (from x in rm.FoodCategories where x.nameFC == nameCategory select x).FirstOrDefault();
            if (idCategory == 0 || nameCategory == "" || foodCategoryDelete == null || txtCategoryID.Text == "")
            {
                msg.Show("Ban vui lòng chọn danh mục muốn xóa.", "THÔNG BÁO", msg.Buttons.Yes,msg.Icon.Info);
            }
            else
            {
                try
                {

                    if (msg.Show("Bạn có chắc chắn muốn xóa danh mục " + nameCategory + " ?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                    {
                        rm.FoodCategories.Remove(foodCategoryDelete);
                        if (rm.SaveChanges() > 0)
                        {
                            msg.Show("Xóa thành công.", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                            Load();
                        }
                        else
                        {
                            msg.Show("Đã có lỗi xảy ra.", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Error);
                        }
                    }
                }
                catch
                {
                    msg.Show("Bạn không thể xóa danh mục này!", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Error);
                }

            }
        }
        #endregion
    }
}
