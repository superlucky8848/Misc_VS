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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.tbCFilter = new System.Windows.Forms.TabControl();
            this.tPTagFilter = new System.Windows.Forms.TabPage();
            this.tPDocFilter = new System.Windows.Forms.TabPage();
            this.lVTag = new System.Windows.Forms.ListView();
            this.tSTools = new System.Windows.Forms.ToolStrip();
            this.colTagName = new System.Windows.Forms.ColumnHeader();
            this.colTagValue = new System.Windows.Forms.ColumnHeader();
            this.colDocName = new System.Windows.Forms.ColumnHeader();
            this.tSbtImport = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbFileName = new System.Windows.Forms.Label();
            this.lVFileAttribute = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colValue = new System.Windows.Forms.ColumnHeader();
            this.rTBDoc = new System.Windows.Forms.RichTextBox();
            this.tLPMain.SuspendLayout();
            this.tbCFilter.SuspendLayout();
            this.tSTools.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPMain
            // 
            this.tLPMain.ColumnCount = 2;
            this.tLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPMain.Controls.Add(this.tbCFilter, 0, 1);
            this.tLPMain.Controls.Add(this.lVTag, 0, 0);
            this.tLPMain.Controls.Add(this.splitContainer1, 1, 0);
            this.tLPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPMain.Location = new System.Drawing.Point(0, 25);
            this.tLPMain.Name = "tLPMain";
            this.tLPMain.RowCount = 2;
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tLPMain.Size = new System.Drawing.Size(633, 517);
            this.tLPMain.TabIndex = 0;
            // 
            // tbCFilter
            // 
            this.tbCFilter.Controls.Add(this.tPTagFilter);
            this.tbCFilter.Controls.Add(this.tPDocFilter);
            this.tbCFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCFilter.Location = new System.Drawing.Point(3, 320);
            this.tbCFilter.Name = "tbCFilter";
            this.tbCFilter.SelectedIndex = 0;
            this.tbCFilter.Size = new System.Drawing.Size(294, 194);
            this.tbCFilter.TabIndex = 0;
            // 
            // tPTagFilter
            // 
            this.tPTagFilter.Location = new System.Drawing.Point(4, 22);
            this.tPTagFilter.Name = "tPTagFilter";
            this.tPTagFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tPTagFilter.Size = new System.Drawing.Size(286, 168);
            this.tPTagFilter.TabIndex = 0;
            this.tPTagFilter.Text = "Tag Filter";
            this.tPTagFilter.UseVisualStyleBackColor = true;
            // 
            // tPDocFilter
            // 
            this.tPDocFilter.Location = new System.Drawing.Point(4, 22);
            this.tPDocFilter.Name = "tPDocFilter";
            this.tPDocFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tPDocFilter.Size = new System.Drawing.Size(623, 168);
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
            this.colDocName});
            this.lVTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lVTag.FullRowSelect = true;
            this.lVTag.Location = new System.Drawing.Point(3, 3);
            this.lVTag.Name = "lVTag";
            this.lVTag.Size = new System.Drawing.Size(294, 311);
            this.lVTag.TabIndex = 1;
            this.lVTag.UseCompatibleStateImageBehavior = false;
            this.lVTag.View = System.Windows.Forms.View.Details;
            this.lVTag.DragDrop += new System.Windows.Forms.DragEventHandler(this.lVTag_DragDrop);
            this.lVTag.DragEnter += new System.Windows.Forms.DragEventHandler(this.lVTag_DragEnter);
            // 
            // tSTools
            // 
            this.tSTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSbtImport});
            this.tSTools.Location = new System.Drawing.Point(0, 0);
            this.tSTools.Name = "tSTools";
            this.tSTools.Size = new System.Drawing.Size(633, 25);
            this.tSTools.TabIndex = 1;
            this.tSTools.Text = "toolStrip1";
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
            // colDocName
            // 
            this.colDocName.Text = "Doc";
            this.colDocName.Width = 100;
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(303, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lVFileAttribute);
            this.splitContainer1.Panel1.Controls.Add(this.lbFileName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rTBDoc);
            this.tLPMain.SetRowSpan(this.splitContainer1, 2);
            this.splitContainer1.Size = new System.Drawing.Size(327, 511);
            this.splitContainer1.SplitterDistance = 105;
            this.splitContainer1.TabIndex = 2;
            // 
            // lbFileName
            // 
            this.lbFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbFileName.Location = new System.Drawing.Point(0, 0);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(327, 12);
            this.lbFileName.TabIndex = 0;
            this.lbFileName.Text = "No doc selected";
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
            this.lVFileAttribute.Size = new System.Drawing.Size(327, 93);
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
            // rTBDoc
            // 
            this.rTBDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBDoc.Location = new System.Drawing.Point(0, 0);
            this.rTBDoc.Name = "rTBDoc";
            this.rTBDoc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rTBDoc.Size = new System.Drawing.Size(327, 402);
            this.rTBDoc.TabIndex = 0;
            this.rTBDoc.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 542);
            this.Controls.Add(this.tLPMain);
            this.Controls.Add(this.tSTools);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tLPMain.ResumeLayout(false);
            this.tbCFilter.ResumeLayout(false);
            this.tSTools.ResumeLayout(false);
            this.tSTools.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPMain;
        private System.Windows.Forms.TabControl tbCFilter;
        private System.Windows.Forms.TabPage tPTagFilter;
        private System.Windows.Forms.TabPage tPDocFilter;
        private System.Windows.Forms.ListView lVTag;
        private System.Windows.Forms.ColumnHeader colTagName;
        private System.Windows.Forms.ColumnHeader colTagValue;
        private System.Windows.Forms.ColumnHeader colDocName;
        private System.Windows.Forms.ToolStrip tSTools;
        private System.Windows.Forms.ToolStripButton tSbtImport;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lVFileAttribute;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colValue;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.RichTextBox rTBDoc;
    }
}

