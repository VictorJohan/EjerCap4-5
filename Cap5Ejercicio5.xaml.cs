using Humanizer;
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
    /// Interaction logic for Cap5Ejercicio5.xaml
    /// </summary>
    public partial class Cap5Ejercicio5 : Window
    {
        public Cap5Ejercicio5()
        {
            InitializeComponent();
        }

        private void convertirButton_Click(object sender, RoutedEventArgs e)
        {
            int numero = int.Parse(numeroTextBox.Text);

            conversionTextBlock.Text = numero.ToWords();
        }

        private void atrasButton_Click(object sender, RoutedEventArgs e)
        {
            Capitulo5 c5 = new Capitulo5();
            c5.Show();
            this.Close();
        }
    }
}
