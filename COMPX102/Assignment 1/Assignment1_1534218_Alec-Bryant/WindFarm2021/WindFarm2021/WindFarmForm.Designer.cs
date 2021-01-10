namespace Compx102H
{
  partial class WindFarmForm
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
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._pictureBoxWindFarm = new System.Windows.Forms.PictureBox();
            this._heightLabel = new System.Windows.Forms.Label();
            this._radiusLabel = new System.Windows.Forms.Label();
            this._clearButton = new System.Windows.Forms.Button();
            this._statusLabel = new System.Windows.Forms.Label();
            this._heightTrackBar = new System.Windows.Forms.TrackBar();
            this._radiusTrackBar = new System.Windows.Forms.TrackBar();
            this._numberOfBladesLabel = new System.Windows.Forms.Label();
            this._numberOfBladesUpDown = new System.Windows.Forms.NumericUpDown();
            this._poleColorLabel = new System.Windows.Forms.Label();
            this._clockwiseLabel = new System.Windows.Forms.Label();
            this._poleColorButton = new System.Windows.Forms.Button();
            this._clockwiseCheckBox = new System.Windows.Forms.CheckBox();
            this._capacityLabel = new System.Windows.Forms.Label();
            this._rotorColorLabel = new System.Windows.Forms.Label();
            this._capacityUpDown = new System.Windows.Forms.NumericUpDown();
            this._rotorColorButton = new System.Windows.Forms.Button();
            this._animationTimer = new System.Windows.Forms.Timer(this.components);
            this._tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxWindFarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._heightTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._radiusTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numberOfBladesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._capacityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 3;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this._tableLayoutPanel.Controls.Add(this._pictureBoxWindFarm, 0, 0);
            this._tableLayoutPanel.Controls.Add(this._heightLabel, 1, 0);
            this._tableLayoutPanel.Controls.Add(this._radiusLabel, 1, 1);
            this._tableLayoutPanel.Controls.Add(this._clearButton, 2, 7);
            this._tableLayoutPanel.Controls.Add(this._statusLabel, 0, 7);
            this._tableLayoutPanel.Controls.Add(this._heightTrackBar, 2, 0);
            this._tableLayoutPanel.Controls.Add(this._radiusTrackBar, 2, 1);
            this._tableLayoutPanel.Controls.Add(this._numberOfBladesLabel, 1, 2);
            this._tableLayoutPanel.Controls.Add(this._numberOfBladesUpDown, 2, 2);
            this._tableLayoutPanel.Controls.Add(this._poleColorLabel, 1, 4);
            this._tableLayoutPanel.Controls.Add(this._clockwiseLabel, 1, 3);
            this._tableLayoutPanel.Controls.Add(this._poleColorButton, 2, 4);
            this._tableLayoutPanel.Controls.Add(this._clockwiseCheckBox, 2, 3);
            this._tableLayoutPanel.Controls.Add(this._capacityLabel, 1, 6);
            this._tableLayoutPanel.Controls.Add(this._rotorColorLabel, 1, 5);
            this._tableLayoutPanel.Controls.Add(this._capacityUpDown, 2, 6);
            this._tableLayoutPanel.Controls.Add(this._rotorColorButton, 2, 5);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 8;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(689, 405);
            this._tableLayoutPanel.TabIndex = 0;
            // 
            // _pictureBoxWindFarm
            // 
            this._pictureBoxWindFarm.BackColor = System.Drawing.Color.PaleGreen;
            this._pictureBoxWindFarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._pictureBoxWindFarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pictureBoxWindFarm.Location = new System.Drawing.Point(3, 3);
            this._pictureBoxWindFarm.Name = "_pictureBoxWindFarm";
            this._tableLayoutPanel.SetRowSpan(this._pictureBoxWindFarm, 7);
            this._pictureBoxWindFarm.Size = new System.Drawing.Size(404, 365);
            this._pictureBoxWindFarm.TabIndex = 0;
            this._pictureBoxWindFarm.TabStop = false;
            this._pictureBoxWindFarm.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxWindFarmPaint);
            this._pictureBoxWindFarm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxWindFarmMouseClick);
            this._pictureBoxWindFarm.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this._pictureBoxWindFarm_MouseDoubleClick);
            // 
            // _heightLabel
            // 
            this._heightLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._heightLabel.AutoSize = true;
            this._heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._heightLabel.Location = new System.Drawing.Point(413, 13);
            this._heightLabel.Name = "_heightLabel";
            this._heightLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this._heightLabel.Size = new System.Drawing.Size(104, 26);
            this._heightLabel.TabIndex = 0;
            this._heightLabel.Text = "Pole height:";
            // 
            // _radiusLabel
            // 
            this._radiusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._radiusLabel.AutoSize = true;
            this._radiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._radiusLabel.Location = new System.Drawing.Point(413, 66);
            this._radiusLabel.Name = "_radiusLabel";
            this._radiusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this._radiusLabel.Size = new System.Drawing.Size(113, 26);
            this._radiusLabel.TabIndex = 2;
            this._radiusLabel.Text = "Rotor radius:";
            this._radiusLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._radiusLabel.UseMnemonic = false;
            // 
            // _clearButton
            // 
            this._clearButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._clearButton.Location = new System.Drawing.Point(532, 373);
            this._clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._clearButton.Name = "_clearButton";
            this._clearButton.Size = new System.Drawing.Size(154, 30);
            this._clearButton.TabIndex = 15;
            this._clearButton.Text = "Clear";
            this._clearButton.UseVisualStyleBackColor = true;
            this._clearButton.Click += new System.EventHandler(this._clearButton_Click);
            // 
            // _statusLabel
            // 
            this._statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._statusLabel.AutoSize = true;
            this._tableLayoutPanel.SetColumnSpan(this._statusLabel, 2);
            this._statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._statusLabel.Location = new System.Drawing.Point(3, 379);
            this._statusLabel.Name = "_statusLabel";
            this._statusLabel.Size = new System.Drawing.Size(100, 18);
            this._statusLabel.TabIndex = 14;
            this._statusLabel.Text = "Status: Ready";
            // 
            // _heightTrackBar
            // 
            this._heightTrackBar.LargeChange = 10;
            this._heightTrackBar.Location = new System.Drawing.Point(532, 3);
            this._heightTrackBar.Maximum = 500;
            this._heightTrackBar.Minimum = 10;
            this._heightTrackBar.Name = "_heightTrackBar";
            this._heightTrackBar.Size = new System.Drawing.Size(154, 45);
            this._heightTrackBar.TabIndex = 1;
            this._heightTrackBar.TickFrequency = 50;
            this._heightTrackBar.Value = 150;
            // 
            // _radiusTrackBar
            // 
            this._radiusTrackBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._radiusTrackBar.LargeChange = 10;
            this._radiusTrackBar.Location = new System.Drawing.Point(532, 58);
            this._radiusTrackBar.Maximum = 100;
            this._radiusTrackBar.Name = "_radiusTrackBar";
            this._radiusTrackBar.Size = new System.Drawing.Size(154, 45);
            this._radiusTrackBar.TabIndex = 3;
            this._radiusTrackBar.TickFrequency = 10;
            this._radiusTrackBar.Value = 75;
            // 
            // _numberOfBladesLabel
            // 
            this._numberOfBladesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._numberOfBladesLabel.AutoSize = true;
            this._numberOfBladesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._numberOfBladesLabel.Location = new System.Drawing.Point(413, 119);
            this._numberOfBladesLabel.Name = "_numberOfBladesLabel";
            this._numberOfBladesLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this._numberOfBladesLabel.Size = new System.Drawing.Size(69, 26);
            this._numberOfBladesLabel.TabIndex = 4;
            this._numberOfBladesLabel.Text = "Blades:";
            this._numberOfBladesLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._numberOfBladesLabel.UseMnemonic = false;
            // 
            // _numberOfBladesUpDown
            // 
            this._numberOfBladesUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._numberOfBladesUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._numberOfBladesUpDown.Location = new System.Drawing.Point(532, 119);
            this._numberOfBladesUpDown.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this._numberOfBladesUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numberOfBladesUpDown.Name = "_numberOfBladesUpDown";
            this._numberOfBladesUpDown.Size = new System.Drawing.Size(154, 26);
            this._numberOfBladesUpDown.TabIndex = 5;
            this._numberOfBladesUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // _poleColorLabel
            // 
            this._poleColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._poleColorLabel.AutoSize = true;
            this._poleColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._poleColorLabel.Location = new System.Drawing.Point(413, 225);
            this._poleColorLabel.Name = "_poleColorLabel";
            this._poleColorLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this._poleColorLabel.Size = new System.Drawing.Size(103, 26);
            this._poleColorLabel.TabIndex = 8;
            this._poleColorLabel.Text = "Pole colour:";
            this._poleColorLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._poleColorLabel.UseMnemonic = false;
            // 
            // _clockwiseLabel
            // 
            this._clockwiseLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._clockwiseLabel.AutoSize = true;
            this._clockwiseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._clockwiseLabel.Location = new System.Drawing.Point(413, 172);
            this._clockwiseLabel.Name = "_clockwiseLabel";
            this._clockwiseLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this._clockwiseLabel.Size = new System.Drawing.Size(93, 26);
            this._clockwiseLabel.TabIndex = 6;
            this._clockwiseLabel.Text = "Clockwise:";
            this._clockwiseLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._clockwiseLabel.UseMnemonic = false;
            // 
            // _poleColorButton
            // 
            this._poleColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._poleColorButton.BackColor = System.Drawing.Color.White;
            this._poleColorButton.Location = new System.Drawing.Point(532, 227);
            this._poleColorButton.Name = "_poleColorButton";
            this._poleColorButton.Size = new System.Drawing.Size(154, 23);
            this._poleColorButton.TabIndex = 9;
            this._poleColorButton.UseVisualStyleBackColor = false;
            // 
            // _clockwiseCheckBox
            // 
            this._clockwiseCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._clockwiseCheckBox.AutoSize = true;
            this._clockwiseCheckBox.Checked = true;
            this._clockwiseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this._clockwiseCheckBox.Location = new System.Drawing.Point(532, 178);
            this._clockwiseCheckBox.Name = "_clockwiseCheckBox";
            this._clockwiseCheckBox.Size = new System.Drawing.Size(15, 14);
            this._clockwiseCheckBox.TabIndex = 7;
            this._clockwiseCheckBox.UseVisualStyleBackColor = true;
            // 
            // _capacityLabel
            // 
            this._capacityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._capacityLabel.AutoSize = true;
            this._capacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._capacityLabel.Location = new System.Drawing.Point(413, 331);
            this._capacityLabel.Name = "_capacityLabel";
            this._capacityLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this._capacityLabel.Size = new System.Drawing.Size(83, 26);
            this._capacityLabel.TabIndex = 12;
            this._capacityLabel.Text = "Capacity:";
            this._capacityLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._capacityLabel.UseMnemonic = false;
            // 
            // _rotorColorLabel
            // 
            this._rotorColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._rotorColorLabel.AutoSize = true;
            this._rotorColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._rotorColorLabel.Location = new System.Drawing.Point(413, 278);
            this._rotorColorLabel.Name = "_rotorColorLabel";
            this._rotorColorLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this._rotorColorLabel.Size = new System.Drawing.Size(113, 26);
            this._rotorColorLabel.TabIndex = 10;
            this._rotorColorLabel.Text = "Rotor colour:";
            this._rotorColorLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._rotorColorLabel.UseMnemonic = false;
            // 
            // _capacityUpDown
            // 
            this._capacityUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._capacityUpDown.DecimalPlaces = 1;
            this._capacityUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._capacityUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this._capacityUpDown.Location = new System.Drawing.Point(532, 331);
            this._capacityUpDown.Name = "_capacityUpDown";
            this._capacityUpDown.Size = new System.Drawing.Size(154, 26);
            this._capacityUpDown.TabIndex = 13;
            this._capacityUpDown.Value = new decimal(new int[] {
            32,
            0,
            0,
            65536});
            // 
            // _rotorColorButton
            // 
            this._rotorColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._rotorColorButton.BackColor = System.Drawing.Color.DarkOrange;
            this._rotorColorButton.Location = new System.Drawing.Point(532, 280);
            this._rotorColorButton.Name = "_rotorColorButton";
            this._rotorColorButton.Size = new System.Drawing.Size(154, 23);
            this._rotorColorButton.TabIndex = 11;
            this._rotorColorButton.UseVisualStyleBackColor = false;
            // 
            // _animationTimer
            // 
            this._animationTimer.Enabled = true;
            this._animationTimer.Interval = 50;
            this._animationTimer.Tick += new System.EventHandler(this.AnimationTimerTick);
            // 
            // WindFarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 405);
            this.Controls.Add(this._tableLayoutPanel);
            this.Name = "WindFarmForm";
            this.Text = "COMPX102-21H Wind Farm";
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxWindFarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._heightTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._radiusTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numberOfBladesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._capacityUpDown)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
    private System.Windows.Forms.PictureBox _pictureBoxWindFarm;
    private System.Windows.Forms.Label _heightLabel;
    private System.Windows.Forms.Label _radiusLabel;
    private System.Windows.Forms.TrackBar _heightTrackBar;
    private System.Windows.Forms.Label _capacityLabel;
    private System.Windows.Forms.NumericUpDown _numberOfBladesUpDown;
    private System.Windows.Forms.Label _numberOfBladesLabel;
    private System.Windows.Forms.TrackBar _radiusTrackBar;
    private System.Windows.Forms.NumericUpDown _capacityUpDown;
    private System.Windows.Forms.Button _poleColorButton;
    private System.Windows.Forms.Label _rotorColorLabel;
    private System.Windows.Forms.Label _clockwiseLabel;
    private System.Windows.Forms.CheckBox _clockwiseCheckBox;
    private System.Windows.Forms.Label _poleColorLabel;
    private System.Windows.Forms.Button _rotorColorButton;
    private System.Windows.Forms.Button _clearButton;
    private System.Windows.Forms.Label _statusLabel;
        private System.Windows.Forms.Timer _animationTimer;
    }
}

