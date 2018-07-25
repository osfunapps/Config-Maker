using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.project;

namespace Config_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PrepareFirstLaunch();
        }

        private void PrepareFirstLaunch()
        {
            outputFolderTB.BackColor = Color.Red;
            this.logBtn.TabStop = false;
        }

        private void foldersRTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void outputFolderTB_TextChanged(object sender, EventArgs e)
        {
            outputFolderTB.BackColor = Color.White;

        }

        private void outputFolderBrowseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = outputFolderDialog.ShowDialog();
            if (result == DialogResult.OK && outputFolderDialog.SelectedPath.Length > 0)
            {
                outputFolderTB.Text = outputFolderDialog.SelectedPath;
            }
        }


        private void GoBtn_Click(object sender, EventArgs e)
        {
            XmlFileWriter xmlFileWriter = new XmlFileWriter(outputFolderTB.Text, foldersRTB.Text);
            xmlFileWriter.WriteXml();
            Thread.Sleep(500);
            outputFolderTB.BackColor = Color.Red;
        }


        private void DragEnterHandler(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void IrCodesPathDropHandler(object sender, DragEventArgs e)
        {
            outputFolderTB.Text = TitleExporter(((string[])e.Data.GetData(DataFormats.FileDrop, false))[0], false);
        }

        private string TitleExporter(string fileLongStr, bool onlyFileName)
        {
            if (onlyFileName) return fileLongStr.ToString().Substring(fileLongStr.ToString().LastIndexOf("\\") + 1);
            return fileLongStr.ToString().Substring(fileLongStr.ToString().IndexOf("FileName: ") + 1);
        }

        private void outputFolderDialog_HelpRequest(object sender, EventArgs e)
        {
        }



        private void OutputFolderDropHandler(object sender, DragEventArgs e)
        {
            outputFolderTB.Text = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];
        }

        private void logBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(Logger.GetTxt(), Logger.TITLE);
        }



        private void Numbers_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.NUMBERS_TXT);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.VCR_TXT);
        }

        private void navigationBtn_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.NAVIGATION_TXT);

        }

        private void channelBtn_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.CHANNEL_TXT);
        }

        private void colorsBrn_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.COLORS_TXT);
        }

        private void volumeBtn_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.VOLUME_TXT);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Console.WriteLine(keyData);
            switch (keyData)
            {
                case Keys.Alt | Keys.V:
                    foldersRTB.AppendText(TextTemplateHandler.VOLUME_TXT);
                    break;
                case Keys.Alt | Keys.N:
                    foldersRTB.AppendText(TextTemplateHandler.NUMBERS_TXT);
                    break;
                case Keys.Alt | Keys.C:
                    foldersRTB.AppendText(TextTemplateHandler.COLORS_TXT);
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
