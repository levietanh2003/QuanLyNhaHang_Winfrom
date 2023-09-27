namespace quanLyNhaHang_Nhom4.Manager
{
    partial class frmTable
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
            this.txtTongban = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolstripTim = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSobanan = new System.Windows.Forms.ToolStripTextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.txtTenban = new System.Windows.Forms.TextBox();
            this.txtMaban = new System.Windows.Forms.TextBox();
            this.lblTrangthai = new System.Windows.Forms.Label();
            this.lblTenban = new System.Windows.Forms.Label();
            this.lblMaban = new System.Windows.Forms.Label();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lblTongban = new System.Windows.Forms.Label();
            this.colMaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTongban
            // 
            this.txtTongban.BackColor = System.Drawing.Color.Silver;
            this.txtTongban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongban.Location = new System.Drawing.Point(0, 44);
            this.txtTongban.Name = "txtTongban";
            this.txtTongban.Size = new System.Drawing.Size(1023, 26);
            this.txtTongban.TabIndex = 1;
            this.txtTongban.Text = "Tổng số bàn ăn:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolstripTim,
            this.toolStripSobanan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1035, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolstripTim
            // 
            this.toolstripTim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolstripTim.Name = "toolstripTim";
            this.toolstripTim.Size = new System.Drawing.Size(145, 24);
            this.toolstripTim.Text = "Tìm kiếm bàn ăn";
            this.toolstripTim.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSobanan
            // 
            this.toolStripSobanan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripSobanan.Name = "toolStripSobanan";
            this.toolStripSobanan.Size = new System.Drawing.Size(525, 27);
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBan,
            this.colTenBan,
            this.colTrangThai});
            this.dgvList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvList.Location = new System.Drawing.Point(0, 81);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.Size = new System.Drawing.Size(1023, 383);
            this.dgvList.TabIndex = 4;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(713, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(8, 22);
            this.textBox1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.txtTrangthai);
            this.panel1.Controls.Add(this.txtTenban);
            this.panel1.Controls.Add(this.txtMaban);
            this.panel1.Controls.Add(this.lblTrangthai);
            this.panel1.Controls.Add(this.lblTenban);
            this.panel1.Controls.Add(this.lblMaban);
            this.panel1.Controls.Add(this.lblThongtin);
            this.panel1.Location = new System.Drawing.Point(1016, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 812);
            this.panel1.TabIndex = 6;
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(141, 310);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(110, 22);
            this.txtTrangthai.TabIndex = 6;
            // 
            // txtTenban
            // 
            this.txtTenban.Location = new System.Drawing.Point(141, 219);
            this.txtTenban.Name = "txtTenban";
            this.txtTenban.Size = new System.Drawing.Size(110, 22);
            this.txtTenban.TabIndex = 5;
            // 
            // txtMaban
            // 
            this.txtMaban.Location = new System.Drawing.Point(141, 130);
            this.txtMaban.Name = "txtMaban";
            this.txtMaban.Size = new System.Drawing.Size(110, 22);
            this.txtMaban.TabIndex = 4;
            // 
            // lblTrangthai
            // 
            this.lblTrangthai.AutoSize = true;
            this.lblTrangthai.BackColor = System.Drawing.Color.DimGray;
            this.lblTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangthai.ForeColor = System.Drawing.Color.White;
            this.lblTrangthai.Location = new System.Drawing.Point(15, 310);
            this.lblTrangthai.Name = "lblTrangthai";
            this.lblTrangthai.Size = new System.Drawing.Size(94, 20);
            this.lblTrangthai.TabIndex = 3;
            this.lblTrangthai.Text = "Trạng thái";
            // 
            // lblTenban
            // 
            this.lblTenban.AutoSize = true;
            this.lblTenban.BackColor = System.Drawing.Color.DimGray;
            this.lblTenban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenban.ForeColor = System.Drawing.Color.White;
            this.lblTenban.Location = new System.Drawing.Point(15, 216);
            this.lblTenban.Name = "lblTenban";
            this.lblTenban.Size = new System.Drawing.Size(76, 20);
            this.lblTenban.TabIndex = 2;
            this.lblTenban.Text = "Tên bàn";
            // 
            // lblMaban
            // 
            this.lblMaban.AutoSize = true;
            this.lblMaban.BackColor = System.Drawing.Color.DimGray;
            this.lblMaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaban.ForeColor = System.Drawing.Color.White;
            this.lblMaban.Location = new System.Drawing.Point(15, 132);
            this.lblMaban.Name = "lblMaban";
            this.lblMaban.Size = new System.Drawing.Size(70, 20);
            this.lblMaban.TabIndex = 1;
            this.lblMaban.Text = "Mã bàn";
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtin.ForeColor = System.Drawing.Color.White;
            this.lblThongtin.Location = new System.Drawing.Point(3, 40);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(208, 29);
            this.lblThongtin.TabIndex = 0;
            this.lblThongtin.Text = "Thông tin bàn ăn";
            this.lblThongtin.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnHienthi
            // 
            this.btnHienthi.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.bx_show_icon;
            this.btnHienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHienthi.Location = new System.Drawing.Point(857, 567);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(125, 51);
            this.btnHienthi.TabIndex = 10;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHienthi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Close_2_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(702, 567);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 51);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSua.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Pencil_icon;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(546, 567);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(105, 51);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Actions_list_add_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(365, 567);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 51);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Tatice_Cristal_Intense_Loupe_256;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // lblTongban
            // 
            this.lblTongban.AutoSize = true;
            this.lblTongban.BackColor = System.Drawing.Color.Silver;
            this.lblTongban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongban.Location = new System.Drawing.Point(158, 47);
            this.lblTongban.Name = "lblTongban";
            this.lblTongban.Size = new System.Drawing.Size(29, 20);
            this.lblTongban.TabIndex = 11;
            this.lblTongban.Text = "10";
            // 
            // colMaBan
            // 
            this.colMaBan.HeaderText = "Mã bàn ăn";
            this.colMaBan.MinimumWidth = 6;
            this.colMaBan.Name = "colMaBan";
            this.colMaBan.Width = 330;
            // 
            // colTenBan
            // 
            this.colTenBan.HeaderText = "Tên bàn ăn";
            this.colTenBan.MinimumWidth = 6;
            this.colTenBan.Name = "colTenBan";
            this.colTenBan.Width = 320;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Width = 320;
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 650);
            this.Controls.Add(this.lblTongban);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtTongban);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTable";
            this.Text = "frmTable";
            this.Load += new System.EventHandler(this.frmTable_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTongban;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolstripTim;
        private System.Windows.Forms.ToolStripTextBox toolStripSobanan;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.Label lblMaban;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.TextBox txtTenban;
        private System.Windows.Forms.TextBox txtMaban;
        private System.Windows.Forms.Label lblTrangthai;
        private System.Windows.Forms.Label lblTenban;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Label lblTongban;
    }
}