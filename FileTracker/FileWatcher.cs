using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileTracker
{
    public partial class FileWatcher : Form
    {
        /// <summary>
        /// Constructor to Initialize all the Componets
        /// </summary>
        public FileWatcher()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gloabl private Variables
        /// </summary>
        private StringBuilder myNewString = new StringBuilder();
        private bool flag = false;
        private System.IO.FileSystemWatcher fileWatcher;
        private bool watching = false;

        /// <summary>
        /// Button to Watch the File or Directory if any changes happens to the File or directory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWatchFile_Click(object sender, EventArgs e)
        {
            //Checks if the Path Is not Empty then It Starts Tracking the File.
            if (!string.IsNullOrEmpty(txtFilePath.Text))
            {
                //If The File or Directory is Already watched then Cancel this Tracking of the File or Directory.
                if (watching)
                {
                    watching = false;
                    fileWatcher.EnableRaisingEvents = false;
                    fileWatcher.Dispose();
                    btnWatch.BackColor = Color.DarkSlateBlue;
                    btnWatch.Text = "Watch";
                    rdbDirectory.Enabled = true;
                    rdbFile.Enabled = true;
                    //If Directory Checked then Its Other options should be opened for selection.
                    if(rdbDirectory.Checked)
                    {
                        chkSubFolder.Enabled = true;
                        cmbStrictFileTypes.Enabled = true;
                    }
                    else
                    {
                        chkSubFolder.Enabled = false;
                        cmbStrictFileTypes.Enabled = false;
                    }                  
                }
                else
                {
                    rdbDirectory.Enabled = false;
                    rdbFile.Enabled = false;
                    chkSubFolder.Enabled = false;
                    cmbStrictFileTypes.Enabled = false;
                    watching = true;
                    btnWatch.BackColor = Color.Red;
                    btnWatch.Text = "Stop Watching";
                    fileWatcher = new System.IO.FileSystemWatcher();
                    //If Directory is Selected it Starts watching all the Things in that directory.
                    if (rdbDirectory.Checked)
                    {
                        var selectedFile = (cmbStrictFileTypes.SelectedItem?.ToString()??"-Select-").Trim();
                        //Check for If Specific Type of file you wants to keep track of for that Directory.It adds filter.
                        if (selectedFile == ".*" || selectedFile == "-Select-")
                        {
                            fileWatcher.Filter = "*.*";
                            fileWatcher.Path = txtFilePath.Text + "\\";
                        }
                        else
                        {
                            fileWatcher.Filter = $"*{selectedFile}";
                            fileWatcher.Path = txtFilePath.Text + "\\";
                        }
                        //Watch if to Track the Sub-Folder in case of Directory Tracking
                        if (chkSubFolder.Checked)
                        {
                            fileWatcher.IncludeSubdirectories = true;
                        }
                    }
                    else
                    {
                        //Tracks a specific file
                        fileWatcher.Filter = txtFilePath.Text.Substring(txtFilePath.Text.LastIndexOf('\\') + 1);
                        fileWatcher.Path = txtFilePath.Text.Substring(0, txtFilePath.Text.Length - fileWatcher.Filter.Length);
                    }

                    //All the File Watching Event Supported by  System.IO.FileSystemWatcher
                    fileWatcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                                         | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                    fileWatcher.Changed += new FileSystemEventHandler(OnChanged);
                    fileWatcher.Created += new FileSystemEventHandler(OnChanged);
                    fileWatcher.Deleted += new FileSystemEventHandler(OnChanged);
                    fileWatcher.Renamed += new RenamedEventHandler(OnRenamed);
                    fileWatcher.EnableRaisingEvents = true;
                }
            }
           
        }

        /// <summary>
        /// On-File or directory Change Automatic-Event Fires
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (!flag)
            {
                myNewString.Remove(0, myNewString.Length);
                myNewString.Append(e.FullPath);
                myNewString.Append(" ");
                myNewString.Append(e.ChangeType.ToString());
                myNewString.Append("    ");
                myNewString.Append(DateTime.Now.ToString());
                flag = true;
            }
        }

        /// <summary>
        /// On-File or Directorty Name Changes the Event fires automatically.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            if (!flag)
            {
                myNewString.Remove(0, myNewString.Length);
                myNewString.Append(e.OldFullPath);
                myNewString.Append(" ");
                myNewString.Append(e.ChangeType.ToString());
                myNewString.Append(" ");
                myNewString.Append("to ");
                myNewString.Append(e.Name);
                myNewString.Append("    ");
                myNewString.Append(DateTime.Now.ToString());
                flag = true;
                fileWatcher.Filter = e.Name;
                fileWatcher.Path = e.FullPath.Substring(0, e.FullPath.Length - fileWatcher.Filter.Length);
            }
        }
        /// <summary>
        /// Added Item to Notification List on any file Watching Event Occures.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrEditNotify_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                lstNotification.BeginUpdate();
                lstNotification.Items.Add(myNewString.ToString());
                lstNotification.EndUpdate();
                flag = false;
            }
        }
        /// <summary>
        /// Button For Browsing the File or the Directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            //Checks Wheather the Directory of File Mode of Tracking is Selected for Tracking
            if (rdbDirectory.Checked)
            {
                DialogResult resDialog = dlgOpenDir.ShowDialog();
                if (resDialog.ToString() == "OK")
                {
                    txtFilePath.Text = dlgOpenDir.SelectedPath;
                }              
            }
            else
            {
                DialogResult resDialog = dlgOpenFile.ShowDialog();
                if (resDialog.ToString() == "OK")
                {                   
                    txtFilePath.Text = dlgOpenFile.FileName;
                }
            }
        }

        /// <summary>
        /// Write all Loged Watched file details to the a File to Store Details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLog_Click(object sender, EventArgs e)
        {
            //Checks if there is any Log in the Notification Pad.
            if (!string.IsNullOrEmpty(lstNotification.Text))
            {
                DialogResult resDialog = dlgSaveFile.ShowDialog();
                if (resDialog.ToString() == "OK")
                {
                    FileInfo fi = new FileInfo(dlgSaveFile.FileName);
                    StreamWriter sw = fi.CreateText();
                    foreach (string sItem in lstNotification.Items)
                    {
                        sw.WriteLine(sItem);
                    }
                    sw.Close();
                }
            }
            
        }

        /// <summary>
        /// Enables file Watching Properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFile.Checked == true)
            {
                chkSubFolder.Enabled = false;
                chkSubFolder.Checked = false;
                cmbStrictFileTypes.Enabled = false;
            }
        }

        /// <summary>
        /// Enables the Directive Watching Properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbDir_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDirectory.Checked == true)
            {
                chkSubFolder.Enabled = true;
                cmbStrictFileTypes.Enabled = true;
            }
        }

    }
}
