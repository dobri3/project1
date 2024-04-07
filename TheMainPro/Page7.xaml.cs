using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using TheMainPro.Core;

namespace TheMainPro
{
    /// <summary>
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void pg1_Click(object sender, RoutedEventArgs e)
        {
            MainCore.MainFrameCore.Navigate(new Page6());
        }
        private void pg2_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        

        private void answer_Checked(object sender, RoutedEventArgs e)
        {
            btn1.Background = Brushes.Red;
            btn2.Background = Brushes.Green;
            btn3.Background = Brushes.Red;
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            answer.IsEnabled = false;
        }
    }
}
