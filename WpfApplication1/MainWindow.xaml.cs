using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApplication1
{
   
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
       
        DispatcherTimer timer =new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            
            this.btUn.Click += BtUn_Click;
            timer.Interval = new TimeSpan(1000);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TestDispatcher obj = new TestDispatcher();
            obj.UpdateUiHandler += Obj_UpdateUiHandler;
            obj.Update();
        }

        private void BtUn_Click(object sender, RoutedEventArgs e)
        {
           //obj.Update();
        }

        private void Obj_UpdateUiHandler(object sender, EventMy e)
        {
            this.tbBox.Text = e.Text;
        }
    }

}