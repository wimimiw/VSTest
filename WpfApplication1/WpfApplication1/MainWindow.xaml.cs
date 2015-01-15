using System;
using System.Collections.Generic;
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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.label1.Content = "asd";

            System.IO.Ports.SerialPort ff = new System.IO.Ports.SerialPort();

            Window1 wdw = new Window1();
            wdw.ShowDialog();            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.textBox1.Text += "abc\n";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Timers.Timer tmr = new System.Timers.Timer();
            tmr.Interval = 1000;
            tmr.Elapsed += new System.Timers.ElapsedEventHandler(tmr_Elapsed);
            tmr.Enabled = true;
        }

        private delegate void UpdateTimer();

        void tmr_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new UpdateTimer(delegate { this.textBlock1.Text = DateTime.Now.ToLongTimeString(); }));      
            //throw new NotImplementedException();
        }
    }
}
