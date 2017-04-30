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
    /// Lógica de interacción para Cocina.xaml
    /// </summary>
    public partial class Cocina : Window
    {
        public Cocina()
        {
            InitializeComponent();
        }


        public class tareas
        {
            public String Habitacion { get; set; }
            public String Menu { get; set; }
            public String Anotacion { get; set; }
            public Boolean Entregado { get; set; }
            public String Hora { get; set; }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Tarealista.ItemsSource = new tareas[]

            {
                     new tareas{Habitacion = "3243",Menu = "Menú 1", Entregado=false, Hora = "13:54"},
                     new tareas{Habitacion = "32343",Menu = "Menú 3",Entregado=false , Hora = "16:14"},
                     new tareas{Habitacion = "3221",Menu = "Menú 2", Entregado=false, Hora = "20:01"},
                     new tareas{Habitacion = "321",Menu = "Menú 1", Entregado=false, Hora = "10:01"},
                     new tareas{Habitacion = "21",Menu = "Menú 2", Entregado=false, Hora = "15:21"},
                     new tareas{Habitacion = "39",Menu = "Menú 3", Entregado=false, Hora = "21:14"}

            };

        }

        private void Abrirmenus(object sender, RoutedEventArgs e)
        {
            Menús Menu = new Menús();
            Menu.ShowDialog();
        }
        private void Abririnventario(object sender, RoutedEventArgs e)
        {
            Inventario inv = new Inventario();
            inv.ShowDialog();
        }

        private void Cerrar(object sender, RoutedEventArgs e)
        {

            this.Close();
        }


    }
}
