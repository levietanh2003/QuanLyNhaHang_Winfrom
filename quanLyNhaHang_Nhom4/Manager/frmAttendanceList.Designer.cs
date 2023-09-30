namespace quanLyNhaHang_Nhom4.Manager
{
    partial class frmAttendanceList
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvDiemDanh = new System.Windows.Forms.DataGridView();
            this.dgv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTimeSheetsList = new System.Windows.Forms.Panel();
            this.lblTimeSheetsList = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDanh)).BeginInit();
            this.pnTimeSheetsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(904, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 957);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(194, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chấm công";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã NV :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(204, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 35);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(111, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 47);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thông Tin Nhân Viên";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(224, 332);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 35);
            this.textBox2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(76, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giới Tính :";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(224, 415);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 35);
            this.textBox3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(76, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chức Vụ :";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(224, 493);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(280, 35);
            this.textBox4.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(76, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày Sinh :";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(224, 574);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(280, 35);
            this.textBox5.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(76, 649);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "CCCD :";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(224, 646);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(280, 35);
            this.textBox6.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(76, 713);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "SĐT :";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(224, 710);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(280, 35);
            this.textBox7.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(76, 770);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "Địa Chỉ  :";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(224, 767);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(280, 35);
            this.textBox8.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(224, 852);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "Điểm danh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::quanLyNhaHang_Nhom4.Properties.Resources.low_vision_solid_24;
            this.button2.Location = new System.Drawing.Point(494, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 69);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvDiemDanh
            // 
            this.dgvDiemDanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_id,
            this.dgv_name,
            this.dgv_datetime});
            this.dgvDiemDanh.Location = new System.Drawing.Point(0, 112);
            this.dgvDiemDanh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDiemDanh.Name = "dgvDiemDanh";
            this.dgvDiemDanh.RowHeadersWidth = 51;
            this.dgvDiemDanh.RowTemplate.Height = 24;
            this.dgvDiemDanh.Size = new System.Drawing.Size(871, 825);
            this.dgvDiemDanh.TabIndex = 18;
            // 
            // dgv_id
            // 
            this.dgv_id.HeaderText = "Mã nhân viên";
            this.dgv_id.MinimumWidth = 6;
            this.dgv_id.Name = "dgv_id";
            this.dgv_id.Width = 150;
            // 
            // dgv_name
            // 
            this.dgv_name.HeaderText = "Tên nhân viên";
            this.dgv_name.MinimumWidth = 6;
            this.dgv_name.Name = "dgv_name";
            this.dgv_name.Width = 250;
            // 
            // dgv_datetime
            // 
            this.dgv_datetime.HeaderText = "Ngày điểm danh";
            this.dgv_datetime.MinimumWidth = 6;
            this.dgv_datetime.Name = "dgv_datetime";
            this.dgv_datetime.Width = 300;
            // 
            // pnTimeSheetsList
            // 
            this.pnTimeSheetsList.BackColor = System.Drawing.SystemColors.Menu;
            this.pnTimeSheetsList.Controls.Add(this.lblTimeSheetsList);
            this.pnTimeSheetsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTimeSheetsList.Location = new System.Drawing.Point(0, 0);
            this.pnTimeSheetsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnTimeSheetsList.Name = "pnTimeSheetsList";
            this.pnTimeSheetsList.Size = new System.Drawing.Size(871, 89);
            this.pnTimeSheetsList.TabIndex = 19;
            // 
            // lblTimeSheetsList
            // 
            this.lblTimeSheetsList.AutoSize = true;
            this.lblTimeSheetsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimeSheetsList.ForeColor = System.Drawing.Color.Black;
            this.lblTimeSheetsList.Location = new System.Drawing.Point(72, 17);
            this.lblTimeSheetsList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeSheetsList.Name = "lblTimeSheetsList";
            this.lblTimeSheetsList.Size = new System.Drawing.Size(474, 52);
            this.lblTimeSheetsList.TabIndex = 18;
            this.lblTimeSheetsList.Text = "Danh sách chấm công";
            // 
            // frmAttendanceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 957);
            this.Controls.Add(this.pnTimeSheetsList);
            this.Controls.Add(this.dgvDiemDanh);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAttendanceList";
            this.Text = "frmAttendanceList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDanh)).EndInit();
            this.pnTimeSheetsList.ResumeLayout(false);
            this.pnTimeSheetsList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_datetime;
        private System.Windows.Forms.Panel pnTimeSheetsList;
        private System.Windows.Forms.Label lblTimeSheetsList;
    }
}