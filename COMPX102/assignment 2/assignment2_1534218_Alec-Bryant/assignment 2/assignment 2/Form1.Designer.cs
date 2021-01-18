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
            this.numericUpDownRate = new System.Windows.Forms.NumericUpDown();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelBooked = new System.Windows.Forms.Label();
            this.checkBoxBooked = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownRoomNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFloorNumber = new System.Windows.Forms.NumericUpDown();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBook = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelNoVacancy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloorNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(776, 517);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Location = new System.Drawing.Point(794, 67);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(65, 13);
            this.labelRoomType.TabIndex = 1;
            this.labelRoomType.Text = "Room Type:";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(878, 64);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(107, 21);
            this.comboBoxRoomType.TabIndex = 2;
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Location = new System.Drawing.Point(794, 15);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(78, 13);
            this.labelRoomNumber.TabIndex = 3;
            this.labelRoomNumber.Text = "Room Number:";
            // 
            // labelFloorNumber
            // 
            this.labelFloorNumber.AutoSize = true;
            this.labelFloorNumber.Location = new System.Drawing.Point(794, 41);
            this.labelFloorNumber.Name = "labelFloorNumber";
            this.labelFloorNumber.Size = new System.Drawing.Size(73, 13);
            this.labelFloorNumber.TabIndex = 4;
            this.labelFloorNumber.Text = "Floor Number:";
            // 
            // labelRiverView
            // 
            this.labelRiverView.AutoSize = true;
            this.labelRiverView.Location = new System.Drawing.Point(794, 117);
            this.labelRiverView.Name = "labelRiverView";
            this.labelRiverView.Size = new System.Drawing.Size(61, 13);
            this.labelRiverView.TabIndex = 7;
            this.labelRiverView.Text = "River View:";
            // 
            // checkBoxRiverView
            // 
            this.checkBoxRiverView.AutoSize = true;
            this.checkBoxRiverView.Location = new System.Drawing.Point(878, 116);
            this.checkBoxRiverView.Name = "checkBoxRiverView";
            this.checkBoxRiverView.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRiverView.TabIndex = 8;
            this.checkBoxRiverView.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRate
            // 
            this.numericUpDownRate.Location = new System.Drawing.Point(878, 91);
            this.numericUpDownRate.Name = "numericUpDownRate";
            this.numericUpDownRate.Size = new System.Drawing.Size(107, 20);
            this.numericUpDownRate.TabIndex = 11;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(794, 93);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(33, 13);
            this.labelRate.TabIndex = 12;
            this.labelRate.Text = "Rate:";
            // 
            // labelBooked
            // 
            this.labelBooked.AutoSize = true;
            this.labelBooked.Location = new System.Drawing.Point(794, 137);
            this.labelBooked.Name = "labelBooked";
            this.labelBooked.Size = new System.Drawing.Size(47, 13);
            this.labelBooked.TabIndex = 13;
            this.labelBooked.Text = "Booked:";
            // 
            // checkBoxBooked
            // 
            this.checkBoxBooked.AutoSize = true;
            this.checkBoxBooked.Enabled = false;
            this.checkBoxBooked.Location = new System.Drawing.Point(878, 137);
            this.checkBoxBooked.Name = "checkBoxBooked";
            this.checkBoxBooked.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBooked.TabIndex = 14;
            this.checkBoxBooked.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(795, 157);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(62, 23);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // numericUpDownRoomNumber
            // 
            this.numericUpDownRoomNumber.Location = new System.Drawing.Point(878, 12);
            this.numericUpDownRoomNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownRoomNumber.Name = "numericUpDownRoomNumber";
            this.numericUpDownRoomNumber.Size = new System.Drawing.Size(107, 20);
            this.numericUpDownRoomNumber.TabIndex = 16;
            this.numericUpDownRoomNumber.ValueChanged += new System.EventHandler(this.numericUpDownRoomNumber_ValueChanged);
            // 
            // numericUpDownFloorNumber
            // 
            this.numericUpDownFloorNumber.Enabled = false;
            this.numericUpDownFloorNumber.Location = new System.Drawing.Point(878, 38);
            this.numericUpDownFloorNumber.Name = "numericUpDownFloorNumber";
            this.numericUpDownFloorNumber.ReadOnly = true;
            this.numericUpDownFloorNumber.Size = new System.Drawing.Size(107, 20);
            this.numericUpDownFloorNumber.TabIndex = 17;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(862, 157);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(62, 23);
            this.buttonEdit.TabIndex = 18;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(930, 157);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(62, 23);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(795, 187);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(75, 23);
            this.buttonBook.TabIndex = 20;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(797, 515);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(83, 13);
            this.labelStatus.TabIndex = 22;
            this.labelStatus.Text = "STATUSLABEL";
            // 
            // labelNoVacancy
            // 
            this.labelNoVacancy.AutoSize = true;
            this.labelNoVacancy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNoVacancy.Location = new System.Drawing.Point(795, 499);
            this.labelNoVacancy.Name = "labelNoVacancy";
            this.labelNoVacancy.Size = new System.Drawing.Size(84, 13);
            this.labelNoVacancy.TabIndex = 23;
            this.labelNoVacancy.Text = "NO VANCANCY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1005, 540);
            this.Controls.Add(this.labelNoVacancy);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.numericUpDownFloorNumber);
            this.Controls.Add(this.numericUpDownRoomNumber);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBoxBooked);
            this.Controls.Add(this.labelBooked);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.numericUpDownRate);
            this.Controls.Add(this.checkBoxRiverView);
            this.Controls.Add(this.labelRiverView);
            this.Controls.Add(this.labelFloorNumber);
            this.Controls.Add(this.labelRoomNumber);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.labelRoomType);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloorNumber)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDownRate;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelBooked;
        private System.Windows.Forms.CheckBox checkBoxBooked;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownRoomNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownFloorNumber;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelNoVacancy;
    }
}

