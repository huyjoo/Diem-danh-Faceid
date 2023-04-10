using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuLieuHocTap
{
    public partial class HomeGiangVien : Form
    {
        string user;
        public HomeGiangVien(string user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void HomeGiangVien_Load(object sender, EventArgs e)
        {
            string thoigian = DateTime.Now.ToString("dd/MM/yyyy");
            ngaygio.Text = thoigian;    
            lab_ID.Text = user; 
            id.Text = user;
            loadten();
            lab_Ten.Text = com_ten.Text;
        }
        private Form currentFromChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFromChild != null)
            {
                currentFromChild.Close();
            }
            currentFromChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        void loadten()
        {
            try
            {
                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection ketnoi = new SqlConnection(@"" + line + "");
                ketnoi.Open();

                var cmd = new SqlCommand("SELECT ten FROM  Giangvien where id ='" + lab_ID.Text + "' ", ketnoi);
                var dr = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(dr);
                dr.Dispose();
                com_ten.DisplayMember = "ten";
                com_ten.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
            
        }

        private void btn_giangvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CaNhanGiangVien(lab_ID.Text, lab_Ten.Text));
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login LOGIN = new Login();
            LOGIN.Show();
            this.Hide();
        }

        private void btn_LichDay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LichDay(lab_ID.Text, lab_Ten.Text));
        }

        private void btx_DiemDanh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DiemDanh(lab_ID.Text, lab_Ten.Text));
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình quản lý lịch học và điểm danh\nChủ sở hữu KIET-HUY\nPhiên bản: 1.1", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void côngCụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mọi liên hệ cần trợ giúp vui lòng gửi qua mail votuankiet@kietvo.xyz", "Thông báo");
        }
    }
}
