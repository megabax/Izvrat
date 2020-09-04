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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public static Color color;

        public Window3()
        {
            InitializeComponent();
            label.Content = (RenderCapability.Tier >> 16);     
            color=Colors.Red;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush();
            GradientStop gs1 = new GradientStop(Colors.Yellow, 0.3);
            GradientStop gs2 = new GradientStop(Colors.Red, 0.7);
            GradientStop gs3 = new GradientStop(Colors.Blue, 1);
            brush.GradientStops.Clear();
            brush.GradientStops.Add(gs1);
            brush.GradientStops.Add(gs2);
            brush.GradientStops.Add(gs3);
            grid.Background = brush;
           // brush.InvalidateProperty()
        }
    }
}
