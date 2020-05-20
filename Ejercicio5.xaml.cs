using System;
using System.Collections.Generic;
using System.Linq;
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

        byte mayor = 0, menor = 0, j = 0, c = 0;
        double promedio = 0;
        bool ctr = false;
        byte[] edad = new byte[30];

        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void insertarButton_Click(object sender, RoutedEventArgs e)
        {
            edad[j] = byte.Parse(edadTextBox.Text);
            
            if (ctr == false)
            {
                mayor = menor = edad[j];
                promedio += edad[j];
                promedioTextBlock.Text = promedio.ToString();
                mayorTextBlock.Text = mayor.ToString();
                menorTextBlock.Text = menor.ToString();
                ctr = true;
                j++;
            }
            else
            {

                if (edad[j] > mayor)
                {
                    mayor = edad[j];
                }
                else if (edad[j] < menor)
                {
                    menor = edad[j];
                }

                c = 1;
                for(int i = 1; i<edad.Length; i++)
                {
                   if(edad[i] == 0)
                    {
                        break;
                    }
                    promedio += edad[i];
                    c++;
                }
                promedio /= c;
                MessageBox.Show(c.ToString());
                
                promedioTextBlock.Text = promedio.ToString();
                mayorTextBlock.Text = mayor.ToString();
                menorTextBlock.Text = menor.ToString();
                j++;
            }
            edadTextBox.Text = "";
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            edadTextBox.Text = "";
            promedioTextBlock.Text = "";
            mayorTextBlock.Text = "";
            menorTextBlock.Text = "";
            mayor = menor = 0;
            promedio = 0;
            c = 0;
            for(int i = 0; i<edad.Length; i++)
            {
                edad[i] = 0;
            }
            ctr = false;
            
        }

        private void atarsButton_Click(object sender, RoutedEventArgs e)
        {
            Capitulo4 c4 = new Capitulo4();
            c4.Show();
            this.Close();
        }
    }
}
