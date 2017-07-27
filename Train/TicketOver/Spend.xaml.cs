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
using Train.TicketInfo;

namespace Train.TicketOver
{
    /// <summary>
    /// Interaction logic for Spend.xaml
    /// </summary>
    public partial class Spend : Page
    {
        public static int a;
        TicketBuy tb;
       public Spend(TicketBuy tb)
        {
            InitializeComponent();
            this.tb = tb;
            if (BuyT.chang)
            {
                this.Resources.MergedDictionaries.Remove(tb.path1);
                this.Resources.MergedDictionaries.Add(tb.path2);
            }
           
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tbt = sender as TextBox;
            switch (tbt.Name)
            {
                case "t1":
                    tb.uname.Content = t1.Text;
                    break;
                case "t2":
                    tb.uid.Content = t2.Text;
                    break;
            }
        }

        private void p1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            tb.upassw.Content = p1.Password;
        }
    }
}
