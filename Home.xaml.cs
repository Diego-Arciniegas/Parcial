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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parcial_Diego_Arciniegas
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {

        public Home()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Cedula = txtCedula.Text;
            string Precio = lblPrecio.Content.ToString();
            string Tipo = cbxTipo.Text;
            string Cantidad = srCantidad.Value.ToString();

            DateTime Now = DateTime.Now;
            txtResults.Items.Add("-Fecha: " + DateTime.Now + "\n" + "-Nombre: " + Nombre + "\n" + "-Cedúla: " + Cedula + "\n" + "-Tipo: " + Tipo + "\n" + "-Precio: " + Precio + "\n" + "-Cantidad: " + Cantidad);


        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.IsChecked.Value)
            {
                lblPrecio.Content = rb.Content.ToString();
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.IsChecked.Value)
            {
                lblPrecio.Content = rb.Content.ToString();
            }
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.IsChecked.Value)
            {
                lblPrecio.Content = rb.Content.ToString();
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = sender as ComboBox;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.frameMain.NavigationService.Navigate(new Login());
        }



        private void srLevel_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblLevel.Content = "-Cantidad: " + srCantidad.Value.ToString();
        }
    }
}

