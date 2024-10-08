using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyTro.Payment
{
    public partial class Formfill_Admin : Form
    {
        public void GenerateInvoice( string electricityUsage, string waterUsage)
        {
            int width = 800;
            int height = 600;

            using (Bitmap bitmap = new Bitmap(width, height))
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);

                // Font settings
                Font headerFont = new Font("Arial", 16, FontStyle.Bold);
                Font regularFont = new Font("Arial", 12);
                Font smallFont = new Font("Arial", 10);


                //Lấy thông tin phòng
                int soPhong = 2;// lấy giá trị tên phòng ở trang formchung

                // Draw header 
                g.DrawString("PHIẾU THÔNG BÁO PHÍ DỊCH VỤ THÁNG 10", headerFont, Brushes.Black, new PointF(50, 20));
                g.DrawString("Số phòng " + soPhong, regularFont, Brushes.Black, new PointF(50, 60));
                g.DrawString("Số người dùng: 2", regularFont, Brushes.Black, new PointF(50, 90));
                g.DrawString("Số điện: " + electricityUsage + " kWh", regularFont, Brushes.Black, new PointF(50, 120));
                g.DrawString("Số nước: " + waterUsage + " m3", regularFont, Brushes.Black, new PointF(50, 150));

                // Draw table
                g.DrawRectangle(Pens.Black, 50, 200, 700, 300);
                g.DrawString("Dịch vụ", regularFont, Brushes.Black, new PointF(70, 210));
                g.DrawString("Giá", regularFont, Brushes.Black, new PointF(300, 210));
                g.DrawString("Số lượng", regularFont, Brushes.Black, new PointF(500, 210));
                g.DrawString("Thành tiền", regularFont, Brushes.Black, new PointF(650, 210));

                // Sample data for the table
                g.DrawString("Điện", regularFont, Brushes.Black, new PointF(70, 240));
                g.DrawString("2.000 đ/kWh", regularFont, Brushes.Black, new PointF(300, 240));
                g.DrawString(electricityUsage, regularFont, Brushes.Black, new PointF(500, 240));
                g.DrawString((Convert.ToInt32(electricityUsage) * 2000).ToString() + " đ", regularFont, Brushes.Black, new PointF(650, 240));

                g.DrawString("Nước", regularFont, Brushes.Black, new PointF(70, 270));
                g.DrawString("50.000 đ/m3", regularFont, Brushes.Black, new PointF(300, 270));
                g.DrawString(waterUsage, regularFont, Brushes.Black, new PointF(500, 270));
                g.DrawString((Convert.ToInt32(waterUsage) * 50000).ToString() + " đ", regularFont, Brushes.Black, new PointF(650, 270));

                // Save the image
                try
                {
                    bitmap.Save("D:\\BTL_LTTQ\\AppQuanLyTro\\Payment\\Image_Payment\\Invoice.png");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message);
                }
            }
        }
            public Formfill_Admin()
        {
            InitializeComponent();
        }
        private List<string> imagePaths = new List<string>();
        private void showImage()
        {
            if (imagePaths.Count == 2)
            {
                pictureBox1.Image=Image.FromFile(imagePaths[0]);
                pictureBox2.Image = Image.FromFile(imagePaths[1]);

            }
        }
        
        private void btnSendImageClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();// mở folder tìm kiếm file
            ofd.Filter = "Bitmap Files|*.bmp|JPEG Image Files|*.jpg|All Files|*.*"; // này là có 3 bộ lọc (có 3 đuôi)
            ofd.FilterIndex = 3;// bộ lọc mặc định ->  all file
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePaths.Clear();
                imagePaths.AddRange(ofd.FileNames);
                if (imagePaths.Count != 2)
                {
                    MessageBox.Show("Vui lòng chọn 2 ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                showImage();
                for (int i = 0; i < 2; i++)
                {
                    string imageparh = imagePaths[i];
                  //  string filename =;
                }
            }
            btnSendImage.Enabled = false;
            btnOk.Enabled = true;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtENumber.Text == "" && txtWNumber.Text == "")
            {
                MessageBox.Show("cần nhập số điện và nước!");
                txtENumber.Focus();
            }
            else if (txtENumber.Text == "")
            {
                MessageBox.Show("cần nhập số điện!");
                txtENumber.Focus();
            }
            else if (txtWNumber.Text == "")
            {
                MessageBox.Show("cần nhập số nước!");
                txtWNumber.Focus();
            }

            else
            {
                MessageBox.Show("Gửi thành công!");
            }
            string en=txtENumber.Text;
            string wn=txtWNumber.Text;
            GenerateInvoice(en, wn);
            MessageBox.Show("tạo oke ròi nha");
        }

      
    }
}
