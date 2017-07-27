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
using Train.Properties;
using Train.RouTine;
using Train.TicketInfo;
using Train.TicketOver;

namespace Train
{
    /// <summary>
    /// Interaction logic for BuyT.xaml
    /// </summary>
    public partial class BuyT : Page
    {
         public static string s1;
         Rou rou;
         public static int num = 0;
         public Boolean selected = false;
         public static Boolean chang = false;
         public ResourceDictionary path1, path2;
         public BuyT(Rou rou)
        {
            InitializeComponent();
            InitLanguage();
            this.rou = rou;
            f2.Content = new Routine(this);
            Tnumber.Content = "";
            
        }
         private string currentLanguage = "Zh-Cn";
         private string pfx = "/Xmlresource/";
         private List<string> languages = new List<string>();
         private void InitLanguage()
         {
             foreach (var v in this.Resources.MergedDictionaries)
             {
                 if (v.Source.OriginalString == pfx + "Language.xaml")
                 {
                     foreach (var language in v.Keys)
                     {
                         languages.Add(language.ToString());
                     }
                 }
             }
         }
        private void Button_Click(object sender, RoutedEventArgs e)
        {        
            FrameworkElement source = e.Source as FrameworkElement;
            switch (source.Name)
            {
                case "Button1": s1 = "1";
                    break;
                case "Button2":s1 = "2"; 
                    break;
                case "Button3": s1 = "3";
                    break;
                case "Button4": s1 = "4";
                    break;
                case "Button5": s1 = "5";
                    break;
                case "Button6": s1 = "6";
                    break;
                case "Button7": s1 = "7"; ;
                    break;
                case "Button8": s1 = "8";
                    break;
                case "Button9": s1 = "9";
                    break;
                case "Button10":s1 = "10";
                    break;
            }
            Tnumber.Content = s1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           if(Tnumber.Content == null || Tnumber.Content.ToString() == "")
           {
               MessageBox.Show("请选择票数！");
           }
           else if (numline.Text == "0")
           {
               MessageBox.Show("站点数目有错误，请重新选择!");
           }
           else
           {
               if(num >= 0){
                   num++;
                   this.show();
               }
               else
               {
                   num = 1;
                   this.show();
               }
               
           }
        }
        private void Button11_Click(object sender, RoutedEventArgs e)
        {       
            s1 = TextBox1.Text;
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            if (num <= 3)
            {
                num--;
                this.show();
            }
            else
            {
                num = 3;
            }
            
        }
        private void Allline_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Content.ToString())
            {
                case "总线" :
                    num = 1;
                    show();
                    f2.Content = new Routine(this);
                    break;
                case "一号线":
                    num = 1;
                    show();
                    f2.Content = new OneRoutine(this);
                    break;
                case "二号线":
                    num = 1;
                    show();
                    f2.Content = new TwoRoutine(this);
                    break;
            }

        }
        private void show()
        {
            switch (num)
            {
                case 1:
                    f2.Content = new Routine(this);
                    line1.Visibility = System.Windows.Visibility.Visible;
                    line2.Visibility = System.Windows.Visibility.Visible;
                    numline.Text = "";
                    end1.Content = "null";
                    selected = false;
                    break;
                case 2:
                    if (end1.Content.ToString() != "null")
                    {
                        selected = true;
                    }
                    f2.Content = new Type1(this);
                    break;
                case 3:
                    num--;
                    if (numline.Text == "")
                    {
                        MessageBox.Show("请自定义选择通票！");
                    }
                    else
                    {     
                        TicketBuy tb = new TicketBuy(this);
                        tb.ShowDialog();
                    }       
                    break;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            chang = true;
            string selectedLanguageName = (e.Source as MenuItem).Header.ToString();
            foreach (var v in languages)
            {
                string languageName = this.FindResource(v).ToString();
                if (languageName == selectedLanguageName)
                {
                    ResourceDictionary currentDict = new ResourceDictionary()
                    {
                        Source = new Uri(pfx + currentLanguage + ".xaml", UriKind.Relative)
                    };
                    this.Resources.MergedDictionaries.Remove(currentDict);
                    rou.Resources.MergedDictionaries.Remove(currentDict);
                    path1 = currentDict;
                    currentDict.Source = new Uri(pfx + v + ".xaml", UriKind.Relative);
                    this.Resources.MergedDictionaries.Add(currentDict);
                    rou.Resources.MergedDictionaries.Add(currentDict);
                    path2 = currentDict;
                    currentLanguage = v;
                    break;
                }
            }
        }

    }
}
