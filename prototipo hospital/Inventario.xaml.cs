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
    /// Lógica de interacción para Inventario.xaml
    /// </summary>
    public partial class Inventario : Window
    {
        public Inventario()
        {
            InitializeComponent();
        }
        private void Cerrar(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
        public class Inventario1
        {
            public string Nombre { get; set; }
            public int Cantidad { get; set; }
            public string Descripción { get; set; }

        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            InventarioLista.ItemsSource = new Inventario1[]

            {
                     new Inventario1{Nombre= "Sal",Cantidad=42, Descripción= "Paquetes de 3 kg."},
                     new Inventario1{Nombre= "Pollo",Cantidad=542, Descripción= "Cajas de 3 pollos completos"},
                     new Inventario1{Nombre= "Agua",Cantidad=4212, Descripción= "Paquetes de 24 botellas de agua"},
                     new Inventario1{Nombre= "Ternera",Cantidad=12, Descripción= "Paquetes de 50 kg"},
                     new Inventario1{Nombre= "Macarrones",Cantidad=2212, Descripción= "Caja de 20 paquetes de 1 kg de pasta"},
                     new Inventario1{Nombre= "Tomate",Cantidad=21, Descripción= "Caja de tomates de 30kg"}






            };

        }

        private void Pedir(object sender, RoutedEventArgs e)
        {
            Pedir A = new Pedir();
            A.ShowDialog();

        }




    }
}
