namespace SpaceInvaders
{
    partial class Game
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
      this._pictureBox = new System.Windows.Forms.PictureBox();
      this._animationTimer = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // _pictureBox
      // 
      this._pictureBox.BackColor = System.Drawing.Color.Black;
      this._pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this._pictureBox.Location = new System.Drawing.Point(0, 0);
      this._pictureBox.Name = "_pictureBox";
      this._pictureBox.Size = new System.Drawing.Size(469, 304);
      this._pictureBox.TabIndex = 0;
      this._pictureBox.TabStop = false;
      this._pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this._pictureBox_Paint);
      this._pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this._pictureBox_MouseMove);
      // 
      // _animationTimer
      // 
      this._animationTimer.Enabled = true;
      this._animationTimer.Interval = 60;
      this._animationTimer.Tick += new System.EventHandler(this._animationTimer_Tick);
      // 
      // Game
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.ClientSize = new System.Drawing.Size(469, 304);
      this.Controls.Add(this._pictureBox);
      this.Name = "Game";
      this.Text = "Space Invaders";
      ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox _pictureBox;
    private System.Windows.Forms.Timer _animationTimer;
  }
}

