using System.Drawing;
using System.Windows.Forms;

namespace MyPetWinForm
{
    public class Form1 : Form
    {
        private PictureBox pictureBox;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "AngryTiger.jpg");
            imageList1.Images.SetKeyName(1, "ChillTiger.jpg");
            imageList1.Images.SetKeyName(2, "DancingTiger.jpg");
            imageList1.Images.SetKeyName(3, "HighFiveBruhTiger.jpg");
            imageList1.Images.SetKeyName(4, "Tiger.jpg");
            // 
            // Form1
            // 
            ClientSize = new Size(750, 445);
            Name = "Form1";
            ResumeLayout(false);

        }

        public Form1()
        {
            this.Text = "My Pet Tiger";
            this.Size = new Size(450, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "Tiger.jpg");
            pictureBox.Image = Image.FromFile(imagePath);

            this.Controls.Add(pictureBox);
        }
        private ImageList imageList1;
        private System.ComponentModel.IContainer components;
    }
}
