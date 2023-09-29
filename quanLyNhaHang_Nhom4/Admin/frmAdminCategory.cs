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
    public partial class frmAdminCategory : Form
    {
        public frmAdminCategory()
        {
            InitializeComponent();
            columnRatio();
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
            int totalWidth = dgvDanhMuc.Width;
            int column1Width = (int)(totalWidth * 0.2);  
            int column2Width = (int)(totalWidth * 0.4);  
            int column3Width = (int)(totalWidth * 0.4);

            dgvDanhMuc.Columns[0].Width = column1Width;
            dgvDanhMuc.Columns[1].Width = column2Width;
            dgvDanhMuc.Columns[2].Width = column3Width;
        }
        #endregion
    }
}
