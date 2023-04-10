using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataTable = System.Data.DataTable;

namespace TuLieuHocTap
{
    public partial class NhanVien : Form
    {





        public NhanVien()
        {

            InitializeComponent();
        }



        private void NhanVien_Load(object sender, EventArgs e)
        {
            btn_Luu.Enabled = false;
            ketnoicsdl();



        }
        private void btn_ThemGiangVien_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Reset.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_ThemGiangVien.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = true;
            btn_Reset.Enabled = false;


        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_ThemGiangVien.Enabled = false;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = false;
            btn_Reset.Enabled = false;

        }


        private void ketnoicsdl()
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");

            DataSet data = new DataSet();
            string hienthi = "select * from GiangVien";
            ketnoi.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            dataGridView1.Refresh();




        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_ID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_Ten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            com_GioiTinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_SDT.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txt_Mail.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt_DiaChi.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            com_Khoa.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();


            //
            lab_ID.ForeColor = Color.Red;
            lab_Ten.ForeColor = Color.Red;
            lab_GioiTinh.ForeColor = Color.Red;
            lab_SDT.ForeColor = Color.Red;
            lab_Email.ForeColor = Color.Red;
            lab_DiaChi.ForeColor = Color.Red;
            lab_Khoa.ForeColor = Color.Red;



        }

        private void btx_LamMoi_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
            btn_Luu.Enabled = false;
            btn_ThemGiangVien.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Reset.Enabled = true;
            ///đổi màu
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            lab_Khoa.ForeColor = Color.Black;




        }

        private void btx_Reset_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_ThemGiangVien.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Reset.Enabled = true;

        }

        private void btx_Luu_Click(object sender, EventArgs e)
        {

            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            lab_Khoa.ForeColor = Color.Black;


            ///Them CSDL
            if (btn_ThemGiangVien.Enabled == true)
            {


                try
                {
                    if (KiemTra())
                    {
                        string trangthai = "1";
                        var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                        StreamReader sr = new StreamReader(txtpath);
                        String line = sr.ReadToEnd();
                        SqlConnection Connection = new SqlConnection(@"" + line + "");
                        Connection.Open();

                        string insertStr = "Insert into GiangVien VALUES (@id, @ten, @GioiTinh ,@SDT, @Email , @DiaChi, @MaKhoa, @MatKhau, @TrangThai)";
                        SqlCommand insertCmd = new SqlCommand(insertStr, Connection);
                        insertCmd.Parameters.AddWithValue("id", txt_ID.Text);
                        insertCmd.Parameters.AddWithValue("ten", txt_Ten.Text);
                        insertCmd.Parameters.AddWithValue("GioiTinh", com_GioiTinh.Text);
                        insertCmd.Parameters.AddWithValue("SDT", txt_SDT.Text);
                        insertCmd.Parameters.AddWithValue("Email", txt_Mail.Text);
                        insertCmd.Parameters.AddWithValue("DiaChi", txt_DiaChi.Text);
                        insertCmd.Parameters.AddWithValue("MaKhoa", com_Khoa.Text);
                        //HAST MD5
                        String MatKhau = "";
                        Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt_ID.Text);
                        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                        buffer = md5.ComputeHash(buffer);
                        foreach (Byte b in buffer)
                        {
                            MatKhau += b.ToString("X2");
                        }
                        insertCmd.Parameters.AddWithValue("MatKhau", MatKhau);

                        insertCmd.Parameters.AddWithValue("TrangThai", trangthai);

                        insertCmd.ExecuteNonQuery();
                        ketnoicsdl();
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }





            }
            //Sua CSDL
            if (btn_Sua.Enabled == true)
            {

                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection connSua = new SqlConnection(@"" + line + "");
                connSua.Open();

                
               
                string sua = "Update GiangVien set ID='" + txt_ID.Text + "',ten=N'" + txt_Ten.Text + "',GioiTinh= N'" + com_GioiTinh.Text + "',SDT= N'" + txt_SDT.Text + "',Email= '" + txt_Mail.Text + "',DiaChi= N'" + txt_DiaChi.Text + "',MaKhoa= N'" + com_Khoa.Text + "'  where id = '" + txt_ID.Text + "'";
                SqlCommand updateCmd = new SqlCommand(sua, connSua);
                string doithongtin ="update LopHoc  set Ten=N'"+txt_Ten.Text+ "'where ID = '" + txt_ID.Text + "'";
                SqlCommand doi = new SqlCommand(doithongtin, connSua);

                updateCmd.CommandType = CommandType.Text;
                doi.CommandType= CommandType.Text; 
                doi.ExecuteNonQuery();
                updateCmd.ExecuteNonQuery();
                ketnoicsdl();


            }
            //Xoa
            if (btn_Xoa.Enabled == true)
            {
                try
                {
                    var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                    StreamReader sr = new StreamReader(txtpath);
                    String line = sr.ReadToEnd();
                    SqlConnection connXoa = new SqlConnection(@"" + line + "");
                    connXoa.Open();

                    string xoa = "Delete from GiangVien where ID='" + txt_ID.Text + "'";
                    SqlCommand deletedCmd = new SqlCommand(xoa, connXoa);
                    deletedCmd.CommandType = CommandType.Text;
                    deletedCmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    ketnoicsdl();
                    connXoa.Close();
                }
                catch
                {
                    MessageBox.Show("Giảng viên có lịch dạy vui lòng xóa lịch của giảng viên trước!");
                }
            }






            //Reset pasword
            if (btn_Reset.Enabled == true)
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

                string ReSet = "Update GiangVien  set MatKhau='" + MatKhau + "' where id = '" + txt_ID.Text + "'";
                SqlCommand updateCmd = new SqlCommand(ReSet, ketnoi);
                updateCmd.CommandType = CommandType.Text;
                MessageBox.Show("Đã đặt lại mật khẩu!", "Thông báo");
                updateCmd.ExecuteNonQuery();
                ketnoicsdl();
            }


            btn_ThemGiangVien.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Reset.Enabled = false;





        }
        bool KiemTra()
        {
            if (txt_ID.Text == "" || txt_Ten.Text == "" || com_GioiTinh.Text == "" || txt_SDT.Text == "" || txt_Mail.Text == "" || com_Khoa.Text == "" || txt_DiaChi.Text == "")
            {
                ketnoicsdl();
                MessageBox.Show("Bạn nhập thiếu!", "Nhập Thiếu", MessageBoxButtons.OK);
                return false;
            }
            return true;


        }

        private void btn_TimTen_Click(object sender, EventArgs e)
        {

            try
            {
                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection ketnoi = new SqlConnection(@"" + line + "");

                DataSet data = new DataSet();
                string hienthi = "select * from GiangVien where MaKhoa = N'" + com_Khoa.Text + "'";
                ketnoi.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
                dataGridView1.Refresh();
            }
            catch
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
        private void btn_Tim_Click(object sender, EventArgs e)
        {



            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");

            DataSet data = new DataSet();
            string hienthi = "select * from GiangVien where id = '" + txt_Tim.Text + "'";
            ketnoi.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];

            dataGridView1.Refresh();
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
            lab_Khoa.ForeColor = Color.Black;

        }

        private void txt_Ten_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Red;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            lab_Khoa.ForeColor = Color.Black;

        }

        private void com_GioiTinh_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Red;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            lab_Khoa.ForeColor = Color.Black;

        }

        private void txt_SDT_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Red;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            lab_Khoa.ForeColor = Color.Black;

        }

        private void txt_Mail_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Red;
            lab_DiaChi.ForeColor = Color.Black;
            lab_Khoa.ForeColor = Color.Black;

        }

        private void txt_DiaChi_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Red;
            lab_Khoa.ForeColor = Color.Black;

        }

        private void com_Khoa_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            lab_Khoa.ForeColor = Color.Red;

        }

       



       


    }



}
