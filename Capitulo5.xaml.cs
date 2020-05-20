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
    /// Interaction logic for Capitulo5.xaml
    /// </summary>
    public partial class Capitulo5 : Window
    {
        public Capitulo5()
        {
            InitializeComponent();
        }

        private void Ejer4Button_Click(object sender, RoutedEventArgs e)
        {
            Cap5Ejercicio4 cap5ej4 = new Cap5Ejercicio4();
            cap5ej4.Show();
            this.Close();
        }

        private void Ejer5Button_Click(object sender, RoutedEventArgs e)
        {
            Cap5Ejercicio5 c5eje5 = new Cap5Ejercicio5();
            c5eje5.Show();
            this.Close();
        }

        private void atrasButton_Click(object sender, RoutedEventArgs e)
        {
            Capitulo5 c5 = new Capitulo5();
            c5.Show();
            this.Close();
        }
    }
}
