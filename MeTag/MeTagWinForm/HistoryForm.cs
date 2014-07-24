using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MeTagWinForm
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RefreshHistoryList(List<HistoryNode> historyList)
        {
            lVHistory.Items.Clear();
            if (historyList == null || historyList.Count == 0) return;
            int lastIndex = historyList.Count - 1;
            for (int i = 0; i < lastIndex; i++)
            {
                ListViewItem newItem = lVHistory.Items.Add(i.ToString());
                newItem.SubItems.Add(historyList[i].loadDateTime.ToString("yyyy-MM-dd hh:mm:ss"));
                newItem.SubItems.Add(historyList[i].saveDateTime.ToString("yyyy-MM-dd hh:mm:ss"));
                newItem.SubItems.Add(historyList[i].computerName);
            }
            ListViewItem lastItem = lVHistory.Items.Add("*");
            lastItem.SubItems.Add(historyList[lastIndex].loadDateTime.ToString("yyyy-MM-dd hh:mm:ss"));
            lastItem.SubItems.Add("-");
            lastItem.SubItems.Add(historyList[lastIndex].computerName);
        }
    }
}
