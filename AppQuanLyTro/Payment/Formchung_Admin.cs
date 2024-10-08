using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyTro.Payment
{
    public partial class Formchung_Admin : Form
    {
        public Formchung_Admin()
        {
            InitializeComponent();
        }
        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }
        private void Form3_Admin_Load(object sender, EventArgs e)
        {
            btnBack.Image = ResizeImage(Image.FromFile("D:\\BTL_LTTQ\\pic\\backButton.png"), 30,30);
            btnNext.Image = ResizeImage(Image.FromFile("D:\\BTL_LTTQ\\pic\\nextButton.png"),30,30);
        }
    }
    
}
