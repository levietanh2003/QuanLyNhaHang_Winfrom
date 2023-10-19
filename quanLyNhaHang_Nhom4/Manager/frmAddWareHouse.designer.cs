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
            this.btnShowUnit = new System.Windows.Forms.Button();
            this.btnDeleteUnit = new System.Windows.Forms.Button();
            this.btnEditUnit = new System.Windows.Forms.Button();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.dgvUnitList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.txtUnitID = new System.Windows.Forms.TextBox();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.cmbMaterialName = new System.Windows.Forms.ComboBox();
            this.pn1 = new System.Windows.Forms.Panel();
            this.btnSaveBillOfWH = new System.Windows.Forms.Button();
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
            this.btnShowMaterial = new System.Windows.Forms.Button();
            this.btnDeleteMaterial = new System.Windows.Forms.Button();
            this.btnEditMaterial = new System.Windows.Forms.Button();
            this.btnAddMaterial = new System.Windows.Forms.Button();
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
            this.cmbUnit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(253, 207);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(121, 45);
            this.cmbUnit.TabIndex = 7;
            this.cmbUnit.SelectedIndexChanged += new System.EventHandler(this.cmbUnit_SelectedIndexChanged);
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterialName.Location = new System.Drawing.Point(253, 128);
            this.txtMaterialName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(121, 45);
            this.txtMaterialName.TabIndex = 6;
            // 
            // txtMaterialID
            // 
            this.txtMaterialID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterialID.Location = new System.Drawing.Point(253, 72);
            this.txtMaterialID.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtMaterialID.Name = "txtMaterialID";
            this.txtMaterialID.ReadOnly = true;
            this.txtMaterialID.Size = new System.Drawing.Size(121, 45);
            this.txtMaterialID.TabIndex = 6;
            this.txtMaterialID.TextChanged += new System.EventHandler(this.txtMaterialID_TextChanged);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.White;
            this.lblUnit.Location = new System.Drawing.Point(5, 215);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(191, 37);
            this.lblUnit.TabIndex = 5;
            this.lblUnit.Text = "Đơn vị tính:";
            // 
            // lbllblMaterialName2
            // 
            this.lbllblMaterialName2.AutoSize = true;
            this.lbllblMaterialName2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllblMaterialName2.ForeColor = System.Drawing.Color.White;
            this.lbllblMaterialName2.Location = new System.Drawing.Point(5, 136);
            this.lbllblMaterialName2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbllblMaterialName2.Name = "lbllblMaterialName2";
            this.lbllblMaterialName2.Size = new System.Drawing.Size(256, 37);
            this.lbllblMaterialName2.TabIndex = 5;
            this.lbllblMaterialName2.Text = "Tên nguyên liệu:";
            // 
            // lblidMaterial
            // 
            this.lblidMaterial.AutoSize = true;
            this.lblidMaterial.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidMaterial.ForeColor = System.Drawing.Color.White;
            this.lblidMaterial.Location = new System.Drawing.Point(5, 72);
            this.lblidMaterial.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblidMaterial.Name = "lblidMaterial";
            this.lblidMaterial.Size = new System.Drawing.Size(246, 37);
            this.lblidMaterial.TabIndex = 5;
            this.lblidMaterial.Text = "Mã nguyên liệu:";
            // 
            // txtNumer
            // 
            this.txtNumer.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumer.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumer.Location = new System.Drawing.Point(268, 149);
            this.txtNumer.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumer.Name = "txtNumer";
            this.txtNumer.Size = new System.Drawing.Size(254, 45);
            this.txtNumer.TabIndex = 21;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(22, 228);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(141, 37);
            this.lblPrice.TabIndex = 23;
            this.lblPrice.Text = "Đơn giá:";
            // 
            // lblNumer
            // 
            this.lblNumer.AutoSize = true;
            this.lblNumer.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumer.ForeColor = System.Drawing.Color.Black;
            this.lblNumer.Location = new System.Drawing.Point(22, 152);
            this.lblNumer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumer.Name = "lblNumer";
            this.lblNumer.Size = new System.Drawing.Size(157, 37);
            this.lblNumer.TabIndex = 24;
            this.lblNumer.Text = "Số lượng:";
            // 
            // lblMaterialName
            // 
            this.lblMaterialName.AutoSize = true;
            this.lblMaterialName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialName.ForeColor = System.Drawing.Color.Black;
            this.lblMaterialName.Location = new System.Drawing.Point(22, 101);
            this.lblMaterialName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterialName.Name = "lblMaterialName";
            this.lblMaterialName.Size = new System.Drawing.Size(256, 37);
            this.lblMaterialName.TabIndex = 25;
            this.lblMaterialName.Text = "Tên nguyên liệu:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(268, 221);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(254, 45);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterialList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaterialList.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvMaterialList.Location = new System.Drawing.Point(398, 2);
            this.dgvMaterialList.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgvMaterialList.Name = "dgvMaterialList";
            this.dgvMaterialList.ReadOnly = true;
            this.dgvMaterialList.RowHeadersWidth = 62;
            this.dgvMaterialList.RowTemplate.Height = 28;
            this.dgvMaterialList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterialList.Size = new System.Drawing.Size(408, 479);
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
            this.tpUnit.Location = new System.Drawing.Point(8, 45);
            this.tpUnit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tpUnit.Name = "tpUnit";
            this.tpUnit.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tpUnit.Size = new System.Drawing.Size(808, 483);
            this.tpUnit.TabIndex = 2;
            this.tpUnit.Text = "Đơn vị tính";
            this.tpUnit.Click += new System.EventHandler(this.tpUnit_Click);
            // 
            // btnShowUnit
            // 
            this.btnShowUnit.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUnit.Location = new System.Drawing.Point(254, 272);
            this.btnShowUnit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnShowUnit.Name = "btnShowUnit";
            this.btnShowUnit.Size = new System.Drawing.Size(117, 41);
            this.btnShowUnit.TabIndex = 25;
            this.btnShowUnit.Text = "HIển thị";
            this.btnShowUnit.UseVisualStyleBackColor = true;
            this.btnShowUnit.Click += new System.EventHandler(this.btnShowUnit_Click);
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUnit.Location = new System.Drawing.Point(121, 340);
            this.btnDeleteUnit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(117, 41);
            this.btnDeleteUnit.TabIndex = 26;
            this.btnDeleteUnit.Text = "Xóa";
            this.btnDeleteUnit.UseVisualStyleBackColor = true;
            this.btnDeleteUnit.Click += new System.EventHandler(this.btnDeleteUnit_Click);
            // 
            // btnEditUnit
            // 
            this.btnEditUnit.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUnit.Location = new System.Drawing.Point(254, 340);
            this.btnEditUnit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEditUnit.Name = "btnEditUnit";
            this.btnEditUnit.Size = new System.Drawing.Size(117, 41);
            this.btnEditUnit.TabIndex = 27;
            this.btnEditUnit.Text = "Sửa";
            this.btnEditUnit.UseVisualStyleBackColor = true;
            this.btnEditUnit.Click += new System.EventHandler(this.btnEditUnit_Click);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUnit.Location = new System.Drawing.Point(121, 272);
            this.btnAddUnit.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(117, 41);
            this.btnAddUnit.TabIndex = 28;
            this.btnAddUnit.Text = "Thêm";
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
            this.dgvUnitList.Location = new System.Drawing.Point(394, 2);
            this.dgvUnitList.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgvUnitList.Name = "dgvUnitList";
            this.dgvUnitList.RowHeadersWidth = 62;
            this.dgvUnitList.RowTemplate.Height = 28;
            this.dgvUnitList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnitList.Size = new System.Drawing.Size(413, 479);
            this.dgvUnitList.TabIndex = 3;
            this.dgvUnitList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnitList_CellClick);
            // 
            // id
            // 
            this.id.FillWeight = 107.9545F;
            this.id.HeaderText = "Mã đơn vị tính";
            this.id.MinimumWidth = 9;
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.FillWeight = 92.04546F;
            this.name.HeaderText = "Tên đơn vị tính";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitName.Location = new System.Drawing.Point(202, 179);
            this.txtUnitName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(165, 45);
            this.txtUnitName.TabIndex = 2;
            // 
            // txtUnitID
            // 
            this.txtUnitID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitID.Location = new System.Drawing.Point(202, 101);
            this.txtUnitID.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtUnitID.Name = "txtUnitID";
            this.txtUnitID.ReadOnly = true;
            this.txtUnitID.Size = new System.Drawing.Size(165, 45);
            this.txtUnitID.TabIndex = 2;
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.ForeColor = System.Drawing.Color.White;
            this.lblUnitName.Location = new System.Drawing.Point(6, 183);
            this.lblUnitName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(181, 37);
            this.lblUnitName.TabIndex = 1;
            this.lblUnitName.Text = "Tên đơn vị:";
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitID.ForeColor = System.Drawing.Color.White;
            this.lblUnitID.Location = new System.Drawing.Point(10, 105);
            this.lblUnitID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(171, 37);
            this.lblUnitID.TabIndex = 1;
            this.lblUnitID.Text = "Mã đơn vị:";
            // 
            // cmbMaterialName
            // 
            this.cmbMaterialName.BackColor = System.Drawing.SystemColors.Control;
            this.cmbMaterialName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterialName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterialName.FormattingEnabled = true;
            this.cmbMaterialName.Location = new System.Drawing.Point(268, 93);
            this.cmbMaterialName.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaterialName.Name = "cmbMaterialName";
            this.cmbMaterialName.Size = new System.Drawing.Size(254, 45);
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
            this.pn1.Location = new System.Drawing.Point(18, 69);
            this.pn1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(797, 272);
            this.pn1.TabIndex = 32;
            // 
            // btnSaveBillOfWH
            // 
            this.btnSaveBillOfWH.BackColor = System.Drawing.Color.White;
            this.btnSaveBillOfWH.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveBillOfWH.Location = new System.Drawing.Point(574, 175);
            this.btnSaveBillOfWH.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnSaveBillOfWH.Name = "btnSaveBillOfWH";
            this.btnSaveBillOfWH.Size = new System.Drawing.Size(177, 43);
            this.btnSaveBillOfWH.TabIndex = 17;
            this.btnSaveBillOfWH.Text = "Lưu hóa đơn";
            this.btnSaveBillOfWH.UseVisualStyleBackColor = false;
            this.btnSaveBillOfWH.Click += new System.EventHandler(this.btnSaveBillOfWH_Click_1);
            // 
            // rtbNote
            // 
            this.rtbNote.Font = new System.Drawing.Font("Cambria", 9.5F);
            this.rtbNote.Location = new System.Drawing.Point(574, 73);
            this.rtbNote.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(177, 86);
            this.rtbNote.TabIndex = 15;
            this.rtbNote.Text = "";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(415, 88);
            this.lblNote.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(136, 37);
            this.lblNote.TabIndex = 14;
            this.lblNote.Text = "Ghi chú:";
            this.lblNote.Click += new System.EventHandler(this.lblNote_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPrice.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtTotalPrice.Location = new System.Drawing.Point(154, 181);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(234, 38);
            this.txtTotalPrice.TabIndex = 10;
            // 
            // txtSupplier
            // 
            this.txtSupplier.BackColor = System.Drawing.Color.White;
            this.txtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupplier.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtSupplier.Location = new System.Drawing.Point(154, 139);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(234, 38);
            this.txtSupplier.TabIndex = 8;
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtDate.Location = new System.Drawing.Point(154, 97);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(234, 38);
            this.txtDate.TabIndex = 7;
            // 
            // txtIdBillOfWareHouse
            // 
            this.txtIdBillOfWareHouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdBillOfWareHouse.Font = new System.Drawing.Font("Cambria", 12F);
            this.txtIdBillOfWareHouse.Location = new System.Drawing.Point(154, 48);
            this.txtIdBillOfWareHouse.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdBillOfWareHouse.Name = "txtIdBillOfWareHouse";
            this.txtIdBillOfWareHouse.ReadOnly = true;
            this.txtIdBillOfWareHouse.Size = new System.Drawing.Size(234, 38);
            this.txtIdBillOfWareHouse.TabIndex = 6;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalPrice.Location = new System.Drawing.Point(2, 181);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(163, 37);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "Tổng tiền:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(2, 147);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(225, 37);
            this.lblSupplier.TabIndex = 13;
            this.lblSupplier.Text = "Nhà Cung Cấp:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(6, 97);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(182, 37);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Ngày Nhập:";
            // 
            // lblBillOfWareHouse
            // 
            this.lblBillOfWareHouse.AutoSize = true;
            this.lblBillOfWareHouse.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillOfWareHouse.ForeColor = System.Drawing.Color.White;
            this.lblBillOfWareHouse.Location = new System.Drawing.Point(6, 48);
            this.lblBillOfWareHouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBillOfWareHouse.Name = "lblBillOfWareHouse";
            this.lblBillOfWareHouse.Size = new System.Drawing.Size(198, 37);
            this.lblBillOfWareHouse.TabIndex = 9;
            this.lblBillOfWareHouse.Text = "Mã hóa đơn:";
            // 
            // lblBillInfo
            // 
            this.lblBillInfo.AutoSize = true;
            this.lblBillInfo.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.lblBillInfo.Location = new System.Drawing.Point(11, 3);
            this.lblBillInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBillInfo.Name = "lblBillInfo";
            this.lblBillInfo.Size = new System.Drawing.Size(239, 32);
            this.lblBillInfo.TabIndex = 0;
            this.lblBillInfo.Text = "Thông tin hóa đơn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lblBillDetail);
            this.panel2.Location = new System.Drawing.Point(827, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 44);
            this.panel2.TabIndex = 31;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblBillDetail
            // 
            this.lblBillDetail.AutoSize = true;
            this.lblBillDetail.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.lblBillDetail.Location = new System.Drawing.Point(12, 3);
            this.lblBillDetail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblBillDetail.Name = "lblBillDetail";
            this.lblBillDetail.Size = new System.Drawing.Size(208, 32);
            this.lblBillDetail.TabIndex = 0;
            this.lblBillDetail.Text = "Chi tiết hóa đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lblBillInfo);
            this.panel1.Location = new System.Drawing.Point(27, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 44);
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
            this.tpMaterial.Location = new System.Drawing.Point(8, 45);
            this.tpMaterial.Margin = new System.Windows.Forms.Padding(2);
            this.tpMaterial.Name = "tpMaterial";
            this.tpMaterial.Padding = new System.Windows.Forms.Padding(2);
            this.tpMaterial.Size = new System.Drawing.Size(808, 483);
            this.tpMaterial.TabIndex = 1;
            this.tpMaterial.Text = "Nguyên Liệu";
            // 
            // btnShowMaterial
            // 
            this.btnShowMaterial.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMaterial.Location = new System.Drawing.Point(253, 304);
            this.btnShowMaterial.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnShowMaterial.Name = "btnShowMaterial";
            this.btnShowMaterial.Size = new System.Drawing.Size(135, 41);
            this.btnShowMaterial.TabIndex = 22;
            this.btnShowMaterial.Text = "HIển thị";
            this.btnShowMaterial.UseVisualStyleBackColor = true;
            this.btnShowMaterial.Click += new System.EventHandler(this.btnShowMaterial_Click_1);
            // 
            // btnDeleteMaterial
            // 
            this.btnDeleteMaterial.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMaterial.Location = new System.Drawing.Point(253, 362);
            this.btnDeleteMaterial.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDeleteMaterial.Name = "btnDeleteMaterial";
            this.btnDeleteMaterial.Size = new System.Drawing.Size(135, 41);
            this.btnDeleteMaterial.TabIndex = 22;
            this.btnDeleteMaterial.Text = "Xóa";
            this.btnDeleteMaterial.UseVisualStyleBackColor = true;
            this.btnDeleteMaterial.Click += new System.EventHandler(this.btnDeleteMaterial_Click);
            // 
            // btnEditMaterial
            // 
            this.btnEditMaterial.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMaterial.Location = new System.Drawing.Point(107, 362);
            this.btnEditMaterial.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEditMaterial.Name = "btnEditMaterial";
            this.btnEditMaterial.Size = new System.Drawing.Size(135, 41);
            this.btnEditMaterial.TabIndex = 22;
            this.btnEditMaterial.Text = "Sửa";
            this.btnEditMaterial.UseVisualStyleBackColor = true;
            this.btnEditMaterial.Click += new System.EventHandler(this.btnEditMaterial_Click_1);
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMaterial.Location = new System.Drawing.Point(107, 304);
            this.btnAddMaterial.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(135, 41);
            this.btnAddMaterial.TabIndex = 21;
            this.btnAddMaterial.Text = "Thêm";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click_1);
            // 
            // lsvBillInfoOfWH
            // 
            this.lsvBillInfoOfWH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBillInfoOfWH.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBillInfoOfWH.GridLines = true;
            this.lsvBillInfoOfWH.HideSelection = false;
            this.lsvBillInfoOfWH.LabelEdit = true;
            this.lsvBillInfoOfWH.Location = new System.Drawing.Point(827, 69);
            this.lsvBillInfoOfWH.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lsvBillInfoOfWH.Name = "lsvBillInfoOfWH";
            this.lsvBillInfoOfWH.Size = new System.Drawing.Size(691, 820);
            this.lsvBillInfoOfWH.TabIndex = 34;
            this.lsvBillInfoOfWH.UseCompatibleStateImageBehavior = false;
            this.lsvBillInfoOfWH.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên nguyên liệu";
            this.columnHeader1.Width = 150;
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
            this.columnHeader4.Width = 140;
            // 
            // tclBill
            // 
            this.tclBill.Controls.Add(this.tpBillInfo);
            this.tclBill.Controls.Add(this.tpMaterial);
            this.tclBill.Controls.Add(this.tpUnit);
            this.tclBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tclBill.Location = new System.Drawing.Point(10, 361);
            this.tclBill.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tclBill.Name = "tclBill";
            this.tclBill.SelectedIndex = 0;
            this.tclBill.Size = new System.Drawing.Size(824, 536);
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
            this.tpBillInfo.Location = new System.Drawing.Point(8, 45);
            this.tpBillInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tpBillInfo.Name = "tpBillInfo";
            this.tpBillInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tpBillInfo.Size = new System.Drawing.Size(808, 483);
            this.tpBillInfo.TabIndex = 0;
            this.tpBillInfo.Text = "Chi tiết hóa đơn";
            this.tpBillInfo.UseVisualStyleBackColor = true;
            // 
            // btnAddBillInfo
            // 
            this.btnAddBillInfo.BackColor = System.Drawing.Color.DimGray;
            this.btnAddBillInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBillInfo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBillInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBillInfo.Location = new System.Drawing.Point(268, 355);
            this.btnAddBillInfo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddBillInfo.Name = "btnAddBillInfo";
            this.btnAddBillInfo.Size = new System.Drawing.Size(115, 49);
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
            this.panel9.Location = new System.Drawing.Point(2, 2);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(804, 57);
            this.panel9.TabIndex = 19;
            // 
            // lblAddMaterialInfo
            // 
            this.lblAddMaterialInfo.AutoSize = true;
            this.lblAddMaterialInfo.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMaterialInfo.ForeColor = System.Drawing.Color.White;
            this.lblAddMaterialInfo.Location = new System.Drawing.Point(44, 12);
            this.lblAddMaterialInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddMaterialInfo.Name = "lblAddMaterialInfo";
            this.lblAddMaterialInfo.Size = new System.Drawing.Size(417, 37);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 957);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsvBillInfoOfWH);
            this.Controls.Add(this.tclBill);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
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
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridView dgvMaterialList;
        private System.Windows.Forms.TabPage tpUnit;
        private System.Windows.Forms.DataGridView dgvUnitList;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.TextBox txtUnitID;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.Label lblUnitID;
        private System.Windows.Forms.ComboBox cmbMaterialName;
        private System.Windows.Forms.Panel pn1;
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
        private System.Windows.Forms.PrintPreviewDialog pddHoaDon;
        private System.Windows.Forms.Button btnSaveBillOfWH;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.Button btnShowMaterial;
        private System.Windows.Forms.Button btnDeleteMaterial;
        private System.Windows.Forms.Button btnEditMaterial;
        private System.Windows.Forms.Button btnShowUnit;
        private System.Windows.Forms.Button btnDeleteUnit;
        private System.Windows.Forms.Button btnEditUnit;
        private System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}