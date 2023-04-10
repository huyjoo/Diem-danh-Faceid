namespace TuLieuHocTap
{
    partial class DangKyMonHoc
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_tim = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.lab_MSSV = new System.Windows.Forms.Label();
            this.lab_Ten = new System.Windows.Forms.Label();
            this.lab_MaGiangVien = new System.Windows.Forms.Label();
            this.lab_MaLop = new System.Windows.Forms.Label();
            this.Lab_TenMonHoc = new System.Windows.Forms.Label();
            this.lab_CaHoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_DangKi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_Dangky = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lab_DangKy = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lab_SoLuong = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lab_Phong = new System.Windows.Forms.Label();
            this.ThoiGian_Hoc = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Xuat2 = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lab_Malop_xoa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MaLop2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cahoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenMon,
            this.Cahoc,
            this.ID,
            this.ThoiGian,
            this.PhongHoc,
            this.SoLuong});
            this.dataGridView1.Location = new System.Drawing.Point(17, 148);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_tim
            // 
            this.txt_tim.Location = new System.Drawing.Point(18, 107);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.Size = new System.Drawing.Size(242, 27);
            this.txt_tim.TabIndex = 3;
            this.txt_tim.Text = "Nhập tên môn học";
            this.txt_tim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tim_KeyDown);
            // 
            // btn_Tim
            // 
            this.btn_Tim.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Tim.Image = global::TuLieuHocTap.Properties.Resources.Tim32;
            this.btn_Tim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tim.Location = new System.Drawing.Point(264, 98);
            this.btn_Tim.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(116, 42);
            this.btn_Tim.TabIndex = 3;
            this.btn_Tim.Text = "Tìm kiếm";
            this.btn_Tim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Tim.UseVisualStyleBackColor = false;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // lab_MSSV
            // 
            this.lab_MSSV.AutoSize = true;
            this.lab_MSSV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_MSSV.Location = new System.Drawing.Point(16, 23);
            this.lab_MSSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_MSSV.Name = "lab_MSSV";
            this.lab_MSSV.Size = new System.Drawing.Size(52, 19);
            this.lab_MSSV.TabIndex = 4;
            this.lab_MSSV.Text = "MSSV:";
            // 
            // lab_Ten
            // 
            this.lab_Ten.AutoSize = true;
            this.lab_Ten.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Ten.Location = new System.Drawing.Point(16, 55);
            this.lab_Ten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Ten.Name = "lab_Ten";
            this.lab_Ten.Size = new System.Drawing.Size(37, 19);
            this.lab_Ten.TabIndex = 5;
            this.lab_Ten.Text = "Tên:";
            // 
            // lab_MaGiangVien
            // 
            this.lab_MaGiangVien.AutoSize = true;
            this.lab_MaGiangVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_MaGiangVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab_MaGiangVien.Location = new System.Drawing.Point(264, 55);
            this.lab_MaGiangVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_MaGiangVien.Name = "lab_MaGiangVien";
            this.lab_MaGiangVien.Size = new System.Drawing.Size(118, 19);
            this.lab_MaGiangVien.TabIndex = 7;
            this.lab_MaGiangVien.Text = "MÃ GIẢNG VIÊN";
            // 
            // lab_MaLop
            // 
            this.lab_MaLop.AutoSize = true;
            this.lab_MaLop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_MaLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab_MaLop.Location = new System.Drawing.Point(264, 23);
            this.lab_MaLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_MaLop.Name = "lab_MaLop";
            this.lab_MaLop.Size = new System.Drawing.Size(99, 19);
            this.lab_MaLop.TabIndex = 6;
            this.lab_MaLop.Text = "Mã học phần";
            // 
            // Lab_TenMonHoc
            // 
            this.Lab_TenMonHoc.AutoSize = true;
            this.Lab_TenMonHoc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_TenMonHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lab_TenMonHoc.Location = new System.Drawing.Point(743, 23);
            this.Lab_TenMonHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lab_TenMonHoc.Name = "Lab_TenMonHoc";
            this.Lab_TenMonHoc.Size = new System.Drawing.Size(135, 19);
            this.Lab_TenMonHoc.TabIndex = 8;
            this.Lab_TenMonHoc.Text = "Tên Môn Môn Học";
            // 
            // lab_CaHoc
            // 
            this.lab_CaHoc.AutoSize = true;
            this.lab_CaHoc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_CaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab_CaHoc.Location = new System.Drawing.Point(516, 55);
            this.lab_CaHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_CaHoc.Name = "lab_CaHoc";
            this.lab_CaHoc.Size = new System.Drawing.Size(55, 19);
            this.lab_CaHoc.TabIndex = 9;
            this.lab_CaHoc.Text = "Ca Học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ca học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(638, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên môn học:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã giảng viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã Lớp:";
            // 
            // btn_DangKi
            // 
            this.btn_DangKi.Image = global::TuLieuHocTap.Properties.Resources.Luu32;
            this.btn_DangKi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DangKi.Location = new System.Drawing.Point(445, 98);
            this.btn_DangKi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DangKi.Name = "btn_DangKi";
            this.btn_DangKi.Size = new System.Drawing.Size(127, 44);
            this.btn_DangKi.TabIndex = 15;
            this.btn_DangKi.Text = "Đăng Kí";
            this.btn_DangKi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangKi.UseVisualStyleBackColor = true;
            this.btn_DangKi.Click += new System.EventHandler(this.btn_DangKi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.cmb_Dangky);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnXuat);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_DangKi);
            this.panel1.Controls.Add(this.btn_Tim);
            this.panel1.Controls.Add(this.txt_tim);
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 375);
            this.panel1.TabIndex = 16;
            // 
            // cmb_Dangky
            // 
            this.cmb_Dangky.FormattingEnabled = true;
            this.cmb_Dangky.Location = new System.Drawing.Point(1181, 298);
            this.cmb_Dangky.Name = "cmb_Dangky";
            this.cmb_Dangky.Size = new System.Drawing.Size(10, 27);
            this.cmb_Dangky.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lab_DangKy);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lab_SoLuong);
            this.groupBox1.Controls.Add(this.Lab_TenMonHoc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lab_MaGiangVien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lab_CaHoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lab_MaLop);
            this.groupBox1.Controls.Add(this.lab_Phong);
            this.groupBox1.Controls.Add(this.lab_Ten);
            this.groupBox1.Controls.Add(this.ThoiGian_Hoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lab_MSSV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1134, 93);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // lab_DangKy
            // 
            this.lab_DangKy.AutoSize = true;
            this.lab_DangKy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_DangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab_DangKy.Location = new System.Drawing.Point(1037, 55);
            this.lab_DangKy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_DangKy.Name = "lab_DangKy";
            this.lab_DangKy.Size = new System.Drawing.Size(33, 19);
            this.lab_DangKy.TabIndex = 26;
            this.lab_DangKy.Text = "100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(958, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "Đăng ký:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lab_SoLuong
            // 
            this.lab_SoLuong.AutoSize = true;
            this.lab_SoLuong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_SoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab_SoLuong.Location = new System.Drawing.Point(1037, 23);
            this.lab_SoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_SoLuong.Name = "lab_SoLuong";
            this.lab_SoLuong.Size = new System.Drawing.Size(33, 19);
            this.lab_SoLuong.TabIndex = 24;
            this.lab_SoLuong.Text = "100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(958, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Số lượng:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(638, 55);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Thời gian:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(423, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Phòng học:";
            // 
            // lab_Phong
            // 
            this.lab_Phong.AutoSize = true;
            this.lab_Phong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Phong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab_Phong.Location = new System.Drawing.Point(513, 23);
            this.lab_Phong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Phong.Name = "lab_Phong";
            this.lab_Phong.Size = new System.Drawing.Size(83, 19);
            this.lab_Phong.TabIndex = 20;
            this.lab_Phong.Text = "Phòng Học";
            // 
            // ThoiGian_Hoc
            // 
            this.ThoiGian_Hoc.AutoSize = true;
            this.ThoiGian_Hoc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoiGian_Hoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ThoiGian_Hoc.Location = new System.Drawing.Point(743, 55);
            this.ThoiGian_Hoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ThoiGian_Hoc.Name = "ThoiGian_Hoc";
            this.ThoiGian_Hoc.Size = new System.Drawing.Size(73, 19);
            this.ThoiGian_Hoc.TabIndex = 19;
            this.ThoiGian_Hoc.Text = "Thời gian";
            // 
            // btnXuat
            // 
            this.btnXuat.Image = global::TuLieuHocTap.Properties.Resources.XuatFile32;
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(640, 98);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(105, 44);
            this.btnXuat.TabIndex = 18;
            this.btnXuat.Text = "Xuất File";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btn_Xuat2);
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lab_Malop_xoa);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(11, 389);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1440, 366);
            this.panel2.TabIndex = 17;
            // 
            // btn_Xuat2
            // 
            this.btn_Xuat2.Image = global::TuLieuHocTap.Properties.Resources.XuatFile32;
            this.btn_Xuat2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xuat2.Location = new System.Drawing.Point(638, 9);
            this.btn_Xuat2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xuat2.Name = "btn_Xuat2";
            this.btn_Xuat2.Size = new System.Drawing.Size(105, 42);
            this.btn_Xuat2.TabIndex = 17;
            this.btn_Xuat2.Text = "Xuất File";
            this.btn_Xuat2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xuat2.UseVisualStyleBackColor = true;
            this.btn_Xuat2.Click += new System.EventHandler(this.btn_Xuat2_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::TuLieuHocTap.Properties.Resources.Xoa32;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(443, 9);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(127, 42);
            this.btn_Xoa.TabIndex = 16;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã Lớp";
            // 
            // lab_Malop_xoa
            // 
            this.lab_Malop_xoa.AutoSize = true;
            this.lab_Malop_xoa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Malop_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab_Malop_xoa.Location = new System.Drawing.Point(243, 32);
            this.lab_Malop_xoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Malop_xoa.Name = "lab_Malop_xoa";
            this.lab_Malop_xoa.Size = new System.Drawing.Size(0, 19);
            this.lab_Malop_xoa.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Lớp học đã đăng kí";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop2,
            this.TenMon2,
            this.ten,
            this.msv,
            this.id2});
            this.dataGridView2.Location = new System.Drawing.Point(20, 53);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1140, 226);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // MaLop2
            // 
            this.MaLop2.DataPropertyName = "Malop";
            this.MaLop2.HeaderText = "Mã lớp";
            this.MaLop2.Name = "MaLop2";
            this.MaLop2.Width = 200;
            // 
            // TenMon2
            // 
            this.TenMon2.DataPropertyName = "tenmon";
            this.TenMon2.HeaderText = "Tên môn học";
            this.TenMon2.Name = "TenMon2";
            this.TenMon2.Width = 300;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "ten";
            this.ten.HeaderText = "Tên sinh viên";
            this.ten.Name = "ten";
            this.ten.Width = 200;
            // 
            // msv
            // 
            this.msv.DataPropertyName = "mssv";
            this.msv.HeaderText = "Mã sinh viên";
            this.msv.Name = "msv";
            this.msv.Width = 200;
            // 
            // id2
            // 
            this.id2.DataPropertyName = "id";
            this.id2.HeaderText = "Mã giảng viên";
            this.id2.Name = "id2";
            this.id2.Width = 200;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 200;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên môn";
            this.TenMon.Name = "TenMon";
            this.TenMon.Width = 150;
            // 
            // Cahoc
            // 
            this.Cahoc.DataPropertyName = "Cahoc";
            this.Cahoc.HeaderText = "Ca học";
            this.Cahoc.Name = "Cahoc";
            this.Cahoc.Width = 150;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã giảng viên";
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thời gian";
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.Width = 150;
            // 
            // PhongHoc
            // 
            this.PhongHoc.DataPropertyName = "PhongHoc";
            this.PhongHoc.HeaderText = "Phòng học";
            this.PhongHoc.Name = "PhongHoc";
            this.PhongHoc.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // DangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 766);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DangKyMonHoc";
            this.Text = "DangKiMonHoc";
            this.Load += new System.EventHandler(this.DangKiMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_tim;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Label lab_MSSV;
        private System.Windows.Forms.Label lab_Ten;
        private System.Windows.Forms.Label lab_MaGiangVien;
        private System.Windows.Forms.Label lab_MaLop;
        private System.Windows.Forms.Label Lab_TenMonHoc;
        private System.Windows.Forms.Label lab_CaHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_DangKi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btn_Xuat2;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lab_Malop_xoa;
        private System.Windows.Forms.Label ThoiGian_Hoc;
        private System.Windows.Forms.Label lab_Phong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lab_SoLuong;
        private System.Windows.Forms.Label lab_DangKy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_Dangky;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn msv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cahoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}