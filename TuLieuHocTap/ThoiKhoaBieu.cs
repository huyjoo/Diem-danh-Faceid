using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuLieuHocTap
{
    public partial class ThoiKhoaBieu : Form
    {
        public ThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void ThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            //lấy kích thước của màn hình
            
            btn_Luu.Enabled = false;
            cmb_TenGV.Enabled = false;  
            cmb_TMH.Enabled = false;    
            CNCSDL();
            HienThiMaLop();
            HienThiThongTin();

        }

        void HienThiMaLop()
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");
            ketnoi.Open();

            var cmd = new SqlCommand("SELECT MALOP FROM  LopHoc ", ketnoi);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cmb_MaLop.DisplayMember = "MALOP";
            cmb_MaLop.DataSource = dt;
           
        }
         void HienThiThongTin () //Hiển thị thông tin với điều kiện có mã lớp
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
        String line = sr.ReadToEnd();
        SqlConnection ketnoi = new SqlConnection(@"" + line + "");
        ketnoi.Open();

            var cmd = new SqlCommand("SELECT ID,MonHoc FROM  LopHoc where MaLop ='"+cmb_MaLop.Text+"' ", ketnoi);
        var dr = cmd.ExecuteReader();
        var dt = new DataTable();
        dt.Load(dr);
            dr.Dispose();
            cmb_TMH.DisplayMember = "MonHoc";
            cmb_TMH.DataSource = dt;
            cmb_TenGV.DisplayMember = "ID";
            cmb_TenGV.DataSource = dt;
        }
         void CNCSDL()
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

        private void cmb_MaLop_KeyDown(object sender, KeyEventArgs e)
        {
            HienThiThongTin();
            
        }

        private void cmb_MaLop_MouseDown(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            btn_Luu.Enabled = true;
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Them.Enabled = true;

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Them.Enabled = false;
            cmb_MaLop.Enabled = false;
            cmb_CaHoc.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btn_Luu.Enabled = true;
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = true;
            btn_Them.Enabled = false;
            cmb_MaLop.Enabled = false;
            cmb_TenGV.Enabled = false;
            cmb_TMH.Enabled = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Cahoc.ForeColor = Color.Black;
            lab_Hong.ForeColor = Color.Black;
            lab_Link.ForeColor = Color.Black;
            lab_ThoiGian.ForeColor = Color.Black;
            if (kiemtra())
            {
                if (btn_Them.Enabled == true)
                {
                    try  
                    {
                        var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                        StreamReader sr = new StreamReader(txtpath);
                        String line = sr.ReadToEnd();
                        SqlConnection Connection = new SqlConnection(@"" + line + "");
                        Connection.Open();
                        string lop = cmb_MaLop.Text;
                        string cahoc = cmb_CaHoc.Text;
                        
                        string tkb = lop + cahoc;
                        string insertStr = "Insert into ThoiKhoaBieu VALUES (@MaLop, @TenMon, @IDGiangVien , @CaHoc, @LinkMeet, @PhongHoc, @maTKB, @SoLuong,@ThoiGian)";
                        SqlCommand insertCmd = new SqlCommand(insertStr, Connection);
                        insertCmd.Parameters.AddWithValue("MaLop", cmb_MaLop.Text);
                        insertCmd.Parameters.AddWithValue("TenMon", cmb_TMH.Text);
                        insertCmd.Parameters.AddWithValue("IDGiangVien", cmb_TenGV.Text);
                        insertCmd.Parameters.AddWithValue("CaHoc", cmb_CaHoc.Text);
                        insertCmd.Parameters.AddWithValue("LinkMeet", txt_Link.Text);
                        insertCmd.Parameters.AddWithValue("PhongHoc", cmb_PhongHoc.Text);
                        insertCmd.Parameters.AddWithValue("maTKB", tkb);
                        insertCmd.Parameters.AddWithValue("SoLuong", txt_SoLuong.Text);
                        insertCmd.Parameters.AddWithValue("ThoiGian", date_ThoiGian.Text);

                        insertCmd.ExecuteNonQuery();
                        CNCSDL();
                        HienThiMaLop();
                        HienThiThongTin();
                        MessageBox.Show("Đã lưu thành công", "Thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Kiểm tra lại thời học","Thông báo");
                        cmb_CaHoc.Focus();
                    }
                   
                }

                if(btn_Xoa.Enabled == true)
                {
                    try
                    {

                        string lop = cmb_MaLop.Text;
                        string cahoc = cmb_CaHoc.Text;
                        string tkb = lop + cahoc;
                        var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                        StreamReader sr = new StreamReader(txtpath);
                        String line = sr.ReadToEnd();
                        SqlConnection connXoa = new SqlConnection(@"" + line + "");
                        connXoa.Open();

                        string xoa = "Delete from ThoiKhoaBieu where maTKB='" + tkb + "'";
                        SqlCommand deletedCmd = new SqlCommand(xoa, connXoa);
                        deletedCmd.CommandType = CommandType.Text;
                        deletedCmd.ExecuteNonQuery();
                        CNCSDL();
                        HienThiMaLop();
                        HienThiThongTin();
                        connXoa.Close();
                        MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                        
                    }
                       
 
                    catch
                    {
                        MessageBox.Show("Xóa không thành công!", "Thông báo");


                    }
                }
                if(btn_Sua.Enabled == true)
                {
                    try
                    {
                        
                        var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                        StreamReader sr = new StreamReader(txtpath);
                        String line = sr.ReadToEnd();
                        SqlConnection Connection = new SqlConnection(@"" + line + "");
                        Connection.Open();
                        string lop = cmb_MaLop.Text;
                        string cahoc = cmb_CaHoc.Text;

                        string tkb = lop + cahoc;
                        string sua = "update Thoikhoabieu set Malop ='"+cmb_MaLop.Text+"', tenmon=N'"+ cmb_TMH.Text+ "', ID ='"+cmb_TenGV.Text+"', Cahoc='"+cmb_CaHoc.Text+"', LinkMeet='"+txt_Link.Text+"', ThoiGian='"+date_ThoiGian.Text+"', phonghoc='"+cmb_PhongHoc.Text+"',soluong='"+txt_SoLuong.Text+"' where MAtkb ='"+tkb+"' ";
                        SqlCommand suaCmd = new SqlCommand(sua, Connection);
                        suaCmd.ExecuteNonQuery();
                        CNCSDL();
                        HienThiMaLop();
                        HienThiThongTin();
                        MessageBox.Show("Đã sửa thành công", "Thông báo");
                    }
                    catch
                    {
                        MessageBox.Show("Không sửa được");
                    }
                }
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
           
            
            CNCSDL();
            HienThiMaLop();
            HienThiThongTin();
            btn_Luu.Enabled = false;
            btn_Xoa.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Them.Enabled = true;
            cmb_MaLop.Enabled = true;
            ///đổi màu
            lab_ID.ForeColor = Color.Black;
            lab_Cahoc.ForeColor = Color.Black;
            lab_Hong.ForeColor = Color.Black;
            lab_Link.ForeColor = Color.Black;
            lab_ThoiGian.ForeColor = Color.Black;
          
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
                string hienthi = "select * from ThoiKhoaBieu where MaLop = '" + cmb_MaLop.Text + "'";
                ketnoi.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];

                dataGridView1.Refresh();
            }
            catch
            {

                MessageBox.Show("Không tìm thấy " + cmb_MaLop.Text + ".", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }


        bool kiemtra()
        {
            if(cmb_MaLop.Text == "" || cmb_TenGV.Text == "" || cmb_TMH.Text == "" ||date_ThoiGian.Text == "" || cmb_CaHoc.Text ==  "" || txt_Link.Text == "" || cmb_PhongHoc.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu hoặc sai định dạng");
                return false;   
            }    
            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            cmb_MaLop.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            cmb_TMH.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            cmb_TenGV.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            cmb_CaHoc.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txt_Link.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            cmb_PhongHoc.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txt_SoLuong.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            date_ThoiGian.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
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

        private void date_ThoiGian_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Cahoc.ForeColor = Color.Black;
            lab_Hong.ForeColor = Color.Black;
            lab_Link.ForeColor = Color.Black;
            lab_ThoiGian.ForeColor = Color.Red;
        }

        private void cmb_CaHoc_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Cahoc.ForeColor = Color.Red;
            lab_Hong.ForeColor = Color.Black;
            lab_Link.ForeColor = Color.Black;
            lab_ThoiGian.ForeColor = Color.Black;
        }

        private void txt_Link_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Cahoc.ForeColor = Color.Black;
            lab_Hong.ForeColor = Color.Black;
            lab_Link.ForeColor = Color.Red;
            lab_ThoiGian.ForeColor = Color.Black;
        }

        private void cmb_PhongHoc_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Cahoc.ForeColor = Color.Black;
            lab_Hong.ForeColor = Color.Red;
            lab_Link.ForeColor = Color.Black;
            lab_ThoiGian.ForeColor = Color.Black;
        }

        private void cmb_MaLop_MouseClick(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Red;
            lab_Cahoc.ForeColor = Color.Black;
            lab_Hong.ForeColor = Color.Black;
            lab_Link.ForeColor = Color.Black;
            lab_ThoiGian.ForeColor = Color.Black;

        }

        private void btn_TaoLink_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://meet.google.com/?pli=1");
            Process.Start(sInfo);
        }
    }
}
