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
    /// Interaction logic for Ejercicio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void insertarButton_Click(object sender, RoutedEventArgs e)
        {
            byte edad = byte.Parse(edadTextBox.Text);
            byte edadMayor = 0, edadmenor = 0;
            byte edadPromedio = 0;

        }
    }
}
