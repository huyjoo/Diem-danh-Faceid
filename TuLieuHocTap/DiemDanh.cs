using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Speech.Synthesis;

namespace TuLieuHocTap
{
    public partial class DiemDanh : Form
    {
        string id;
        string ten;
        
        //initializing 
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        Image<Gray, byte> gray, result, result2, result3, result4, TrainedFace = null, TrainedEyes = null, TrainedMouth = null, TrainedNose = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        //Initializing a list to save detected names of students
        List<string> NamePersons = new List<string>();
        string name = null, names = null;
        int t, ContTrain, NumLabels;
        int a = 0;
        int b = 0;
        int c = 0;

        HaarCascade eyes; //detectiom by eyes
        HaarCascade mouth;
        HaarCascade nose;

        SqlConnection con; //connection

        private void XUAT_Click(object sender, EventArgs e)
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

        private HashSet<string> FacesAlreadyDetected = new HashSet<string>();

        private void resetAttendanceButton_Click(object sender, EventArgs e)
        {
            quetlai();
            FacesAlreadyDetected.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");
            ketnoi.Open();

            string thoigian = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            string diemdanh = "Có mặt";
            string sua = "Update DiemDanh_LichHoc set dateandtime='" + thoigian + "', Diemdanh=N'" + diemdanh + "' where MSSV ='" + txt_dd_id.Text + "'";
            SqlCommand cmd = new SqlCommand(sua, ketnoi);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            capnhat();
           


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dataGridView1.CurrentRow.Index;
            txt_dd_ten.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txt_dd_id.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadSV();//CHẠY HÀM HIỂN THỊ SINH VIÊN  VẮNG  NULL
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo một đối tượng SpeechSynthesizer
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                ReadOnlyCollection<InstalledVoice> voices = synthesizer.GetInstalledVoices();
                // Chọn bộ nhớ đệm để sử dụng (ví dụ: "eSpeak-vietnam")
                synthesizer.SelectVoice("eSpeak-vietnam");

                //synthesizer.Rate = -7;
                // Chuyển đổi văn bản thành giọng nói
                synthesizer.Speak(txt_dd_ten.Text + "có mặt không");
            }
            catch
            {

            }
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grabber = new Capture();
            grabber.QueryFrame();
            Application.Idle += new EventHandler(FrameGrabber);
            btn_BatCam.Enabled = false;
            capnhat();

        }
        
