using quanLyNhaHang_Nhom4.Database;
using quanLyNhaHang_Nhom4.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace quanLyNhaHang_Nhom4.Admin
{
    public partial class frmAdminRevenue : Form
    {
        QuanLyQuanAnEntities contextDB = new QuanLyQuanAnEntities();
        public frmAdminRevenue()
        {
            InitializeComponent();
            load();
        }

        #region Method
        void load()
        {
            loadTimeDatePickerBill();
            loadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        //load du lieu dgvViewRevenue
        void loadListAllBill()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            int indexRow = 0;
            dgvViewRevenue.Rows.Clear();
            double total = 0;
            foreach(var item in (from x in contextDB.Bills select x).ToList())
            {
                indexRow = dgvViewRevenue.Rows.Add();
                dgvViewRevenue.Rows[indexRow].Cells[0].Value = item.idBill;
                dgvViewRevenue.Rows[indexRow].Cells[1].Value = item.totalPrice;
                dgvViewRevenue.Rows[indexRow].Cells[2].Value = item.discount;
                dgvViewRevenue.Rows[indexRow].Cells[3].Value = item.dateCheckIn.ToString("dd/MM/yyyy HH:mm");
                dgvViewRevenue.Rows[indexRow].Cells[4].Value = item.dateCheckOut == null ? item.dateCheckOut.ToString() : DateTime.Parse(item.dateCheckOut.ToString()).ToString("dd/MM/yyyy HH:mm");//.Split(' ')[0];
                dgvViewRevenue.Rows[indexRow].Cells[5].Value = item.payerId;
                total += double.Parse(item.totalPrice.ToString());
            }
            string totalPrice = double.Parse(total.ToString()).ToString("#,###", culture.NumberFormat) + " đ";
            lblTotalRevenue.Text = "Doanh thu: " + totalPrice;
            setDataGridView(dgvViewRevenue);
        }

        // load bill len chart va dgvRevenue
        void loadChart()
        {
            
            FoodChart.ChartAreas["ChartArea"].AxisY.Title = "Số món ăn đã bán";
            FoodChart.ChartAreas["ChartArea"].AxisX.Title = "Tên món ăn";
            FoodChart.ChartAreas["ChartArea"].AxisX.Interval = 1;
            FoodChart.Series["Số món ăn đã bán"].IsValueShownAsLabel = true;
            FoodChart.ChartAreas["ChartArea"].AxisX.LabelStyle.Interval = 1;

            // load top mon an len dgvFoodRevenue
            var foodTop = contextDB.USP_GetFoodTop5(dtpkFromDate.Value, dtpkToDate.Value).ToList();
            int indeRow = 0;
            dgvFoodRevenue.Rows.Clear();
            foreach(var item in foodTop)
            {
                indeRow = dgvFoodRevenue.Rows.Add();
                dgvFoodRevenue.Rows[indeRow].Cells[0].Value = item.nameFood;
                dgvFoodRevenue.Rows[indeRow].Cells[1].Value = item.countFood;
                dgvFoodRevenue.Rows[indeRow].Cells[2].Value = item.unitPrice;
                dgvFoodRevenue.Rows[indeRow].Cells[3].Value = item.totalPrice;
            }
            setDataGridView(dgvFoodRevenue);

            FoodChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            foreach (var series in FoodChart.Series)
            {
                series.Points.Clear();
            }
            foreach (var item in foodTop)
            {
                FoodChart.Series["Số món ăn đã bán"].Points.AddXY(item.nameFood, item.countFood);
            }
        }
        // load billByDate
        void loadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            CultureInfo culture = CultureInfo.CurrentCulture;

            int indexRow = 0;
            dgvViewRevenue.Rows.Clear();
            double total = 0;
            foreach(var item in (contextDB.USP_GetListBillByDate(checkIn,checkOut)).ToList())
            {
                indexRow = dgvViewRevenue.Rows.Add();
                dgvViewRevenue.Rows[indexRow].Cells[0].Value = item.idBill;
                dgvViewRevenue.Rows[indexRow].Cells[1].Value = item.totalPrice;
                dgvViewRevenue.Rows[indexRow].Cells[2].Value = item.discount;
                dgvViewRevenue.Rows[indexRow].Cells[3].Value = item.dateCheckIn.ToString("dd/MM/yyyy HH:mm");
                dgvViewRevenue.Rows[indexRow].Cells[4].Value = item.dateCheckOut == null ? item.dateCheckOut.ToString() : DateTime.Parse(item.dateCheckOut.ToString()).ToString("dd/MM/yyyy HH:mm");//.Split(' ')[0];
                dgvViewRevenue.Rows[indexRow].Cells[5].Value = item.payerId;
                total += double.Parse(item.totalPrice.ToString());
            }
            string totalPrice = double.Parse(total.ToString()).ToString("#,###", culture.NumberFormat) + " đ";
            lblTotalRevenue.Text = "Doanh thu: " + totalPrice;
            setDataGridView(dgvViewRevenue);
        }

        // load dtpk ve ngay dau thang va cuoi thang hien tai
        void loadTimeDatePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year,today.Month,1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        // set dataGridView
        void setDataGridView(DataGridView dataGridView)
        {
            // fontSize 
            int desiredFontSize = 12;

            // chinh font size cho toan bo dgv
            dataGridView.DefaultCellStyle.Font = new Font("Cambria", desiredFontSize);

            // chinh frontSize cho ten cot
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 15, FontStyle.Bold);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        #endregion

        #region Event
        private void rbt_seeAll_CheckedChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = DateTime.Parse("01/01/2023");
            loadListAllBill();
        }
        private void rbt_today_CheckedChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = today.Date;
            dtpkToDate.Value = today.Date.AddDays(1);
            //loadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);

        }
        private void rbt_month_CheckedChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
            //loadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);

        }
        private void rbt_year_CheckedChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, 1, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddYears(1).AddDays(-1);
            //loadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private void dtpkFromDate_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
        private void rbt_seeOnDay_CheckedChanged(object sender, EventArgs e)
        {
            if (dtpkFromDate.Value > dtpkToDate.Value)
            {
                msg.Show("Khoảng thời gian xem không hợp lệ ", "THÀNH CÔNG", msg.Buttons.No, msg.Icon.Warning);
            }
            else
            {
                loadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            }
        }

        private void dtpkFromDate_ValueChanged(object sender, EventArgs e)
        {
            loadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            loadChart();
        }

        #endregion

        private void dtpkToDate_ValueChanged(object sender, EventArgs e)
        {
            loadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            loadChart();
        }
    }
}
