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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            new Presenter(this);
        }

        public event EventHandler PlusEvent = null;
        public event EventHandler MinusEvent = null;
        public event EventHandler MultiplyEvent = null;
        public event EventHandler DivideEvent = null;


        public void plus(object sender, RoutedEventArgs e)
        {
            PlusEvent.Invoke(sender, e);
        }

        public void minus(object sender, RoutedEventArgs e)
        {
            MinusEvent.Invoke(sender, e);
        }

        public void mult(object sender, RoutedEventArgs e)
        {
            MultiplyEvent.Invoke(sender, e);
        }

        public void div(object sender, RoutedEventArgs e)
        {
            DivideEvent.Invoke(sender, e);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
