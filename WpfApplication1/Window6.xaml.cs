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
    /// Логика взаимодействия для Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void TextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
           /*TextBox tb = sender as TextBox;
            DragDrop.DoDragDrop(tb, tb.Text, DragDropEffects.Copy);*/
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label lb = sender as Label;
            DragDrop.DoDragDrop(lb, lb.Content, DragDropEffects.All);
        }

        private void TextBox_Drop(object sender, DragEventArgs e)
        {
            
        }

        private void TextBox_DragEnter(object sender, DragEventArgs e)
        {
            MessageBox.Show(e.Data.ToString());
        }

        private void Label_DragEnter(object sender, DragEventArgs e)
        {
            //MessageBox.Show(e.Data.ToString());
        }

        private void Label_Drop(object sender, DragEventArgs e)
        {
            Label lb = e.OriginalSource as Label;
            lb1.Content = lb.Content;
        }
    }
}
