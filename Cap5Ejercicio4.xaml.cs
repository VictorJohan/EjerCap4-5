using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EjerCap4_5
{
    /// <summary>
    /// Interaction logic for Cap5Ejercicio4.xaml
    /// </summary>
    public partial class Cap5Ejercicio4 : Window
    {
        public Cap5Ejercicio4()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(numTextBox.Text);
            Factorial(num);
        }

        private void atrasButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw. Show();
            this.Close();
        }

        private void Factorial(int num)
        {
            String Strfactorial = "";
            int intFactorial = 1;

            Strfactorial += num;

            for (int i = num - 1; i >= 1; i--)
            {
                intFactorial *= i;
                Strfactorial += ($" x {i}");
            }
            intFactorial = intFactorial * num;

            factorialTextBlock.Text = Strfactorial + " = " + intFactorial + "i";

        }
    }
}
