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
    /// Interaction logic for Capitulo4.xaml
    /// </summary>
    public partial class Capitulo4 : Window
    {
        public Capitulo4()
        {
            InitializeComponent();
        }

        private void Ejer1Button_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1 ej = new Ejercicio1();
            ej.Show();
            this.Close();
        }

        private void Ejer2Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Ejer5Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void atrasButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
