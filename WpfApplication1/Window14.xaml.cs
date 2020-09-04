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
    /// Логика взаимодействия для Window14.xaml
    /// </summary>
    public partial class Window14 : Window
    {
        public Window14()
        {
            InitializeComponent();
        }

        private void MyBtn_Click(object sender, RoutedEventArgs e)
        {
            MyBtn.Style = (Style)FindResource("MyStyle");
        }

        private void mouse_enter(object sender, MouseEventArgs e)
        {
            (sender as Control).BorderThickness = new Thickness(3);
        }

        private void mouse_leave(object sender, MouseEventArgs e)
        {
            (sender as Control).BorderThickness = new Thickness(0);
        }
    }
}
