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

namespace Train
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
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
                data1.ItemsSource = q.ToList();
                var m = from t in con.Ticket
                        select new
                        {
                           ID = t.Id,
                           用户名 = t.nameInfo,
                           标识 = t.status,
                           站点数目 = t.stops,
                           起点站 = t.start,
                           终点站 = t.end
                        };
                data2.ItemsSource = m.ToList();
            }
        }
    }
}
