namespace quanLyNhaHang_Nhom4.Manager
{
    partial class frmWareHouse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTotalBill = new System.Windows.Forms.Panel();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBillDetail = new System.Windows.Forms.Label();
            this.dgvBillOfWareHouseList = new System.Windows.Forms.DataGridView();
            this.idBillOfWareHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsvBillInfoOfWH = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pn1 = new System.Windows.Forms.Panel();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblBillOfWHID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTotalBill.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillOfWareHouseList)).BeginInit();
            this.pn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTotalBill
            // 
            this.pnTotalBill.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTotalBill.Controls.Add(this.label1);
            this.pnTotalBill.Controls.Add(this.lblTotalBill);
            this.pnTotalBill.Location = new System.Drawing.Point(0, 11);
            this.pnTotalBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnTotalBill.Name = "pnTotalBill";
            this.pnTotalBill.Size = new System.Drawing.Size(865, 70);
            this.pnTotalBill.TabIndex = 0;
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalBill.Location = new System.Drawing.Point(2, 24);
            this.lblTotalBill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(273, 37);
            this.lblTotalBill.TabIndex = 0;
            this.lblTotalBill.Text = "Tổng số hóa đơn: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lblBillDetail);
            this.panel2.Location = new System.Drawing.Point(872, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 70);
            this.panel2.TabIndex = 7;
            // 
            // lblBillDetail
            // 
            this.lblBillDetail.AutoSize = true;
            this.lblBillDetail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lblBillDetail.Location = new System.Drawing.Point(11, 24);
            this.lblBillDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBillDetail.Name = "lblBillDetail";
            this.lblBillDetail.Size = new System.Drawing.Size(250, 37);
            this.lblBillDetail.TabIndex = 7;
            this.lblBillDetail.Text = "Chi tiết hóa đơn";
            // 
            // dgvBillOfWareHouseList
            // 
            this.dgvBillOfWareHouseList.AllowUserToAddRows = false;
            this.dgvBillOfWareHouseList.AllowUserToDeleteRows = false;
            this.dgvBillOfWareHouseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillOfWareHouseList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBillOfWareHouseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillOfWareHouseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBillOfWareHouse,
            this.dateAdded,
            this.supplier,
            this.note});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillOfWareHouseList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBillOfWareHouseList.Location = new System.Drawing.Point(0, 102);
            this.dgvBillOfWareHouseList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBillOfWareHouseList.Name = "dgvBillOfWareHouseList";
            this.dgvBillOfWareHouseList.ReadOnly = true;
            this.dgvBillOfWareHouseList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBillOfWareHouseList.RowHeadersWidth = 82;
            this.dgvBillOfWareHouseList.RowTemplate.Height = 28;
            this.dgvBillOfWareHouseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillOfWareHouseList.Size = new System.Drawing.Size(865, 489);
            this.dgvBillOfWareHouseList.TabIndex = 7;
            // 
            // idBillOfWareHouse
            // 
            this.idBillOfWareHouse.FillWeight = 113.6364F;
            this.idBillOfWareHouse.HeaderText = "Mã Hóa Đơn";
            this.idBillOfWareHouse.MinimumWidth = 10;
            this.idBillOfWareHouse.Name = "idBillOfWareHouse";
            this.idBillOfWareHouse.ReadOnly = true;
            this.idBillOfWareHouse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dateAdded
            // 
            this.dateAdded.FillWeight = 95.45455F;
            this.dateAdded.HeaderText = "Ngày Nhập Hàng";
            this.dateAdded.MinimumWidth = 10;
            this.dateAdded.Name = "dateAdded";
            this.dateAdded.ReadOnly = true;
            // 
            // supplier
            // 
            this.supplier.FillWeight = 95.45455F;
            this.supplier.HeaderText = "Nhà cung cấp";
            this.supplier.MinimumWidth = 10;
            this.supplier.Name = "supplier";
            this.supplier.ReadOnly = true;
            // 
            // note
            // 
            this.note.FillWeight = 95.45455F;
            this.note.HeaderText = "Ghi Chú";
            this.note.MinimumWidth = 10;
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // lsvBillInfoOfWH
            // 
            this.lsvBillInfoOfWH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBillInfoOfWH.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBillInfoOfWH.GridLines = true;
            this.lsvBillInfoOfWH.HideSelection = false;
            this.lsvBillInfoOfWH.LabelEdit = true;
            this.lsvBillInfoOfWH.Location = new System.Drawing.Point(872, 102);
            this.lsvBillInfoOfWH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsvBillInfoOfWH.Name = "lsvBillInfoOfWH";
            this.lsvBillInfoOfWH.Size = new System.Drawing.Size(657, 857);
            this.lsvBillInfoOfWH.TabIndex = 6;
            this.lsvBillInfoOfWH.UseCompatibleStateImageBehavior = false;
            this.lsvBillInfoOfWH.View = System.Windows.Forms.View.Details;
            this.lsvBillInfoOfWH.SelectedIndexChanged += new System.EventHandler(this.lsvBillInfoOfWH_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Nguyên Liệu";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 291;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 270;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 589;
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.DimGray;
            this.pn1.Controls.Add(this.rtbNote);
            this.pn1.Controls.Add(this.textBox3);
            this.pn1.Controls.Add(this.textBox2);
            this.pn1.Controls.Add(this.textBox1);
            this.pn1.Controls.Add(this.txtTotalPrice);
            this.pn1.Controls.Add(this.lblSupplier);
            this.pn1.Controls.Add(this.lblTotalPrice);
            this.pn1.Controls.Add(this.lblDate);
            this.pn1.Controls.Add(this.lblNote);
            this.pn1.Controls.Add(this.lblBillOfWHID);
            this.pn1.Location = new System.Drawing.Point(0, 615);
            this.pn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(865, 344);
            this.pn1.TabIndex = 3;
            // 
            // rtbNote
            // 
            this.rtbNote.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNote.Location = new System.Drawing.Point(546, 122);
            this.rtbNote.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(296, 167);
            this.rtbNote.TabIndex = 2;
            this.rtbNote.Text = "";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(259, 27);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(237, 45);
            this.txtTotalPrice.TabIndex = 1;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(-1, 164);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(240, 41);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "Nhà cung cấp:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(-1, 248);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(179, 41);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "Tổng tiền:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(8, 91);
            this.lblDate.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(200, 41);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Ngày Nhập:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(539, 66);
            this.lblNote.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(149, 41);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "Ghi chú:";
            // 
            // lblBillOfWHID
            // 
            this.lblBillOfWHID.AutoSize = true;
            this.lblBillOfWHID.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillOfWHID.ForeColor = System.Drawing.Color.White;
            this.lblBillOfWHID.Location = new System.Drawing.Point(-1, 27);
            this.lblBillOfWHID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBillOfWHID.Name = "lblBillOfWHID";
            this.lblBillOfWHID.Size = new System.Drawing.Size(219, 41);
            this.lblBillOfWHID.TabIndex = 0;
            this.lblBillOfWHID.Text = "Mã hóa đơn:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(259, 103);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 45);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(259, 176);
            this.textBox2.Margin = new System.Windows.Forms.Padding(1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 45);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(259, 248);
            this.textBox3.Margin = new System.Windows.Forms.Padding(1);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 45);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // frmWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1528, 957);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.lsvBillInfoOfWH);
            this.Controls.Add(this.dgvBillOfWareHouseList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnTotalBill);
            this.Font = new System.Drawing.Font("Cambria", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmWareHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thông tin đơn hàng";
            this.pnTotalBill.ResumeLayout(false);
            this.pnTotalBill.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillOfWareHouseList)).EndInit();
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTotalBill;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBillDetail;
        private System.Windows.Forms.DataGridView dgvBillOfWareHouseList;
        private System.Windows.Forms.ListView lsvBillInfoOfWH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblBillOfWHID;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBillOfWareHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}