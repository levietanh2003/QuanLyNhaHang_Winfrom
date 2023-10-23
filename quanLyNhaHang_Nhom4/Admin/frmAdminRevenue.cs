using Microsoft.Office.Interop.Excel;
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
using DataTable = System.Data.DataTable;

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
            //  đặt khoảng cách giữa các nhãn trên trục X thành 1.
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

            // Phương thức đặt độ rộng của các đường lưới chính trên trục X của biểu đồ thành 0. Nó cũng xóa bỏ các điểm dữ liệu hiện có từ tất cả các chuỗi trong biểu đồ.
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
            //dataGridView.DefaultCellStyle.Font = new Font("Cambria", desiredFontSize);
            dataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Cambria", desiredFontSize);

            // chinh frontSize cho ten cot
            //dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 15, FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Cambria", 15, FontStyle.Bold);

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

        // xuat file excel theo ngay thang yeu cau
        void explorFile(System.Data.DataTable data, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // tao phan tieu de
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // tao tieu de cot
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã Hóa Đơn";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Tổng Tiền";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Giảm Giá";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Ngày Vào";

            cl4.ColumnWidth = 10.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Ngày Ra";

            cl5.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "NV Thanh Toán";

            cl6.ColumnWidth = 18.5;

            //Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            //cl7.Value2 = "Tình trạng";

            //cl7.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

            rowHead.Font.Bold = true;

            // ke vien
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // thiet lap mau nen
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // tao mang theo dataTable
            object[,] arr = new object[data.Rows.Count, data.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            // chuyen di lieu dataTable vao mang doi tuong

            for (int row = 0; row < data.Rows.Count; row++)
            {
                DataRow dataRow = data.Rows[row];

                for (int col = 0; col < data.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            // thiet lap vung dien du lieu
            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + data.Rows.Count - 2;

            int columnEnd = data.Columns.Count;

            // o bat dau dien du lieu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            // o ket thuc dien du lieu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // lay ve vung dien du lieu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
            // dien du lieu vao vung da thiet lap
            range.Value2 = arr;
            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
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
        private void dtpkToDate_ValueChanged(object sender, EventArgs e)
        {
            loadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            loadChart();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DataTable dt = new System.Data.DataTable();

            DataColumn col1 = new DataColumn("Mã Hóa Đơn");
            DataColumn col2 = new DataColumn("Tổng Tiền");
            DataColumn col3 = new DataColumn("Giảm Giá");
            DataColumn col4 = new DataColumn("Ngày Vào");
            DataColumn col5 = new DataColumn("Ngày Ra");
            DataColumn col6 = new DataColumn("NV Thanh Toán");

            dt.Columns.Add(col1);
            dt.Columns.Add(col2);
            dt.Columns.Add(col3);
            dt.Columns.Add(col4);
            dt.Columns.Add(col5);
            dt.Columns.Add(col6);

            foreach (DataGridViewRow dgvRow in dgvViewRevenue.Rows)
            {
                DataRow dtRow = dt.NewRow();
                dtRow[0] = dgvRow.Cells[0].Value;
                dtRow[1] = dgvRow.Cells[1].Value;
                dtRow[2] = dgvRow.Cells[2].Value;
                dtRow[3] = dgvRow.Cells[3].Value;
                dtRow[4] = dgvRow.Cells[4].Value;
                dtRow[5] = dgvRow.Cells[5].Value;

                dt.Rows.Add(dtRow);
            }
            explorFile(dt, "Danh sach", "BÁO CÁO DOANH THU");
        }
        #endregion
    }
}
