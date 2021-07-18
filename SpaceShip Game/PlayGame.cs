using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShip_Game
{
    public partial class PlayGame : Form
    {
        public int score { set; get; }
        
        private List<Enemy> enemies;
        private int speed;
        private bool fire = false;
        
        private List<PictureBox> bullets;
        private PictureBox deadShip = null;

        private int MOVE_SPEED = 4;

        //Movments
        private bool left = false;
        private bool rigth = false;
        

        private PictureBox lastB = null;
        

        public PlayGame()
        {
            InitializeComponent();
            this.score = 0;
            this.speed = 1;
          
            DoubleBuffered = true;


            this.bullets = new List<PictureBox>();
            this.enemies = new List<Enemy>();

            makeEnemies();

        }

        public void makeEnemies() {
            Random random = new Random();
            Enemy[] tmpArray = new Enemy[8];

            for(int i=0; i<8; i++)
            {

                Enemy tmp = new Enemy();
                tmp.enemy.Left = random.Next(1, 15) * 40;
                tmp.enemy.Top += random.Next(1, 5) * 40;
                tmpArray[i] = tmp;
                this.Controls.Add(tmp.enemy);

            }

           for(int i=0; i< tmpArray.Length-1; i++)
            {
                for(int j=i+1; j<tmpArray.Length; j++)
                {
                    if(tmpArray[i].enemy.Top < tmpArray[j].enemy.Top)
                    {
                        Enemy tmp2 = tmpArray[j];
                        tmpArray[j] = tmpArray[i];
                        tmpArray[i] = tmp2;
                    }

                }
            }

            for (int i = 0; i < tmpArray.Length; i++) {
                this.enemies.Add(tmpArray[i]);
            }
           
            myTimer.Start();
            moveTimer.Start();
        }

        private void PlayGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = true;
                rigth = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                rigth = true;
                left = false;
            }
            if(e.KeyCode == Keys.Space)
            {
                this.fire = true;
                shoot();

            }
        }

        public void shoot() {
           
            if(lastB != null && lastB.Top + lastB.Height > ship.Top-100)
            {
                return;
            }
            
            int location = ship.Left + ship.Width / 2 - 7;
            PictureBox bullet = new PictureBox();
            lastB = bullet;
            bullet.Size = new Size(14, 25);
            bullet.Left = location;
            bullet.Top = ship.Top;
            bullet.Image = Properties.Resources.newBulletUp;
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            this.bullets.Add(bullet);
            this.Controls.Add(bullet);

            isHit(bullet);
        }

        public void isHit(PictureBox bullet)
        {
           
            foreach(Enemy e in enemies)
            {
                if ((bullet.Left + 14 > e.enemy.Left) && (bullet.Left + 14 <= e.enemy.Left + 60 ))
                {
                    if (e.isHit != true)
                    {
                        e.isHit = true;
                        e.myB = bullet;
                        break;

                    }
                }
            }
           
        }

        public void deleteHit(Enemy en, PictureBox deadShip, PictureBox b)
        {
            this.score += 1;
            displeyScore.Text = "Score: " + this.score.ToString();
            this.Controls.Remove(deadShip);
            this.enemies.Remove(en);
            this.Controls.Remove(b);
            this.bullets.Remove(b);

            if (this.enemies.Count == 0)
            {
                makeEnemies();
            }
            
        }
        private void myTimer_Tick(object sender, EventArgs e)
        {//Tick of the timer == 50ms
            bool izlezi = false;

            if (enemies.First().enemy.Top+40 >= 510 )
            {
                this.Close();
            }
            foreach(Enemy en in enemies)
            {
                en.enemy.Top += speed;
            }

            if(fire)
            {
                foreach(PictureBox p in bullets)
                {
                    p.Top -= 4;

                    //dead Ship
                   
                    foreach(Enemy en in enemies)
                    {
                        if(en.isHit)
                        {
                            if (en.myB.Top <= en.enemy.Top + en.enemy.Height)
                            {
                                deleteHit(en, en.enemy,en.myB);
                                izlezi = true;
                                break;
                               
                            }

                        }
                    }
                    if(izlezi)
                    {
                        break;

                    }
                    if (p.Top <= -14)
                    {
                        bullets.Remove(p);
                        this.Controls.Remove(p);
                        break;
                    }

                }

                if(bullets.Count == 0)
                {
                    this.fire = false;
                    this.lastB = null;
                }

            }
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            if(left)
            {
                if (ship.Left >= 0)
                {
                    ship.Left -= MOVE_SPEED;
                }
                
            }
            else if (rigth)
            {
                if (ship.Left + ship.Width <= 850)
                {
                    ship.Left += MOVE_SPEED;
                }
               
            }

            
        }

        private void PlayGame_KeyUp(object sender, KeyEventArgs e)
        {
            if(left)
            {
                left = false;
            }

            if(rigth)
            {
                rigth = false;
            }

        }
    }
}
