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

namespace Train
{
    /// <summary>
    /// Interaction logic for TrainSy.xaml
    /// </summary>
    public partial class TrainSy : Window
    {
        public TrainSy()
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Adminstrator2.Administ ad = new Adminstrator2.Administ();
            ad.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Rou ru = new Rou();
            ru.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
