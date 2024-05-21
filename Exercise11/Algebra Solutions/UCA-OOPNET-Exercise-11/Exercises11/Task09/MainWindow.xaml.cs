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

namespace Task09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string BACKGROUND_1 = "background1",
            BACKGROUND_2 = "background2";
        private string currentBackground = BACKGROUND_1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Toggle();
        }

        private void Toggle()
        {
            string newBackground = (currentBackground == BACKGROUND_1) ?
                BACKGROUND_2 : BACKGROUND_1;
            currentBackground = newBackground;

            var brush = this.FindResource(newBackground) as RadialGradientBrush;

            foreach (Control ctrl in grid.Children)
            {
                if (ctrl is Button button)
                {
                    button.Background = brush;
                }
            }
        }
    }
}
