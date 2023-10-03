
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
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.dgvFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFoodStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrFoodImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(888, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 957);
            this.panel2.TabIndex = 1;
            // 
            // ptrFoodImage
            // 
            this.ptrFoodImage.Location = new System.Drawing.Point(120, 470);
            this.ptrFoodImage.Margin = new System.Windows.Forms.Padding(6);
            this.ptrFoodImage.Name = "ptrFoodImage";
            this.ptrFoodImage.Size = new System.Drawing.Size(380, 329);
            this.ptrFoodImage.TabIndex = 6;
            this.ptrFoodImage.TabStop = false;
            // 
            // rdbFoodStatus
            // 
            this.rdbFoodStatus.AutoSize = true;
            this.rdbFoodStatus.ForeColor = System.Drawing.Color.White;
            this.rdbFoodStatus.Location = new System.Drawing.Point(316, 369);
            this.rdbFoodStatus.Margin = new System.Windows.Forms.Padding(6);
            this.rdbFoodStatus.Name = "rdbFoodStatus";
            this.rdbFoodStatus.Size = new System.Drawing.Size(173, 38);
            this.rdbFoodStatus.TabIndex = 5;
            this.rdbFoodStatus.TabStop = true;
            this.rdbFoodStatus.Text = "Đang bán";
            this.rdbFoodStatus.UseVisualStyleBackColor = true;
            // 
            // cmbNameFC
            // 
            this.cmbNameFC.Enabled = false;
            this.cmbNameFC.FormattingEnabled = true;
            this.cmbNameFC.Location = new System.Drawing.Point(238, 217);
            this.cmbNameFC.Margin = new System.Windows.Forms.Padding(6);
            this.cmbNameFC.Name = "cmbNameFC";
            this.cmbNameFC.Size = new System.Drawing.Size(319, 42);
            this.cmbNameFC.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(238, 293);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(319, 41);
            this.txtPrice.TabIndex = 3;
            // 
            // txtNameFood
            // 
            this.txtNameFood.Location = new System.Drawing.Point(238, 141);
            this.txtNameFood.Margin = new System.Windows.Forms.Padding(6);
            this.txtNameFood.Name = "txtNameFood";
            this.txtNameFood.ReadOnly = true;
            this.txtNameFood.Size = new System.Drawing.Size(319, 41);
            this.txtNameFood.TabIndex = 3;
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(238, 65);
            this.txtFoodID.Margin = new System.Windows.Forms.Padding(6);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.ReadOnly = true;
            this.txtFoodID.Size = new System.Drawing.Size(319, 41);
            this.txtFoodID.TabIndex = 3;
            // 
            // lblFoodImage
            // 
            this.lblFoodImage.ForeColor = System.Drawing.Color.White;
            this.lblFoodImage.Location = new System.Drawing.Point(120, 831);
            this.lblFoodImage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFoodImage.Name = "lblFoodImage";
            this.lblFoodImage.Size = new System.Drawing.Size(380, 34);
            this.lblFoodImage.TabIndex = 2;
            this.lblFoodImage.Text = "......";
            this.lblFoodImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFoodImage.Click += new System.EventHandler(this.lblImage_Click);
            // 
            // lblFoodStatus
            // 
            this.lblFoodStatus.AutoSize = true;
            this.lblFoodStatus.ForeColor = System.Drawing.Color.White;
            this.lblFoodStatus.Location = new System.Drawing.Point(64, 374);
            this.lblFoodStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFoodStatus.Name = "lblFoodStatus";
            this.lblFoodStatus.Size = new System.Drawing.Size(154, 34);
            this.lblFoodStatus.TabIndex = 2;
            this.lblFoodStatus.Text = "Trạng thái";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(64, 299);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 34);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Giá";
            // 
            // lblNameFc
            // 
            this.lblNameFc.AutoSize = true;
            this.lblNameFc.ForeColor = System.Drawing.Color.White;
            this.lblNameFc.Location = new System.Drawing.Point(64, 223);
            this.lblNameFc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNameFc.Name = "lblNameFc";
            this.lblNameFc.Size = new System.Drawing.Size(149, 34);
            this.lblNameFc.TabIndex = 2;
            this.lblNameFc.Text = "Danh mục";
            // 
            // lblNameFood
            // 
            this.lblNameFood.AutoSize = true;
            this.lblNameFood.ForeColor = System.Drawing.Color.White;
            this.lblNameFood.Location = new System.Drawing.Point(64, 147);
            this.lblNameFood.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNameFood.Name = "lblNameFood";
            this.lblNameFood.Size = new System.Drawing.Size(172, 34);
            this.lblNameFood.TabIndex = 2;
            this.lblNameFood.Text = "Tên món ăn";
            // 
            // lblFoodID
            // 
            this.lblFoodID.AutoSize = true;
            this.lblFoodID.ForeColor = System.Drawing.Color.White;
            this.lblFoodID.Location = new System.Drawing.Point(64, 71);
            this.lblFoodID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFoodID.Name = "lblFoodID";
            this.lblFoodID.Size = new System.Drawing.Size(123, 34);
            this.lblFoodID.TabIndex = 2;
            this.lblFoodID.Text = "Mã món";
            // 
            // txtSearchFood
            // 
            this.txtSearchFood.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold);
            this.txtSearchFood.Location = new System.Drawing.Point(243, 30);
            this.txtSearchFood.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearchFood.Name = "txtSearchFood";
            this.txtSearchFood.Size = new System.Drawing.Size(609, 41);
            this.txtSearchFood.TabIndex = 3;
            this.txtSearchFood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchFood_KeyPress);
            // 
            // txtTotalFood
            // 
            this.txtTotalFood.Enabled = false;
            this.txtTotalFood.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold);
            this.txtTotalFood.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotalFood.Location = new System.Drawing.Point(1, 86);
            this.txtTotalFood.Margin = new System.Windows.Forms.Padding(6);
            this.txtTotalFood.Name = "txtTotalFood";
            this.txtTotalFood.ReadOnly = true;
            this.txtTotalFood.Size = new System.Drawing.Size(851, 41);
            this.txtTotalFood.TabIndex = 3;
            this.txtTotalFood.TextChanged += new System.EventHandler(this.txtTotalFood_TextChanged);
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.AllowUserToAddRows = false;
            this.dgvFoodList.AllowUserToDeleteRows = false;
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFoodName,
            this.dgvPrice,
            this.dgvImage,
            this.dgvFoodStatus});
            this.dgvFoodList.Enabled = false;
            this.dgvFoodList.Location = new System.Drawing.Point(1, 140);
            this.dgvFoodList.Margin = new System.Windows.Forms.Padding(6);
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.ReadOnly = true;
            this.dgvFoodList.RowHeadersWidth = 82;
            this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodList.Size = new System.Drawing.Size(851, 790);
            this.dgvFoodList.TabIndex = 4;
            // 
            // dgvFoodName
            // 
            this.dgvFoodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvFoodName.HeaderText = "Tên món ăn";
            this.dgvFoodName.MinimumWidth = 10;
            this.dgvFoodName.Name = "dgvFoodName";
            this.dgvFoodName.ReadOnly = true;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvPrice.HeaderText = "Giá món ăn";
            this.dgvPrice.MinimumWidth = 10;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            // 
            // dgvImage
            // 
            this.dgvImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvImage.HeaderText = "Đường dẫn ảnh";
            this.dgvImage.MinimumWidth = 10;
            this.dgvImage.Name = "dgvImage";
            this.dgvImage.ReadOnly = true;
            // 
            // dgvFoodStatus
            // 
            this.dgvFoodStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvFoodStatus.HeaderText = "Trạng thái";
            this.dgvFoodStatus.MinimumWidth = 10;
            this.dgvFoodStatus.Name = "dgvFoodStatus";
            this.dgvFoodStatus.ReadOnly = true;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold);
            this.btnSearchFood.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchFood.Image")));
            this.btnSearchFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFood.Location = new System.Drawing.Point(14, 22);
            this.btnSearchFood.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(218, 52);
            this.btnSearchFood.TabIndex = 5;
            this.btnSearchFood.Text = "Tìm món ăn";
            this.btnSearchFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchFood.UseVisualStyleBackColor = true;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // frmManagerFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 957);
            this.Controls.Add(this.btnSearchFood);
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.txtSearchFood);
            this.Controls.Add(this.txtTotalFood);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmManagerFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManagerFood";
            this.Load += new System.EventHandler(this.frmManagerFood_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrFoodImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox txtTotalFood;
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFoodStatus;
    }
}