using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace MeTagQA
{
    public partial class MainForm : Form
    {
        #region Custom Variables

        #endregion

        #region Custom Functions
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "MeTagQA[v" + FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion.ToString()+"]";
        }

        private void tSbtImport_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbDlg = new FolderBrowserDialog())
            {
                if (fbDlg.ShowDialog() == DialogResult.OK)
                { 
                    //TODO: Load Files for selected folder.

                }
            }
        }

        private void lVTag_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (fileNames.Length > 0 && Directory.Exists(fileNames[0])) e.Effect = DragDropEffects.Copy;
                else e.Effect = DragDropEffects.None;
            }
            else e.Effect = DragDropEffects.None;
        }

        private void lVTag_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (fileNames.Length > 0 && Directory.Exists(fileNames[0]))
            {
                //TODO: Load Files for selected folder.
            }
        }
    }
}
