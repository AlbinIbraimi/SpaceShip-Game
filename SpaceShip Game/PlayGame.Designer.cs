namespace SpaceShip_Game
{
    partial class PlayGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ship = new System.Windows.Forms.PictureBox();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.displeyScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).BeginInit();
            this.SuspendLayout();
            // 
            // ship
            // 
            this.ship.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ship.Image = global::SpaceShip_Game.Properties.Resources.lighter1;
            this.ship.Location = new System.Drawing.Point(374, 509);
            this.ship.Name = "ship";
            this.ship.Size = new System.Drawing.Size(39, 60);
            this.ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship.TabIndex = 0;
            this.ship.TabStop = false;
            // 
            // myTimer
            // 
            this.myTimer.Interval = 25;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // moveTimer
            // 
            this.moveTimer.Interval = 20;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // displeyScore
            // 
            this.displeyScore.AutoSize = true;
            this.displeyScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displeyScore.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displeyScore.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.displeyScore.Location = new System.Drawing.Point(719, 545);
            this.displeyScore.Name = "displeyScore";
            this.displeyScore.Size = new System.Drawing.Size(71, 24);
            this.displeyScore.TabIndex = 1;
            this.displeyScore.Text = "Score: 0";
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceShip_Game.Properties.Resources.flat_1000x1000_075_f;
            this.ClientSize = new System.Drawing.Size(834, 581);
            this.Controls.Add(this.displeyScore);
            this.Controls.Add(this.ship);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PlayGame";
            this.Text = "Spaceship";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PlayGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ship;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Timer moveTimer;
        private System.Windows.Forms.Label displeyScore;
    }
}