using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShip_Game
{
    public class Enemy
    {
        public PictureBox enemy;
        public bool isHit;

        public PictureBox myB;

        public Enemy() {
            this.isHit = false;

            this.enemy = new PictureBox();

            this.enemy.Size = new Size(40, 40);
            this.enemy.Image = Properties.Resources.enemyes;
            this.enemy.Left = -20;
            this.enemy.Top = -300;
            this.enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            this.enemy.BackColor = Color.Black;
           

        }

    }
}
