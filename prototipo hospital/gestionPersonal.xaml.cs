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
using System.Windows.Shapes;

namespace prototipo_hospital
{
    /// <summary>
    /// Lógica de interacción para gestionPersonal.xaml
    /// </summary>
    public partial class gestionPersonal : Window
    {
        public gestionPersonal()
        {
            InitializeComponent();
            this.Reset();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult key = MessageBox.Show("¿Seguro que desea salir?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            e.Cancel = (key == MessageBoxResult.No);
        }
        private void botonSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public class Datos
        {
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public string Funcion { get; set; }
            public Sexo Sexo { get; set; }
            public double ID { get; set; }
            public string Area { get; set; }              //Podria ser como la Planta
            public string Direccion { get; set; }
            public string Correo { get; set; }
            public double Telefono { get; set; }
            public string Salario { get; set; }

        }
        public enum Sexo
        {
            Hombre,
            Mujer
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            datosPersonas.ItemsSource = new Datos[]
            {
                new Datos{Nombre = "Pedro", Apellidos = "Galdos Gonzalez", Sexo = Sexo.Hombre, ID = 1844562, Funcion = "Camillero", Area = "Planta 1", Salario = "4200 €", Correo = "Pedro@gmail.com", Direccion = "C/Pedro", Telefono = 637525252 },
                new Datos{Nombre = "Sophia", Apellidos = "Nogal Saelices", Sexo = Sexo.Mujer, ID = 8412686, Funcion = "Camillero", Area = "Planta 2", Salario = "6000 €", Correo = "Sophia@gmail.com", Direccion = "C/Sophia", Telefono = 637635241 },
                new Datos{Nombre = "Sergio", Apellidos = "Prado Verde", Sexo = Sexo.Hombre, ID = 7896124, Funcion = "Camillero", Area = "Planta 3", Salario = "5500 €", Correo = "Sergio@gmail.com", Direccion = "C/Sergio", Telefono = 456123789 },
            };
        }
        public void Reset()
        {
            gestionCanvas.Items.Clear();          //"Nombre ComboBox".Items.Clear();
            foreach (string Canvas in busqueda)      //foreach (string "Nombre variable" in "Nombre string[]")
            {
                gestionCanvas.Items.Add(Canvas);
            }
            gestionCanvas.Text = gestionCanvas.Items[0] as string;
        }

        private string[] busqueda = { "ID", "Telefono", "Correo" };


        private void verCurriculum_Click(object sender, RoutedEventArgs e)
        {
            VentanaCurriculum ventcurri = new VentanaCurriculum();
            ventcurri.ShowDialog();
        }

        private void gestionCanvas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (gestionCanvas.SelectedItem == gestionCanvas.Items[0])
            {
                id.Visibility = Visibility.Visible;
                telefono.Visibility = Visibility.Hidden;
                correo.Visibility = Visibility.Hidden;
            }

            if (gestionCanvas.SelectedItem == gestionCanvas.Items[1])
            {
                id.Visibility = Visibility.Hidden;
                telefono.Visibility = Visibility.Hidden;
                correo.Visibility = Visibility.Visible;
            }

            if (gestionCanvas.SelectedItem == gestionCanvas.Items[2])
            {
                id.Visibility = Visibility.Hidden;
                telefono.Visibility = Visibility.Visible;
                correo.Visibility = Visibility.Hidden;
            }
        }

        private void habilitarBusqueda_Click(object sender, RoutedEventArgs e)
        {
            canvasBusqueda.IsEnabled = true;
        }

        private void botonBusqueda_Click(object sender, RoutedEventArgs e)
        {
            canvasDatos.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rectangle.Visibility = Visibility.Hidden;
            imagenPersona.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Foto guardada correctamente", "Foto");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textCurriculum.Visibility = Visibility.Visible;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Curriculum guardada correctamente", "Curriculum");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Instancia guardada correctamente", "Instancia");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}