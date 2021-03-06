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
      this._animationTimer = new System.Windows.Forms.Timer(this.components);
      this._pictureBox = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // _animationTimer
      // 
      this._animationTimer.Enabled = true;
      this._animationTimer.Interval = 20;
      this._animationTimer.Tick += new System.EventHandler(this.AnimationTimerTick);
      // 
      // _pictureBox
      // 
      this._pictureBox.BackColor = System.Drawing.Color.Black;
      this._pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this._pictureBox.Location = new System.Drawing.Point(0, 0);
      this._pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this._pictureBox.Name = "_pictureBox";
      this._pictureBox.Size = new System.Drawing.Size(625, 374);
      this._pictureBox.TabIndex = 0;
      this._pictureBox.TabStop = false;
      this._pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePaint);
      this._pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameMouseMove);
      // 
      // Game
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.ClientSize = new System.Drawing.Size(625, 374);
      this.Controls.Add(this._pictureBox);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Game";
      this.Text = "Space Invaders";
      ((System.ComponentModel.ISupportInitialize)(this._pictureBox)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer _animationTimer;
        private System.Windows.Forms.PictureBox _pictureBox;

    }
}

