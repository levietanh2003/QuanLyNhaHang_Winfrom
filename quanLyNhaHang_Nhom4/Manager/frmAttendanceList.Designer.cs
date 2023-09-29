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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendanceList));
            this.pnTimeSheetsList = new System.Windows.Forms.Panel();
            this.lblTimeSheetsList = new System.Windows.Forms.Label();
            this.dgvAttendanceList = new System.Windows.Forms.DataGridView();
            this.dgv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnInfoStaff = new System.Windows.Forms.Panel();
            this.btnFindStaff = new FontAwesome.Sharp.IconButton();
            this.btnRollUp = new System.Windows.Forms.Button();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtIdentityCard = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblIdentityCard = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblStaffInfo = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblTimeSheets = new System.Windows.Forms.Label();
            this.pnTimeSheetsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceList)).BeginInit();
            this.pnInfoStaff.SuspendLayout();
            this.SuspendLayout();
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
            this.pnTimeSheetsList.TabIndex = 13;
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
            // dgvAttendanceList
            // 
            this.dgvAttendanceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttendanceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_id,
            this.dgv_name,
            this.dgv_datetime});
            this.dgvAttendanceList.Location = new System.Drawing.Point(0, 112);
            this.dgvAttendanceList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAttendanceList.Name = "dgvAttendanceList";
            this.dgvAttendanceList.RowHeadersWidth = 51;
            this.dgvAttendanceList.RowTemplate.Height = 24;
            this.dgvAttendanceList.Size = new System.Drawing.Size(871, 826);
            this.dgvAttendanceList.TabIndex = 14;
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
            // pnInfoStaff
            // 
            this.pnInfoStaff.BackColor = System.Drawing.Color.DimGray;
            this.pnInfoStaff.Controls.Add(this.btnFindStaff);
            this.pnInfoStaff.Controls.Add(this.btnRollUp);
            this.pnInfoStaff.Controls.Add(this.txtAdress);
            this.pnInfoStaff.Controls.Add(this.txtPhoneNumber);
            this.pnInfoStaff.Controls.Add(this.txtIdentityCard);
            this.pnInfoStaff.Controls.Add(this.txtDateOfBirth);
            this.pnInfoStaff.Controls.Add(this.txtPosition);
            this.pnInfoStaff.Controls.Add(this.lblAdress);
            this.pnInfoStaff.Controls.Add(this.lblPhoneNumber);
            this.pnInfoStaff.Controls.Add(this.lblIdentityCard);
            this.pnInfoStaff.Controls.Add(this.lblDateOfBirth);
            this.pnInfoStaff.Controls.Add(this.lblPosition);
            this.pnInfoStaff.Controls.Add(this.txtSex);
            this.pnInfoStaff.Controls.Add(this.lblSex);
            this.pnInfoStaff.Controls.Add(this.txtStaffName);
            this.pnInfoStaff.Controls.Add(this.lblStaffName);
            this.pnInfoStaff.Controls.Add(this.lblStaffInfo);
            this.pnInfoStaff.Controls.Add(this.txtStaffID);
            this.pnInfoStaff.Controls.Add(this.lblStaffID);
            this.pnInfoStaff.Controls.Add(this.lblTimeSheets);
            this.pnInfoStaff.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnInfoStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnInfoStaff.Location = new System.Drawing.Point(903, 0);
            this.pnInfoStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnInfoStaff.Name = "pnInfoStaff";
            this.pnInfoStaff.Size = new System.Drawing.Size(625, 958);
            this.pnInfoStaff.TabIndex = 15;
            // 
            // btnFindStaff
            // 
            this.btnFindStaff.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnFindStaff.IconColor = System.Drawing.Color.Black;
            this.btnFindStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindStaff.Location = new System.Drawing.Point(508, 112);
            this.btnFindStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFindStaff.Name = "btnFindStaff";
            this.btnFindStaff.Size = new System.Drawing.Size(103, 70);
            this.btnFindStaff.TabIndex = 19;
            this.btnFindStaff.UseVisualStyleBackColor = true;
            // 
            // btnRollUp
            // 
            this.btnRollUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRollUp.Image = ((System.Drawing.Image)(resources.GetObject("btnRollUp.Image")));
            this.btnRollUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRollUp.Location = new System.Drawing.Point(253, 779);
            this.btnRollUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRollUp.Name = "btnRollUp";
            this.btnRollUp.Size = new System.Drawing.Size(206, 91);
            this.btnRollUp.TabIndex = 18;
            this.btnRollUp.Text = "Điểm danh";
            this.btnRollUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRollUp.UseVisualStyleBackColor = true;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(214, 701);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(314, 29);
            this.txtAdress.TabIndex = 17;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(214, 630);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(314, 29);
            this.txtPhoneNumber.TabIndex = 16;
            // 
            // txtIdentityCard
            // 
            this.txtIdentityCard.Location = new System.Drawing.Point(214, 551);
            this.txtIdentityCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdentityCard.Name = "txtIdentityCard";
            this.txtIdentityCard.Size = new System.Drawing.Size(314, 29);
            this.txtIdentityCard.TabIndex = 15;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(214, 496);
            this.txtDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(314, 29);
            this.txtDateOfBirth.TabIndex = 14;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(214, 431);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(314, 29);
            this.txtPosition.TabIndex = 13;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblAdress.ForeColor = System.Drawing.Color.White;
            this.lblAdress.Location = new System.Drawing.Point(25, 701);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(149, 37);
            this.lblAdress.TabIndex = 12;
            this.lblAdress.Text = "Địa Chỉ  :";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(25, 630);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(99, 37);
            this.lblPhoneNumber.TabIndex = 11;
            this.lblPhoneNumber.Text = "SĐT :";
            // 
            // lblIdentityCard
            // 
            this.lblIdentityCard.AutoSize = true;
            this.lblIdentityCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIdentityCard.ForeColor = System.Drawing.Color.White;
            this.lblIdentityCard.Location = new System.Drawing.Point(25, 551);
            this.lblIdentityCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentityCard.Name = "lblIdentityCard";
            this.lblIdentityCard.Size = new System.Drawing.Size(127, 37);
            this.lblIdentityCard.TabIndex = 10;
            this.lblIdentityCard.Text = "CCCD :";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirth.Location = new System.Drawing.Point(18, 489);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(183, 37);
            this.lblDateOfBirth.TabIndex = 9;
            this.lblDateOfBirth.Text = "Ngày Sinh :";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(18, 424);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(159, 37);
            this.lblPosition.TabIndex = 8;
            this.lblPosition.Text = "Chức Vụ :";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(214, 358);
            this.txtSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(171, 29);
            this.txtSex.TabIndex = 7;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSex.ForeColor = System.Drawing.Color.White;
            this.lblSex.Location = new System.Drawing.Point(18, 358);
            this.lblSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(164, 37);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "Giới Tính :";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(214, 298);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(314, 29);
            this.txtStaffName.TabIndex = 5;
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStaffName.ForeColor = System.Drawing.Color.White;
            this.lblStaffName.Location = new System.Drawing.Point(18, 290);
            this.lblStaffName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(140, 37);
            this.lblStaffName.TabIndex = 4;
            this.lblStaffName.Text = "Họ Tên :";
            // 
            // lblStaffInfo
            // 
            this.lblStaffInfo.AutoSize = true;
            this.lblStaffInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStaffInfo.ForeColor = System.Drawing.Color.White;
            this.lblStaffInfo.Location = new System.Drawing.Point(123, 200);
            this.lblStaffInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffInfo.Name = "lblStaffInfo";
            this.lblStaffInfo.Size = new System.Drawing.Size(452, 52);
            this.lblStaffInfo.TabIndex = 3;
            this.lblStaffInfo.Text = "Thông Tin Nhân Viên";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(174, 128);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(259, 29);
            this.txtStaffID.TabIndex = 2;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStaffID.ForeColor = System.Drawing.Color.White;
            this.lblStaffID.Location = new System.Drawing.Point(14, 128);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(134, 37);
            this.lblStaffID.TabIndex = 1;
            this.lblStaffID.Text = "Mã NV :";
            // 
            // lblTimeSheets
            // 
            this.lblTimeSheets.AutoSize = true;
            this.lblTimeSheets.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimeSheets.ForeColor = System.Drawing.Color.White;
            this.lblTimeSheets.Location = new System.Drawing.Point(205, 17);
            this.lblTimeSheets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeSheets.Name = "lblTimeSheets";
            this.lblTimeSheets.Size = new System.Drawing.Size(254, 52);
            this.lblTimeSheets.TabIndex = 0;
            this.lblTimeSheets.Text = "Chấm công";
            // 
            // frmAttendanceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 958);
            this.Controls.Add(this.pnInfoStaff);
            this.Controls.Add(this.dgvAttendanceList);
            this.Controls.Add(this.pnTimeSheetsList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAttendanceList";
            this.Text = "frmAttendanceList";
            this.pnTimeSheetsList.ResumeLayout(false);
            this.pnTimeSheetsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceList)).EndInit();
            this.pnInfoStaff.ResumeLayout(false);
            this.pnInfoStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTimeSheetsList;
        private System.Windows.Forms.Label lblTimeSheetsList;
        private System.Windows.Forms.DataGridView dgvAttendanceList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_datetime;
        private System.Windows.Forms.Panel pnInfoStaff;
        private System.Windows.Forms.Button btnRollUp;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtIdentityCard;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblIdentityCard;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblStaffInfo;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblTimeSheets;
        private FontAwesome.Sharp.IconButton btnFindStaff;
    }
}