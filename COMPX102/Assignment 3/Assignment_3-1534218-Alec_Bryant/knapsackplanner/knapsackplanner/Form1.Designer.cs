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
            this.dataGridViewStoredSItems = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridViewContainers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStoredSItems)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewStoredSItems, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _dataGridViewItems
            // 
            this._dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewItems.Location = new System.Drawing.Point(3, 63);
            this._dataGridViewItems.Name = "_dataGridViewItems";
            this._dataGridViewItems.Size = new System.Drawing.Size(260, 324);
            this._dataGridViewItems.TabIndex = 0;
            // 
            // _dataGridViewContainers
            // 
            this._dataGridViewContainers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridViewContainers.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridViewContainers.Location = new System.Drawing.Point(269, 63);
            this._dataGridViewContainers.Name = "_dataGridViewContainers";
            this._dataGridViewContainers.Size = new System.Drawing.Size(260, 324);
            this._dataGridViewContainers.TabIndex = 1;
            // 
            // dataGridViewStoredSItems
            // 
            this.dataGridViewStoredSItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStoredSItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStoredSItems.Location = new System.Drawing.Point(535, 63);
            this.dataGridViewStoredSItems.Name = "dataGridViewStoredSItems";
            this.dataGridViewStoredSItems.Size = new System.Drawing.Size(262, 324);
            this.dataGridViewStoredSItems.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStoredSItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView _dataGridViewItems;
        private System.Windows.Forms.DataGridView _dataGridViewContainers;
        private System.Windows.Forms.DataGridView dataGridViewStoredSItems;
    }
}

