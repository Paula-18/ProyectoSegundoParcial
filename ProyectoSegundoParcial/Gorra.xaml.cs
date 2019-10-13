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
    /// Lógica de interacción para Gorra.xaml
    /// </summary>
    public partial class Gorra : UserControl
    {
        public Gorra()
        {
            InitializeComponent();
        }

        private void TboxClienteG_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxClienteG.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxFechaG_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxFechaG.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxPrecioG_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxPrecioG.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxDescuentoG_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxDescuentoG.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxGorraG_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxGorraG.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void TboxColorG_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxColorG.Text == "")
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                alerta.Visibility = Visibility.Hidden;
            }
        }

        private void BtnGuardar_Click (object sender, RoutedEventArgs e)
        {
            if (tboxClienteG.Text == "" || tboxFechaG.Text == "" || tboxPrecioG.Text == "" || tboxClienteG.Text == "" 
                || tboxGorraG.Text == "" || tboxColorG.Text == "" || (checkBoxXS.IsChecked == true && checkBoxS.IsChecked == true  
                && checkBoxM.IsChecked == true && checkBoxL.IsChecked == true && checkBoxXL.IsChecked == true) || 
                (cbMarcaG.SelectedItem == cbMarcaG.ItemsSource) || (rbSi.IsChecked == true && rbNo.IsChecked == true))
            {
                alerta.Visibility = Visibility.Visible;
            }
            else
            {
                gridGorra.Children.Clear();
                alerta.Visibility = Visibility.Hidden;
                btnGuardar.Visibility = Visibility.Hidden;
                btnCancelar.Visibility = Visibility.Hidden;

            }

        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            gridGorra.Children.Clear();
            btnGuardar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
        }
    }
}
