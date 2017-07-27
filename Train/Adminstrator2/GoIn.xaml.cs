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

namespace Train.Adminstrator2
{
    /// <summary>
    /// Interaction logic for GoIn.xaml
    /// </summary>
    public partial class GoIn : Window
    {
        public GoIn()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var con = new UserEntities8())
            {
                var q1 = from t in con.Admin
                         where t.adminInfo.Equals(t1.Text) == true && t.password.Equals(p2.Password) == true
                         select t;
                if (q1.Count() != 0)
                {
                    User.UserGoing us = new User.UserGoing();
                    us.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("登录失败\n输入有错误!或所填内容有空！");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            t1.Text = "";
            p2.Password = "";
            t3.Text = "";
        }
    }
}
