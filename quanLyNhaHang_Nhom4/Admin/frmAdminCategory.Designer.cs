﻿namespace quanLyNhaHang_Nhom4.Manager
{
    partial class frmAdminCategory
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
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.lblTenDM = new System.Windows.Forms.Label();
            this.lblMaDM = new System.Windows.Forms.Label();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTongdanhmuc = new System.Windows.Forms.Label();
            this.lblTongDM = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.colMaDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSomon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripTracuu,
            this.toolStripTxtTracuu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(679, 40);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Tatice_Cristal_Intense_Loupe_256;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 34);
            this.toolStripButton1.Text = "Tra cứu danh mục";
            // 
            // toolStripTracuu
            // 
            this.toolStripTracuu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripTracuu.Font = new System.Drawing.Font("Cambria", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTracuu.Name = "toolStripTracuu";
            this.toolStripTracuu.Size = new System.Drawing.Size(256, 34);
            this.toolStripTracuu.Text = "Tra cứu danh mục";
            // 
            // toolStripTxtTracuu
            // 
            this.toolStripTxtTracuu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTxtTracuu.Name = "toolStripTxtTracuu";
            this.toolStripTxtTracuu.Size = new System.Drawing.Size(350, 50);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.txtTenDM);
            this.panel1.Controls.Add(this.txtMaDM);
            this.panel1.Controls.Add(this.lblTenDM);
            this.panel1.Controls.Add(this.lblMaDM);
            this.panel1.Controls.Add(this.lblThongtin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1041, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 957);
            this.panel1.TabIndex = 1;
            // 
            // txtTenDM
            // 
            this.txtTenDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDM.Location = new System.Drawing.Point(218, 494);
            this.txtTenDM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(193, 32);
            this.txtTenDM.TabIndex = 4;
            // 
            // txtMaDM
            // 
            this.txtMaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDM.Location = new System.Drawing.Point(218, 343);
            this.txtMaDM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(193, 32);
            this.txtMaDM.TabIndex = 3;
            // 
            // lblTenDM
            // 
            this.lblTenDM.AutoSize = true;
            this.lblTenDM.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDM.ForeColor = System.Drawing.Color.White;
            this.lblTenDM.Location = new System.Drawing.Point(18, 494);
            this.lblTenDM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDM.Name = "lblTenDM";
            this.lblTenDM.Size = new System.Drawing.Size(187, 32);
            this.lblTenDM.TabIndex = 2;
            this.lblTenDM.Text = "Tên danh mục";
            // 
            // lblMaDM
            // 
            this.lblMaDM.AutoSize = true;
            this.lblMaDM.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDM.ForeColor = System.Drawing.Color.White;
            this.lblMaDM.Location = new System.Drawing.Point(18, 343);
            this.lblMaDM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaDM.Name = "lblMaDM";
            this.lblMaDM.Size = new System.Drawing.Size(178, 32);
            this.lblMaDM.TabIndex = 1;
            this.lblMaDM.Text = "Mã danh mục";
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Font = new System.Drawing.Font("Cambria", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtin.ForeColor = System.Drawing.Color.White;
            this.lblThongtin.Location = new System.Drawing.Point(45, 227);
            this.lblThongtin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(389, 47);
            this.lblThongtin.TabIndex = 0;
            this.lblThongtin.Text = "Thông tin danh mục";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblTongdanhmuc);
            this.panel2.Controls.Add(this.lblTongDM);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 53);
            this.panel2.TabIndex = 2;
            // 
            // lblTongdanhmuc
            // 
            this.lblTongdanhmuc.AutoSize = true;
            this.lblTongdanhmuc.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongdanhmuc.Location = new System.Drawing.Point(237, 13);
            this.lblTongdanhmuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongdanhmuc.Name = "lblTongdanhmuc";
            this.lblTongdanhmuc.Size = new System.Drawing.Size(46, 32);
            this.lblTongdanhmuc.TabIndex = 5;
            this.lblTongdanhmuc.Text = "10";
            // 
            // lblTongDM
            // 
            this.lblTongDM.AutoSize = true;
            this.lblTongDM.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDM.Location = new System.Drawing.Point(19, 13);
            this.lblTongDM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongDM.Name = "lblTongDM";
            this.lblTongDM.Size = new System.Drawing.Size(210, 32);
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
            this.panel3.Location = new System.Drawing.Point(0, 746);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 145);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnHienthi
            // 
            this.btnHienthi.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienthi.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.bx_show_icon;
            this.btnHienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienthi.Location = new System.Drawing.Point(756, 37);
            this.btnHienthi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(169, 72);
            this.btnHienthi.TabIndex = 4;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHienthi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHienthi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Close_2_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(554, 37);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(174, 72);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Pencil_icon;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(344, 37);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(174, 72);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Actions_list_add_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(133, 37);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(174, 72);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDM,
            this.colTenDM,
            this.colSomon});
            this.dgvDanhMuc.Location = new System.Drawing.Point(0, 159);
            this.dgvDanhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.RowTemplate.Height = 24;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new System.Drawing.Size(984, 545);
            this.dgvDanhMuc.TabIndex = 4;
            this.dgvDanhMuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colMaDM
            // 
            this.colMaDM.HeaderText = "Mã danh mục";
            this.colMaDM.MinimumWidth = 6;
            this.colMaDM.Name = "colMaDM";
            this.colMaDM.ReadOnly = true;
            this.colMaDM.Width = 150;
            // 
            // colTenDM
            // 
            this.colTenDM.HeaderText = "Tên danh mục";
            this.colTenDM.MinimumWidth = 6;
            this.colTenDM.Name = "colTenDM";
            this.colTenDM.ReadOnly = true;
            this.colTenDM.Width = 300;
            // 
            // colSomon
            // 
            this.colSomon.HeaderText = "Số món ăn";
            this.colSomon.MinimumWidth = 6;
            this.colSomon.Name = "colSomon";
            this.colSomon.ReadOnly = true;
            this.colSomon.Width = 200;
            // 
            // frmAdminCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 957);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdminCategory";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "frmQLDanhMuc";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSomon;
    }
}