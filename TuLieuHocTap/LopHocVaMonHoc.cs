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
    public partial class LopHocVaMonHoc : Form
    {

        //Code được viết bởi Võ Tuấn Kiệt và Lê Văn Huy SV HUETCH
        //Liên hệ mail: votuankiet@kietvo.xyz
        //std: 0788987420
        public LopHocVaMonHoc()
        {
            InitializeComponent();
        }

        private void LopHocVaMonHoc_Load(object sender, EventArgs e)
        {
            btn_LuuMonHoc.Enabled = false;
            btn_LuuLop.Enabled = false;
            ketnoicsdl();
            loadIDGV();
            loadTENGV();
            LoadMonHoc();
            loadLopHoc();
        }


        void loadIDGV()
        {
            try
            {
                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection ketnoi = new SqlConnection(@"" + line + "");
                ketnoi.Open();

                var cmd = new SqlCommand("SELECT ID FROM GIANGVIEN", ketnoi);
                var dr = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(dr);
                dr.Dispose();
                cmb_ID_GV.DisplayMember = "ID";
                cmb_ID_GV.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Không kết nối được CSDL");
            }
            


        } //Hiển thị ID giảng viên vào combobox

        void loadTENGV()
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");
            ketnoi.Open();

            var cmd = new SqlCommand("SELECT ten FROM GIANGVIEN where id = '" + cmb_ID_GV.Text + "' ", ketnoi);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cmb_tenGV.DisplayMember = "ten";
            cmb_tenGV.DataSource = dt;


        }//Hiển thị tên giảng viên vào combobox
        void ketnoicsdl()
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");

            DataSet data = new DataSet();
            string hienthi = "select * from MonHoc";
            ketnoi.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            dataGridView1.Refresh();
        }//Đổ CSDL môn học

        void loadLopHoc()
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");

            DataSet data = new DataSet();
            string hienthi = "select * from LopHoc";
            ketnoi.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(hienthi, ketnoi);
            adapter.Fill(data);
            dataGridView2.DataSource = data.Tables[0];
            dataGridView2.Refresh();
        }

        void LoadMonHoc()
        {
            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");
            ketnoi.Open();

            var cmd = new SqlCommand("SELECT TenMonHoc FROM MonHoc", ketnoi);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cmb_Ten_MonHoc.DisplayMember = "TenMonHoc";
            cmb_Ten_MonHoc.DataSource = dt;
        }
        private void cmb_ID_GV_KeyDown(object sender, KeyEventArgs e)
        {
            loadTENGV();
        }//Nhấn ENTER TRONG COMBOX THÌ TÊN GIẢNG VIÊN SẼ HIỂN THỊ RA



        private void btn_ThemMonHoc_Click(object sender, EventArgs e)
        {
            btn_LuuMonHoc.Enabled = true;
            btn_SuaMonHoc.Enabled = false;
            btn_XoaMonHoc.Enabled = false;
            btn_ThemMonHoc.Enabled = true;
        }

        private void btn_XoaMonHoc_Click(object sender, EventArgs e)
        {
            btn_LuuMonHoc.Enabled = true;
            btn_SuaMonHoc.Enabled = false;
            btn_XoaMonHoc.Enabled = true;
            btn_ThemMonHoc.Enabled = false;
        }



        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
            loadIDGV();
            loadTENGV();
            LoadMonHoc();
            btn_SuaMonHoc.Enabled = true;
            btn_XoaMonHoc.Enabled = true;
            btn_ThemMonHoc.Enabled = true;
            btn_LuuMonHoc.Enabled = false;

        }



        private void btn_SuaMonHoc_Click(object sender, EventArgs e)
        {
            btn_LuuMonHoc.Enabled = true;
            btn_SuaMonHoc.Enabled = true;
            btn_XoaMonHoc.Enabled = false;
            btn_ThemMonHoc.Enabled = false;

        }

        private void btn_LuuMonHoc_Click(object sender, EventArgs e)
        {
            if (kiemtra()) //Gọi hàm kiểm tra nếu true thì thực hiện công việc
            {
                if (btn_ThemMonHoc.Enabled == true) //btn lưu được mở thì thực hiện.
                {
                    try
                    {
                        var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                        StreamReader sr = new StreamReader(txtpath);
                        String line = sr.ReadToEnd();
                        SqlConnection Connection = new SqlConnection(@"" + line + "");
                        Connection.Open();

                        string insertStr = "Insert into MonHoc VALUES (@MaMonHoc, @TenMonHoc, @TC )";
                        SqlCommand insertCmd = new SqlCommand(insertStr, Connection);
                        insertCmd.Parameters.AddWithValue("MaMonHoc", txt_Ma_MH.Text);
                        insertCmd.Parameters.AddWithValue("TenMonHoc", txt_TenMonHoc.Text);
                        insertCmd.Parameters.AddWithValue("TC", txt_TC.Text);
                        insertCmd.ExecuteNonQuery();

                        ketnoicsdl();
                        loadIDGV();
                        loadTENGV();
                        LoadMonHoc();
                        loadLopHoc();
                    }
                    catch //Lỗi đầu vào do người dùng nhập
                    {
                        MessageBox.Show("Mã có thể bị trùng hoặc bạn đã nhập sai định dạng", "Mã mỗi 02");
                        txt_Ma_MH.Focus();

                    }

                }

                if (btn_XoaMonHoc.Enabled == true)//btn xóa được mở thì thực hiện.

                {
                    try
                    {
                        var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                        StreamReader sr = new StreamReader(txtpath);
                        String line = sr.ReadToEnd();
                        SqlConnection connXoa = new SqlConnection(@"" + line + "");
                        connXoa.Open();

                        string xoa = "Delete from MonHoc where MaMonHoc='" + txt_Ma_MH.Text + "'";
                        SqlCommand deletedCmd = new SqlCommand(xoa, connXoa);
                        deletedCmd.CommandType = CommandType.Text;
                        deletedCmd.ExecuteNonQuery();
                        MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                        ketnoicsdl();
                        loadIDGV();
                        loadTENGV();
                        LoadMonHoc();
                        loadLopHoc();
                        connXoa.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Có thể bạn chưa chọn mã môn học cần xóa", "Mã mỗi 02");
                        txt_Ma_MH.Focus();
                    }
                }

                if (btn_SuaMonHoc.Enabled == true)
                {
                    try
                    {


                        var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                        StreamReader sr = new StreamReader(txtpath);
                        String line = sr.ReadToEnd();
                        SqlConnection connSua = new SqlConnection(@"" + line + "");
                        connSua.Open();

                        string sua = "Update MonHoc set MaMonHoc='" + txt_Ma_MH.Text + "',TenMonHoc=N'" + txt_TenMonHoc.Text + "', TC ='" + txt_TC.Text + "'   where MaMonHoc = '" + txt_Ma_MH.Text + "'";
                        SqlCommand updateCmd = new SqlCommand(sua, connSua);
                        updateCmd.CommandType = CommandType.Text;
                        updateCmd.ExecuteNonQuery();
                        ketnoicsdl();
                        loadIDGV();
                        loadTENGV();
                        LoadMonHoc();

                    }
                    catch
                    {
                        MessageBox.Show("Có thể bạn nhập sai mã môn học cần sữa", "Mã mỗi 02");
                        txt_Ma_MH.Focus();
                    }
                }


            }
        }

        //Kiểm tra dữ liệu nhập vào môn
        bool kiemtra()
        {
            if (txt_Ma_MH.Text == "")
            {
                MessageBox.Show("Chưa nhập mã!");
                txt_Ma_MH.Focus();
                return false;
            }

            if (txt_TenMonHoc.Text == "")
            {
                MessageBox.Show("Chưa nhập tên môn học!");
                txt_TenMonHoc.Focus();
                return false;
            }

            if (txt_TC.Text == "")
            {
                MessageBox.Show("Chưa nhập số tính chỉ!");
                txt_TC.Focus();
                return false;
            }
            return true;
        }

        //Kiểm tra dữ liệu nhập vào lớp
        bool kiemtralop()
        {
            if (txt_MaLop.Text == "")
            {
                MessageBox.Show("Chưa nhập mã lớp!");
                txt_Ma_MH.Focus();
                return false;
            }

            if (cmb_ID_GV.Text == "")
            {
                MessageBox.Show("ID giảng viên sai hoặc thiếu!");
                cmb_ID_GV.Focus();
                return false;
            }
            if (cmb_tenGV.Text == "")
            {
                MessageBox.Show("Tên giảng viên sai hoặc thiếu!");
                cmb_tenGV.Focus();
                return false;
            }


            if (cmb_Ten_MonHoc.Text == "")
            {
                MessageBox.Show("Tên môn học sai hoặc thiếu!!");
                cmb_Ten_MonHoc.Focus();
                return false;
            }
            return true;
        }


        //Đỗ dữ liệu vào textBox....Môn học
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_Ma_MH.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_TenMonHoc.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_TC.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

        }
       

        //Phần Lớp học***

        private void btn_ThemLop_Click(object sender, EventArgs e)
        {
            btn_LuuLop.Enabled = true;
            btn_ThemLop.Enabled = true;
            btn_Xoalop.Enabled = false;
            btn_Sualop.Enabled = false;
        }

        private void btn_Xoalop_Click(object sender, EventArgs e)
        {
            btn_LuuLop.Enabled = true;
            btn_ThemLop.Enabled = false;
            btn_Xoalop.Enabled = true;
            btn_Sualop.Enabled = false;

        }

        private void btn_Sualop_Click(object sender, EventArgs e)
        {
            btn_LuuLop.Enabled = true;
            btn_ThemLop.Enabled = false;
            btn_Xoalop.Enabled = false;
            btn_Sualop.Enabled = true;
        }

        private void btn_LuuLop_Click(object sender, EventArgs e)
        {
            if (kiemtralop())
            {
                if(btn_Sualop.Enabled == true)
                {
                        try
                    {
                        var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                        StreamReader sr = new StreamReader(txtpath);
                        String line = sr.ReadToEnd();
                        SqlConnection connSua = new SqlConnection(@"" + line + "");
                        connSua.Open();

                        string sua = "Update LopHoc set MaLop='" + txt_MaLop.Text + "',ID=N'" + cmb_ID_GV.Text + "', Ten =N'" + cmb_tenGV.Text + "', MonHoc =N'" + cmb_Ten_MonHoc.Text + "'   where MaLop = '" + txt_MaLop.Text + "'";
                        SqlCommand updateCmd = new SqlCommand(sua, connSua);
                        updateCmd.CommandType = CommandType.Text;
                        updateCmd.ExecuteNonQuery();
                        ketnoicsdl();
                        loadIDGV();
                        loadTENGV();
                        LoadMonHoc();
                        loadLopHoc();
                    }
                    catch
                    {
                        MessageBox.Show("Mã có thể bị trùng hoặc bạn đã nhập sai định dạng", "Mã mỗi 02");
                        txt_MaLop.Focus();
                    }
                       

                    
                   
                }//Sửa lớp học
                if(btn_ThemLop.Enabled == true)
                {
                    try
                    {
                        var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                        StreamReader sr = new StreamReader(txtpath);
                        String line = sr.ReadToEnd();
                        SqlConnection Connection = new SqlConnection(@"" + line + "");
                        Connection.Open();

                        string insertStr = "Insert into LopHoc VALUES (@MaLop, @ID, @Ten, @MonHoc )";
                        SqlCommand insertCmd = new SqlCommand(insertStr, Connection);
                        insertCmd.Parameters.AddWithValue("MaLop", txt_MaLop.Text);
                        insertCmd.Parameters.AddWithValue("ID", cmb_ID_GV.Text);
                        insertCmd.Parameters.AddWithValue("Ten", cmb_tenGV.Text);
                        insertCmd.Parameters.AddWithValue("MonHoc", cmb_Ten_MonHoc.Text);
                        
                        insertCmd.ExecuteNonQuery();
                        ketnoicsdl();
                        loadIDGV();
                        loadTENGV();
                        LoadMonHoc();
                        loadLopHoc();

                    }
                    catch
                    {
                        MessageBox.Show("Mã có thể bị trùng hoặc bạn đã nhập sai định dạng", "Mã mỗi 02");
                        txt_MaLop.Focus();
                    }
                }//Thêm lớp học
                if (btn_Xoalop.Enabled == true)
                {

                    try
                    {
                        var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                        StreamReader sr = new StreamReader(txtpath);
                        String line = sr.ReadToEnd();
                        SqlConnection connXoa = new SqlConnection(@"" + line + "");
                        connXoa.Open();

                        string xoa = "Delete from LopHoc where MaLop='" + txt_MaLop.Text + "'";
                        SqlCommand deletedCmd = new SqlCommand(xoa, connXoa);
                        deletedCmd.CommandType = CommandType.Text;
                        deletedCmd.ExecuteNonQuery();
                        MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                        ketnoicsdl();
                        loadIDGV();
                        loadTENGV();
                        LoadMonHoc();
                        loadLopHoc();
                        connXoa.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Có thể lớp này chưa học xong, cần xóa lớp học trước");
                        txt_MaLop.Focus();
                    }
                }
                
            }
        }

        private void btn_LamMoiLop_Click(object sender, EventArgs e)
        {
            btn_LuuLop.Enabled = false;
            btn_ThemLop.Enabled = true;
            btn_Xoalop.Enabled = true;
            btn_Sualop.Enabled = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            txt_MaLop.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            cmb_ID_GV.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            cmb_tenGV.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            cmb_Ten_MonHoc.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_TimMonHoc_Click(object sender, EventArgs e)
        {
            try
            {
                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                SqlConnection ketnoi = new SqlConnection(@"" + line + "");

                DataSet data = new DataSet();
                string hienthi = "select * from MonHoc where MaMonHoc = '" + txt_Ma_MH.Text + "'";
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
    }
}
