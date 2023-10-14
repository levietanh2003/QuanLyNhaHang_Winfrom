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
            this.dgvBillOfWareHouse = new System.Windows.Forms.DataGridView();
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
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtDateAdd = new System.Windows.Forms.TextBox();
            this.txtBillOfWareHouseID = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblBillOfWHID = new System.Windows.Forms.Label();
            this.pnTotalBill.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillOfWareHouse)).BeginInit();
            this.pn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTotalBill
            // 
            this.pnTotalBill.BackColor = System.Drawing.Color.Gainsboro;
            this.pnTotalBill.Controls.Add(this.lblTotalBill);
            this.pnTotalBill.Location = new System.Drawing.Point(0, 11);
            this.pnTotalBill.Margin = new System.Windows.Forms.Padding(2);
            this.pnTotalBill.Name = "pnTotalBill";
            this.pnTotalBill.Size = new System.Drawing.Size(865, 70);
            this.pnTotalBill.TabIndex = 0;
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalBill.Location = new System.Drawing.Point(11, 15);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
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
            // dgvBillOfWareHouse
            // 
            this.dgvBillOfWareHouse.AllowUserToAddRows = false;
            this.dgvBillOfWareHouse.AllowUserToDeleteRows = false;
            this.dgvBillOfWareHouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillOfWareHouse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBillOfWareHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillOfWareHouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBillOfWareHouse,
            this.dateAdded,
            this.supplier,
            this.note});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillOfWareHouse.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBillOfWareHouse.Location = new System.Drawing.Point(0, 102);
            this.dgvBillOfWareHouse.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBillOfWareHouse.Name = "dgvBillOfWareHouse";
            this.dgvBillOfWareHouse.ReadOnly = true;
            this.dgvBillOfWareHouse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBillOfWareHouse.RowHeadersWidth = 82;
            this.dgvBillOfWareHouse.RowTemplate.Height = 28;
            this.dgvBillOfWareHouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillOfWareHouse.Size = new System.Drawing.Size(865, 489);
            this.dgvBillOfWareHouse.TabIndex = 7;
            this.dgvBillOfWareHouse.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBillOfWareHouse_CellMouseClick);
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
            this.lsvBillInfoOfWH.Margin = new System.Windows.Forms.Padding(2);
            this.lsvBillInfoOfWH.Name = "lsvBillInfoOfWH";
            this.lsvBillInfoOfWH.Size = new System.Drawing.Size(639, 796);
            this.lsvBillInfoOfWH.TabIndex = 6;
            this.lsvBillInfoOfWH.UseCompatibleStateImageBehavior = false;
            this.lsvBillInfoOfWH.View = System.Windows.Forms.View.Details;
            this.lsvBillInfoOfWH.SelectedIndexChanged += new System.EventHandler(this.lsvBillInfoOfWH_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Nguyên Liệu";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số Lượng";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 200;
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.DimGray;
            this.pn1.Controls.Add(this.rtbNote);
            this.pn1.Controls.Add(this.txtTotalPrice);
            this.pn1.Controls.Add(this.txtSupplier);
            this.pn1.Controls.Add(this.txtDateAdd);
            this.pn1.Controls.Add(this.txtBillOfWareHouseID);
            this.pn1.Controls.Add(this.lblSupplier);
            this.pn1.Controls.Add(this.lbl5);
            this.pn1.Controls.Add(this.lblDate);
            this.pn1.Controls.Add(this.lblNote);
            this.pn1.Controls.Add(this.lblBillOfWHID);
            this.pn1.Location = new System.Drawing.Point(0, 615);
            this.pn1.Margin = new System.Windows.Forms.Padding(2);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(865, 283);
            this.pn1.TabIndex = 3;
            // 
            // rtbNote
            // 
            this.rtbNote.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNote.Location = new System.Drawing.Point(546, 83);
            this.rtbNote.Margin = new System.Windows.Forms.Padding(1);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.ReadOnly = true;
            this.rtbNote.Size = new System.Drawing.Size(296, 167);
            this.rtbNote.TabIndex = 2;
            this.rtbNote.Text = "";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(259, 205);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(1);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(237, 45);
            this.txtTotalPrice.TabIndex = 1;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplier.Location = new System.Drawing.Point(259, 146);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(1);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(237, 45);
            this.txtSupplier.TabIndex = 1;
            this.txtSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSupplier.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDateAdd
            // 
            this.txtDateAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateAdd.Location = new System.Drawing.Point(259, 87);
            this.txtDateAdd.Margin = new System.Windows.Forms.Padding(1);
            this.txtDateAdd.Name = "txtDateAdd";
            this.txtDateAdd.ReadOnly = true;
            this.txtDateAdd.Size = new System.Drawing.Size(237, 45);
            this.txtDateAdd.TabIndex = 1;
            this.txtDateAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBillOfWareHouseID
            // 
            this.txtBillOfWareHouseID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillOfWareHouseID.Location = new System.Drawing.Point(259, 27);
            this.txtBillOfWareHouseID.Margin = new System.Windows.Forms.Padding(1);
            this.txtBillOfWareHouseID.Name = "txtBillOfWareHouseID";
            this.txtBillOfWareHouseID.ReadOnly = true;
            this.txtBillOfWareHouseID.Size = new System.Drawing.Size(237, 45);
            this.txtBillOfWareHouseID.TabIndex = 1;
            this.txtBillOfWareHouseID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(-1, 150);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(240, 41);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "Nhà cung cấp:";
            this.lblSupplier.Click += new System.EventHandler(this.lblSupplier_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(1, 209);
            this.lbl5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(179, 41);
            this.lbl5.TabIndex = 0;
            this.lbl5.Text = "Tổng tiền:";
            this.lbl5.Click += new System.EventHandler(this.lbl5_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(-1, 91);
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
            this.lblNote.Location = new System.Drawing.Point(539, 27);
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
            // frmWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1528, 957);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.lsvBillInfoOfWH);
            this.Controls.Add(this.dgvBillOfWareHouse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnTotalBill);
            this.Font = new System.Drawing.Font("Cambria", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmWareHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thông tin đơn hàng";
            this.Load += new System.EventHandler(this.frmWareHouse_Load);
            this.pnTotalBill.ResumeLayout(false);
            this.pnTotalBill.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillOfWareHouse)).EndInit();
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTotalBill;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBillDetail;
        private System.Windows.Forms.DataGridView dgvBillOfWareHouse;
        private System.Windows.Forms.ListView lsvBillInfoOfWH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblBillOfWHID;
        private System.Windows.Forms.TextBox txtBillOfWareHouseID;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBillOfWareHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtDateAdd;
    }
}