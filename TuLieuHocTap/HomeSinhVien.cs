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
    public partial class HomeSinhVien : Form
    {
        private string username;
        public HomeSinhVien(string user)
        {
            this.username = user;
            InitializeComponent();
        }

        private void HomeSinhVien_Load(object sender, EventArgs e)
        {
            string thoigian = DateTime.Now.ToString("dd/MM/yyyy");
            ngaygio.Text = thoigian;
            cmb_ten.Enabled = false;
            id.Text = username;
            txt_ID.Text = username;
            loathongtin();
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

        private void btn_DangKiMonHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DangKyMonHoc(txt_ID.Text,lab_Ten.Text));
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }


        void loathongtin()
        {
            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");
            ketnoi.Open();

            var cmd = new SqlCommand("SELECT TEN FROM  SinhVien where MSSV ='" + txt_ID.Text + "' ", ketnoi);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cmb_ten.DisplayMember = "Ten";
            cmb_ten.DataSource = dt;
            lab_Ten.Text =cmb_ten.Text;
           
        }

        private void btn_TKB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThoiKhoaBieuSV(username));
        }

        private void btn_sinhvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CaNhanSinhVien(username,lab_Ten.Text));
        }

        private void côngCụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mọi liên hệ cần trợ giúp vui lòng gửi qua mail votuankiet@kietvo.xyz", "Thông báo");
        }
    }
}
