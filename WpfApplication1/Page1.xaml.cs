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

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private bool command_enable;

        public Page1()
        {
            InitializeComponent();
            command_enable = true;
            ApplicationCommands.New.Text = "llllll";
            CommandBinding binding = new CommandBinding(ApplicationCommands.New);            
            binding.Executed += OnNew;
            binding.CanExecute += OnCanExecute;
            CommandBindings.Add(binding);            
        }

        private void OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = command_enable;
        }

        private void OnNew(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //ApplicationCommands.New.
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            command_enable = false;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            command_enable = true;
        }
    }
}
