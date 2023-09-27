namespace quanLyNhaHang_Nhom4.Manager
{
    partial class frmQLDanhMuc
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripTracuu = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTxtTracuu = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.lblMaDM = new System.Windows.Forms.Label();
            this.lblTenDM = new System.Windows.Forms.Label();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTongDM = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTongdanhmuc = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSomon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripTracuu,
            this.toolStripTxtTracuu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1035, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Tatice_Cristal_Intense_Loupe_256;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripTracuu
            // 
            this.toolStripTracuu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripTracuu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.toolStripTracuu.Name = "toolStripTracuu";
            this.toolStripTracuu.Size = new System.Drawing.Size(172, 25);
            this.toolStripTracuu.Text = "Tra cứu danh mục";
            // 
            // toolStripTxtTracuu
            // 
            this.toolStripTxtTracuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTxtTracuu.Name = "toolStripTxtTracuu";
            this.toolStripTxtTracuu.Size = new System.Drawing.Size(713, 28);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.txtTenDM);
            this.panel1.Controls.Add(this.txtMaDM);
            this.panel1.Controls.Add(this.lblTenDM);
            this.panel1.Controls.Add(this.lblMaDM);
            this.panel1.Controls.Add(this.lblThongtin);
            this.panel1.Location = new System.Drawing.Point(937, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 811);
            this.panel1.TabIndex = 1;
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtin.ForeColor = System.Drawing.Color.White;
            this.lblThongtin.Location = new System.Drawing.Point(21, 81);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(203, 25);
            this.lblThongtin.TabIndex = 0;
            this.lblThongtin.Text = "Thông tin danh mục";
            // 
            // lblMaDM
            // 
            this.lblMaDM.AutoSize = true;
            this.lblMaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDM.ForeColor = System.Drawing.Color.White;
            this.lblMaDM.Location = new System.Drawing.Point(3, 165);
            this.lblMaDM.Name = "lblMaDM";
            this.lblMaDM.Size = new System.Drawing.Size(145, 25);
            this.lblMaDM.TabIndex = 1;
            this.lblMaDM.Text = "Mã danh mục";
            // 
            // lblTenDM
            // 
            this.lblTenDM.AutoSize = true;
            this.lblTenDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDM.ForeColor = System.Drawing.Color.White;
            this.lblTenDM.Location = new System.Drawing.Point(3, 266);
            this.lblTenDM.Name = "lblTenDM";
            this.lblTenDM.Size = new System.Drawing.Size(153, 25);
            this.lblTenDM.TabIndex = 2;
            this.lblTenDM.Text = "Tên danh mục";
            // 
            // txtMaDM
            // 
            this.txtMaDM.Location = new System.Drawing.Point(125, 165);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(141, 22);
            this.txtMaDM.TabIndex = 3;
            // 
            // txtTenDM
            // 
            this.txtTenDM.Location = new System.Drawing.Point(125, 269);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(141, 22);
            this.txtTenDM.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblTongdanhmuc);
            this.panel2.Controls.Add(this.lblTongDM);
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 35);
            this.panel2.TabIndex = 2;
            // 
            // lblTongDM
            // 
            this.lblTongDM.AutoSize = true;
            this.lblTongDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDM.Location = new System.Drawing.Point(14, 9);
            this.lblTongDM.Name = "lblTongDM";
            this.lblTongDM.Size = new System.Drawing.Size(179, 25);
            this.lblTongDM.TabIndex = 3;
            this.lblTongDM.Text = "Tổng danh mục:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.btnHienthi);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Location = new System.Drawing.Point(0, 536);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(931, 102);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblTongdanhmuc
            // 
            this.lblTongdanhmuc.AutoSize = true;
            this.lblTongdanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongdanhmuc.Location = new System.Drawing.Point(157, 9);
            this.lblTongdanhmuc.Name = "lblTongdanhmuc";
            this.lblTongdanhmuc.Size = new System.Drawing.Size(29, 20);
            this.lblTongdanhmuc.TabIndex = 5;
            this.lblTongdanhmuc.Text = "10";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Actions_list_add_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(353, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 61);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Pencil_icon;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(501, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 61);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Close_2_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(641, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 61);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnHienthi
            // 
            this.btnHienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienthi.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.bx_show_icon;
            this.btnHienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienthi.Location = new System.Drawing.Point(788, 19);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(128, 61);
            this.btnHienthi.TabIndex = 4;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienthi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHienthi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDM,
            this.colTenDM,
            this.colSomon});
            this.dataGridView1.Location = new System.Drawing.Point(0, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(931, 405);
            this.dataGridView1.TabIndex = 4;
            // 
            // colMaDM
            // 
            this.colMaDM.HeaderText = "Mã danh mục";
            this.colMaDM.MinimumWidth = 6;
            this.colMaDM.Name = "colMaDM";
            this.colMaDM.Width = 270;
            // 
            // colTenDM
            // 
            this.colTenDM.HeaderText = "Tên danh mục";
            this.colTenDM.MinimumWidth = 6;
            this.colTenDM.Name = "colTenDM";
            this.colTenDM.Width = 327;
            // 
            // colSomon
            // 
            this.colSomon.HeaderText = "Số món ăn";
            this.colSomon.MinimumWidth = 6;
            this.colSomon.Name = "colSomon";
            this.colSomon.Width = 280;
            // 
            // frmQLDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLDanhMuc";
            this.Text = "frmQLDanhMuc";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripTracuu;
        private System.Windows.Forms.ToolStripTextBox toolStripTxtTracuu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTenDM;
        private System.Windows.Forms.Label lblMaDM;
        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTongdanhmuc;
        private System.Windows.Forms.Label lblTongDM;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSomon;
    }
}