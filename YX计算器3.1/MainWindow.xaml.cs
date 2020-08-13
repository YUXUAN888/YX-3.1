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
using MahApps.Metro.Controls;



namespace YX计算器3._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            { }
        }
            public double jisuan1; //定义一个变量值

        public double jisuan2; //定义一个变量值

        public char fuhao; //定义一个变量值

        public double jiegun = 0; //定义一个变量值

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "1";//取值
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "2";//取值
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "3";//取值
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "4";//取值
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "5";//取值
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "6";//取值
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "7";//取值
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "8";//取值
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "9";//取值
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "0";//取值
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "")//判断
            {
                MessageBox.Show("请输入数字以计算", "提示");//提示框
                return;//返回执行
            }
            jisuan1 = Convert.ToDouble(TextBox1.Text);

            fuhao = '+';

            TextBox1.Text = "";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "")//判断
            {
                MessageBox.Show("请输入数字以计算", "提示");//提示框
                return;//返回执行
            }
            jisuan1 = Convert.ToDouble(TextBox1.Text);

            fuhao = '-';

            TextBox1.Text = "";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "")//判断
            {
                MessageBox.Show("请输入数字以计算", "提示");//提示框
                return;//返回执行
            }
            jisuan1 = Convert.ToDouble(TextBox1.Text);

            fuhao = '*';

            TextBox1.Text = "";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "")//判断
            {
                MessageBox.Show("请输入数字以计算", "提示");//提示框
                return;//返回执行
            }
            jisuan1 = Convert.ToDouble(TextBox1.Text);

            fuhao = '/';

            TextBox1.Text = "";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            if (TextBox1.Text == "")
            {
                MessageBox.Show("请输入数字以计算", "提示");
                return;
            }
            jisuan2 = Convert.ToDouble(TextBox1.Text);

            switch (fuhao)

            {

                case '+':

                    jiegun = jisuan1 + jisuan2;

                    break;

                case '-':

                    jiegun = jisuan1 - jisuan2;

                    break;

                case '*':

                    jiegun = jisuan1 * jisuan2;

                    break;

                case '/':

                    jiegun = jisuan1 / jisuan2;

                    break;

                case '%':

                    jiegun = jisuan1 / jisuan2;

                    break;

            }

            TextBox1.Text = Convert.ToString(jiegun);

        }
    }
    }
    
   

    
    

