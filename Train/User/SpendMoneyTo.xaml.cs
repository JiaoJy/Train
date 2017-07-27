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

namespace Train.User
{
    /// <summary>
    /// Interaction logic for SpendMoneyTo.xaml
    /// </summary>
    public partial class SpendMoneyTo : Page
    {
        public static int  b;
        public SpendMoneyTo()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var con = new UserEntities8())
            {
                var q = from t in con.Users
                        where t.nameInfo == t1.Text && t.ID == t2.Text
                        select t;
                if(q.Count() != 0)
                {
                    foreach (var v in q)
                    {
                        v.balance += int.Parse(t3.Text.ToString());
                       
                    }
                    con.SaveChanges();
                    MessageBox.Show("充值成功");
                }
                else
                {
                    MessageBox.Show("输入错误\n找不到此人！");
                }
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UserGoing us = new UserGoing();
            us.f1.Content = "";
        }  
    }
}
