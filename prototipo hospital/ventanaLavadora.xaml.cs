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
        public ventanaLavadora()
        {
            InitializeComponent();
        }
        public ventanaLavadora(int porcentaje, int blanca, int color, int negra)
        {
            //int porcentajeLocal = porcentaje;
            int porcentajeLocal = porcentaje;
            int blancaLocal = blanca;
            int colorLocal = color;
            int negraLocal = negra;
            InitializeComponent();
        }
        //        blancaTexto.Content = String.Concat("Ropa blanca: ", " ", blanca[0], " Kg");

        //Labels


       
    }
}
