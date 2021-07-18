using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShip_Game
{
    public partial class Form1 : Form
    {
        private PlayGame myPlayForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.Gray;
            btnStart.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.Black;
            btnStart.Cursor = Cursors.Default;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            myPlayForm = new PlayGame();
            this.Hide();

            DialogResult myResult = myPlayForm.ShowDialog();
            if((myResult == DialogResult.OK) || (myResult == DialogResult.Cancel))
            {
                this.Show();
                lblScore.Text = "Score: " + myPlayForm.score;
            }
        }
    }
}
