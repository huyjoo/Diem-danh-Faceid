using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TuLieuHocTap
{
    public partial class XacMinhGV : Form
    {
        private System.Windows.Forms.Timer aTimer;
        private int counter = 30;
        string id;
        int OTP;
        Random random = new Random();
        public XacMinhGV(string id)
        {
            this.id = id;       
            InitializeComponent();
        }

        private void XacMinhGV_Load(object sender, EventArgs e)
        {
            txtID.Text = id;
            GetMail();
        }

        private void Gữi_Click(object sender, EventArgs e)
        {
           
           
            if (OTP.ToString().Equals(txt_Ma.Text))

            {
               
                thanhcong();
                HomeGiangVien sinhvien = new HomeGiangVien(txtID.Text);
                sinhvien.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mã OTP không chính xác!");
                khongthanhcong();
            }

        }


        void GetMail()
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");
            ketnoi.Open();

            var cmd = new SqlCommand("SELECT Email FROM Giangvien where ID = '" + txtID.Text + "'", ketnoi);
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
                    Timeout = 120000

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

        private void lab_GuiLai_Click(object sender, EventArgs e)
        {
            lab_Loinhan.Text = "Nhập OTP để xác minh";
            lab_Loinhan.ForeColor = Color.Black;
            counter = 60;
            chaythoigian();
            lab_GuiLai.ForeColor = Color.Red;
            try
            {

              
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
                    Timeout = 120000

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

      void chaythoigian() //Khởi chạy bắt đầu giời

        {
            aTimer = new System.Windows.Forms.Timer();

            aTimer.Tick += new EventHandler(timer1_Tick_1);

            aTimer.Interval = 1000; // 1 second

            aTimer.Start();

            lab_ThoiGian.Text = counter.ToString();

            aTimer.Start();
        }
       
       
       

        

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            counter--;

            if (counter == 0)
            {
                OTP = random.Next(100000, 1000000);//Thời gian = 0 thì eandum một mã mới

                aTimer.Stop();
                lab_Loinhan.Text = "OTP hết hạn"; //chuyển lời nhắn sang hết hạn
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
