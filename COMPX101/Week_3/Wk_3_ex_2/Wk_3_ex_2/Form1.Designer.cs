namespace Wk_3_ex_2
{
    partial class Form1
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
            this.buttonDrawTriangle = new System.Windows.Forms.Button();
            this.buttonDrawSquare = new System.Windows.Forms.Button();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.buttonErase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDrawTriangle
            // 
            this.buttonDrawTriangle.Location = new System.Drawing.Point(115, 383);
            this.buttonDrawTriangle.Name = "buttonDrawTriangle";
            this.buttonDrawTriangle.Size = new System.Drawing.Size(88, 23);
            this.buttonDrawTriangle.TabIndex = 0;
            this.buttonDrawTriangle.Text = "Draw Triangle";
            this.buttonDrawTriangle.UseVisualStyleBackColor = true;
            this.buttonDrawTriangle.Click += new System.EventHandler(this.buttonDrawTriangle_Click);
            // 
            // buttonDrawSquare
            // 
            this.buttonDrawSquare.Location = new System.Drawing.Point(209, 383);
            this.buttonDrawSquare.Name = "buttonDrawSquare";
            this.buttonDrawSquare.Size = new System.Drawing.Size(79, 23);
            this.buttonDrawSquare.TabIndex = 1;
            this.buttonDrawSquare.Text = "Draw Square";
            this.buttonDrawSquare.UseVisualStyleBackColor = true;
            this.buttonDrawSquare.Click += new System.EventHandler(this.buttonDrawSquare_Click);
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.Location = new System.Drawing.Point(32, 34);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(720, 315);
            this.pictureBoxDisplay.TabIndex = 2;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(294, 383);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(178, 23);
            this.buttonErase.TabIndex = 3;
            this.buttonErase.Text = "I heard you don\'t like my shapes";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Controls.Add(this.buttonDrawSquare);
            this.Controls.Add(this.buttonDrawTriangle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDrawTriangle;
        private System.Windows.Forms.Button buttonDrawSquare;
        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.Button buttonErase;
    }
}

