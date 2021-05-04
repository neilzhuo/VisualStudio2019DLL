using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace TestDll
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IDllWrapper dllWrapper;

        public MainWindow()
        {
            InitializeComponent();
            dllWrapper = new DllWrapper();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(Input1.Text);
            double b = double.Parse(Input2.Text);
            Result.Text = dllWrapper.AddFromDll(a, b).ToString();
        }

        private void Substract_Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(Input1.Text);
            double b = double.Parse(Input2.Text);
            Result.Text = dllWrapper.SubstractFromDll(a, b).ToString();

        }

        private void Multiply_Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(Input1.Text);
            double b = double.Parse(Input2.Text);
            Result.Text = dllWrapper.MultiplyFromDll(a, b).ToString();
        }

        private void Divide_Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(Input1.Text);
            double b = double.Parse(Input2.Text);
            Result.Text = dllWrapper.DivideFromDll(a, b).ToString();
        }

        private void Sqrt_Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(Input3.Text);
            Result.Text = dllWrapper.SqrtFromDll(a).ToString();
        }
    }
}
