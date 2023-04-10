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
    public partial class CaNhanGiangVien : Form
    {
        string user;
        string ten;
        public CaNhanGiangVien(string user, string ten)
        {
            this.user = user;
            this.ten = ten; 
            InitializeComponent();
        }

        private void CaNhanGiangVien_Load(object sender, EventArgs e)
        {
            lab_MSGV.Text = user;
            lab_Ten.Text = ten;
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                try
                {

                    var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                    StreamReader sr = new StreamReader(txtpath);
                    String line = sr.ReadToEnd();
                    SqlConnection conn = new SqlConnection(@"" + line + "");
                    conn.Open();
                    string tailhoan = lab_MSGV.Text;
                    string matkhau = txt_MK_CU.Text;
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
                        string sql = "select *from GiangVien" + " where ID='" + tailhoan + "' and  Matkhau='" + str + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);

                        SqlDataReader dta = cmd.ExecuteReader();

                        if (dta.Read() == true)
                        {

                            doimatkhau();

                        }

                        else
                        {

                            MessageBox.Show("Mật khẩu cũ nhập không chính xác");

                        }
                    }


                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối", "Thông báo");
                }

            }

        }


        bool kiemtra()
        {
            if (txt_MK_CU.Text == "")
            {
                MessageBox.Show("Trường nhập thiếu", "Thông báo");
                return false;
            }

            if (txt_MK_Moi.Text == "")
            {
                MessageBox.Show("Trường bắt buộc", "Thông báo");
                txt_MK_Moi.Focus();

                return false;
            }
            if (txt_NhapLai.Text == "")
            {
                MessageBox.Show("Trường bắt buộc", "Thông báo");
                txt_NhapLai.Focus();

                return false;
            }

            if (txt_MK_Moi.Text != txt_NhapLai.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp", "Thông báo");
                return false;
            }

            return true;
        }

        public void doimatkhau()
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");
            ketnoi.Open();

            //HAST MD5
            String MatKhau = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt_NhapLai.Text);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                MatKhau += b.ToString("X2");
            }

            string ReSet = "Update GiangVien set MatKhau='" + MatKhau + "' where ID = '" + lab_MSGV.Text + "'";
            SqlCommand updateCmd = new SqlCommand(ReSet, ketnoi);
            updateCmd.CommandType = CommandType.Text;
            MessageBox.Show("Đặt lại mật khẩu cho " + lab_Ten.Text + " Thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            updateCmd.ExecuteNonQuery();


        }
    }
}
