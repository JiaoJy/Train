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

namespace Train.Adminstrator2
{
    /// <summary>
    /// Interaction logic for AdEnter.xaml
    /// </summary>
    public partial class AdEnter : Page
    {
        public static string a;
        public static string b;
        public AdEnter()
        {
            InitializeComponent();
            
        }      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            t1.Text = "";
            p2.Password = "";
            //AddTo page = new AddTo();
           // NavigationService ns = NavigationService.GetNavigationService(this);
            //ns.Navigate(page);
        }

        private void t1_TextChanged(object sender, TextChangedEventArgs e)
        {
            a = t1.Text;
        }

        private void p2_TextInput(object sender, TextCompositionEventArgs e)
        {
            b = p2.Password;
        }
    }
}
