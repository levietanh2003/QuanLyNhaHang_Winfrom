
namespace quanLyNhaHang_Nhom4.Manager
{
    partial class frmManagerFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerFood));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptrFoodImage = new System.Windows.Forms.PictureBox();
            this.rdbFoodStatus = new System.Windows.Forms.RadioButton();
            this.cmbNameFC = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNameFood = new System.Windows.Forms.TextBox();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.lblFoodImage = new System.Windows.Forms.Label();
            this.lblFoodStatus = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNameFc = new System.Windows.Forms.Label();
            this.lblNameFood = new System.Windows.Forms.Label();
            this.lblFoodID = new System.Windows.Forms.Label();
            this.txtSearchFood = new System.Windows.Forms.TextBox();
            this.txtTotalFood = new System.Windows.Forms.TextBox();
            this.dgvFoodInfo = new System.Windows.Forms.DataGridView();
            this.dgvFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFoodStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrFoodImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Image = ((System.Drawing.Image)(resources.GetObject("lblTitle.Image")));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1021, 100);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "      Quản lý thông tin thức ăn";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.ptrFoodImage);
            this.panel2.Controls.Add(this.rdbFoodStatus);
            this.panel2.Controls.Add(this.cmbNameFC);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtNameFood);
            this.panel2.Controls.Add(this.txtFoodID);
            this.panel2.Controls.Add(this.lblFoodImage);
            this.panel2.Controls.Add(this.lblFoodStatus);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblNameFc);
            this.panel2.Controls.Add(this.lblNameFood);
            this.panel2.Controls.Add(this.lblFoodID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(672, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 519);
            this.panel2.TabIndex = 1;
            // 
            // ptrFoodImage
            // 
            this.ptrFoodImage.Location = new System.Drawing.Point(69, 254);
            this.ptrFoodImage.Name = "ptrFoodImage";
            this.ptrFoodImage.Size = new System.Drawing.Size(220, 224);
            this.ptrFoodImage.TabIndex = 6;
            this.ptrFoodImage.TabStop = false;
            // 
            // rdbFoodStatus
            // 
            this.rdbFoodStatus.AutoSize = true;
            this.rdbFoodStatus.Location = new System.Drawing.Point(176, 199);
            this.rdbFoodStatus.Name = "rdbFoodStatus";
            this.rdbFoodStatus.Size = new System.Drawing.Size(91, 21);
            this.rdbFoodStatus.TabIndex = 5;
            this.rdbFoodStatus.TabStop = true;
            this.rdbFoodStatus.Text = "Đang bán";
            this.rdbFoodStatus.UseVisualStyleBackColor = true;
            // 
            // cmbNameFC
            // 
            this.cmbNameFC.Enabled = false;
            this.cmbNameFC.FormattingEnabled = true;
            this.cmbNameFC.Location = new System.Drawing.Point(133, 117);
            this.cmbNameFC.Name = "cmbNameFC";
            this.cmbNameFC.Size = new System.Drawing.Size(176, 24);
            this.cmbNameFC.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(133, 158);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(176, 24);
            this.txtPrice.TabIndex = 3;
            // 
            // txtNameFood
            // 
            this.txtNameFood.Location = new System.Drawing.Point(133, 76);
            this.txtNameFood.Name = "txtNameFood";
            this.txtNameFood.ReadOnly = true;
            this.txtNameFood.Size = new System.Drawing.Size(176, 24);
            this.txtNameFood.TabIndex = 3;
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(133, 35);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.ReadOnly = true;
            this.txtFoodID.Size = new System.Drawing.Size(176, 24);
            this.txtFoodID.TabIndex = 3;
            // 
            // lblFoodImage
            // 
            this.lblFoodImage.AutoSize = true;
            this.lblFoodImage.Location = new System.Drawing.Point(166, 493);
            this.lblFoodImage.Name = "lblFoodImage";
            this.lblFoodImage.Size = new System.Drawing.Size(26, 17);
            this.lblFoodImage.TabIndex = 2;
            this.lblFoodImage.Text = "......";
            this.lblFoodImage.Click += new System.EventHandler(this.lblImage_Click);
            // 
            // lblFoodStatus
            // 
            this.lblFoodStatus.AutoSize = true;
            this.lblFoodStatus.Location = new System.Drawing.Point(38, 202);
            this.lblFoodStatus.Name = "lblFoodStatus";
            this.lblFoodStatus.Size = new System.Drawing.Size(79, 17);
            this.lblFoodStatus.TabIndex = 2;
            this.lblFoodStatus.Text = "Trạng thái";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(38, 161);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 17);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Giá";
            // 
            // lblNameFc
            // 
            this.lblNameFc.AutoSize = true;
            this.lblNameFc.Location = new System.Drawing.Point(38, 120);
            this.lblNameFc.Name = "lblNameFc";
            this.lblNameFc.Size = new System.Drawing.Size(77, 17);
            this.lblNameFc.TabIndex = 2;
            this.lblNameFc.Text = "Danh mục";
            // 
            // lblNameFood
            // 
            this.lblNameFood.AutoSize = true;
            this.lblNameFood.Location = new System.Drawing.Point(38, 79);
            this.lblNameFood.Name = "lblNameFood";
            this.lblNameFood.Size = new System.Drawing.Size(88, 17);
            this.lblNameFood.TabIndex = 2;
            this.lblNameFood.Text = "Tên món ăn";
            // 
            // lblFoodID
            // 
            this.lblFoodID.AutoSize = true;
            this.lblFoodID.Location = new System.Drawing.Point(38, 38);
            this.lblFoodID.Name = "lblFoodID";
            this.lblFoodID.Size = new System.Drawing.Size(63, 17);
            this.lblFoodID.TabIndex = 2;
            this.lblFoodID.Text = "Mã món";
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold);
            this.txtSearchFood.Location = new System.Drawing.Point(137, 119);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(529, 24);
            this.txtSearchFood.TabIndex = 3;
            this.txtSearchFood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchFood_KeyPress);
            // 
            // txtTotalFood
            // 
            this.txtTotalFood.Enabled = false;
            this.txtTotalFood.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold);
            this.txtTotalFood.Location = new System.Drawing.Point(5, 149);
            this.txtTotalFood.Name = "txtTotalFood";
            this.txtTotalFood.ReadOnly = true;
            this.txtTotalFood.Size = new System.Drawing.Size(661, 24);
            this.txtTotalFood.TabIndex = 3;
            // 
            // dgvFoodInfo
            // 
            this.dgvFoodInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFoodName,
            this.dgvPrice,
            this.dgvImage,
            this.dgvFoodStatus});
            this.dgvFoodInfo.Enabled = false;
            this.dgvFoodInfo.Location = new System.Drawing.Point(5, 179);
            this.dgvFoodInfo.Name = "dgvFoodInfo";
            this.dgvFoodInfo.ReadOnly = true;
            this.dgvFoodInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodInfo.Size = new System.Drawing.Size(661, 428);
            this.dgvFoodInfo.TabIndex = 4;
            this.dgvFoodInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodInfo_CellContentClick);
            // 
            // dgvFoodName
            // 
            this.dgvFoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvFoodName.HeaderText = "Tên món ăn";
            this.dgvFoodName.Name = "dgvFoodName";
            this.dgvFoodName.ReadOnly = true;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvPrice.HeaderText = "Giá món ăn";
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            // 
            // dgvImage
            // 
            this.dgvImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvImage.HeaderText = "Đường dẫn ảnh";
            this.dgvImage.Name = "dgvImage";
            this.dgvImage.ReadOnly = true;
            // 
            // dgvFoodStatus
            // 
            this.dgvFoodStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvFoodStatus.HeaderText = "Trạng thái";
            this.dgvFoodStatus.Name = "dgvFoodStatus";
            this.dgvFoodStatus.ReadOnly = true;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold);
            this.btnSearchFood.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchFood.Image")));
            this.btnSearchFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFood.Location = new System.Drawing.Point(12, 115);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(119, 28);
            this.btnSearchFood.TabIndex = 5;
            this.btnSearchFood.Text = "Tìm món ăn";
            this.btnSearchFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchFood.UseVisualStyleBackColor = true;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // frmManagerFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 619);
            this.Controls.Add(this.btnSearchFood);
            this.Controls.Add(this.dgvFoodInfo);
            this.Controls.Add(this.txtTotalFood);
            this.Controls.Add(this.txtSearchFood);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagerFood";
            this.Text = "frmManagerFood";
            this.Load += new System.EventHandler(this.frmManagerFood_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrFoodImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ptrFoodImage;
        private System.Windows.Forms.RadioButton rdbFoodStatus;
        private System.Windows.Forms.ComboBox cmbNameFC;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtNameFood;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label lblFoodImage;
        private System.Windows.Forms.Label lblFoodStatus;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNameFc;
        private System.Windows.Forms.Label lblNameFood;
        private System.Windows.Forms.Label lblFoodID;
        private System.Windows.Forms.TextBox txtSearchFood;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTotalFood;
        private System.Windows.Forms.DataGridView dgvFoodInfo;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFoodStatus;
    }
}