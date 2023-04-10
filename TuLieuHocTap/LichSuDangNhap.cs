using Microsoft.Office.Interop.Excel;
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
    public partial class LichSuDangNhap : Form
    {
        public LichSuDangNhap()
        {
            InitializeComponent();
        }

        private void LichSuDangNhap_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            
        }


        void ketnoicsdl()
        {
            try

            {

                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection ketnoi = new SqlConnection(@"" + line + "");

                DataSet data = new DataSet();
                string hienthi = "select * from LichSuDangNhap";
                ketnoi.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_TimVoiNgay_Click(object sender, EventArgs e)
        {
            try

            {

                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection ketnoi = new SqlConnection(@"" + line + "");

                DataSet data = new DataSet();
                string hienthi = "select * from LichSuDangNhap where thoigian ='" + txt_Nhap.Text + "'";
                ketnoi.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_TimVoiID_Click(object sender, EventArgs e)
        {
            try

            {

                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection ketnoi = new SqlConnection(@"" + line + "");

                DataSet data = new DataSet();
                string hienthi = "select * from LichSuDangNhap where id ='" + txt_Nhap.Text + "'";
                ketnoi.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_TimVoiMail_Click(object sender, EventArgs e)
        {
            try

            {

                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection ketnoi = new SqlConnection(@"" + line + "");

                DataSet data = new DataSet();
                string hienthi = "select * from LichSuDangNhap where email ='" + txt_Nhap.Text + "'";
                ketnoi.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            try
            {
                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection connXoa = new SqlConnection(@"" + line + "");
                connXoa.Open();

                string xoa = "Delete from LichSuDangNhap where id='" + txt_Nhap.Text + "'";
                SqlCommand deletedCmd = new SqlCommand(xoa, connXoa);
                deletedCmd.CommandType = CommandType.Text;
                deletedCmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                ketnoicsdl();
                connXoa.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_Nhap.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
        }

        private void btn_XuatFile_Click(object sender, EventArgs e)
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

        private void btn_KhongThanhCong_Click(object sender, EventArgs e)
        {

            try

            {

                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection ketnoi = new SqlConnection(@"" + line + "");

                DataSet data = new DataSet();
                string hienthi = "select * from LichSuDangNhap where trangthai =N'Không thành công'";
                ketnoi.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
                dataGridView1.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1 & e.Value != null)
                {

                    int trangthai = Convert.ToInt32(e.Value);
                    if (trangthai == 0)

                        e.CellStyle.BackColor = Color.Red;

                }
            }
            catch
            {
                MessageBox.Show("Đừng thao tác quá nhiều");
            }
        }
    }
}
