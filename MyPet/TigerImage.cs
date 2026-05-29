using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyPet
{
    internal class TigerImage : Form
    {
        private PictureBox tigerPictureBox;
        public TigerImage()
        {
            this.Text = "Your GLORIOUS pet Tiger!";
            this.Size = new Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            tigerPictureBox = new PictureBox();
            tigerPictureBox.Size = new Size(350, 350);
            tigerPictureBox.Location = new Point(25, 25);
            tigerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
