namespace TuLieuHocTap
{
    partial class XacMinhSinhVien
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
            this.Mail = new System.Windows.Forms.ComboBox();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.Label();
            this.Lab_Email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_Loinhan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gữi = new System.Windows.Forms.Button();
            this.lab_GuiLai = new System.Windows.Forms.Label();
            this.lab_ThoiGian = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mail
            // 
            this.Mail.BackColor = System.Drawing.SystemColors.Control;
            this.Mail.ForeColor = System.Drawing.SystemColors.Control;
            this.Mail.FormattingEnabled = true;
            this.Mail.Location = new System.Drawing.Point(1055, 528);
            this.Mail.Margin = new System.Windows.Forms.Padding(4);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(12, 24);
            this.Mail.TabIndex = 1;
            // 
            // txt_Ma
            // 
            this.txt_Ma.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma.Location = new System.Drawing.Point(203, 513);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(176, 36);
            this.txt_Ma.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(304, 362);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(155, 29);
            this.txtID.TabIndex = 4;
            this.txtID.Text = "ID người dùng";
            // 
            // Lab_Email
            // 
            this.Lab_Email.AutoSize = true;
            this.Lab_Email.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Email.ForeColor = System.Drawing.Color.Maroon;
            this.Lab_Email.Location = new System.Drawing.Point(435, 400);
            this.Lab_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Email.Name = "Lab_Email";
            this.Lab_Email.Size = new System.Drawing.Size(74, 29);
            this.Lab_Email.TabIndex = 6;
            this.Lab_Email.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 400);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chúng tôi đã gửi OTP xác thực qua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 362);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Xin chào";
            // 
            // lab_Loinhan
            // 
            this.lab_Loinhan.AutoSize = true;
            this.lab_Loinhan.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Loinhan.Location = new System.Drawing.Point(199, 482);
            this.lab_Loinhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Loinhan.Name = "lab_Loinhan";
            this.lab_Loinhan.Size = new System.Drawing.Size(181, 23);
            this.lab_Loinhan.TabIndex = 9;
            this.lab_Loinhan.Text = "Nhập OTP để xác minh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "XÁC MINH DANH TÍNH CỦA BẠN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TuLieuHocTap.Properties.Resources.xacminhdanhtinh;
            this.pictureBox1.Location = new System.Drawing.Point(216, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Gữi
            // 
            this.Gữi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gữi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gữi.Image = global::TuLieuHocTap.Properties.Resources.xacminh32;
            this.Gữi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Gữi.Location = new System.Drawing.Point(401, 503);
            this.Gữi.Margin = new System.Windows.Forms.Padding(4);
            this.Gữi.Name = "Gữi";
            this.Gữi.Size = new System.Drawing.Size(169, 54);
            this.Gữi.TabIndex = 3;
            this.Gữi.Text = "Xác minh";
            this.Gữi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Gữi.UseVisualStyleBackColor = true;
            this.Gữi.Click += new System.EventHandler(this.btn_XacMinh_Click);
            // 
            // lab_GuiLai
            // 
            this.lab_GuiLai.AutoSize = true;
            this.lab_GuiLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_GuiLai.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_GuiLai.ForeColor = System.Drawing.Color.Black;
            this.lab_GuiLai.Location = new System.Drawing.Point(199, 554);
            this.lab_GuiLai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_GuiLai.Name = "lab_GuiLai";
            this.lab_GuiLai.Size = new System.Drawing.Size(56, 21);
            this.lab_GuiLai.TabIndex = 12;
            this.lab_GuiLai.Text = "Gửi lại";
            this.lab_GuiLai.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lab_GuiLai.Click += new System.EventHandler(this.lab_GuiLai_Click);
            // 
            // lab_ThoiGian
            // 
            this.lab_ThoiGian.AutoSize = true;
            this.lab_ThoiGian.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ThoiGian.Location = new System.Drawing.Point(338, 523);
            this.lab_ThoiGian.Name = "lab_ThoiGian";
            this.lab_ThoiGian.Size = new System.Drawing.Size(28, 21);
            this.lab_ThoiGian.TabIndex = 25;
            this.lab_ThoiGian.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // XacMinhSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 583);
            this.Controls.Add(this.lab_ThoiGian);
            this.Controls.Add(this.lab_GuiLai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lab_Loinhan);
            this.Controls.Add(this.Gữi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lab_Email);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XacMinhSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác minh người dùng";
            this.Load += new System.EventHandler(this.XacMinhSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.ComboBox Mail;
        private System.Windows.Forms.Label Lab_Email;
        private System.Windows.Forms.Button Gữi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_Loinhan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_GuiLai;
        private System.Windows.Forms.Label lab_ThoiGian;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}