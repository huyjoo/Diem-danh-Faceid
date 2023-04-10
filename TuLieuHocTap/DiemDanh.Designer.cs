namespace TuLieuHocTap
{
    partial class DiemDanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiemDanh));
            this.btn_BatCam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resetAttendanceButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_Ten = new System.Windows.Forms.Label();
            this.LAB_ID = new System.Windows.Forms.Label();
            this.com_maLop = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_dd_ten = new System.Windows.Forms.Label();
            this.txt_dd_id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.XUAT = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BatCam
            // 
            this.btn_BatCam.Location = new System.Drawing.Point(61, 139);
            this.btn_BatCam.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BatCam.Name = "btn_BatCam";
            this.btn_BatCam.Size = new System.Drawing.Size(225, 87);
            this.btn_BatCam.TabIndex = 5;
            this.btn_BatCam.Text = "1. Bật camera và quét";
            this.btn_BatCam.UseVisualStyleBackColor = true;
            this.btn_BatCam.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(448, 510);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "© HUY - KIET, 2022";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(634, 174);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 43);
            this.button3.TabIndex = 11;
            this.button3.Text = "Sinh viên vắng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resetAttendanceButton
            // 
            this.resetAttendanceButton.Location = new System.Drawing.Point(469, 174);
            this.resetAttendanceButton.Name = "resetAttendanceButton";
            this.resetAttendanceButton.Size = new System.Drawing.Size(134, 43);
            this.resetAttendanceButton.TabIndex = 12;
            this.resetAttendanceButton.Text = "Quét lại";
            this.resetAttendanceButton.UseVisualStyleBackColor = true;
            this.resetAttendanceButton.Click += new System.EventHandler(this.resetAttendanceButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "____________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số lượng sinh viên: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "____________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên Sinh viên:";
            // 
            // lab_Ten
            // 
            this.lab_Ten.AutoSize = true;
            this.lab_Ten.Location = new System.Drawing.Point(110, 22);
            this.lab_Ten.Name = "lab_Ten";
            this.lab_Ten.Size = new System.Drawing.Size(47, 24);
            this.lab_Ten.TabIndex = 21;
            this.lab_Ten.Text = "Tên";
            // 
            // LAB_ID
            // 
            this.LAB_ID.AutoSize = true;
            this.LAB_ID.Location = new System.Drawing.Point(110, 70);
            this.LAB_ID.Name = "LAB_ID";
            this.LAB_ID.Size = new System.Drawing.Size(29, 24);
            this.LAB_ID.TabIndex = 22;
            this.LAB_ID.Text = "ID";
            // 
            // com_maLop
            // 
            this.com_maLop.FormattingEnabled = true;
            this.com_maLop.Location = new System.Drawing.Point(293, 185);
            this.com_maLop.Name = "com_maLop";
            this.com_maLop.Size = new System.Drawing.Size(120, 32);
            this.com_maLop.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Hãy Chọn Lớp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(469, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(313, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txt_dd_ten);
            this.panel1.Controls.Add(this.txt_dd_id);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.XUAT);
            this.panel1.Controls.Add(this.imageBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btn_BatCam);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lab_Ten);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.LAB_ID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.resetAttendanceButton);
            this.panel1.Controls.Add(this.com_maLop);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 612);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_dd_ten
            // 
            this.txt_dd_ten.AutoSize = true;
            this.txt_dd_ten.Location = new System.Drawing.Point(816, 233);
            this.txt_dd_ten.Name = "txt_dd_ten";
            this.txt_dd_ten.Size = new System.Drawing.Size(47, 24);
            this.txt_dd_ten.TabIndex = 29;
            this.txt_dd_ten.Text = "Tên";
            // 
            // txt_dd_id
            // 
            this.txt_dd_id.AutoSize = true;
            this.txt_dd_id.Location = new System.Drawing.Point(816, 282);
            this.txt_dd_id.Name = "txt_dd_id";
            this.txt_dd_id.Size = new System.Drawing.Size(29, 24);
            this.txt_dd_id.TabIndex = 30;
            this.txt_dd_id.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(820, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 43);
            this.button1.TabIndex = 26;
            this.button1.Text = "Điểm danh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // XUAT
            // 
            this.XUAT.Image = global::TuLieuHocTap.Properties.Resources.XuatFile32;
            this.XUAT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XUAT.Location = new System.Drawing.Point(810, 174);
            this.XUAT.Margin = new System.Windows.Forms.Padding(4);
            this.XUAT.Name = "XUAT";
            this.XUAT.Size = new System.Drawing.Size(163, 43);
            this.XUAT.TabIndex = 25;
            this.XUAT.Text = "Xuất file";
            this.XUAT.UseVisualStyleBackColor = true;
            this.XUAT.Click += new System.EventHandler(this.XUAT_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.Color.Transparent;
            this.imageBox1.InitialImage = global::TuLieuHocTap.Properties.Resources.andanh;
            this.imageBox1.Location = new System.Drawing.Point(50, 233);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(363, 256);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 6;
            this.imageBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(820, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 43);
            this.button2.TabIndex = 31;
            this.button2.Text = "Gọi tên";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "DiemDanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetectAndAttendance";
            this.Load += new System.EventHandler(this.DetectAndAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button btn_BatCam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetAttendanceButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox com_maLop;
        private System.Windows.Forms.Label LAB_ID;
        private System.Windows.Forms.Label lab_Ten;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button XUAT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txt_dd_ten;
        private System.Windows.Forms.Label txt_dd_id;
        private System.Windows.Forms.Button button2;
    }
}