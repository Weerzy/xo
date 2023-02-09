
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

namespace xo
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
        public int i = 0;
        public int j = 0;

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            Place1.IsEnabled = true;
            Place1.Content = "";
            Place2.IsEnabled = true;
            Place2.Content = " ";
            Place3.IsEnabled = true;
            Place3.Content = "   ";
            Place4.IsEnabled = true;
            Place4.Content = "     ";
            Place5.IsEnabled = true;
            Place5.Content = "      ";
            Place6.IsEnabled = true;
            Place6.Content = "       ";
            Place7.IsEnabled = true;
            Place7.Content = "        ";
            Place8.IsEnabled = true;
            Place8.Content = "         ";
            Place9.IsEnabled = true;
            Place9.Content = "          ";
            j++;
        }
        public void Clicked_Place(Button n)
        {
            i++;
            if (i % 2 == 0)
            {
                if (j % 2 == 0)
                {
                    n.Content = "X";
                }
                else
                {
                    n.Content = "O";
                }
            }
            else
            {
                if (j % 2 == 0)
                {
                    n.Content = "O";
                }
                else
                {
                    n.Content = "X";
                }
            }
            check();
        }
        private void Place1_Click(object sender, RoutedEventArgs e)
        {
            Clicked_Place(Place1);
            Place1.IsEnabled = false;
        }
        private void Place2_Click(object sender, RoutedEventArgs e)
        {
            Clicked_Place(Place2);
            Place2.IsEnabled = false;
        }
        private void Place3_Click(object sender, RoutedEventArgs e)
        {
            Clicked_Place(Place3);
            Place3.IsEnabled = false;
        }
        private void Place4_Click(object sender, RoutedEventArgs e)
        {
            Clicked_Place(Place4);
            Place4.IsEnabled = false;
        }
        private void Place5_Click(object sender, RoutedEventArgs e)
        {
            Clicked_Place(Place5);
            Place5.IsEnabled = false;
        }
        private void Place6_Click(object sender, RoutedEventArgs e)
        {
            Clicked_Place(Place6);
            Place6.IsEnabled = false;
        }
        private void Place7_Click(object sender, RoutedEventArgs e)
        {
            Clicked_Place(Place7);
            Place7.IsEnabled = false;
        }
        private void Place8_Click(object sender, RoutedEventArgs e)
        {
            Clicked_Place(Place8);
            Place8.IsEnabled = false;
        }
        private void Place9_Click(object sender, RoutedEventArgs e)
        {
            Clicked_Place(Place9);
            Place9.IsEnabled = false;
        }
        public void check()
        {
            List<Button> places = new List<Button> { Place1, Place2, Place3, Place4, Place5, Place6, Place7, Place8, Place9 };
            int a = 0;
            string n = "";
            if (Place1.Content == Place2.Content && Place1.Content == Place3.Content)
            {
                n = (string)Place1.Content;
                MessageBox.Show($"Победили {n}");
                foreach (Button i in places) { i.IsEnabled = false; }
            }
            if (Place4.Content == Place5.Content && Place4.Content == Place6.Content)
            {   
                n = (string)Place4.Content;
                MessageBox.Show($"Победили {n}");
                foreach (Button i in places) { i.IsEnabled = false; }
            }
            if (Place7.Content == Place8.Content && Place7.Content == Place9.Content)
            {
                n = (string)Place7.Content;
                MessageBox.Show($"Победили {n}");
                foreach (Button i in places) { i.IsEnabled = false; }
            }
            if (Place1.Content == Place4.Content && Place1.Content == Place7.Content)
            {
                n = (string)Place1.Content;
                MessageBox.Show($"Победили {n}");
                foreach (Button i in places) { i.IsEnabled = false; }
            }
            if (Place2.Content == Place5.Content && Place2.Content == Place8.Content)
            {
                n = (string)Place1.Content;
                MessageBox.Show($"Победили {n}");
                foreach (Button i in places) { i.IsEnabled = false; }
            }
            if (Place3.Content == Place6.Content && Place3.Content == Place9.Content)
            {
                n = (string)Place1.Content;
                MessageBox.Show($"Победили {n}");
                foreach (Button i in places) { i.IsEnabled = false; }
            }
            if (Place1.Content == Place5.Content && Place1.Content == Place9.Content)
            {
                n = (string)Place1.Content;
                MessageBox.Show($"Победили {n}");
                foreach (Button i in places) { i.IsEnabled = false; }
            }
            if (Place1.Content == Place2.Content && Place1.Content == Place3.Content)
            {
                n = (string)Place1.Content;
                MessageBox.Show($"Победили {n}");
                foreach (Button i in places) { i.IsEnabled = false; }
            }
            if (Place3.Content == Place5.Content && Place3.Content == Place7.Content)
            {
                n = (string)Place1.Content;
                MessageBox.Show($"Победили {n}");
                foreach (Button i in places) { i.IsEnabled = false; }
            }
        }
    }
}