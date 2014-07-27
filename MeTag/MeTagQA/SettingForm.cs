using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MeTagQA
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void btMeTagPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofDlg = new OpenFileDialog())
            {
                ofDlg.FileName = tBMeTagPath.Text;
                ofDlg.Filter = "MeTag Application|MeTagWinForm.exe";
                ofDlg.Multiselect = false;

                if (ofDlg.ShowDialog() == DialogResult.OK)
                {
                    tBMeTagPath.Text = ofDlg.FileName;
                }
            }
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            tBMeTagPath.Text = Properties.Settings.Default.MeTagPath;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MeTagPath = tBMeTagPath.Text;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
