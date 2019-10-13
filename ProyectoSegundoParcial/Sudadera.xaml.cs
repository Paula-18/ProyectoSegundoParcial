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
    /// Lógica de interacción para Sudadera.xaml
    /// </summary>
    public partial class Sudadera : UserControl
    {
        public Sudadera()
        {
            InitializeComponent();
        }

        private void TboxClienteS_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxClienteS.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxFechaS_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxFechaS.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxPrecioS_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxPrecioS.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxDescuentoS_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxDescuentoS.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxSudadera_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxSudadera.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxColorS_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxColorS.Text == "")
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
            if (tboxClienteS.Text == "" || tboxFechaS.Text == "" || tboxPrecioS.Text == "" || tboxClienteS.Text == ""
                || tboxSudadera.Text == "" || tboxColorS.Text == "" || (checkBoxXS.IsChecked == true && checkBoxS.IsChecked == true
                && checkBoxM.IsChecked == true && checkBoxL.IsChecked == true && checkBoxXL.IsChecked == true) ||
                (cbMarcaS.SelectedItem == cbMarcaS.ItemsSource) || (rbSi.IsChecked == true && rbNo.IsChecked == true))
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                gridSudadera.Children.Clear();
                alerta.Visibility = Visibility.Hidden;
                btnGuardar.Visibility = Visibility.Hidden;
                btnCancelar.Visibility = Visibility.Hidden;

            }

        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            gridSudadera.Children.Clear();
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
        }
    }
}
    