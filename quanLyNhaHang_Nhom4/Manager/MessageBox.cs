using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyNhaHang_Nhom4.Manager
{
    public partial class msg : Form
    {
        // Các button sẽ hiển thị lên Msg.
        public enum Buttons
        {
            YesNo = 1,
            Yes = 2,
            No = 3
        }
        // Các icon thể hiện nội dung của Msg
        public enum Icon
        {
            Success = 1,
            Error = 2,
            Warning = 3,
            Info = 4,
            Question = 5,
            Shield = 6,
            Search = 7
        }
        public enum AnimateStyle
        {
            SlideDown = 1,
            FadeIn = 2,
            ZoomIn = 3
        }
        class AnimateMsgBox
        {
            public Size FormSize;
            public msg.AnimateStyle Style;
            public AnimateMsgBox(Size formSize, msg.AnimateStyle style)
            {
                this.FormSize = formSize;//formSize;
                this.Style = style;
            }
        }
        // Bóng đổ
        private const int CS_DROPSHADOW = 0x00020000;
        private static msg _msgBox;
        // Header, Footer và Icon
        private PictureBox _picIcon = new PictureBox();
        private Panel _plHeader = new Panel();
        private Label _lblTitle;
        private Panel _plFooter = new Panel();
        private Panel _plIcon = new Panel();
        // THông điệp
        private Label _lblMessage;
        // Panel
        private FlowLayoutPanel _flpButtons = new FlowLayoutPanel();
        // List các button
        private List<Button> _buttonCollection = new List<Button>();
        // Kết quả
        private static DialogResult _buttonResult = new DialogResult();
        // Timer hiệu ứng
        private static Timer _timer;
        // Phát tiếng Beep
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool MessageBeep(uint type);
        private msg()
        {
            //custom 
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.BackColor = Color.WhiteSmoke;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Width = 400;
            // Panel Picture Box
            _plIcon.Dock = DockStyle.Bottom;
            _plIcon.Padding = new Padding(0);
            _plIcon.Controls.Add(_picIcon);
            _picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            _picIcon.Dock = DockStyle.Bottom;
            _picIcon.Height = 70;
            // Header
            _lblTitle = new Label();
            _lblTitle.ForeColor = Color.FromArgb(236, 112, 99);
            _lblTitle.BackColor = Color.WhiteSmoke;//m cứ để màu coi nó nằm ở đâu cho dễ xác định
            _lblTitle.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _lblTitle.Dock = DockStyle.None;
            _lblTitle.Location = new System.Drawing.Point(0, 10);
            _lblTitle.AutoSize = false;
            _lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            _lblTitle.Height = 35; //à rồi, cái title chỉ là cái label nên nó nhỏ, muốn chỉnh thì phải chỉnh thằng header
            _lblTitle.Width = 484;
            //Footer
            _lblMessage = new Label();
            _lblMessage.ForeColor = Color.Black;
            _lblMessage.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _lblMessage.Dock = DockStyle.Bottom;
            _lblMessage.Location = new System.Drawing.Point(0, 50);
            _lblMessage.AutoSize = false;
            _lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            _lblMessage.Height = 60;
            _lblMessage.Width = 484;
            //====================================================
            _flpButtons.FlowDirection = FlowDirection.RightToLeft;
            _flpButtons.Dock = DockStyle.Fill;
            //===================================================
            _plHeader.Dock = DockStyle.Bottom;
            _plHeader.Padding = new Padding(0);
            _plHeader.Height = 100;
            _plHeader.BackColor = Color.WhiteSmoke;
            _plHeader.Controls.Add(_lblMessage);
            _plHeader.Controls.Add(_lblTitle);
            //====================================================
            _plFooter.Dock = DockStyle.Bottom;
            _plFooter.Padding = new Padding(0, 0, 5, 0);
            _plFooter.BackColor = Color.WhiteSmoke;
            _plFooter.Height = 60;
            _plFooter.Controls.Add(_flpButtons);
            // Add controls vào form
            this.Controls.Add(_plHeader);
            this.Controls.Add(_picIcon);
            this.Controls.Add(_plFooter);
        }
        private static void InitButtons(Buttons buttons)
        {
            switch (buttons)
            {
                case msg.Buttons.YesNo:
                    _msgBox.InitYesNoButtons();
                    break;
                case msg.Buttons.Yes:
                    _msgBox.InitYesButtons();
                    break;
                case msg.Buttons.No:
                    _msgBox.InitNoButtons();
                    break;

            }
            foreach (Button btn in _msgBox._buttonCollection)
            {

                btn.ForeColor = Color.FromArgb(255, 255, 255);
                btn.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.BackColor = Color.FromArgb(9, 132, 227);
                btn.Padding = new Padding(0);
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Height = 50;
                btn.Width = 110;
                _msgBox._flpButtons.Controls.Add(btn);
            }
        }
        private static void InitIcon(Icon icon)
        {
            switch (icon)
            {
                case msg.Icon.Success:

                    _msgBox._picIcon.BackgroundImage = Image.FromFile(@"..\..\Image\Icon\checked.png");
                    _msgBox._picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                    break;

                case msg.Icon.Error:
                    _msgBox._picIcon.BackgroundImage = Image.FromFile(@"..\..\Image\Icon\error.png");
                    _msgBox._picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                    break;

                case msg.Icon.Info:
                    _msgBox._picIcon.BackgroundImage = Image.FromFile(@"..\..\Image\Icon\info.png");
                    _msgBox._picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                    break;

                case msg.Icon.Question:
                    _msgBox._picIcon.BackgroundImage = Image.FromFile(@"..\..\Image\Icon\question.png");
                    _msgBox._picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                    break;

                case msg.Icon.Shield:
                    _msgBox._picIcon.BackgroundImage = Image.FromFile(@"..\..\Image\Icon\security.png");
                    _msgBox._picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                    break;

                case msg.Icon.Warning:
                    _msgBox._picIcon.BackgroundImage = Image.FromFile(@"..\..\Image\Icon\warning.png");
                    _msgBox._picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
                    break;
            }
        }
        private void InitYesNoButtons()
        {
            Button btnYes = new Button();
            btnYes.Text = "Xác Nhận";
            btnYes.Click += ButtonClick;

            Button btnNo = new Button();
            btnNo.Text = "Hủy Bỏ";
            btnNo.Click += ButtonClick;

            this._buttonCollection.Add(btnYes);
            this._buttonCollection.Add(btnNo);
        }
        private void InitYesButtons()
        {
            Button btnYes = new Button();
            btnYes.Text = "Xác Nhận";
            btnYes.Click += ButtonClick;
            this._buttonCollection.Add(btnYes);
        }
        private void InitNoButtons()
        {
            Button btnNo = new Button();
            btnNo.Text = "Hủy Bỏ";
            btnNo.Click += ButtonClick;
            this._buttonCollection.Add(btnNo);
        }
        private static void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text)
            {
                case "Xác Nhận":
                    _buttonResult = DialogResult.Yes;
                    break;
                case "Hủy Bỏ":
                    _buttonResult = DialogResult.No;
                    break;
            }
            _msgBox.Dispose();
        }
        private static Size MessageSize(string message)
        {
            Graphics g = _msgBox.CreateGraphics();
            //form size
            int width = 480;
            int height = 220;
            SizeF size = g.MeasureString(message, new System.Drawing.Font("Segoe UI", 10));
            if (message.Length < 150)
            {
                if ((int)size.Width > 350)
                {
                    width = (int)size.Width;
                }
            }
            else
            {
                string[] groups = (from Match m in Regex.Matches(message, ".{1,180}") select m.Value).ToArray();
                int lines = groups.Length + 1;
                width = 700;
                height += (int)(size.Height + 10) * lines;
            }
            return new Size(width, height);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1));
            Pen pen = new Pen(Color.FromArgb(0, 151, 251));

            g.DrawRectangle(pen, rect);
        }
        static void timer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            AnimateMsgBox animate = (AnimateMsgBox)timer.Tag;

            switch (animate.Style)
            {
                case msg.AnimateStyle.SlideDown:
                    if (_msgBox.Height < animate.FormSize.Height)
                    {
                        _msgBox.Height += 17;
                        _msgBox.Invalidate();
                    }
                    else
                    {
                        _timer.Stop();
                        _timer.Dispose();
                    }
                    break;
                case msg.AnimateStyle.FadeIn:
                    if (_msgBox.Opacity < 1)
                    {
                        _msgBox.Opacity += 0.1;
                        _msgBox.Invalidate();
                    }
                    else
                    {
                        _timer.Stop();
                        _timer.Dispose();
                    }
                    break;
                case msg.AnimateStyle.ZoomIn:
                    if (_msgBox.Width > animate.FormSize.Width)
                    {
                        _msgBox.Width -= 17;
                        _msgBox.Invalidate();
                    }
                    if (_msgBox.Height > animate.FormSize.Height)
                    {
                        _msgBox.Height -= 17;
                        _msgBox.Invalidate();
                    }
                    break;
            }
        }
        public static void Show(string message)
        {
            _msgBox = new msg();
            _msgBox._lblMessage.Text = message;
            _msgBox.ShowDialog();
            MessageBeep(0);
        }
        public static void Show(string message, string title)
        {
            _msgBox = new msg();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
            _msgBox.Size = msg.MessageSize(message);
            _msgBox.ShowDialog();
            MessageBeep(0);
        }
        public static DialogResult Show(string message, string title, Buttons buttons)
        {
            _msgBox = new msg();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
            _msgBox._picIcon.Hide();

            msg.InitButtons(buttons);

            _msgBox.Size = msg.MessageSize(message);
            _msgBox.ShowDialog();
            MessageBeep(0);
            return _buttonResult;
        }
        public static DialogResult Show(string message, string title, Buttons buttons, Icon icon)
        {
            _msgBox = new msg();
            _msgBox._lblMessage.Text = message; //đợi t xíu, đang có công chuyện ok
            _msgBox._lblTitle.Text = title;
            msg.InitButtons(buttons);
            msg.InitIcon(icon);
            _msgBox.Size = msg.MessageSize(message);
            _msgBox.ShowDialog();
            MessageBeep(0);
            return _buttonResult;
        }
        public static DialogResult Show(string message, string title, Buttons buttons, Icon icon, AnimateStyle style)
        {
            _msgBox = new msg();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
            _msgBox.Height = 0;
            msg.InitButtons(buttons);
            msg.InitIcon(icon);
            _timer = new Timer();
            Size formSize = msg.MessageSize(message);
            switch (style)
            {
                case msg.AnimateStyle.SlideDown:
                    _msgBox.Size = new Size(formSize.Width, 0);
                    _timer.Interval = 1;
                    _timer.Tag = new AnimateMsgBox(formSize, style);
                    break;
                case msg.AnimateStyle.FadeIn:
                    _msgBox.Size = formSize;
                    _msgBox.Opacity = 0;
                    _timer.Interval = 20;
                    _timer.Tag = new AnimateMsgBox(formSize, style);
                    break;
                case msg.AnimateStyle.ZoomIn:
                    _msgBox.Size = new Size(formSize.Width + 100, formSize.Height + 100);
                    _timer.Tag = new AnimateMsgBox(formSize, style);
                    _timer.Interval = 1;
                    break;
            }
            _timer.Tick += timer_Tick;
            _timer.Start();
            _msgBox.ShowDialog();
            MessageBeep(0);
            return _buttonResult;
        }
    }
}
