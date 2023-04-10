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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace TuLieuHocTap
{
    public partial class ThemSinhVien : Form
    {
        Capture grabber; //để mở máy ảnh
        Image<Bgr, byte> currentFrame; //để chụp ảnh
        Image<Gray, byte> gray, result, result2, result3, result4, TrainedFace = null, TrainedEyes = null, TrainedMouth = null, TrainedNose = null; //initializing as an empty object  

        //đang khởi tạo hharcascade để nhận diện khuôn mặt (phát hiện theo thứ tự)
        HaarCascade face; //detection by face
        HaarCascade eyes; //detectiom by eyes
        HaarCascade mouth;
        HaarCascade nose;

        //initializing faces and name storage array 
        List<Image<Gray, byte>> detectedImages = new List<Image<Gray, byte>>();
        List<Image<Gray, byte>> detectedImages2 = new List<Image<Gray, byte>>();
        List<Image<Gray, byte>> detectedImages3 = new List<Image<Gray, byte>>();
        List<Image<Gray, byte>> detectedImages4 = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();

        int t = 0; //making t into 0 so that algorithm can increment it into 1 = True when face is found 
        int a = 0;



        int b = 0;
        int c = 0;

        //chuỗi kết nối đến cơ sở dữ liệu
        SqlConnection con;


        int NumLabels, ContTrain = 0;


        byte[] imgface = null;
        byte[] imgeyes = null;
        byte[] imgmouth = null;
        byte[] imgnose = null;


        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click_1(object sender, EventArgs e) //Bật Camera
        {
            grabber = new Capture(); //Máy ảnh mở khi nhấn vào
            // 1.Tạo sự kiện grabber 
            grabber.QueryFrame();
            // 2.Bây giờ có thể quay
            Application.Idle += new EventHandler(FrameGrabber); //Máy ảnh bật thì gọi sự kiện lấy khung 

            button1.Enabled = false;//Tắt nút lưu


            btn_Chup.Enabled = true;//Tắt nút chụp
        }

        private void button2_Click_1(object sender, EventArgs e) //extract features button
        {

            
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //  TrainedEyes = result2.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
               //  TrainedMouth = result3.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
               //   TrainedNose = result4.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //b. Image box to show the detected faces
                 img_KhuonMat.Image = TrainedFace;
                btn_Luu.Enabled = true;

                    


           
        }

        private void button3_Click_1(object sender, EventArgs e) //save face button
        {
            extractfeatures();
            addtodatabase(imgface);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        //Các sự kiện hiện đỏ label khi nhấn chuột vào text box
        private void txt_ID_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Red;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;   
            lab_SDT.ForeColor = Color.Black;    
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black; 
            lab_NgaySinh.ForeColor = Color.Black;
            
        }

        private void txt_Ten_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Red;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            lab_NgaySinh.ForeColor = Color.Black;

        }

        private void com_GioiTinh_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Red;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            lab_NgaySinh.ForeColor = Color.Black;
        }

        private void txt_SDT_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Red;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            lab_NgaySinh.ForeColor = Color.Black;
        }

        private void txt_Email_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Red;
            lab_DiaChi.ForeColor = Color.Black;
            lab_NgaySinh.ForeColor = Color.Black;
        }

        private void txt_DiaChi_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Red;
            lab_NgaySinh.ForeColor = Color.Black;
        }

        private void txt_NgaySinh_MouseDown(object sender, MouseEventArgs e)
        {
            lab_ID.ForeColor = Color.Black;
            lab_Ten.ForeColor = Color.Black;
            lab_GioiTinh.ForeColor = Color.Black;
            lab_SDT.ForeColor = Color.Black;
            lab_Email.ForeColor = Color.Black;
            lab_DiaChi.ForeColor = Color.Black;
            lab_NgaySinh.ForeColor = Color.Red;
        }

        public ThemSinhVien()
        {
            //tải tệp haarcascade theo tên tệp và gán cho biến haarcascade
            
            //Tải haarcascades để nhận diện khuôn mặt
                        face = new HaarCascade("haarcascade-frontalface-default.xml");
            //
            eyes = new HaarCascade("haarcascade_mcs_eyepair_big.xml");
            //
            mouth = new HaarCascade("mouth.xml");
            //
            nose = new HaarCascade("nose.xml");

            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Chup.Enabled= false;
            btn_Luu.Enabled= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addtodatabase(byte[] imgface) //Thêm sinh viên vào CSDL
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();


            using (SqlConnection Connection = new SqlConnection(@"" + line + ""))
            {
                if (txt_Ten.Text == String.Empty || txt_ID.Text == String.Empty)
                {
                    MessageBox.Show("Error, Student details must be entered", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    try
                    {
                        //Thêm các thông tin nhập từ ô text box vào csdl
                        Connection.Open();
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO SinhVien ([ten], [MSSV],[imgface],[GioiTinh],[SDT],[Email],[DiaChi],[MatKhau],[TrangThai]) VALUES (@studentname, @idstudent,@imgface,@GioiTinh,@SDT, @Email, @DiaChi, @MatKhau, @TrangThai);", Connection);
                        cmd.Parameters.AddWithValue("@studentname",txt_Ten.Text);
                        cmd.Parameters.AddWithValue("@idstudent", txt_ID.Text);
                        cmd.Parameters.AddWithValue("@imgface", imgface);
                        cmd.Parameters.AddWithValue("@GioiTinh", com_GioiTinh.Text);
                        cmd.Parameters.AddWithValue("@SDT", txt_SDT.Text);
                        cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txt_DiaChi.Text);
                        
                        //HAST MD5
                        String MatKhau = "";
                        Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt_ID.Text);
                        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                        buffer = md5.ComputeHash(buffer);
                        foreach (Byte b in buffer)
                        {
                            MatKhau += b.ToString("X2");
                        }

                        cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
                        string trangthai = "1";
                        //trạng thái = 1 là mở, trạng thái = là khóa
                        cmd.Parameters.AddWithValue("TrangThai", trangthai);

                        //đổi màu lab
                        lab_ID.ForeColor = Color.Black;
                        lab_Ten.ForeColor = Color.Black;
                        lab_GioiTinh.ForeColor = Color.Black;
                        lab_SDT.ForeColor = Color.Black;
                        lab_Email.ForeColor = Color.Black;
                        lab_DiaChi.ForeColor = Color.Black;
                        lab_NgaySinh.ForeColor = Color.Black;


                        int i = cmd.ExecuteNonQuery();
                        Connection.Close();

                        if (i == 1)
                        {
                            MessageBox.Show("Đã lưu sinh viên vào cơ sở dữ liệu.");
                            getPrimaryKey();
                            txt_Ten.Clear();
                            txt_ID.Clear();

                        }
                        else
                        {
                            MessageBox.Show("Lỗi!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi:" + ex.Message);

                    }
                }

            }

        }

        private void getPrimaryKey() //Cấp ID mới
        {

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();

            using (SqlConnection Connection = new SqlConnection(@"" + line + ""))
            {
                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand(@"SELECT MAX(Id)+1 FROM SINHVIEN;", Connection);
                    Connection.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error has occured: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        public void extractfeatures()
        {
            ContTrain = ContTrain + 1;

            //khuôn mặt được phát hiện sẽ được lưu vào một thư mục có tên của người đó
            //
            detectedImages.Add(TrainedFace);
          //  detectedImages2.Add(TrainedEyes);
          //  detectedImages3.Add(TrainedMouth);
          //  detectedImages4.Add(TrainedNose);

            labels.Add(txt_ID.Text);
            int cong = 20;
            //write name of the detected person into list 
            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedNames.txt", detectedImages.ToArray().Length.ToString() + "%");
            /*
            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedNames.txt", detectedImages2.ToArray().Length.ToString() + "%");
            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedNames.txt", detectedImages3.ToArray().Length.ToString() + "%");
            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedNames.txt", detectedImages4.ToArray().Length.ToString() + "%");
            */
            //write to files
            int s = 20;

            for (int i = 1; i < detectedImages.ToArray().Length+  1 ; i++)
            {
               
                detectedImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
              
                File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedNames.txt", labels.ToArray()[i - 1] + "%");

                FileStream fsstream = new FileStream(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fsstream);
                imgface = br.ReadBytes((int)fsstream.Length);

            }
            /*
               for (int i = 1; i < detectedImages2.ToArray().Length + 1; i++)
            {
              
              detectedImages2.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/eyes" + i + ".bmp");
           
            File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedNames.txt", labels.ToArray()[i - 1] + "/");
              FileStream fsstream = new FileStream(Application.StartupPath + "/TrainedFaces/eyes" + i + ".bmp", FileMode.Open, FileAccess.Read);
              BinaryReader br = new BinaryReader(fsstream);
               imgeyes = br.ReadBytes((int)fsstream.Length);
             }

            for (int i = 1; i < detectedImages3.ToArray().Length + 1; i++)
             {
            
               detectedImages3.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/mouth" + i + ".bmp");
            //Saves name to text file
            File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedNames.txt", labels.ToArray()[i - 1] + "/");
                 FileStream fsstream = new FileStream(Application.StartupPath + "/TrainedFaces/mouth" + i + ".bmp", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fsstream);
                imgmouth = br.ReadBytes((int)fsstream.Length);
              }

            for (int i = 1; i < detectedImages4.ToArray().Length + 1; i++)
             {
       
                 detectedImages4.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/nose" + i + ".bmp");
        
                 File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedNames.txt", labels.ToArray()[i - 1] + "/");
              FileStream fsstream = new FileStream(Application.StartupPath + "/TrainedFaces/nose" + i + ".bmp", FileMode.Open, FileAccess.Read);
             BinaryReader br = new BinaryReader(fsstream);
                imgnose = br.ReadBytes((int)fsstream.Length);
               }
            */

            MessageBox.Show("Đã lưu hình vào bộ nhớ!");
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        void FrameGrabber(object sender, EventArgs e) //Frame grabber event 
        {
            //khởi tạo khung hiện tại với trình lấy truy vấn đang bắt khung
            currentFrame = grabber.QueryFrame().Resize(501, 407, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC); //resizing the frame with cubic frame
                                                                                                       //currentFrame2 = grabber.QueryFrame().Resize(400, 300, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //1.Chuyển đổi khung hình thành thang màu xám(image processing) 
            gray = currentFrame.Convert<Gray, Byte>();
            //gray2 = hiện tạiFrame.Convert<Gray, Byte>();

            //2.  Phát hiện khuôn mặt bằng Haar Classifier
                        MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 2, 1, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
            MCvAvgComp[][] eyesDetected = gray.DetectHaarCascade(eyes, 1.2, 5, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
            MCvAvgComp[][] mouthDetected = gray.DetectHaarCascade(mouth, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(50, 50));
            MCvAvgComp[][] noseDetected = gray.DetectHaarCascade(nose, 1.2, 5, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
            //face is name of the haar cascade, giving sizes to the cascade, applying canny pruning on haar classifier 

            //3. Kiểm tra từng khung hình ảnh được xử lý bởi trình phân loại thông qua ImageBox(video được xử lý dưới dạng khung hình ảnh để nhận diện khuôn mặt),  sau đó phát hiện khuôn mặt
            foreach (MCvAvgComp f in facesDetected[0])
            {
                //a.  Nếu phát hiện khuôn mặt thì tăng t lên 1 = True
                t = t + 1;
                //b. Kết quả là sao chép khuôn mặt được phát hiện trong tên khung(gray.result)
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //thay đổi kích thước khung đã sao chép và biến nó thành hình khối
                //Xem kết quả(detected image, face), chuyển đổi khung hiện tại sang thang màu xám

                //c. Vẽ traingle xung quanh trên hình ảnh được phát hiện (face) 
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);

            }

            foreach (MCvAvgComp f in eyesDetected[0])
            {
                //    //a.  Nếu phát hiện khuôn mặt thì tăng t lên 1 = True
                a = a + 1;
                //    //b. Kết quả là sao chép khuôn mặt được phát hiện trong tên khung(gray.result)
                result2 = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
          
                currentFrame.Draw(f.rect, new Bgr(Color.White), 2);

            }

            foreach (MCvAvgComp f in mouthDetected[0])
            {
              
                b = b + 1;
         
                result3 = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
           
                   currentFrame.Draw(f.rect, new Bgr(Color.Green), 2);

            }

            foreach (MCvAvgComp f in noseDetected[0])
            {
              
                c = c + 1;
            
                result4 = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
          
                //    //c. Drawing traingle around on detected image (face) 
                currentFrame.Draw(f.rect, new Bgr(Color.Blue), 2);

            }


            imageBox1.Image = currentFrame; ///khung hình hiện tại = được chụp từ máy ảnh vào hộp hình ảnh

        }



    }
}
