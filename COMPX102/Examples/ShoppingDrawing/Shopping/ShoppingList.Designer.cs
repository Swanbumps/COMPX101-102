namespace Shopping
{
    partial class MainWindow
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
            if (disposing && (components != null)) {
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._listBox = new System.Windows.Forms.ListBox();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._findButton = new System.Windows.Forms.Button();
            this._totalButton = new System.Windows.Forms.Button();
            this._removeButton = new System.Windows.Forms.Button();
            this._replaceButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this._listBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this._nameTextBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this._findButton, 3, 2);
            this.tableLayoutPanel.Controls.Add(this._totalButton, 3, 2);
            this.tableLayoutPanel.Controls.Add(this._removeButton, 2, 2);
            this.tableLayoutPanel.Controls.Add(this._replaceButton, 1, 2);
            this.tableLayoutPanel.Controls.Add(this._addButton, 0, 2);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(475, 403);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // _listBox
            // 
            this._listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.SetColumnSpan(this._listBox, 5);
            this._listBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._listBox.FormattingEnabled = true;
            this._listBox.ItemHeight = 24;
            this._listBox.Location = new System.Drawing.Point(3, 3);
            this._listBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
            this._listBox.Name = "_listBox";
            this._listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this._listBox.Size = new System.Drawing.Size(469, 316);
            this._listBox.TabIndex = 0;
            this._listBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBoxDrawItem);
            this._listBox.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedIndexChanged);
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.SetColumnSpan(this._nameTextBox, 5);
            this._nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._nameTextBox.Location = new System.Drawing.Point(3, 324);
            this._nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(469, 29);
            this._nameTextBox.TabIndex = 1;
            this._nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameTextBoxKeyDown);
            // 
            // _findButton
            // 
            this._findButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._findButton.Location = new System.Drawing.Point(383, 358);
            this._findButton.Name = "_findButton";
            this._findButton.Size = new System.Drawing.Size(89, 42);
            this._findButton.TabIndex = 7;
            this._findButton.Text = "Find";
            this._findButton.UseVisualStyleBackColor = true;
            this._findButton.Click += new System.EventHandler(this.FindButtonClick);
            // 
            // _totalButton
            // 
            this._totalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._totalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._totalButton.Location = new System.Drawing.Point(288, 358);
            this._totalButton.Name = "_totalButton";
            this._totalButton.Size = new System.Drawing.Size(89, 42);
            this._totalButton.TabIndex = 8;
            this._totalButton.Text = "Total";
            this._totalButton.UseVisualStyleBackColor = true;
            this._totalButton.Click += new System.EventHandler(this.TotalButtonClick);
            // 
            // _removeButton
            // 
            this._removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._removeButton.Location = new System.Drawing.Point(193, 358);
            this._removeButton.Name = "_removeButton";
            this._removeButton.Size = new System.Drawing.Size(89, 42);
            this._removeButton.TabIndex = 6;
            this._removeButton.Text = "Remove";
            this._removeButton.UseVisualStyleBackColor = true;
            this._removeButton.Click += new System.EventHandler(this.RemoveButtonClick);
            // 
            // _replaceButton
            // 
            this._replaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._replaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._replaceButton.Location = new System.Drawing.Point(98, 358);
            this._replaceButton.Name = "_replaceButton";
            this._replaceButton.Size = new System.Drawing.Size(89, 42);
            this._replaceButton.TabIndex = 5;
            this._replaceButton.Text = "Replace";
            this._replaceButton.UseVisualStyleBackColor = true;
            this._replaceButton.Click += new System.EventHandler(this.ReplaceButtonClick);
            // 
            // _addButton
            // 
            this._addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._addButton.Location = new System.Drawing.Point(3, 358);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(89, 42);
            this._addButton.TabIndex = 4;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 403);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainWindow";
            this.Text = "Shopping List";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.ListBox _listBox;
        private System.Windows.Forms.Button _findButton;
        private System.Windows.Forms.Button _removeButton;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _replaceButton;
    private System.Windows.Forms.Button _totalButton;
  }
}

