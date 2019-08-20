using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class MainScene : Form
    {

        public readonly int playerSpeed = 5;
        public readonly int ObjectSpeed = 5;

        //TODO: Add health and invincibility timer
        //public readonly int playerInvincible = 5;

        public int playerhealth = 1;

        /// <summary>
        /// Prevent window resizing
        /// </summary>
        public MainScene()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// Initial setup
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {

            //window
            DoubleBuffered = true;
            BackColor = Color.Black;

            //player
            pbPlayer.Image = Properties.Resources.Player_sprite;
            pbPlayer.Size = new Size(200,200);
            pbPlayer.Location = new Point(0, 0);
            pbPlayer.BorderStyle = BorderStyle.FixedSingle;
            pbPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPlayer.BackColor = TransparencyKey;

            //Danger zone - Spikes
            pbSpikes.Image = Properties.Resources.Spikes;
            pbSpikes.BorderStyle = BorderStyle.FixedSingle;
            pbSpikes.BackColor = TransparencyKey;

            //Danger zone - Moving spikes
            pbMovingSpikes01.Image = Properties.Resources.Spikes;
            pbMovingSpikes01.BorderStyle = BorderStyle.FixedSingle;
            pbMovingSpikes01.BackColor = TransparencyKey;
            pbMovingSpikes01.Top = this.Height;

            //timers
            timerSpikes.Enabled = true;

            //exit zone
            pnlExit.BackColor = Color.DarkGray;
        }

        /// <summary>
        /// Player movement
        /// </summary>
        private void NainScene_KeyDown(object sender, KeyEventArgs e)
        {
            //Player reached exit
            if (pbPlayer.Bounds.IntersectsWith(pnlExit.Bounds))
                Winner();

            //player hits damageZone
            if (pbPlayer.Bounds.IntersectsWith(pbSpikes.Bounds) ||
                pbPlayer.Bounds.IntersectsWith(pbMovingSpikes01.Bounds))
            {
                Changehealth(-1);
            }
            //Move player
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                    case Keys.Up:
                        pbPlayer.Top -= playerSpeed;
                        break;
                    case Keys.A:
                    case Keys.Left:
                        pbPlayer.Left -= playerSpeed;
                        break;
                    case Keys.S:
                    case Keys.Down:
                        pbPlayer.Top += playerSpeed;
                        break;
                    case Keys.D:
                    case Keys.Right:
                        pbPlayer.Left += playerSpeed;
                        break;
                    default:
                        break;
                }
            }
        }

        private void TimerSpikes_Tick(object sender, EventArgs e)
        {
            //player hit
            if (pbMovingSpikes01.Bounds.IntersectsWith(pbPlayer.Bounds))
            {
                Changehealth(-1);
            }
            //Move spikes
            else
            {
                if (pbMovingSpikes01.Top < 0)
                {
                    pbMovingSpikes01.Top += ObjectSpeed;
                }
                if (pbMovingSpikes01.Top >= this.Height)
                {
                    pbMovingSpikes01.Top -= ObjectSpeed;
                }
            }
        }

        /// <summary>
        /// Run this once the win conditions have passed
        /// </summary>
        void Winner()
        {
            MessageBox.Show("Winner!");
            Application.Exit();
        }

        /// <summary>
        /// Change player health 
        /// </summary>
        /// <param name="amount">int - set negative to lower health, positive to increase health</param>
        void Changehealth(int amount)
        {
            playerhealth += amount;

            if (playerhealth <= 0)
                Lose();
        }

        /// <summary>
        /// Run once lose condition is passed
        /// </summary>
        void Lose()
        {
            timerSpikes.Enabled = false;
            MessageBox.Show("You Died!");
            Application.Exit();
        }
    }
}
