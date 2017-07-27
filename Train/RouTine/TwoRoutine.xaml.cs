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

namespace Train.RouTine
{
    /// <summary>
    /// Interaction logic for TwoRoutine.xaml
    /// </summary>
    public partial class TwoRoutine : Page
    {
        public static string s;
        BuyT bt;
        public string i;
        int a, b;
        Boolean first = false;
        public TwoRoutine(BuyT bt)
        {
            InitializeComponent();
            this.bt = bt;
            bt.start1.Content = "刘庄";
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel sta = sender as StackPanel;
            if (!first)
            {
                switch (sta.Name)
                {
                    case "sta1":
                        a = 0;
                        bt.start1.Content = TextBlock1.Text;
                        break;
                    case "sta2":
                        a = 1;
                        bt.start1.Content = TextBlock2.Text;
                        break;
                    case "sta3":
                        a = 2;
                        bt.start1.Content = TextBlock3.Text;
                        break;
                    case "sta4":
                        a = 3;
                        bt.start1.Content = TextBlock4.Text;
                        break;
                    case "sta5":
                        a = 4;
                        bt.start1.Content = TextBlock5.Text;
                        break;
                    case "sta6":
                        a = 5;
                        bt.start1.Content = TextBlock6.Text;
                        break;
                    case "sta7":
                        a = 6;
                        bt.start1.Content = TextBlock7.Text;
                        break;
                    case "sta8":
                        a = 7;
                        bt.start1.Content = TextBlock8.Text;
                        break;
                    case "sta9":
                        a = 8;
                        bt.start1.Content = TextBlock9.Text;
                        break;
                    case "sta10":
                        a = 9;
                        bt.start1.Content = TextBlock10.Text;
                        break;
                    case "sta11":
                        a = 10;
                        bt.start1.Content = TextBlock11.Text;
                        break;
                    case "sta12":
                        a = 11;
                        bt.start1.Content = TextBlock12.Text;
                        break;
                    case "sta13":
                        a = 12;
                        bt.start1.Content = TextBlock13.Text;
                        break;
                    case "sta14":
                        a = 13;
                        bt.start1.Content = TextBlock14.Text;
                        break;
                    case "sta15":
                        a = 14;
                        bt.start1.Content = TextBlock15.Text;
                        break;
                    default:
                        break;
                }
                first = true;
            }
            else
            {
                switch (sta.Name)
                {
                    case "sta1":
                        b = 0;
                        bt.end1.Content = TextBlock1.Text;
                        break;
                    case "sta2":
                        b = 1;
                        bt.end1.Content = TextBlock2.Text;
                        break;
                    case "sta3":
                        b = 2;
                        bt.end1.Content = TextBlock3.Text;
                        break;
                    case "sta4":
                        b = 3;
                        bt.end1.Content = TextBlock4.Text;
                        break;
                    case "sta5":
                        b = 4;
                        bt.end1.Content = TextBlock5.Text;
                        break;
                    case "sta6":
                        b = 5;
                        bt.end1.Content = TextBlock6.Text;
                        break;
                    case "sta7":
                        b = 6;
                        bt.end1.Content = TextBlock7.Text;
                        break;
                    case "sta8":
                        b = 7;
                        bt.end1.Content = TextBlock8.Text;
                        break;
                    case "sta9":
                        b = 8;
                        bt.end1.Content = TextBlock9.Text;
                        break;
                    case "sta10":
                        b = 9;
                        bt.end1.Content = TextBlock10.Text;
                        break;
                    case "sta11":
                        b = 10;
                        bt.end1.Content = TextBlock11.Text;
                        break;
                    case "sta12":
                        b = 11;
                        bt.end1.Content = TextBlock12.Text;
                        break;
                    case "sta13":
                        b = 12;
                        bt.end1.Content = TextBlock13.Text;
                        break;
                    case "sta14":
                        b = 13;
                        bt.end1.Content = TextBlock14.Text;
                        break;
                    case "sta15":
                        b = 14;
                        bt.end1.Content = TextBlock15.Text;
                        break;
                    default:
                        break;
                }
                first = false;
            }
            i = b - a + "";
            if (b < a)
            {
                i = a - b + "";
            }
            bt.numline.Text = i;
        }
    }
}
