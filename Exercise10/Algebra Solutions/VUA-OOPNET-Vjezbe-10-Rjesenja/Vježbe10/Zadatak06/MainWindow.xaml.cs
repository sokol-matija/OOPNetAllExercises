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

namespace Zadatak06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();

            StackPanel sp = new StackPanel();
            sp.Width = 20;
            sp.Height = 20;
            sp.Margin = new Thickness(3);
            Color c = Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256));
            sp.Background = new SolidColorBrush(c);
            // LayoutTransform prilikom rotacije uzima u ozbir raspodjelu elemenata
            sp.LayoutTransform = new RotateTransform(r.Next(0, 361));

            pnlContainer.Children.Add(sp);
        }

        private void btnUkloni_Click(object sender, RoutedEventArgs e)
        {
            pnlContainer.Children.Clear();
        }
    }
}
