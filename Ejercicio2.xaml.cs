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
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            int numBase = int.Parse(baseTextBox.Text), numPotencia = int.Parse(potenciaTextBox.Text);

            resulLabel.Content = Math.Pow(numBase, numPotencia);
        }

        private void atrasButton_Click(object sender, RoutedEventArgs e)
        {
            Capitulo4 c4 = new Capitulo4();
            c4.Show();
            this.Close();
        }
    }
}
