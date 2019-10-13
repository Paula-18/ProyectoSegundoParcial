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
    /// Lógica de interacción para Camisa.xaml
    /// </summary>
    public partial class Camisa : UserControl
    {
        public Camisa()
        {
            InitializeComponent();
        }

        private void TboxClienteC_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxClienteC.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxFechaC_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxFechaC.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxPrecioC_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxPrecioC.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxDescuentoC_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxDescuentoC.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxCamisa_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxCamisa.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxColorC_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxColorC.Text == "")
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
            if (tboxClienteC.Text == "" || tboxFechaC.Text == "" || tboxPrecioC.Text == "" || tboxClienteC.Text == ""
                || tboxCamisa.Text == "" || tboxColorC.Text == "" || (checkBoxXS.IsChecked == true && checkBoxS.IsChecked == true
                && checkBoxM.IsChecked == true && checkBoxL.IsChecked == true && checkBoxXL.IsChecked == true) ||
                (cbMarcaC.SelectedItem == cbMarcaC.ItemsSource) || (rbSi.IsChecked == true && rbNo.IsChecked == true))
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                gridCamisa.Children.Clear();
                alerta.Visibility = Visibility.Hidden;
                btnGuardar.Visibility = Visibility.Hidden;
                btnCancelar.Visibility = Visibility.Hidden;

            }

        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            gridCamisa.Children.Clear();
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
        }
    }
}
