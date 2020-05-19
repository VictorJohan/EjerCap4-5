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
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(NumTextBox.Text);
            String resul = "";
            resulLabel.Content = "";
            for (int i = 1; i<=10; i++)
            {
                resul = NumTextBox.Text + " x " + i + " = " + num * i;
                resulLabel.Content = resulLabel.Content + resul + "\n";
            }
        }

        private void AtrasButton_Click(object sender, RoutedEventArgs e)
        {
            Capitulo4 c4 = new Capitulo4();
            c4.Show();
            this.Close();
        }
    }
}
