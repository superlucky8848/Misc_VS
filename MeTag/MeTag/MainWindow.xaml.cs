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

namespace MeTag
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
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


    }
}
