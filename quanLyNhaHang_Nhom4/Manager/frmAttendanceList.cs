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
        public frmAttendanceList()
        {
            InitializeComponent();
            columnRatio();
           
        }

        #region Method
        public void columnRatio()
        {
            int totalWidth = dgvDiemDanh.Width;
            int column1Width = (int)(totalWidth * 0.2);
            int column2Width = (int)(totalWidth * 0.4);
            int column3Width = (int)(totalWidth * 0.4);
            dgvDiemDanh.Columns[0].Width = column1Width;
            dgvDiemDanh.Columns[1].Width = column2Width;
            dgvDiemDanh.Columns[2].Width = column3Width;
        }
        #endregion
        #region Event

        #endregion
    }

}
