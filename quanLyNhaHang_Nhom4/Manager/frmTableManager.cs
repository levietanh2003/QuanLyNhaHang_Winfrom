using quanLyNhaHang_Nhom4.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace quanLyNhaHang_Nhom4.Manager
{
    public partial class frmTableManager : Form
    {
       QuanLyQuanAnEntities contextDB = new QuanLyQuanAnEntities();
        public static int TableWidth = 110;
        public static int TableHeight = 110;
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; } //;
        }
        public frmTableManager(Account acc)
        {
            LoginAccount = acc;
            InitializeComponent();
            load();
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        #region Method
        void load()
        {
            fillCategoryCombobox();
            loadTable();
        }

        // load talle
        void loadTable()
        {
            flpTable.Controls.Clear();
            List<TableFood> tableFoods = (from x in contextDB.TableFoods select x).ToList();
            foreach(TableFood item in tableFoods)
            {
                Button btn = new Button() { Width = TableWidth, Height = TableHeight };
                btn.Text = item.nameTable + Environment.NewLine + item.statusTable;
                btn.Click += btnTable_Click;
                btn.Tag = item;
                btn.TabStop = false;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                switch (item.statusTable)
                {
                    case "Trống":
                        btn.Image = Image.FromFile(@"..\..\Image\Icon\trong.png");
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.TextAlign = ContentAlignment.TopCenter;
                        btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold);
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.BackColor = Color.White;

                        break;
                    default:
                        btn.Image = Image.FromFile(@"..\..\Image\Icon\trong.png");
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold);
                        btn.TextAlign = ContentAlignment.TopCenter;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.BackColor = Color.Green;
                        break;

                }
                flpTable.Controls.Add(btn);
            }
        }

        // fill combobox danh muc
        void fillCategoryCombobox()
        {
            List<FoodCategory> foodCategories = (from x in contextDB.FoodCategories select x).ToList();
            cmbCategoryFood.DataSource = foodCategories;
            cmbCategoryFood.DisplayMember = "nameFC";
           
        }

        // fill combobox mon an
        void fillFoodNameByCategory(int id)
        {
            List<Food> foods = (from x in contextDB.Foods where x.idFC == id && x.statusFood.Contains("Đang bán") select x).ToList();
            cmbNameFood.DataSource = foods;
            cmbNameFood.DisplayMember= "nameFood";
        }

        void loadImageFoodByIdFood(int id)
        {
            String image = (from f in contextDB.Foods where f.idFood == id select f.imageFood).FirstOrDefault().ToString();
            if (image == null)
            {
                image = "default.png";
            }
            Image img = GetCopyImage(@"..\..\Image\food\" + image);
            ptbImageFood.Image = img;
            if(img == null)
            {
                Image imgDeFauth = GetCopyImage(@"..\..\Image\food\default.png");
            }
            else
            ptbImageFood.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        void printBill()
        {
            pddHoaDon.Document = pdHoaDon;
            pddHoaDon.ShowDialog();
        }
        void loadPriceFoodByIdFood(int id)
        {
            float price = (float)((from f in contextDB.Foods where f.idFood == id select f.price).FirstOrDefault());
            CultureInfo culture = CultureInfo.CurrentCulture;
            lblFoodPrice.Text = double.Parse(price.ToString()).ToString("#,###", culture.NumberFormat) + " đ";
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

        // chuc nang gop ban
        private void mergeTable(TableFood table1, TableFood table2)
        {
           
        }
        #endregion

        #region Event
        private void btnTable_Click(object sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as TableFood).idTable;
            lsvBill.Tag = (sender as Button).Tag;
            showInfoFood(tableId);
        }
        // khi chon category xe lay id ra de fill name len combobox
        private void cmbCategoryFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idCategory = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            FoodCategory selected = cb.SelectedItem as FoodCategory;
            idCategory = selected.idFC;
            

            fillFoodNameByCategory(idCategory);
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            TableFood table = lsvBill.Tag as TableFood;
            if (table != null)
            {
                int idBill = -1;
                // vao bill lay ra trang thai ban = 0 la khong co nguoi
                List<Bill> bills = (from b in contextDB.Bills where b.idTable == table.idTable && b.statusBill == 0 select b).ToList();
                // gan idBill cho id duoi CSDl
                foreach (Bill item in bills)
                {
                    idBill = item.idBill;
                }

                int idFood = (cmbNameFood.SelectedItem as Food).idFood;
                int count = (int)nmCountFood.Value;
                if (idBill == -1)
                {
                    contextDB.USP_InsertBill(table.idTable);
                    int idBillMax = (from b in contextDB.Bills select b.idBill).Max();
                    contextDB.USP_InsertBillInfo(idBillMax, idFood, count);
                }
                else
                {
                    contextDB.USP_InsertBillInfo(idBill, idFood, count);
                }
                table.statusTable = "Có người";

                // lay thong tin mon an an dat vao listView
                showInfoFood(table.idTable);
                loadTable();
            }
            else
            {
                msg.Show("Vui lòng chọn bàn để thêm món! ", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
            }
        }

        // luu thong tin mon an dat len listView
        void showInfoFood(int id)
        {

            lsvBill.Items.Clear();
            float totalPrice = 0;
            // thuc hien truy van de ket noi bang va lay thong tin nhu mong muon 
            var listBillInfro = (from bi in contextDB.BillInfoes
                                join b in contextDB.Bills on bi.idBill equals b.idBill
                                join f in contextDB.Foods on bi.idFood equals f.idFood
                                where b.statusBill == 0 && b.idTable == id
                                select new
                                {
                                    f.nameFood,
                                    bi.countFood,
                                    f.price,

                                });

            foreach (var item in listBillInfro)
            {
                ListViewItem lsvItem = new ListViewItem(item.nameFood.ToString());
                // so luong
                lsvItem.SubItems.Add(item.countFood.ToString());
                // gia mon 
                lsvItem.SubItems.Add(item.price.ToString());
                // tinh tien theo mon
                lsvItem.SubItems.Add((item.countFood * item.price).ToString());
                //tong so mon an
                totalPrice += float.Parse((item.countFood * item.price).ToString());
                lsvBill.Items.Add(lsvItem);
            }
            //CultureInfo culture = new CultureInfo("vi-VN");
            CultureInfo culture = CultureInfo.CurrentCulture;

            //Thread.CurrentThread.CurrentCulture = culture;
            if (double.Parse(totalPrice.ToString()) != 0)
                txtTotalPrice.Text = double.Parse(totalPrice.ToString()).ToString("#,###", culture.NumberFormat) + " đ";
            else
                txtTotalPrice.Text = "";
            //txbTotalPrice.Text = totalPrice.
        }
        private void cmbNameFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idFood = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Food selected = cb.SelectedItem as Food;
            idFood = selected.idFood;

            loadImageFoodByIdFood(idFood);
            loadPriceFoodByIdFood(idFood);
        }
        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            load();
            
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            int idBill = -1;
            TableFood table = lsvBill.Tag as TableFood;
            List<Bill> bills = (from b in contextDB.Bills where b.idTable == table.idTable && b.statusBill == 0 select b).ToList();
            if (table != null)
            {
                foreach(var item in bills)
                {
                    idBill = item.idBill;
                }

                int discount = (int)nmDiscount.Value;
                // nguoi thanh toan
                string payperID = loginAccount.userName;
                if (idBill != -1)
                {
                    float totalPrice = float.Parse((txtTotalPrice.Text).ToString().Split(' ')[0]);
                    float finalTotalPrice = (totalPrice - totalPrice * discount / 100);
                    if (msg.Show(string.Format("Bạn có muốn thành toán cho bàn {0}\nTổng tiền: {1}đ\nSố tiền của bạn sau khi được giảm giá {2}% là: {3}đ", table.nameTable, totalPrice, discount, finalTotalPrice), "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Success) == DialogResult.Yes)
                    {
                        printBill();
                        contextDB.USP_CheckOut(discount, finalTotalPrice, payperID, idBill);
                        showInfoFood(table.idTable);
                        table.statusTable = "Trống";
                        loadTable();
                    }
                }
                else
                {
                    msg.Show("Da co loi xay ra ! ", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Warning);
                }
            }
            else
            {
                msg.Show("Vui lòng chọn bàn để thêm món! ", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Warning);

            }

        }
        // in hoa don 
        private void dpHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var tenNhaHang = "Cuộc Hẹn Sau Giờ Làm";
            var diaChi = "Đại học Công nghệ TP.HCM (Thu Duc Campus)";
            var phone = "0772722361";

            TableFood table = lsvBill.Tag as TableFood;

            var hoaDon = -1;
            var dateCheckIn = DateTime.Now;
            List<Bill> bills = (from x in contextDB.Bills where x.idTable == table.idTable && x.statusBill == 0 select x).ToList();

            foreach(var item in bills)
            {
                hoaDon = item.idBill;
                dateCheckIn = item.dateCheckIn;
            }

            var w = pdHoaDon.DefaultPageSettings.PaperSize.Width;
            e.Graphics.DrawImage(Image.FromFile(@"..\..\Image\Icon\logo_quanAN.png"), w / 4 - 20, 20, 100, 100);
            e.Graphics.DrawString(tenNhaHang.ToUpper(), new Font("Courier New", 30, FontStyle.Bold), Brushes.Black, new Point(100, 120));
            e.Graphics.DrawString(String.Format("Số hóa đơn: {0}", hoaDon), new Font("Courier New", 15, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 190, 85));
            e.Graphics.DrawString(table.nameTable, new Font("Courier New", 30, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 220, 140));
            Pen blackPen = new Pen(Color.Black, 1);
            Point p1 = new Point(w / 2 + 180, 105);
            Point p2 = new Point(w - 40, 105);
            e.Graphics.DrawLine(blackPen, p1, p2);

            p1 = new Point(w / 2 + 190, 108);
            p2 = new Point(w - 50, 108);
            e.Graphics.DrawLine(blackPen, p1, p2);

            e.Graphics.DrawString(string.Format("{0} - {1}", diaChi, phone), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(70, 160));
            e.Graphics.DrawString(String.Format("{0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm")), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 200, 110));


            var y = 200;
            p1 = new Point(80, y);
            p2 = new Point(w - 80, y);
            e.Graphics.DrawLine(blackPen, p1, p2);


            y += 20;
            e.Graphics.DrawString("HÓA ĐƠN GỌI MÓN", new Font("Courier New", 30, FontStyle.Bold), Brushes.Black, new Point(w / 4, y - 10));
            DateTime time = DateTime.Now;
            y += 30;
            e.Graphics.DrawString(String.Format("Thời gian vào: {0}", dateCheckIn.ToString("dd/MM/yyyy HH:mm")), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(40, y));
            e.Graphics.DrawString(String.Format("Thời gian thanh toán: {0}", time.ToString("dd/MM/yyyy HH:mm")), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 80, y));


            y += 20;
            p1 = new Point(20, y);
            p2 = new Point(w - 20, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            y += 10;

            e.Graphics.DrawString("STT", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(40, y));
            e.Graphics.DrawString("Tên món", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(100, y));
            e.Graphics.DrawString("SL", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
            e.Graphics.DrawString("Đơn giá", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 100, y));
            e.Graphics.DrawString("Thành tiền", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w - 170, y));

            //int i = 1;
            y += 20;
            int flag = y;
            //int sum = 0;
            for (int i = 0; i < lsvBill.Items.Count; i++)
            {
                y += 20;
                e.Graphics.DrawString(string.Format("{0}", i + 1), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(45, y));
                e.Graphics.DrawString(lsvBill.Items[i].SubItems[0].Text, new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(105, y));
                e.Graphics.DrawString(Int32.Parse(lsvBill.Items[i].SubItems[1].Text).ToString(), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 5, y));
                e.Graphics.DrawString(Int32.Parse(lsvBill.Items[i].SubItems[2].Text).ToString(), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 105, y));
                e.Graphics.DrawString(Int32.Parse(lsvBill.Items[i].SubItems[3].Text).ToString(), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w - 165, y));
            }
            for (int i = 0; i < 20; i++)
            {
                flag += 20;
                e.Graphics.DrawString("............................................................................................................", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(45, flag + 4));

            }
            y += 20 * (20 - lsvBill.Items.Count);
            y += 40;
            y += 20;
            p1 = new Point(20, y);
            p2 = new Point(w - 20, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            int discount = (int)nmDiscount.Value;
            float totalPrice = float.Parse((txtTotalPrice.Text).ToString().Split(' ')[0]);
            float finalTotalPrice = (totalPrice - totalPrice * discount / 100);
            y += 20;
            e.Graphics.DrawString(string.Format("Tổng tiền:"), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(40, y));
            e.Graphics.DrawString(string.Format("{0:N0} VNĐ", totalPrice), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w - 100 - totalPrice.ToString().Length * 10, y));
            y += 20;
            e.Graphics.DrawString(string.Format("Giảm giá:"), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(40, y));
            e.Graphics.DrawString(string.Format("-{0:N0} VNĐ({1}%)", totalPrice * discount / 100, discount), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w - 100 - totalPrice.ToString().Length * 10, y));
            y += 20;
            e.Graphics.DrawString(string.Format("Thành tiền:"), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(40, y));
            e.Graphics.DrawString(string.Format("{0:N0} VNĐ", finalTotalPrice), new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w - 100 - finalTotalPrice.ToString().Length * 10, y));

            y += 30;
            e.Graphics.DrawString(string.Format("Thành chữ:", new NumberToText().ChuyenSoSangChuoi(finalTotalPrice)), new Font("Courier New", 10, FontStyle.Italic), Brushes.Black, new Point(40, y));
            e.Graphics.DrawString(string.Format("{0}", new NumberToText().ChuyenSoSangChuoi(finalTotalPrice)), new Font("Courier New", 10, FontStyle.Italic), Brushes.Black, new Point(w - 40 - (new NumberToText().ChuyenSoSangChuoi(finalTotalPrice)).ToString().Length * 10, y));

            y += 40;
            e.Graphics.DrawString("Xin chân thành cảm ơn sự ủng hộ của quý khách!", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(200, y + 50));
            e.Graphics.DrawImage(Image.FromFile(@"..\..\Image\Icon\anh-5-sao.png"), w / 4 + 20, y + 80, 400, 85);
        }
        #endregion
    }
}
