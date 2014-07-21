using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using Microsoft.Win32;

namespace MeTag
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private TagDoc curDoc = null;

        public MainWindow()
        {
            InitializeComponent();
            titleBar.MouseLeftButtonDown += (o, e) => DragMove();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbTitle.Text = "MeTag[v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "]";
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofDlg = new OpenFileDialog();
            ofDlg.DefaultExt = ".xml";
            ofDlg.Filter = "XML File|*.xml|All File|*.*";
            ofDlg.Multiselect = false;

            if (ofDlg.ShowDialog() == true)
            {
                curDoc = AppBase.LoadFile(ofDlg.FileName);
                if (curDoc == null) MessageBox.Show("Failed to load seleted file, check file format.");
                else
                {
                    rTBDoc.SelectAll();
                    rTBDoc.Selection.Text = curDoc.content;
                    rTBDoc.Selection.Select(rTBDoc.Document.ContentStart, rTBDoc.Document.ContentStart);
                    meTagControl.lbMessage.Text = String.Format("Message:\n Tilte:{0}\n Author:{1}\n URL:{2}\n ID:{3}", curDoc.title, curDoc.author, curDoc.url, curDoc.id);
                }
            }
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            curDoc.type = meTagControl.cbType.Text;
            curDoc.intent = meTagControl.cbIntent.Text;

            SaveFileDialog sfDlg = new SaveFileDialog();
            sfDlg.DefaultExt = "*.xml";
            sfDlg.Filter = "XML File|*.xml|All File|*.*";

            if (sfDlg.ShowDialog() == true)
            {
                if (AppBase.SaveFile(sfDlg.FileName, curDoc))
                    MessageBox.Show("Save successful", "Save file", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Save failed", "Save file", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void MainWindow_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.F1))
            {
                if (e.Delta < 0 && meTagControl.cbPurpose.SelectedIndex > 0) meTagControl.cbPurpose.SelectedIndex--;
                if (e.Delta > 0 && meTagControl.cbPurpose.SelectedIndex < meTagControl.cbPurpose.Items.Count) meTagControl.cbPurpose.SelectedIndex++;
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            BrushConverter bc = new  BrushConverter();
            if (e.Key == Key.F1)
            {
                string oriText = rTBDoc.Selection.Text;
                rTBDoc.Selection.Text = "<a>" + oriText + "</a>";
            }
            else if (e.Key == Key.F2)
            {
                TextPointer pt1 = rTBDoc.Document.ContentStart.GetPositionAtOffset(10);
                TextPointer pt2 = rTBDoc.Document.ContentStart.GetPositionAtOffset(15);
                rTBDoc.Selection.Select(pt1, pt2);
                rTBDoc.Selection.ApplyPropertyValue(RichTextBox.BackgroundProperty, "#FFBB88");
            }
        }

        private void rTBDoc_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.F1))
            {
                e.Handled = true;
                MouseWheelEventArgs eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
                eventArg.RoutedEvent = UIElement.MouseWheelEvent;
                eventArg.Source = sender;
                mainWin.RaiseEvent(eventArg);
            }
        }
    }
}
