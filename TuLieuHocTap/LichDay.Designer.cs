namespace TuLieuHocTap
{
    partial class LichDay
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
            System.Windows.Forms.Button btn_Xemtheongay;
            System.Windows.Forms.Button btn_Xemall;
            this.lab_PhongHoc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cahoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonghoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lab_CaHoc = new System.Windows.Forms.Label();
            this.lab_ThoiGian = new System.Windows.Forms.Label();
            this.Lab_TenMon = new System.Windows.Forms.Label();
            this.lab_MSGV = new System.Windows.Forms.Label();
            this.lab_Ten = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ThoiGian = new System.Windows.Forms.TextBox();
            btn_Xemtheongay = new System.Windows.Forms.Button();
            btn_Xemall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_PhongHoc
            // 
            this.lab_PhongHoc.AutoSize = true;
            this.lab_PhongHoc.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_PhongHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab_PhongHoc.Location = new System.Drawing.Point(283, 277);
            this.lab_PhongHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_PhongHoc.Name = "lab_PhongHoc";
            this.lab_PhongHoc.Size = new System.Drawing.Size(134, 33);
            this.lab_PhongHoc.TabIndex = 14;
            this.lab_PhongHoc.Text = "Phòng Học";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMon,
            this.cahoc,
            this.thoigianhoc,
            this.phonghoc});
            this.dataGridView1.Location = new System.Drawing.Point(72, 332);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(805, 283);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên môn ";
            this.TenMon.Name = "TenMon";
            this.TenMon.Width = 200;
            // 
            // cahoc
            // 
            this.cahoc.DataPropertyName = "cahoc";
            this.cahoc.HeaderText = "Ca học";
            this.cahoc.Name = "cahoc";
            this.cahoc.Width = 150;
            // 
            // thoigianhoc
            // 
            this.thoigianhoc.DataPropertyName = "thoigianhoc";
            this.thoigianhoc.HeaderText = "Thời gian học";
            this.thoigianhoc.Name = "thoigianhoc";
            this.thoigianhoc.Width = 150;
            // 
            // phonghoc
            // 
            this.phonghoc.DataPropertyName = "phonghoc";
            this.phonghoc.HeaderText = "Phòng học";
            this.phonghoc.Name = "phonghoc";
            this.phonghoc.Width = 150;
            // 
            // Lab_CaHoc
            // 
            this.Lab_CaHoc.AutoSize = true;
            this.Lab_CaHoc.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_CaHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lab_CaHoc.Location = new System.Drawing.Point(283, 226);
            this.Lab_CaHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lab_CaHoc.Name = "Lab_CaHoc";
            this.Lab_CaHoc.Size = new System.Drawing.Size(91, 33);
            this.Lab_CaHoc.TabIndex = 12;
            this.Lab_CaHoc.Text = "Ca Học";
            // 
            // lab_ThoiGian
            // 
            this.lab_ThoiGian.AutoSize = true;
            this.lab_ThoiGian.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ThoiGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab_ThoiGian.Location = new System.Drawing.Point(283, 171);
            this.lab_ThoiGian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_ThoiGian.Name = "lab_ThoiGian";
            this.lab_ThoiGian.Size = new System.Drawing.Size(185, 33);
            this.lab_ThoiGian.TabIndex = 11;
            this.lab_ThoiGian.Text = "Thời Giang Học";
            // 
            // Lab_TenMon
            // 
            this.Lab_TenMon.AutoSize = true;
            this.Lab_TenMon.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_TenMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lab_TenMon.Location = new System.Drawing.Point(283, 117);
            this.Lab_TenMon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lab_TenMon.Name = "Lab_TenMon";
            this.Lab_TenMon.Size = new System.Drawing.Size(113, 33);
            this.Lab_TenMon.TabIndex = 10;
            this.Lab_TenMon.Text = "Tên Môn";
            // 
            // lab_MSGV
            // 
            this.lab_MSGV.AutoSize = true;
            this.lab_MSGV.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_MSGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab_MSGV.Location = new System.Drawing.Point(283, 61);
            this.lab_MSGV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_MSGV.Name = "lab_MSGV";
            this.lab_MSGV.Size = new System.Drawing.Size(150, 33);
            this.lab_MSGV.TabIndex = 9;
            this.lab_MSGV.Text = "ID Sinh Viên";
            // 
            // lab_Ten
            // 
            this.lab_Ten.AutoSize = true;
            this.lab_Ten.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lab_Ten.Location = new System.Drawing.Point(283, 7);
            this.lab_Ten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_Ten.Name = "lab_Ten";
            this.lab_Ten.Size = new System.Drawing.Size(165, 33);
            this.lab_Ten.TabIndex = 8;
            this.lab_Ten.Text = "Tên Sinh Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 33);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phòng học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ca dạy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời gian dạy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID giảng viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên giảng viên";
            // 
            // btn_Xemtheongay
            // 
            btn_Xemtheongay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Xemtheongay.Location = new System.Drawing.Point(642, 282);
            btn_Xemtheongay.Name = "btn_Xemtheongay";
            btn_Xemtheongay.Size = new System.Drawing.Size(113, 27);
            btn_Xemtheongay.TabIndex = 20;
            btn_Xemtheongay.Text = "Xem theo ngày";
            btn_Xemtheongay.UseVisualStyleBackColor = true;
            btn_Xemtheongay.Click += new System.EventHandler(this.btn_Xemtheongay_Click);
            // 
            // btn_Xemall
            // 
            btn_Xemall.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn_Xemall.Location = new System.Drawing.Point(778, 282);
            btn_Xemall.Name = "btn_Xemall";
            btn_Xemall.Size = new System.Drawing.Size(99, 27);
            btn_Xemall.TabIndex = 19;
            btn_Xemall.Text = "Xem tất cả";
            btn_Xemall.UseVisualStyleBackColor = true;
            btn_Xemall.Click += new System.EventHandler(this.btn_Xemall_Click);
            // 
            // txt_ThoiGian
            // 
            this.txt_ThoiGian.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThoiGian.Location = new System.Drawing.Point(440, 283);
            this.txt_ThoiGian.Name = "txt_ThoiGian";
            this.txt_ThoiGian.Size = new System.Drawing.Size(186, 27);
            this.txt_ThoiGian.TabIndex = 18;
            // 
            // LichDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 635);
            this.Controls.Add(btn_Xemtheongay);
            this.Controls.Add(btn_Xemall);
            this.Controls.Add(this.txt_ThoiGian);
            this.Controls.Add(this.lab_PhongHoc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Lab_CaHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_ThoiGian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lab_TenMon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab_MSGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_Ten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LichDay";
            this.Text = "Lịch dạy";
            this.Load += new System.EventHandler(this.LichDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab_PhongHoc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Lab_CaHoc;
        private System.Windows.Forms.Label lab_ThoiGian;
        private System.Windows.Forms.Label Lab_TenMon;
        private System.Windows.Forms.Label lab_MSGV;
        private System.Windows.Forms.Label lab_Ten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cahoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonghoc;
        private System.Windows.Forms.TextBox txt_ThoiGian;
    }
}