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
    /// Interaction logic for Delet.xaml
    /// </summary>
    public partial class Delet : Page
    {
        public Delet()
        {
            InitializeComponent();
            see();
        }
        private void see()
        {
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
            using (var con = new UserEntities8()){
                var q = from t in con.Users
                        where t.nameInfo == t1.Text && t2.Text == t.ID
                        select t;
                if (q.Count() != 0)
                {
                    using (var con1 = new UserEntities8())
                    {
                        var q1 = from t in con1.Users
                                 where t.nameInfo == t1.Text && t.ID == t2.Text && t.balance == 0
                                 select t;
                        if (q1.Count() == 0)
                        {
                            MessageBox.Show("还有余额!");

                        }
                        else
                        {
                            foreach (var v in q)
                            {
                                con.Users.Remove(v);
                            }
                            con.SaveChanges();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("查无此人！\n请重新输入！");
                }
            }
            see();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
        }
    }
}
