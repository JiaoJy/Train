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
    /// Interaction logic for Routine.xaml
    /// </summary>
    public partial class Routine : Page
    {
        BuyT bt;
        public Routine(BuyT bt)
        {         
            InitializeComponent();
            this.bt = bt;
        }
    }
}
