namespace FileTracker
{
    partial class FileWatcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileWatcher));
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnWatch = new System.Windows.Forms.Button();
            this.lstNotification = new System.Windows.Forms.ListBox();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.tmrEditNotify = new System.Windows.Forms.Timer(this.components);
            this.groupBoxDirectorySelection = new System.Windows.Forms.GroupBox();
            this.cmbStrictFileTypes = new System.Windows.Forms.ComboBox();
            this.lblStrictFileType = new System.Windows.Forms.Label();
            this.chkSubFolder = new System.Windows.Forms.CheckBox();
            this.rdbDirectory = new System.Windows.Forms.RadioButton();
            this.rdbFile = new System.Windows.Forms.RadioButton();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgOpenDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnLog = new System.Windows.Forms.Button();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxDirectorySelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(9, 90);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(268, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Location = new System.Drawing.Point(8, 74);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(133, 13);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "Path for File/Directory";
            // 
            // btnWatch
            // 
            this.btnWatch.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnWatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWatch.Location = new System.Drawing.Point(11, 116);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(145, 27);
            this.btnWatch.TabIndex = 4;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = false;
            this.btnWatch.Click += new System.EventHandler(this.btnWatchFile_Click);
            // 
            // lstNotification
            // 
            this.lstNotification.FormattingEnabled = true;
            this.lstNotification.Location = new System.Drawing.Point(9, 176);
            this.lstNotification.Name = "lstNotification";
            this.lstNotification.Size = new System.Drawing.Size(463, 238);
            this.lstNotification.TabIndex = 5;
            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifications.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNotifications.Location = new System.Drawing.Point(8, 160);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(302, 13);
            this.lblNotifications.TabIndex = 6;
            this.lblNotifications.Text = "All Notifications from Watched File/Directory";
            // 
            // tmrEditNotify
            // 
            this.tmrEditNotify.Enabled = true;
            this.tmrEditNotify.Tick += new System.EventHandler(this.tmrEditNotify_Tick);
            // 
            // groupBoxDirectorySelection
            // 
            this.groupBoxDirectorySelection.Controls.Add(this.cmbStrictFileTypes);
            this.groupBoxDirectorySelection.Controls.Add(this.lblStrictFileType);
            this.groupBoxDirectorySelection.Controls.Add(this.chkSubFolder);
            this.groupBoxDirectorySelection.Controls.Add(this.rdbDirectory);
            this.groupBoxDirectorySelection.Controls.Add(this.rdbFile);
            this.groupBoxDirectorySelection.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDirectorySelection.Location = new System.Drawing.Point(9, 3);
            this.groupBoxDirectorySelection.Name = "groupBoxDirectorySelection";
            this.groupBoxDirectorySelection.Size = new System.Drawing.Size(457, 68);
            this.groupBoxDirectorySelection.TabIndex = 7;
            this.groupBoxDirectorySelection.TabStop = false;
            this.groupBoxDirectorySelection.Text = "Choose Directory/File";
            // 
            // cmbStrictFileTypes
            // 
            this.cmbStrictFileTypes.Enabled = false;
            this.cmbStrictFileTypes.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStrictFileTypes.FormattingEnabled = true;
            this.cmbStrictFileTypes.Items.AddRange(new object[] {
            ".*",
            ".docx",
            ".doc",
            ".odt",
            ".pdf ",
            ".rtf",
            ".tex",
            ".txt",
            ".wps",
            ".wks",
            ".wpd",
            ".wmv",
            ".vob",
            ".swf",
            ".rm",
            ".mpeg",
            ".mpg",
            ".mp4",
            ".mov",
            ".mkv",
            ".m4v ",
            ".h264",
            ".flv",
            ".avi",
            ".3gp",
            ".3g2",
            ".xlsx",
            ".xls",
            ".xlr",
            ".ods",
            ".swift",
            ".sh",
            ".java",
            ".cs",
            ".h",
            ".cpp",
            ".class",
            ".c",
            ".vb",
            ".pptx",
            ".ppt",
            ".pps",
            ".odp",
            ".key ",
            ".xhtml",
            ".rss",
            ".php",
            ".part",
            ".jsp",
            ".js",
            ".html",
            ".htm",
            ".css",
            ".cfm",
            ".cer",
            ".aspx",
            ".asp",
            ".png",
            ".jpeg",
            ".jpg",
            ".tif ",
            ".svg",
            ".ai",
            ".bmp",
            ".gif",
            ".ico",
            ".psd",
            ".ps",
            ".ttf",
            ".otf",
            ".fon",
            ".fnt",
            ".wsf",
            ".py",
            ".jar",
            ".gadget",
            ".exe",
            ".com",
            ".pl ",
            ".cgi ",
            ".bin",
            ".bat ",
            ".apk",
            ".xml",
            ".tar",
            ".sql",
            ".sav",
            ".mdb",
            ".log",
            ".dbf",
            ".db",
            ".dat",
            ".csv",
            ".vcd",
            ".bin",
            ".dmg",
            ".iso",
            ".toast",
            ".zip",
            ".deb",
            ".pkg",
            ".rar",
            ".rpm",
            ".z",
            ".tar",
            ".arj",
            ".7z",
            ".aif",
            ".cda",
            ".mid ",
            ".midi",
            ".mp3",
            ".mpa",
            ".ogg",
            ".wav",
            ".wma",
            ".wpl",
            ".tmp",
            ".sys ",
            ".msi",
            ".lnk",
            ".ini",
            ".icns",
            ".drv",
            ".dmp",
            ".dll",
            ".cur",
            ".cpl",
            ".cfg",
            ".cab",
            ".bak"});
            this.cmbStrictFileTypes.Location = new System.Drawing.Point(324, 41);
            this.cmbStrictFileTypes.Name = "cmbStrictFileTypes";
            this.cmbStrictFileTypes.Size = new System.Drawing.Size(107, 21);
            this.cmbStrictFileTypes.TabIndex = 5;
            this.cmbStrictFileTypes.Text = "-Select-";
            // 
            // lblStrictFileType
            // 
            this.lblStrictFileType.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrictFileType.Location = new System.Drawing.Point(249, 43);
            this.lblStrictFileType.Name = "lblStrictFileType";
            this.lblStrictFileType.Size = new System.Drawing.Size(62, 18);
            this.lblStrictFileType.TabIndex = 4;
            this.lblStrictFileType.Text = "File Type";
            // 
            // chkSubFolder
            // 
            this.chkSubFolder.AutoSize = true;
            this.chkSubFolder.Enabled = false;
            this.chkSubFolder.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSubFolder.Location = new System.Drawing.Point(119, 43);
            this.chkSubFolder.Name = "chkSubFolder";
            this.chkSubFolder.Size = new System.Drawing.Size(124, 17);
            this.chkSubFolder.TabIndex = 2;
            this.chkSubFolder.Text = "Include Subfolders";
            this.chkSubFolder.UseVisualStyleBackColor = true;
            // 
            // rdbDirectory
            // 
            this.rdbDirectory.AutoSize = true;
            this.rdbDirectory.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDirectory.Location = new System.Drawing.Point(6, 42);
            this.rdbDirectory.Name = "rdbDirectory";
            this.rdbDirectory.Size = new System.Drawing.Size(74, 17);
            this.rdbDirectory.TabIndex = 1;
            this.rdbDirectory.Text = "Directory";
            this.rdbDirectory.UseVisualStyleBackColor = true;
            this.rdbDirectory.CheckedChanged += new System.EventHandler(this.rdbDir_CheckedChanged);
            // 
            // rdbFile
            // 
            this.rdbFile.AutoSize = true;
            this.rdbFile.Checked = true;
            this.rdbFile.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFile.Location = new System.Drawing.Point(6, 19);
            this.rdbFile.Name = "rdbFile";
            this.rdbFile.Size = new System.Drawing.Size(45, 17);
            this.rdbFile.TabIndex = 0;
            this.rdbFile.TabStop = true;
            this.rdbFile.Text = "File";
            this.rdbFile.UseVisualStyleBackColor = true;
            this.rdbFile.CheckedChanged += new System.EventHandler(this.rdbFile_CheckedChanged);
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowseFile.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFile.Location = new System.Drawing.Point(283, 90);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(75, 22);
            this.btnBrowseFile.TabIndex = 8;
            this.btnBrowseFile.Text = "Browse";
            this.btnBrowseFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseFile.UseVisualStyleBackColor = false;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // dlgOpenDir
            // 
            this.dlgOpenDir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Coral;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLog.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(324, 416);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(142, 34);
            this.btnLog.TabIndex = 9;
            this.btnLog.Text = "Log Notifications";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.DefaultExt = "log";
            this.dlgSaveFile.Filter = "LogFiles|*.log";
            // 
            // FileWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 457);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.groupBoxDirectorySelection);
            this.Controls.Add(this.lblNotifications);
            this.Controls.Add(this.lstNotification);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.btnBrowseFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileWatcher";
            this.Text = "FileTracker";
            this.groupBoxDirectorySelection.ResumeLayout(false);
            this.groupBoxDirectorySelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //File path Text Box
        private System.Windows.Forms.TextBox txtFilePath;
        //File Path Label
        private System.Windows.Forms.Label lblFilePath;
        //Button Start Watching the files
        private System.Windows.Forms.Button btnWatch;
        //Notification List Box for Showing all the Notifications
        private System.Windows.Forms.ListBox lstNotification;
        //Notification Label
        private System.Windows.Forms.Label lblNotifications;
        //Edit timer
        private System.Windows.Forms.Timer tmrEditNotify;
        //Directory Selection Container
        private System.Windows.Forms.GroupBox groupBoxDirectorySelection;
        //Radio Button for File Selection
        private System.Windows.Forms.RadioButton rdbFile;
        //Radio Button for Directory Selection
        private System.Windows.Forms.RadioButton rdbDirectory;
        //Browse file Button
        private System.Windows.Forms.Button btnBrowseFile;
        //Dialog box for File Selection
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        //open folder
        private System.Windows.Forms.FolderBrowserDialog dlgOpenDir;
        //Log Noification Button
        private System.Windows.Forms.Button btnLog;
        //Save Dialog Box
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        //Check box for Sub folders
        private System.Windows.Forms.CheckBox chkSubFolder;
        //File type DropDown
        private System.Windows.Forms.ComboBox cmbStrictFileTypes;
        //Label for File Type
        private System.Windows.Forms.Label lblStrictFileType;
    }
}

