using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuLieuHocTap
{
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void ketnoicsdl()
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");

            DataSet data = new DataSet();
            string hienthi = "select * from SinhVien";
            ketnoi.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            dataGridView1.Refresh();




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_Ten.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
           txt_ID.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            com_GioiTinh.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_SDT.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt_Email.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txt_DiaChi.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();

            ///Doi mau labbel
            lab_ID.ForeColor = Color.Red;
            lab_Ten.ForeColor = Color.Red;
            lab_GioiTinh.ForeColor = Color.Red;
            lab_SDT.ForeColor = Color.Red;
            lab_Email.ForeColor = Color.Red;
            lab_DiaChi.ForeColor = Color.Red;
            Lab_NgaySinh.ForeColor = Color.Red;

        }

        private void btn_ThemSinhVien_Click(object sender, EventArgs e)
        {
            ThemSinhVien them = new ThemSinhVien();
            them.Show();

        }

        private void btn_Xoa_Click(object sender, EventArgs e)

        {
            btn_Luu.Enabled = true;

            btn_ThemSinhVien.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = true;
            btn_Reset.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_ThemSinhVien.Enabled=false;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = false;
            btn_Reset.Enabled = false;
        }

        private void btx_LamMoi_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
            btn_Luu.Enabled = false;
            btn_ThemSinhVien.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Reset.Enabled = true;

            //
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            Lab_NgaySinh.ForeColor = Color.Black;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            Lab_NgaySinh.ForeColor = Color.Black;
            //Xóa sinh viên
            if (btn_Xoa.Enabled == true)
            {
                try
                {
                    var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                    StreamReader sr = new StreamReader(txtpath);
                    String line = sr.ReadToEnd();
                    SqlConnection connXoa = new SqlConnection(@"" + line + "");
                    connXoa.Open();

                    string xoa = "Delete from SinhVien where MSSV='" + txt_ID.Text + "'";
                    SqlCommand deletedCmd = new SqlCommand(xoa, connXoa);
                    deletedCmd.CommandType = CommandType.Text;
                    deletedCmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    ketnoicsdl();
                    connXoa.Close();
                }
                catch
                {
                    MessageBox.Show("Sinh viên còn đang học!");
                }
                
            }

            //Sua CSDL
            if (btn_Sua.Enabled == true)


            {
                if (KiemTra())
                {
                   
                  
                        var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                        StreamReader sr = new StreamReader(txtpath);
                        String line = sr.ReadToEnd();
                        SqlConnection connSua = new SqlConnection(@"" + line + "");
                        connSua.Open();

                        string sua = "Update SinhVien set MSSV='" + txt_ID.Text + "',ten =N'" + txt_Ten.Text + "',GioiTinh= N'" + com_GioiTinh.Text + "',SDT= N'" + txt_SDT.Text + "',Email= '" + txt_Email.Text + "',DiaChi= N'" + txt_DiaChi.Text + "'  where mssv = '" + txt_ID.Text + "'";
                        SqlCommand updateCmd = new SqlCommand(sua, connSua);

                        string suaten= "update DiemDanh_LichHoc set Ten =N'" + txt_Ten.Text+"' where MSSV ='"+txt_ID.Text+"' ";
                        SqlCommand SUATEN = new SqlCommand(suaten, connSua);
                        SUATEN.CommandType= CommandType.Text;   
                        SUATEN.ExecuteNonQuery();
                        updateCmd.CommandType = CommandType.Text;
                        updateCmd.ExecuteNonQuery();
                        ketnoicsdl();
                    
                    

                }
                    


            }



            // Reset pasword
            if (btn_Reset.Enabled == true)
            {

                if (KiemTra())
                {
                    var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                    StreamReader sr = new StreamReader(txtpath);
                    String line = sr.ReadToEnd();
                    SqlConnection ketnoi = new SqlConnection(@"" + line + "");
                    ketnoi.Open();

                    //HAST MD5
                    String MatKhau = "";
                    Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt_ID.Text);
                    System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                    buffer = md5.ComputeHash(buffer);
                    foreach (Byte b in buffer)
                    {
                        MatKhau += b.ToString("X2");
                    }

                    string ReSet = "Update SinhVien set MatKhau='" + MatKhau + "' where MSSV = '" + txt_ID.Text + "'";
                    SqlCommand updateCmd = new SqlCommand(ReSet, ketnoi);
                    updateCmd.CommandType = CommandType.Text;
                    MessageBox.Show("Đặt lại mật khẩu cho " + txt_Ten.Text + " Thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    updateCmd.ExecuteNonQuery();
                    ketnoicsdl();
                }
                   
            }

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_ThemSinhVien.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Reset.Enabled = true;

        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {

            try
            {
                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection ketnoi = new SqlConnection(@"" + line + "");

                DataSet data = new DataSet();
                string hienthi = "select * from SinhVien where MSSV = '" + txt_Tim.Text + "'";
                ketnoi.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];

                dataGridView1.Refresh();
            }
            catch
            {

                MessageBox.Show("Không tìm thấy " + txt_ID.Text + ".", "THÔNG BÁO", MessageBoxButtons.OK);
            }

           
        }

        private void btn_TimGT_Click(object sender, EventArgs e)
        {
            try
            {
                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection ketnoi = new SqlConnection(@"" + line + "");

                DataSet data = new DataSet();
                string hienthi = "select * from SinhVien where GioiTinh = '" + com_GioiTinh.Text + "'";
                ketnoi.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];

                dataGridView1.Refresh();
            }
            catch
            {

                MessageBox.Show("Không tìm thấy " + txt_ID.Text + ".", "THÔNG BÁO", MessageBoxButtons.OK);
            }



        }

        bool KiemTra()
        {
            if (txt_ID.Text == "" || txt_Ten.Text == "" || com_GioiTinh.Text == "" || txt_SDT.Text == "" || txt_Email.Text == "" ||  txt_DiaChi.Text == "")
            {
                ketnoicsdl();
                MessageBox.Show("Bạn nhập thiếu!", "Nhập Thiếu", MessageBoxButtons.OK);
                return false;
            }
            return true;


        }

        private void btx_Xuat_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dataGridView1, saveFileDialog1.FileName);

            }
        }
        void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý học sinh";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void txt_ID_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Red;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            Lab_NgaySinh.ForeColor = Color.Black;
        }

        private void txt_Ten_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Red;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            Lab_NgaySinh.ForeColor = Color.Black;
        }

        private void com_GioiTinh_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Red;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            Lab_NgaySinh.ForeColor = Color.Black;
        }

        private void txt_SDT_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Red;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            Lab_NgaySinh.ForeColor = Color.Black;
        }

        private void txt_Email_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Red;
            lab_DiaChi.ForeColor = Color.Black;
            Lab_NgaySinh.ForeColor = Color.Black;
        }

        private void txt_DiaChi_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Red;
            Lab_NgaySinh.ForeColor = Color.Black;
        }

        private void txt_NgaySinh_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            Lab_NgaySinh.ForeColor = Color.Red;
        }
    }
}
