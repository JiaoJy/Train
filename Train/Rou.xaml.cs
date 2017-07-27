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
    /// Interaction logic for Rou.xaml
    /// </summary>
    public partial class Rou : Window
    {
        public static int i;
        public Rou()
        {
            InitializeComponent();
            
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            f1.Content = new BuyT(this);
        }
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TrainSy t = new TrainSy();
            t.Show();
            this.Close();
        }
    }
}

