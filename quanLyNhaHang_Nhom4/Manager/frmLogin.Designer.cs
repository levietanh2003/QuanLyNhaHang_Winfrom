namespace quanLyNhaHang_Nhom4.Manager
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbUserName = new System.Windows.Forms.PictureBox();
            this.ptbPassWord = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.logo_quanAN;
            this.pictureBox1.Location = new System.Drawing.Point(12, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(408, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANG NHAP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbUserName
            // 
            this.ptbUserName.BackColor = System.Drawing.Color.White;
            this.ptbUserName.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbUserName.ErrorImage")));
            this.ptbUserName.Image = ((System.Drawing.Image)(resources.GetObject("ptbUserName.Image")));
            this.ptbUserName.InitialImage = global::quanLyNhaHang_Nhom4.Properties.Resources.user_regular_24;
            this.ptbUserName.Location = new System.Drawing.Point(347, 208);
            this.ptbUserName.Name = "ptbUserName";
            this.ptbUserName.Size = new System.Drawing.Size(67, 62);
            this.ptbUserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbUserName.TabIndex = 2;
            this.ptbUserName.TabStop = false;
            // 
            // ptbPassWord
            // 
            this.ptbPassWord.BackColor = System.Drawing.Color.White;
            this.ptbPassWord.Image = ((System.Drawing.Image)(resources.GetObject("ptbPassWord.Image")));
            this.ptbPassWord.Location = new System.Drawing.Point(347, 349);
            this.ptbPassWord.Name = "ptbPassWord";
            this.ptbPassWord.Size = new System.Drawing.Size(67, 62);
            this.ptbPassWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPassWord.TabIndex = 2;
            this.ptbPassWord.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(431, 232);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(280, 38);
            this.txtUser.TabIndex = 3;
            this.txtUser.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(431, 373);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(280, 38);
            this.txtPassWord.TabIndex = 3;
            this.txtPassWord.Enter += new System.EventHandler(this.txtPassWord_Enter);
            this.txtPassWord.Leave += new System.EventHandler(this.txtPassWord_Leave);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(501, 458);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(210, 55);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "ĐĂNG NHẬP";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // ptbExit
            // 
            this.ptbExit.BackColor = System.Drawing.Color.Transparent;
            this.ptbExit.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.exit_solid_24;
            this.ptbExit.Location = new System.Drawing.Point(653, 12);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(58, 58);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbExit.TabIndex = 5;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1201, 575);
            this.Controls.Add(this.ptbExit);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.ptbPassWord);
            this.Controls.Add(this.ptbUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbUserName;
        private System.Windows.Forms.PictureBox ptbPassWord;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.PictureBox ptbExit;
    }
}