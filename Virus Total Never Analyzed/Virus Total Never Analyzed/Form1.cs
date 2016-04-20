using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Virus_Total_Never_Analyzed.Objects;
using System.IO;


namespace Virus_Total_Never_Analyzed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowseVirusTotal_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();

            Open.Filter = "File |*.*";

            Open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (Open.ShowDialog() == DialogResult.OK)
                textBoxVirusTotal.Text = Open.FileName;
                       
        }

        private void buttonsScan_Click(object sender, EventArgs e)
        {
            try
            {
                VirusTotals virusTotal = new VirusTotals("501caf66349cc7357eb4398ac3298fdd03dec01a3e2f3ad576525aa7b57a1987");
                virusTotal.UseTLS = true;
                
                labelMessageResult.Text = "Please wait";
                labelMessageResult.Text = null;
                linkLabelVirustotal.Text = null;
                labelSHA256Result.Text = null;
                labelDetectionRatioResult.Text = null;
                labelDateOfAnalysisResult.Text = null;

                FileInfo fileInfo = new FileInfo(textBoxVirusTotal.Text);

                //Check if the file has been scanned before.
                FileReport fileResult = virusTotal.GetFileReport(fileInfo);
                bool hasFileBeenScannedBefore = fileResult.ResponseCode == ReportResponseCode.Present;


                if (hasFileBeenScannedBefore)
                {
                    PrintScan(fileResult);
                }
                else
                {
                    PrintScan(fileResult, false); ;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }


        public void PrintScan(FileReport fileReport)
        {
            
            labelMessageResult.Text = fileReport.VerboseMsg;
            linkLabelVirustotal.Text = fileReport.Permalink;
            labelSHA256Result.Text = fileReport.SHA256;
            labelDetectionRatioResult.Text = fileReport.Positives.ToString() + " / " + fileReport.Total.ToString();
            labelDateOfAnalysisResult.Text = fileReport.ScanDate.ToString();

            if (fileReport.ResponseCode == ReportResponseCode.Present)
            {
                listViewVirusTotal.Items.Clear();
                foreach (KeyValuePair<string, ScanEngine> scan in fileReport.Scans)
                {
                    ListViewItem listViewVirusTotalItem = new ListViewItem(scan.Key);
                    listViewVirusTotalItem.SubItems.Add(scan.Value.Detected.ToString());
                    listViewVirusTotal.Items.Add(listViewVirusTotalItem);
                }
            }

        }

        private void PrintScan(FileReport fileReport, bool scanResult)
        {
            labelMessageResult.Text = "The file has never been scanned before";
            listViewVirusTotal.Items.Clear();
            
        }

        private void linkLabelVirustotal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabelVirustotal.Text);
        }

        
    }
}
