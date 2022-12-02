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

namespace WpfApp17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int i = 0;
        string x = "x";
        string o = "o";
       

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            btn1.IsEnabled = false;
            
                if (i % 2 == 0)
                {

                    btn1.Content = x;
                    i++;

                }
                else
                {
                    btn1.Content = o;
                    i++;
                }
            WinLose();




        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            btn2.IsEnabled = false;
            if (i % 2 == 0)
            {
                btn2.Content = x;
                i++;
            }
            else
            {
                btn2.Content = o;
                i++;
            }
            WinLose();

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            btn3.IsEnabled = false;
            if (i % 2 == 0)
            {
                btn3.Content = "x";
                i++;
            }
            else
            {
                btn3.Content = "o";
                i++;
            }
            WinLose();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            btn4.IsEnabled = false;
            if (i % 2 == 0)
            {
                btn4.Content = "x";
                i++;
            }
            else
            {
                btn4.Content = "o";
                i++;
            }
            WinLose();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            btn5.IsEnabled = false;
            if (i % 2 == 0)
            {
                btn5.Content = "x";
                i++;
            }
            else
            {
                btn5.Content = "o";
                i++;
            }
            WinLose();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            btn6.IsEnabled = false;
            if (i % 2 == 0)
            {
                btn6.Content = "x";
                i++;
            }
            else
            {
                btn6.Content = "o";
                i++;
            }
            WinLose();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            btn7.IsEnabled = false;
            if (i % 2 == 0)
            {
                btn7.Content = "x";
                i++;
            }
            else
            {
                btn7.Content = "o";
                i++;
            }
            WinLose();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            btn8.IsEnabled = false;
            if (i % 2 == 0)
            {
                btn8.Content = "x";
                i++;
            }
            else
            {
                btn8.Content = "o";
                i++;
            }
            WinLose();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            btn9.IsEnabled = false;
            if (i % 2 == 0)
            {
                btn9.Content = "x";
                i++;
            }
            else
            {
                btn9.Content = "o";
                i++;
            }
            WinLose();

        }
        private void WinLose()
        {

            if (btn3.Content !="" && btn5.Content!="" && btn7.Content!="")
            {
                if (btn1.Content == btn2.Content & btn3.Content == btn2.Content)
                {
                    MessageBox.Show("победа");
                }
                if (btn4.Content == btn5.Content & btn5.Content == btn6.Content)
                {
                    MessageBox.Show("победа");
                }
                if (btn7.Content == btn8.Content & btn8.Content == btn9.Content)
                {
                    MessageBox.Show("победа");
                }
                if (btn1.Content == btn4.Content & btn4.Content == btn7.Content)
                {
                    MessageBox.Show("победа");
                }
                if (btn2.Content == btn5.Content & btn5.Content == btn8.Content)
                {
                    MessageBox.Show("победа");
                }
                if (btn3.Content == btn6.Content & btn6.Content == btn9.Content)
                {
                    MessageBox.Show("победа");
                }
                if (btn1.Content == btn5.Content & btn5.Content == btn9.Content)
                {
                    MessageBox.Show("победа");
                }
                if (btn3.Content == btn5.Content & btn5.Content == btn7.Content)
                {
                    MessageBox.Show("победа");
                }
            }
            else
            {
                if (btn3.Content != "" && btn5.Content != "" && btn7.Content != "")
                {
                    MessageBox.Show("ничья");
                }
                
            }
            
            


        }

        private void rest_Click(object sender, RoutedEventArgs e)
        {
            MainWindow B = new MainWindow();
            this.Close();
            B.Show();
        }
    }
}

