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

namespace Train.RouTine
{
    /// <summary>
    /// Interaction logic for OneRutine.xaml
    /// </summary>
    public partial class OneRoutine : Page
    {
        public static String s;
        public string i;
        BuyT bt;
        Boolean first = false;
        int a, b;
        public OneRoutine(BuyT bt)
        {
            InitializeComponent();
            this.bt = bt;
            bt.start1.Content = "市体育中心";
        }

        private void st1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel sta = sender as StackPanel;
            if (!first)
            {
                switch (sta.Name)
                {
                    case "st1":
                        a = 0;
                        bt.start1.Content = TextBlock1.Text;
                        break;
                    case "st2":
                        a = 1;
                        bt.start1.Content = TextBlock2.Text;
                        break;
                    case "st3":
                        a = 2;
                        bt.start1.Content = TextBlock3.Text;
                        break;
                    case "st4":
                        a = 3;
                        bt.start1.Content = TextBlock4.Text;
                        break;
                    case "st5":
                        a = 4;
                        bt.start1.Content = TextBlock5.Text;
                        break;
                    case "st6":
                        a = 5;
                        bt.start1.Content = TextBlock6.Text;
                        break;
                    case "st7":
                        a = 6;
                        bt.start1.Content = TextBlock7.Text;
                        break;
                    case "st8":
                        a = 7;
                        bt.start1.Content = TextBlock8.Text;
                        break;
                    case "st9":
                        a = 8;
                        bt.start1.Content = TextBlock9.Text;
                        break;
                    case "st10":
                        a = 9;
                        bt.start1.Content = TextBlock10.Text;
                        break;
                    case "st11":
                        a = 10;
                        bt.start1.Content = TextBlock11.Text;
                        break;
                    case "st12":
                        a = 11;
                        bt.start1.Content = TextBlock12.Text;
                        break;
                    case "st13":
                        a = 12;
                        bt.start1.Content = TextBlock13.Text;
                        break;
                    case "st14":
                        a = 13;
                        bt.start1.Content = TextBlock14.Text;
                        break;
                    case "st15":
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
                    case "st1":
                        b = 0;
                        bt.end1.Content = TextBlock1.Text;
                        break;
                    case "st2":
                        b = 1;
                        bt.end1.Content = TextBlock2.Text;
                        break;
                    case "st3":
                        b = 2;
                        bt.end1.Content = TextBlock3.Text;
                        break;
                    case "st4":
                        b = 3;
                        bt.end1.Content = TextBlock4.Text;
                        break;
                    case "st5":
                        b = 4;
                        bt.end1.Content = TextBlock5.Text;
                        break;
                    case "st6":
                        b = 5;
                        bt.end1.Content = TextBlock6.Text;
                        break;
                    case "st7":
                        b = 6;
                        bt.end1.Content = TextBlock7.Text;
                        break;
                    case "st8":
                        b = 7;
                        bt.end1.Content = TextBlock8.Text;
                        break;
                    case "st9":
                        b = 8;
                        bt.end1.Content = TextBlock9.Text;
                        break;
                    case "st10":
                        b = 9;
                        bt.end1.Content = TextBlock10.Text;
                        break;
                    case "st11":
                        b = 10;
                        bt.end1.Content = TextBlock11.Text;
                        break;
                    case "st12":
                        b = 11;
                        bt.end1.Content = TextBlock12.Text;
                        break;
                    case "st13":
                        b = 12;
                        bt.end1.Content = TextBlock13.Text;
                        break;
                    case "st14":
                        b = 13;
                        bt.end1.Content = TextBlock14.Text;
                        break;
                    case "st15":
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

