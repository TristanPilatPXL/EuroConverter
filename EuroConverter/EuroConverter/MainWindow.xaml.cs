using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EuroConverter
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

        private void delete(object sender, RoutedEventArgs e)
        {
            
            euro.Text = string.Empty;
            frank.Text = string.Empty;
        }

        private void convert(object sender, RoutedEventArgs e)
        {
            euro.Foreground = Brushes.Black;


            if (double.TryParse(euro.Text, out double euroAmount))
            {
                double frankAmount = euroAmount * 40.3399;
                frank.Text = frankAmount.ToString("N2");
            }
            else
            {
                euro.Foreground = Brushes.Red;
            }
        }
    }
}