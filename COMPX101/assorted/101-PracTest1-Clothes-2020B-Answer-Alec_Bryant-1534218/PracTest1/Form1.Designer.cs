namespace PracTest1
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
            this.textBoxShirts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExcess = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxShirtFabric = new System.Windows.Forms.TextBox();
            this.textBoxTotalFabric = new System.Windows.Forms.TextBox();
            this.textBoxExcessFabric = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxRolls = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRollsCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxShirts
            // 
            this.textBoxShirts.Location = new System.Drawing.Point(98, 12);
            this.textBoxShirts.Name = "textBoxShirts";
            this.textBoxShirts.Size = new System.Drawing.Size(100, 20);
            this.textBoxShirts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Shirts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Excess per Shirt:";
            // 
            // textBoxExcess
            // 
            this.textBoxExcess.Location = new System.Drawing.Point(322, 12);
            this.textBoxExcess.Name = "textBoxExcess";
            this.textBoxExcess.Size = new System.Drawing.Size(100, 20);
            this.textBoxExcess.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fabric for Shirts:";
            // 
            // textBoxShirtFabric
            // 
            this.textBoxShirtFabric.Location = new System.Drawing.Point(98, 39);
            this.textBoxShirtFabric.Name = "textBoxShirtFabric";
            this.textBoxShirtFabric.ReadOnly = true;
            this.textBoxShirtFabric.Size = new System.Drawing.Size(100, 20);
            this.textBoxShirtFabric.TabIndex = 5;
            // 
            // textBoxTotalFabric
            // 
            this.textBoxTotalFabric.Location = new System.Drawing.Point(98, 66);
            this.textBoxTotalFabric.Name = "textBoxTotalFabric";
            this.textBoxTotalFabric.ReadOnly = true;
            this.textBoxTotalFabric.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalFabric.TabIndex = 6;
            // 
            // textBoxExcessFabric
            // 
            this.textBoxExcessFabric.Location = new System.Drawing.Point(322, 39);
            this.textBoxExcessFabric.Name = "textBoxExcessFabric";
            this.textBoxExcessFabric.ReadOnly = true;
            this.textBoxExcessFabric.Size = new System.Drawing.Size(100, 20);
            this.textBoxExcessFabric.TabIndex = 7;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(322, 66);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.ReadOnly = true;
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Fabric:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Excess Fabric:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Cost:";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(93, 124);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 12;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(174, 124);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(255, 124);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxRolls
            // 
            this.textBoxRolls.Location = new System.Drawing.Point(98, 92);
            this.textBoxRolls.Name = "textBoxRolls";
            this.textBoxRolls.ReadOnly = true;
            this.textBoxRolls.Size = new System.Drawing.Size(100, 20);
            this.textBoxRolls.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Rolls of Fabric:";
            // 
            // textBoxRollsCost
            // 
            this.textBoxRollsCost.Location = new System.Drawing.Point(322, 92);
            this.textBoxRollsCost.Name = "textBoxRollsCost";
            this.textBoxRollsCost.ReadOnly = true;
            this.textBoxRollsCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxRollsCost.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cost of Rolls:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 159);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxRollsCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxRolls);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxExcessFabric);
            this.Controls.Add(this.textBoxTotalFabric);
            this.Controls.Add(this.textBoxShirtFabric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxExcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxShirts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practical Test 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxShirts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxExcess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxShirtFabric;
        private System.Windows.Forms.TextBox textBoxTotalFabric;
        private System.Windows.Forms.TextBox textBoxExcessFabric;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxRolls;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRollsCost;
        private System.Windows.Forms.Label label8;
    }
}

