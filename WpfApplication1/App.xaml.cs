using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnNavigationFailed(NavigationFailedEventArgs e)
        {
            base.OnNavigationFailed(e);
            MessageBox.Show(e.Uri + " " + e.Exception.Message);
            e.Handled = true;
        }
    }
}
