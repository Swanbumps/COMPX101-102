namespace WK_4_EX_3
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
            this.buttonPower = new System.Windows.Forms.Button();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.labelLamp = new System.Windows.Forms.Label();
            this.checkBoxPower = new System.Windows.Forms.CheckBox();
            this.radioButtonOR = new System.Windows.Forms.RadioButton();
            this.radioButtonAND = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonPower
            // 
            this.buttonPower.Location = new System.Drawing.Point(12, 120);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(75, 23);
            this.buttonPower.TabIndex = 0;
            this.buttonPower.Text = "Power";
            this.buttonPower.UseVisualStyleBackColor = true;
            this.buttonPower.Click += new System.EventHandler(this.buttonPower_Click);
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSize = true;
            this.checkBoxA.Location = new System.Drawing.Point(12, 12);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(33, 17);
            this.checkBoxA.TabIndex = 1;
            this.checkBoxA.Text = "A";
            this.checkBoxA.UseVisualStyleBackColor = true;
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Location = new System.Drawing.Point(12, 35);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(33, 17);
            this.checkBoxB.TabIndex = 2;
            this.checkBoxB.Text = "B";
            this.checkBoxB.UseVisualStyleBackColor = true;
            // 
            // labelLamp
            // 
            this.labelLamp.AutoSize = true;
            this.labelLamp.BackColor = System.Drawing.Color.White;
            this.labelLamp.Location = new System.Drawing.Point(186, 9);
            this.labelLamp.Name = "labelLamp";
            this.labelLamp.Size = new System.Drawing.Size(33, 13);
            this.labelLamp.TabIndex = 3;
            this.labelLamp.Text = "Lamp";
            // 
            // checkBoxPower
            // 
            this.checkBoxPower.AutoSize = true;
            this.checkBoxPower.Location = new System.Drawing.Point(12, 59);
            this.checkBoxPower.Name = "checkBoxPower";
            this.checkBoxPower.Size = new System.Drawing.Size(56, 17);
            this.checkBoxPower.TabIndex = 4;
            this.checkBoxPower.Text = "Power";
            this.checkBoxPower.UseVisualStyleBackColor = true;
            // 
            // radioButtonOR
            // 
            this.radioButtonOR.AutoSize = true;
            this.radioButtonOR.Location = new System.Drawing.Point(82, 13);
            this.radioButtonOR.Name = "radioButtonOR";
            this.radioButtonOR.Size = new System.Drawing.Size(41, 17);
            this.radioButtonOR.TabIndex = 5;
            this.radioButtonOR.TabStop = true;
            this.radioButtonOR.Text = "OR";
            this.radioButtonOR.UseVisualStyleBackColor = true;
            // 
            // radioButtonAND
            // 
            this.radioButtonAND.AutoSize = true;
            this.radioButtonAND.Location = new System.Drawing.Point(82, 35);
            this.radioButtonAND.Name = "radioButtonAND";
            this.radioButtonAND.Size = new System.Drawing.Size(48, 17);
            this.radioButtonAND.TabIndex = 6;
            this.radioButtonAND.TabStop = true;
            this.radioButtonAND.Text = "AND";
            this.radioButtonAND.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonAND);
            this.Controls.Add(this.radioButtonOR);
            this.Controls.Add(this.checkBoxPower);
            this.Controls.Add(this.labelLamp);
            this.Controls.Add(this.checkBoxB);
            this.Controls.Add(this.checkBoxA);
            this.Controls.Add(this.buttonPower);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.Label labelLamp;
        private System.Windows.Forms.CheckBox checkBoxPower;
        private System.Windows.Forms.RadioButton radioButtonOR;
        private System.Windows.Forms.RadioButton radioButtonAND;
    }
}

