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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminTable));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolstripTim = new System.Windows.Forms.ToolStripLabel();
            this.txtFindTableName = new System.Windows.Forms.ToolStripTextBox();
            this.dgvTableFood = new System.Windows.Forms.DataGridView();
            this.colMaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.lblMaban = new System.Windows.Forms.Label();
            this.lblTenban = new System.Windows.Forms.Label();
            this.lblTrangthai = new System.Windows.Forms.Label();
            this.txtTableID = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtTableStatus = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalTableFood = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableFood)).BeginInit();
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
            this.txtFindTableName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(855, 50);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 44);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolstripTim
            // 
            this.toolstripTim.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolstripTim.Name = "toolstripTim";
            this.toolstripTim.Size = new System.Drawing.Size(220, 44);
            this.toolstripTim.Text = "Tìm kiếm bàn ăn";
            this.toolstripTim.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // txtFindTableName
            // 
            this.txtFindTableName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFindTableName.Name = "txtFindTableName";
            this.txtFindTableName.Size = new System.Drawing.Size(500, 50);
            this.txtFindTableName.Click += new System.EventHandler(this.txtFindTableName_Click);
            this.txtFindTableName.TextChanged += new System.EventHandler(this.txtFindTableName_TextChanged);
            // 
            // dgvTableFood
            // 
            this.dgvTableFood.AllowUserToAddRows = false;
            this.dgvTableFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBan,
            this.colTenBan,
            this.colTrangThai});
            this.dgvTableFood.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTableFood.Location = new System.Drawing.Point(0, 122);
            this.dgvTableFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTableFood.Name = "dgvTableFood";
            this.dgvTableFood.ReadOnly = true;
            this.dgvTableFood.RowHeadersWidth = 51;
            this.dgvTableFood.RowTemplate.Height = 24;
            this.dgvTableFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableFood.Size = new System.Drawing.Size(984, 545);
            this.dgvTableFood.TabIndex = 4;
            this.dgvTableFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            this.dgvTableFood.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTableFood_CellMouseClick);
            // 
            // colMaBan
            // 
            this.colMaBan.HeaderText = "Mã bàn ăn";
            this.colMaBan.MinimumWidth = 6;
            this.colMaBan.Name = "colMaBan";
            this.colMaBan.ReadOnly = true;
            this.colMaBan.Width = 200;
            // 
            // colTenBan
            // 
            this.colTenBan.HeaderText = "Tên bàn ăn";
            this.colTenBan.MinimumWidth = 6;
            this.colTenBan.Name = "colTenBan";
            this.colTenBan.ReadOnly = true;
            this.colTenBan.Width = 300;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.Width = 300;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.btnShowTable);
            this.panel3.Controls.Add(this.btnDeleteTable);
            this.panel3.Controls.Add(this.btnEditTable);
            this.panel3.Controls.Add(this.btnAddTable);
            this.panel3.Location = new System.Drawing.Point(0, 746);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 145);
            this.panel3.TabIndex = 12;
            // 
            // btnShowTable
            // 
            this.btnShowTable.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTable.Image = ((System.Drawing.Image)(resources.GetObject("btnShowTable.Image")));
            this.btnShowTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowTable.Location = new System.Drawing.Point(756, 37);
            this.btnShowTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(169, 72);
            this.btnShowTable.TabIndex = 4;
            this.btnShowTable.Text = "Hiển thị";
            this.btnShowTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTable.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTable.Image")));
            this.btnDeleteTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTable.Location = new System.Drawing.Point(554, 37);
            this.btnDeleteTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(174, 72);
            this.btnDeleteTable.TabIndex = 2;
            this.btnDeleteTable.Text = "Xóa";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnEditTable
            // 
            this.btnEditTable.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTable.Image = ((System.Drawing.Image)(resources.GetObject("btnEditTable.Image")));
            this.btnEditTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTable.Location = new System.Drawing.Point(344, 37);
            this.btnEditTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(174, 72);
            this.btnEditTable.TabIndex = 1;
            this.btnEditTable.Text = "Sửa";
            this.btnEditTable.UseVisualStyleBackColor = true;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTable.Image")));
            this.btnAddTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTable.Location = new System.Drawing.Point(133, 37);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(174, 72);
            this.btnAddTable.TabIndex = 0;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Font = new System.Drawing.Font("Cambria", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtin.ForeColor = System.Drawing.Color.White;
            this.lblThongtin.Location = new System.Drawing.Point(83, 215);
            this.lblThongtin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(359, 47);
            this.lblThongtin.TabIndex = 0;
            this.lblThongtin.Text = "Thông Tin Món Ăn";
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
            // txtTableID
            // 
            this.txtTableID.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableID.Location = new System.Drawing.Point(203, 314);
            this.txtTableID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.ReadOnly = true;
            this.txtTableID.Size = new System.Drawing.Size(193, 36);
            this.txtTableID.TabIndex = 4;
            // 
            // txtTableName
            // 
            this.txtTableName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableName.Location = new System.Drawing.Point(203, 447);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(193, 36);
            this.txtTableName.TabIndex = 5;
            // 
            // txtTableStatus
            // 
            this.txtTableStatus.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableStatus.Location = new System.Drawing.Point(203, 584);
            this.txtTableStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTableStatus.Name = "txtTableStatus";
            this.txtTableStatus.ReadOnly = true;
            this.txtTableStatus.Size = new System.Drawing.Size(193, 36);
            this.txtTableStatus.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.txtTableStatus);
            this.panel1.Controls.Add(this.txtTableName);
            this.panel1.Controls.Add(this.txtTableID);
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
            this.panel2.Controls.Add(this.lblTotalTableFood);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 53);
            this.panel2.TabIndex = 13;
            // 
            // lblTotalTableFood
            // 
            this.lblTotalTableFood.AutoSize = true;
            this.lblTotalTableFood.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTableFood.Location = new System.Drawing.Point(19, 13);
            this.lblTotalTableFood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTableFood.Name = "lblTotalTableFood";
            this.lblTotalTableFood.Size = new System.Drawing.Size(210, 32);
            this.lblTotalTableFood.TabIndex = 3;
            this.lblTotalTableFood.Text = "Tổng danh mục:";
            // 
            // frmAdminTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 957);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTableFood);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdminTable";
            this.Text = "frmTable";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableFood)).EndInit();
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
        private System.Windows.Forms.ToolStripTextBox txtFindTableName;
        private System.Windows.Forms.DataGridView dgvTableFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.Label lblMaban;
        private System.Windows.Forms.Label lblTenban;
        private System.Windows.Forms.Label lblTrangthai;
        private System.Windows.Forms.TextBox txtTableID;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtTableStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalTableFood;
    }
}