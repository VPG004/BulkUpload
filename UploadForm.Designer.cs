
namespace BulkUpload
{
    partial class UploadForm
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Excel file format should be .xlsx");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Raw data file- Sheet name must be “Sheet1”.");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Don\'t insert blank row between data");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("While uploading excel file in Tool please delete all formula of excel sheet.");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Only insert raw data. Calculation part done by programmatically.");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("For Every upload of new data the old data should be deleted.");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAPMID = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnShow = new System.Windows.Forms.Button();
            this.grdDownload = new System.Windows.Forms.DataGridView();
            this.btnDownload = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPullReport = new System.Windows.Forms.Button();
            this.grdHistory = new System.Windows.Forms.DataGridView();
            this.btnHistory = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDownload)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Controls.Add(this.btnBrowseFile);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(51, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Upload :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(263, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Upload Status";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(826, 51);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(110, 37);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import File";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(700, 51);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(110, 37);
            this.btnBrowseFile.TabIndex = 2;
            this.btnBrowseFile.Text = "Browse...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(103, 56);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(587, 26);
            this.txtFilePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path :";
            // 
            // lblAPMID
            // 
            this.lblAPMID.AutoSize = true;
            this.lblAPMID.Location = new System.Drawing.Point(990, 8);
            this.lblAPMID.Name = "lblAPMID";
            this.lblAPMID.Size = new System.Drawing.Size(60, 20);
            this.lblAPMID.TabIndex = 1;
            this.lblAPMID.Text = "APMID";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(51, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1014, 238);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Some Limitation of excel file are as follow -";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(22, 44);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Excel file format should be .xlsx";
            treeNode8.Name = "Node1";
            treeNode8.Text = "Raw data file- Sheet name must be “Sheet1”.";
            treeNode9.Name = "Node2";
            treeNode9.Text = "Don\'t insert blank row between data";
            treeNode10.Name = "Node3";
            treeNode10.Text = "While uploading excel file in Tool please delete all formula of excel sheet.";
            treeNode11.Name = "Node4";
            treeNode11.Text = "Only insert raw data. Calculation part done by programmatically.";
            treeNode12.Name = "Node6";
            treeNode12.Text = "For Every upload of new data the old data should be deleted.";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(679, 153);
            this.treeView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 578);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblAPMID);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1264, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Upload File";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDownload);
            this.tabPage2.Controls.Add(this.grdDownload);
            this.tabPage2.Controls.Add(this.btnShow);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1264, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Download Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(74, 14);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(292, 55);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show Rate Sheet Expiry Data";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // grdDownload
            // 
            this.grdDownload.AllowUserToAddRows = false;
            this.grdDownload.AllowUserToDeleteRows = false;
            this.grdDownload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDownload.Location = new System.Drawing.Point(20, 85);
            this.grdDownload.Name = "grdDownload";
            this.grdDownload.RowHeadersWidth = 62;
            this.grdDownload.RowTemplate.Height = 28;
            this.grdDownload.Size = new System.Drawing.Size(1218, 454);
            this.grdDownload.TabIndex = 1;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(487, 14);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(292, 55);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Export into Excel";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnPullReport);
            this.tabPage3.Controls.Add(this.grdHistory);
            this.tabPage3.Controls.Add(this.btnHistory);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1264, 545);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Upload History";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnPullReport
            // 
            this.btnPullReport.Location = new System.Drawing.Point(490, 10);
            this.btnPullReport.Name = "btnPullReport";
            this.btnPullReport.Size = new System.Drawing.Size(292, 55);
            this.btnPullReport.TabIndex = 5;
            this.btnPullReport.Text = "Export Into Excel";
            this.btnPullReport.UseVisualStyleBackColor = true;
            this.btnPullReport.Click += new System.EventHandler(this.btnPullReport_Click);
            // 
            // grdHistory
            // 
            this.grdHistory.AllowUserToAddRows = false;
            this.grdHistory.AllowUserToDeleteRows = false;
            this.grdHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistory.Location = new System.Drawing.Point(23, 81);
            this.grdHistory.Name = "grdHistory";
            this.grdHistory.RowHeadersWidth = 62;
            this.grdHistory.RowTemplate.Height = 28;
            this.grdHistory.Size = new System.Drawing.Size(1218, 454);
            this.grdHistory.TabIndex = 4;
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(77, 10);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(292, 55);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "Show Upload History Data";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 596);
            this.Controls.Add(this.tabControl1);
            this.Name = "UploadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Rate Sheet Expiry Date Data";
            this.Load += new System.EventHandler(this.UploadForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDownload)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAPMID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.DataGridView grdDownload;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnPullReport;
        private System.Windows.Forms.DataGridView grdHistory;
        private System.Windows.Forms.Button btnHistory;
    }
}