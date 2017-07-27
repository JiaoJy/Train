using System.Windows.Controls;

namespace Train.Adminstrator2
{
    /// <summary>
    /// Interaction logic for AddTo.xaml
    /// </summary>
    public partial class AddTo : Page
    {
        public static string a;
        public static string b;
     
        public AddTo()
        {
            InitializeComponent();
         
          
        }

        private void t1_TextChanged(object sender, TextChangedEventArgs e)
        {
            a = t1.Text;
        }

        private void p2_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            b = p2.Password;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


    }
}