        public DiemDanh( string id, string ten)
        {
            this.id = id;
            this.ten = ten;
            InitializeComponent();
            face = new HaarCascade("haarcascade-frontalface-default.xml");
            try
            {   
                //Load previous trainned faces of students and their names
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedNames.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    //make a list of string
                    labels.Add(Labels[tf]); 
                }

              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FrameGrabber(object sender, EventArgs e)
        {
            try
            {
                NamePersons.Add("");
                //Detect number of faces on screen
                label5.Text = "0";

                //Get the current frame form capture device
                currentFrame = grabber.QueryFrame().Resize(501, 407, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);


                //Chuyen hinh thanh do xam
                gray = currentFrame.Convert<Gray, Byte>();

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
              face,
              1.3,
              10,
              Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
              new Size(20, 20));







                //Hanh dong cho tug phan tu duoc phat hien
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    t = t + 1;
                    result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                    //draw the face detected in the 0th (gray) channel with blue color
                    currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);
                    //initialize result,t and gray if (trainingImages.ToArray().Length != 0)
                    {
                        //term criteria against each image to find a match with it, perform different iterations
                        MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);
                        //call class by creating object and pass parameters
                        EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                             trainingImages.ToArray(),
                             labels.ToArray(),
                             5000,
                             ref termCrit);
                        //next step is to name find for recognize face
                        name = recognizer.Recognize(result);
                        //now show recognized person name so
                        currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));//initalize font for the name captured

                    }



                    if (!FacesAlreadyDetected.Contains(name))
                    {
                        SaveToDatabase(name, DateTime.Now);
                        FacesAlreadyDetected.Add(name);

                        //Show dữ liệu nhận dạng  từ CSDL lên DatagridView
                        var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                        StreamReader sr = new StreamReader(txtpath);
                        String line = sr.ReadToEnd();
                        con = new SqlConnection(@"" + line + "");
                        SqlDataAdapter checkup = new SqlDataAdapter("SELECT * FROM DiemDanh_LichHoc WHERE malop ='" + com_maLop.Text + "' ", con);               //this will get all marked attendance from the database
                        DataTable sd = new DataTable();

                        checkup.Fill(sd);
                        dataGridView1.DataSource = sd;

                        DataTable sd1 = new DataTable();
                        sd1 = sd.DefaultView.ToTable(true, "ten", "mssv", "dateandtime", "DiemDanh", "Malop");

                        dataGridView1.DataSource = sd1;


                    }


                    NamePersons[t - 1] = name;
                    NamePersons.Add("");
                    //check detected faces 
                    label5.Text = facesDetected[0].Length.ToString();
                }
                t = 0;

                //Names concatenation of persons recognized
                for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
                {
                    names = names + NamePersons[nnn] + ", ";
                    //MessageBox.Show(NamePersons[nnn]);

                    string test = NamePersons[nnn] + ",";

                    System.IO.File.AppendAllText("TrainedFaces/names.txt", test);

                }
                //load haarclassifier and previous saved images to find matches
                imageBox1.Image = currentFrame;
                label3.Text = names;
                names = "";
                NamePersons.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            


        }

        private void SaveToDatabase(string studentID,  DateTime dateTime)
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();

            using (SqlConnection Connection = new SqlConnection(@""+line+""))
            {


                try
                {
                    Connection.Open();
                   
                    SqlCommand getNameFromSID = new SqlCommand(@"SELECT ten from sinhvien WHERE  mssv=@studentid", Connection);
                  
                    getNameFromSID.Parameters.AddWithValue("@studentid", studentID);

                    string studentName = string.Empty;

                    using (SqlDataReader reader = getNameFromSID.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                studentName = reader["ten"].ToString();
                            }
                        }
                    }


                    string thoigian = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                    string diemdanh = "Có mặt";
                    string sua = "Update DiemDanh_LichHoc set dateandtime='" + thoigian+"', Diemdanh=N'" + diemdanh+ "' where malop ='"+com_maLop.Text+"' and  MSSV = '"+studentID+"'";
                    SqlCommand cmd = new SqlCommand(sua, Connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    HienThiThongTin();
                    Connection.Close();

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error has occured:" + ex.Message);

                }
            }
        }
        
        private void DetectAndAttendance_Load(object sender, EventArgs e)
        {
            lab_Ten.Text = ten;
            LAB_ID.Text = id;
            loadSV();
            HienThiThongTin();
        }

        void HienThiThongTin() //Hiển thị thông tin với điều kiện có mã lớp
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");
            ketnoi.Open();

            var cmd = new SqlCommand("SELECT DISTINCT MALOP FROM  DiemDanh_LichHoc where ID ='" + LAB_ID.Text + "' ", ketnoi);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            com_maLop.DisplayMember = "MALOP";
            com_maLop.DataSource = dt;
           
        }

        void quetlai()
        {
            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            SqlConnection ketnoi = new SqlConnection(@"" + line + "");
            ketnoi.Open();

            string thoigian = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            string diemdanh = "null";
            string sua = "Update DiemDanh_LichHoc set dateandtime='" + thoigian + "', Diemdanh=N'" + diemdanh + "' where malop ='" + com_maLop.Text + "'";
            SqlCommand cmd = new SqlCommand(sua, ketnoi);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            loadSV();
            ketnoi.Close();

        }

        void loadSV()
        {
            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            con = new SqlConnection(@"" + line + "");
            SqlDataAdapter checkup = new SqlDataAdapter("SELECT * FROM DiemDanh_LichHoc WHERE malop ='" + com_maLop.Text + "' and diemdanh = 'null'", con); //this will get all marked attendance from the database
            DataTable sd = new DataTable();

            checkup.Fill(sd);
            dataGridView1.DataSource = sd;

            DataTable sd1 = new DataTable();
            sd1 = sd.DefaultView.ToTable(true, "ten", "mssv", "dateandtime", "Diemdanh", "malop");

            dataGridView1.DataSource = sd1;
        }

        void capnhat()
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            con = new SqlConnection(@"" + line + "");
            SqlDataAdapter checkup = new SqlDataAdapter("SELECT * FROM DiemDanh_LichHoc WHERE malop ='" + com_maLop.Text + "'", con); 
            DataTable sd = new DataTable();

            checkup.Fill(sd);
            dataGridView1.DataSource = sd;
        }
    }
}
