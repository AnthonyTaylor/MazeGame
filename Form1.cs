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

        //TODO: Add health and invincibility timer
        //public readonly int playerInvincible = 5;

        public int playerhealth = 5;

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
            if (pbPlayer.Bounds.IntersectsWith(pbSpikes.Bounds))
            {
                Changehealth(-1);
            }
            else
            {
                //Move player
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

        void Winner()
        {
            MessageBox.Show("Winner!");
            Application.Exit();
        }

        void Changehealth(int amount)
        {
            //playerhealth += amount;
            MessageBox.Show("You Died!");
            Application.Exit();
        }
    }
}
