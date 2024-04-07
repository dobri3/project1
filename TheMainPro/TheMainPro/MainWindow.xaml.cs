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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainCore.MainFrameCore = MainFrame;
            MainFrame.Navigate(new Page1());
        }

        private void Button_Click(object sender, EventArgs e)
        {


            //        const string message =
            //"Вы уверены, что хотите выйти? Ответы могут не сохраниться";           
            //    DialogResult result = MessageBox.Show(message, MessageBoxButtons.YesNo);

            //// If the no button was pressed ...
            //if (result == DialogResult.No)
            //{
            //    // cancel the closure of the form.
            //    e.Cancel = true;
        //}
                Application.Current.Shutdown();

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainCore.MainFrameCore.Navigate(new Page1());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainCore.MainFrameCore.Navigate(new Page2());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }
    }
}
