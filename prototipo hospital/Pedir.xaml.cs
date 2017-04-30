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
    /// Lógica de interacción para Pedir.xaml
    /// </summary>
    public partial class Pedir : Window
    {
        public Pedir()
        {
            InitializeComponent();
        }

        public class ListaComida
        {
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Pedirlista.ItemsSource = new ListaComida[]

            {
                     new ListaComida{Nombre= "Sal",Cantidad=0},
                     new ListaComida{Nombre= "Pollo",Cantidad=0},
                     new ListaComida{Nombre= "Agua",Cantidad=0},
                     new ListaComida{Nombre= "Ternera",Cantidad=12},
                     new ListaComida{Nombre= "Macarrones",Cantidad=2212 },
                     new ListaComida{Nombre= "Tomate",Cantidad=21, }

            };


        }

        private void Cerrar(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

    }
}
