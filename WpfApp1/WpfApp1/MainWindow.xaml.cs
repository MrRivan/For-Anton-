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
using System.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        int First_Number_1;
        int First_Number_2;
        int beacon;
        private void Visibility_All()
        {
            Start_Bt.Visibility = Visibility.Hidden;
            Start_Lb.Visibility = Visibility.Hidden;
            Thread.Sleep(500);
            Main_Bt.Visibility = Visibility.Visible;
            Main_Lb.Visibility = Visibility.Visible;
            Sum_False_Lb.Visibility = Visibility.Visible;
            Sum_False_Tb.Visibility = Visibility.Visible;
            Sum_True_Lb.Visibility = Visibility.Visible;
            Sum_True_Tb.Visibility = Visibility.Visible;
            Area1_RB.Visibility = Visibility.Visible;
            Area2_RB.Visibility = Visibility.Visible;
            Area3_RB.Visibility = Visibility.Visible;
            Area4_RB.Visibility = Visibility.Visible;
        }
        private int Support_Random(int a, int b)
        {
            int c = 0;
            do
            {
                c = random.Next(1, 100);
            } while (c == a * b);
            return c;
        }
        private void check_answer(ref int Sum_true, ref int Sum_false, int etalon)
        {
            if((Area1_RB.IsChecked == false)&& (Area2_RB.IsChecked == false)&& (Area3_RB.IsChecked == false)&& (Area4_RB.IsChecked == false))
            {
                MessageBox.Show("Выберите один из вариантов");
                return;
            }
            if (Area1_RB.IsChecked == true)
            {
                int check = 1;
                if(check==etalon)
                {
                    Sum_true++;
                    Area1_Lb.Visibility = Visibility.Visible;
                    Area1_Lb.Content = "Правильно!";
                    Area1_Lb.Background = Brushes.Green;
                }
                else
                {
                    Sum_false++;
                    Area1_Lb.Visibility = Visibility.Visible;
                    Area1_Lb.Content = "Не правильно!";
                    Area1_Lb.Background = Brushes.Red;
                }
            }
            if (Area2_RB.IsChecked == true)
            {
                int check = 2;
                if (check == etalon)
                {
                    Sum_true++;
                    Area2_Lb.Visibility = Visibility.Visible;
                    Area2_Lb.Content = "Правильно!";
                    Area2_Lb.Background = Brushes.Green;
                }
                else
                {
                    Sum_false++;
                    Area2_Lb.Visibility = Visibility.Visible;
                    Area2_Lb.Content = "Не правильно!";
                    Area2_Lb.Background = Brushes.Red;
                }
            }
            if (Area3_RB.IsChecked == true)
            {
                int check = 3;
                if (check == etalon)
                {
                    Sum_true++;
                    Area3_Lb.Visibility = Visibility.Visible;
                    Area3_Lb.Content = "Правильно!";
                    Area3_Lb.Background = Brushes.Green;
                }
                else
                {
                    Sum_false++;
                    Area3_Lb.Visibility = Visibility.Visible;
                    Area3_Lb.Content = "Не правильно!";
                    Area3_Lb.Background = Brushes.Red;
                }
            }
            if (Area4_RB.IsChecked == true)
            {
                int check = 4;
                if (check == etalon)
                {
                    Sum_true++;
                    Area4_Lb.Visibility = Visibility.Visible;
                    Area4_Lb.Content = "Правильно!";
                    Area4_Lb.Background = Brushes.Green;
                }
                else
                {
                    Sum_false++;
                    Area4_Lb.Visibility = Visibility.Visible;
                    Area4_Lb.Content = "Не правильно!";
                    Area4_Lb.Background = Brushes.Red;
                }
            }
        }
        private void Preprocess ()
        {
            int New_Number_1;
            int New_Number_2;
            do
            {
                New_Number_1 = random.Next(1, 9);
            } while (New_Number_1 == First_Number_1);
            {
                New_Number_2 = random.Next(1, 9);
            } while (New_Number_2 == First_Number_2) ;
            First_Number_1 = New_Number_1;
            First_Number_2 = New_Number_2;
            Main_Lb.Content = $"{First_Number_1}x{First_Number_2}";
            beacon = random.Next(1, 4);
            switch (beacon)
            {
                case 1:
                    Area1_RB.Content = $"{First_Number_1 * First_Number_2}";
                    Area2_RB.Content = $"{Support_Random(First_Number_1, First_Number_2)}";
                    Area3_RB.Content = $"{Support_Random(First_Number_1, First_Number_2)}";
                    Area4_RB.Content = $"{Support_Random(First_Number_1, First_Number_2)}";
                    break;
                case 2:
                    Area2_RB.Content = $"{First_Number_1 * First_Number_2}";
                    Area1_RB.Content = $"{Support_Random(First_Number_1, First_Number_2)}";
                    Area3_RB.Content = $"{Support_Random(First_Number_1, First_Number_2)}";
                    Area4_RB.Content = $"{Support_Random(First_Number_1, First_Number_2)}";
                    break;
                case 3:
                    Area3_RB.Content = $"{First_Number_1 * First_Number_2}";
                    Area2_RB.Content = $"{Support_Random(First_Number_1, First_Number_2)}";
                    Area1_RB.Content = $"{Support_Random(First_Number_1, First_Number_2)}";
                    Area4_RB.Content = $"{Support_Random(First_Number_1, First_Number_2)}";
                    break;
                case 4:
                    Area4_RB.Content = $"{First_Number_1 * First_Number_2}";
                    Area2_RB.Content = $"{Support_Random(First_Number_1, First_Number_2)}";
                    Area3_RB.Content = $"{Support_Random(First_Number_1, First_Number_2)}";
                    Area1_RB.Content = $"{Support_Random(First_Number_1, First_Number_2)}";
                    break;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        
        public void Button_Click(object sender, RoutedEventArgs e)
        {    
            Visibility_All();
            First_Number_1 = random.Next(1, 9);
            First_Number_2 = random.Next(1, 9);
            Preprocess();           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (int.Parse(Sum_True_Tb.Content.ToString()) < 10)
            {
                int Sum_true = int.Parse(Sum_True_Tb.Content.ToString());
                int Sum_false = int.Parse(Sum_False_Tb.Content.ToString());
                check_answer(ref Sum_true, ref Sum_false, beacon);
                Sum_True_Tb.Content = $"{Sum_true}";
                Sum_False_Tb.Content = $"{Sum_false}";
                Thread.Sleep(3000);
                Area4_Lb.Background = Brushes.White;
                Area3_Lb.Background = Brushes.White;
                Area2_Lb.Background = Brushes.White;
                Area1_Lb.Background = Brushes.White;
                Area1_Lb.Visibility = Visibility.Hidden;
                Area2_Lb.Visibility = Visibility.Hidden;
                Area3_Lb.Visibility = Visibility.Hidden;
                Area4_Lb.Visibility = Visibility.Hidden;
                Area1_RB.IsChecked = false;
                Area2_RB.IsChecked = false;
                Area3_RB.IsChecked = false;
                Area4_RB.IsChecked = false;
                Preprocess();
            }
            else
            {
                MessageBox.Show("Поздравляю вы завершили тест!");
                return;
            }

        }

            

        //private void tbSum_TextChanged(object sender, TextChangedEventArgs e)
        //{
        // LINQ
        //Where -для фильтрации
        //Aggregate- для свертки 
        //OrderBy- для сортировки 
        //var SortedArray = array.OrderBy( (x) => x );

        //}
    }
 
}
