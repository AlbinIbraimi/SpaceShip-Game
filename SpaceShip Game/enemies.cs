using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SpaceShip_Game
{
    public class enemies
    {
        public PictureBox e;
        private bool isHit;

        enemies() {
            this.isHit = false;
            this.e = new PictureBox();
            this.e.Size = new Size(40, 40);
            this.e.Image = Properties.Resources.enemyes;
            this.e.Left = -20;
            this.e.Top = -300;
            this.e.SizeMode = PictureBoxSizeMode.StretchImage;
            this.e.BackColor = Color.Black;

        }

    }
}
