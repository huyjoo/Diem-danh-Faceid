namespace TuLieuHocTap
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nangcao = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ten = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Pannel_from = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_User = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.giangVienTableAdapter1 = new TuLieuHocTap.DIEM_DANHDataSet1TableAdapters.GiangVienTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btx_QLSV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_QLNV = new System.Windows.Forms.Button();
            this.btn_Lop = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_ThoiKhoaBieu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.THOIGIAN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.Pannel_from.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.nangcao,
            this.ten,
            this.THOIGIAN,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // nangcao
            // 
            this.nangcao.Name = "nangcao";
            this.nangcao.Size = new System.Drawing.Size(73, 20);
            this.nangcao.Text = "Nâng cao ";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.thoátToolStripMenuItem.Text = "Đăng xuất";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // ten
            // 
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(37, 20);
            this.ten.Text = "Tên";
            // 
            // Pannel_from
            // 
            this.Pannel_from.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pannel_from.Controls.Add(this.label3);
            this.Pannel_from.Controls.Add(this.pictureBox1);
            this.Pannel_from.Location = new System.Drawing.Point(233, 31);
            this.Pannel_from.Name = "Pannel_from";
            this.Pannel_from.Size = new System.Drawing.Size(1671, 735);
            this.Pannel_from.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(498, 628);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "© HUTECH - KIET - HUY, 2022";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TuLieuHocTap.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(366, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txt_User
            // 
            this.txt_User.AutoSize = true;
            this.txt_User.ForeColor = System.Drawing.Color.Red;
            this.txt_User.Location = new System.Drawing.Point(11, 43);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(91, 19);
            this.txt_User.TabIndex = 2;
            this.txt_User.Text = "Chào mừng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chào mừng ";
            // 
            // giangVienTableAdapter1
            // 
            this.giangVienTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btx_QLSV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_User);
            this.panel1.Controls.Add(this.btn_QLNV);
            this.panel1.Controls.Add(this.btn_Lop);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_ThoiKhoaBieu);
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 743);
            this.panel1.TabIndex = 31;
            // 
            // btx_QLSV
            // 
            this.btx_QLSV.Image = global::TuLieuHocTap.Properties.Resources.SinhVien;
            this.btx_QLSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btx_QLSV.Location = new System.Drawing.Point(4, 235);
            this.btx_QLSV.Margin = new System.Windows.Forms.Padding(4);
            this.btx_QLSV.Name = "btx_QLSV";
            this.btx_QLSV.Size = new System.Drawing.Size(187, 74);
            this.btx_QLSV.TabIndex = 30;
            this.btx_QLSV.Text = "Sinh viên";
            this.btx_QLSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btx_QLSV.UseVisualStyleBackColor = true;
            this.btx_QLSV.Click += new System.EventHandler(this.btx_QLSV_Click);
            // 
            // button1
            // 
            this.button1.Image = global::TuLieuHocTap.Properties.Resources.LichSuDangNhap;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 481);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 78);
            this.button1.TabIndex = 12;
            this.button1.Text = "Lịch sử Login";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_QLNV
            // 
            this.btn_QLNV.Image = global::TuLieuHocTap.Properties.Resources.GiangVien;
            this.btn_QLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QLNV.Location = new System.Drawing.Point(4, 153);
            this.btn_QLNV.Margin = new System.Windows.Forms.Padding(4);
            this.btn_QLNV.Name = "btn_QLNV";
            this.btn_QLNV.Size = new System.Drawing.Size(187, 74);
            this.btn_QLNV.TabIndex = 15;
            this.btn_QLNV.Text = "Giảng viên";
            this.btn_QLNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_QLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_QLNV.UseVisualStyleBackColor = true;
            this.btn_QLNV.Click += new System.EventHandler(this.btn_QLNV_Click);
            // 
            // btn_Lop
            // 
            this.btn_Lop.Image = global::TuLieuHocTap.Properties.Resources.LopHoc;
            this.btn_Lop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Lop.Location = new System.Drawing.Point(4, 317);
            this.btn_Lop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Lop.Name = "btn_Lop";
            this.btn_Lop.Size = new System.Drawing.Size(187, 74);
            this.btn_Lop.TabIndex = 27;
            this.btn_Lop.Text = "Lớp học và  môn học";
            this.btn_Lop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Lop.UseVisualStyleBackColor = true;
            this.btn_Lop.Click += new System.EventHandler(this.btn_Lop_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::TuLieuHocTap.Properties.Resources.themSV;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(4, 71);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 74);
            this.button2.TabIndex = 11;
            this.button2.Text = "Thêm Sinh Viên";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ThoiKhoaBieu
            // 
            this.btn_ThoiKhoaBieu.Image = global::TuLieuHocTap.Properties.Resources.ThoiKhoaBieu;
            this.btn_ThoiKhoaBieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThoiKhoaBieu.Location = new System.Drawing.Point(4, 399);
            this.btn_ThoiKhoaBieu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ThoiKhoaBieu.Name = "btn_ThoiKhoaBieu";
            this.btn_ThoiKhoaBieu.Size = new System.Drawing.Size(187, 74);
            this.btn_ThoiKhoaBieu.TabIndex = 26;
            this.btn_ThoiKhoaBieu.Text = "Lịch học";
            this.btn_ThoiKhoaBieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThoiKhoaBieu.UseVisualStyleBackColor = true;
            this.btn_ThoiKhoaBieu.Click += new System.EventHandler(this.btn_ThoiKhoaBieu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(1, 772);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1903, 67);
            this.panel2.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(826, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "© HUTECH - KIET - HUY, 2022";
            // 
            // THOIGIAN
            // 
            this.THOIGIAN.Name = "THOIGIAN";
            this.THOIGIAN.Size = new System.Drawing.Size(67, 20);
            this.THOIGIAN.Text = "ThoGIAN";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 781);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pannel_from);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang dành cho quản trị viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MAINGUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Pannel_from.ResumeLayout(false);
            this.Pannel_from.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_QLNV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button btn_ThoiKhoaBieu;
        private System.Windows.Forms.Button btn_Lop;
        private System.Windows.Forms.Panel Pannel_from;
        private System.Windows.Forms.ToolStripMenuItem ten;
        private System.Windows.Forms.Label txt_User;
        private System.Windows.Forms.Label label2;
        private DIEM_DANHDataSet1TableAdapters.GiangVienTableAdapter giangVienTableAdapter1;
        private System.Windows.Forms.Button btx_QLSV;
        private System.Windows.Forms.ToolStripMenuItem nangcao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem THOIGIAN;
    }
}