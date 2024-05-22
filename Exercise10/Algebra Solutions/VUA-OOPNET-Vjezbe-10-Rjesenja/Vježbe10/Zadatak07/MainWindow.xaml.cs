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

namespace Zadatak07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
            mojGrid.Background = GetRandomLinearGradientColor();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int brojRedaka = mojGrid.RowDefinitions.Count;
            int brojStupaca = mojGrid.ColumnDefinitions.Count;

            foreach (Button btn in mojGrid.Children)
            {
                int trenutniRedak = (int)btn.GetValue(Grid.RowProperty);
                int trenutniStupac = (int)btn.GetValue(Grid.ColumnProperty);

                //Provjeravaj da li je trenutna pozicija zadnji redak i zadnji stupac
                trenutniStupac++;
                if(trenutniStupac >= brojStupaca)
                {
                    trenutniStupac = 0;
                    trenutniRedak++;

                    if(trenutniRedak >= brojRedaka)
                    {
                        trenutniRedak = 0;
                    }
                }

                btn.SetValue(Grid.RowProperty, trenutniRedak);
                btn.SetValue(Grid.ColumnProperty, trenutniStupac);
            }

            mojGrid.Background = GetRandomLinearGradientColor();
        }

        private LinearGradientBrush GetRandomLinearGradientColor()
        {
            LinearGradientBrush lgb = new LinearGradientBrush();

            GradientStop stop1 = new GradientStop();
            stop1.Color = GetRandomColor();
            stop1.Offset = 0;

            GradientStop stop2 = new GradientStop();
            stop2.Color = GetRandomColor();
            stop2.Offset = 1;

            lgb.GradientStops.Add(stop1);
            lgb.GradientStops.Add(stop2);

            return lgb;
        }

        private Color GetRandomColor()
        {
            var R = (byte)rnd.Next(0, 255);
            var G = (byte)rnd.Next(0, 255);
            var B = (byte)rnd.Next(0, 255);

            return Color.FromArgb(255, R, G, B);
        }
    }
}
