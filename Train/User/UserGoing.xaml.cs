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

namespace Train.User
{
    /// <summary>
    /// Interaction logic for UserGoing.xaml
    /// </summary>
    public partial class UserGoing : Window
    {
        public UserGoing()
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            f1.Navigate(new Uri("/User/Add1.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new Uri("/User/Add1.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            f1.Navigate(new Uri("/User/SpendMoneyTo.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new Uri("/User/Delet.xaml", UriKind.Relative));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TrainSy t = new TrainSy();
            t.Show();
            this.Close();
        }      
    }
}
