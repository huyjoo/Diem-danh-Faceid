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
using System.Net.Mail;
using System.Net;


namespace TuLieuHocTap
{
    public partial class XacMinhSinhVien : Form
    {
        private System.Windows.Forms.Timer aTimer;
        string MSSV;
        int OTP;
        private int counter = 30;
        Random random = new Random();
       
        public XacMinhSinhVien(string mSSV)
        {
            InitializeComponent();
            this.MSSV= mSSV;
        }

        private void XacMinhSinhVien_Load(object sender, EventArgs e)
        {
            
            txtID.Text = MSSV;
           
            GetMail();

        }

        void GetMail()
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");
            ketnoi.Open();

            var cmd = new SqlCommand("SELECT Email FROM SinhVien where MSSV = '"+txtID.Text+"'", ketnoi);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            Mail.DisplayMember = "Email";
            Mail.DataSource = dt;
            Lab_Email.Text = Mail.Text;

            try
            {
                chaythoigian();
                OTP = random.Next(100000, 1000000);

                var fromAddress = new System.Net.Mail.MailAddress("123adufff@gmail.com", "KIET HUY");
                var toAddress = new MailAddress(Mail.Text);
                const string frompass = "sbpphbnmrijlmuwp";
                const string subject = "OTP CODE";

                string body = "Ma xac thuc cua ban la:" + OTP.ToString() + "\nPhan mem quan ly va diem danh bang khuong mat\nCopyright by KIET - HUY, 2022";
                var smtp = new SmtpClient
                {
                    Host = " smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, frompass),
                    Timeout = 200000

                };
                using (var message = new MailMessage(fromAddress, toAddress)


                {
                    Subject = subject,
                    Body = body,




                })
                {
                    smtp.Send(message);
                }
                
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }




        }

        private void btn_XacMinh_Click(object sender, EventArgs e)
        {

            if (OTP.ToString().Equals(txt_Ma.Text))

            {
                thanhcong();
                HomeSinhVien sinhvien = new HomeSinhVien(txtID.Text);
                sinhvien.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mã OTP không chính xác!");
                khongthanhcong();
            }

        }

        private void lab_GuiLai_Click(object sender, EventArgs e)
        {
            lab_Loinhan.Text = "Nhập OTP để xác minh";
            lab_Loinhan.ForeColor = Color.Black;
            counter = 60;
            chaythoigian();
            lab_GuiLai.ForeColor = Color.Red;
            try
            {
                lab_GuiLai.ForeColor = Color.Red;
                OTP = random.Next(100000, 1000000);

                var fromAddress = new System.Net.Mail.MailAddress("123adufff@gmail.com", "KIET HUY");
                var toAddress = new MailAddress(Mail.Text);
                const string frompass = "sbpphbnmrijlmuwp";
                const string subject = "OTP CODE";

                string body = "Ma xac thuc cua ban la:" + OTP.ToString() + "\nPhan mem quan ly va diem danh bang khuong mat\nCopyright by KIET - HUY, 2022";
                var smtp = new SmtpClient
                {
                    Host = " smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, frompass),
                    Timeout = 200000

                };
                using (var message = new MailMessage(fromAddress, toAddress)


                {
                    Subject = subject,
                    Body = body,




                })
                {
                    smtp.Send(message);
                }

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

        }

        void thanhcong()
        {
            try
            {
                
                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection Connection = new SqlConnection(@"" + line + "");
                Connection.Open();
                string thoigian = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                string trangthaidangnhap = "1";
                string insertStr = "Insert into LichSuDangNhap VALUES (@id, @trangthai , @EMail, @thoigian)";
                SqlCommand insertCmd = new SqlCommand(insertStr, Connection);
                insertCmd.Parameters.AddWithValue("id",txtID.Text);
                insertCmd.Parameters.AddWithValue("trangthai", trangthaidangnhap);
                insertCmd.Parameters.AddWithValue("EMail", Lab_Email.Text);
                insertCmd.Parameters.AddWithValue("thoigian", thoigian);


                insertCmd.ExecuteNonQuery();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        void khongthanhcong()
        {
            try
            {

                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection Connection = new SqlConnection(@"" + line + "");
                Connection.Open();
                string thoigian = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                string trangthaidangnhap = "0";
                string insertStr = "Insert into LichSuDangNhap VALUES (@id, @trangthai , @EMail, @thoigian)";
                SqlCommand insertCmd = new SqlCommand(insertStr, Connection);
                insertCmd.Parameters.AddWithValue("id", txtID.Text);
                insertCmd.Parameters.AddWithValue("trangthai", trangthaidangnhap);
                insertCmd.Parameters.AddWithValue("EMail", Lab_Email.Text);
                insertCmd.Parameters.AddWithValue("thoigian", thoigian);


                insertCmd.ExecuteNonQuery();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        void chaythoigian()
        {
            aTimer = new System.Windows.Forms.Timer();

            aTimer.Tick += new EventHandler(timer1_Tick);

            aTimer.Interval = 1000; // 1 second

            aTimer.Start();

            lab_ThoiGian.Text = counter.ToString();

            aTimer.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;

            if (counter == 0)
            {
                OTP = random.Next(100000, 1000000);

                aTimer.Stop();
                lab_Loinhan.Text = "OTP hết hạn";
                lab_Loinhan.ForeColor = Color.Red;
            }
            lab_ThoiGian.Text = counter.ToString();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login dx = new Login();
            dx.Show();
            this.Hide();
        }
    }
}
