using Emgu.CV;
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
    public partial class DangKyMonHoc : Form
    {

        string MSSV;
        string TENSINHVIEN;
        public DangKyMonHoc(string id, string name)
        {
           
            
            this.MSSV = id;
            this.TENSINHVIEN = name;
            InitializeComponent();

            
        }
        private void ketnoicsdl()
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");

            DataSet data = new DataSet();
            string hienthi = "select * from ThoiKhoaBieu";
            ketnoi.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            dataGridView1.Refresh();
            



        }

        private void DangKiMonHoc_Load(object sender, EventArgs e)
        {
            lab_MSSV.Text = MSSV;
            lab_Ten.Text = TENSINHVIEN;
            ketnoicsdl();
            loaddangky();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");

            DataSet data = new DataSet();
            string hienthi = "select * from ThoiKhoaBieu where TenMon =N'"+txt_tim.Text+"'";
            ketnoi.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            dataGridView1.Refresh();

        }

        private void txt_tim_KeyDown(object sender, KeyEventArgs e)
        {
            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");

            DataSet data = new DataSet();
            string hienthi = "select * from ThoiKhoaBieu where TenMon =N'" + txt_tim.Text + "'";
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
            lab_MaLop.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            Lab_TenMonHoc.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            lab_MaGiangVien.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            lab_CaHoc.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            ThoiGian_Hoc.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            lab_Phong.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            lab_SoLuong.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            soluongdangky();




        }

        private void btn_DangKi_Click(object sender, EventArgs e)
        {
            if (checksoluon())
            {
                try
                {
                    var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                    StreamReader sr = new StreamReader(txtpath);
                    String line = sr.ReadToEnd();
                    SqlConnection Connection = new SqlConnection(@"" + line + "");
                    Connection.Open();
                    string massv = lab_MSSV.Text;
                    string maLop = lab_MaLop.Text;
                    string IDDiemdanh = massv + maLop;
                    string thoigian = "";
                    string trangthaidiemdanh = "null";
                    string insertStr = "Insert into DiemDanh_LichHoc VALUES (@Ten, @MSSV, @DiemDanh, @MaLop, @TenMon, @Cahoc , @ID,  @dateandtime, @IDDiemdanh, @ThoiGianHoc, @PhongHoc )";
                    SqlCommand insertCmd = new SqlCommand(insertStr, Connection);
                    insertCmd.Parameters.AddWithValue("ten", lab_Ten.Text);
                    insertCmd.Parameters.AddWithValue("MSSV", lab_MSSV.Text);
                    insertCmd.Parameters.AddWithValue("DiemDanh", trangthaidiemdanh);
                    insertCmd.Parameters.AddWithValue("MaLop", lab_MaLop.Text);
                    insertCmd.Parameters.AddWithValue("TenMon", Lab_TenMonHoc.Text);
                    insertCmd.Parameters.AddWithValue("CaHoc", lab_CaHoc.Text);
                    insertCmd.Parameters.AddWithValue("ID", lab_MaGiangVien.Text);
                    insertCmd.Parameters.AddWithValue("dateandtime", thoigian);
                    insertCmd.Parameters.AddWithValue("IDDiemDanh", IDDiemdanh);
                    insertCmd.Parameters.AddWithValue("ThoiGianHoc", ThoiGian_Hoc.Text);
                    insertCmd.Parameters.AddWithValue("PhongHoc", lab_Phong.Text);
                    insertCmd.ExecuteNonQuery();
                    loaddangky();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có thể bạn đã đăng kí rồi");
                }
            }
           
            
        }


        void loaddangky()
        {
            try
            {
                string mssv = lab_MSSV.Text;
                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection ketnoi = new SqlConnection(@"" + line + "");

                DataSet data = new DataSet();
                string hienthi = "select ten, mssv,malop,tenmon,id from DiemDanh_LichHoc WHERE MSSV = '" + mssv+"' ";
                ketnoi.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
                adapter.Fill(data);
                dataGridView2.DataSource = data.Tables[0];
                dataGridView2.Refresh();
            }
            catch
            {
                MessageBox.Show("Không hiển thị được lớp đăng kí","Lỗi 03");
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

                string xoa = "Delete from DiemDanh_LichHoc where mssv='" + lab_MSSV.Text + "' and malop = '" + lab_Malop_xoa.Text + "' ";
                SqlCommand deletedCmd = new SqlCommand(xoa, connXoa);
                deletedCmd.CommandType = CommandType.Text;
                deletedCmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                ketnoicsdl();
                loaddangky();
                connXoa.Close();
                lab_Malop_xoa.Text = "";
            }

            catch
            {
                MessageBox.Show("Chưa chọn lớp xóa!", "Thông báo");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dataGridView2.CurrentRow.Index;
            lab_Malop_xoa.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            dataGridView2.Refresh();


        }

        private void btnXuat_Click(object sender, EventArgs e)
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

        private void btn_Xuat2_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel2(dataGridView2, saveFileDialog1.FileName);

            }

        }
        void ToExcel2(DataGridView dataGridView1, string fileName)
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
                for (int i = 0; i < dataGridView2.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView2.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
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

        void soluongdangky()
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");
            ketnoi.Open();

            var cmd = new SqlCommand("SELECT count(*) as 'dangky' from DiemDanh_LichHoc where MaLop='"+lab_MaLop.Text+"' ", ketnoi);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cmb_Dangky.DisplayMember = "dangky";
            cmb_Dangky.DataSource = dt;
            lab_DangKy.Text = cmb_Dangky.Text;
        }

        bool checksoluon()
        {
            string soluong = lab_SoLuong.Text;
            string dangky = lab_DangKy.Text;
            if(soluong == dangky)
            {
                MessageBox.Show("Rất tiếc lớp học đã đủ");
                return false;
            }
           
            return true;
        }
             

    }
}
