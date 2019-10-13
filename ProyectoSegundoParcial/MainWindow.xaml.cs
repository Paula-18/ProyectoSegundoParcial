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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void CbProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdProductos.Children.Clear();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            switch (cbProductos.SelectedIndex)
            {
                case 0:
                    grdProductos.Children.Add(new Gorra());
                    break;
                case 1:
                    grdProductos.Children.Add(new Sudadera());
                    break;
                case 2:
                    grdProductos.Children.Add(new Blusa());
                    break;
                case 3:
                    grdProductos.Children.Add(new Camisa());
                    break;
                case 4:
                    grdProductos.Children.Add(new Pantalon());
                    break;
                case 5:
                    grdProductos.Children.Add(new Falda());
                    break;
                default:
                    break;
            }
        }

    }
}
