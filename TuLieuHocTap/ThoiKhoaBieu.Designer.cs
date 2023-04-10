namespace TuLieuHocTap
{
    partial class ThoiKhoaBieu
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
            this.lab_ID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Link = new System.Windows.Forms.TextBox();
            this.lab_Link = new System.Windows.Forms.Label();
            this.lab_Cahoc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_ThoiGian = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lab_Hong = new System.Windows.Forms.Label();
            this.cmb_PhongHoc = new System.Windows.Forms.ComboBox();
            this.cmb_MaLop = new System.Windows.Forms.ComboBox();
            this.cmb_TMH = new System.Windows.Forms.ComboBox();
            this.cmb_TenGV = new System.Windows.Forms.ComboBox();
            this.date_ThoiGian = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_TaoLink = new System.Windows.Forms.Button();
            this.cmb_CaHoc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_XuatFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkMeet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTKB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_ID
            // 
            this.lab_ID.AutoSize = true;
            this.lab_ID.Location = new System.Drawing.Point(6, 26);
            this.lab_ID.Name = "lab_ID";
            this.lab_ID.Size = new System.Drawing.Size(55, 19);
            this.lab_ID.TabIndex = 1;
            this.lab_ID.Text = "Mã lớp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenMon,
            this.ID,
            this.ThoiGianHoc,
            this.CaHoc,
            this.LinkMeet,
            this.PhongHoc,
            this.MaTKB,
            this.SoLuong});
            this.dataGridView1.Location = new System.Drawing.Point(390, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(630, 460);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_Link
            // 
            this.txt_Link.Location = new System.Drawing.Point(153, 199);
            this.txt_Link.Name = "txt_Link";
            this.txt_Link.Size = new System.Drawing.Size(92, 27);
            this.txt_Link.TabIndex = 7;
            this.txt_Link.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_Link_MouseDown);
            // 
            // lab_Link
            // 
            this.lab_Link.AutoSize = true;
            this.lab_Link.Location = new System.Drawing.Point(6, 197);
            this.lab_Link.Name = "lab_Link";
            this.lab_Link.Size = new System.Drawing.Size(123, 19);
            this.lab_Link.TabIndex = 6;
            this.lab_Link.Text = "Link Google Meet";
            // 
            // lab_Cahoc
            // 
            this.lab_Cahoc.AutoSize = true;
            this.lab_Cahoc.Location = new System.Drawing.Point(6, 171);
            this.lab_Cahoc.Name = "lab_Cahoc";
            this.lab_Cahoc.Size = new System.Drawing.Size(53, 19);
            this.lab_Cahoc.TabIndex = 10;
            this.lab_Cahoc.Text = "Ca học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã giảng viên";
            // 
            // lab_ThoiGian
            // 
            this.lab_ThoiGian.AutoSize = true;
            this.lab_ThoiGian.Location = new System.Drawing.Point(6, 139);
            this.lab_ThoiGian.Name = "lab_ThoiGian";
            this.lab_ThoiGian.Size = new System.Drawing.Size(70, 19);
            this.lab_ThoiGian.TabIndex = 23;
            this.lab_ThoiGian.Text = "Thời gian";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tên Môn học";
            // 
            // lab_Hong
            // 
            this.lab_Hong.AutoSize = true;
            this.lab_Hong.Location = new System.Drawing.Point(6, 235);
            this.lab_Hong.Name = "lab_Hong";
            this.lab_Hong.Size = new System.Drawing.Size(76, 19);
            this.lab_Hong.TabIndex = 27;
            this.lab_Hong.Text = "Phòng học";
            // 
            // cmb_PhongHoc
            // 
            this.cmb_PhongHoc.FormattingEnabled = true;
            this.cmb_PhongHoc.Items.AddRange(new object[] {
            "A.1.1",
            "A.1.2",
            "A.1.3",
            "A.1.4",
            "A.1.5",
            "A.2.1",
            "A.2.2",
            "A.2.3",
            "A.2.4",
            "A.2.5",
            "A.3.1",
            "A.3.2",
            "A.3.3",
            "A.3.4",
            "A.3.5"});
            this.cmb_PhongHoc.Location = new System.Drawing.Point(152, 235);
            this.cmb_PhongHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_PhongHoc.Name = "cmb_PhongHoc";
            this.cmb_PhongHoc.Size = new System.Drawing.Size(192, 27);
            this.cmb_PhongHoc.TabIndex = 28;
            this.cmb_PhongHoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmb_PhongHoc_MouseDown);
            // 
            // cmb_MaLop
            // 
            this.cmb_MaLop.FormattingEnabled = true;
            this.cmb_MaLop.Location = new System.Drawing.Point(152, 18);
            this.cmb_MaLop.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_MaLop.Name = "cmb_MaLop";
            this.cmb_MaLop.Size = new System.Drawing.Size(192, 27);
            this.cmb_MaLop.TabIndex = 29;
            this.cmb_MaLop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_MaLop_KeyDown);
            this.cmb_MaLop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_MaLop_MouseClick);
            this.cmb_MaLop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmb_MaLop_MouseDown);
            // 
            // cmb_TMH
            // 
            this.cmb_TMH.FormattingEnabled = true;
            this.cmb_TMH.Location = new System.Drawing.Point(153, 57);
            this.cmb_TMH.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_TMH.Name = "cmb_TMH";
            this.cmb_TMH.Size = new System.Drawing.Size(192, 27);
            this.cmb_TMH.TabIndex = 30;
            // 
            // cmb_TenGV
            // 
            this.cmb_TenGV.FormattingEnabled = true;
            this.cmb_TenGV.Location = new System.Drawing.Point(152, 94);
            this.cmb_TenGV.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_TenGV.Name = "cmb_TenGV";
            this.cmb_TenGV.Size = new System.Drawing.Size(192, 27);
            this.cmb_TenGV.TabIndex = 31;
            // 
            // date_ThoiGian
            // 
            this.date_ThoiGian.Location = new System.Drawing.Point(152, 131);
            this.date_ThoiGian.Name = "date_ThoiGian";
            this.date_ThoiGian.Size = new System.Drawing.Size(192, 27);
            this.date_ThoiGian.TabIndex = 34;
            this.date_ThoiGian.Text = "1/10/2022";
            this.date_ThoiGian.MouseDown += new System.Windows.Forms.MouseEventHandler(this.date_ThoiGian_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Tim);
            this.groupBox1.Controls.Add(this.btn_LamMoi);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 211);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::TuLieuHocTap.Properties.Resources.ThemTL32;
            this.btn_Them.Location = new System.Drawing.Point(20, 26);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(126, 49);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Image = global::TuLieuHocTap.Properties.Resources.Luu32;
            this.btn_Luu.Location = new System.Drawing.Point(205, 87);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(126, 49);
            this.btn_Luu.TabIndex = 15;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::TuLieuHocTap.Properties.Resources.Xoa32;
            this.btn_Xoa.Location = new System.Drawing.Point(205, 26);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(126, 49);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = global::TuLieuHocTap.Properties.Resources.Sua32;
            this.btn_Sua.Location = new System.Drawing.Point(20, 87);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(126, 49);
            this.btn_Sua.TabIndex = 21;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Image = global::TuLieuHocTap.Properties.Resources.Tim32;
            this.btn_Tim.Location = new System.Drawing.Point(205, 150);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(126, 49);
            this.btn_Tim.TabIndex = 33;
            this.btn_Tim.Text = "Tìm kiếm";
            this.btn_Tim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Image = global::TuLieuHocTap.Properties.Resources.LamMoi32;
            this.btn_LamMoi.Location = new System.Drawing.Point(20, 150);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(126, 49);
            this.btn_LamMoi.TabIndex = 32;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_SoLuong);
            this.groupBox2.Controls.Add(this.btn_TaoLink);
            this.groupBox2.Controls.Add(this.cmb_CaHoc);
            this.groupBox2.Controls.Add(this.lab_ID);
            this.groupBox2.Controls.Add(this.lab_Link);
            this.groupBox2.Controls.Add(this.txt_Link);
            this.groupBox2.Controls.Add(this.date_ThoiGian);
            this.groupBox2.Controls.Add(this.lab_Cahoc);
            this.groupBox2.Controls.Add(this.cmb_TenGV);
            this.groupBox2.Controls.Add(this.cmb_TMH);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmb_MaLop);
            this.groupBox2.Controls.Add(this.lab_ThoiGian);
            this.groupBox2.Controls.Add(this.cmb_PhongHoc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lab_Hong);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 303);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // btn_TaoLink
            // 
            this.btn_TaoLink.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoLink.Image = global::TuLieuHocTap.Properties.Resources.tao32;
            this.btn_TaoLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaoLink.Location = new System.Drawing.Point(251, 199);
            this.btn_TaoLink.Name = "btn_TaoLink";
            this.btn_TaoLink.Size = new System.Drawing.Size(93, 27);
            this.btn_TaoLink.TabIndex = 40;
            this.btn_TaoLink.Text = "Tạo";
            this.btn_TaoLink.UseVisualStyleBackColor = true;
            this.btn_TaoLink.Click += new System.EventHandler(this.btn_TaoLink_Click);
            // 
            // cmb_CaHoc
            // 
            this.cmb_CaHoc.FormattingEnabled = true;
            this.cmb_CaHoc.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            ""});
            this.cmb_CaHoc.Location = new System.Drawing.Point(152, 163);
            this.cmb_CaHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_CaHoc.Name = "cmb_CaHoc";
            this.cmb_CaHoc.Size = new System.Drawing.Size(192, 27);
            this.cmb_CaHoc.TabIndex = 35;
            this.cmb_CaHoc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmb_CaHoc_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(617, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 26);
            this.label8.TabIndex = 39;
            this.label8.Text = "Thông tin lịch học";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatFile.Image = global::TuLieuHocTap.Properties.Resources.XuatFile32;
            this.btn_XuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XuatFile.Location = new System.Drawing.Point(902, 27);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(103, 27);
            this.btn_XuatFile.TabIndex = 36;
            this.btn_XuatFile.Text = "Xuất File";
            this.btn_XuatFile.UseVisualStyleBackColor = true;
            this.btn_XuatFile.Click += new System.EventHandler(this.btn_XuatFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Số lượng ";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.AccessibleRole = System.Windows.Forms.AccessibleRole.Diagram;
            this.txt_SoLuong.Location = new System.Drawing.Point(153, 271);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(192, 27);
            this.txt_SoLuong.TabIndex = 42;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 115;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên môn học";
            this.TenMon.Name = "TenMon";
            this.TenMon.Width = 150;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã giảng viên";
            this.ID.Name = "ID";
            this.ID.Width = 135;
            // 
            // ThoiGianHoc
            // 
            this.ThoiGianHoc.DataPropertyName = "ThoiGianHoc";
            this.ThoiGianHoc.HeaderText = "Ngày học";
            this.ThoiGianHoc.Name = "ThoiGianHoc";
            this.ThoiGianHoc.Width = 130;
            // 
            // CaHoc
            // 
            this.CaHoc.DataPropertyName = "CaHoc";
            this.CaHoc.HeaderText = "Ca học";
            this.CaHoc.Name = "CaHoc";
            this.CaHoc.Width = 115;
            // 
            // LinkMeet
            // 
            this.LinkMeet.DataPropertyName = "LinkMeet";
            this.LinkMeet.HeaderText = "Link Meet";
            this.LinkMeet.Name = "LinkMeet";
            this.LinkMeet.Width = 130;
            // 
            // PhongHoc
            // 
            this.PhongHoc.DataPropertyName = "PhongHoc";
            this.PhongHoc.HeaderText = "Phòng";
            this.PhongHoc.Name = "PhongHoc";
            // 
            // MaTKB
            // 
            this.MaTKB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaTKB.DataPropertyName = "MaTKB";
            this.MaTKB.HeaderText = "ID TKB";
            this.MaTKB.Name = "MaTKB";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // ThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 534);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_XuatFile);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThoiKhoaBieu";
            this.RightToLeftLayout = true;
            this.Text = "ThoiKhoaBieu";
            this.Load += new System.EventHandler(this.ThoiKhoaBieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lab_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Link;
        private System.Windows.Forms.Label lab_Link;
        private System.Windows.Forms.Label lab_Cahoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label lab_ThoiGian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lab_Hong;
        private System.Windows.Forms.ComboBox cmb_PhongHoc;
        private System.Windows.Forms.ComboBox cmb_MaLop;
        private System.Windows.Forms.ComboBox cmb_TMH;
        private System.Windows.Forms.ComboBox cmb_TenGV;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox date_ThoiGian;
        private System.Windows.Forms.Button btn_XuatFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_CaHoc;
        private System.Windows.Forms.Button btn_TaoLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkMeet;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTKB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}