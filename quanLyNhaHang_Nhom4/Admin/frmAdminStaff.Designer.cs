namespace quanLyNhaHang_Nhom4.Manager
{
    partial class frmAccount
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btntracuu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.txttracuunv = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbltongso = new System.Windows.Forms.Label();
            this.lblmanv = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.lblchucvu = new System.Windows.Forms.Label();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.lblcmnd = new System.Windows.Forms.Label();
            this.lblsdt = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblthongtinnv = new System.Windows.Forms.Label();
            this.btnreload = new System.Windows.Forms.Button();
            this.clm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmhovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmgioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmchucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(852, 637);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbltongso);
            this.panel1.Location = new System.Drawing.Point(12, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 28);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.btnreload);
            this.panel2.Controls.Add(this.lblthongtinnv);
            this.panel2.Controls.Add(this.lblmanv);
            this.panel2.Controls.Add(this.lblhoten);
            this.panel2.Controls.Add(this.lblgioitinh);
            this.panel2.Controls.Add(this.lblchucvu);
            this.panel2.Controls.Add(this.lblngaysinh);
            this.panel2.Controls.Add(this.lblcmnd);
            this.panel2.Controls.Add(this.lblsdt);
            this.panel2.Controls.Add(this.lbldiachi);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(840, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 637);
            this.panel2.TabIndex = 2;
            // 
            // btntracuu
            // 
            this.btntracuu.Location = new System.Drawing.Point(12, 83);
            this.btntracuu.Name = "btntracuu";
            this.btntracuu.Size = new System.Drawing.Size(143, 22);
            this.btntracuu.TabIndex = 3;
            this.btntracuu.Text = "Tra cứu nhân viên ";
            this.btntracuu.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(580, 589);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(90, 36);
            this.btnxoa.TabIndex = 5;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(331, 589);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(90, 36);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(452, 589);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(90, 36);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // txttracuunv
            // 
            this.txttracuunv.Location = new System.Drawing.Point(176, 83);
            this.txttracuunv.Name = "txttracuunv";
            this.txttracuunv.Size = new System.Drawing.Size(658, 22);
            this.txttracuunv.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 368);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(164, 416);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 118);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(164, 327);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 22);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(164, 120);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(161, 22);
            this.textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(164, 191);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(200, 22);
            this.textBox7.TabIndex = 14;
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(701, 589);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(90, 36);
            this.btnhienthi.TabIndex = 9;
            this.btnhienthi.Text = "Hiển thị ";
            this.btnhienthi.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 233);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm,
            this.clmhovaten,
            this.clmgioitinh,
            this.clmchucvu,
            this.clmngaysinh,
            this.clmcmnd,
            this.clmsdt,
            this.clmdiachi});
            this.dataGridView1.Location = new System.Drawing.Point(0, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(834, 377);
            this.dataGridView1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 280);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // lbltongso
            // 
            this.lbltongso.AutoSize = true;
            this.lbltongso.Location = new System.Drawing.Point(3, 6);
            this.lbltongso.Name = "lbltongso";
            this.lbltongso.Size = new System.Drawing.Size(120, 16);
            this.lbltongso.TabIndex = 11;
            this.lbltongso.Text = "Tổng số nhân viên ";
            this.lbltongso.Click += new System.EventHandler(this.lbltongso_Click);
            // 
            // lblmanv
            // 
            this.lblmanv.AutoSize = true;
            this.lblmanv.Location = new System.Drawing.Point(18, 120);
            this.lblmanv.Name = "lblmanv";
            this.lblmanv.Size = new System.Drawing.Size(89, 16);
            this.lblmanv.TabIndex = 15;
            this.lblmanv.Text = "Mã nhân viên ";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(18, 159);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(46, 16);
            this.lblhoten.TabIndex = 16;
            this.lblhoten.Text = "Họ tên";
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Location = new System.Drawing.Point(18, 197);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(57, 16);
            this.lblgioitinh.TabIndex = 17;
            this.lblgioitinh.Text = "Giới tính ";
            // 
            // lblchucvu
            // 
            this.lblchucvu.AutoSize = true;
            this.lblchucvu.Location = new System.Drawing.Point(18, 241);
            this.lblchucvu.Name = "lblchucvu";
            this.lblchucvu.Size = new System.Drawing.Size(54, 16);
            this.lblchucvu.TabIndex = 18;
            this.lblchucvu.Text = "Chức vụ";
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.AutoSize = true;
            this.lblngaysinh.Location = new System.Drawing.Point(18, 285);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(67, 16);
            this.lblngaysinh.TabIndex = 19;
            this.lblngaysinh.Text = "Ngày sinh";
            // 
            // lblcmnd
            // 
            this.lblcmnd.AutoSize = true;
            this.lblcmnd.Location = new System.Drawing.Point(18, 330);
            this.lblcmnd.Name = "lblcmnd";
            this.lblcmnd.Size = new System.Drawing.Size(47, 16);
            this.lblcmnd.TabIndex = 20;
            this.lblcmnd.Text = "CMND";
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Location = new System.Drawing.Point(18, 371);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(85, 16);
            this.lblsdt.TabIndex = 21;
            this.lblsdt.Text = "Số điện thoại";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(18, 416);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(50, 16);
            this.lbldiachi.TabIndex = 22;
            this.lbldiachi.Text = "Địa chỉ ";
            // 
            // lblthongtinnv
            // 
            this.lblthongtinnv.AutoSize = true;
            this.lblthongtinnv.Location = new System.Drawing.Point(14, 69);
            this.lblthongtinnv.Name = "lblthongtinnv";
            this.lblthongtinnv.Size = new System.Drawing.Size(125, 16);
            this.lblthongtinnv.TabIndex = 13;
            this.lblthongtinnv.Text = "Thông tin nhân viên ";
            // 
            // btnreload
            // 
            this.btnreload.Location = new System.Drawing.Point(331, 120);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(33, 22);
            this.btnreload.TabIndex = 23;
            this.btnreload.UseVisualStyleBackColor = true;
            // 
            // clm
            // 
            this.clm.HeaderText = "Mã nv";
            this.clm.MinimumWidth = 6;
            this.clm.Name = "clm";
            this.clm.ReadOnly = true;
            this.clm.Width = 85;
            // 
            // clmhovaten
            // 
            this.clmhovaten.HeaderText = "Họ và tên ";
            this.clmhovaten.MinimumWidth = 6;
            this.clmhovaten.Name = "clmhovaten";
            this.clmhovaten.ReadOnly = true;
            // 
            // clmgioitinh
            // 
            this.clmgioitinh.HeaderText = "Giới tính ";
            this.clmgioitinh.MinimumWidth = 6;
            this.clmgioitinh.Name = "clmgioitinh";
            this.clmgioitinh.ReadOnly = true;
            this.clmgioitinh.Width = 85;
            // 
            // clmchucvu
            // 
            this.clmchucvu.HeaderText = "Chức vụ";
            this.clmchucvu.MinimumWidth = 6;
            this.clmchucvu.Name = "clmchucvu";
            this.clmchucvu.ReadOnly = true;
            // 
            // clmngaysinh
            // 
            this.clmngaysinh.HeaderText = "Ngày sinh";
            this.clmngaysinh.MinimumWidth = 6;
            this.clmngaysinh.Name = "clmngaysinh";
            this.clmngaysinh.ReadOnly = true;
            // 
            // clmcmnd
            // 
            this.clmcmnd.HeaderText = "CMND";
            this.clmcmnd.MinimumWidth = 6;
            this.clmcmnd.Name = "clmcmnd";
            this.clmcmnd.ReadOnly = true;
            this.clmcmnd.Width = 90;
            // 
            // clmsdt
            // 
            this.clmsdt.HeaderText = "SĐT";
            this.clmsdt.MinimumWidth = 6;
            this.clmsdt.Name = "clmsdt";
            this.clmsdt.ReadOnly = true;
            // 
            // clmdiachi
            // 
            this.clmdiachi.HeaderText = "Địa chỉ ";
            this.clmdiachi.MinimumWidth = 6;
            this.clmdiachi.Name = "clmdiachi";
            this.clmdiachi.ReadOnly = true;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1236, 637);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.txttracuunv);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btntracuu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblmanv;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.Label lblchucvu;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.Label lblcmnd;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btntracuu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.TextBox txttracuunv;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbltongso;
        private System.Windows.Forms.Label lblthongtinnv;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmhovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmgioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmchucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdiachi;
    }
}