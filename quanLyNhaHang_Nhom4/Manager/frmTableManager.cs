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
                        break;
                    default:
                        // chua kiem anh trang thai co nguoi
                        btn.Image = Image.FromFile(@".\Image\conguoi.png");
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold);
                        btn.TextAlign = ContentAlignment.TopCenter;
                        btn.FlatStyle = FlatStyle.Flat;
                        break;

                }
                flpTable.Controls.Add(btn);
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            TableFood tableFood = lsvBill.Tag as TableFood;

            if (tableFood != null)
            {
                int idBill = -1;
                List<Bill> bills = (from b in contextDB.Bills where b.idTable == tableFood.idTable && b.statusBill == 0 select b).ToList();
                foreach (Bill item in bills)
                {
                    idBill = item.idBill;
                }

                int idFood = (cmbNameFood.SelectedItem as Food).idFood;
                int count = (int)nmCountFood.Value;
                if (idBill == -1)
                {
                    contextDB.USP_InsertBill(tableFood.idTable);
                    int idBillMax = (from b in contextDB.Bills select b.idBill).Max();
                    contextDB.USP_InsertBillInfo(idBillMax, idFood, count);
                }
                else
                {
                    contextDB.USP_InsertBillInfo(idBill, idFood, count);
                }
                tableFood.statusTable = "Có người";
                //ShowBill(table.idTable);
                loadTable();
            }
            else
            {
                msg.Show("Vui lòng chọn bàn để thêm món! ", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Info);
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

        #endregion

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
    }
}
