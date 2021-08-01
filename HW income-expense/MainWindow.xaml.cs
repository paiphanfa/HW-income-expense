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

namespace HW_income_expense
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(incometxt.Text);
            double y = double.Parse(expensetxt.Text);
            double z = double.Parse(wishtxt.Text);
            double sum = summation(x, y, z);
            calculatedtxt.Text = " "+ sum + " ";
        }

        private void incometxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void wishtxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        private double summation(double a, double b, double c)
        {
            double sum;
            sum = c/(a - b) ;
            return sum;
        }

        private void calculatedtxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
