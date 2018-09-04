namespace Config_Maker
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
            this.foldersRTB = new System.Windows.Forms.RichTextBox();
            this.GoBtn = new System.Windows.Forms.Button();
            this.outputFolderBrowseBtn = new System.Windows.Forms.Button();
            this.outputFolderTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.irCodesFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.logBtn = new System.Windows.Forms.LinkLabel();
            this.navigationBtn = new System.Windows.Forms.Button();
            this.numbersBtn = new System.Windows.Forms.Button();
            this.colorsBrn = new System.Windows.Forms.Button();
            this.channelBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.volumeBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.acGoBtn = new System.Windows.Forms.Button();
            this.acOutputTB = new System.Windows.Forms.TextBox();
            this.acBrowseBtn = new System.Windows.Forms.Button();
            this.fanSpeedGB = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fanSpeedTB = new System.Windows.Forms.TrackBar();
            this.modesGB = new System.Windows.Forms.GroupBox();
            this.aiCB = new System.Windows.Forms.CheckBox();
            this.windCB = new System.Windows.Forms.CheckBox();
            this.hotCB = new System.Windows.Forms.CheckBox();
            this.coldCB = new System.Windows.Forms.CheckBox();
            this.degreesGB = new System.Windows.Forms.GroupBox();
            this.degreeTypeCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maxDegreeDUD = new System.Windows.Forms.DomainUpDown();
            this.minDegreeDUD = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.swingBtn = new System.Windows.Forms.Button();
            this.powerBtn = new System.Windows.Forms.Button();
            this.fanSpeedBtn = new System.Windows.Forms.Button();
            this.modesBtn = new System.Windows.Forms.Button();
            this.tempDownBtn = new System.Windows.Forms.Button();
            this.tempUpBtn = new System.Windows.Forms.Button();
            this.acRTB = new System.Windows.Forms.RichTextBox();
            this.acOutputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.fanSpeedGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fanSpeedTB)).BeginInit();
            this.modesGB.SuspendLayout();
            this.degreesGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // foldersRTB
            // 
            this.foldersRTB.AllowDrop = true;
            this.foldersRTB.EnableAutoDragDrop = true;
            this.foldersRTB.Font = new System.Drawing.Font("Consolas", 13F);
            this.foldersRTB.Location = new System.Drawing.Point(6, 6);
            this.foldersRTB.Name = "foldersRTB";
            this.foldersRTB.Size = new System.Drawing.Size(571, 190);
            this.foldersRTB.TabIndex = 1;
            this.foldersRTB.Text = "";
            this.foldersRTB.TextChanged += new System.EventHandler(this.foldersRTB_TextChanged);
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(229, 54);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(100, 57);
            this.GoBtn.TabIndex = 3;
            this.GoBtn.Text = "Go\r\n(CTRL + G)";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // outputFolderBrowseBtn
            // 
            this.outputFolderBrowseBtn.Location = new System.Drawing.Point(472, 15);
            this.outputFolderBrowseBtn.Name = "outputFolderBrowseBtn";
            this.outputFolderBrowseBtn.Size = new System.Drawing.Size(81, 38);
            this.outputFolderBrowseBtn.TabIndex = 0;
            this.outputFolderBrowseBtn.TabStop = false;
            this.outputFolderBrowseBtn.Text = "Browse...";
            this.outputFolderBrowseBtn.UseVisualStyleBackColor = true;
            this.outputFolderBrowseBtn.Click += new System.EventHandler(this.outputFolderBrowseBtn_Click);
            // 
            // outputFolderTB
            // 
            this.outputFolderTB.AllowDrop = true;
            this.outputFolderTB.Location = new System.Drawing.Point(87, 23);
            this.outputFolderTB.Name = "outputFolderTB";
            this.outputFolderTB.Size = new System.Drawing.Size(364, 20);
            this.outputFolderTB.TabIndex = 2;
            this.outputFolderTB.TextChanged += new System.EventHandler(this.outputFolderTB_TextChanged);
            this.outputFolderTB.DragDrop += new System.Windows.Forms.DragEventHandler(this.IrCodesPathDropHandler);
            this.outputFolderTB.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterHandler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-120, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Output Folder";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // outputFolderDialog
            // 
            this.outputFolderDialog.HelpRequest += new System.EventHandler(this.outputFolderDialog_HelpRequest);
            // 
            // logBtn
            // 
            this.logBtn.AutoSize = true;
            this.logBtn.Location = new System.Drawing.Point(536, 94);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(29, 13);
            this.logBtn.TabIndex = 0;
            this.logBtn.TabStop = true;
            this.logBtn.Text = "LOG";
            this.logBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logBtn_LinkClicked);
            // 
            // navigationBtn
            // 
            this.navigationBtn.BackColor = System.Drawing.Color.Chartreuse;
            this.navigationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationBtn.Location = new System.Drawing.Point(17, 19);
            this.navigationBtn.Name = "navigationBtn";
            this.navigationBtn.Size = new System.Drawing.Size(97, 55);
            this.navigationBtn.TabIndex = 20;
            this.navigationBtn.TabStop = false;
            this.navigationBtn.Text = "Navigation\r\n(CTRL + N)";
            this.navigationBtn.UseVisualStyleBackColor = false;
            this.navigationBtn.Click += new System.EventHandler(this.navigationBtn_Click);
            // 
            // numbersBtn
            // 
            this.numbersBtn.BackColor = System.Drawing.Color.Yellow;
            this.numbersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersBtn.Location = new System.Drawing.Point(411, 19);
            this.numbersBtn.Name = "numbersBtn";
            this.numbersBtn.Size = new System.Drawing.Size(115, 55);
            this.numbersBtn.TabIndex = 21;
            this.numbersBtn.TabStop = false;
            this.numbersBtn.Text = "Numbers\r\n(ALT + N)";
            this.numbersBtn.UseVisualStyleBackColor = false;
            this.numbersBtn.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // colorsBrn
            // 
            this.colorsBrn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.colorsBrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorsBrn.ForeColor = System.Drawing.Color.Transparent;
            this.colorsBrn.Location = new System.Drawing.Point(161, 19);
            this.colorsBrn.Name = "colorsBrn";
            this.colorsBrn.Size = new System.Drawing.Size(97, 55);
            this.colorsBrn.TabIndex = 22;
            this.colorsBrn.TabStop = false;
            this.colorsBrn.Text = "Colors\r\n(ALT + C)\r\n";
            this.colorsBrn.UseVisualStyleBackColor = false;
            this.colorsBrn.Click += new System.EventHandler(this.colorsBrn_Click);
            // 
            // channelBtn
            // 
            this.channelBtn.Location = new System.Drawing.Point(83, 85);
            this.channelBtn.Name = "channelBtn";
            this.channelBtn.Size = new System.Drawing.Size(97, 45);
            this.channelBtn.TabIndex = 23;
            this.channelBtn.TabStop = false;
            this.channelBtn.Text = "Channel\r";
            this.channelBtn.UseVisualStyleBackColor = true;
            this.channelBtn.Click += new System.EventHandler(this.channelBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 45);
            this.button2.TabIndex = 24;
            this.button2.TabStop = false;
            this.button2.Text = "VCR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // volumeBtn
            // 
            this.volumeBtn.BackColor = System.Drawing.Color.Crimson;
            this.volumeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeBtn.Location = new System.Drawing.Point(285, 19);
            this.volumeBtn.Name = "volumeBtn";
            this.volumeBtn.Size = new System.Drawing.Size(90, 55);
            this.volumeBtn.TabIndex = 25;
            this.volumeBtn.TabStop = false;
            this.volumeBtn.Text = "Volume\r\n(ALT + V)\r\n";
            this.volumeBtn.UseVisualStyleBackColor = false;
            this.volumeBtn.Click += new System.EventHandler(this.volumeBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 501);
            this.tabControl1.TabIndex = 26;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.foldersRTB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(584, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Normal Remote";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.outputFolderTB);
            this.groupBox3.Controls.Add(this.outputFolderBrowseBtn);
            this.groupBox3.Controls.Add(this.GoBtn);
            this.groupBox3.Controls.Add(this.logBtn);
            this.groupBox3.Location = new System.Drawing.Point(6, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 118);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 26);
            this.label13.TabIndex = 36;
            this.label13.Text = "Output Folder\r\n(CTRL + P)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.navigationBtn);
            this.groupBox1.Controls.Add(this.numbersBtn);
            this.groupBox1.Controls.Add(this.colorsBrn);
            this.groupBox1.Controls.Add(this.volumeBtn);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.channelBtn);
            this.groupBox1.Location = new System.Drawing.Point(10, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 142);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buttons";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.fanSpeedGB);
            this.tabPage2.Controls.Add(this.modesGB);
            this.tabPage2.Controls.Add(this.degreesGB);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.acRTB);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AC Remote";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.acGoBtn);
            this.groupBox4.Controls.Add(this.acOutputTB);
            this.groupBox4.Controls.Add(this.acBrowseBtn);
            this.groupBox4.Location = new System.Drawing.Point(7, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(562, 126);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Output Folder";
            // 
            // acGoBtn
            // 
            this.acGoBtn.Location = new System.Drawing.Point(236, 61);
            this.acGoBtn.Name = "acGoBtn";
            this.acGoBtn.Size = new System.Drawing.Size(107, 55);
            this.acGoBtn.TabIndex = 34;
            this.acGoBtn.Text = "Go";
            this.acGoBtn.UseVisualStyleBackColor = true;
            this.acGoBtn.Click += new System.EventHandler(this.acGoBtn_Click);
            // 
            // acOutputTB
            // 
            this.acOutputTB.AllowDrop = true;
            this.acOutputTB.Location = new System.Drawing.Point(97, 25);
            this.acOutputTB.Name = "acOutputTB";
            this.acOutputTB.Size = new System.Drawing.Size(363, 20);
            this.acOutputTB.TabIndex = 36;
            this.acOutputTB.DragDrop += new System.Windows.Forms.DragEventHandler(this.IrCodesPathDropHandler);
            this.acOutputTB.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterHandler);
            // 
            // acBrowseBtn
            // 
            this.acBrowseBtn.Location = new System.Drawing.Point(466, 22);
            this.acBrowseBtn.Name = "acBrowseBtn";
            this.acBrowseBtn.Size = new System.Drawing.Size(79, 25);
            this.acBrowseBtn.TabIndex = 37;
            this.acBrowseBtn.Text = "Browse...";
            this.acBrowseBtn.UseVisualStyleBackColor = true;
            this.acBrowseBtn.Click += new System.EventHandler(this.acBrowseBtn_Click);
            // 
            // fanSpeedGB
            // 
            this.fanSpeedGB.Controls.Add(this.label11);
            this.fanSpeedGB.Controls.Add(this.label9);
            this.fanSpeedGB.Controls.Add(this.label10);
            this.fanSpeedGB.Controls.Add(this.label7);
            this.fanSpeedGB.Controls.Add(this.label8);
            this.fanSpeedGB.Controls.Add(this.label6);
            this.fanSpeedGB.Controls.Add(this.label5);
            this.fanSpeedGB.Controls.Add(this.fanSpeedTB);
            this.fanSpeedGB.Location = new System.Drawing.Point(356, 233);
            this.fanSpeedGB.Name = "fanSpeedGB";
            this.fanSpeedGB.Size = new System.Drawing.Size(213, 103);
            this.fanSpeedGB.TabIndex = 41;
            this.fanSpeedGB.TabStop = false;
            this.fanSpeedGB.Text = "Fan Speed Max";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label11.Location = new System.Drawing.Point(173, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label9.Location = new System.Drawing.Point(149, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label10.Location = new System.Drawing.Point(125, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label7.Location = new System.Drawing.Point(103, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label8.Location = new System.Drawing.Point(79, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label6.Location = new System.Drawing.Point(55, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label5.Location = new System.Drawing.Point(31, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "1";
            // 
            // fanSpeedTB
            // 
            this.fanSpeedTB.LargeChange = 1;
            this.fanSpeedTB.Location = new System.Drawing.Point(24, 29);
            this.fanSpeedTB.Maximum = 7;
            this.fanSpeedTB.Minimum = 1;
            this.fanSpeedTB.Name = "fanSpeedTB";
            this.fanSpeedTB.Size = new System.Drawing.Size(168, 45);
            this.fanSpeedTB.TabIndex = 0;
            this.fanSpeedTB.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.fanSpeedTB.Value = 4;
            // 
            // modesGB
            // 
            this.modesGB.Controls.Add(this.aiCB);
            this.modesGB.Controls.Add(this.windCB);
            this.modesGB.Controls.Add(this.hotCB);
            this.modesGB.Controls.Add(this.coldCB);
            this.modesGB.Location = new System.Drawing.Point(7, 270);
            this.modesGB.Name = "modesGB";
            this.modesGB.Size = new System.Drawing.Size(343, 66);
            this.modesGB.TabIndex = 40;
            this.modesGB.TabStop = false;
            this.modesGB.Text = "Modes";
            // 
            // aiCB
            // 
            this.aiCB.AutoSize = true;
            this.aiCB.Location = new System.Drawing.Point(252, 25);
            this.aiCB.Name = "aiCB";
            this.aiCB.Size = new System.Drawing.Size(36, 17);
            this.aiCB.TabIndex = 3;
            this.aiCB.Text = "AI";
            this.aiCB.UseVisualStyleBackColor = true;
            // 
            // windCB
            // 
            this.windCB.AutoSize = true;
            this.windCB.Checked = true;
            this.windCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.windCB.Location = new System.Drawing.Point(184, 25);
            this.windCB.Name = "windCB";
            this.windCB.Size = new System.Drawing.Size(51, 17);
            this.windCB.TabIndex = 2;
            this.windCB.Text = "Wind";
            this.windCB.UseVisualStyleBackColor = true;
            // 
            // hotCB
            // 
            this.hotCB.AutoSize = true;
            this.hotCB.Checked = true;
            this.hotCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hotCB.Location = new System.Drawing.Point(120, 25);
            this.hotCB.Name = "hotCB";
            this.hotCB.Size = new System.Drawing.Size(43, 17);
            this.hotCB.TabIndex = 1;
            this.hotCB.Text = "Hot";
            this.hotCB.UseVisualStyleBackColor = true;
            // 
            // coldCB
            // 
            this.coldCB.AutoSize = true;
            this.coldCB.Checked = true;
            this.coldCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.coldCB.Location = new System.Drawing.Point(51, 25);
            this.coldCB.Name = "coldCB";
            this.coldCB.Size = new System.Drawing.Size(47, 17);
            this.coldCB.TabIndex = 0;
            this.coldCB.Text = "Cold";
            this.coldCB.UseVisualStyleBackColor = true;
            // 
            // degreesGB
            // 
            this.degreesGB.Controls.Add(this.degreeTypeCB);
            this.degreesGB.Controls.Add(this.label4);
            this.degreesGB.Controls.Add(this.maxDegreeDUD);
            this.degreesGB.Controls.Add(this.minDegreeDUD);
            this.degreesGB.Controls.Add(this.label3);
            this.degreesGB.Controls.Add(this.label1);
            this.degreesGB.Location = new System.Drawing.Point(7, 160);
            this.degreesGB.Name = "degreesGB";
            this.degreesGB.Size = new System.Drawing.Size(343, 106);
            this.degreesGB.TabIndex = 39;
            this.degreesGB.TabStop = false;
            this.degreesGB.Text = "Degrees";
            // 
            // degreeTypeCB
            // 
            this.degreeTypeCB.DisplayMember = "C";
            this.degreeTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.degreeTypeCB.FormattingEnabled = true;
            this.degreeTypeCB.Items.AddRange(new object[] {
            "C",
            "F"});
            this.degreeTypeCB.Location = new System.Drawing.Point(255, 51);
            this.degreeTypeCB.Name = "degreeTypeCB";
            this.degreeTypeCB.Size = new System.Drawing.Size(46, 21);
            this.degreeTypeCB.TabIndex = 1;
            this.degreeTypeCB.ValueMember = "C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type";
            // 
            // maxDegreeDUD
            // 
            this.maxDegreeDUD.Items.Add("35");
            this.maxDegreeDUD.Items.Add("34");
            this.maxDegreeDUD.Items.Add("33");
            this.maxDegreeDUD.Items.Add("32");
            this.maxDegreeDUD.Items.Add("31");
            this.maxDegreeDUD.Items.Add("30");
            this.maxDegreeDUD.Items.Add("29");
            this.maxDegreeDUD.Items.Add("28");
            this.maxDegreeDUD.Items.Add("27");
            this.maxDegreeDUD.Items.Add("26");
            this.maxDegreeDUD.Items.Add("25");
            this.maxDegreeDUD.Items.Add("24");
            this.maxDegreeDUD.Items.Add("23");
            this.maxDegreeDUD.Items.Add("22");
            this.maxDegreeDUD.Items.Add("21");
            this.maxDegreeDUD.Items.Add("20");
            this.maxDegreeDUD.Items.Add("19");
            this.maxDegreeDUD.Items.Add("18");
            this.maxDegreeDUD.Items.Add("17");
            this.maxDegreeDUD.Items.Add("16");
            this.maxDegreeDUD.Items.Add("15");
            this.maxDegreeDUD.Items.Add("14");
            this.maxDegreeDUD.Items.Add("13");
            this.maxDegreeDUD.Items.Add("12");
            this.maxDegreeDUD.Items.Add("11");
            this.maxDegreeDUD.Items.Add("10");
            this.maxDegreeDUD.Items.Add("9");
            this.maxDegreeDUD.Items.Add("8");
            this.maxDegreeDUD.Items.Add("7");
            this.maxDegreeDUD.Items.Add("6");
            this.maxDegreeDUD.Items.Add("5");
            this.maxDegreeDUD.Items.Add("4");
            this.maxDegreeDUD.Items.Add("3");
            this.maxDegreeDUD.Items.Add("2");
            this.maxDegreeDUD.Items.Add("1");
            this.maxDegreeDUD.Location = new System.Drawing.Point(141, 70);
            this.maxDegreeDUD.Name = "maxDegreeDUD";
            this.maxDegreeDUD.Size = new System.Drawing.Size(40, 20);
            this.maxDegreeDUD.TabIndex = 3;
            this.maxDegreeDUD.Text = "31";
            // 
            // minDegreeDUD
            // 
            this.minDegreeDUD.Items.Add("35");
            this.minDegreeDUD.Items.Add("34");
            this.minDegreeDUD.Items.Add("33");
            this.minDegreeDUD.Items.Add("32");
            this.minDegreeDUD.Items.Add("31");
            this.minDegreeDUD.Items.Add("30");
            this.minDegreeDUD.Items.Add("29");
            this.minDegreeDUD.Items.Add("28");
            this.minDegreeDUD.Items.Add("27");
            this.minDegreeDUD.Items.Add("26");
            this.minDegreeDUD.Items.Add("25");
            this.minDegreeDUD.Items.Add("24");
            this.minDegreeDUD.Items.Add("23");
            this.minDegreeDUD.Items.Add("22");
            this.minDegreeDUD.Items.Add("21");
            this.minDegreeDUD.Items.Add("20");
            this.minDegreeDUD.Items.Add("19");
            this.minDegreeDUD.Items.Add("18");
            this.minDegreeDUD.Items.Add("17");
            this.minDegreeDUD.Items.Add("16");
            this.minDegreeDUD.Items.Add("15");
            this.minDegreeDUD.Items.Add("14");
            this.minDegreeDUD.Items.Add("13");
            this.minDegreeDUD.Items.Add("12");
            this.minDegreeDUD.Items.Add("11");
            this.minDegreeDUD.Items.Add("10");
            this.minDegreeDUD.Items.Add("9");
            this.minDegreeDUD.Items.Add("8");
            this.minDegreeDUD.Items.Add("7");
            this.minDegreeDUD.Items.Add("6");
            this.minDegreeDUD.Items.Add("5");
            this.minDegreeDUD.Items.Add("4");
            this.minDegreeDUD.Items.Add("3");
            this.minDegreeDUD.Items.Add("2");
            this.minDegreeDUD.Items.Add("1");
            this.minDegreeDUD.Location = new System.Drawing.Point(141, 33);
            this.minDegreeDUD.Name = "minDegreeDUD";
            this.minDegreeDUD.Size = new System.Drawing.Size(40, 20);
            this.minDegreeDUD.TabIndex = 2;
            this.minDegreeDUD.Text = "16";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.swingBtn);
            this.groupBox2.Controls.Add(this.powerBtn);
            this.groupBox2.Controls.Add(this.fanSpeedBtn);
            this.groupBox2.Controls.Add(this.modesBtn);
            this.groupBox2.Controls.Add(this.tempDownBtn);
            this.groupBox2.Controls.Add(this.tempUpBtn);
            this.groupBox2.Location = new System.Drawing.Point(356, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 220);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remote";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // swingBtn
            // 
            this.swingBtn.Location = new System.Drawing.Point(128, 152);
            this.swingBtn.Name = "swingBtn";
            this.swingBtn.Size = new System.Drawing.Size(45, 30);
            this.swingBtn.TabIndex = 21;
            this.swingBtn.Text = "Swing";
            this.swingBtn.UseVisualStyleBackColor = true;
            this.swingBtn.Click += new System.EventHandler(this.swingBtn_Click);
            // 
            // powerBtn
            // 
            this.powerBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.powerBtn.BackColor = System.Drawing.Color.Red;
            this.powerBtn.Location = new System.Drawing.Point(17, 19);
            this.powerBtn.Name = "powerBtn";
            this.powerBtn.Size = new System.Drawing.Size(75, 45);
            this.powerBtn.TabIndex = 25;
            this.powerBtn.Text = "Power";
            this.powerBtn.UseVisualStyleBackColor = false;
            this.powerBtn.Click += new System.EventHandler(this.powerBtn_Click);
            // 
            // fanSpeedBtn
            // 
            this.fanSpeedBtn.Location = new System.Drawing.Point(17, 144);
            this.fanSpeedBtn.Name = "fanSpeedBtn";
            this.fanSpeedBtn.Size = new System.Drawing.Size(75, 47);
            this.fanSpeedBtn.TabIndex = 24;
            this.fanSpeedBtn.Text = "Fan Speed";
            this.fanSpeedBtn.UseVisualStyleBackColor = true;
            this.fanSpeedBtn.Click += new System.EventHandler(this.fanSpeedBtn_Click);
            // 
            // modesBtn
            // 
            this.modesBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.modesBtn.ForeColor = System.Drawing.Color.Transparent;
            this.modesBtn.Location = new System.Drawing.Point(123, 49);
            this.modesBtn.Name = "modesBtn";
            this.modesBtn.Size = new System.Drawing.Size(63, 37);
            this.modesBtn.TabIndex = 22;
            this.modesBtn.Text = "Mode";
            this.modesBtn.UseVisualStyleBackColor = false;
            this.modesBtn.Click += new System.EventHandler(this.modesBtn_Click);
            // 
            // tempDownBtn
            // 
            this.tempDownBtn.Location = new System.Drawing.Point(17, 101);
            this.tempDownBtn.Name = "tempDownBtn";
            this.tempDownBtn.Size = new System.Drawing.Size(75, 32);
            this.tempDownBtn.TabIndex = 23;
            this.tempDownBtn.Text = "Temp Down";
            this.tempDownBtn.UseVisualStyleBackColor = true;
            this.tempDownBtn.Click += new System.EventHandler(this.tempDownBtn_Click);
            // 
            // tempUpBtn
            // 
            this.tempUpBtn.Location = new System.Drawing.Point(117, 102);
            this.tempUpBtn.Name = "tempUpBtn";
            this.tempUpBtn.Size = new System.Drawing.Size(75, 32);
            this.tempUpBtn.TabIndex = 20;
            this.tempUpBtn.Text = "Temp Up";
            this.tempUpBtn.UseVisualStyleBackColor = true;
            this.tempUpBtn.Click += new System.EventHandler(this.tempUpBtn_Click);
            // 
            // acRTB
            // 
            this.acRTB.AllowDrop = true;
            this.acRTB.EnableAutoDragDrop = true;
            this.acRTB.Font = new System.Drawing.Font("Consolas", 9F);
            this.acRTB.Location = new System.Drawing.Point(7, 6);
            this.acRTB.Name = "acRTB";
            this.acRTB.Size = new System.Drawing.Size(343, 148);
            this.acRTB.TabIndex = 33;
            this.acRTB.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 503);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Config Maker";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.fanSpeedGB.ResumeLayout(false);
            this.fanSpeedGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fanSpeedTB)).EndInit();
            this.modesGB.ResumeLayout(false);
            this.modesGB.PerformLayout();
            this.degreesGB.ResumeLayout(false);
            this.degreesGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox foldersRTB;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.Button outputFolderBrowseBtn;
        private System.Windows.Forms.TextBox outputFolderTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog irCodesFileDialog;
        private System.Windows.Forms.FolderBrowserDialog outputFolderDialog;
        private System.Windows.Forms.LinkLabel logBtn;
        private System.Windows.Forms.Button navigationBtn;
        private System.Windows.Forms.Button numbersBtn;
        private System.Windows.Forms.Button colorsBrn;
        private System.Windows.Forms.Button channelBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button volumeBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox fanSpeedGB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar fanSpeedTB;
        private System.Windows.Forms.GroupBox modesGB;
        private System.Windows.Forms.CheckBox aiCB;
        private System.Windows.Forms.CheckBox windCB;
        private System.Windows.Forms.CheckBox hotCB;
        private System.Windows.Forms.CheckBox coldCB;
        private System.Windows.Forms.GroupBox degreesGB;
        public System.Windows.Forms.ComboBox degreeTypeCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown maxDegreeDUD;
        private System.Windows.Forms.DomainUpDown minDegreeDUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button swingBtn;
        private System.Windows.Forms.Button powerBtn;
        private System.Windows.Forms.Button fanSpeedBtn;
        private System.Windows.Forms.Button modesBtn;
        private System.Windows.Forms.Button tempDownBtn;
        private System.Windows.Forms.Button tempUpBtn;
        private System.Windows.Forms.Button acBrowseBtn;
        private System.Windows.Forms.TextBox acOutputTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button acGoBtn;
        private System.Windows.Forms.RichTextBox acRTB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FolderBrowserDialog acOutputFolderDialog;
    }
}

