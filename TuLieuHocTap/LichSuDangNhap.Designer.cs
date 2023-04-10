namespace TuLieuHocTap
{
    partial class LichSuDangNhap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_KhongThanhCong = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_XuatFile = new System.Windows.Forms.Button();
            this.txt_Nhap = new System.Windows.Forms.TextBox();
            this.btn_TimVoiMail = new System.Windows.Forms.Button();
            this.btn_TimVoiID = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btn_KhongThanhCong);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_XuatFile);
            this.groupBox1.Controls.Add(this.txt_Nhap);
            this.groupBox1.Controls.Add(this.btn_TimVoiMail);
            this.groupBox1.Controls.Add(this.btn_TimVoiID);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(953, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_KhongThanhCong
            // 
            this.btn_KhongThanhCong.Location = new System.Drawing.Point(255, 73);
            this.btn_KhongThanhCong.Name = "btn_KhongThanhCong";
            this.btn_KhongThanhCong.Size = new System.Drawing.Size(139, 30);
            this.btn_KhongThanhCong.TabIndex = 7;
            this.btn_KhongThanhCong.Text = "Tài khoản False";
            this.btn_KhongThanhCong.UseVisualStyleBackColor = true;
            this.btn_KhongThanhCong.Click += new System.EventHandler(this.btn_KhongThanhCong_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = global::TuLieuHocTap.Properties.Resources.Xoa32;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(410, 73);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(119, 30);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.Image = global::TuLieuHocTap.Properties.Resources.XuatFile32;
            this.btn_XuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XuatFile.Location = new System.Drawing.Point(535, 73);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(139, 30);
            this.btn_XuatFile.TabIndex = 5;
            this.btn_XuatFile.Text = "Xuất File ";
            this.btn_XuatFile.UseVisualStyleBackColor = true;
            this.btn_XuatFile.Click += new System.EventHandler(this.btn_XuatFile_Click);
            // 
            // txt_Nhap
            // 
            this.txt_Nhap.Location = new System.Drawing.Point(6, 27);
            this.txt_Nhap.Name = "txt_Nhap";
            this.txt_Nhap.Size = new System.Drawing.Size(213, 27);
            this.txt_Nhap.TabIndex = 4;
            // 
            // btn_TimVoiMail
            // 
            this.btn_TimVoiMail.Location = new System.Drawing.Point(131, 73);
            this.btn_TimVoiMail.Name = "btn_TimVoiMail";
            this.btn_TimVoiMail.Size = new System.Drawing.Size(118, 30);
            this.btn_TimVoiMail.TabIndex = 3;
            this.btn_TimVoiMail.Text = "Tìm với Email";
            this.btn_TimVoiMail.UseVisualStyleBackColor = true;
            this.btn_TimVoiMail.Click += new System.EventHandler(this.btn_TimVoiMail_Click);
            // 
            // btn_TimVoiID
            // 
            this.btn_TimVoiID.Location = new System.Drawing.Point(6, 73);
            this.btn_TimVoiID.Name = "btn_TimVoiID";
            this.btn_TimVoiID.Size = new System.Drawing.Size(119, 30);
            this.btn_TimVoiID.TabIndex = 0;
            this.btn_TimVoiID.Text = "Tìm với ID";
            this.btn_TimVoiID.UseVisualStyleBackColor = true;
            this.btn_TimVoiID.Click += new System.EventHandler(this.btn_TimVoiID_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.trangthai,
            this.email,
            this.thoigian});
            this.dataGridView1.Location = new System.Drawing.Point(10, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(826, 405);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã người dùng";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái đăng nhập";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.Width = 200;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email người dùng";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // thoigian
            // 
            this.thoigian.DataPropertyName = "thoigian";
            this.thoigian.HeaderText = "Thời gian đăng nhập";
            this.thoigian.MinimumWidth = 6;
            this.thoigian.Name = "thoigian";
            this.thoigian.Width = 200;
            // 
            // LichSuDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 696);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "LichSuDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LichSuDangNhap";
            this.Load += new System.EventHandler(this.LichSuDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_XuatFile;
        private System.Windows.Forms.TextBox txt_Nhap;
        private System.Windows.Forms.Button btn_TimVoiMail;
        private System.Windows.Forms.Button btn_TimVoiID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigian;
        private System.Windows.Forms.Button btn_KhongThanhCong;
    }
}