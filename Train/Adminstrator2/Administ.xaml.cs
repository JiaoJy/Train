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
    /// Interaction logic for Administ.xaml
    /// </summary>
    public partial class Administ : Window
    {

        public int c = 0;
        public Administ()
        {
            InitializeComponent();

            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }
        public void see()
        {
            using (var con = new UserEntities8())
            {
                var q = from t in con.Admin
                        select new
                        {
                            用户名 = t.adminInfo,
                            密码 = t.password,
                            // 时间 = t.datetime
                        };
            }
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            c = 1;
            f1.Navigate(new Uri("/Adminstrator2/AddTo.xaml", UriKind.Relative));
        
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            c = 2;
            f1.Navigate(new Uri("/Adminstrator2/AdEnter.xaml", UriKind.Relative));
       
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           
              

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            if (c == 1)
            {

                if (AddTo.a != "" && AddTo.b != "")
                {
                    using (var con = new UserEntities8())
                    {
                        Admin ad = new Admin()
                        {
                            adminInfo = AddTo.a,
                            password = AddTo.b

                        };
                        try
                        {
                            con.Admin.Add(ad);
                            con.SaveChanges();
                            MessageBox.Show("注册成功！");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "添加失败！");
                        }
                    }

                }

                else
                {
                    MessageBox.Show("所填内容不能为空！");
                }
            }
            if (c == 2)
            {
                using (var con = new UserEntities8())
                {
                    var q1 = from t in con.Admin
                             where t.adminInfo.Equals(AdEnter.a) == true && t.password.Equals(AdEnter.b) == true
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

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            TrainSy t = new TrainSy();
            t.Show();
            this.Close();
        }
    }
}
