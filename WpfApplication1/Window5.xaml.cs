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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        private bool state;

        private BitmapImage act;

        private BitmapImage stp;

        public Window5()
        {
            InitializeComponent();

            act = new BitmapImage();
            act.BeginInit();
            act.UriSource = new Uri("BotActive.png", UriKind.Relative);
            act.EndInit();

            stp = new BitmapImage();
            stp.BeginInit();
            stp.UriSource = new Uri("BotStop.png", UriKind.Relative);
            stp.EndInit();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            /*Button btn = new Button();
            btn.Content = "sdfsdfdsf";
            //spXXXXX.Children.Add(btn);*/
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("dddddddddd");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sdccvxcv");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(num.Text);
        }

        private void num_TextInput(object sender, TextCompositionEventArgs e)
        {
            MessageBox.Show("num_TextInput: "+num.Text);
        }

        private void num_TextChanged(object sender, TextChangedEventArgs e)
        {
            MessageBox.Show("num_TextChanged: " + num.Text);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (state)
            {
                imImage.Source = act;
            }
            else
            {
                imImage.Source = stp;
            }
            state = !state;                
        }
    }
}
