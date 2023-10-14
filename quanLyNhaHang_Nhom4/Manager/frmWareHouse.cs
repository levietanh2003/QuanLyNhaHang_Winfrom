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
    public partial class frmWareHouse : Form
    {
        QuanLyQuanAnEntities contextDB = new QuanLyQuanAnEntities();
        public frmWareHouse()
        {
            InitializeComponent();
            load();
        }

        #region Method

        void load()
        {
            loadBillOfWaseHouse();
        }
        void loadBillOfWaseHouse()
        {
            int insertRow = 0;
            dgvBillOfWareHouse.Rows.Clear();
            // lay ra bang BillOfWasHouse tu csdl
            List<BillOfWareHouse> billOfWareHouses = (from x in contextDB.BillOfWareHouses 
                                                      select x).ToList();                              
            foreach(var item in billOfWareHouses)
            {
                insertRow = dgvBillOfWareHouse.Rows.Add();
                dgvBillOfWareHouse.Rows[insertRow].Cells[0].Value = item.idBillOfWareHouse;
                dgvBillOfWareHouse.Rows[insertRow].Cells[1].Value = item.dateAdded.ToString().Split(' ')[0];
                dgvBillOfWareHouse.Rows[insertRow].Cells[2].Value = item.supplier;
                dgvBillOfWareHouse.Rows[insertRow].Cells[3].Value = item.note;

                lblTotalBill.Text = "Tổng số hóa đơn: " + (dgvBillOfWareHouse.Rows.Count).ToString();
                // fontSize 
                int desiredFontSize = 12;

                // chinh font size cho toan bo dgv
                dgvBillOfWareHouse.DefaultCellStyle.Font = new Font("Cambria", desiredFontSize);

                // chinh frontSize cho ten cot
                dgvBillOfWareHouse.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 15, FontStyle.Bold);

                dgvBillOfWareHouse.BorderStyle = BorderStyle.None;
                dgvBillOfWareHouse.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                dgvBillOfWareHouse.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgvBillOfWareHouse.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
                dgvBillOfWareHouse.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                dgvBillOfWareHouse.BackgroundColor = Color.White;

                dgvBillOfWareHouse.EnableHeadersVisualStyles = false;
                dgvBillOfWareHouse.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgvBillOfWareHouse.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
                dgvBillOfWareHouse.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            }
        }

        void loadBillInfoWareHouseById(int idBillWareHouseList)
        {
            lsvBillInfoOfWH.Items.Clear();
            int totalPrice = 0;
            //lay ra bang thong tin chi tiet hoa don nha cung cung theo ma
            foreach (var item in
                (from biwh in contextDB.BillInfoOfWareHouses
                 where biwh.idBillOfWareHouse == idBillWareHouseList
                 select biwh).ToList()
                )
            {
                ListViewItem lsvItem = new ListViewItem(item.Material.nameMaterial);
                lsvItem.SubItems.Add(item.number.ToString());
                lsvItem.SubItems.Add(item.price.ToString());
                lsvItem.SubItems.Add(item.totalPrice.ToString());
                totalPrice += item.price;
                lsvBillInfoOfWH.Items.Add(lsvItem);
            }
            txtTotalPrice.Text = totalPrice.ToString();
        }

        #endregion

        #region Event
        private void frmWareHouse_Load(object sender, EventArgs e)
        {

        }
        private void lsvBillInfoOfWH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dgvBillOfWareHouse_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int select = e.RowIndex;
                loadBillInfoWareHouseById(select + 1);
                txtBillOfWareHouseID.Text = dgvBillOfWareHouse.Rows[select].Cells[0].Value.ToString();
                txtDateAdd.Text = dgvBillOfWareHouse.Rows[select].Cells[1].Value.ToString();
                txtSupplier.Text = dgvBillOfWareHouse.Rows[select].Cells[2].Value.ToString();
                rtbNote.Text = dgvBillOfWareHouse.Rows[select].Cells[3].Value.ToString();

            }catch
            {
                msg.Show("Đã xảy ra lỗi khi thêm!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private void lblSupplier_Click(object sender, EventArgs e)
        {

        }

        private void lbl5_Click(object sender, EventArgs e)
        {

        }
    }
}
