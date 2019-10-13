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

namespace ProyectoSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para Blusa.xaml
    /// </summary>
    public partial class Blusa : UserControl
    {
        public Blusa()
        {
            InitializeComponent();
        }

        private void TboxClienteB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxClienteB.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxFechaB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxFechaB.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxPrecioB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxPrecioB.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxDescuentoB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxDescuentoB.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxBlusa_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxBlusa.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxColorB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxColorB.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (tboxClienteB.Text == "" || tboxFechaB.Text == "" || tboxPrecioB.Text == "" || tboxClienteB.Text == ""
                || tboxBlusa.Text == "" || tboxColorB.Text == "" || (checkBoxXS.IsChecked == true && checkBoxS.IsChecked == true
                && checkBoxM.IsChecked == true && checkBoxL.IsChecked == true && checkBoxXL.IsChecked == true) ||
                (cbMarcaB.SelectedItem == cbMarcaB.ItemsSource) || (rbSi.IsChecked == true && rbNo.IsChecked == true))
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                gridBlusa.Children.Clear();
                alerta.Visibility = Visibility.Hidden;
                btnGuardar.Visibility = Visibility.Hidden;
                btnCancelar.Visibility = Visibility.Hidden;

            }

        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            gridBlusa.Children.Clear();
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
        }
    }
}
