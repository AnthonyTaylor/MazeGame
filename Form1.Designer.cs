namespace MazeGame
{
    partial class MainScene
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
            this.pnlExit = new System.Windows.Forms.Panel();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbSpikes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpikes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.Color.LightGreen;
            this.pnlExit.Location = new System.Drawing.Point(724, -1);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(77, 451);
            this.pnlExit.TabIndex = 1;
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pbPlayer.Location = new System.Drawing.Point(12, 12);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(100, 50);
            this.pbPlayer.TabIndex = 2;
            this.pbPlayer.TabStop = false;
            // 
            // pbSpikes
            // 
            this.pbSpikes.BackColor = System.Drawing.Color.LightCoral;
            this.pbSpikes.Location = new System.Drawing.Point(12, 388);
            this.pbSpikes.Name = "pbSpikes";
            this.pbSpikes.Size = new System.Drawing.Size(100, 50);
            this.pbSpikes.TabIndex = 3;
            this.pbSpikes.TabStop = false;
            this.pbSpikes.Tag = "damageZone";
            // 
            // MainScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbSpikes);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pnlExit);
            this.Name = "MainScene";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MazeGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NainScene_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpikes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbSpikes;
    }
}

