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
    public partial class ThoiKhoaBieuSV : Form
    {
        string user;
        public ThoiKhoaBieuSV(string user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void ThoiKhoaBieuSV_Load(object sender, EventArgs e)
        {
            lab_MSSV.Text =user;
            string thoigian = DateTime.Now.ToString("dd/MM/yyyy ss,mm,HH");
            txt_ThoiGian.Text = thoigian;
            dodulieu();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dataGridView1.CurrentRow.Index;
                lab_Ten.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                Lab_TenMon.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                lab_ThoiGian.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                Lab_CaHoc.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                lab_PhongHoc.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                Lab_IDGV.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();

            }
            catch
            {
                MessageBox.Show("Loi");
            }
            
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
                string hienthi = "select ten, mssv, tenmon, cahoc, thoigianhoc, phonghoc ,id from DiemDanh_LichHoc where mssv = '" + lab_MSSV.Text + "' and thoigianhoc ='"+txt_ThoiGian.Text+"' ";
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

        private void btn_Xemall_Click(object sender, EventArgs e)
        {
            try
            {
                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection ketnoi = new SqlConnection(@"" + line + "");

                DataSet data = new DataSet();
                string hienthi = "select ten, mssv, tenmon, cahoc, thoigianhoc, phonghoc ,id from DiemDanh_LichHoc where mssv = '" + lab_MSSV.Text + "' ";
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
            try
            {
                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection ketnoi = new SqlConnection(@"" + line + "");

                DataSet data = new DataSet();
                string hienthi = "select ten, mssv, tenmon, cahoc, thoigianhoc, phonghoc ,id from DiemDanh_LichHoc where mssv = '" + lab_MSSV.Text + "' and thoigianhoc ='" + txt_ThoiGian.Text + "' ";
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
    }
}
