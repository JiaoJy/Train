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
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add1 : Page
    {
       public static string s1;
       public static string s2;
        public static string s3;
        public static  string s4;
        public Add1()
        {
            InitializeComponent();
           // t3.Text = DateTime.Now.ToString();
                   see();
        }
        private void see(){
            using (var con = new UserEntities8())
            {
                var q = from t in con.Users
                        select new
                        {
                            用户名 = t.nameInfo,
                            密码 = t.password,
                            开户时间 = t.datetime,
                            身份证号 = t.ID,
                            余额 = t.balance
                        };
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (t1.Text != "" && p2.Password != "" && t3.Text != "" && t4.Text != "")
            {
                using (var con = new UserEntities8())
                {
                    Users us = new Users()
                    {
                        nameInfo = t1.Text,
                        password = p2.Password,
                        datetime = DateTime.Now,//ParseExact(t3.Text, "yyyy-MM-dd", null),
                        ID = t4.Text,
                        balance = 0
                       
                    };
                    try
                    {
                        con.Users.Add(us);
                        con.SaveChanges();
                        MessageBox.Show(t1.Text + "用户注册成功！");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "添加失败！");
                    }
                    // see();
                }
            }

            else
            {
                MessageBox.Show("所填内容不能为空！");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            t1.Text = "";
            p2.Password = "";
            t3.Text = "";
            t4.Text = "";
        }
    }
}
