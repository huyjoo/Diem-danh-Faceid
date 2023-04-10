namespace TuLieuHocTap
{
	partial class ThemSinhVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemSinhVien));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.img_KhuonMat = new Emgu.CV.UI.ImageBox();
            this.btn_Chup = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_NgaySinh = new System.Windows.Forms.TextBox();
            this.com_GioiTinh = new System.Windows.Forms.ComboBox();
            this.lab_NgaySinh = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lab_Email = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lab_DiaChi = new System.Windows.Forms.Label();
            this.lab_GioiTinh = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lab_SDT = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lab_ID = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.lab_Ten = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_KhuonMat)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(583, 611);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "© HUTECH - KIET - HUY, 2022";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 554);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhìn thẳng vào Camera";
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.Color.Transparent;
            this.imageBox1.Location = new System.Drawing.Point(37, 24);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(383, 416);
            this.imageBox1.TabIndex = 4;
            this.imageBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::TuLieuHocTap.Properties.Resources.MoCamera;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(46, 461);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 79);
            this.button1.TabIndex = 3;
            this.button1.Text = "1.Bật Camera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.closeProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1331, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.backToolStripMenuItem.Text = "Trang chủ";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // closeProgramToolStripMenuItem
            // 
            this.closeProgramToolStripMenuItem.Name = "closeProgramToolStripMenuItem";
            this.closeProgramToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.closeProgramToolStripMenuItem.Text = "Close Program";
            this.closeProgramToolStripMenuItem.Click += new System.EventHandler(this.closeProgramToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.img_KhuonMat);
            this.groupBox2.Controls.Add(this.btn_Chup);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(475, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 554);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mặt";
            // 
            // img_KhuonMat
            // 
            this.img_KhuonMat.BackColor = System.Drawing.Color.Transparent;
            this.img_KhuonMat.Location = new System.Drawing.Point(65, 121);
            this.img_KhuonMat.Name = "img_KhuonMat";
            this.img_KhuonMat.Size = new System.Drawing.Size(275, 290);
            this.img_KhuonMat.TabIndex = 16;
            this.img_KhuonMat.TabStop = false;
            // 
            // btn_Chup
            // 
            this.btn_Chup.Image = global::TuLieuHocTap.Properties.Resources.ChupAnh;
            this.btn_Chup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Chup.Location = new System.Drawing.Point(18, 461);
            this.btn_Chup.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Chup.Name = "btn_Chup";
            this.btn_Chup.Size = new System.Drawing.Size(366, 79);
            this.btn_Chup.TabIndex = 15;
            this.btn_Chup.Text = "2.Chụp ảnh";
            this.btn_Chup.UseVisualStyleBackColor = true;
            this.btn_Chup.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.txt_NgaySinh);
            this.groupBox3.Controls.Add(this.com_GioiTinh);
            this.groupBox3.Controls.Add(this.lab_NgaySinh);
            this.groupBox3.Controls.Add(this.txt_Email);
            this.groupBox3.Controls.Add(this.lab_Email);
            this.groupBox3.Controls.Add(this.txt_DiaChi);
            this.groupBox3.Controls.Add(this.lab_DiaChi);
            this.groupBox3.Controls.Add(this.lab_GioiTinh);
            this.groupBox3.Controls.Add(this.txt_SDT);
            this.groupBox3.Controls.Add(this.lab_SDT);
            this.groupBox3.Controls.Add(this.txt_ID);
            this.groupBox3.Controls.Add(this.lab_ID);
            this.groupBox3.Controls.Add(this.btn_Luu);
            this.groupBox3.Controls.Add(this.txt_Ten);
            this.groupBox3.Controls.Add(this.lab_Ten);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(896, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 535);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập thông tin";
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.Location = new System.Drawing.Point(130, 313);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(262, 32);
            this.txt_NgaySinh.TabIndex = 34;
            this.txt_NgaySinh.Text = "14/08/2001";
            this.txt_NgaySinh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_NgaySinh_MouseDown);
            // 
            // com_GioiTinh
            // 
            this.com_GioiTinh.FormattingEnabled = true;
            this.com_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.com_GioiTinh.Location = new System.Drawing.Point(130, 115);
            this.com_GioiTinh.Name = "com_GioiTinh";
            this.com_GioiTinh.Size = new System.Drawing.Size(262, 32);
            this.com_GioiTinh.TabIndex = 33;
            this.com_GioiTinh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.com_GioiTinh_MouseDown);
            // 
            // lab_NgaySinh
            // 
            this.lab_NgaySinh.AutoSize = true;
            this.lab_NgaySinh.Location = new System.Drawing.Point(11, 316);
            this.lab_NgaySinh.Name = "lab_NgaySinh";
            this.lab_NgaySinh.Size = new System.Drawing.Size(97, 24);
            this.lab_NgaySinh.TabIndex = 31;
            this.lab_NgaySinh.Text = "Ngày sinh:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(130, 215);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(262, 32);
            this.txt_Email.TabIndex = 30;
            this.txt_Email.Text = "123adufff@gmail.com";
            this.txt_Email.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_Email_MouseDown);
            // 
            // lab_Email
            // 
            this.lab_Email.AutoSize = true;
            this.lab_Email.Location = new System.Drawing.Point(11, 220);
            this.lab_Email.Name = "lab_Email";
            this.lab_Email.Size = new System.Drawing.Size(62, 24);
            this.lab_Email.TabIndex = 29;
            this.lab_Email.Text = "Email:";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(130, 261);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(262, 32);
            this.txt_DiaChi.TabIndex = 28;
            this.txt_DiaChi.Text = "q7";
            this.txt_DiaChi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_DiaChi_MouseDown);
            // 
            // lab_DiaChi
            // 
            this.lab_DiaChi.AutoSize = true;
            this.lab_DiaChi.Location = new System.Drawing.Point(11, 266);
            this.lab_DiaChi.Name = "lab_DiaChi";
            this.lab_DiaChi.Size = new System.Drawing.Size(73, 24);
            this.lab_DiaChi.TabIndex = 27;
            this.lab_DiaChi.Text = "Địa chỉ:";
            // 
            // lab_GioiTinh
            // 
            this.lab_GioiTinh.AutoSize = true;
            this.lab_GioiTinh.Location = new System.Drawing.Point(11, 123);
            this.lab_GioiTinh.Name = "lab_GioiTinh";
            this.lab_GioiTinh.Size = new System.Drawing.Size(91, 24);
            this.lab_GioiTinh.TabIndex = 24;
            this.lab_GioiTinh.Text = "Giới tính:";
            this.lab_GioiTinh.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(130, 171);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(262, 32);
            this.txt_SDT.TabIndex = 23;
            this.txt_SDT.Text = "0788987420";
            this.txt_SDT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_SDT_MouseDown);
            // 
            // lab_SDT
            // 
            this.lab_SDT.AutoSize = true;
            this.lab_SDT.Location = new System.Drawing.Point(11, 176);
            this.lab_SDT.Name = "lab_SDT";
            this.lab_SDT.Size = new System.Drawing.Size(47, 24);
            this.lab_SDT.TabIndex = 22;
            this.lab_SDT.Text = "SĐT:";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(130, 26);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(262, 32);
            this.txt_ID.TabIndex = 21;
            this.txt_ID.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_ID_MouseDown);
            // 
            // lab_ID
            // 
            this.lab_ID.AutoSize = true;
            this.lab_ID.Location = new System.Drawing.Point(11, 30);
            this.lab_ID.Name = "lab_ID";
            this.lab_ID.Size = new System.Drawing.Size(115, 24);
            this.lab_ID.TabIndex = 20;
            this.lab_ID.Text = "ID Sinh viên:";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Luu.Image = global::TuLieuHocTap.Properties.Resources.Luu64;
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(46, 442);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(337, 79);
            this.btn_Luu.TabIndex = 19;
            this.btn_Luu.Text = "3. Lưu vào CSDL";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(130, 73);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(262, 32);
            this.txt_Ten.TabIndex = 18;
            this.txt_Ten.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_Ten_MouseDown);
            // 
            // lab_Ten
            // 
            this.lab_Ten.AutoSize = true;
            this.lab_Ten.Location = new System.Drawing.Point(11, 76);
            this.lab_Ten.Name = "lab_Ten";
            this.lab_Ten.Size = new System.Drawing.Size(45, 24);
            this.lab_Ten.TabIndex = 17;
            this.lab_Ten.Text = "Tên:";
            // 
            // ThemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 656);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThemSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Facial Recognition";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_KhuonMat)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProgramToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private Emgu.CV.UI.ImageBox img_KhuonMat;
        private System.Windows.Forms.Button btn_Chup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lab_ID;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Label lab_Ten;
        private System.Windows.Forms.Label lab_GioiTinh;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lab_SDT;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lab_DiaChi;
        private System.Windows.Forms.Label lab_NgaySinh;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lab_Email;
        private System.Windows.Forms.ComboBox com_GioiTinh;
        private System.Windows.Forms.TextBox txt_NgaySinh;
    }
}

