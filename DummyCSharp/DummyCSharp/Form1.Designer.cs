namespace DummyCSharp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbDummyPos = new System.Windows.Forms.ComboBox();
            this.cbVelocity = new System.Windows.Forms.ComboBox();
            this.cbCarModel = new System.Windows.Forms.ComboBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBoth = new System.Windows.Forms.RadioButton();
            this.rbGroundImp = new System.Windows.Forms.RadioButton();
            this.rbFirstImp = new System.Windows.Forms.RadioButton();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.resultNum2 = new System.Windows.Forms.TextBox();
            this.resultNum1 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.TextBox12 = new System.Windows.Forms.TextBox();
            this.trackState = new System.Windows.Forms.TrackBar();
            this.trackSpeed = new System.Windows.Forms.TrackBar();
            this.inc = new System.Windows.Forms.TextBox();
            this.TextBox10 = new System.Windows.Forms.TextBox();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.TextBox11 = new System.Windows.Forms.TextBox();
            this.pbVideo = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pbDemo = new System.Windows.Forms.PictureBox();
            this.btnAcceleration = new System.Windows.Forms.Button();
            this.btnAnnotation = new System.Windows.Forms.Button();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnSubmit);
            this.GroupBox1.Controls.Add(this.cbDummyPos);
            this.GroupBox1.Controls.Add(this.cbVelocity);
            this.GroupBox1.Controls.Add(this.cbCarModel);
            this.GroupBox1.Controls.Add(this.TextBox3);
            this.GroupBox1.Controls.Add(this.TextBox2);
            this.GroupBox1.Controls.Add(this.TextBox1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(288, 145);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Option";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(207, 104);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 30);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbDummyPos
            // 
            this.cbDummyPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDummyPos.FormattingEnabled = true;
            this.cbDummyPos.Items.AddRange(new object[] {
            "0",
            "45",
            "90"});
            this.cbDummyPos.Location = new System.Drawing.Point(124, 74);
            this.cbDummyPos.Name = "cbDummyPos";
            this.cbDummyPos.Size = new System.Drawing.Size(158, 21);
            this.cbDummyPos.TabIndex = 1;
            // 
            // cbVelocity
            // 
            this.cbVelocity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVelocity.FormattingEnabled = true;
            this.cbVelocity.Items.AddRange(new object[] {
            "30",
            "40",
            "50",
            "60"});
            this.cbVelocity.Location = new System.Drawing.Point(124, 47);
            this.cbVelocity.Name = "cbVelocity";
            this.cbVelocity.Size = new System.Drawing.Size(158, 21);
            this.cbVelocity.TabIndex = 1;
            // 
            // cbCarModel
            // 
            this.cbCarModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarModel.FormattingEnabled = true;
            this.cbCarModel.Items.AddRange(new object[] {
            "Pickup",
            "Sedan",
            "SUV"});
            this.cbCarModel.Location = new System.Drawing.Point(124, 20);
            this.cbCarModel.Name = "cbCarModel";
            this.cbCarModel.Size = new System.Drawing.Size(158, 21);
            this.cbCarModel.TabIndex = 1;
            // 
            // TextBox3
            // 
            this.TextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox3.Location = new System.Drawing.Point(7, 79);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(100, 15);
            this.TextBox3.TabIndex = 0;
            this.TextBox3.Text = "Dummy position";
            this.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox2.Location = new System.Drawing.Point(6, 51);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(100, 15);
            this.TextBox2.TabIndex = 0;
            this.TextBox2.Text = "Velocity";
            this.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.Location = new System.Drawing.Point(6, 23);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 15);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.Text = "Car model";
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.rbBoth);
            this.GroupBox2.Controls.Add(this.rbGroundImp);
            this.GroupBox2.Controls.Add(this.rbFirstImp);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(12, 163);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(288, 94);
            this.GroupBox2.TabIndex = 2;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Acceleration";
            // 
            // rbBoth
            // 
            this.rbBoth.AutoSize = true;
            this.rbBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBoth.Location = new System.Drawing.Point(15, 66);
            this.rbBoth.Name = "rbBoth";
            this.rbBoth.Size = new System.Drawing.Size(53, 20);
            this.rbBoth.TabIndex = 0;
            this.rbBoth.Text = "Both";
            this.rbBoth.UseVisualStyleBackColor = true;
            this.rbBoth.CheckedChanged += new System.EventHandler(this.rbBoth_CheckedChanged);
            // 
            // rbGroundImp
            // 
            this.rbGroundImp.AutoSize = true;
            this.rbGroundImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGroundImp.Location = new System.Drawing.Point(15, 43);
            this.rbGroundImp.Name = "rbGroundImp";
            this.rbGroundImp.Size = new System.Drawing.Size(113, 20);
            this.rbGroundImp.TabIndex = 0;
            this.rbGroundImp.Text = "Ground impact";
            this.rbGroundImp.UseVisualStyleBackColor = true;
            this.rbGroundImp.CheckedChanged += new System.EventHandler(this.rbGroundImp_CheckedChanged);
            // 
            // rbFirstImp
            // 
            this.rbFirstImp.AutoSize = true;
            this.rbFirstImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFirstImp.Location = new System.Drawing.Point(15, 20);
            this.rbFirstImp.Name = "rbFirstImp";
            this.rbFirstImp.Size = new System.Drawing.Size(94, 20);
            this.rbFirstImp.TabIndex = 0;
            this.rbFirstImp.Text = "First impact";
            this.rbFirstImp.UseVisualStyleBackColor = true;
            this.rbFirstImp.CheckedChanged += new System.EventHandler(this.rbFirstImp_CheckedChanged);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.TextBox5);
            this.GroupBox3.Controls.Add(this.resultNum2);
            this.GroupBox3.Controls.Add(this.resultNum1);
            this.GroupBox3.Controls.Add(this.TextBox4);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(12, 263);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(288, 81);
            this.GroupBox3.TabIndex = 3;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Result";
            // 
            // TextBox5
            // 
            this.TextBox5.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox5.Location = new System.Drawing.Point(15, 50);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(130, 15);
            this.TextBox5.TabIndex = 0;
            this.TextBox5.Text = "HIC-Ground impact :";
            this.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultNum2
            // 
            this.resultNum2.BackColor = System.Drawing.SystemColors.Control;
            this.resultNum2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultNum2.ForeColor = System.Drawing.Color.Red;
            this.resultNum2.Location = new System.Drawing.Point(176, 50);
            this.resultNum2.Name = "resultNum2";
            this.resultNum2.Size = new System.Drawing.Size(92, 15);
            this.resultNum2.TabIndex = 0;
            this.resultNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultNum1
            // 
            this.resultNum1.BackColor = System.Drawing.SystemColors.Control;
            this.resultNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultNum1.ForeColor = System.Drawing.Color.Red;
            this.resultNum1.Location = new System.Drawing.Point(176, 23);
            this.resultNum1.Name = "resultNum1";
            this.resultNum1.Size = new System.Drawing.Size(92, 15);
            this.resultNum1.TabIndex = 0;
            this.resultNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox4
            // 
            this.TextBox4.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox4.Location = new System.Drawing.Point(16, 22);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(130, 15);
            this.TextBox4.TabIndex = 0;
            this.TextBox4.Text = "HIC-First impact        :";
            this.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.TextBox12);
            this.GroupBox4.Controls.Add(this.trackState);
            this.GroupBox4.Controls.Add(this.trackSpeed);
            this.GroupBox4.Controls.Add(this.inc);
            this.GroupBox4.Controls.Add(this.TextBox10);
            this.GroupBox4.Controls.Add(this.TextBox8);
            this.GroupBox4.Controls.Add(this.TextBox11);
            this.GroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.Location = new System.Drawing.Point(12, 350);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(288, 81);
            this.GroupBox4.TabIndex = 4;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Animation";
            // 
            // TextBox12
            // 
            this.TextBox12.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox12.Location = new System.Drawing.Point(10, 48);
            this.TextBox12.Name = "TextBox12";
            this.TextBox12.Size = new System.Drawing.Size(40, 15);
            this.TextBox12.TabIndex = 2;
            this.TextBox12.Text = "State";
            // 
            // trackState
            // 
            this.trackState.AutoSize = false;
            this.trackState.Location = new System.Drawing.Point(45, 47);
            this.trackState.Maximum = 300;
            this.trackState.Minimum = 1;
            this.trackState.Name = "trackState";
            this.trackState.Size = new System.Drawing.Size(240, 22);
            this.trackState.TabIndex = 1;
            this.trackState.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackState.Value = 1;
            this.trackState.Scroll += new System.EventHandler(this.trackState_Scroll);
            // 
            // trackSpeed
            // 
            this.trackSpeed.AutoSize = false;
            this.trackSpeed.Location = new System.Drawing.Point(121, 22);
            this.trackSpeed.Maximum = 15;
            this.trackSpeed.Minimum = 1;
            this.trackSpeed.Name = "trackSpeed";
            this.trackSpeed.Size = new System.Drawing.Size(123, 22);
            this.trackSpeed.TabIndex = 1;
            this.trackSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackSpeed.Value = 1;
            this.trackSpeed.Scroll += new System.EventHandler(this.trackSpeed_Scroll);
            // 
            // inc
            // 
            this.inc.Location = new System.Drawing.Point(35, 21);
            this.inc.Name = "inc";
            this.inc.ReadOnly = true;
            this.inc.Size = new System.Drawing.Size(36, 21);
            this.inc.TabIndex = 0;
            this.inc.Text = "1";
            // 
            // TextBox10
            // 
            this.TextBox10.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox10.Location = new System.Drawing.Point(242, 24);
            this.TextBox10.Name = "TextBox10";
            this.TextBox10.Size = new System.Drawing.Size(44, 15);
            this.TextBox10.TabIndex = 0;
            this.TextBox10.Text = "Slower";
            this.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox8
            // 
            this.TextBox8.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox8.Location = new System.Drawing.Point(11, 24);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.Size = new System.Drawing.Size(30, 15);
            this.TextBox8.TabIndex = 0;
            this.TextBox8.Text = "inc:";
            // 
            // TextBox11
            // 
            this.TextBox11.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox11.Location = new System.Drawing.Point(77, 24);
            this.TextBox11.Name = "TextBox11";
            this.TextBox11.Size = new System.Drawing.Size(44, 15);
            this.TextBox11.TabIndex = 0;
            this.TextBox11.Text = "Faster";
            this.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbVideo
            // 
            this.pbVideo.Location = new System.Drawing.Point(306, 12);
            this.pbVideo.Name = "pbVideo";
            this.pbVideo.Size = new System.Drawing.Size(617, 348);
            this.pbVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVideo.TabIndex = 7;
            this.pbVideo.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(565, 366);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(45, 45);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(631, 368);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(45, 45);
            this.btnStop.TabIndex = 10;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pbDemo
            // 
            this.pbDemo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDemo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbDemo.Location = new System.Drawing.Point(929, 12);
            this.pbDemo.Name = "pbDemo";
            this.pbDemo.Size = new System.Drawing.Size(358, 332);
            this.pbDemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDemo.TabIndex = 8;
            this.pbDemo.TabStop = false;
            // 
            // btnAcceleration
            // 
            this.btnAcceleration.Location = new System.Drawing.Point(1042, 396);
            this.btnAcceleration.Name = "btnAcceleration";
            this.btnAcceleration.Size = new System.Drawing.Size(110, 20);
            this.btnAcceleration.TabIndex = 14;
            this.btnAcceleration.Text = "Acceleration Graph";
            this.btnAcceleration.UseVisualStyleBackColor = true;
            this.btnAcceleration.Click += new System.EventHandler(this.btnAcceleration_Click);
            // 
            // btnAnnotation
            // 
            this.btnAnnotation.Location = new System.Drawing.Point(961, 396);
            this.btnAnnotation.Name = "btnAnnotation";
            this.btnAnnotation.Size = new System.Drawing.Size(75, 20);
            this.btnAnnotation.TabIndex = 15;
            this.btnAnnotation.Text = "Annotation";
            this.btnAnnotation.UseVisualStyleBackColor = true;
            this.btnAnnotation.Click += new System.EventHandler(this.btnAnnotation_Click);
            // 
            // PictureBox3
            // 
            this.PictureBox3.Location = new System.Drawing.Point(947, 437);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(355, 309);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox3.TabIndex = 11;
            this.PictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox2.Location = new System.Drawing.Point(475, 437);
            this.PictureBox2.MinimumSize = new System.Drawing.Size(430, 300);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(456, 300);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 16;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.Location = new System.Drawing.Point(12, 437);
            this.PictureBox1.MinimumSize = new System.Drawing.Size(430, 300);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(457, 300);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 17;
            this.PictureBox1.TabStop = false;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 20;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 763);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.btnAcceleration);
            this.Controls.Add(this.btnAnnotation);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.pbVideo);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.pbDemo);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Dummy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnSubmit;
        internal System.Windows.Forms.ComboBox cbDummyPos;
        internal System.Windows.Forms.ComboBox cbVelocity;
        internal System.Windows.Forms.ComboBox cbCarModel;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.RadioButton rbBoth;
        internal System.Windows.Forms.RadioButton rbGroundImp;
        internal System.Windows.Forms.RadioButton rbFirstImp;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox TextBox5;
        internal System.Windows.Forms.TextBox resultNum2;
        internal System.Windows.Forms.TextBox resultNum1;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.TextBox TextBox12;
        internal System.Windows.Forms.TrackBar trackState;
        internal System.Windows.Forms.TrackBar trackSpeed;
        internal System.Windows.Forms.TextBox inc;
        internal System.Windows.Forms.TextBox TextBox10;
        internal System.Windows.Forms.TextBox TextBox8;
        internal System.Windows.Forms.TextBox TextBox11;
        internal System.Windows.Forms.PictureBox pbVideo;
        internal System.Windows.Forms.Button btnPlay;
        internal System.Windows.Forms.Button btnStop;
        internal System.Windows.Forms.PictureBox pbDemo;
        internal System.Windows.Forms.Button btnAcceleration;
        internal System.Windows.Forms.Button btnAnnotation;
        internal System.Windows.Forms.PictureBox PictureBox3;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Timer Timer1;
    }
}

