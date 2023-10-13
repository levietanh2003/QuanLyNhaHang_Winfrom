namespace quanLyNhaHang_Nhom4.Manager
{
    partial class frmAddWareHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddWareHouse));
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.txtMaterialID = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lbllblMaterialName2 = new System.Windows.Forms.Label();
            this.lblidMaterial = new System.Windows.Forms.Label();
            this.txtNumer = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNumer = new System.Windows.Forms.Label();
            this.lblMaterialName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dgvMaterialList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpUnit = new System.Windows.Forms.TabPage();
            this.btnShowUnit = new FontAwesome.Sharp.IconButton();
            this.btnDeleteUnit = new FontAwesome.Sharp.IconButton();
            this.btnEditUnit = new FontAwesome.Sharp.IconButton();
            this.btnAddUnit = new FontAwesome.Sharp.IconButton();
            this.dgvUnitList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.txtUnitID = new System.Windows.Forms.TextBox();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.cmbMaterialName = new System.Windows.Forms.ComboBox();
            this.pn1 = new System.Windows.Forms.Panel();
            this.btnSaveBillOfWH = new FontAwesome.Sharp.IconButton();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtIdBillOfWareHouse = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblBillOfWareHouse = new System.Windows.Forms.Label();
            this.lblBillInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBillDetail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tpMaterial = new System.Windows.Forms.TabPage();
            this.btnShowMaterial = new FontAwesome.Sharp.IconButton();
            this.btnDeleteMaterial = new FontAwesome.Sharp.IconButton();
            this.btnEditMaterial = new FontAwesome.Sharp.IconButton();
            this.btnAddMaterial = new FontAwesome.Sharp.IconButton();
            this.lsvBillInfoOfWH = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tclBill = new System.Windows.Forms.TabControl();
            this.tpBillInfo = new System.Windows.Forms.TabPage();
            this.btnAddBillInfo = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblAddMaterialInfo = new System.Windows.Forms.Label();
            this.pdHoaDon = new System.Drawing.Printing.PrintDocument();
            this.pddHoaDon = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialList)).BeginInit();
            this.tpUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitList)).BeginInit();
            this.pn1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpMaterial.SuspendLayout();
            this.tclBill.SuspendLayout();
            this.tpBillInfo.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(262, 310);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(251, 52);
            this.cmbUnit.TabIndex = 7;
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txtMaterialName.Location = new System.Drawing.Point(262, 206);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(249, 52);
            this.txtMaterialName.TabIndex = 6;
            // 
            // txtMaterialID
            // 
            this.txtMaterialID.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txtMaterialID.Location = new System.Drawing.Point(262, 100);
            this.txtMaterialID.Name = "txtMaterialID";
            this.txtMaterialID.Size = new System.Drawing.Size(249, 52);
            this.txtMaterialID.TabIndex = 6;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblUnit.ForeColor = System.Drawing.Color.White;
            this.lblUnit.Location = new System.Drawing.Point(10, 315);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(248, 49);
            this.lblUnit.TabIndex = 5;
            this.lblUnit.Text = "Đơn vị tính:";
            // 
            // lbllblMaterialName2
            // 
            this.lbllblMaterialName2.AutoSize = true;
            this.lbllblMaterialName2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbllblMaterialName2.ForeColor = System.Drawing.Color.White;
            this.lbllblMaterialName2.Location = new System.Drawing.Point(3, 195);
            this.lbllblMaterialName2.Name = "lbllblMaterialName2";
            this.lbllblMaterialName2.Size = new System.Drawing.Size(336, 49);
            this.lbllblMaterialName2.TabIndex = 5;
            this.lbllblMaterialName2.Text = "Tên nguyên liệu:";
            // 
            // lblidMaterial
            // 
            this.lblidMaterial.AutoSize = true;
            this.lblidMaterial.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblidMaterial.ForeColor = System.Drawing.Color.White;
            this.lblidMaterial.Location = new System.Drawing.Point(10, 104);
            this.lblidMaterial.Name = "lblidMaterial";
            this.lblidMaterial.Size = new System.Drawing.Size(322, 49);
            this.lblidMaterial.TabIndex = 5;
            this.lblidMaterial.Text = "Mã nguyên liệu:";
            // 
            // txtNumer
            // 
            this.txtNumer.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumer.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txtNumer.Location = new System.Drawing.Point(304, 222);
            this.txtNumer.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtNumer.Name = "txtNumer";
            this.txtNumer.Size = new System.Drawing.Size(348, 52);
            this.txtNumer.TabIndex = 21;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(34, 358);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(183, 49);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "Đơn giá:";
            // 
            // lblNumer
            // 
            this.lblNumer.AutoSize = true;
            this.lblNumer.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNumer.ForeColor = System.Drawing.Color.Black;
            this.lblNumer.Location = new System.Drawing.Point(34, 222);
            this.lblNumer.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNumer.Name = "lblNumer";
            this.lblNumer.Size = new System.Drawing.Size(207, 49);
            this.lblNumer.TabIndex = 24;
            this.lblNumer.Text = "Số lượng:";
            // 
            // lblMaterialName
            // 
            this.lblMaterialName.AutoSize = true;
            this.lblMaterialName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblMaterialName.ForeColor = System.Drawing.Color.Black;
            this.lblMaterialName.Location = new System.Drawing.Point(34, 101);
            this.lblMaterialName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMaterialName.Name = "lblMaterialName";
            this.lblMaterialName.Size = new System.Drawing.Size(336, 49);
            this.lblMaterialName.TabIndex = 25;
            this.lblMaterialName.Text = "Tên nguyên liệu:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrice.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txtPrice.Location = new System.Drawing.Point(304, 358);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(348, 52);
            this.txtPrice.TabIndex = 22;
            // 
            // dgvMaterialList
            // 
            this.dgvMaterialList.AllowUserToAddRows = false;
            this.dgvMaterialList.AllowUserToDeleteRows = false;
            this.dgvMaterialList.ColumnHeadersHeight = 34;
            this.dgvMaterialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMaterialList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterialList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaterialList.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvMaterialList.Location = new System.Drawing.Point(517, 6);
            this.dgvMaterialList.Name = "dgvMaterialList";
            this.dgvMaterialList.ReadOnly = true;
            this.dgvMaterialList.RowHeadersWidth = 62;
            this.dgvMaterialList.RowTemplate.Height = 28;
            this.dgvMaterialList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterialList.Size = new System.Drawing.Size(437, 537);
            this.dgvMaterialList.TabIndex = 4;
            this.dgvMaterialList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterialList_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nguyên liệu";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nguyên liệu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Đơn vị tính";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // tpUnit
            // 
            this.tpUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.tpUnit.Controls.Add(this.btnShowUnit);
            this.tpUnit.Controls.Add(this.btnDeleteUnit);
            this.tpUnit.Controls.Add(this.btnEditUnit);
            this.tpUnit.Controls.Add(this.btnAddUnit);
            this.tpUnit.Controls.Add(this.dgvUnitList);
            this.tpUnit.Controls.Add(this.txtUnitName);
            this.tpUnit.Controls.Add(this.txtUnitID);
            this.tpUnit.Controls.Add(this.lblUnitName);
            this.tpUnit.Controls.Add(this.lblUnitID);
            this.tpUnit.Location = new System.Drawing.Point(8, 39);
            this.tpUnit.Name = "tpUnit";
            this.tpUnit.Padding = new System.Windows.Forms.Padding(3);
            this.tpUnit.Size = new System.Drawing.Size(961, 549);
            this.tpUnit.TabIndex = 2;
            this.tpUnit.Text = "Đơn vị tính";
            // 
            // btnShowUnit
            // 
            this.btnShowUnit.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnShowUnit.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShowUnit.IconColor = System.Drawing.Color.Black;
            this.btnShowUnit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowUnit.IconSize = 25;
            this.btnShowUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowUnit.Location = new System.Drawing.Point(435, 21);
            this.btnShowUnit.Margin = new System.Windows.Forms.Padding(5);
            this.btnShowUnit.Name = "btnShowUnit";
            this.btnShowUnit.Size = new System.Drawing.Size(125, 61);
            this.btnShowUnit.TabIndex = 24;
            this.btnShowUnit.Text = "Hiển thị";
            this.btnShowUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowUnit.UseVisualStyleBackColor = true;
            this.btnShowUnit.Click += new System.EventHandler(this.btnShowUnit_Click);
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUnit.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnDeleteUnit.IconColor = System.Drawing.Color.Black;
            this.btnDeleteUnit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteUnit.IconSize = 25;
            this.btnDeleteUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUnit.Location = new System.Drawing.Point(309, 21);
            this.btnDeleteUnit.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(104, 61);
            this.btnDeleteUnit.TabIndex = 23;
            this.btnDeleteUnit.Text = "Xóa";
            this.btnDeleteUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteUnit.UseVisualStyleBackColor = true;
            this.btnDeleteUnit.Click += new System.EventHandler(this.btnDeleteUnit_Click);
            // 
            // btnEditUnit
            // 
            this.btnEditUnit.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEditUnit.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditUnit.IconColor = System.Drawing.Color.Black;
            this.btnEditUnit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditUnit.IconSize = 25;
            this.btnEditUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUnit.Location = new System.Drawing.Point(181, 21);
            this.btnEditUnit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditUnit.Name = "btnEditUnit";
            this.btnEditUnit.Size = new System.Drawing.Size(107, 61);
            this.btnEditUnit.TabIndex = 22;
            this.btnEditUnit.Text = "Sửa";
            this.btnEditUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditUnit.UseVisualStyleBackColor = true;
            this.btnEditUnit.Click += new System.EventHandler(this.btnEditUnit_Click);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUnit.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddUnit.IconColor = System.Drawing.Color.Black;
            this.btnAddUnit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddUnit.IconSize = 25;
            this.btnAddUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUnit.Location = new System.Drawing.Point(28, 21);
            this.btnAddUnit.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(128, 61);
            this.btnAddUnit.TabIndex = 21;
            this.btnAddUnit.Text = "Thêm";
            this.btnAddUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUnit.UseVisualStyleBackColor = true;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // dgvUnitList
            // 
            this.dgvUnitList.AllowUserToAddRows = false;
            this.dgvUnitList.AllowUserToDeleteRows = false;
            this.dgvUnitList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnitList.ColumnHeadersHeight = 34;
            this.dgvUnitList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUnitList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dgvUnitList.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvUnitList.Location = new System.Drawing.Point(566, 3);
            this.dgvUnitList.Name = "dgvUnitList";
            this.dgvUnitList.RowHeadersWidth = 62;
            this.dgvUnitList.RowTemplate.Height = 28;
            this.dgvUnitList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnitList.Size = new System.Drawing.Size(392, 543);
            this.dgvUnitList.TabIndex = 3;
            this.dgvUnitList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnitList_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "Mã đơn vị tính";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Tên đơn vị tính";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txtUnitName.Location = new System.Drawing.Point(249, 377);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(293, 52);
            this.txtUnitName.TabIndex = 2;
            // 
            // txtUnitID
            // 
            this.txtUnitID.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txtUnitID.Location = new System.Drawing.Point(249, 174);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.Size = new System.Drawing.Size(293, 52);
            this.txtUnitID.TabIndex = 2;
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblUnitName.ForeColor = System.Drawing.Color.White;
            this.lblUnitName.Location = new System.Drawing.Point(16, 366);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(237, 49);
            this.lblUnitName.TabIndex = 1;
            this.lblUnitName.Text = "Tên đơn vị:";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblUnitID.ForeColor = System.Drawing.Color.White;
            this.lblUnitID.Location = new System.Drawing.Point(26, 178);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(223, 49);
            this.lblUnitID.TabIndex = 1;
            this.lblUnitID.Text = "Mã đơn vị:";
            // 
            // cmbMaterialName
            // 
            this.cmbMaterialName.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMaterialName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterialName.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.cmbMaterialName.FormattingEnabled = true;
            this.cmbMaterialName.Location = new System.Drawing.Point(304, 101);
            this.cmbMaterialName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cmbMaterialName.Name = "cmbMaterialName";
            this.cmbMaterialName.Size = new System.Drawing.Size(348, 52);
            this.cmbMaterialName.TabIndex = 20;
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.DimGray;
            this.pn1.Controls.Add(this.btnSaveBillOfWH);
            this.pn1.Controls.Add(this.rtbNote);
            this.pn1.Controls.Add(this.lblNote);
            this.pn1.Controls.Add(this.txtTotalPrice);
            this.pn1.Controls.Add(this.txtSupplier);
            this.pn1.Controls.Add(this.txtDate);
            this.pn1.Controls.Add(this.txtIdBillOfWareHouse);
            this.pn1.Controls.Add(this.lblTotalPrice);
            this.pn1.Controls.Add(this.lblSupplier);
            this.pn1.Controls.Add(this.lblDate);
            this.pn1.Controls.Add(this.lblBillOfWareHouse);
            this.pn1.Location = new System.Drawing.Point(4, 48);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(980, 286);
            this.pn1.TabIndex = 32;
            // 
            // btnSaveBillOfWH
            // 
            this.btnSaveBillOfWH.BackColor = System.Drawing.Color.White;
            this.btnSaveBillOfWH.FlatAppearance.BorderSize = 0;
            this.btnSaveBillOfWH.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBillOfWH.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSaveBillOfWH.IconColor = System.Drawing.Color.Black;
            this.btnSaveBillOfWH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveBillOfWH.Location = new System.Drawing.Point(624, 198);
            this.btnSaveBillOfWH.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveBillOfWH.Name = "btnSaveBillOfWH";
            this.btnSaveBillOfWH.Size = new System.Drawing.Size(257, 60);
            this.btnSaveBillOfWH.TabIndex = 16;
            this.btnSaveBillOfWH.Text = "Lưu hóa đơn";
            this.btnSaveBillOfWH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveBillOfWH.UseVisualStyleBackColor = false;
            this.btnSaveBillOfWH.Click += new System.EventHandler(this.btnSaveBillOfWH_Click);
            // 
            // rtbNote
            // 
            this.rtbNote.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNote.Location = new System.Drawing.Point(702, 29);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(261, 145);
            this.rtbNote.TabIndex = 15;
            this.rtbNote.Text = "";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(576, 34);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(136, 37);
            this.lblNote.TabIndex = 14;
            this.lblNote.Text = "Ghi chú:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPrice.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotalPrice.Location = new System.Drawing.Point(205, 177);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(315, 45);
            this.txtTotalPrice.TabIndex = 10;
            // 
            // txtSupplier
            // 
            this.txtSupplier.BackColor = System.Drawing.Color.White;
            this.txtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupplier.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSupplier.Location = new System.Drawing.Point(205, 129);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(315, 45);
            this.txtSupplier.TabIndex = 8;
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDate.Location = new System.Drawing.Point(205, 75);
            this.txtDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(315, 45);
            this.txtDate.TabIndex = 7;
            // 
            // txtIdBillOfWareHouse
            // 
            this.txtIdBillOfWareHouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdBillOfWareHouse.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIdBillOfWareHouse.Location = new System.Drawing.Point(205, 29);
            this.txtIdBillOfWareHouse.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtIdBillOfWareHouse.Name = "txtIdBillOfWareHouse";
            this.txtIdBillOfWareHouse.ReadOnly = true;
            this.txtIdBillOfWareHouse.Size = new System.Drawing.Size(315, 45);
            this.txtIdBillOfWareHouse.TabIndex = 6;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(18, 177);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(163, 37);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "Tổng tiền:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(18, 129);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(225, 37);
            this.lblSupplier.TabIndex = 13;
            this.lblSupplier.Text = "Nhà Cung Cấp:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(18, 83);
            this.lblDate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(182, 37);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Ngày Nhập:";
            // 
            // lblBillOfWareHouse
            // 
            this.lblBillOfWareHouse.AutoSize = true;
            this.lblBillOfWareHouse.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lblBillOfWareHouse.ForeColor = System.Drawing.Color.White;
            this.lblBillOfWareHouse.Location = new System.Drawing.Point(18, 29);
            this.lblBillOfWareHouse.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBillOfWareHouse.Name = "lblBillOfWareHouse";
            this.lblBillOfWareHouse.Size = new System.Drawing.Size(198, 37);
            this.lblBillOfWareHouse.TabIndex = 9;
            this.lblBillOfWareHouse.Text = "Mã hóa đơn:";
            // 
            // lblBillInfo
            // 
            this.lblBillInfo.AutoSize = true;
            this.lblBillInfo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillInfo.Location = new System.Drawing.Point(7, 10);
            this.lblBillInfo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblBillInfo.Name = "lblBillInfo";
            this.lblBillInfo.Size = new System.Drawing.Size(286, 37);
            this.lblBillInfo.TabIndex = 0;
            this.lblBillInfo.Text = "Thông tin hóa đơn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lblBillDetail);
            this.panel2.Location = new System.Drawing.Point(990, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(526, 37);
            this.panel2.TabIndex = 31;
            // 
            // lblBillDetail
            // 
            this.lblBillDetail.AutoSize = true;
            this.lblBillDetail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillDetail.Location = new System.Drawing.Point(9, 5);
            this.lblBillDetail.Name = "lblBillDetail";
            this.lblBillDetail.Size = new System.Drawing.Size(250, 37);
            this.lblBillDetail.TabIndex = 0;
            this.lblBillDetail.Text = "Chi tiết hóa đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblBillInfo);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 37);
            this.panel1.TabIndex = 30;
            // 
            // tpMaterial
            // 
            this.tpMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.tpMaterial.Controls.Add(this.btnShowMaterial);
            this.tpMaterial.Controls.Add(this.btnDeleteMaterial);
            this.tpMaterial.Controls.Add(this.btnEditMaterial);
            this.tpMaterial.Controls.Add(this.btnAddMaterial);
            this.tpMaterial.Controls.Add(this.cmbUnit);
            this.tpMaterial.Controls.Add(this.txtMaterialName);
            this.tpMaterial.Controls.Add(this.txtMaterialID);
            this.tpMaterial.Controls.Add(this.lblUnit);
            this.tpMaterial.Controls.Add(this.lbllblMaterialName2);
            this.tpMaterial.Controls.Add(this.lblidMaterial);
            this.tpMaterial.Controls.Add(this.dgvMaterialList);
            this.tpMaterial.Location = new System.Drawing.Point(8, 39);
            this.tpMaterial.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tpMaterial.Name = "tpMaterial";
            this.tpMaterial.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tpMaterial.Size = new System.Drawing.Size(961, 549);
            this.tpMaterial.TabIndex = 1;
            this.tpMaterial.Text = "Nguyên Liệu";
            // 
            // btnShowMaterial
            // 
            this.btnShowMaterial.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnShowMaterial.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShowMaterial.IconColor = System.Drawing.Color.Black;
            this.btnShowMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowMaterial.IconSize = 25;
            this.btnShowMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowMaterial.Location = new System.Drawing.Point(372, 20);
            this.btnShowMaterial.Margin = new System.Windows.Forms.Padding(5);
            this.btnShowMaterial.Name = "btnShowMaterial";
            this.btnShowMaterial.Size = new System.Drawing.Size(139, 56);
            this.btnShowMaterial.TabIndex = 20;
            this.btnShowMaterial.Text = "Hiển thị";
            this.btnShowMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowMaterial.UseVisualStyleBackColor = true;
            this.btnShowMaterial.Click += new System.EventHandler(this.btnShowMaterial_Click);
            // 
            // btnDeleteMaterial
            // 
            this.btnDeleteMaterial.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteMaterial.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnDeleteMaterial.IconColor = System.Drawing.Color.Black;
            this.btnDeleteMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteMaterial.IconSize = 25;
            this.btnDeleteMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMaterial.Location = new System.Drawing.Point(253, 20);
            this.btnDeleteMaterial.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteMaterial.Name = "btnDeleteMaterial";
            this.btnDeleteMaterial.Size = new System.Drawing.Size(100, 56);
            this.btnDeleteMaterial.TabIndex = 19;
            this.btnDeleteMaterial.Text = "Xóa";
            this.btnDeleteMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteMaterial.UseVisualStyleBackColor = true;
            this.btnDeleteMaterial.Click += new System.EventHandler(this.btnDeleteMaterial_Click);
            // 
            // btnEditMaterial
            // 
            this.btnEditMaterial.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEditMaterial.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditMaterial.IconColor = System.Drawing.Color.Black;
            this.btnEditMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditMaterial.IconSize = 25;
            this.btnEditMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditMaterial.Location = new System.Drawing.Point(148, 20);
            this.btnEditMaterial.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditMaterial.Name = "btnEditMaterial";
            this.btnEditMaterial.Size = new System.Drawing.Size(95, 56);
            this.btnEditMaterial.TabIndex = 18;
            this.btnEditMaterial.Text = "Sửa";
            this.btnEditMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditMaterial.UseVisualStyleBackColor = true;
            this.btnEditMaterial.Click += new System.EventHandler(this.btnEditMaterial_Click);
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMaterial.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddMaterial.IconColor = System.Drawing.Color.Black;
            this.btnAddMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddMaterial.IconSize = 25;
            this.btnAddMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMaterial.Location = new System.Drawing.Point(13, 20);
            this.btnAddMaterial.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(120, 56);
            this.btnAddMaterial.TabIndex = 17;
            this.btnAddMaterial.Text = "Thêm";
            this.btnAddMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // lsvBillInfoOfWH
            // 
            this.lsvBillInfoOfWH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBillInfoOfWH.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBillInfoOfWH.GridLines = true;
            this.lsvBillInfoOfWH.HideSelection = false;
            this.lsvBillInfoOfWH.LabelEdit = true;
            this.lsvBillInfoOfWH.Location = new System.Drawing.Point(990, 47);
            this.lsvBillInfoOfWH.Name = "lsvBillInfoOfWH";
            this.lsvBillInfoOfWH.Size = new System.Drawing.Size(540, 889);
            this.lsvBillInfoOfWH.TabIndex = 34;
            this.lsvBillInfoOfWH.UseCompatibleStateImageBehavior = false;
            this.lsvBillInfoOfWH.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên nguyên liệu";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 120;
            // 
            // tclBill
            // 
            this.tclBill.Controls.Add(this.tpBillInfo);
            this.tclBill.Controls.Add(this.tpMaterial);
            this.tclBill.Controls.Add(this.tpUnit);
            this.tclBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclBill.Location = new System.Drawing.Point(7, 340);
            this.tclBill.Name = "tclBill";
            this.tclBill.SelectedIndex = 0;
            this.tclBill.Size = new System.Drawing.Size(977, 596);
            this.tclBill.TabIndex = 33;
            // 
            // tpBillInfo
            // 
            this.tpBillInfo.Controls.Add(this.btnAddBillInfo);
            this.tpBillInfo.Controls.Add(this.txtPrice);
            this.tpBillInfo.Controls.Add(this.txtNumer);
            this.tpBillInfo.Controls.Add(this.lblPrice);
            this.tpBillInfo.Controls.Add(this.lblNumer);
            this.tpBillInfo.Controls.Add(this.lblMaterialName);
            this.tpBillInfo.Controls.Add(this.cmbMaterialName);
            this.tpBillInfo.Controls.Add(this.panel9);
            this.tpBillInfo.ForeColor = System.Drawing.Color.White;
            this.tpBillInfo.Location = new System.Drawing.Point(8, 39);
            this.tpBillInfo.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tpBillInfo.Name = "tpBillInfo";
            this.tpBillInfo.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tpBillInfo.Size = new System.Drawing.Size(961, 549);
            this.tpBillInfo.TabIndex = 0;
            this.tpBillInfo.Text = "Chi tiết hóa đơn";
            this.tpBillInfo.UseVisualStyleBackColor = true;
            // 
            // btnAddBillInfo
            // 
            this.btnAddBillInfo.BackColor = System.Drawing.Color.DimGray;
            this.btnAddBillInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBillInfo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBillInfo.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Actions_list_add_icon;
            this.btnAddBillInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBillInfo.Location = new System.Drawing.Point(637, 428);
            this.btnAddBillInfo.Name = "btnAddBillInfo";
            this.btnAddBillInfo.Size = new System.Drawing.Size(227, 83);
            this.btnAddBillInfo.TabIndex = 27;
            this.btnAddBillInfo.Text = "Thêm";
            this.btnAddBillInfo.UseVisualStyleBackColor = false;
            this.btnAddBillInfo.Click += new System.EventHandler(this.btnAddBillInfo_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.lblAddMaterialInfo);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(7, 6);
            this.panel9.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(947, 72);
            this.panel9.TabIndex = 19;
            // 
            // lblAddMaterialInfo
            // 
            this.lblAddMaterialInfo.AutoSize = true;
            this.lblAddMaterialInfo.Font = new System.Drawing.Font("Cambria", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMaterialInfo.ForeColor = System.Drawing.Color.White;
            this.lblAddMaterialInfo.Location = new System.Drawing.Point(59, 22);
            this.lblAddMaterialInfo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAddMaterialInfo.Name = "lblAddMaterialInfo";
            this.lblAddMaterialInfo.Size = new System.Drawing.Size(525, 47);
            this.lblAddMaterialInfo.TabIndex = 6;
            this.lblAddMaterialInfo.Text = "Thêm thông tin nguyên liệu";
            // 
            // pdHoaDon
            // 
            this.pdHoaDon.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdHoaDon_PrintPage);
            // 
            // pddHoaDon
            // 
            this.pddHoaDon.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pddHoaDon.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pddHoaDon.ClientSize = new System.Drawing.Size(400, 300);
            this.pddHoaDon.Enabled = true;
            this.pddHoaDon.Icon = ((System.Drawing.Icon)(resources.GetObject("pddHoaDon.Icon")));
            this.pddHoaDon.Name = "pddHoaDon";
            this.pddHoaDon.Visible = false;
            // 
            // frmAddWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 957);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsvBillInfoOfWH);
            this.Controls.Add(this.tclBill);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddWareHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Hóa Đơn Mới";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialList)).EndInit();
            this.tpUnit.ResumeLayout(false);
            this.tpUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitList)).EndInit();
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpMaterial.ResumeLayout(false);
            this.tpMaterial.PerformLayout();
            this.tclBill.ResumeLayout(false);
            this.tpBillInfo.ResumeLayout(false);
            this.tpBillInfo.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnDeleteMaterial;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.TextBox txtMaterialID;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lbllblMaterialName2;
        private System.Windows.Forms.Button btnAddBillInfo;
        private System.Windows.Forms.Label lblidMaterial;
        private System.Windows.Forms.TextBox txtNumer;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNumer;
        private System.Windows.Forms.Label lblMaterialName;
        private FontAwesome.Sharp.IconButton btnEditMaterial;
        private FontAwesome.Sharp.IconButton btnAddMaterial;
        private System.Windows.Forms.TextBox txtPrice;
        private FontAwesome.Sharp.IconButton btnShowMaterial;
        private System.Windows.Forms.DataGridView dgvMaterialList;
        private System.Windows.Forms.TabPage tpUnit;
        private FontAwesome.Sharp.IconButton btnShowUnit;
        private FontAwesome.Sharp.IconButton btnDeleteUnit;
        private FontAwesome.Sharp.IconButton btnEditUnit;
        private FontAwesome.Sharp.IconButton btnAddUnit;
        private System.Windows.Forms.DataGridView dgvUnitList;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.TextBox txtUnitID;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.Label lblUnitID;
        private System.Windows.Forms.ComboBox cmbMaterialName;
        private System.Windows.Forms.Panel pn1;
        private FontAwesome.Sharp.IconButton btnSaveBillOfWH;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtIdBillOfWareHouse;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblBillOfWareHouse;
        private System.Windows.Forms.Label lblBillInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBillDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tpMaterial;
        private System.Windows.Forms.ListView lsvBillInfoOfWH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabControl tclBill;
        private System.Windows.Forms.TabPage tpBillInfo;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblAddMaterialInfo;
        private System.Drawing.Printing.PrintDocument pdHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.PrintPreviewDialog pddHoaDon;
    }
}