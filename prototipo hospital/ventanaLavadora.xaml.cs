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
    /// Lógica de interacción para ventanaLavadora.xaml
    /// </summary>
    public partial class ventanaLavadora : Window
    {
        int blancaLocal;
        int colorLocal;
        int negraLocal;
        
        Random cyka = new Random();
        public ventanaLavadora()
        {
            InitializeComponent();


            blancaTexto.Content = String.Concat("Ropa blanca: ", " ", blancaLocal, " Kg");
            colorTexto.Content = String.Concat("Ropa blanca: ", " ", colorLocal, " Kg");
            negraTexto.Content = String.Concat("Ropa blanca: ", " ", negraLocal, " Kg");
        }
        public ventanaLavadora(int porcentaje, int blanca, int color, int negra)
        {
            InitializeComponent();

            blancaTexto.Content = String.Concat("Ropa blanca: ", " ", blanca, " Kg");
            colorTexto.Content = String.Concat("Ropa blanca: ", " ", color, " Kg");
            negraTexto.Content = String.Concat("Ropa blanca: ", " ", negra, " Kg");

        }

        private void Actualizar_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
