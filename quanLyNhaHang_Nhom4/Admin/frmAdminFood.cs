using quanLyNhaHang_Nhom4.Database;
using quanLyNhaHang_Nhom4.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyNhaHang_Nhom4.Admin
{
    public partial class frmAdminFood : Form
    {
        QuanLyQuanAnEntities contextDB = new QuanLyQuanAnEntities();
        public frmAdminFood()
        {
            InitializeComponent();
            load();
            columnRatio();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #region Method
        void load()
        {
            loadListFood();
            loadCategory();
        }
        public void columnRatio()
        {
            int totalWidth = dgvFoodList.Width;
            int column1Width = (int)(totalWidth * 0.25);
            int column2Width = (int)(totalWidth * 0.25);
            int column3Width = (int)(totalWidth * 0.25);
            int column4Width = (int)(totalWidth * 0.25);

            dgvFoodList.Columns[0].Width = column1Width;
            dgvFoodList.Columns[1].Width = column2Width;
            dgvFoodList.Columns[2].Width = column3Width;
            dgvFoodList.Columns[3].Width = column4Width;

        }
        // load du lieu le dataGirdView
        void loadListFood()
        {
            int index = 0;
            dgvFoodList.Rows.Clear();
            foreach(var item in (from x in contextDB.Foods select x ).ToList())
            {
                index = dgvFoodList.Rows.Add();
                dgvFoodList.Rows[index].Cells[0].Value = item.idFood;
                dgvFoodList.Rows[index].Cells[1].Value = item.nameFood;
                dgvFoodList.Rows[index].Cells[2].Value = item.idFC;
                dgvFoodList.Rows[index].Cells[3].Value = item.price;
                dgvFoodList.Rows[index].Cells[4].Value = item.imageFood;
                dgvFoodList.Rows[index].Cells[5].Value = item.statusFood;
            }
            lblTotalFood.Text = "Tổng số món ăn: " + (dgvFoodList.Rows.Count - 1).ToString();
            setDataGridView(dgvFoodList);
        }
        
        // load theo ten
        void loadListFoodByName(string name)
        {
            int index = 0;
            dgvFoodList.Rows.Clear();
            foreach (var item in (from x in contextDB.Foods 
                                  where x.nameFood.Contains(name)
                                  select x).ToList())
            {
                index = dgvFoodList.Rows.Add();
                dgvFoodList.Rows[index].Cells[0].Value = item.idFood;
                dgvFoodList.Rows[index].Cells[1].Value = item.nameFood;
                dgvFoodList.Rows[index].Cells[2].Value = item.idFC;
                dgvFoodList.Rows[index].Cells[3].Value = item.price;
                dgvFoodList.Rows[index].Cells[4].Value = item.imageFood;
                dgvFoodList.Rows[index].Cells[5].Value = item.statusFood;
            }
            lblTotalFood.Text = "Tổng số món ăn: " + (dgvFoodList.Rows.Count - 1).ToString();
            setDataGridView(dgvFoodList);
        }

        // load loai thuc an len comboox
        void loadCategory()
        {
            List<FoodCategory> foodCategories = (from x in contextDB.FoodCategories select x).ToList();
            cbbFoodCategory.DataSource = foodCategories;
            cbbFoodCategory.DisplayMember = "nameFC";
        }

        // kiem tra anh trong Image\food\ va do len tren form
        void LoadImageFoodByIdFood(int id)
        {
            String image = (from f in contextDB.Foods where f.idFood == id select f.imageFood).FirstOrDefault();
            Image img = GetCopyImage(@"..\..\Image\food\" + image);
            ptbImageOfFood.Image = img;
            ptbImageOfFood.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

        // mo file de upload anh
        void GetFile()
        {
            System.Windows.Forms.OpenFileDialog openImage = new OpenFileDialog();
            openImage.Title = "Select your image";
            openImage.InitialDirectory = "C:";
            openImage.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openImage.AutoUpgradeEnabled = true;
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                String Chosen_File = openImage.FileName;

                string filename = System.IO.Path.GetFileName(Chosen_File);
                String inputExt = (Path.GetExtension(filename).ToLower());
                try
                {
                    System.IO.File.Copy(Chosen_File, @"..\..\Image\food\" + filename);
                }
                catch
                {
                }
                Invoke((MethodInvoker)delegate
                {
                    lblLinkImage.Text = filename;
                    ptbImageOfFood.Image = new Bitmap(Chosen_File);
                    ptbImageOfFood.SizeMode = PictureBoxSizeMode.StretchImage;
                });
            }
        }

        // them food
        void AddFood()
        {
            string name = txtFoodName.Text;
            int idCategory = (cbbFoodCategory.SelectedIndex) + 1;
            float price = 0;
            string linkImage = lblLinkImage.Text;
            if (name != "" && float.TryParse(txtPrice.Text, out price))
            {
                if ((from f in contextDB.Foods where f.nameFood == name select f).FirstOrDefault() != null)
                {
                    if (msg.Show("Tên món ăn đã tồn tại. Bạn có chắc chắn thêm món?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Warning) == DialogResult.Yes)
                    {
                        if (linkImage == "")
                        {
                            if (msg.Show("Bạn vẫn chưa tải hình món ăn lên. Bạn có chắc chắn thêm món?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                            {
                                if (contextDB.USP_InsertFood(name, idCategory, price, linkImage) > 0)
                                {
                                    msg.Show("Thêm thành công", "THÔNG BÁO",msg.Buttons.Yes, msg.Icon.Success);
                                    loadListFood();
                                }
                                else
                                {
                                    msg.Show("Có lỗi khi thêm món ăn.", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                                }
                            }
                        }
                        else
                        {
                            if (contextDB.USP_InsertFood(name, idCategory, price, linkImage) > 0)
                            {
                                msg.Show("Thêm thành công.","THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                                loadListFood();
                            }
                            else
                            {
                               msg.Show("Có lỗi khi thêm món ăn.", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                            }
                        }
                    }
                }
                else
                {
                    if (contextDB.USP_InsertFood(name, idCategory, price, linkImage) > 0)
                    {
                        msg.Show("Thêm thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        loadListFood();
                    }
                    else
                    {
                        msg.Show("Có lỗi khi thêm món ăn", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
            else
            {
                if (name == "")
                {
                    msg.Show("Vui lòng nhập tên món ăn !", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                }
                else
                {
                    msg.Show("Vui lòng nhập giá món ăn là số!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                }
            }
        }

        // xoa food
        void DeleteFood()
        {
            try
            {
                int idFood = Int32.Parse(txtFoodID.Text);
                string name = txtFoodID.Text;
                string linkImage = lblLinkImage.Text;

                if (msg.Show("Bạn có chắc chắn muốn xóa món " + name + "?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                {
                    Food foodDelete = (from food in contextDB.Foods where food.idFood == idFood select food).FirstOrDefault();
                    contextDB.Foods.Remove(foodDelete);
                    if (contextDB.SaveChanges() > 0)
                    {
                        msg.Show("Xóa thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        if (File.Exists(@"..\..\Image\food\" + linkImage)) // kiem tra tap tin dung huong dan 
                        {
                            File.Delete(@"..\..\Image\food\" + linkImage); // xao tep anh do
                        }
                        loadListFood();
                    }
                    else
                    {
                        msg.Show("Đã có lỗi xảy ra", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                    }
                }
            }
            catch
            {
                msg.Show("Bạn không thể xóa món ăn này!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Info);
            }
        }

        // sua food
        void EditFood()
        {
            int idFood = Int32.Parse(txtFoodID.Text);
            string name = txtFoodName.Text;
            int idCategory = (cbbFoodCategory.SelectedIndex) + 1;
            float price = 0;
            string linkImage = lblLinkImage.Text;

            if(name == "" || float.TryParse(txtPrice.Text, out price))
            {
                Food foodEdit = (from food in contextDB.Foods where food.idFood ==  idFood select  food).FirstOrDefault();
                // kiem tra nguoi dung khi chua cap nhat anh
                if((from x in contextDB.Foods where x.imageFood == linkImage && x.idFood == idFood select x).FirstOrDefault() != null)
                {
                    if (msg.Show("Bạn vẫn chưa tải hình món ăn lên.\n Bạn có chắc chắn sửa món?", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
                    {
                        foodEdit.idFood = idFood;
                        foodEdit.nameFood = name;
                        foodEdit.price = price;
                        foodEdit.imageFood = linkImage;
                        contextDB.SaveChanges();
                        msg.Show("Sửa thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                        loadListFood();
                    }
                }
                else
                {
                    foodEdit.idFood = idFood;
                    foodEdit.nameFood = name;
                    foodEdit.price = price;
                    foodEdit.imageFood = linkImage;
                    contextDB.SaveChanges();
                    msg.Show("Sửa thành công", "THÔNG BÁO", msg.Buttons.Yes, msg.Icon.Success);
                    loadListFood();
                }
            }
            else
            {
                if (name == "")
                {
                    msg.Show("Vui lòng nhập tên món ăn !", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                }
                else
                {
                    msg.Show("Vui lòng nhập giá món ăn là số!", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Error);
                }
            }
        }
        void setDataGridView(DataGridView dataGrid)
        {
            // fontSize 
            int desiredFontSize = 12;

            // chinh font size cho toan bo dgv
            dataGrid.DefaultCellStyle.Font = new Font("Cambria", desiredFontSize);

            // chinh frontSize cho ten cot
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 15, FontStyle.Bold);

            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGrid.BackgroundColor = Color.White;

            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        #endregion

        #region Event
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            AddFood();
        }
        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            DeleteFood();
        }
        private void btnEditFood_Click(object sender, EventArgs e)
        {
            EditFood();
        }
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            loadListFood();
            txtSearchFood.Text = string.Empty;
        }
        private void txtSearchFood_TextChanged(object sender, EventArgs e)
        {
            loadListFoodByName(txtSearchFood.Text);
        }
        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            Thread threadGetFile = new Thread(new ThreadStart(GetFile));
            threadGetFile.ApartmentState = ApartmentState.STA;
            threadGetFile.Start();
        }
        private void dgvFoodList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dgvFoodList.Rows[rowIndex];
                txtFoodID.Text = row.Cells[0].Value.ToString();
                txtFoodName.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[3].Value.ToString();
                lblLinkImage.Text = row.Cells[4].Value.ToString();
                cbStatus.Checked = row.Cells[5].Value.ToString() == "Đang bán";
                cbbFoodCategory.SelectedIndex = (int)row.Cells[2].Value - 1;
                LoadImageFoodByIdFood((int)row.Cells[0].Value);
            }
            catch
            {

            }
        }
        public bool ChangeStatus(bool status, int idFood)
        {
            Food food = (from f in contextDB.Foods where f.idFood == idFood select f).FirstOrDefault();
            food.statusFood = "Đang bán";
            //string query = string.Format("update food set statusFood = N'Đang bán' where idFood = " + idFood);
            if (status == false) food.statusFood = "Tạm ngưng";// query = string.Format("update food set statusFood = N'Tạm ngưng' where idFood = " + idFood);
            //int result = DataProvider.Instance.ExecuteNonQuery(query);
            return contextDB.SaveChanges() > 0;
        }
        private void cbStatus_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int idFood = Int32.Parse(txtFoodID.Text);
                ChangeStatus(cbStatus.Checked == true , idFood);
            }
            catch
            {
                msg.Show("Vui lòng chọn món trước khi điều chỉnh", "THÔNG BÁO", msg.Buttons.No, msg.Icon.Warning);
            }
        }
        #endregion
    }
}
