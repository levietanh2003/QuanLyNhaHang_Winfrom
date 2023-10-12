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
            ptbImageFood.SizeMode = PictureBoxSizeMode.StretchImage;
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
                        //printBill();
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
        #endregion
    }
}
