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
            this.SuspendLayout();
            // 
            // foldersRTB
            // 
            this.foldersRTB.AllowDrop = true;
            this.foldersRTB.EnableAutoDragDrop = true;
            this.foldersRTB.Font = new System.Drawing.Font("Consolas", 13F);
            this.foldersRTB.Location = new System.Drawing.Point(12, 12);
            this.foldersRTB.Name = "foldersRTB";
            this.foldersRTB.Size = new System.Drawing.Size(382, 230);
            this.foldersRTB.TabIndex = 1;
            this.foldersRTB.Text = "";
            this.foldersRTB.TextChanged += new System.EventHandler(this.foldersRTB_TextChanged);
            // 
            // GoBtn
            // 
            this.GoBtn.Location = new System.Drawing.Point(159, 287);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(75, 24);
            this.GoBtn.TabIndex = 7;
            this.GoBtn.Text = "Go";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // outputFolderBrowseBtn
            // 
            this.outputFolderBrowseBtn.Location = new System.Drawing.Point(313, 248);
            this.outputFolderBrowseBtn.Name = "outputFolderBrowseBtn";
            this.outputFolderBrowseBtn.Size = new System.Drawing.Size(81, 24);
            this.outputFolderBrowseBtn.TabIndex = 12;
            this.outputFolderBrowseBtn.Text = "Browse...";
            this.outputFolderBrowseBtn.UseVisualStyleBackColor = true;
            this.outputFolderBrowseBtn.Click += new System.EventHandler(this.outputFolderBrowseBtn_Click);
            // 
            // outputFolderTB
            // 
            this.outputFolderTB.AllowDrop = true;
            this.outputFolderTB.Location = new System.Drawing.Point(95, 250);
            this.outputFolderTB.Name = "outputFolderTB";
            this.outputFolderTB.Size = new System.Drawing.Size(212, 20);
            this.outputFolderTB.TabIndex = 11;
            this.outputFolderTB.TextChanged += new System.EventHandler(this.outputFolderTB_TextChanged);
            this.outputFolderTB.DragDrop += new System.Windows.Forms.DragEventHandler(this.IrCodesPathDropHandler);
            this.outputFolderTB.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterHandler);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 253);
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
            this.logBtn.Location = new System.Drawing.Point(525, 297);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(29, 13);
            this.logBtn.TabIndex = 19;
            this.logBtn.TabStop = true;
            this.logBtn.Text = "LOG";
            this.logBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logBtn_LinkClicked);
            // 
            // navigationBtn
            // 
            this.navigationBtn.Location = new System.Drawing.Point(400, 16);
            this.navigationBtn.Name = "navigationBtn";
            this.navigationBtn.Size = new System.Drawing.Size(75, 23);
            this.navigationBtn.TabIndex = 20;
            this.navigationBtn.Text = "Navigation";
            this.navigationBtn.UseVisualStyleBackColor = true;
            this.navigationBtn.Click += new System.EventHandler(this.navigationBtn_Click);
            // 
            // numbersBtn
            // 
            this.numbersBtn.Location = new System.Drawing.Point(443, 137);
            this.numbersBtn.Name = "numbersBtn";
            this.numbersBtn.Size = new System.Drawing.Size(75, 23);
            this.numbersBtn.TabIndex = 21;
            this.numbersBtn.Text = "Numbers";
            this.numbersBtn.UseVisualStyleBackColor = true;
            this.numbersBtn.Click += new System.EventHandler(this.Numbers_Click);
            // 
            // colorsBrn
            // 
            this.colorsBrn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.colorsBrn.ForeColor = System.Drawing.Color.Transparent;
            this.colorsBrn.Location = new System.Drawing.Point(443, 55);
            this.colorsBrn.Name = "colorsBrn";
            this.colorsBrn.Size = new System.Drawing.Size(75, 23);
            this.colorsBrn.TabIndex = 22;
            this.colorsBrn.Text = "Colors";
            this.colorsBrn.UseVisualStyleBackColor = false;
            this.colorsBrn.Click += new System.EventHandler(this.colorsBrn_Click);
            // 
            // channelBtn
            // 
            this.channelBtn.Location = new System.Drawing.Point(481, 16);
            this.channelBtn.Name = "channelBtn";
            this.channelBtn.Size = new System.Drawing.Size(75, 23);
            this.channelBtn.TabIndex = 23;
            this.channelBtn.Text = "Channel";
            this.channelBtn.UseVisualStyleBackColor = true;
            this.channelBtn.Click += new System.EventHandler(this.channelBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "VCR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // volumeBtn
            // 
            this.volumeBtn.Location = new System.Drawing.Point(443, 175);
            this.volumeBtn.Name = "volumeBtn";
            this.volumeBtn.Size = new System.Drawing.Size(75, 23);
            this.volumeBtn.TabIndex = 25;
            this.volumeBtn.Text = "Volume";
            this.volumeBtn.UseVisualStyleBackColor = true;
            this.volumeBtn.Click += new System.EventHandler(this.volumeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 326);
            this.Controls.Add(this.volumeBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.channelBtn);
            this.Controls.Add(this.colorsBrn);
            this.Controls.Add(this.numbersBtn);
            this.Controls.Add(this.navigationBtn);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.outputFolderBrowseBtn);
            this.Controls.Add(this.outputFolderTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GoBtn);
            this.Controls.Add(this.foldersRTB);
            this.Name = "Form1";
            this.Text = "Config Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

