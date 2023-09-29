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
    public partial class frmAdminTable : Form
    {
        public frmAdminTable()
        {
            InitializeComponent();
            columnRatio();
        }
        #region Event
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTable_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        #endregion

        #region Method
        public void columnRatio()
        {
            int totalWidth = dgvBanAn.Width;
            int column1Width = (int)(totalWidth * 0.2);
            int column2Width = (int)(totalWidth * 0.4);
            int column3Width = (int)(totalWidth * 0.4);

            dgvBanAn.Columns[0].Width = column1Width;
            dgvBanAn.Columns[1].Width = column2Width;
            dgvBanAn.Columns[2].Width = column3Width;
        }
        #endregion
    }
}
