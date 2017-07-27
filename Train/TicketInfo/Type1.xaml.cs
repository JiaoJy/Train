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

namespace Train.TicketOver
{
    /// <summary>
    /// Type.xaml 的交互逻辑
    /// </summary>
    public partial class Type1 : Page
    {
        BuyT bt;
        public Type1(BuyT bt)
        {
            InitializeComponent();
            this.bt = bt;
            if (bt.selected)
            {
                numl.Text = bt.numline.Text;
            }
            else
            {
                numl.IsEnabled = true;
                bt.end1.Content = "null";
            }
            bt.numline.Text = numl.Text;
        }

        private void r1_Checked(object sender, RoutedEventArgs e)
        {
            bt.numline.Text = numl.Text;
            RadioButton ra = sender as RadioButton;
            switch (ra.Content.ToString())
            {
                case "单程票":
                    bt.ptype.Content = "单程票";
                    break;
                case "双程票":
                    bt.ptype.Content = "双程票";
                    break;
                default:
                    break;
            }

        }

        private void numl_TextChanged(object sender, TextChangedEventArgs e)
        {
            bt.numline.Text = numl.Text;
        }
    }
}
