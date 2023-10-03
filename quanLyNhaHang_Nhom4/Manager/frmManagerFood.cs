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
    public partial class frmManagerFood : Form
    {
        QuanLyQuanAnEntities contextDB = new QuanLyQuanAnEntities();

        public frmManagerFood()
        {
            InitializeComponent();
            load();
        }

        private void lblImage_Click(object sender, EventArgs e)
        {

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
                //dgvFoodList.Rows[insertRow].Cells[0].Value = item.idFood;
                dgvFoodList.Rows[insertRow].Cells[0].Value = item.nameFood;
                //dgvFoodList.Rows[insertRow].Cells[2].Value = item.idFC;
                dgvFoodList.Rows[insertRow].Cells[1].Value = item.price;
                dgvFoodList.Rows[insertRow].Cells[2].Value = item.imageFood;
                dgvFoodList.Rows[insertRow].Cells[3].Value = item.statusFood;
            }

            // fontSize 
            int desiredFontSize = 12;

            // chinh font size cho toan bo dgv
            dgvFoodList.DefaultCellStyle.Font = new Font("Cambria", desiredFontSize);

            // chinh frontSize cho ten cot
            dgvFoodList.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 15, FontStyle.Bold);

            txtTotalFood.Text = "Tổng số món ăn: " + (dgvFoodList.Rows.Count - 1).ToString();
            dgvFoodList.BorderStyle = BorderStyle.None;
            dgvFoodList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvFoodList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFoodList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvFoodList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvFoodList.BackgroundColor = Color.White;

            dgvFoodList.EnableHeadersVisualStyles = false;
            dgvFoodList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFoodList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvFoodList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        #endregion

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
    }
}
