using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuLieuHocTap
{
    public partial class Home : Form
    {

        private string username;
        
        
       
        public Home(string user )
        {
            this.username = user;

            //var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            //// string txtpath = @"D:/Connection/ConnectionString.txt";
            //StreamReader sr = new StreamReader(txtpath);
            //String line = sr.ReadToEnd();

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThemSinhVien());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LichSuDangNhap());
        }

        private void MAINGUI_Load(object sender, EventArgs e)
        {
            string thoigian = DateTime.Now.ToString("dd/MM/yyyy");
            THOIGIAN.Text = thoigian;
            ten.Text = username;
            txt_User.Text = username;
        }
       

        private void btn_QLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien());

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
            Pannel_from.Controls.Add(childForm);
            Pannel_from.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login dangxuat = new Login();
            dangxuat.Show();
            this.Hide();
        }

        private void btn_HeThong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HeThong());
        }

        private void btn_ThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThoiKhoaBieu());
        }

        private void btn_Lop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LopHocVaMonHoc());
        }

        private void btx_QLSV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SinhVien());
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chương trình quản lý lịch học và điểm danh\nChủ sở hữu KIET-HUY\nPhiên bản: 1.1","Thông tin",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
