namespace TuLieuHocTap
{
    partial class SinhVien
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
            this.btn_TimGT = new System.Windows.Forms.Button();
            this.btx_Xuat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_NgaySinh = new System.Windows.Forms.TextBox();
            this.com_GioiTinh = new System.Windows.Forms.ComboBox();
            this.Lab_NgaySinh = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lab_Email = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lab_DiaChi = new System.Windows.Forms.Label();
            this.lab_GioiTinh = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lab_SDT = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lab_ID = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.lab_Ten = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btx_LamMoi = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_ThemSinhVien = new System.Windows.Forms.Button();
            this.btn_Tim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TimGT
            // 
            this.btn_TimGT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimGT.Image = global::TuLieuHocTap.Properties.Resources.TimKhoa32;
            this.btn_TimGT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimGT.Location = new System.Drawing.Point(724, 24);
            this.btn_TimGT.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_TimGT.Name = "btn_TimGT";
            this.btn_TimGT.Size = new System.Drawing.Size(160, 37);
            this.btn_TimGT.TabIndex = 43;
            this.btn_TimGT.Text = "Tìm theo giới tính";
            this.btn_TimGT.UseVisualStyleBackColor = true;
            this.btn_TimGT.Click += new System.EventHandler(this.btn_TimGT_Click);
            // 
            // btx_Xuat
            // 
            this.btx_Xuat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btx_Xuat.Image = global::TuLieuHocTap.Properties.Resources.XuatFile32;
            this.btx_Xuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btx_Xuat.Location = new System.Drawing.Point(894, 24);
            this.btx_Xuat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btx_Xuat.Name = "btx_Xuat";
            this.btx_Xuat.Size = new System.Drawing.Size(131, 37);
            this.btx_Xuat.TabIndex = 42;
            this.btx_Xuat.Text = "Xuất File";
            this.btx_Xuat.UseVisualStyleBackColor = true;
            this.btx_Xuat.Click += new System.EventHandler(this.btx_Xuat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.Ten,
            this.GioiTinh,
            this.SDT,
            this.Email,
            this.DiaChi});
            this.dataGridView1.Location = new System.Drawing.Point(352, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(678, 570);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "Mã sinh viên";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.Width = 150;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Họ và tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 150;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 150;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 130;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 150;
            // 
            // txt_Tim
            // 
            this.txt_Tim.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tim.Location = new System.Drawing.Point(388, 25);
            this.txt_Tim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(157, 32);
            this.txt_Tim.TabIndex = 40;
            this.txt_Tim.Text = "1234";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.txt_NgaySinh);
            this.groupBox3.Controls.Add(this.com_GioiTinh);
            this.groupBox3.Controls.Add(this.Lab_NgaySinh);
            this.groupBox3.Controls.Add(this.txt_Email);
            this.groupBox3.Controls.Add(this.lab_Email);
            this.groupBox3.Controls.Add(this.txt_DiaChi);
            this.groupBox3.Controls.Add(this.lab_DiaChi);
            this.groupBox3.Controls.Add(this.lab_GioiTinh);
            this.groupBox3.Controls.Add(this.txt_SDT);
            this.groupBox3.Controls.Add(this.lab_SDT);
            this.groupBox3.Controls.Add(this.txt_ID);
            this.groupBox3.Controls.Add(this.lab_ID);
            this.groupBox3.Controls.Add(this.txt_Ten);
            this.groupBox3.Controls.Add(this.lab_Ten);
            this.groupBox3.Controls.Add(this.btn_Luu);
            this.groupBox3.Controls.Add(this.btx_LamMoi);
            this.groupBox3.Controls.Add(this.btn_Reset);
            this.groupBox3.Controls.Add(this.btn_Sua);
            this.groupBox3.Controls.Add(this.btn_Xoa);
            this.groupBox3.Controls.Add(this.btn_ThemSinhVien);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(4, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(341, 730);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.Location = new System.Drawing.Point(108, 348);
            this.txt_NgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(175, 32);
            this.txt_NgaySinh.TabIndex = 54;
            this.txt_NgaySinh.Text = "1/1/2000";
            this.txt_NgaySinh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_NgaySinh_MouseDown);
            // 
            // com_GioiTinh
            // 
            this.com_GioiTinh.FormattingEnabled = true;
            this.com_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.com_GioiTinh.Location = new System.Drawing.Point(108, 150);
            this.com_GioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.com_GioiTinh.Name = "com_GioiTinh";
            this.com_GioiTinh.Size = new System.Drawing.Size(175, 32);
            this.com_GioiTinh.TabIndex = 53;
            this.com_GioiTinh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.com_GioiTinh_MouseDown);
            // 
            // Lab_NgaySinh
            // 
            this.Lab_NgaySinh.AutoSize = true;
            this.Lab_NgaySinh.Location = new System.Drawing.Point(17, 351);
            this.Lab_NgaySinh.Name = "Lab_NgaySinh";
            this.Lab_NgaySinh.Size = new System.Drawing.Size(96, 24);
            this.Lab_NgaySinh.TabIndex = 52;
            this.Lab_NgaySinh.Text = "Ngày sinh:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(108, 250);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(175, 32);
            this.txt_Email.TabIndex = 51;
            this.txt_Email.Text = "_@hutech.edu.vn";
            this.txt_Email.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_Email_MouseDown);
            // 
            // lab_Email
            // 
            this.lab_Email.AutoSize = true;
            this.lab_Email.Location = new System.Drawing.Point(17, 255);
            this.lab_Email.Name = "lab_Email";
            this.lab_Email.Size = new System.Drawing.Size(61, 24);
            this.lab_Email.TabIndex = 50;
            this.lab_Email.Text = "Email:";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(108, 295);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(175, 32);
            this.txt_DiaChi.TabIndex = 49;
            this.txt_DiaChi.Text = "TP HCM";
            this.txt_DiaChi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_DiaChi_MouseDown);
            // 
            // lab_DiaChi
            // 
            this.lab_DiaChi.AutoSize = true;
            this.lab_DiaChi.Location = new System.Drawing.Point(17, 302);
            this.lab_DiaChi.Name = "lab_DiaChi";
            this.lab_DiaChi.Size = new System.Drawing.Size(71, 24);
            this.lab_DiaChi.TabIndex = 48;
            this.lab_DiaChi.Text = "Địa chỉ:";
            // 
            // lab_GioiTinh
            // 
            this.lab_GioiTinh.AutoSize = true;
            this.lab_GioiTinh.Location = new System.Drawing.Point(17, 158);
            this.lab_GioiTinh.Name = "lab_GioiTinh";
            this.lab_GioiTinh.Size = new System.Drawing.Size(88, 24);
            this.lab_GioiTinh.TabIndex = 47;
            this.lab_GioiTinh.Text = "Giới tính:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(108, 206);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(175, 32);
            this.txt_SDT.TabIndex = 46;
            this.txt_SDT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_SDT_MouseDown);
            // 
            // lab_SDT
            // 
            this.lab_SDT.AutoSize = true;
            this.lab_SDT.Location = new System.Drawing.Point(17, 210);
            this.lab_SDT.Name = "lab_SDT";
            this.lab_SDT.Size = new System.Drawing.Size(45, 24);
            this.lab_SDT.TabIndex = 45;
            this.lab_SDT.Text = "SĐT:";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(108, 62);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(175, 32);
            this.txt_ID.TabIndex = 44;
            this.txt_ID.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_ID_MouseDown);
            // 
            // lab_ID
            // 
            this.lab_ID.AutoSize = true;
            this.lab_ID.Location = new System.Drawing.Point(17, 65);
            this.lab_ID.Name = "lab_ID";
            this.lab_ID.Size = new System.Drawing.Size(113, 24);
            this.lab_ID.TabIndex = 43;
            this.lab_ID.Text = "ID Sinh viên:";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(108, 108);
            this.txt_Ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(175, 32);
            this.txt_Ten.TabIndex = 42;
            this.txt_Ten.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_Ten_MouseDown);
            // 
            // lab_Ten
            // 
            this.lab_Ten.AutoSize = true;
            this.lab_Ten.Location = new System.Drawing.Point(17, 111);
            this.lab_Ten.Name = "lab_Ten";
            this.lab_Ten.Size = new System.Drawing.Size(44, 24);
            this.lab_Ten.TabIndex = 41;
            this.lab_Ten.Text = "Tên:";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Image = global::TuLieuHocTap.Properties.Resources.Luu32;
            this.btn_Luu.Location = new System.Drawing.Point(169, 543);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(111, 57);
            this.btn_Luu.TabIndex = 40;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btx_LamMoi
            // 
            this.btx_LamMoi.Image = global::TuLieuHocTap.Properties.Resources.LamMoi32;
            this.btx_LamMoi.Location = new System.Drawing.Point(19, 543);
            this.btx_LamMoi.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btx_LamMoi.Name = "btx_LamMoi";
            this.btx_LamMoi.Size = new System.Drawing.Size(117, 57);
            this.btx_LamMoi.TabIndex = 39;
            this.btx_LamMoi.Text = "Làm mới";
            this.btx_LamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btx_LamMoi.UseVisualStyleBackColor = true;
            this.btx_LamMoi.Click += new System.EventHandler(this.btx_LamMoi_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Image = global::TuLieuHocTap.Properties.Resources.Reset32;
            this.btn_Reset.Location = new System.Drawing.Point(171, 462);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(111, 57);
            this.btn_Reset.TabIndex = 36;
            this.btn_Reset.Text = "Reset Pass";
            this.btn_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::TuLieuHocTap.Properties.Resources.Sua32;
            this.btn_Sua.Location = new System.Drawing.Point(19, 462);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(117, 57);
            this.btn_Sua.TabIndex = 30;
            this.btn_Sua.Text = "Sửa thông tin";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::TuLieuHocTap.Properties.Resources.Xoa32;
            this.btn_Xoa.Location = new System.Drawing.Point(172, 395);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(111, 57);
            this.btn_Xoa.TabIndex = 29;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_ThemSinhVien
            // 
            this.btn_ThemSinhVien.Image = global::TuLieuHocTap.Properties.Resources.them32;
            this.btn_ThemSinhVien.Location = new System.Drawing.Point(19, 395);
            this.btn_ThemSinhVien.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_ThemSinhVien.Name = "btn_ThemSinhVien";
            this.btn_ThemSinhVien.Size = new System.Drawing.Size(117, 57);
            this.btn_ThemSinhVien.TabIndex = 19;
            this.btn_ThemSinhVien.Text = "Thêm";
            this.btn_ThemSinhVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ThemSinhVien.UseVisualStyleBackColor = true;
            this.btn_ThemSinhVien.Click += new System.EventHandler(this.btn_ThemSinhVien_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Image = global::TuLieuHocTap.Properties.Resources.Tim32;
            this.btn_Tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tim.Location = new System.Drawing.Point(554, 23);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(160, 34);
            this.btn_Tim.TabIndex = 38;
            this.btn_Tim.Text = "Tìm theo ID";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 744);
            this.Controls.Add(this.btn_TimGT);
            this.Controls.Add(this.btx_Xuat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Tim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Tim);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SinhVien";
            this.Text = "SinhVien";
            this.Load += new System.EventHandler(this.SinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TimGT;
        private System.Windows.Forms.Button btx_Xuat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btx_LamMoi;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_ThemSinhVien;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_NgaySinh;
        private System.Windows.Forms.ComboBox com_GioiTinh;
        private System.Windows.Forms.Label Lab_NgaySinh;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lab_Email;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lab_DiaChi;
        private System.Windows.Forms.Label lab_GioiTinh;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lab_SDT;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lab_ID;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Label lab_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
    }
}