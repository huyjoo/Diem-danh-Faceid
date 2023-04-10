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
    public partial class LichDay : Form
    {
        string user;
        string ten;
        public LichDay(string user, string ten)
           
        {
            this.user = user;
            this.ten = ten; 
            InitializeComponent();
        }

        private void LichDay_Load(object sender, EventArgs e)
        {
            string thoigian = DateTime.Now.ToString("dd/MM/yyyy");
            txt_ThoiGian.Text = thoigian;
            lab_Ten.Text = ten;  
            lab_MSGV.Text = user;
            dodulieu();

        }


        void dodulieu()
        {
            try
            {
                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection ketnoi = new SqlConnection(@"" + line + "");

                DataSet data = new DataSet();
                string hienthi = "select DISTINCT  tenmon, cahoc, thoigianhoc, phonghoc  from DiemDanh_LichHoc where id = '" + lab_MSGV.Text + "' and thoigianhoc = '"+txt_ThoiGian.Text+"' ";
                ketnoi.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
                dataGridView1.Refresh();
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại", "Thông báo");
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int i;
                i = dataGridView1.CurrentRow.Index;
                Lab_TenMon.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                lab_ThoiGian.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                Lab_CaHoc.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                lab_PhongHoc.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
               

            }
            catch
            {
                MessageBox.Show("Loi");
            }
        }

        private void btn_Xemall_Click(object sender, EventArgs e)
        {
            try
            {
                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection ketnoi = new SqlConnection(@"" + line + "");

                DataSet data = new DataSet();
                string hienthi = "select DISTINCT  tenmon, cahoc, thoigianhoc, phonghoc  from DiemDanh_LichHoc where id = '" + lab_MSGV.Text + "' ";
                ketnoi.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
                dataGridView1.Refresh();
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại", "Thông báo");
            }
        }

        private void btn_Xemtheongay_Click(object sender, EventArgs e)
        {
            dodulieu();
        }
    }
}
