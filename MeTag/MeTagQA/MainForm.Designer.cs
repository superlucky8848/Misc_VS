namespace MeTagQA
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.tbCFilter = new System.Windows.Forms.TabControl();
            this.tPTagFilter = new System.Windows.Forms.TabPage();
            this.btTagFilterResult = new System.Windows.Forms.Button();
            this.gBTextMatchMethod = new System.Windows.Forms.GroupBox();
            this.rBTextExact = new System.Windows.Forms.RadioButton();
            this.rBTextEndWith = new System.Windows.Forms.RadioButton();
            this.rBTextContain = new System.Windows.Forms.RadioButton();
            this.rBTextStartWith = new System.Windows.Forms.RadioButton();
            this.tBTagText = new System.Windows.Forms.TextBox();
            this.cbTagValue = new System.Windows.Forms.ComboBox();
            this.btTagReset = new System.Windows.Forms.Button();
            this.btTagFilterNew = new System.Windows.Forms.Button();
            this.cBTagName = new System.Windows.Forms.ComboBox();
            this.tPDocFilter = new System.Windows.Forms.TabPage();
            this.lVTag = new System.Windows.Forms.ListView();
            this.colTagName = new System.Windows.Forms.ColumnHeader();
            this.colTagValue = new System.Windows.Forms.ColumnHeader();
            this.colTagText = new System.Windows.Forms.ColumnHeader();
            this.colDocName = new System.Windows.Forms.ColumnHeader();
            this.splitRight = new System.Windows.Forms.SplitContainer();
            this.lVFileAttribute = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colValue = new System.Windows.Forms.ColumnHeader();
            this.lbFileName = new System.Windows.Forms.Label();
            this.rTBDoc = new System.Windows.Forms.RichTextBox();
            this.tSTools = new System.Windows.Forms.ToolStrip();
            this.tSbtImport = new System.Windows.Forms.ToolStripButton();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.splitLeft = new System.Windows.Forms.SplitContainer();
            this.btDocFilterResult = new System.Windows.Forms.Button();
            this.btDocReset = new System.Windows.Forms.Button();
            this.btDocFilterNew = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.tBDocPropName = new System.Windows.Forms.TextBox();
            this.cBDocIntent = new System.Windows.Forms.ComboBox();
            this.cBDocType = new System.Windows.Forms.ComboBox();
            this.tBDocPropValue = new System.Windows.Forms.TextBox();
            this.gBOtherProperty = new System.Windows.Forms.GroupBox();
            this.tSbtOpenMeTag = new System.Windows.Forms.ToolStripButton();
            this.tSbtSettings = new System.Windows.Forms.ToolStripButton();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.tbCFilter.SuspendLayout();
            this.tPTagFilter.SuspendLayout();
            this.gBTextMatchMethod.SuspendLayout();
            this.tPDocFilter.SuspendLayout();
            this.splitRight.Panel1.SuspendLayout();
            this.splitRight.Panel2.SuspendLayout();
            this.splitRight.SuspendLayout();
            this.tSTools.SuspendLayout();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.splitLeft.Panel1.SuspendLayout();
            this.splitLeft.Panel2.SuspendLayout();
            this.splitLeft.SuspendLayout();
            this.gBOtherProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 12);
            label1.TabIndex = 0;
            label1.Text = "Tag Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 12);
            label2.TabIndex = 4;
            label2.Text = "Tag Value:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 62);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 12);
            label3.TabIndex = 6;
            label3.Text = "Tag Text:";
            // 
            // tbCFilter
            // 
            this.tbCFilter.Controls.Add(this.tPTagFilter);
            this.tbCFilter.Controls.Add(this.tPDocFilter);
            this.tbCFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCFilter.Location = new System.Drawing.Point(0, 0);
            this.tbCFilter.Name = "tbCFilter";
            this.tbCFilter.SelectedIndex = 0;
            this.tbCFilter.Size = new System.Drawing.Size(313, 253);
            this.tbCFilter.TabIndex = 0;
            // 
            // tPTagFilter
            // 
            this.tPTagFilter.Controls.Add(this.btTagFilterResult);
            this.tPTagFilter.Controls.Add(this.gBTextMatchMethod);
            this.tPTagFilter.Controls.Add(this.tBTagText);
            this.tPTagFilter.Controls.Add(label3);
            this.tPTagFilter.Controls.Add(this.cbTagValue);
            this.tPTagFilter.Controls.Add(label2);
            this.tPTagFilter.Controls.Add(this.btTagReset);
            this.tPTagFilter.Controls.Add(this.btTagFilterNew);
            this.tPTagFilter.Controls.Add(this.cBTagName);
            this.tPTagFilter.Controls.Add(label1);
            this.tPTagFilter.Location = new System.Drawing.Point(4, 22);
            this.tPTagFilter.Name = "tPTagFilter";
            this.tPTagFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tPTagFilter.Size = new System.Drawing.Size(305, 227);
            this.tPTagFilter.TabIndex = 0;
            this.tPTagFilter.Text = "Tag Filter";
            this.tPTagFilter.UseVisualStyleBackColor = true;
            // 
            // btTagFilterResult
            // 
            this.btTagFilterResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btTagFilterResult.Location = new System.Drawing.Point(116, 196);
            this.btTagFilterResult.Name = "btTagFilterResult";
            this.btTagFilterResult.Size = new System.Drawing.Size(98, 23);
            this.btTagFilterResult.TabIndex = 13;
            this.btTagFilterResult.Text = "Filter Result";
            this.btTagFilterResult.UseVisualStyleBackColor = true;
            this.btTagFilterResult.Click += new System.EventHandler(this.btTagFilterResult_Click);
            // 
            // gBTextMatchMethod
            // 
            this.gBTextMatchMethod.Controls.Add(this.rBTextExact);
            this.gBTextMatchMethod.Controls.Add(this.rBTextEndWith);
            this.gBTextMatchMethod.Controls.Add(this.rBTextContain);
            this.gBTextMatchMethod.Controls.Add(this.rBTextStartWith);
            this.gBTextMatchMethod.Location = new System.Drawing.Point(14, 86);
            this.gBTextMatchMethod.Name = "gBTextMatchMethod";
            this.gBTextMatchMethod.Size = new System.Drawing.Size(200, 70);
            this.gBTextMatchMethod.TabIndex = 12;
            this.gBTextMatchMethod.TabStop = false;
            this.gBTextMatchMethod.Text = "Text Match Method";
            // 
            // rBTextExact
            // 
            this.rBTextExact.AutoSize = true;
            this.rBTextExact.Checked = true;
            this.rBTextExact.Location = new System.Drawing.Point(6, 20);
            this.rBTextExact.Name = "rBTextExact";
            this.rBTextExact.Size = new System.Drawing.Size(53, 16);
            this.rBTextExact.TabIndex = 8;
            this.rBTextExact.TabStop = true;
            this.rBTextExact.Text = "Exact";
            this.rBTextExact.UseVisualStyleBackColor = true;
            // 
            // rBTextEndWith
            // 
            this.rBTextEndWith.AutoSize = true;
            this.rBTextEndWith.Location = new System.Drawing.Point(102, 42);
            this.rBTextEndWith.Name = "rBTextEndWith";
            this.rBTextEndWith.Size = new System.Drawing.Size(71, 16);
            this.rBTextEndWith.TabIndex = 11;
            this.rBTextEndWith.Text = "End With";
            this.rBTextEndWith.UseVisualStyleBackColor = true;
            // 
            // rBTextContain
            // 
            this.rBTextContain.AutoSize = true;
            this.rBTextContain.Location = new System.Drawing.Point(6, 42);
            this.rBTextContain.Name = "rBTextContain";
            this.rBTextContain.Size = new System.Drawing.Size(65, 16);
            this.rBTextContain.TabIndex = 9;
            this.rBTextContain.Text = "Contain";
            this.rBTextContain.UseVisualStyleBackColor = true;
            // 
            // rBTextStartWith
            // 
            this.rBTextStartWith.AutoSize = true;
            this.rBTextStartWith.Location = new System.Drawing.Point(102, 20);
            this.rBTextStartWith.Name = "rBTextStartWith";
            this.rBTextStartWith.Size = new System.Drawing.Size(83, 16);
            this.rBTextStartWith.TabIndex = 10;
            this.rBTextStartWith.Text = "Start With";
            this.rBTextStartWith.UseVisualStyleBackColor = true;
            // 
            // tBTagText
            // 
            this.tBTagText.Location = new System.Drawing.Point(77, 59);
            this.tBTagText.Name = "tBTagText";
            this.tBTagText.Size = new System.Drawing.Size(134, 21);
            this.tBTagText.TabIndex = 7;
            // 
            // cbTagValue
            // 
            this.cbTagValue.FormattingEnabled = true;
            this.cbTagValue.Location = new System.Drawing.Point(77, 33);
            this.cbTagValue.Name = "cbTagValue";
            this.cbTagValue.Size = new System.Drawing.Size(134, 20);
            this.cbTagValue.TabIndex = 5;
            // 
            // btTagReset
            // 
            this.btTagReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btTagReset.Location = new System.Drawing.Point(8, 167);
            this.btTagReset.Name = "btTagReset";
            this.btTagReset.Size = new System.Drawing.Size(102, 23);
            this.btTagReset.TabIndex = 3;
            this.btTagReset.Text = "Reset";
            this.btTagReset.UseVisualStyleBackColor = true;
            this.btTagReset.Click += new System.EventHandler(this.btTagReset_Click);
            // 
            // btTagFilterNew
            // 
            this.btTagFilterNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btTagFilterNew.Location = new System.Drawing.Point(8, 196);
            this.btTagFilterNew.Name = "btTagFilterNew";
            this.btTagFilterNew.Size = new System.Drawing.Size(102, 23);
            this.btTagFilterNew.TabIndex = 2;
            this.btTagFilterNew.Text = "Filter New";
            this.btTagFilterNew.UseVisualStyleBackColor = true;
            this.btTagFilterNew.Click += new System.EventHandler(this.btTagFilterNew_Click);
            // 
            // cBTagName
            // 
            this.cBTagName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTagName.FormattingEnabled = true;
            this.cBTagName.Items.AddRange(new object[] {
            "",
            "purpose",
            "destination",
            "attender",
            "transport",
            "beforetravel",
            "duringtravel",
            "aftertravel",
            "time"});
            this.cBTagName.Location = new System.Drawing.Point(77, 6);
            this.cBTagName.Name = "cBTagName";
            this.cBTagName.Size = new System.Drawing.Size(134, 20);
            this.cBTagName.TabIndex = 1;
            this.cBTagName.SelectedIndexChanged += new System.EventHandler(this.cBTagName_SelectedIndexChanged);
            // 
            // tPDocFilter
            // 
            this.tPDocFilter.Controls.Add(this.gBOtherProperty);
            this.tPDocFilter.Controls.Add(this.cBDocIntent);
            this.tPDocFilter.Controls.Add(label5);
            this.tPDocFilter.Controls.Add(this.cBDocType);
            this.tPDocFilter.Controls.Add(label6);
            this.tPDocFilter.Controls.Add(this.btDocFilterResult);
            this.tPDocFilter.Controls.Add(this.btDocReset);
            this.tPDocFilter.Controls.Add(this.btDocFilterNew);
            this.tPDocFilter.Location = new System.Drawing.Point(4, 22);
            this.tPDocFilter.Name = "tPDocFilter";
            this.tPDocFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tPDocFilter.Size = new System.Drawing.Size(305, 227);
            this.tPDocFilter.TabIndex = 1;
            this.tPDocFilter.Text = "Doc Filter";
            this.tPDocFilter.UseVisualStyleBackColor = true;
            // 
            // lVTag
            // 
            this.lVTag.AllowDrop = true;
            this.lVTag.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTagName,
            this.colTagValue,
            this.colTagText,
            this.colDocName});
            this.lVTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVTag.FullRowSelect = true;
            this.lVTag.Location = new System.Drawing.Point(0, 0);
            this.lVTag.Name = "lVTag";
            this.lVTag.Size = new System.Drawing.Size(313, 448);
            this.lVTag.TabIndex = 1;
            this.lVTag.UseCompatibleStateImageBehavior = false;
            this.lVTag.View = System.Windows.Forms.View.Details;
            this.lVTag.SelectedIndexChanged += new System.EventHandler(this.lVTag_SelectedIndexChanged);
            this.lVTag.DragDrop += new System.Windows.Forms.DragEventHandler(this.lVTag_DragDrop);
            this.lVTag.DragEnter += new System.Windows.Forms.DragEventHandler(this.lVTag_DragEnter);
            // 
            // colTagName
            // 
            this.colTagName.Text = "Tag";
            this.colTagName.Width = 100;
            // 
            // colTagValue
            // 
            this.colTagValue.Text = "Value";
            this.colTagValue.Width = 100;
            // 
            // colTagText
            // 
            this.colTagText.Text = "Text";
            this.colTagText.Width = 100;
            // 
            // colDocName
            // 
            this.colDocName.Text = "Doc";
            this.colDocName.Width = 100;
            // 
            // splitRight
            // 
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitRight.Location = new System.Drawing.Point(0, 0);
            this.splitRight.Name = "splitRight";
            this.splitRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRight.Panel1
            // 
            this.splitRight.Panel1.Controls.Add(this.lVFileAttribute);
            this.splitRight.Panel1.Controls.Add(this.lbFileName);
            this.splitRight.Panel1MinSize = 150;
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.Controls.Add(this.rTBDoc);
            this.splitRight.Size = new System.Drawing.Size(691, 705);
            this.splitRight.SplitterDistance = 150;
            this.splitRight.TabIndex = 2;
            this.splitRight.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer_Splitter_Paint);
            // 
            // lVFileAttribute
            // 
            this.lVFileAttribute.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colValue});
            this.lVFileAttribute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVFileAttribute.FullRowSelect = true;
            this.lVFileAttribute.Location = new System.Drawing.Point(0, 12);
            this.lVFileAttribute.Name = "lVFileAttribute";
            this.lVFileAttribute.Size = new System.Drawing.Size(691, 138);
            this.lVFileAttribute.TabIndex = 1;
            this.lVFileAttribute.UseCompatibleStateImageBehavior = false;
            this.lVFileAttribute.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 94;
            // 
            // colValue
            // 
            this.colValue.Text = "Value";
            this.colValue.Width = 210;
            // 
            // lbFileName
            // 
            this.lbFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFileName.Location = new System.Drawing.Point(0, 0);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(691, 12);
            this.lbFileName.TabIndex = 0;
            this.lbFileName.Text = "No doc selected";
            // 
            // rTBDoc
            // 
            this.rTBDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBDoc.HideSelection = false;
            this.rTBDoc.Location = new System.Drawing.Point(0, 0);
            this.rTBDoc.Name = "rTBDoc";
            this.rTBDoc.ReadOnly = true;
            this.rTBDoc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rTBDoc.Size = new System.Drawing.Size(691, 551);
            this.rTBDoc.TabIndex = 0;
            this.rTBDoc.Text = "";
            // 
            // tSTools
            // 
            this.tSTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSbtImport,
            this.tSbtOpenMeTag,
            this.tSbtSettings});
            this.tSTools.Location = new System.Drawing.Point(0, 0);
            this.tSTools.Name = "tSTools";
            this.tSTools.Size = new System.Drawing.Size(1008, 25);
            this.tSTools.TabIndex = 1;
            this.tSTools.Text = "toolStrip1";
            // 
            // tSbtImport
            // 
            this.tSbtImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSbtImport.Image = ((System.Drawing.Image)(resources.GetObject("tSbtImport.Image")));
            this.tSbtImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtImport.Name = "tSbtImport";
            this.tSbtImport.Size = new System.Drawing.Size(61, 22);
            this.tSbtImport.Text = "Import...";
            this.tSbtImport.Click += new System.EventHandler(this.tSbtImport_Click);
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMain.Location = new System.Drawing.Point(0, 25);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.splitLeft);
            this.splitMain.Panel1MinSize = 300;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitRight);
            this.splitMain.Size = new System.Drawing.Size(1008, 705);
            this.splitMain.SplitterDistance = 313;
            this.splitMain.TabIndex = 2;
            this.splitMain.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer_Splitter_Paint);
            // 
            // splitLeft
            // 
            this.splitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitLeft.Location = new System.Drawing.Point(0, 0);
            this.splitLeft.Name = "splitLeft";
            this.splitLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLeft.Panel1
            // 
            this.splitLeft.Panel1.Controls.Add(this.lVTag);
            this.splitLeft.Panel1MinSize = 150;
            // 
            // splitLeft.Panel2
            // 
            this.splitLeft.Panel2.Controls.Add(this.tbCFilter);
            this.splitLeft.Size = new System.Drawing.Size(313, 705);
            this.splitLeft.SplitterDistance = 448;
            this.splitLeft.TabIndex = 0;
            this.splitLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer_Splitter_Paint);
            // 
            // btDocFilterResult
            // 
            this.btDocFilterResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDocFilterResult.Location = new System.Drawing.Point(116, 196);
            this.btDocFilterResult.Name = "btDocFilterResult";
            this.btDocFilterResult.Size = new System.Drawing.Size(98, 23);
            this.btDocFilterResult.TabIndex = 16;
            this.btDocFilterResult.Text = "Filter Result";
            this.btDocFilterResult.UseVisualStyleBackColor = true;
            this.btDocFilterResult.Click += new System.EventHandler(this.btDocFilterResult_Click);
            // 
            // btDocReset
            // 
            this.btDocReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDocReset.Location = new System.Drawing.Point(8, 167);
            this.btDocReset.Name = "btDocReset";
            this.btDocReset.Size = new System.Drawing.Size(102, 23);
            this.btDocReset.TabIndex = 15;
            this.btDocReset.Text = "Reset";
            this.btDocReset.UseVisualStyleBackColor = true;
            this.btDocReset.Click += new System.EventHandler(this.btDocReset_Click);
            // 
            // btDocFilterNew
            // 
            this.btDocFilterNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDocFilterNew.Location = new System.Drawing.Point(8, 196);
            this.btDocFilterNew.Name = "btDocFilterNew";
            this.btDocFilterNew.Size = new System.Drawing.Size(102, 23);
            this.btDocFilterNew.TabIndex = 14;
            this.btDocFilterNew.Text = "Filter New";
            this.btDocFilterNew.UseVisualStyleBackColor = true;
            this.btDocFilterNew.Click += new System.EventHandler(this.btDocFilterNew_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 16);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Exact";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(102, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "End With";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 16);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "Contain";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(102, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(83, 16);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.Text = "Start With";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // tBDocPropName
            // 
            this.tBDocPropName.Location = new System.Drawing.Point(53, 14);
            this.tBDocPropName.Name = "tBDocPropName";
            this.tBDocPropName.Size = new System.Drawing.Size(147, 21);
            this.tBDocPropName.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 17);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(35, 12);
            label4.TabIndex = 21;
            label4.Text = "Name:";
            // 
            // cBDocIntent
            // 
            this.cBDocIntent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBDocIntent.FormattingEnabled = true;
            this.cBDocIntent.Items.AddRange(new object[] {
            "",
            "positve",
            "neutral",
            "negative"});
            this.cBDocIntent.Location = new System.Drawing.Point(77, 34);
            this.cBDocIntent.Name = "cBDocIntent";
            this.cBDocIntent.Size = new System.Drawing.Size(134, 20);
            this.cBDocIntent.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(24, 37);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(47, 12);
            label5.TabIndex = 19;
            label5.Text = "intent:";
            // 
            // cBDocType
            // 
            this.cBDocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBDocType.FormattingEnabled = true;
            this.cBDocType.Items.AddRange(new object[] {
            "",
            "tour",
            "rest",
            "backpack",
            "business"});
            this.cBDocType.Location = new System.Drawing.Point(77, 7);
            this.cBDocType.Name = "cBDocType";
            this.cBDocType.Size = new System.Drawing.Size(134, 20);
            this.cBDocType.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(36, 10);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(35, 12);
            label6.TabIndex = 17;
            label6.Text = "type:";
            // 
            // tBDocPropValue
            // 
            this.tBDocPropValue.Location = new System.Drawing.Point(53, 42);
            this.tBDocPropValue.Name = "tBDocPropValue";
            this.tBDocPropValue.Size = new System.Drawing.Size(147, 21);
            this.tBDocPropValue.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 45);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(41, 12);
            label7.TabIndex = 23;
            label7.Text = "Value:";
            // 
            // gBOtherProperty
            // 
            this.gBOtherProperty.Controls.Add(label7);
            this.gBOtherProperty.Controls.Add(this.tBDocPropValue);
            this.gBOtherProperty.Controls.Add(label4);
            this.gBOtherProperty.Controls.Add(this.tBDocPropName);
            this.gBOtherProperty.Location = new System.Drawing.Point(8, 61);
            this.gBOtherProperty.Name = "gBOtherProperty";
            this.gBOtherProperty.Size = new System.Drawing.Size(206, 70);
            this.gBOtherProperty.TabIndex = 25;
            this.gBOtherProperty.TabStop = false;
            this.gBOtherProperty.Text = "Other Property";
            // 
            // tSbtOpenMeTag
            // 
            this.tSbtOpenMeTag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSbtOpenMeTag.Image = ((System.Drawing.Image)(resources.GetObject("tSbtOpenMeTag.Image")));
            this.tSbtOpenMeTag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtOpenMeTag.Name = "tSbtOpenMeTag";
            this.tSbtOpenMeTag.Size = new System.Drawing.Size(119, 22);
            this.tSbtOpenMeTag.Text = "Open With MeTag";
            this.tSbtOpenMeTag.Click += new System.EventHandler(this.tSbtOpenMeTag_Click);
            // 
            // tSbtSettings
            // 
            this.tSbtSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSbtSettings.Image = ((System.Drawing.Image)(resources.GetObject("tSbtSettings.Image")));
            this.tSbtSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtSettings.Name = "tSbtSettings";
            this.tSbtSettings.Size = new System.Drawing.Size(67, 22);
            this.tSbtSettings.Text = "Settings...";
            this.tSbtSettings.Click += new System.EventHandler(this.tSbtSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.tSTools);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.tbCFilter.ResumeLayout(false);
            this.tPTagFilter.ResumeLayout(false);
            this.tPTagFilter.PerformLayout();
            this.gBTextMatchMethod.ResumeLayout(false);
            this.gBTextMatchMethod.PerformLayout();
            this.tPDocFilter.ResumeLayout(false);
            this.tPDocFilter.PerformLayout();
            this.splitRight.Panel1.ResumeLayout(false);
            this.splitRight.Panel2.ResumeLayout(false);
            this.splitRight.ResumeLayout(false);
            this.tSTools.ResumeLayout(false);
            this.tSTools.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            this.splitMain.ResumeLayout(false);
            this.splitLeft.Panel1.ResumeLayout(false);
            this.splitLeft.Panel2.ResumeLayout(false);
            this.splitLeft.ResumeLayout(false);
            this.gBOtherProperty.ResumeLayout(false);
            this.gBOtherProperty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbCFilter;
        private System.Windows.Forms.TabPage tPTagFilter;
        private System.Windows.Forms.TabPage tPDocFilter;
        private System.Windows.Forms.ListView lVTag;
        private System.Windows.Forms.ColumnHeader colTagName;
        private System.Windows.Forms.ColumnHeader colTagValue;
        private System.Windows.Forms.ColumnHeader colDocName;
        private System.Windows.Forms.ToolStrip tSTools;
        private System.Windows.Forms.ToolStripButton tSbtImport;
        private System.Windows.Forms.SplitContainer splitRight;
        private System.Windows.Forms.ListView lVFileAttribute;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.RichTextBox rTBDoc;
        private System.Windows.Forms.ComboBox cBTagName;
        private System.Windows.Forms.ColumnHeader colTagText;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.SplitContainer splitLeft;
        private System.Windows.Forms.Button btTagReset;
        private System.Windows.Forms.Button btTagFilterNew;
        private System.Windows.Forms.RadioButton rBTextEndWith;
        private System.Windows.Forms.RadioButton rBTextStartWith;
        private System.Windows.Forms.RadioButton rBTextContain;
        private System.Windows.Forms.RadioButton rBTextExact;
        private System.Windows.Forms.TextBox tBTagText;
        private System.Windows.Forms.ComboBox cbTagValue;
        private System.Windows.Forms.GroupBox gBTextMatchMethod;
        private System.Windows.Forms.Button btTagFilterResult;
        private System.Windows.Forms.Button btDocFilterResult;
        private System.Windows.Forms.Button btDocReset;
        private System.Windows.Forms.Button btDocFilterNew;
        private System.Windows.Forms.TextBox tBDocPropName;
        private System.Windows.Forms.ComboBox cBDocIntent;
        private System.Windows.Forms.ComboBox cBDocType;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox gBOtherProperty;
        private System.Windows.Forms.TextBox tBDocPropValue;
        private System.Windows.Forms.ToolStripButton tSbtOpenMeTag;
        private System.Windows.Forms.ToolStripButton tSbtSettings;
    }
}

