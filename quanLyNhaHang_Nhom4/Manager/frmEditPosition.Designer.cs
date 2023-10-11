using System;

namespace quanLyNhaHang_Nhom4.Manager
{
    partial class frmEditPosition
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.btnShowPosition = new System.Windows.Forms.Button();
            this.txtPositionName = new System.Windows.Forms.TextBox();
            this.btnEditPosition = new System.Windows.Forms.Button();
            this.btnDeletePosition = new System.Windows.Forms.Button();
            this.txtPositionID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.lblMaban = new System.Windows.Forms.Label();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.dgvPosition = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalPosition = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolstripTim = new System.Windows.Forms.ToolStripLabel();
            this.txtFindPositionByName = new System.Windows.Forms.ToolStripTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.ptbExit);
            this.panel1.Controls.Add(this.btnShowPosition);
            this.panel1.Controls.Add(this.txtPositionName);
            this.panel1.Controls.Add(this.btnEditPosition);
            this.panel1.Controls.Add(this.btnDeletePosition);
            this.panel1.Controls.Add(this.txtPositionID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddPosition);
            this.panel1.Controls.Add(this.lblMaban);
            this.panel1.Controls.Add(this.lblThongtin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(800, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 873);
            this.panel1.TabIndex = 0;
            // 
            // ptbExit
            // 
            this.ptbExit.BackColor = System.Drawing.Color.Transparent;
            this.ptbExit.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.exit_solid_24;
            this.ptbExit.Location = new System.Drawing.Point(395, 778);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(58, 58);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbExit.TabIndex = 10;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // btnShowPosition
            // 
            this.btnShowPosition.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPosition.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.bx_show_icon;
            this.btnShowPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowPosition.Location = new System.Drawing.Point(301, 607);
            this.btnShowPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowPosition.Name = "btnShowPosition";
            this.btnShowPosition.Size = new System.Drawing.Size(171, 76);
            this.btnShowPosition.TabIndex = 4;
            this.btnShowPosition.Text = "Hiển thị";
            this.btnShowPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowPosition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowPosition.UseVisualStyleBackColor = true;
            this.btnShowPosition.Click += new System.EventHandler(this.btnShowPosition_Click);
            // 
            // txtPositionName
            // 
            this.txtPositionName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPositionName.Location = new System.Drawing.Point(214, 344);
            this.txtPositionName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPositionName.Name = "txtPositionName";
            this.txtPositionName.Size = new System.Drawing.Size(258, 36);
            this.txtPositionName.TabIndex = 8;
            // 
            // btnEditPosition
            // 
            this.btnEditPosition.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPosition.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Pencil_icon;
            this.btnEditPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPosition.Location = new System.Drawing.Point(301, 482);
            this.btnEditPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditPosition.Name = "btnEditPosition";
            this.btnEditPosition.Size = new System.Drawing.Size(171, 76);
            this.btnEditPosition.TabIndex = 1;
            this.btnEditPosition.Text = "Sửa";
            this.btnEditPosition.UseVisualStyleBackColor = true;
            this.btnEditPosition.Click += new System.EventHandler(this.btnEditPosition_Click);
            // 
            // btnDeletePosition
            // 
            this.btnDeletePosition.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePosition.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Close_2_icon;
            this.btnDeletePosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePosition.Location = new System.Drawing.Point(35, 607);
            this.btnDeletePosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeletePosition.Name = "btnDeletePosition";
            this.btnDeletePosition.Size = new System.Drawing.Size(171, 76);
            this.btnDeletePosition.TabIndex = 2;
            this.btnDeletePosition.Text = "Xóa";
            this.btnDeletePosition.UseVisualStyleBackColor = true;
            this.btnDeletePosition.Click += new System.EventHandler(this.btnDeletePosition_Click);
            // 
            // txtPositionID
            // 
            this.txtPositionID.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPositionID.Location = new System.Drawing.Point(214, 270);
            this.txtPositionID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPositionID.Name = "txtPositionID";
            this.txtPositionID.ReadOnly = true;
            this.txtPositionID.Size = new System.Drawing.Size(258, 36);
            this.txtPositionID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên Chức Vụ";
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPosition.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.Actions_list_add_icon;
            this.btnAddPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPosition.Location = new System.Drawing.Point(35, 482);
            this.btnAddPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(171, 76);
            this.btnAddPosition.TabIndex = 0;
            this.btnAddPosition.Text = "Thêm";
            this.btnAddPosition.UseVisualStyleBackColor = true;
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
            // 
            // lblMaban
            // 
            this.lblMaban.AutoSize = true;
            this.lblMaban.BackColor = System.Drawing.Color.DimGray;
            this.lblMaban.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaban.ForeColor = System.Drawing.Color.White;
            this.lblMaban.Location = new System.Drawing.Point(29, 270);
            this.lblMaban.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaban.Name = "lblMaban";
            this.lblMaban.Size = new System.Drawing.Size(89, 32);
            this.lblMaban.TabIndex = 7;
            this.lblMaban.Text = "Mã CV";
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Font = new System.Drawing.Font("Cambria", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtin.ForeColor = System.Drawing.Color.White;
            this.lblThongtin.Location = new System.Drawing.Point(123, 155);
            this.lblThongtin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(472, 63);
            this.lblThongtin.TabIndex = 2;
            this.lblThongtin.Text = "Thông tin chức vụ";
            // 
            // dgvPosition
            // 
            this.dgvPosition.AllowUserToAddRows = false;
            this.dgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPosition.Location = new System.Drawing.Point(0, 115);
            this.dgvPosition.Name = "dgvPosition";
            this.dgvPosition.ReadOnly = true;
            this.dgvPosition.RowHeadersWidth = 82;
            this.dgvPosition.RowTemplate.Height = 33;
            this.dgvPosition.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPosition.Size = new System.Drawing.Size(717, 687);
            this.dgvPosition.TabIndex = 1;
            this.dgvPosition.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPosition_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã CV";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Chức Vụ";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblTotalPosition);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 53);
            this.panel2.TabIndex = 18;
            // 
            // lblTotalPosition
            // 
            this.lblTotalPosition.AutoSize = true;
            this.lblTotalPosition.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPosition.Location = new System.Drawing.Point(19, 13);
            this.lblTotalPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPosition.Name = "lblTotalPosition";
            this.lblTotalPosition.Size = new System.Drawing.Size(186, 32);
            this.lblTotalPosition.TabIndex = 3;
            this.lblTotalPosition.Text = "Tổng chức vụ:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolstripTim,
            this.txtFindPositionByName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(514, 43);
            this.toolStrip1.TabIndex = 17;
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
            this.toolstripTim.Size = new System.Drawing.Size(241, 37);
            this.toolstripTim.Text = "Tìm kiếm chức vụ";
            // 
            // txtFindPositionByName
            // 
            this.txtFindPositionByName.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindPositionByName.Name = "txtFindPositionByName";
            this.txtFindPositionByName.Size = new System.Drawing.Size(200, 43);
            this.txtFindPositionByName.TextChanged += new System.EventHandler(this.txtFindPositionByName_TextChanged);
            // 
            // frmEditPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1321, 873);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvPosition);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1321, 873);
            this.MinimumSize = new System.Drawing.Size(1321, 873);
            this.Name = "frmEditPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Chức Vụ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosition)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblThongtin;
        private System.Windows.Forms.TextBox txtPositionName;
        private System.Windows.Forms.TextBox txtPositionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaban;
        private System.Windows.Forms.DataGridView dgvPosition;
        private System.Windows.Forms.Button btnShowPosition;
        private System.Windows.Forms.Button btnEditPosition;
        private System.Windows.Forms.Button btnDeletePosition;
        private System.Windows.Forms.Button btnAddPosition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalPosition;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolstripTim;
        private System.Windows.Forms.ToolStripTextBox txtFindPositionByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.PictureBox ptbExit;
    }
}