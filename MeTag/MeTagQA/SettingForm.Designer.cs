namespace MeTagQA
{
    partial class SettingForm
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
            System.Windows.Forms.Label label1;
            this.tBMeTagPath = new System.Windows.Forms.TextBox();
            this.btMeTagPath = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 12);
            label1.TabIndex = 0;
            label1.Text = "MeTag Path:";
            // 
            // tBMeTagPath
            // 
            this.tBMeTagPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tBMeTagPath.Location = new System.Drawing.Point(89, 6);
            this.tBMeTagPath.Name = "tBMeTagPath";
            this.tBMeTagPath.Size = new System.Drawing.Size(304, 21);
            this.tBMeTagPath.TabIndex = 1;
            // 
            // btMeTagPath
            // 
            this.btMeTagPath.Location = new System.Drawing.Point(399, 4);
            this.btMeTagPath.Name = "btMeTagPath";
            this.btMeTagPath.Size = new System.Drawing.Size(56, 23);
            this.btMeTagPath.TabIndex = 2;
            this.btMeTagPath.Text = "...";
            this.btMeTagPath.UseVisualStyleBackColor = true;
            this.btMeTagPath.Click += new System.EventHandler(this.btMeTagPath_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(297, 59);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(76, 32);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(379, 59);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(76, 32);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // SettingForm
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(467, 103);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btMeTagPath);
            this.Controls.Add(this.tBMeTagPath);
            this.Controls.Add(label1);
            this.Name = "SettingForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBMeTagPath;
        private System.Windows.Forms.Button btMeTagPath;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
    }
}