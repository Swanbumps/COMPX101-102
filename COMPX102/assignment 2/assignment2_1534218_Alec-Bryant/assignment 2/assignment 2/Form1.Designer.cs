namespace assignment_2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.labelFloorNumber = new System.Windows.Forms.Label();
            this.labelRiverView = new System.Windows.Forms.Label();
            this.checkBoxRiverView = new System.Windows.Forms.CheckBox();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.textBoxFloorNumber = new System.Windows.Forms.TextBox();
            this.numericUpDownRate = new System.Windows.Forms.NumericUpDown();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelBooked = new System.Windows.Forms.Label();
            this.checkBoxBooked = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 517);
            this.listBox1.TabIndex = 0;
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Location = new System.Drawing.Point(12, 590);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(65, 13);
            this.labelRoomType.TabIndex = 1;
            this.labelRoomType.Text = "Room Type:";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(96, 587);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(107, 21);
            this.comboBoxRoomType.TabIndex = 2;
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Location = new System.Drawing.Point(12, 538);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(78, 13);
            this.labelRoomNumber.TabIndex = 3;
            this.labelRoomNumber.Text = "Room Number:";
            // 
            // labelFloorNumber
            // 
            this.labelFloorNumber.AutoSize = true;
            this.labelFloorNumber.Location = new System.Drawing.Point(12, 564);
            this.labelFloorNumber.Name = "labelFloorNumber";
            this.labelFloorNumber.Size = new System.Drawing.Size(73, 13);
            this.labelFloorNumber.TabIndex = 4;
            this.labelFloorNumber.Text = "Floor Number:";
            // 
            // labelRiverView
            // 
            this.labelRiverView.AutoSize = true;
            this.labelRiverView.Location = new System.Drawing.Point(12, 640);
            this.labelRiverView.Name = "labelRiverView";
            this.labelRiverView.Size = new System.Drawing.Size(61, 13);
            this.labelRiverView.TabIndex = 7;
            this.labelRiverView.Text = "River View:";
            // 
            // checkBoxRiverView
            // 
            this.checkBoxRiverView.AutoSize = true;
            this.checkBoxRiverView.Location = new System.Drawing.Point(96, 639);
            this.checkBoxRiverView.Name = "checkBoxRiverView";
            this.checkBoxRiverView.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRiverView.TabIndex = 8;
            this.checkBoxRiverView.UseVisualStyleBackColor = true;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(96, 535);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.ReadOnly = true;
            this.textBoxRoomNumber.Size = new System.Drawing.Size(107, 20);
            this.textBoxRoomNumber.TabIndex = 9;
            // 
            // textBoxFloorNumber
            // 
            this.textBoxFloorNumber.Location = new System.Drawing.Point(96, 562);
            this.textBoxFloorNumber.Name = "textBoxFloorNumber";
            this.textBoxFloorNumber.ReadOnly = true;
            this.textBoxFloorNumber.Size = new System.Drawing.Size(107, 20);
            this.textBoxFloorNumber.TabIndex = 10;
            // 
            // numericUpDownRate
            // 
            this.numericUpDownRate.Location = new System.Drawing.Point(96, 614);
            this.numericUpDownRate.Name = "numericUpDownRate";
            this.numericUpDownRate.Size = new System.Drawing.Size(107, 20);
            this.numericUpDownRate.TabIndex = 11;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(12, 616);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(33, 13);
            this.labelRate.TabIndex = 12;
            this.labelRate.Text = "Rate:";
            // 
            // labelBooked
            // 
            this.labelBooked.AutoSize = true;
            this.labelBooked.Location = new System.Drawing.Point(12, 660);
            this.labelBooked.Name = "labelBooked";
            this.labelBooked.Size = new System.Drawing.Size(47, 13);
            this.labelBooked.TabIndex = 13;
            this.labelBooked.Text = "Booked:";
            // 
            // checkBoxBooked
            // 
            this.checkBoxBooked.AutoSize = true;
            this.checkBoxBooked.Location = new System.Drawing.Point(96, 660);
            this.checkBoxBooked.Name = "checkBoxBooked";
            this.checkBoxBooked.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBooked.TabIndex = 14;
            this.checkBoxBooked.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.checkBoxBooked);
            this.Controls.Add(this.labelBooked);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.numericUpDownRate);
            this.Controls.Add(this.textBoxFloorNumber);
            this.Controls.Add(this.textBoxRoomNumber);
            this.Controls.Add(this.checkBoxRiverView);
            this.Controls.Add(this.labelRiverView);
            this.Controls.Add(this.labelFloorNumber);
            this.Controls.Add(this.labelRoomNumber);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.labelRoomType);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Room Number";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.Label labelFloorNumber;
        private System.Windows.Forms.Label labelRiverView;
        private System.Windows.Forms.CheckBox checkBoxRiverView;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.TextBox textBoxFloorNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownRate;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelBooked;
        private System.Windows.Forms.CheckBox checkBoxBooked;
    }
}

