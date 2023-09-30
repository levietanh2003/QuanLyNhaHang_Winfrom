namespace quanLyNhaHang_Nhom4.Manager
{
    partial class frmAdminTable
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
            this.toolstripTim = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSobanan = new System.Windows.Forms.ToolStripTextBox();
            this.dgvBanAn = new System.Windows.Forms.DataGridView();
            this.colMaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.lblMaban = new System.Windows.Forms.Label();
            this.lblTenban = new System.Windows.Forms.Label();
            this.lblTrangthai = new System.Windows.Forms.Label();
            this.txtMaban = new System.Windows.Forms.TextBox();
            this.txtTenban = new System.Windows.Forms.TextBox();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTongdanhmuc = new System.Windows.Forms.Label();
            this.lblTongDM = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolstripTim,
            this.toolStripSobanan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(864, 43);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Tatice_Cristal_Intense_Loupe_256;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 37);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolstripTim
            // 
            this.toolstripTim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolstripTim.Name = "toolstripTim";
            this.toolstripTim.Size = new System.Drawing.Size(229, 37);
            this.toolstripTim.Text = "Tìm kiếm bàn ăn";
            this.toolstripTim.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSobanan
            // 
            this.toolStripSobanan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripSobanan.Name = "toolStripSobanan";
            this.toolStripSobanan.Size = new System.Drawing.Size(500, 43);
            // 
            // dgvBanAn
            // 
            this.dgvBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBan,
            this.colTenBan,
            this.colTrangThai});
            this.dgvBanAn.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBanAn.Location = new System.Drawing.Point(0, 122);
            this.dgvBanAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBanAn.Name = "dgvBanAn";
            this.dgvBanAn.RowHeadersWidth = 51;
            this.dgvBanAn.RowTemplate.Height = 24;
            this.dgvBanAn.Size = new System.Drawing.Size(984, 545);
            this.dgvBanAn.TabIndex = 4;
            this.dgvBanAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // colMaBan
            // 
            this.colMaBan.HeaderText = "Mã bàn ăn";
            this.colMaBan.MinimumWidth = 6;
            this.colMaBan.Name = "colMaBan";
            this.colMaBan.Width = 200;
            // 
            // colTenBan
            // 
            this.colTenBan.HeaderText = "Tên bàn ăn";
            this.colTenBan.MinimumWidth = 6;
            this.colTenBan.Name = "colTenBan";
            this.colTenBan.Width = 300;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Width = 300;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(0, 746);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 145);
            this.panel3.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.bx_show_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(756, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hiển thị";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Close_2_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(554, 37);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 72);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Pencil_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(344, 37);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 72);
            this.button3.TabIndex = 1;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Actions_list_add_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(133, 37);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 72);
            this.button4.TabIndex = 0;
            this.button4.Text = "Thêm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Font = new System.Drawing.Font("Cambria", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtin.ForeColor = System.Drawing.Color.White;
            this.lblThongtin.Location = new System.Drawing.Point(83, 215);
            this.lblThongtin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(331, 47);
            this.lblThongtin.TabIndex = 0;
            this.lblThongtin.Text = "Thông tin bàn ăn";
            this.lblThongtin.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblMaban
            // 
            this.lblMaban.AutoSize = true;
            this.lblMaban.BackColor = System.Drawing.Color.DimGray;
            this.lblMaban.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaban.ForeColor = System.Drawing.Color.White;
            this.lblMaban.Location = new System.Drawing.Point(29, 317);
            this.lblMaban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaban.Name = "lblMaban";
            this.lblMaban.Size = new System.Drawing.Size(103, 32);
            this.lblMaban.TabIndex = 1;
            this.lblMaban.Text = "Mã bàn";
            // 
            // lblTenban
            // 
            this.lblTenban.AutoSize = true;
            this.lblTenban.BackColor = System.Drawing.Color.DimGray;
            this.lblTenban.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenban.ForeColor = System.Drawing.Color.White;
            this.lblTenban.Location = new System.Drawing.Point(29, 443);
            this.lblTenban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenban.Name = "lblTenban";
            this.lblTenban.Size = new System.Drawing.Size(112, 32);
            this.lblTenban.TabIndex = 2;
            this.lblTenban.Text = "Tên bàn";
            // 
            // lblTrangthai
            // 
            this.lblTrangthai.AutoSize = true;
            this.lblTrangthai.BackColor = System.Drawing.Color.DimGray;
            this.lblTrangthai.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangthai.ForeColor = System.Drawing.Color.White;
            this.lblTrangthai.Location = new System.Drawing.Point(29, 584);
            this.lblTrangthai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrangthai.Name = "lblTrangthai";
            this.lblTrangthai.Size = new System.Drawing.Size(140, 32);
            this.lblTrangthai.TabIndex = 3;
            this.lblTrangthai.Text = "Trạng thái";
            // 
            // txtMaban
            // 
            this.txtMaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaban.Location = new System.Drawing.Point(203, 314);
            this.txtMaban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaban.Name = "txtMaban";
            this.txtMaban.Size = new System.Drawing.Size(193, 32);
            this.txtMaban.TabIndex = 4;
            // 
            // txtTenban
            // 
            this.txtTenban.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenban.Location = new System.Drawing.Point(203, 447);
            this.txtTenban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenban.Name = "txtTenban";
            this.txtTenban.Size = new System.Drawing.Size(193, 32);
            this.txtTenban.TabIndex = 5;
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangthai.Location = new System.Drawing.Point(203, 584);
            this.txtTrangthai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(193, 32);
            this.txtTrangthai.TabIndex = 6;
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1041, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 957);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblTongdanhmuc);
            this.panel2.Controls.Add(this.lblTongDM);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 53);
            this.panel2.TabIndex = 13;
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
            // frmAdminTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 957);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBanAn);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdminTable";
            this.Text = "frmTable";
            this.Load += new System.EventHandler(this.frmTable_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolstripTim;
        private System.Windows.Forms.ToolStripTextBox toolStripSobanan;
        private System.Windows.Forms.DataGridView dgvBanAn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.Label lblMaban;
        private System.Windows.Forms.Label lblTenban;
        private System.Windows.Forms.Label lblTrangthai;
        private System.Windows.Forms.TextBox txtMaban;
        private System.Windows.Forms.TextBox txtTenban;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTongdanhmuc;
        private System.Windows.Forms.Label lblTongDM;
    }
}