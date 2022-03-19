namespace AutoClicker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.milisecondsBox = new System.Windows.Forms.NumericUpDown();
            this.secondsBox = new System.Windows.Forms.NumericUpDown();
            this.minutesBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rightCheckbox = new System.Windows.Forms.CheckBox();
            this.leftCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.milisecondsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.milisecondsBox);
            this.groupBox.Controls.Add(this.secondsBox);
            this.groupBox.Controls.Add(this.minutesBox);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(246, 105);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Click Interval";
            // 
            // milisecondsBox
            // 
            this.milisecondsBox.Location = new System.Drawing.Point(6, 72);
            this.milisecondsBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.milisecondsBox.Name = "milisecondsBox";
            this.milisecondsBox.Size = new System.Drawing.Size(77, 20);
            this.milisecondsBox.TabIndex = 8;
            this.milisecondsBox.ValueChanged += new System.EventHandler(this.textChangedInBox);
            this.milisecondsBox.Click += new System.EventHandler(this.textChangedInBox);
            this.milisecondsBox.Enter += new System.EventHandler(this.textChangedInBox);
            this.milisecondsBox.Leave += new System.EventHandler(this.textChangedInBox);
            // 
            // secondsBox
            // 
            this.secondsBox.Location = new System.Drawing.Point(6, 46);
            this.secondsBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.secondsBox.Name = "secondsBox";
            this.secondsBox.Size = new System.Drawing.Size(77, 20);
            this.secondsBox.TabIndex = 7;
            this.secondsBox.ValueChanged += new System.EventHandler(this.textChangedInBox);
            this.secondsBox.Click += new System.EventHandler(this.textChangedInBox);
            // 
            // minutesBox
            // 
            this.minutesBox.Location = new System.Drawing.Point(6, 20);
            this.minutesBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.minutesBox.Name = "minutesBox";
            this.minutesBox.Size = new System.Drawing.Size(77, 20);
            this.minutesBox.TabIndex = 6;
            this.minutesBox.ValueChanged += new System.EventHandler(this.textChangedInBox);
            this.minutesBox.Click += new System.EventHandler(this.textChangedInBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Miliseconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minutes";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 123);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(102, 47);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start (F1)";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(120, 123);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(102, 47);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop (F2)";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rightCheckbox);
            this.groupBox1.Controls.Add(this.leftCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(264, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 105);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click Mode";
            // 
            // rightCheckbox
            // 
            this.rightCheckbox.AutoSize = true;
            this.rightCheckbox.Location = new System.Drawing.Point(6, 46);
            this.rightCheckbox.Name = "rightCheckbox";
            this.rightCheckbox.Size = new System.Drawing.Size(77, 17);
            this.rightCheckbox.TabIndex = 1;
            this.rightCheckbox.Text = "Right Click";
            this.rightCheckbox.UseVisualStyleBackColor = true;
            this.rightCheckbox.Click += new System.EventHandler(this.checkboxChangedRight);
            // 
            // leftCheckbox
            // 
            this.leftCheckbox.AutoSize = true;
            this.leftCheckbox.Checked = true;
            this.leftCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.leftCheckbox.Location = new System.Drawing.Point(6, 22);
            this.leftCheckbox.Name = "leftCheckbox";
            this.leftCheckbox.Size = new System.Drawing.Size(70, 17);
            this.leftCheckbox.TabIndex = 0;
            this.leftCheckbox.Text = "Left Click";
            this.leftCheckbox.UseVisualStyleBackColor = true;
            this.leftCheckbox.Click += new System.EventHandler(this.checkboxChangedLeft);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(404, 182);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Clicker MAX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exitProgram);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.milisecondsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.NumericUpDown milisecondsBox;
        private System.Windows.Forms.NumericUpDown secondsBox;
        private System.Windows.Forms.NumericUpDown minutesBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox rightCheckbox;
        private System.Windows.Forms.CheckBox leftCheckbox;
    }
}

