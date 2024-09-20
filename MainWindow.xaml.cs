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

namespace Homework3_Part2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            int cents = (int)slVal.Value;
            slLabel.Content = cents.ToString();

            int quarters = cents / 25;
            cents %= 25;

            int dimes = cents / 10;
            cents %= 10;

            int nickels = cents/5;
            cents %= 5;

            label.Content = "You have bought an item for "+ slLabel.Content + " cents, so your change is";
            q.Content = quarters.ToString() + " Quarters";
            d.Content = dimes.ToString() + " Dimes";
            n.Content = nickels.ToString() + " Nickels";
        }
    }
}