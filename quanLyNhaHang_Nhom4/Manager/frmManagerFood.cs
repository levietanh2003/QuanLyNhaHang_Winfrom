using quanLyNhaHang_Nhom4.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace quanLyNhaHang_Nhom4.Manager
{
    public partial class frmManagerFood : Form
    {
        QuanLyQuanAnEntities contextDB = new QuanLyQuanAnEntities();

        public frmManagerFood()
        {
            InitializeComponent();
            load();
        }


        #region Method
        void load()
        {
            loadFoodList();
            loadCategory();
        }

        private void loadCategory()
        {
           List<FoodCategory> listFoodCategories = (from category in contextDB.FoodCategories
                                                select category).ToList();
            // fill danh muc len tren combobox
            cmbNameFC.DataSource = listFoodCategories;
            cmbNameFC.DisplayMember = "nameFC";
        }

        
        void loadFoodList()
        {
            int insertRow = 0;
            dgvFoodList.Rows.Clear();
            List<Food> listFood = (from food in contextDB.Foods
                                   select food).ToList();
            foreach(var item in listFood )
            {
                insertRow = dgvFoodList.Rows.Add();
                dgvFoodList.Rows[insertRow].Cells[0].Value = item.idFood;
                dgvFoodList.Rows[insertRow].Cells[1].Value = item.nameFood;
                dgvFoodList.Rows[insertRow].Cells[2].Value = item.idFC;
                dgvFoodList.Rows[insertRow].Cells[3].Value = item.price;
                dgvFoodList.Rows[insertRow].Cells[4].Value = item.imageFood;
                dgvFoodList.Rows[insertRow].Cells[5].Value = item.statusFood;
            }
            txtTotalFood.Text = "Tổng số món ăn: " + (dgvFoodList.Rows.Count - 1).ToString();
            setDataGridView(dgvFoodList);
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
        private void loadListFoodByName(string name)
        {
            int n = 0;
            dgvFoodList.Rows.Clear();
            QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
            List<Food> listFood = (from f in rm.Foods where f.nameFood.Contains(name) select f).ToList();
            foreach (var item in listFood)
            {
                n = dgvFoodList.Rows.Add();
                dgvFoodList.Rows[n].Cells[0].Value = item.idFood;
                dgvFoodList.Rows[n].Cells[1].Value = item.nameFood;
                dgvFoodList.Rows[n].Cells[2].Value = item.idFC;
                dgvFoodList.Rows[n].Cells[3].Value = item.price;
                dgvFoodList.Rows[n].Cells[4].Value = item.imageFood;
                dgvFoodList.Rows[n].Cells[5].Value = item.statusFood;
            }
            txtTotalFood.Text = "Tổng số món ăn: " + (dgvFoodList.Rows.Count - 1).ToString();
            setDataGridView(dgvFoodList);
        }
        void LoadImageFoodByIdFood(int id)
        {
            QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
            String image = (from f in rm.Foods where f.idFood == id select f.imageFood).FirstOrDefault().ToString();
            if (image == null)
            {
                image = "default.png";
            }
            //String image = FoodDAO.Instance.GetLinkImageByFood(id);
            Image img = GetCopyImage(@" @""..\..\Image\food\""" + image);
            ptbImageOfFood.Image = img;
            ptbImageOfFood.SizeMode = PictureBoxSizeMode.StretchImage;
            //ptbImageOfFood.Image = new Bitmap(@"./Image/food/" + image);
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }
        #endregion

        #region Event
        private void frmManagerFood_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
 
        }
        private void txtSearchFood_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            //    e.Handled = true;
        }

        private void txtTotalFood_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvFoodList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvFoodList.Rows[rowIndex];
                txtFoodID.Text = row.Cells[0].Value.ToString();
                txtFoodName.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString();
                lblLinkImage.Text = row.Cells[4].Value.ToString();
                cbStatus.Checked = row.Cells[5].Value.ToString() == "Đang bán";
                cmbNameFC.SelectedIndex = (int)row.Cells[2].Value - 1;
                LoadImageFoodByIdFood((int)row.Cells[0].Value);
            }
            catch
            {

            }
        }

        private void cbStatus_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int idFood = Int32.Parse(txtFoodID.Text);
                QuanLyQuanAnEntities rm = new QuanLyQuanAnEntities();
                Food food = (from f in rm.Foods where f.idFood == idFood select f).First();
                food.statusFood = (cbStatus.Checked == true) ? "Đang bán" : "Tạm ngưng";
                if (!(rm.SaveChanges() > 0))
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loadFoodList();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn món trước khi điều chỉnh", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            loadListFoodByName(txtSearchFood.Text);
        }
        private void lblLinkImage_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
