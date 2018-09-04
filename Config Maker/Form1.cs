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
using Config_Maker.project.ac;

namespace Config_Maker
{
    public partial class Form1 : Form
    {
        private string FILE_MADE = "File Made!";
        private string WINDOW_INFO = "Information";

        public static char HOT = 'H', COLD = 'C', WIND = 'W', AI = 'A';
        private string REMOTE_TYPE_AC = "ac";
        private string REMOTE_TYPE_NORMAL = "normal";


        public Form1()
        {
            InitializeComponent();
            PrepareFirstLaunch();
        }

        private void PrepareFirstLaunch()
        {
            outputFolderTB.BackColor = Color.Red;
            this.logBtn.TabStop = false;
            degreeTypeCB.SelectedIndex = 0;
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
            XmlFileWriter xmlFileWriter = new XmlFileWriter(outputFolderTB.Text, foldersRTB.Text, REMOTE_TYPE_NORMAL);
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
            var senderTB = (TextBox)sender;
            if (senderTB.Name == "acOutputTB")
            {
                acOutputTB.Text = TitleExporter(((string[])e.Data.GetData(DataFormats.FileDrop, false))[0], false);
            }
            else
            {
                outputFolderTB.Text = TitleExporter(((string[])e.Data.GetData(DataFormats.FileDrop, false))[0], false);
            }
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
            foldersRTB.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.VCR_TXT);
            foldersRTB.Focus();
        }

        private void navigationBtn_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.NAVIGATION_TXT);
            foldersRTB.Focus();

        }

        private void channelBtn_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.CHANNEL_TXT);
            foldersRTB.Focus();
        }

        private void colorsBrn_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.COLORS_TXT);
            foldersRTB.Focus();
        }

        private void volumeBtn_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.VOLUME_TXT);
            foldersRTB.Focus();
        }

        private void acGoBtn_Click(object sender, EventArgs e)
        {
            ACXmlFileWriter xmlFileWriter = new ACXmlFileWriter(acOutputTB.Text, acRTB.Text, minDegreeDUD.Text, maxDegreeDUD.Text, GetModesList(), fanSpeedTB.Value, degreeTypeCB.Text, aiCB.Checked, REMOTE_TYPE_AC);
            xmlFileWriter.WriteXml();
            MessageBox.Show(FILE_MADE, WINDOW_INFO);
        }

        private List<char> GetModesList()
        {
            List<char> modesList = new List<char>();

            if (coldCB.Checked)
                modesList.Add(COLD);

            if (hotCB.Checked)
                modesList.Add(HOT);

            if (windCB.Checked)
                modesList.Add(WIND);

            if (aiCB.Checked)
                modesList.Add(AI);
            return modesList;
        }

        private void acBrowseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = acOutputFolderDialog.ShowDialog();
            if (result == DialogResult.OK && acOutputFolderDialog.SelectedPath.Length > 0)
                acOutputTB.Text = acOutputFolderDialog.SelectedPath;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Console.WriteLine(keyData);
            switch (keyData)
            {
                case Keys.Alt | Keys.V:
                    foldersRTB.AppendText(TextTemplateHandler.VOLUME_TXT);
                    break;

                case Keys.Control | Keys.G:
                    GoBtn.PerformClick();
                    return true;

                case Keys.Control | Keys.P:
                    outputFolderTB.Focus();
                    return true;

                case Keys.Control | Keys.N:
                    foldersRTB.AppendText(TextTemplateHandler.NAVIGATION_TXT);
                    break;
                case Keys.Alt | Keys.N:
                    foldersRTB.AppendText(TextTemplateHandler.NUMBERS_TXT);
                    break;
                case Keys.Alt | Keys.C:
                    foldersRTB.AppendText(TextTemplateHandler.COLORS_TXT);
                    break;

                case Keys.Control | Keys.T:
                    foldersRTB.Focus();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void swingBtn_Click(object sender, EventArgs e)
        {
            acRTB.AppendText(TextTemplateHandler.SWING_TXT);
        }

        private void fanSpeedBtn_Click(object sender, EventArgs e)
        {
            acRTB.AppendText(TextTemplateHandler.FAN_SPEED_TXT);
        }

        private void tempUpBtn_Click(object sender, EventArgs e)
        {
            acRTB.AppendText(TextTemplateHandler.TEMP_UP_TXT);
        }

        private void tempDownBtn_Click(object sender, EventArgs e)
        {
            acRTB.AppendText(TextTemplateHandler.TEMP_DOWN_TXT);
        }

        private void modesBtn_Click(object sender, EventArgs e)
        {
            acRTB.AppendText(TextTemplateHandler.MODE_TXT);
        }

        private void powerBtn_Click(object sender, EventArgs e)
        {
            acRTB.AppendText(TextTemplateHandler.POWER_2_TXT);
            acRTB.AppendText(TextTemplateHandler.POWER_1_TXT);
        }
    }
}
