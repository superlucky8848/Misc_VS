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
        private List<OutDoc> outDocList = new List<OutDoc>();
        private SettingForm settingForm = new SettingForm();
        #endregion

        #region Custom Functions
        private void RefreshTagListView()
        {
            lVTag.Items.Clear();
            foreach (OutDoc curDoc in outDocList)
            {
                foreach (TagInfo tagInfo in curDoc.TagInfoList)
                {
                    ListViewItem item = lVTag.Items.Add(tagInfo.TagName);
                    item.SubItems.Add(tagInfo.TagValue);
                    item.SubItems.Add(tagInfo.TagText);
                    item.SubItems.Add(String.Format("{0}({1}/{2})",
                        Path.GetFileNameWithoutExtension(tagInfo.TagDocName),
                        curDoc.DocType,
                        curDoc.DocIntent));
                    item.Tag = tagInfo;
                }
            }
        }

        public void RefreshDoc(TagInfo tagInfo)
        {
            if (tagInfo == null) return;
            OutDoc curDoc = tagInfo.ownerDoc;
            int index = curDoc.TagInfoList.IndexOf(tagInfo);
            int selStart, selLength;

            lbFileName.Text = curDoc.FileName;
            lVFileAttribute.Items.Clear();
            foreach (KeyValuePair<string, string> prop in curDoc.DocProperties)
                lVFileAttribute.Items.Add(prop.Key).SubItems.Add(prop.Value);
            rTBDoc.Text = curDoc.Content;
            if (curDoc.GetTagOffset(index, out selStart, out selLength))
                rTBDoc.Select(selStart, selLength);
            rTBDoc.ScrollToCaret();
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();
            settingForm.Owner = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "MeTagQA[v" + FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion.ToString() + "]";
        }

        private void tSbtImport_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbDlg = new FolderBrowserDialog())
            {
                if (fbDlg.ShowDialog() == DialogResult.OK)
                {
                    outDocList.Clear();
                    string[] files = Directory.GetFiles(fbDlg.SelectedPath, "*.xml", SearchOption.TopDirectoryOnly);
                    foreach (string file in files)
                    {
                        OutDoc newDoc = new OutDoc(file);
                        if (!String.IsNullOrEmpty(newDoc.FileName)) outDocList.Add(newDoc);
                    }
                    RefreshTagListView();
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
                outDocList.Clear();
                string[] files = Directory.GetFiles(fileNames[0], "*.xml", SearchOption.TopDirectoryOnly);
                foreach (string file in files)
                {
                    OutDoc newDoc = new OutDoc(file);
                    if (!String.IsNullOrEmpty(newDoc.FileName)) outDocList.Add(newDoc);
                }
                RefreshTagListView();
            }
        }

        private void lVTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lVTag.SelectedIndices.Count == 0) return;
            TagInfo curTag = lVTag.SelectedItems[0].Tag as TagInfo;
            RefreshDoc(curTag);
        }

        private void splitContainer_Splitter_Paint(object sender, PaintEventArgs e)
        {
            SplitContainer control = sender as SplitContainer;
            //paint the three dots'
            Point[] points = new Point[3];
            int w = control.Width;
            int h = control.Height;
            int d = control.SplitterDistance;
            int sW = control.SplitterWidth;

            //calculate the position of the points'
            if (control.Orientation == Orientation.Horizontal)
            {
                points[0] = new Point((w / 2), d + (sW / 2));
                points[1] = new Point(points[0].X - 10, points[0].Y);
                points[2] = new Point(points[0].X + 10, points[0].Y);
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlDarkDark), 0, d + sW / 2 - 1, w / 2 - 20, 2);
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlLightLight), 0, d + sW / 2 - 1, w / 2 - 21, 1);
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlDarkDark), w / 2 + 20, d + sW / 2 - 1, w / 2 - 20, 2);
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlLightLight), w / 2 + 20, d + sW / 2 - 1, w / 2 - 21, 1);
            }
            else
            {
                points[0] = new Point(d + (sW / 2), (h / 2));
                points[1] = new Point(points[0].X, points[0].Y - 10);
                points[2] = new Point(points[0].X, points[0].Y + 10);
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlDarkDark), d + sW / 2 - 1, 0, 2, h / 2 - 20);
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlLightLight), d + sW / 2 - 1, 0, 1, h / 2 - 21);
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlDarkDark), d + sW / 2 - 1, h / 2 + 20, 2, h / 2 - 20);
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlLightLight), d + sW / 2 - 1, h / 2 + 20, 1, h / 2 - 21);
            }

            foreach (Point p in points)
            {
                p.Offset(-2, -2);
                e.Graphics.FillEllipse(SystemBrushes.ControlDark,
                    new Rectangle(p, new Size(3, 3)));

                p.Offset(1, 1);
                e.Graphics.FillEllipse(SystemBrushes.ControlLight,
                    new Rectangle(p, new Size(3, 3)));
            }
        }

        //Filter Tags
        private void btTagFilterNew_Click(object sender, EventArgs e)
        {
            lVTag.SuspendLayout();
            RefreshTagListView();
            btTagFilterResult.PerformClick();
            lVTag.ResumeLayout();
        }

        private void btTagFilterResult_Click(object sender, EventArgs e)
        {
            for(int i = lVTag.Items.Count-1; i>=0; --i)
            {
                ListViewItem item = lVTag.Items[i];
                string tagName = item.SubItems[0].Text;
                string tagValue = item.SubItems[1].Text;
                string tagText = item.SubItems[2].Text;

                //I'm sorry for anyone that debug these following lines. It's the filter logic which I only can say...
                if (!(
                        (String.IsNullOrEmpty(cBTagName.Text) || tagName == cBTagName.Text) &&
                        (String.IsNullOrEmpty(cbTagValue.Text) || tagValue == cbTagValue.Text) &&
                        (String.IsNullOrEmpty(tBTagText.Text) ||
                            rBTextExact.Checked && tagText == tBTagText.Text ||
                            rBTextContain.Checked && tagText.Contains(tBTagText.Text) ||
                            rBTextStartWith.Checked && tagText.StartsWith(tBTagText.Text) ||
                            rBTextEndWith.Checked && tagText.EndsWith(tBTagText.Text))
                     ))
                {
                    lVTag.Items.RemoveAt(i);
                }
            }
        }

        private void btTagReset_Click(object sender, EventArgs e)
        {
            RefreshTagListView();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            splitMain.Invalidate();
            splitLeft.Invalidate();
            splitRight.Invalidate();
        }

        private void btDocFilterNew_Click(object sender, EventArgs e)
        {
            lVTag.SuspendLayout();
            RefreshTagListView();
            btDocFilterResult.PerformClick();
            lVTag.ResumeLayout();
        }

        private void btDocReset_Click(object sender, EventArgs e)
        {
            RefreshTagListView();
        }

        private void btDocFilterResult_Click(object sender, EventArgs e)
        {
            for (int i = lVTag.Items.Count - 1; i >= 0; --i)
            {
                TagInfo tagInfo = lVTag.Items[i].Tag as TagInfo;
                if (tagInfo == null)
                {
                    lVTag.Items.RemoveAt(i);
                    continue;
                }
                OutDoc curDoc = tagInfo.ownerDoc;
                if (curDoc == null)
                {
                    lVTag.Items.RemoveAt(i);
                    continue;
                }

                if(!(
                        (String.IsNullOrEmpty(cBDocType.Text) || cBDocType.Text==curDoc.DocType) &&
                        (String.IsNullOrEmpty(cBDocIntent.Text) || cBDocIntent.Text == curDoc.DocIntent) &&
                        (String.IsNullOrEmpty(tBDocPropName.Text) || curDoc.DocProperties[tBDocPropName.Text]==tBDocPropValue.Text)
                    ))   //TODO: Modify that.
                {
                    lVTag.Items.RemoveAt(i);
                }
            }
        }

        private void cBTagName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTagValue.Items.Clear();
            cbTagValue.Text = "";
            switch (cBTagName.Text)
            { 
                case "purpose":
                    cbTagValue.Items.Add("personal");
                    cbTagValue.Items.Add("public");
                    break;
                case "destination":
                    cbTagValue.Items.Add("country");
                    cbTagValue.Items.Add("city");
                    cbTagValue.Items.Add("hotel");
                    cbTagValue.Items.Add("attraction");
                    break;
                case "time":
                    cbTagValue.Items.Add("time");
                    cbTagValue.Items.Add("period");
                    break;
            }
        }

        private void tSbtOpenMeTag_Click(object sender, EventArgs e)
        {
            if (lVTag.SelectedItems.Count == 0)
            {
                MessageBox.Show("No tag node is selected.");
                return;
            }
            if (!File.Exists(Properties.Settings.Default.MeTagPath))
            {
                MessageBox.Show("MeTag exe file not found, use settings to set it first.");
                return;
            }
            TagInfo curTag = lVTag.SelectedItems[0].Tag as TagInfo;
            string fileName = curTag.TagDocName+".ws";
            if (!File.Exists(fileName))
            {
                MessageBox.Show(String.Format("Corresponding WorkState File ({0}) is not found.", Path.GetFileName(fileName)));
                return;
            }
            int index = curTag.ownerDoc.TagInfoList.IndexOf(curTag);

            Process.Start(Properties.Settings.Default.MeTagPath, fileName+" "+index.ToString());
        }

        private void tSbtSettings_Click(object sender, EventArgs e)
        {
            settingForm.Show();
        }
    }
}
