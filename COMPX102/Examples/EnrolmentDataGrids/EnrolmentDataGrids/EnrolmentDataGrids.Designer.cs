namespace EnrolmentDataGrids
{
  partial class EnrolmentsForm
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this._enrolledGrid = new System.Windows.Forms.DataGridView();
      this._enrolButton = new System.Windows.Forms.Button();
      this._allStudentsLabel = new System.Windows.Forms.Label();
      this._enrolledStudentsLabel = new System.Windows.Forms.Label();
      this._allPapersLabel = new System.Windows.Forms.Label();
      this._papersGrid = new System.Windows.Forms.DataGridView();
      this._studentsGrid = new System.Windows.Forms.DataGridView();
      this._studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.enrolmentCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this._paperBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this._enrolledGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this._papersGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this._studentsGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this._studentBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this._paperBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
      this.tableLayoutPanel1.Controls.Add(this._enrolledGrid, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this._enrolButton, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this._allStudentsLabel, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this._enrolledStudentsLabel, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this._allPapersLabel, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this._papersGrid, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this._studentsGrid, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1285, 433);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // _enrolledGrid
      // 
      this._enrolledGrid.AllowUserToAddRows = false;
      this._enrolledGrid.AutoGenerateColumns = false;
      this._enrolledGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this._enrolledGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
      this._enrolledGrid.DataSource = this._studentBindingSource;
      this._enrolledGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this._enrolledGrid.Location = new System.Drawing.Point(903, 43);
      this._enrolledGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this._enrolledGrid.Name = "_enrolledGrid";
      this._enrolledGrid.RowHeadersWidth = 24;
      this._enrolledGrid.Size = new System.Drawing.Size(378, 327);
      this._enrolledGrid.TabIndex = 11;
      // 
      // _enrolButton
      // 
      this._enrolButton.Dock = System.Windows.Forms.DockStyle.Fill;
      this._enrolButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._enrolButton.Location = new System.Drawing.Point(518, 378);
      this._enrolButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this._enrolButton.Name = "_enrolButton";
      this._enrolButton.Size = new System.Drawing.Size(377, 51);
      this._enrolButton.TabIndex = 0;
      this._enrolButton.Text = "Enrol Student";
      this._enrolButton.UseVisualStyleBackColor = true;
      this._enrolButton.Click += new System.EventHandler(this.EnrolButtonClick);
      // 
      // _allStudentsLabel
      // 
      this._allStudentsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this._allStudentsLabel.AutoSize = true;
      this._allStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._allStudentsLabel.Location = new System.Drawing.Point(518, 9);
      this._allStudentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this._allStudentsLabel.Name = "_allStudentsLabel";
      this._allStudentsLabel.Size = new System.Drawing.Size(117, 20);
      this._allStudentsLabel.TabIndex = 1;
      this._allStudentsLabel.Text = "All Students:";
      // 
      // _enrolledStudentsLabel
      // 
      this._enrolledStudentsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this._enrolledStudentsLabel.AutoSize = true;
      this._enrolledStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._enrolledStudentsLabel.Location = new System.Drawing.Point(903, 9);
      this._enrolledStudentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this._enrolledStudentsLabel.Name = "_enrolledStudentsLabel";
      this._enrolledStudentsLabel.Size = new System.Drawing.Size(164, 20);
      this._enrolledStudentsLabel.TabIndex = 2;
      this._enrolledStudentsLabel.Text = "Enrolled Students:";
      // 
      // _allPapersLabel
      // 
      this._allPapersLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this._allPapersLabel.AutoSize = true;
      this._allPapersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._allPapersLabel.Location = new System.Drawing.Point(4, 9);
      this._allPapersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this._allPapersLabel.Name = "_allPapersLabel";
      this._allPapersLabel.Size = new System.Drawing.Size(74, 20);
      this._allPapersLabel.TabIndex = 3;
      this._allPapersLabel.Text = "Papers:";
      // 
      // _papersGrid
      // 
      this._papersGrid.AutoGenerateColumns = false;
      this._papersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this._papersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.enrolmentCountDataGridViewTextBoxColumn});
      this._papersGrid.DataSource = this._paperBindingSource;
      this._papersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this._papersGrid.Location = new System.Drawing.Point(4, 43);
      this._papersGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this._papersGrid.Name = "_papersGrid";
      this._papersGrid.RowHeadersWidth = 24;
      this._papersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this._papersGrid.Size = new System.Drawing.Size(506, 327);
      this._papersGrid.TabIndex = 9;
      this._papersGrid.SelectionChanged += new System.EventHandler(this.PapersGridSelectionChanged);
      // 
      // _studentsGrid
      // 
      this._studentsGrid.AutoGenerateColumns = false;
      this._studentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this._studentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
      this._studentsGrid.DataSource = this._studentBindingSource;
      this._studentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this._studentsGrid.Location = new System.Drawing.Point(518, 43);
      this._studentsGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this._studentsGrid.Name = "_studentsGrid";
      this._studentsGrid.RowHeadersWidth = 24;
      this._studentsGrid.Size = new System.Drawing.Size(377, 327);
      this._studentsGrid.TabIndex = 10;
      // 
      // _studentBindingSource
      // 
      this._studentBindingSource.DataSource = typeof(EnrolmentDataGrids.Student);
      // 
      // codeDataGridViewTextBoxColumn
      // 
      this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
      this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
      this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
      this.codeDataGridViewTextBoxColumn.Width = 75;
      // 
      // titleDataGridViewTextBoxColumn
      // 
      this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
      this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
      this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
      // 
      // enrolmentCountDataGridViewTextBoxColumn
      // 
      this.enrolmentCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.enrolmentCountDataGridViewTextBoxColumn.DataPropertyName = "EnrolmentCount";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle2.Format = "N0";
      dataGridViewCellStyle2.NullValue = null;
      dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
      this.enrolmentCountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
      this.enrolmentCountDataGridViewTextBoxColumn.HeaderText = "Students";
      this.enrolmentCountDataGridViewTextBoxColumn.Name = "enrolmentCountDataGridViewTextBoxColumn";
      this.enrolmentCountDataGridViewTextBoxColumn.ReadOnly = true;
      this.enrolmentCountDataGridViewTextBoxColumn.Width = 60;
      // 
      // _paperBindingSource
      // 
      this._paperBindingSource.DataSource = typeof(EnrolmentDataGrids.Paper);
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "ID";
      dataGridViewCellStyle3.Format = "D8";
      dataGridViewCellStyle3.NullValue = null;
      this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridViewTextBoxColumn4.HeaderText = "ID";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.Width = 64;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn5.DataPropertyName = "FirstName";
      this.dataGridViewTextBoxColumn5.HeaderText = "First Name";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn6.DataPropertyName = "LastName";
      this.dataGridViewTextBoxColumn6.HeaderText = "Last Name";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      // 
      // dataGridViewTextBoxColumn7
      // 
      this.dataGridViewTextBoxColumn7.DataPropertyName = "ID";
      dataGridViewCellStyle1.Format = "D8";
      this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridViewTextBoxColumn7.HeaderText = "ID";
      this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
      this.dataGridViewTextBoxColumn7.Width = 64;
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn8.DataPropertyName = "FirstName";
      this.dataGridViewTextBoxColumn8.HeaderText = "First Name";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      // 
      // dataGridViewTextBoxColumn9
      // 
      this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn9.DataPropertyName = "LastName";
      this.dataGridViewTextBoxColumn9.HeaderText = "Last Name";
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      // 
      // EnrolmentsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1285, 433);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "EnrolmentsForm";
      this.Text = "Student Enrolment";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this._enrolledGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this._papersGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this._studentsGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this._studentBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this._paperBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button _enrolButton;
    private System.Windows.Forms.Label _allStudentsLabel;
    private System.Windows.Forms.Label _enrolledStudentsLabel;
    private System.Windows.Forms.Label _allPapersLabel;
    private System.Windows.Forms.DataGridView _papersGrid;
    private System.Windows.Forms.BindingSource _paperBindingSource;
    private System.Windows.Forms.DataGridView _enrolledGrid;
    private System.Windows.Forms.BindingSource _studentBindingSource;
    private System.Windows.Forms.DataGridView _studentsGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn enrolmentCountDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
  }
}

