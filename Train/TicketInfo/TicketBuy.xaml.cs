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
using Train.TicketOver;

namespace Train.TicketInfo
{
    /// <summary>
    /// TicketBuy.xaml 的交互逻辑
    /// </summary>
    public partial class TicketBuy : Window
    {
        BuyT bt;
        public ResourceDictionary path1, path2;
        public TicketBuy(BuyT bt)
        {
            InitializeComponent();
            this.bt = bt;
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            fr.Content = new TicketInformation(bt,this);
            this.path1 = bt.path1;
            this.path2 = bt.path2;
            if (BuyT.chang)
            {
                this.Resources.MergedDictionaries.Remove(path1);
                this.Resources.MergedDictionaries.Add(path2);
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "yes":
                    fr.Content = new Spend(this);
                    yes.Visibility = System.Windows.Visibility.Hidden;
                    buy.Visibility = System.Windows.Visibility.Visible;
                    break;
                case "buy":
                    float a;
                    int numlie;
                    int ppric;
                    if (float.TryParse(ubla.Content.ToString(),out a) == false
                        | int.TryParse(pnum.Content.ToString(),out numlie) == false
                        | int.TryParse(pprice.Content.ToString(),out ppric) == false)
                    {
                        MessageBox.Show("输入格式不正确");
                    }
                    else
                    {
                        using (var con = new UserEntities8())
                        {
                            var q = from t in con.Users
                                    where t.nameInfo == uname.Content.ToString()
                                            && t.ID == uid.Content.ToString() 
                                            && t.password == upassw.Content.ToString()
                                            && t.balance > a
                                    select t;
                            try
                            {
                                if (q.Count() != 0)
                                {
                                    foreach (var v in q)
                                    {
                                        v.balance -= a;
                                    }
                                    con.SaveChanges();  //将更改后的用户数据库进行保存

                                    //向地铁票数据库中添加数据，根据票的数量循环添加票的次数
                                    for (int i = 0; i < numlie; i++)
                                    {
                                        Ticket tick = new Ticket()
                                        {
                                            nameInfo = uname.Content.ToString(),
                                            stops = ppric
                                        };
                                        try
                                        {
                                            con.Ticket.Add(tick);
                                            con.SaveChanges();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message + "添加失败！");
                                        }
                                    }  
                                }
                                else
                                {
                                    MessageBox.Show("输入错误或余额不足！");
                                }
                            }
                            catch (Exception ee)
                            {
                                MessageBox.Show(ee.Message);
                            }
  
                        }
                        Window1 w = new Window1();
                        w.ShowDialog();
                    }
                    
                    break;
                case "cancel":
                    this.Close();
                    break;
                default:
                    break;
            }
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
    }
}
