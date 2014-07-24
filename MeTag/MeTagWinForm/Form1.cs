using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MeTagWinForm
{
    public partial class Form1 : Form
    {
        #region Custom Variables
        private TagDoc curDoc = null;
        private TagNode curTag = null;
        #endregion

        #region Custom Functions
        private void SetCurTag(TagNode newTag)
        {
            if (curTag != null)
            {
                switch (curTag.tagType)
                {
                    case TagType.PURPOSE:
                        BoldLabel(lbPurpose, false);
                        cBPurpose.TextChanged -= new EventHandler(cBCurTag_TextChanged);
                        break;
                    case TagType.DESTINATION:
                        BoldLabel(lbDestination, false);
                        cBDestination.TextChanged -= new EventHandler(cBCurTag_TextChanged);
                        break;
                    case TagType.ATTENDER:
                        BoldLabel(lbAttender, false);
                        break;
                    case TagType.TRANSPORT:
                        BoldLabel(lbTransport, false);
                        break;
                    case TagType.BEFORE_TRAVEL:
                        BoldLabel(lbBeforeTravel, false);
                        cBBeforeTravel.TextChanged -= new EventHandler(cBCurTag_TextChanged);
                        break;
                    case TagType.DURING_TRAVEL:
                        BoldLabel(lbDuringTravel, false);
                        cBDuringTravel.TextChanged -= new EventHandler(cBCurTag_TextChanged);
                        break;
                    case TagType.AFTER_TRAVEL:
                        BoldLabel(lbAfterTravel, false);
                        cBAfterTravel.TextChanged -= new EventHandler(cBCurTag_TextChanged);
                        break;
                    case TagType.TIME:
                        BoldLabel(lbTime, false);
                        cBTime.TextChanged -= new EventHandler(cBCurTag_TextChanged);
                        break;
                }
            }
            curTag = newTag;
            if (curTag != null)
            {
                switch (curTag.tagType)
                {
                    case TagType.PURPOSE:
                        BoldLabel(lbPurpose, true);
                        cBPurpose.Text = curTag.attributes[0].Value;
                        cBPurpose.TextChanged += new EventHandler(cBCurTag_TextChanged);
                        break;
                    case TagType.DESTINATION:
                        BoldLabel(lbDestination, true);
                        cBDestination.Text = curTag.attributes[0].Value;
                        cBDestination.TextChanged += new EventHandler(cBCurTag_TextChanged);
                        break;
                    case TagType.ATTENDER:
                        BoldLabel(lbAttender, true);
                        break;
                    case TagType.TRANSPORT:
                        BoldLabel(lbTransport, true);
                        break;
                    case TagType.BEFORE_TRAVEL:
                        BoldLabel(lbBeforeTravel, true);
                        cBBeforeTravel.Text = curTag.attributes[0].Value;
                        cBBeforeTravel.TextChanged += new EventHandler(cBCurTag_TextChanged);
                        break;
                    case TagType.DURING_TRAVEL:
                        BoldLabel(lbDuringTravel, true);
                        cBDuringTravel.Text = curTag.attributes[0].Value;
                        cBDuringTravel.TextChanged += new EventHandler(cBCurTag_TextChanged);
                        break;
                    case TagType.AFTER_TRAVEL:
                        BoldLabel(lbAfterTravel, true);
                        cBAfterTravel.Text = curTag.attributes[0].Value;
                        cBAfterTravel.TextChanged += new EventHandler(cBCurTag_TextChanged);
                        break;
                    case TagType.TIME:
                        BoldLabel(lbTime, true);
                        cBTime.Text = curTag.attributes[0].Value;
                        cBTime.TextChanged += new EventHandler(cBCurTag_TextChanged);
                        break;
                }
            }
        }

        private void BoldLabel(Label target, bool isBold)
        {
            if (target == null) return;
            if (isBold)
                target.Font = new Font(target.Font, FontStyle.Bold);
            else
                target.Font = new Font(target.Font, FontStyle.Regular);
        }

        private void RefreshRichTextBox(int startPos, int endPos)
        {
            if (curDoc == null) return;
            if (startPos < 0) startPos = 0;
            if (endPos < 0 || endPos > rTBDoc.Text.Length) endPos = rTBDoc.Text.Length;

            rTBDoc.SuspendLayout();

            int oldSelectionStart = rTBDoc.SelectionStart;
            int oldSelectionLength = rTBDoc.SelectionLength;

            int fullRangeStart = startPos;
            int fullRangeEnd = endPos;

            TagNode[] nodesToFormat = curDoc.getTagNodesByRange(startPos, endPos);

            if (nodesToFormat.Length > 0 && nodesToFormat[0].startPos < fullRangeStart) fullRangeStart = nodesToFormat[0].startPos;
            if (nodesToFormat.Length > 0 && nodesToFormat[nodesToFormat.Length - 1].endPos > fullRangeEnd) fullRangeEnd = nodesToFormat[nodesToFormat.Length - 1].endPos;
            rTBDoc.Select(fullRangeStart, fullRangeEnd - fullRangeStart);
            rTBDoc.SelectionBackColor = rTBDoc.BackColor;

            foreach (TagNode curNode in nodesToFormat)
            {
                rTBDoc.Select(curNode.startPos, curNode.endPos - curNode.startPos);
                switch (curNode.tagType)
                {
                    case TagType.PURPOSE:
                        rTBDoc.SelectionBackColor = ColorTranslator.FromHtml("#FF8888");
                        break;
                    case TagType.DESTINATION:
                        rTBDoc.SelectionBackColor = ColorTranslator.FromHtml("#FFBB88");
                        break;
                    case TagType.ATTENDER:
                        rTBDoc.SelectionBackColor = ColorTranslator.FromHtml("#FFFFBB");
                        break;
                    case TagType.TRANSPORT:
                        rTBDoc.SelectionBackColor = ColorTranslator.FromHtml("#88FF88");
                        break;
                    case TagType.BEFORE_TRAVEL:
                        rTBDoc.SelectionBackColor = ColorTranslator.FromHtml("#88FFFF");
                        break;
                    case TagType.DURING_TRAVEL:
                        rTBDoc.SelectionBackColor = ColorTranslator.FromHtml("#88BBFF");
                        break;
                    case TagType.AFTER_TRAVEL:
                        rTBDoc.SelectionBackColor = ColorTranslator.FromHtml("#8888FF");
                        break;
                    case TagType.TIME:
                        rTBDoc.SelectionBackColor = ColorTranslator.FromHtml("#FF88FF");
                        break;
                }
            }

            rTBDoc.Select(oldSelectionStart, oldSelectionLength);
            rTBDoc.ResumeLayout();
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "MeTag[v" + FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion.ToString() + "]";
            cBType.SelectedIndex =
            cbIntent.SelectedIndex =
            cBPurpose.SelectedIndex =
            cBDestination.SelectedIndex =
            cBTime.SelectedIndex = 0;
        }

        private void tSbtOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofDlg = new OpenFileDialog())
            {
                ofDlg.DefaultExt = ".xml";
                ofDlg.Filter = "XML File|*.xml|Work State File|*.ws|All File|*.*";
                ofDlg.Multiselect = false;

                if (ofDlg.ShowDialog() == DialogResult.OK)
                {
                    curDoc = AppBase.LoadFile(ofDlg.FileName);
                    if (curDoc == null) MessageBox.Show("Failed to load seleted file, check file format.");
                    else
                    {
                        rTBDoc.Clear();
                        rTBDoc.Text = curDoc.content;
                        lbMessage.Text = String.Format("Message:\n Tilte:{0}\n Author:{1}\n URL:{2}\n ID:{3}", curDoc.title, curDoc.author, curDoc.url, curDoc.id);
                        RefreshRichTextBox(-1, -1);
                    }
                }
            }
        }

        private void tSbtSave_Click(object sender, EventArgs e)
        {
            curDoc.type = cBType.Text;
            curDoc.intent = cbIntent.Text;

            using (SaveFileDialog sfDlg = new SaveFileDialog())
            {
                sfDlg.FileName = curDoc.id+"_result";
                sfDlg.DefaultExt = "*.xml";
                sfDlg.Filter = "XML File|*.xml|All File|*.*";

                if (sfDlg.ShowDialog() == DialogResult.OK)
                {
                    if (AppBase.SaveFile(sfDlg.FileName, curDoc))
                        MessageBox.Show("Save successful", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else MessageBox.Show("Save failed", "Save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rTBDoc_MouseEnter(object sender, EventArgs e)
        {
            rTBDoc.Focus();
        }

        private void rTBDoc_KeyDown(object sender, KeyEventArgs e)
        {
#if DEBUG
            Console.WriteLine("rTBDoc KeyDown() => " + e.KeyCode.ToString());
#endif
            switch (e.KeyCode)
            {
                case Keys.F1:
                    cBPurpose.Focus();
                    break;
                case Keys.F2:
                    cBDestination.Focus();
                    break;
                case Keys.F5:
                    cBBeforeTravel.Focus();
                    break;
                case Keys.F6:
                    cBDuringTravel.Focus();
                    break;
                case Keys.F7:
                    cBAfterTravel.Focus();
                    break;
                case Keys.F8:
                    cBTime.Focus();
                    break;
            }
        }

        private void rTBDoc_KeyUp(object sender, KeyEventArgs e)
        {
            //TODO: Check And Add Tag
#if DEBUG
            Console.WriteLine("rTBDoc KeyUp() => " + e.KeyCode.ToString());
#endif
            //if (rTBDoc.SelectionLength == 0)
            //{
            //    MessageBox.Show("Slelect something before adding tag!");
            //    return;
            //}

            int insertPos = -1;
            int posStart = rTBDoc.SelectionStart;
            int posEnd = rTBDoc.SelectionStart + rTBDoc.SelectionLength;

            switch (e.KeyCode)
            {
                case Keys.F1:
                    if (curTag == null) //Insert New Node
                    {
                        insertPos = curDoc.GetInsertPos(posStart, posEnd);
                        if (rTBDoc.SelectionLength == 0) MessageBox.Show("Select something to add node");
                        else if (insertPos < 0) MessageBox.Show("Can not add tag here");
                        else
                        {
                            TagNode newNode = new TagNode();
                            newNode.tagType = TagType.PURPOSE;
                            newNode.startPos = posStart;
                            newNode.endPos = posEnd;
                            newNode.attributes.Add(new KeyValuePair<string, string>("value", cBPurpose.Text));
                            curDoc.tagNodeList.Insert(insertPos, newNode);
                            RefreshRichTextBox(posStart, posEnd);
                        }
                    }
                    else    //Remove Existing Node
                    {
                        int tagStart = curTag.startPos, tagEnd = curTag.endPos;
                        curDoc.tagNodeList.Remove(curTag);
                        RefreshRichTextBox(tagStart, tagEnd);
                    }
                    rTBDoc.Focus();
                    break;
                case Keys.F2:
                    if (curTag == null) //Insert New Node
                    {
                        insertPos = curDoc.GetInsertPos(posStart, posEnd);
                        if (rTBDoc.SelectionLength == 0) MessageBox.Show("Select something to add node");
                        else if (insertPos < 0) MessageBox.Show("Can not add tag here");
                        else
                        {
                            TagNode newNode = new TagNode();
                            newNode.tagType = TagType.DESTINATION;
                            newNode.startPos = posStart;
                            newNode.endPos = posEnd;
                            newNode.attributes.Add(new KeyValuePair<string, string>("value", cBDestination.Text));
                            curDoc.tagNodeList.Insert(insertPos, newNode);
                            RefreshRichTextBox(posStart, posEnd);
                        }
                    }
                    else    //Remove Existing Node
                    {
                        int tagStart = curTag.startPos, tagEnd = curTag.endPos;
                        curDoc.tagNodeList.Remove(curTag);
                        RefreshRichTextBox(tagStart, tagEnd);
                    }
                    rTBDoc.Focus();
                    break;
                case Keys.F3:
                    if (curTag == null) //Insert New Node
                    {
                        insertPos = curDoc.GetInsertPos(posStart, posEnd);
                        if (rTBDoc.SelectionLength == 0) MessageBox.Show("Select something to add node");
                        else if (insertPos < 0) MessageBox.Show("Can not add tag here");
                        else
                        {
                            TagNode newNode = new TagNode();
                            newNode.tagType = TagType.ATTENDER;
                            newNode.startPos = posStart;
                            newNode.endPos = posEnd;
                            curDoc.tagNodeList.Insert(insertPos, newNode);
                            RefreshRichTextBox(posStart, posEnd);
                        }
                    }
                    else    //Remove Existing Node
                    {
                        int tagStart = curTag.startPos, tagEnd = curTag.endPos;
                        curDoc.tagNodeList.Remove(curTag);
                        RefreshRichTextBox(tagStart, tagEnd);
                    }
                    rTBDoc.Focus();
                    break;
                case Keys.F4:
                    if (curTag == null) //Insert New Node
                    {
                        insertPos = curDoc.GetInsertPos(posStart, posEnd);
                        if (rTBDoc.SelectionLength == 0) MessageBox.Show("Select something to add node");
                        else if (insertPos < 0) MessageBox.Show("Can not add tag here");
                        else
                        {
                            TagNode newNode = new TagNode();
                            newNode.tagType = TagType.TRANSPORT;
                            newNode.startPos = posStart;
                            newNode.endPos = posEnd;
                            curDoc.tagNodeList.Insert(insertPos, newNode);
                            RefreshRichTextBox(posStart, posEnd);
                        }
                    }
                    else    //Remove Existing Node
                    {
                        int tagStart = curTag.startPos, tagEnd = curTag.endPos;
                        curDoc.tagNodeList.Remove(curTag);
                        RefreshRichTextBox(tagStart, tagEnd);
                    }
                    rTBDoc.Focus();
                    break;
                case Keys.F5:
                    if (curTag == null) //Insert New Node
                    {
                        insertPos = curDoc.GetInsertPos(posStart, posEnd);
                        if (rTBDoc.SelectionLength == 0) MessageBox.Show("Select something to add node");
                        else if (insertPos < 0) MessageBox.Show("Can not add tag here");
                        else
                        {
                            TagNode newNode = new TagNode();
                            newNode.tagType = TagType.BEFORE_TRAVEL;
                            newNode.startPos = posStart;
                            newNode.endPos = posEnd;
                            newNode.attributes.Add(new KeyValuePair<string, string>("value", cBBeforeTravel.Text));
                            curDoc.tagNodeList.Insert(insertPos, newNode);
                            RefreshRichTextBox(posStart, posEnd);
                        }
                    }
                    else    //Remove Existing Node
                    {
                        int tagStart = curTag.startPos, tagEnd = curTag.endPos;
                        curDoc.tagNodeList.Remove(curTag);
                        RefreshRichTextBox(tagStart, tagEnd);
                    }
                    rTBDoc.Focus();
                    break;
                case Keys.F6:
                    if (curTag == null) //Insert New Node
                    {
                        insertPos = curDoc.GetInsertPos(posStart, posEnd);
                        if (rTBDoc.SelectionLength == 0) MessageBox.Show("Select something to add node");
                        else if (insertPos < 0) MessageBox.Show("Can not add tag here");
                        else
                        {
                            TagNode newNode = new TagNode();
                            newNode.tagType = TagType.DURING_TRAVEL;
                            newNode.startPos = posStart;
                            newNode.endPos = posEnd;
                            newNode.attributes.Add(new KeyValuePair<string, string>("value", cBDuringTravel.Text));
                            curDoc.tagNodeList.Insert(insertPos, newNode);
                            RefreshRichTextBox(posStart, posEnd);
                        }
                    }
                    else    //Remove Existing Node
                    {
                        int tagStart = curTag.startPos, tagEnd = curTag.endPos;
                        curDoc.tagNodeList.Remove(curTag);
                        RefreshRichTextBox(tagStart, tagEnd);
                    }
                    rTBDoc.Focus();
                    break;
                case Keys.F7:
                    if (curTag == null) //Insert New Node
                    {
                        insertPos = curDoc.GetInsertPos(posStart, posEnd);
                        if (rTBDoc.SelectionLength == 0) MessageBox.Show("Select something to add node");
                        else if (insertPos < 0) MessageBox.Show("Can not add tag here");
                        else
                        {
                            TagNode newNode = new TagNode();
                            newNode.tagType = TagType.AFTER_TRAVEL;
                            newNode.startPos = posStart;
                            newNode.endPos = posEnd;
                            newNode.attributes.Add(new KeyValuePair<string, string>("value", cBAfterTravel.Text));
                            curDoc.tagNodeList.Insert(insertPos, newNode);
                            RefreshRichTextBox(posStart, posEnd);
                        }
                    }
                    else    //Remove Existing Node
                    {
                        int tagStart = curTag.startPos, tagEnd = curTag.endPos;
                        curDoc.tagNodeList.Remove(curTag);
                        RefreshRichTextBox(tagStart, tagEnd);
                    }
                    rTBDoc.Focus();
                    break;
                case Keys.F8:
                    if (curTag == null) //Insert New Node
                    {
                        insertPos = curDoc.GetInsertPos(posStart, posEnd);
                        if (rTBDoc.SelectionLength == 0) MessageBox.Show("Select something to add node");
                        else if (insertPos < 0) MessageBox.Show("Can not add tag here");
                        else
                        {
                            TagNode newNode = new TagNode();
                            newNode.tagType = TagType.TIME;
                            newNode.startPos = posStart;
                            newNode.endPos = posEnd;
                            newNode.attributes.Add(new KeyValuePair<string, string>("value", cBTime.Text));
                            curDoc.tagNodeList.Insert(insertPos, newNode);
                            RefreshRichTextBox(posStart, posEnd);
                        }
                    }
                    else    //Remove Existing Node
                    {
                        int tagStart = curTag.startPos, tagEnd = curTag.endPos;
                        curDoc.tagNodeList.Remove(curTag);
                        RefreshRichTextBox(tagStart, tagEnd);
                    }
                    rTBDoc.Focus();
                    break;
            }
            TagNode newTag = curDoc.getTagNodeByPos(posStart, posEnd);
            SetCurTag(newTag);
        }

        private void rTBDoc_SelectionChanged(object sender, EventArgs e)
        {
            if (curDoc == null) return;
            else
            {
                int posStart = rTBDoc.SelectionStart;
                int posEnd = rTBDoc.SelectionStart + rTBDoc.SelectionLength;
                TagNode newTag = curDoc.getTagNodeByPos(posStart, posEnd);
                SetCurTag(newTag);
            }
        }

        private void cBCurTag_TextChanged(object sender, EventArgs e)
        {
            ComboBox cbSender = (ComboBox)sender;
            curTag.attributes.Clear();
            curTag.attributes.Add(new KeyValuePair<string, string>("value", cbSender.Text));
        }

        private void tSBHistoryList_Click(object sender, EventArgs e)
        {
            if (curDoc == null) return;
            using (HistoryForm historyForm = new HistoryForm())
            {
                historyForm.RefreshHistoryList(curDoc.historyList);
                historyForm.ShowDialog();
            }
        }
    }
}
