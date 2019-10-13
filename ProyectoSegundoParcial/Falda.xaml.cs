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
    /// Lógica de interacción para Falda.xaml
    /// </summary>
    public partial class Falda : UserControl
    {
        public Falda()
        {
            InitializeComponent();
        }

        private void TboxClienteF_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxClienteF.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxFechaF_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxFechaF.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxPrecioF_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxPrecioF.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxDescuentoF_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxDescuentoF.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxFalda_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxFalda.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxColorF_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxColorF.Text == "")
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
            if (tboxClienteF.Text == "" || tboxFechaF.Text == "" || tboxPrecioF.Text == "" || tboxClienteF.Text == ""
                || tboxFalda.Text == "" || tboxColorF.Text == "" || (checkBoxXS.IsChecked == true && checkBoxS.IsChecked == true
                && checkBoxM.IsChecked == true && checkBoxL.IsChecked == true && checkBoxXL.IsChecked == true) ||
                (cbMarcaF.SelectedItem == cbMarcaF.ItemsSource) || (rbSi.IsChecked == true && rbNo.IsChecked == true))
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                gridFalda.Children.Clear();
                alerta.Visibility = Visibility.Hidden;
                btnGuardar.Visibility = Visibility.Hidden;
                btnCancelar.Visibility = Visibility.Hidden;

            }

        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            gridFalda.Children.Clear();
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
        }
    }
}
