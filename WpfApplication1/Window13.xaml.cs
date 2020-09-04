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
    /// Логика взаимодействия для Window13.xaml
    /// </summary>
    public partial class Window13 : Window
    {
        public Window13()
        {
            InitializeComponent();
        }

        private void tbLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(tbLogin.Text.Length==0)
            {
                tblHint.Visibility = Visibility.Visible;
            }
            else
            {
                tblHint.Visibility = Visibility.Hidden;
            }
        }

        private void tblHintPas_TextInput(object sender, TextCompositionEventArgs e)
        {
            //MessageBox.Show(e.Text);
        }

        private void tblHintPas_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void pbLoginPas_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pbLoginPas.Password.Length == 0)
            {
                tblHintPas.Visibility = Visibility.Visible;
            }
            else
            {
                tblHintPas.Visibility = Visibility.Hidden;
            }
            tblPasw.Text = pbLoginPas.Password;
        }
    }
}
