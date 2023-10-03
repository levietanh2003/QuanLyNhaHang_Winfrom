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
            lblTotalCategory.Text = dgvFoodCategory.Rows.Count.ToString();


            dgvFoodCategory.BorderStyle = BorderStyle.None;
            dgvFoodCategory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvFoodCategory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFoodCategory.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvFoodCategory.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvFoodCategory.BackgroundColor = Color.White;

            dgvFoodCategory.EnableHeadersVisualStyles = false;
            dgvFoodCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFoodCategory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvFoodCategory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        #endregion
    }
}
