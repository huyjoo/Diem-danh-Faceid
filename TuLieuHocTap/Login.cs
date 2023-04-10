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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            try
            {
                //Tạo kết nối CSDL
                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection conn = new SqlConnection(@"" + line + "");
                conn.Open();
                string tailhoan = txt_User.Text;
                string matkhau = txt_Pass.Text;

                if (CHECK_admin.Checked == true)

                {
                   //CHUYỂN MD5
                    String str = "";
                    Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(matkhau);
                    System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                    buffer = md5.ComputeHash(buffer);
                    foreach (Byte b in buffer)
                    {
                        str += b.ToString("X2");
                    }


                    if (tailhoan == "" || matkhau == "")
                    {
                        MessageBox.Show("Tài khoản và mật khẩu không được bỏ trống!");
                    }
                    else
                    {
                        string sql = "select *from taikhoan" + " where TaiKhoan='" + tailhoan + "' and  Matkhau='" + str + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);

                        SqlDataReader dta = cmd.ExecuteReader();

                        if (dta.Read() == true)
                        {
                            Home qt = new Home(txt_User.Text);
                            qt.Show();
                            this.Hide();

                        }

                        else
                        {

                            MessageBox.Show("Sai Tài khoản hoặc mật khẩu");
                            CHECK_GV.Enabled = true;
                            CHECK_admin.Enabled = true;

                        }


                    }

                }

                if (CHECK_GV.Checked == true)
                {
                    //CHUYỂN MD5
                    String str = "";
                    Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(matkhau);
                    System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                    buffer = md5.ComputeHash(buffer);
                    foreach (Byte b in buffer)
                    {
                        str += b.ToString("X2");
                    }


                    if (tailhoan == "" || matkhau == "")
                    {
                        MessageBox.Show("Tài khoản và mật khẩu không được bỏ trống!");
                    }
                    else
                    {// TRUY VẤN VÀO BẢNG SINH VIÊN TRONG CSDL
                        string sql = "select *from GiangVien" + " where ID='" + tailhoan + "' and  Matkhau='" + str + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);

                        SqlDataReader dta = cmd.ExecuteReader();

                        if (dta.Read() == true)
                        {
                            XacMinhGV qt = new XacMinhGV(txt_User.Text);
                            qt.Show();
                            this.Hide();

                        }

                        else
                        {

                            MessageBox.Show("Sai Tài khoản hoặc mật khẩu");
                           
                        }


                    }

                }


                if (CHECK_SV.Checked == true)
                {
                    //CHUYỂN MD5
                    String str = "";
                    Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(matkhau);
                    System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                    buffer = md5.ComputeHash(buffer);
                    foreach (Byte b in buffer)
                    {
                        str += b.ToString("X2");
                    }


                    if (tailhoan == "" || matkhau == "")
                    {
                        MessageBox.Show("Tài khoản và mật khẩu không được bỏ trống!");
                    }
                    else
                    {//TRUY VẤN VÀO BẢNG SINH VIÊN TRONG CSDL
                        string sql = "select *from SinhVien" + " where MSSV='" + tailhoan + "' and  Matkhau='" + str + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);

                        SqlDataReader dta = cmd.ExecuteReader();

                        if (dta.Read() == true)
                        {
                            XacMinhSinhVien qt = new XacMinhSinhVien(txt_User.Text);
                            //Mở from quản trị nếu đăng nhập thành công
                            qt.Show();
                            this.Hide();

                        }

                        else
                        {

                            MessageBox.Show("Sai Tài khoản hoặc mật khẩu");

                        }


                    }

                }
            }
            catch
            {
                MessageBox.Show("Đăng nhập thất bại\n Kiểm tra lại\n 1.Tài khoản \n 2.Mật Khẩu\n 3.Vùng đăng nhập\n","Lỗi 01" );
            }
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void txt_QuenMk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ ADMIN để được đặt lại mật khẩu", "Thông báo");
        }
    }
}
