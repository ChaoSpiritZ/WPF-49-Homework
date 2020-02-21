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

namespace WPF_49_Homework
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            int.TryParse(txt1.Text, out int num1);
            int.TryParse(txt2.Text, out int num2);
            sum = num1 + num2;
            txtblock.Text = sum.ToString();
        }

        private void Next_Button_Click(object sender, RoutedEventArgs e)
        {
            CountriesWindow cWindow = new CountriesWindow();
            cWindow.Show();
        }
    }
}
