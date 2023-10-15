using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanLyNhaHang_Nhom4.Admin;
using quanLyNhaHang_Nhom4.Database;

namespace quanLyNhaHang_Nhom4.Manager
{
    public partial class frmMain : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; changeAccount(loginAccount.typeAccount); }
        }

        public frmMain(Account acc)
        {
            InitializeComponent();
            customizeDesing();
            LoginAccount = acc;
            this.Text = string.Empty;
            //this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            lblTitle.Text = "Giới thiệu";
            this.pnlDesktop.Controls.Clear();
            frmHome frmHome = new frmHome()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add(frmHome);
            frmHome.Show();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #region Method
        void changeAccount(int type)
        {
            btnAdmin.Enabled = type == 1;
            btnWareHouse.Enabled = type == 1;
            btnOpenFormAttendance.Enabled = type == 1;
            //lblXinChao.Text = "Xin chào " + loginAccount.DisplayName + " !";
            btnDisplayName.Text = "Xin chào " + loginAccount.displayName + " !";
            //btnInfoAccount.Text += " (" + loginAccount.DisplayName + ")";
        }
        private void customizeDesing()
        {
            pnlSubAdmin.Visible = false;
            pnlSubWareHouse.Visible = false;
        }
       
        private void hideSubMenu()
        {
            if(pnlSubAdmin.Visible)
            {
                pnlSubAdmin.Visible = false;
            }
            if(pnlSubWareHouse.Visible)
            {
                pnlSubWareHouse.Visible = false;
            }
        }
        private void showSubMeNu(Panel subMenu)
        {
            if(!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void Reset()
        {
            hideSubMenu();
            this.pnlDesktop.Controls.Clear();
            frmHome frmHome = new frmHome()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmHome));
            frmHome.Show();
        }
        #endregion

        #region Event
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showSubMeNu(pnlSubAdmin);
            lblTitle.Text = string.Empty;

            this.pnlDesktop.Controls.Clear();
            frmAdmin frmAdmin = new frmAdmin()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmAdmin)frmAdmin);
            frmAdmin.Show();
        }

        private void btnWareHouse_Click(object sender, EventArgs e)
        {
            showSubMeNu(pnlSubWareHouse);
        }
        private void PtbLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            lblTitle.Text = "Đặt món";
            this.pnlDesktop.Controls.Clear();
            frmTableManager frmTableManager = new frmTableManager(LoginAccount)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmTableManager)frmTableManager);
            frmTableManager.Show();
        }
        private void btnOpenFormRevenue_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            lblTitle.Text = "Quản lý thông kê";
            this.pnlDesktop.Controls.Clear();

            frmAdminRevenue frmAdminRevenue = new frmAdminRevenue()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmAdminRevenue)frmAdminRevenue);
            frmAdminRevenue.Show();
        }
        void timer()
        {
            timer1 = new Timer();
            timer1.Interval = 1000;
            

            // Bắt đầu Timer
            timer1.Start();
        }
        private void btnOpenFromTable_Click(object sender, EventArgs e)
        {
            
            hideSubMenu();
            lblTitle.Text = "Quản lí bàn ăn";
            this.pnlDesktop.Controls.Clear();

            frmAdminTable frmAdminTable = new frmAdminTable()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmAdminTable)frmAdminTable);
            frmAdminTable.Show();
        }
        private void btnOpenFormAttendance_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            //load giao dien cham cong len giao dien chinh
            lblTitle.Text = "Chấm công";
            this.pnlDesktop.Controls.Clear();

            frmAttendanceList frmAttendanceList = new frmAttendanceList()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmAttendanceList)frmAttendanceList);
            frmAttendanceList.Show();
        }

        private void btnOpenFormCategory_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            lblTitle.Text = "Quản lý danh mục";
            this.pnlDesktop.Controls.Clear();

            frmAdminCategory frmAdminCategory = new frmAdminCategory()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmAdminCategory)frmAdminCategory);
            frmAdminCategory.Show();

        }

        private void btnOpenFormAccount_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            lblTitle.Text = "Quản lý tài khoản";
            this.pnlDesktop.Controls.Clear();

            frmAdminAccount frmAdminAccount = new frmAdminAccount()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmAdminAccount)frmAdminAccount);
            frmAdminAccount.Show();

        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            lblTitle.Text = "Thông tin";
            this.pnlDesktop.Controls.Clear();

            frmInfomation frmInfomation = new frmInfomation()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmInfomation)frmInfomation);
            frmInfomation.Show();
        }
        private void btnOpenFormFood_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            lblTitle.Text = "Quản lý món ăn";
            this.pnlDesktop.Controls.Clear();
            frmAdminFood frmAdminFood = new frmAdminFood()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmAdminFood)frmAdminFood);
            frmAdminFood.Show();
        }
        private void btnInfoWareHouse_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            lblTitle.Text = "Quản lý thông tin đơn hàng";
            this.pnlDesktop.Controls.Clear();
            frmWareHouse frmWareHouse = new frmWareHouse() 
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmWareHouse)frmWareHouse);
            frmWareHouse.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (msg.Show("Bạn có muốn đăng xuất không. ", "THÔNG BÁO", msg.Buttons.YesNo, msg.Icon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            lblTitle.Text = "Tra cứu món ăn";
            this.pnlDesktop.Controls.Clear();
            frmManagerFood frmManagerFood = new frmManagerFood()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmManagerFood)frmManagerFood);
            frmManagerFood.Show();
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDisplayName_Click(object sender, EventArgs e)
        {
            frmAccount f = new frmAccount(LoginAccount);
            f.ShowDialog();
        }
        private void btnAddBillOfWareHouse_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            lblTitle.Text = "Thêm nhà cung cấp";
            this.pnlDesktop.Controls.Clear();
            frmAddWareHouse frmAddWareHouse = new frmAddWareHouse(LoginAccount) 
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmAddWareHouse)frmAddWareHouse);
            frmAddWareHouse.Show();
        }

        private void btnOpenFormStaff_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            lblTitle.Text = "Quản lý nhân viên";
            this.pnlDesktop.Controls.Clear();
            frmAdminStaff frmAdminStaff = new frmAdminStaff()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
            };
            this.pnlDesktop.Controls.Add((frmAdminStaff)frmAdminStaff);
            frmAdminStaff.Show();
        }



        #endregion

        private void pnlDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            // Bắt đầu timer
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime selectedTime = DateTime.Now;
            string  formattedTime = selectedTime.ToString("dd/MM/yyyy - HH:mm:ss");
            lblClock.Text = formattedTime;
        }
    }
}
