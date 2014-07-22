namespace MeTagWinForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSbtOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSbtSave = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbType = new System.Windows.Forms.Label();
            this.cBType = new System.Windows.Forms.ComboBox();
            this.cbIntent = new System.Windows.Forms.ComboBox();
            this.cBPurpose = new System.Windows.Forms.ComboBox();
            this.cBDestination = new System.Windows.Forms.ComboBox();
            this.cBBeforeTravel = new System.Windows.Forms.ComboBox();
            this.cBDuringTravel = new System.Windows.Forms.ComboBox();
            this.cBAfterTravel = new System.Windows.Forms.ComboBox();
            this.cBTime = new System.Windows.Forms.ComboBox();
            this.lbPurpose = new System.Windows.Forms.Label();
            this.lbIntent = new System.Windows.Forms.Label();
            this.lbDestination = new System.Windows.Forms.Label();
            this.lbAttender = new System.Windows.Forms.Label();
            this.lbTransport = new System.Windows.Forms.Label();
            this.lbBeforeTravel = new System.Windows.Forms.Label();
            this.lbDuringTravel = new System.Windows.Forms.Label();
            this.lbAfterTravel = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.rTBDoc = new System.Windows.Forms.RichTextBox();
            this.tSBHistoryList = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSbtOpen,
            this.tSbtSave,
            this.toolStripSeparator1,
            this.tSBHistoryList});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(574, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSbtOpen
            // 
            this.tSbtOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSbtOpen.Image = ((System.Drawing.Image)(resources.GetObject("tSbtOpen.Image")));
            this.tSbtOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtOpen.Name = "tSbtOpen";
            this.tSbtOpen.Size = new System.Drawing.Size(44, 22);
            this.tSbtOpen.Text = "Open";
            this.tSbtOpen.Click += new System.EventHandler(this.tSbtOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tSbtSave
            // 
            this.tSbtSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSbtSave.Image = ((System.Drawing.Image)(resources.GetObject("tSbtSave.Image")));
            this.tSbtSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSbtSave.Name = "tSbtSave";
            this.tSbtSave.Size = new System.Drawing.Size(39, 22);
            this.tSbtSave.Text = "Save";
            this.tSbtSave.Click += new System.EventHandler(this.tSbtSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.lbType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cBType, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbIntent, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cBPurpose, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cBDestination, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cBBeforeTravel, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.cBDuringTravel, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.cBAfterTravel, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.cBTime, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.lbPurpose, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbIntent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbDestination, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbAttender, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbTransport, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbBeforeTravel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbDuringTravel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lbAfterTravel, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbTime, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lbMessage, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.rTBDoc, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 389);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.BackColor = System.Drawing.SystemColors.Control;
            this.lbType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbType.Location = new System.Drawing.Point(277, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(144, 30);
            this.lbType.TabIndex = 0;
            this.lbType.Text = "type:";
            this.lbType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cBType
            // 
            this.cBType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBType.FormattingEnabled = true;
            this.cBType.Items.AddRange(new object[] {
            "tour",
            "rest",
            "backpacks",
            "business"});
            this.cBType.Location = new System.Drawing.Point(429, 5);
            this.cBType.Margin = new System.Windows.Forms.Padding(5);
            this.cBType.Name = "cBType";
            this.cBType.Size = new System.Drawing.Size(140, 20);
            this.cBType.TabIndex = 1;
            // 
            // cbIntent
            // 
            this.cbIntent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIntent.FormattingEnabled = true;
            this.cbIntent.Items.AddRange(new object[] {
            "positive",
            "neutual",
            "negative"});
            this.cbIntent.Location = new System.Drawing.Point(429, 35);
            this.cbIntent.Margin = new System.Windows.Forms.Padding(5);
            this.cbIntent.Name = "cbIntent";
            this.cbIntent.Size = new System.Drawing.Size(140, 20);
            this.cbIntent.TabIndex = 3;
            // 
            // cBPurpose
            // 
            this.cBPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBPurpose.FormattingEnabled = true;
            this.cBPurpose.Items.AddRange(new object[] {
            "personal",
            "public"});
            this.cBPurpose.Location = new System.Drawing.Point(429, 65);
            this.cBPurpose.Margin = new System.Windows.Forms.Padding(5);
            this.cBPurpose.Name = "cBPurpose";
            this.cBPurpose.Size = new System.Drawing.Size(140, 20);
            this.cBPurpose.TabIndex = 4;
            this.cBPurpose.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rTBDoc_KeyUp);
            // 
            // cBDestination
            // 
            this.cBDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBDestination.FormattingEnabled = true;
            this.cBDestination.Items.AddRange(new object[] {
            "country",
            "city",
            "hotel",
            "attraction"});
            this.cBDestination.Location = new System.Drawing.Point(429, 95);
            this.cBDestination.Margin = new System.Windows.Forms.Padding(5);
            this.cBDestination.Name = "cBDestination";
            this.cBDestination.Size = new System.Drawing.Size(140, 20);
            this.cBDestination.TabIndex = 5;
            this.cBDestination.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rTBDoc_KeyUp);
            // 
            // cBBeforeTravel
            // 
            this.cBBeforeTravel.FormattingEnabled = true;
            this.cBBeforeTravel.Location = new System.Drawing.Point(429, 185);
            this.cBBeforeTravel.Margin = new System.Windows.Forms.Padding(5);
            this.cBBeforeTravel.Name = "cBBeforeTravel";
            this.cBBeforeTravel.Size = new System.Drawing.Size(140, 20);
            this.cBBeforeTravel.TabIndex = 6;
            this.cBBeforeTravel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rTBDoc_KeyUp);
            // 
            // cBDuringTravel
            // 
            this.cBDuringTravel.FormattingEnabled = true;
            this.cBDuringTravel.Location = new System.Drawing.Point(429, 215);
            this.cBDuringTravel.Margin = new System.Windows.Forms.Padding(5);
            this.cBDuringTravel.Name = "cBDuringTravel";
            this.cBDuringTravel.Size = new System.Drawing.Size(140, 20);
            this.cBDuringTravel.TabIndex = 7;
            this.cBDuringTravel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rTBDoc_KeyUp);
            // 
            // cBAfterTravel
            // 
            this.cBAfterTravel.FormattingEnabled = true;
            this.cBAfterTravel.Location = new System.Drawing.Point(429, 245);
            this.cBAfterTravel.Margin = new System.Windows.Forms.Padding(5);
            this.cBAfterTravel.Name = "cBAfterTravel";
            this.cBAfterTravel.Size = new System.Drawing.Size(140, 20);
            this.cBAfterTravel.TabIndex = 6;
            this.cBAfterTravel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rTBDoc_KeyUp);
            // 
            // cBTime
            // 
            this.cBTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTime.FormattingEnabled = true;
            this.cBTime.Items.AddRange(new object[] {
            "time",
            "period"});
            this.cBTime.Location = new System.Drawing.Point(429, 275);
            this.cBTime.Margin = new System.Windows.Forms.Padding(5);
            this.cBTime.Name = "cBTime";
            this.cBTime.Size = new System.Drawing.Size(140, 20);
            this.cBTime.TabIndex = 8;
            this.cBTime.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rTBDoc_KeyUp);
            // 
            // lbPurpose
            // 
            this.lbPurpose.AutoSize = true;
            this.lbPurpose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lbPurpose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPurpose.Location = new System.Drawing.Point(277, 60);
            this.lbPurpose.Name = "lbPurpose";
            this.lbPurpose.Size = new System.Drawing.Size(144, 30);
            this.lbPurpose.TabIndex = 2;
            this.lbPurpose.Text = "[F1]purpose:";
            this.lbPurpose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbIntent
            // 
            this.lbIntent.AutoSize = true;
            this.lbIntent.BackColor = System.Drawing.SystemColors.Control;
            this.lbIntent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbIntent.Location = new System.Drawing.Point(277, 30);
            this.lbIntent.Name = "lbIntent";
            this.lbIntent.Size = new System.Drawing.Size(144, 30);
            this.lbIntent.TabIndex = 9;
            this.lbIntent.Text = "intent:";
            this.lbIntent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDestination
            // 
            this.lbDestination.AutoSize = true;
            this.lbDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(136)))));
            this.lbDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDestination.Location = new System.Drawing.Point(277, 90);
            this.lbDestination.Name = "lbDestination";
            this.lbDestination.Size = new System.Drawing.Size(144, 30);
            this.lbDestination.TabIndex = 10;
            this.lbDestination.Text = "[F2]destination";
            this.lbDestination.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbAttender
            // 
            this.lbAttender.AutoSize = true;
            this.lbAttender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(136)))));
            this.lbAttender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAttender.Location = new System.Drawing.Point(277, 120);
            this.lbAttender.Name = "lbAttender";
            this.lbAttender.Size = new System.Drawing.Size(144, 30);
            this.lbAttender.TabIndex = 11;
            this.lbAttender.Text = "[F3]attender:";
            this.lbAttender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTransport
            // 
            this.lbTransport.AutoSize = true;
            this.lbTransport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(255)))), ((int)(((byte)(136)))));
            this.lbTransport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTransport.Location = new System.Drawing.Point(277, 150);
            this.lbTransport.Name = "lbTransport";
            this.lbTransport.Size = new System.Drawing.Size(144, 30);
            this.lbTransport.TabIndex = 12;
            this.lbTransport.Text = "[F4]transport:";
            this.lbTransport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbBeforeTravel
            // 
            this.lbBeforeTravel.AutoSize = true;
            this.lbBeforeTravel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbBeforeTravel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBeforeTravel.Location = new System.Drawing.Point(277, 180);
            this.lbBeforeTravel.Name = "lbBeforeTravel";
            this.lbBeforeTravel.Size = new System.Drawing.Size(144, 30);
            this.lbBeforeTravel.TabIndex = 13;
            this.lbBeforeTravel.Text = "[F5]beforetravel";
            this.lbBeforeTravel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDuringTravel
            // 
            this.lbDuringTravel.AutoSize = true;
            this.lbDuringTravel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.lbDuringTravel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDuringTravel.Location = new System.Drawing.Point(277, 210);
            this.lbDuringTravel.Name = "lbDuringTravel";
            this.lbDuringTravel.Size = new System.Drawing.Size(144, 30);
            this.lbDuringTravel.TabIndex = 12;
            this.lbDuringTravel.Text = "[F6]duringtravel:";
            this.lbDuringTravel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbAfterTravel
            // 
            this.lbAfterTravel.AutoSize = true;
            this.lbAfterTravel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lbAfterTravel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAfterTravel.Location = new System.Drawing.Point(277, 240);
            this.lbAfterTravel.Name = "lbAfterTravel";
            this.lbAfterTravel.Size = new System.Drawing.Size(144, 30);
            this.lbAfterTravel.TabIndex = 14;
            this.lbAfterTravel.Text = "[F7]aftertravel:";
            this.lbAfterTravel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTime.Location = new System.Drawing.Point(277, 270);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(144, 30);
            this.lbTime.TabIndex = 15;
            this.lbTime.Text = "[F8]time:";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbMessage, 2);
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMessage.Location = new System.Drawing.Point(277, 300);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(294, 89);
            this.lbMessage.TabIndex = 16;
            this.lbMessage.Text = "Message";
            // 
            // rTBDoc
            // 
            this.rTBDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBDoc.HideSelection = false;
            this.rTBDoc.Location = new System.Drawing.Point(3, 3);
            this.rTBDoc.Name = "rTBDoc";
            this.rTBDoc.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.rTBDoc, 11);
            this.rTBDoc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rTBDoc.Size = new System.Drawing.Size(268, 383);
            this.rTBDoc.TabIndex = 17;
            this.rTBDoc.Text = "";
            this.rTBDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rTBDoc_KeyDown);
            this.rTBDoc.SelectionChanged += new System.EventHandler(this.rTBDoc_SelectionChanged);
            this.rTBDoc.MouseEnter += new System.EventHandler(this.rTBDoc_MouseEnter);
            this.rTBDoc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rTBDoc_KeyUp);
            // 
            // tSBHistoryList
            // 
            this.tSBHistoryList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSBHistoryList.Image = ((System.Drawing.Image)(resources.GetObject("tSBHistoryList.Image")));
            this.tSBHistoryList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSBHistoryList.Name = "tSBHistoryList";
            this.tSBHistoryList.Size = new System.Drawing.Size(88, 22);
            this.tSBHistoryList.Text = "Show History";
            this.tSBHistoryList.Click += new System.EventHandler(this.tSBHistoryList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 414);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSbtOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tSbtSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cBType;
        private System.Windows.Forms.ComboBox cbIntent;
        private System.Windows.Forms.ComboBox cBPurpose;
        private System.Windows.Forms.ComboBox cBDestination;
        private System.Windows.Forms.ComboBox cBBeforeTravel;
        private System.Windows.Forms.ComboBox cBDuringTravel;
        private System.Windows.Forms.ComboBox cBAfterTravel;
        private System.Windows.Forms.ComboBox cBTime;
        private System.Windows.Forms.Label lbPurpose;
        private System.Windows.Forms.Label lbIntent;
        private System.Windows.Forms.Label lbDestination;
        private System.Windows.Forms.Label lbAttender;
        private System.Windows.Forms.Label lbTransport;
        private System.Windows.Forms.Label lbBeforeTravel;
        private System.Windows.Forms.Label lbDuringTravel;
        private System.Windows.Forms.Label lbAfterTravel;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.RichTextBox rTBDoc;
        private System.Windows.Forms.ToolStripButton tSBHistoryList;
    }
}

