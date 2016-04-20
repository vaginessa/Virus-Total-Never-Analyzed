namespace Virus_Total_Never_Analyzed
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabelVirustotal = new System.Windows.Forms.LinkLabel();
            this.labelDateOfAnalysisResult = new System.Windows.Forms.Label();
            this.labelDateOfAnalysis = new System.Windows.Forms.Label();
            this.labelDetectionRatioResult = new System.Windows.Forms.Label();
            this.labelDetectionratio = new System.Windows.Forms.Label();
            this.labelSHA256Result = new System.Windows.Forms.Label();
            this.labelSHA256 = new System.Windows.Forms.Label();
            this.labelLink = new System.Windows.Forms.Label();
            this.labelMessageResult = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonsScan = new System.Windows.Forms.Button();
            this.buttonBrowseVirusTotal = new System.Windows.Forms.Button();
            this.listViewVirusTotal = new System.Windows.Forms.ListView();
            this.columnHeaderAntiVirus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDetected = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxVirusTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabelVirustotal
            // 
            this.linkLabelVirustotal.AutoSize = true;
            this.linkLabelVirustotal.Location = new System.Drawing.Point(93, 93);
            this.linkLabelVirustotal.Name = "linkLabelVirustotal";
            this.linkLabelVirustotal.Size = new System.Drawing.Size(0, 13);
            this.linkLabelVirustotal.TabIndex = 58;
            this.linkLabelVirustotal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelVirustotal_LinkClicked);
            // 
            // labelDateOfAnalysisResult
            // 
            this.labelDateOfAnalysisResult.AutoSize = true;
            this.labelDateOfAnalysisResult.Location = new System.Drawing.Point(93, 63);
            this.labelDateOfAnalysisResult.Name = "labelDateOfAnalysisResult";
            this.labelDateOfAnalysisResult.Size = new System.Drawing.Size(0, 13);
            this.labelDateOfAnalysisResult.TabIndex = 57;
            // 
            // labelDateOfAnalysis
            // 
            this.labelDateOfAnalysis.AutoSize = true;
            this.labelDateOfAnalysis.Location = new System.Drawing.Point(5, 63);
            this.labelDateOfAnalysis.Name = "labelDateOfAnalysis";
            this.labelDateOfAnalysis.Size = new System.Drawing.Size(82, 13);
            this.labelDateOfAnalysis.TabIndex = 56;
            this.labelDateOfAnalysis.Text = "Date of analysis";
            // 
            // labelDetectionRatioResult
            // 
            this.labelDetectionRatioResult.AutoSize = true;
            this.labelDetectionRatioResult.Location = new System.Drawing.Point(93, 50);
            this.labelDetectionRatioResult.Name = "labelDetectionRatioResult";
            this.labelDetectionRatioResult.Size = new System.Drawing.Size(0, 13);
            this.labelDetectionRatioResult.TabIndex = 55;
            // 
            // labelDetectionratio
            // 
            this.labelDetectionratio.AutoSize = true;
            this.labelDetectionratio.Location = new System.Drawing.Point(5, 50);
            this.labelDetectionratio.Name = "labelDetectionratio";
            this.labelDetectionratio.Size = new System.Drawing.Size(76, 13);
            this.labelDetectionratio.TabIndex = 54;
            this.labelDetectionratio.Text = "Detection ratio";
            // 
            // labelSHA256Result
            // 
            this.labelSHA256Result.AutoSize = true;
            this.labelSHA256Result.Location = new System.Drawing.Point(93, 37);
            this.labelSHA256Result.Name = "labelSHA256Result";
            this.labelSHA256Result.Size = new System.Drawing.Size(0, 13);
            this.labelSHA256Result.TabIndex = 53;
            // 
            // labelSHA256
            // 
            this.labelSHA256.AutoSize = true;
            this.labelSHA256.Location = new System.Drawing.Point(6, 37);
            this.labelSHA256.Name = "labelSHA256";
            this.labelSHA256.Size = new System.Drawing.Size(47, 13);
            this.labelSHA256.TabIndex = 52;
            this.labelSHA256.Text = "SHA256";
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(5, 89);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(30, 13);
            this.labelLink.TabIndex = 51;
            this.labelLink.Text = "Link ";
            // 
            // labelMessageResult
            // 
            this.labelMessageResult.AutoSize = true;
            this.labelMessageResult.Location = new System.Drawing.Point(93, 76);
            this.labelMessageResult.Name = "labelMessageResult";
            this.labelMessageResult.Size = new System.Drawing.Size(0, 13);
            this.labelMessageResult.TabIndex = 50;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(5, 76);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 13);
            this.labelMessage.TabIndex = 49;
            this.labelMessage.Text = "Message";
            // 
            // buttonsScan
            // 
            this.buttonsScan.Location = new System.Drawing.Point(429, 3);
            this.buttonsScan.Name = "buttonsScan";
            this.buttonsScan.Size = new System.Drawing.Size(75, 23);
            this.buttonsScan.TabIndex = 48;
            this.buttonsScan.Text = " Scan";
            this.buttonsScan.UseVisualStyleBackColor = true;
            this.buttonsScan.Click += new System.EventHandler(this.buttonsScan_Click);
            // 
            // buttonBrowseVirusTotal
            // 
            this.buttonBrowseVirusTotal.Location = new System.Drawing.Point(327, 3);
            this.buttonBrowseVirusTotal.Name = "buttonBrowseVirusTotal";
            this.buttonBrowseVirusTotal.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseVirusTotal.TabIndex = 47;
            this.buttonBrowseVirusTotal.Text = "Browse ";
            this.buttonBrowseVirusTotal.UseVisualStyleBackColor = true;
            this.buttonBrowseVirusTotal.Click += new System.EventHandler(this.buttonBrowseVirusTotal_Click);
            // 
            // listViewVirusTotal
            // 
            this.listViewVirusTotal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAntiVirus,
            this.columnHeaderDetected});
            this.listViewVirusTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewVirusTotal.FullRowSelect = true;
            this.listViewVirusTotal.GridLines = true;
            this.listViewVirusTotal.Location = new System.Drawing.Point(0, 120);
            this.listViewVirusTotal.Name = "listViewVirusTotal";
            this.listViewVirusTotal.Size = new System.Drawing.Size(515, 311);
            this.listViewVirusTotal.TabIndex = 45;
            this.listViewVirusTotal.UseCompatibleStateImageBehavior = false;
            this.listViewVirusTotal.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderAntiVirus
            // 
            this.columnHeaderAntiVirus.Text = "Anti-virus";
            this.columnHeaderAntiVirus.Width = 142;
            // 
            // columnHeaderDetected
            // 
            this.columnHeaderDetected.Text = "Detected";
            this.columnHeaderDetected.Width = 361;
            // 
            // textBoxVirusTotal
            // 
            this.textBoxVirusTotal.AllowDrop = true;
            this.textBoxVirusTotal.Location = new System.Drawing.Point(6, 5);
            this.textBoxVirusTotal.Name = "textBoxVirusTotal";
            this.textBoxVirusTotal.Size = new System.Drawing.Size(295, 20);
            this.textBoxVirusTotal.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(515, 431);
            this.Controls.Add(this.linkLabelVirustotal);
            this.Controls.Add(this.labelDateOfAnalysisResult);
            this.Controls.Add(this.labelDateOfAnalysis);
            this.Controls.Add(this.labelDetectionRatioResult);
            this.Controls.Add(this.labelDetectionratio);
            this.Controls.Add(this.labelSHA256Result);
            this.Controls.Add(this.labelSHA256);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.labelMessageResult);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonsScan);
            this.Controls.Add(this.buttonBrowseVirusTotal);
            this.Controls.Add(this.listViewVirusTotal);
            this.Controls.Add(this.textBoxVirusTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Virus Total Never Analyzed by Teeknofil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelVirustotal;
        private System.Windows.Forms.Label labelDateOfAnalysisResult;
        private System.Windows.Forms.Label labelDateOfAnalysis;
        private System.Windows.Forms.Label labelDetectionRatioResult;
        private System.Windows.Forms.Label labelDetectionratio;
        private System.Windows.Forms.Label labelSHA256Result;
        private System.Windows.Forms.Label labelSHA256;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.Label labelMessageResult;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonsScan;
        private System.Windows.Forms.Button buttonBrowseVirusTotal;
        private System.Windows.Forms.ListView listViewVirusTotal;
        private System.Windows.Forms.ColumnHeader columnHeaderAntiVirus;
        private System.Windows.Forms.ColumnHeader columnHeaderDetected;
        private System.Windows.Forms.TextBox textBoxVirusTotal;
    }
}

