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
using Train.RouTine;

namespace Train.TicketInfo
{
    /// <summary>
    /// Interaction logic for TicketInfoxaml.xaml
    /// </summary>
    public partial class TicketInformation : Page
    {
        public static int a;
        public static int b;
        public static int bln;
        public int c;
        BuyT bt;
        TicketBuy tb;
        public TicketInformation(BuyT bt,TicketBuy tb)
        {
            InitializeComponent();
            this.bt = bt;
            this.tb = tb;
            if (BuyT.chang)
            {
                this.Resources.MergedDictionaries.Remove(bt.path1);
                this.Resources.MergedDictionaries.Add(bt.path2);
            }
            Ll1.Content = bt.ptype.Content;
            Label1.Content = bt.end1.Content;
            Label2.Content = bt.Tnumber.Content;
            Label6.Content = bt.numline.Text;

            if (Ll1.Content.ToString() == "单程票")
            {
                if (int.TryParse(Label6.Content.ToString(),out c) != false)
                {
                    b = c;
                }
            }
            else if (Ll1.Content.ToString() == "双程票")
            {
                if (int.TryParse(Label6.Content.ToString(),out c) != false)
                {
                    b = 2 * c;
                }
            }
            Label3.Content = b.ToString();
            if (int.TryParse(Label2.Content.ToString(),out c) != false)
            {
                bln = b * c;
            }
            Label4.Content = bln.ToString();
            tb.ubla.Content = Label4.Content;
            tb.pprice.Content = Label3.Content;
            tb.pnum.Content = Label2.Content;
        }
    }
}
