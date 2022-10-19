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
using System.Linq.Expressions;
using System.IO;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {

        Calculator myCalc = new Calculator();
        string parantesÖppning = "(";
        string parantesStängning = ")";
        decimal button1 = 1;
        decimal button2 = 2;
        decimal button3 = 3;
        decimal button4 = 4;
        decimal button5 = 5;
        decimal button6 = 6;
        decimal button7 = 7;
        decimal button8 = 8;
        decimal button9 = 9;
        decimal button0 = 0;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e) // 1
        {
            screen.Text += button1;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e) //2
        {
            screen.Text += button2;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)//3
        {
            screen.Text += button3;
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)//4
        {
            screen.Text += button4;
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)//5
        {
            screen.Text += button5;
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)//6
        {
            screen.Text += button6;
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)//7
        {
            screen.Text += button7;
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)//8
        {
            screen.Text += button8;
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)//9
        {
            screen.Text += button9;
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)//0
        {
            screen.Text += button0;
        }
        private void rensa_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = "";
        }
        private void subtraktion_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "-";
        }
        private void addition_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "+";
        }
        private void division_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "/";
        }

        private void procent_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "%";
        }

        private void comma_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += ",";
        }

        private void multiplikation_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "*";

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void beräkna_Click(object sender, RoutedEventArgs e)
        {
            string klar = myCalc.Beräkna(screen.Text);
            screen.Text = klar;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            screen.Text += parantesÖppning;
        }

        private void parantes__Click(object sender, RoutedEventArgs e)
        {
            screen.Text += parantesStängning;
        }

        private void rotenur_Click(object sender, RoutedEventArgs e)
        {
            screen.Text += "√";
        }
    }
}
