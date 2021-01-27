namespace knapsackplanner
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._dataGridViewItems = new System.Windows.Forms.DataGridView();
            this._dataGridViewContainers = new System.Windows.Forms.DataGridView();
            this._dataGridViewStoredItems = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this._numericUpDownVolume = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this._numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this._textBoxName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._buttonMoveFrom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._buttonMoveTo = new System.Windows.Forms.Button();
            this._numericUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this._buttonDelete = new System.Windows.Forms.Button();
            this._buttonEdit = new System.Windows.Forms.Button();
            this._buttonAddContainer = new System.Windows.Forms.Button();
            this._buttonAddItem = new System.Windows.Forms.Button();
            this.buttonEmpty = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewContainers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewStoredItems)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownWeight)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownValue)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this._dataGridViewItems, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._dataGridViewContainers, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._dataGridViewStoredItems, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _dataGridViewItems
            // 
            this._dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewItems.Location = new System.Drawing.Point(3, 43);
            this._dataGridViewItems.Name = "_dataGridViewItems";
            this._dataGridViewItems.Size = new System.Drawing.Size(260, 344);
            this._dataGridViewItems.TabIndex = 0;
            this._dataGridViewItems.SelectionChanged += new System.EventHandler(this._dataGridViewItems_SelectionChanged);
            // 
            // _dataGridViewContainers
            // 
            this._dataGridViewContainers.AllowUserToDeleteRows = false;
            this._dataGridViewContainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewContainers.Location = new System.Drawing.Point(269, 43);
            this._dataGridViewContainers.Name = "_dataGridViewContainers";
            this._dataGridViewContainers.ReadOnly = true;
            this._dataGridViewContainers.Size = new System.Drawing.Size(260, 344);
            this._dataGridViewContainers.TabIndex = 1;
            this._dataGridViewContainers.SelectionChanged += new System.EventHandler(this._dataGridViewContainers_SelectionChanged);
            // 
            // _dataGridViewStoredItems
            // 
            this._dataGridViewStoredItems.AllowUserToAddRows = false;
            this._dataGridViewStoredItems.AllowUserToDeleteRows = false;
            this._dataGridViewStoredItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewStoredItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewStoredItems.Location = new System.Drawing.Point(535, 43);
            this._dataGridViewStoredItems.Name = "_dataGridViewStoredItems";
            this._dataGridViewStoredItems.ReadOnly = true;
            this._dataGridViewStoredItems.Size = new System.Drawing.Size(262, 344);
            this._dataGridViewStoredItems.TabIndex = 2;
            this._dataGridViewStoredItems.SelectionChanged += new System.EventHandler(this._dataGridViewStoredItems_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this._numericUpDownVolume);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this._numericUpDownWeight);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._textBoxName);
            this.panel1.Location = new System.Drawing.Point(3, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 54);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Volume";
            // 
            // _numericUpDownVolume
            // 
            this._numericUpDownVolume.Location = new System.Drawing.Point(171, 31);
            this._numericUpDownVolume.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this._numericUpDownVolume.Name = "_numericUpDownVolume";
            this._numericUpDownVolume.Size = new System.Drawing.Size(86, 20);
            this._numericUpDownVolume.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight";
            // 
            // _numericUpDownWeight
            // 
            this._numericUpDownWeight.Location = new System.Drawing.Point(86, 31);
            this._numericUpDownWeight.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this._numericUpDownWeight.Name = "_numericUpDownWeight";
            this._numericUpDownWeight.Size = new System.Drawing.Size(79, 20);
            this._numericUpDownWeight.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // _textBoxName
            // 
            this._textBoxName.Location = new System.Drawing.Point(3, 31);
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.Size = new System.Drawing.Size(77, 20);
            this._textBoxName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._buttonMoveFrom);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this._buttonMoveTo);
            this.panel2.Controls.Add(this._numericUpDownValue);
            this.panel2.Location = new System.Drawing.Point(269, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 54);
            this.panel2.TabIndex = 4;
            // 
            // _buttonMoveFrom
            // 
            this._buttonMoveFrom.Location = new System.Drawing.Point(127, 27);
            this._buttonMoveFrom.Name = "_buttonMoveFrom";
            this._buttonMoveFrom.Size = new System.Drawing.Size(130, 23);
            this._buttonMoveFrom.TabIndex = 4;
            this._buttonMoveFrom.Text = "Remove From Container";
            this._buttonMoveFrom.UseVisualStyleBackColor = true;
            this._buttonMoveFrom.Click += new System.EventHandler(this._buttonMoveFrom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Value (Item Only)";
            // 
            // _buttonMoveTo
            // 
            this._buttonMoveTo.Location = new System.Drawing.Point(127, 3);
            this._buttonMoveTo.Name = "_buttonMoveTo";
            this._buttonMoveTo.Size = new System.Drawing.Size(130, 23);
            this._buttonMoveTo.TabIndex = 3;
            this._buttonMoveTo.Text = "Add to Container";
            this._buttonMoveTo.UseVisualStyleBackColor = true;
            this._buttonMoveTo.Click += new System.EventHandler(this._buttonMoveTo_Click);
            // 
            // _numericUpDownValue
            // 
            this._numericUpDownValue.Location = new System.Drawing.Point(4, 30);
            this._numericUpDownValue.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this._numericUpDownValue.Name = "_numericUpDownValue";
            this._numericUpDownValue.Size = new System.Drawing.Size(87, 20);
            this._numericUpDownValue.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonEmpty);
            this.panel3.Controls.Add(this._buttonDelete);
            this.panel3.Controls.Add(this._buttonEdit);
            this.panel3.Controls.Add(this._buttonAddContainer);
            this.panel3.Controls.Add(this._buttonAddItem);
            this.panel3.Location = new System.Drawing.Point(535, 393);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 54);
            this.panel3.TabIndex = 5;
            // 
            // _buttonDelete
            // 
            this._buttonDelete.Location = new System.Drawing.Point(69, 27);
            this._buttonDelete.Name = "_buttonDelete";
            this._buttonDelete.Size = new System.Drawing.Size(93, 23);
            this._buttonDelete.TabIndex = 3;
            this._buttonDelete.Text = "Delete Selected";
            this._buttonDelete.UseVisualStyleBackColor = true;
            this._buttonDelete.Click += new System.EventHandler(this._buttonDelete_Click);
            // 
            // _buttonEdit
            // 
            this._buttonEdit.Location = new System.Drawing.Point(168, 27);
            this._buttonEdit.Name = "_buttonEdit";
            this._buttonEdit.Size = new System.Drawing.Size(91, 23);
            this._buttonEdit.TabIndex = 2;
            this._buttonEdit.Text = "Edit Selected";
            this._buttonEdit.UseVisualStyleBackColor = true;
            this._buttonEdit.Click += new System.EventHandler(this._buttonEdit_Click);
            // 
            // _buttonAddContainer
            // 
            this._buttonAddContainer.Location = new System.Drawing.Point(168, 3);
            this._buttonAddContainer.Name = "_buttonAddContainer";
            this._buttonAddContainer.Size = new System.Drawing.Size(91, 23);
            this._buttonAddContainer.TabIndex = 1;
            this._buttonAddContainer.Text = "Add Container";
            this._buttonAddContainer.UseVisualStyleBackColor = true;
            this._buttonAddContainer.Click += new System.EventHandler(this._buttonAddContainer_Click);
            // 
            // _buttonAddItem
            // 
            this._buttonAddItem.Location = new System.Drawing.Point(69, 3);
            this._buttonAddItem.Name = "_buttonAddItem";
            this._buttonAddItem.Size = new System.Drawing.Size(93, 23);
            this._buttonAddItem.TabIndex = 0;
            this._buttonAddItem.Text = "Add Item";
            this._buttonAddItem.UseVisualStyleBackColor = true;
            this._buttonAddItem.Click += new System.EventHandler(this._buttonAddItem_Click);
            // 
            // buttonEmpty
            // 
            this.buttonEmpty.Location = new System.Drawing.Point(4, 4);
            this.buttonEmpty.Name = "buttonEmpty";
            this.buttonEmpty.Size = new System.Drawing.Size(59, 23);
            this.buttonEmpty.TabIndex = 4;
            this.buttonEmpty.Text = "Empty";
            this.buttonEmpty.UseVisualStyleBackColor = true;
            this.buttonEmpty.Click += new System.EventHandler(this.buttonEmpty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewContainers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewStoredItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownWeight)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownValue)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView _dataGridViewItems;
        private System.Windows.Forms.DataGridView _dataGridViewContainers;
        private System.Windows.Forms.DataGridView _dataGridViewStoredItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _numericUpDownVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _numericUpDownWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textBoxName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button _buttonMoveFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _buttonMoveTo;
        private System.Windows.Forms.NumericUpDown _numericUpDownValue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button _buttonDelete;
        private System.Windows.Forms.Button _buttonEdit;
        private System.Windows.Forms.Button _buttonAddContainer;
        private System.Windows.Forms.Button _buttonAddItem;
        private System.Windows.Forms.Button buttonEmpty;
    }
}

