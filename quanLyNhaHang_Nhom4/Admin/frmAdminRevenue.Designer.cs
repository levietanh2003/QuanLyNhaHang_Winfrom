namespace quanLyNhaHang_Nhom4.Admin
{
    partial class frmAdminRevenue
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
            this.pnTotalRevenue = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgv_maHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_giamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ngayVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_ngayRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_nvThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTopFoodChart = new System.Windows.Forms.Label();
            this.lblFoodRevenue = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgv_tenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_doanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnTotalRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTotalRevenue
            // 
            this.pnTotalRevenue.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTotalRevenue.Controls.Add(this.lblTotalRevenue);
            this.pnTotalRevenue.Location = new System.Drawing.Point(0, 1);
            this.pnTotalRevenue.Name = "pnTotalRevenue";
            this.pnTotalRevenue.Size = new System.Drawing.Size(1058, 100);
            this.pnTotalRevenue.TabIndex = 0;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(27, 17);
            this.lblTotalRevenue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(111, 23);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "Doanh thu:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_maHoaDon,
            this.dgv_tongTien,
            this.dgv_giamGia,
            this.dgv_ngayVao,
            this.dgv_ngayRa,
            this.dgv_nvThanhToan});
            this.dataGridView1.Location = new System.Drawing.Point(0, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 340);
            this.dataGridView1.TabIndex = 1;
            // 
            // dgv_maHoaDon
            // 
            this.dgv_maHoaDon.HeaderText = "Mã Hóa Đơn";
            this.dgv_maHoaDon.MinimumWidth = 6;
            this.dgv_maHoaDon.Name = "dgv_maHoaDon";
            this.dgv_maHoaDon.Width = 150;
            // 
            // dgv_tongTien
            // 
            this.dgv_tongTien.HeaderText = "Tổng Tiền";
            this.dgv_tongTien.MinimumWidth = 6;
            this.dgv_tongTien.Name = "dgv_tongTien";
            this.dgv_tongTien.Width = 175;
            // 
            // dgv_giamGia
            // 
            this.dgv_giamGia.HeaderText = "Giảm Giá";
            this.dgv_giamGia.MinimumWidth = 6;
            this.dgv_giamGia.Name = "dgv_giamGia";
            this.dgv_giamGia.Width = 150;
            // 
            // dgv_ngayVao
            // 
            this.dgv_ngayVao.HeaderText = "Ngày Vào";
            this.dgv_ngayVao.MinimumWidth = 6;
            this.dgv_ngayVao.Name = "dgv_ngayVao";
            this.dgv_ngayVao.Width = 175;
            // 
            // dgv_ngayRa
            // 
            this.dgv_ngayRa.HeaderText = "Ngày Ra";
            this.dgv_ngayRa.MinimumWidth = 6;
            this.dgv_ngayRa.Name = "dgv_ngayRa";
            this.dgv_ngayRa.Width = 175;
            // 
            // dgv_nvThanhToan
            // 
            this.dgv_nvThanhToan.HeaderText = "NV Thanh Toán";
            this.dgv_nvThanhToan.MinimumWidth = 6;
            this.dgv_nvThanhToan.Name = "dgv_nvThanhToan";
            this.dgv_nvThanhToan.Width = 175;
            // 
            // lblTopFoodChart
            // 
            this.lblTopFoodChart.AutoSize = true;
            this.lblTopFoodChart.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTopFoodChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.lblTopFoodChart.Location = new System.Drawing.Point(17, 450);
            this.lblTopFoodChart.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTopFoodChart.Name = "lblTopFoodChart";
            this.lblTopFoodChart.Size = new System.Drawing.Size(498, 40);
            this.lblTopFoodChart.TabIndex = 24;
            this.lblTopFoodChart.Text = "Biểu đồ món ăn bán nhiều nhất";
            // 
            // lblFoodRevenue
            // 
            this.lblFoodRevenue.AutoSize = true;
            this.lblFoodRevenue.Font = new System.Drawing.Font("Cambria", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFoodRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.lblFoodRevenue.Location = new System.Drawing.Point(614, 450);
            this.lblFoodRevenue.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFoodRevenue.Name = "lblFoodRevenue";
            this.lblFoodRevenue.Size = new System.Drawing.Size(301, 40);
            this.lblFoodRevenue.TabIndex = 25;
            this.lblFoodRevenue.Text = "Doanh thu món ăn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_tenMon,
            this.dgv_soLuong,
            this.dgv_gia,
            this.dgv_doanhThu});
            this.dataGridView2.Location = new System.Drawing.Point(508, 513);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(556, 363);
            this.dataGridView2.TabIndex = 26;
            // 
            // dgv_tenMon
            // 
            this.dgv_tenMon.HeaderText = "Tên Món";
            this.dgv_tenMon.MinimumWidth = 6;
            this.dgv_tenMon.Name = "dgv_tenMon";
            this.dgv_tenMon.Width = 125;
            // 
            // dgv_soLuong
            // 
            this.dgv_soLuong.HeaderText = "Số Lượng";
            this.dgv_soLuong.MinimumWidth = 6;
            this.dgv_soLuong.Name = "dgv_soLuong";
            this.dgv_soLuong.Width = 125;
            // 
            // dgv_gia
            // 
            this.dgv_gia.HeaderText = "Giá";
            this.dgv_gia.MinimumWidth = 6;
            this.dgv_gia.Name = "dgv_gia";
            this.dgv_gia.Width = 125;
            // 
            // dgv_doanhThu
            // 
            this.dgv_doanhThu.HeaderText = "Doanh Thu";
            this.dgv_doanhThu.MinimumWidth = 6;
            this.dgv_doanhThu.Name = "dgv_doanhThu";
            this.dgv_doanhThu.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1276, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 27;
            // 
            // frmAdmỉnevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 878);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblFoodRevenue);
            this.Controls.Add(this.lblTopFoodChart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnTotalRevenue);
            this.Name = "frmAdmỉnevenue";
            this.Text = "frmAdmỉnevenue";
            this.pnTotalRevenue.ResumeLayout(false);
            this.pnTotalRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTotalRevenue;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_maHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_giamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ngayVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_ngayRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_nvThanhToan;
        private System.Windows.Forms.Label lblTopFoodChart;
        private System.Windows.Forms.Label lblFoodRevenue;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_tenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_doanhThu;
        private System.Windows.Forms.Panel panel1;
    }
}