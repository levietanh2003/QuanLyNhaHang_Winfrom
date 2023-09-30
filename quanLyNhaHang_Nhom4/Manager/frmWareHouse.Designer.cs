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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnTotalBill = new System.Windows.Forms.Panel();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBillDetail = new System.Windows.Forms.Label();
            this.dgvBillOfWareHouseList = new System.Windows.Forms.DataGridView();
            this.lsvBillInfoOfWH = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pn1 = new System.Windows.Forms.Panel();
            this.lblBillOfWHID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtBillOfWareHouseID = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.idBillOfWareHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTotalBill.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillOfWareHouseList)).BeginInit();
            this.pn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTotalBill
            // 
            this.pnTotalBill.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTotalBill.Controls.Add(this.lblTotalBill);
            this.pnTotalBill.Location = new System.Drawing.Point(13, 13);
            this.pnTotalBill.Margin = new System.Windows.Forms.Padding(4);
            this.pnTotalBill.Name = "pnTotalBill";
            this.pnTotalBill.Size = new System.Drawing.Size(683, 54);
            this.pnTotalBill.TabIndex = 0;
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalBill.Location = new System.Drawing.Point(4, 6);
            this.lblTotalBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(203, 28);
            this.lblTotalBill.TabIndex = 0;
            this.lblTotalBill.Text = "Tổng số hóa đơn: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lblBillDetail);
            this.panel2.Location = new System.Drawing.Point(704, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 54);
            this.panel2.TabIndex = 7;
            // 
            // lblBillDetail
            // 
            this.lblBillDetail.AutoSize = true;
            this.lblBillDetail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lblBillDetail.Location = new System.Drawing.Point(4, 6);
            this.lblBillDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillDetail.Name = "lblBillDetail";
            this.lblBillDetail.Size = new System.Drawing.Size(187, 28);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillOfWareHouseList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBillOfWareHouseList.Location = new System.Drawing.Point(13, 75);
            this.dgvBillOfWareHouseList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBillOfWareHouseList.Name = "dgvBillOfWareHouseList";
            this.dgvBillOfWareHouseList.ReadOnly = true;
            this.dgvBillOfWareHouseList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBillOfWareHouseList.RowHeadersWidth = 82;
            this.dgvBillOfWareHouseList.RowTemplate.Height = 28;
            this.dgvBillOfWareHouseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillOfWareHouseList.Size = new System.Drawing.Size(683, 305);
            this.dgvBillOfWareHouseList.TabIndex = 7;
            // 
            // lsvBillInfoOfWH
            // 
            this.lsvBillInfoOfWH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBillInfoOfWH.GridLines = true;
            this.lsvBillInfoOfWH.HideSelection = false;
            this.lsvBillInfoOfWH.LabelEdit = true;
            this.lsvBillInfoOfWH.Location = new System.Drawing.Point(704, 75);
            this.lsvBillInfoOfWH.Margin = new System.Windows.Forms.Padding(4);
            this.lsvBillInfoOfWH.Name = "lsvBillInfoOfWH";
            this.lsvBillInfoOfWH.Size = new System.Drawing.Size(323, 522);
            this.lsvBillInfoOfWH.TabIndex = 6;
            this.lsvBillInfoOfWH.UseCompatibleStateImageBehavior = false;
            this.lsvBillInfoOfWH.View = System.Windows.Forms.View.Details;
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
            this.pn1.Controls.Add(this.txtBillOfWareHouseID);
            this.pn1.Controls.Add(this.txtDate);
            this.pn1.Controls.Add(this.txtTotalPrice);
            this.pn1.Controls.Add(this.txtSupplier);
            this.pn1.Controls.Add(this.lblSupplier);
            this.pn1.Controls.Add(this.lblTotalPrice);
            this.pn1.Controls.Add(this.lblDate);
            this.pn1.Controls.Add(this.lblNote);
            this.pn1.Controls.Add(this.lblBillOfWHID);
            this.pn1.Location = new System.Drawing.Point(13, 388);
            this.pn1.Margin = new System.Windows.Forms.Padding(4);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(683, 209);
            this.pn1.TabIndex = 3;
            // 
            // lblBillOfWHID
            // 
            this.lblBillOfWHID.AutoSize = true;
            this.lblBillOfWHID.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillOfWHID.ForeColor = System.Drawing.Color.White;
            this.lblBillOfWHID.Location = new System.Drawing.Point(15, 18);
            this.lblBillOfWHID.Name = "lblBillOfWHID";
            this.lblBillOfWHID.Size = new System.Drawing.Size(164, 31);
            this.lblBillOfWHID.TabIndex = 0;
            this.lblBillOfWHID.Text = "Mã hóa đơn:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(15, 67);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(150, 31);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Ngày Nhập:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(15, 163);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(135, 31);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "Tổng tiền:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(15, 112);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(181, 31);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "Nhà cung cấp:";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(199, 112);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(193, 43);
            this.txtSupplier.TabIndex = 1;
            // 
            // txtBillOfWareHouseID
            // 
            this.txtBillOfWareHouseID.Location = new System.Drawing.Point(199, 18);
            this.txtBillOfWareHouseID.Name = "txtBillOfWareHouseID";
            this.txtBillOfWareHouseID.Size = new System.Drawing.Size(193, 43);
            this.txtBillOfWareHouseID.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(199, 67);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(193, 43);
            this.txtDate.TabIndex = 1;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(199, 156);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(193, 43);
            this.txtTotalPrice.TabIndex = 1;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(398, 18);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(112, 31);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "Ghi chú:";
            // 
            // rtbNote
            // 
            this.rtbNote.Location = new System.Drawing.Point(404, 52);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(268, 142);
            this.rtbNote.TabIndex = 2;
            this.rtbNote.Text = "";
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
            // frmWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1031, 610);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.lsvBillInfoOfWH);
            this.Controls.Add(this.dgvBillOfWareHouseList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnTotalBill);
            this.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
        private System.Windows.Forms.TextBox txtBillOfWareHouseID;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBillOfWareHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
    }
}