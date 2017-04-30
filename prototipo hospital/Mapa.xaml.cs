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
    /// Lógica de interacción para Mapa.xaml
    /// </summary>
    public partial class Mapa : Window
    {
        public Mapa()
        {
            InitializeComponent();
        }

        private void botonPlanta0_Click(object sender, RoutedEventArgs e)
        {
            imagen0.Visibility = Visibility.Hidden;
            imagen1.Visibility = Visibility.Visible;
            imagen2.Visibility = Visibility.Hidden;
            canvas0.Visibility = Visibility.Hidden;
            canvas1.Visibility = Visibility.Visible;
            botonPlanta0_1.Visibility = Visibility.Hidden;
            botonPlanta0_2.Visibility = Visibility.Hidden;
            botonPlanta0_3.Visibility = Visibility.Hidden;
            botonPlanta0_4.Visibility = Visibility.Hidden;
            botonPlanta0_5.Visibility = Visibility.Hidden;
            botonPlanta0_6.Visibility = Visibility.Hidden;
            botonPlanta1_1_Bajar.Visibility = Visibility.Visible;
            botonPlanta1_1_Subir.Visibility = Visibility.Visible;
            botonPlanta1_2_Bajar.Visibility = Visibility.Visible;
            botonPlanta1_2_Subir.Visibility = Visibility.Visible;
            botonPlanta1_3_Bajar.Visibility = Visibility.Visible;
            botonPlanta1_3_Subir.Visibility = Visibility.Visible;
            botonPlanta1_4_Bajar.Visibility = Visibility.Visible;
            botonPlanta1_4_Subir.Visibility = Visibility.Visible;
            botonPlanta1_5_Bajar.Visibility = Visibility.Visible;
            botonPlanta1_5_Subir.Visibility = Visibility.Visible;
            botonPlanta1_6_Bajar.Visibility = Visibility.Visible;
            botonPlanta1_6_Subir.Visibility = Visibility.Visible;
            botonPlanta2_1.Visibility = Visibility.Hidden;
            botonPlanta2_2.Visibility = Visibility.Hidden;
            botonPlanta2_3.Visibility = Visibility.Hidden;
            botonPlanta2_4.Visibility = Visibility.Hidden;
            botonPlanta2_5.Visibility = Visibility.Hidden;
            botonPlanta2_6.Visibility = Visibility.Hidden;
        }
        private void botonPlnata1_Subir_Click(object sender, RoutedEventArgs e)
        {
            imagen0.Visibility = Visibility.Hidden;
            imagen1.Visibility = Visibility.Hidden;
            imagen2.Visibility = Visibility.Visible;
            canvas0.Visibility = Visibility.Hidden;
            canvas1.Visibility = Visibility.Hidden;
            botonPlanta0_1.Visibility = Visibility.Hidden;
            botonPlanta0_2.Visibility = Visibility.Hidden;
            botonPlanta0_3.Visibility = Visibility.Hidden;
            botonPlanta0_4.Visibility = Visibility.Hidden;
            botonPlanta0_5.Visibility = Visibility.Hidden;
            botonPlanta0_6.Visibility = Visibility.Hidden;
            botonPlanta1_1_Bajar.Visibility = Visibility.Hidden;
            botonPlanta1_1_Subir.Visibility = Visibility.Hidden;
            botonPlanta1_2_Bajar.Visibility = Visibility.Hidden;
            botonPlanta1_2_Subir.Visibility = Visibility.Hidden;
            botonPlanta1_3_Bajar.Visibility = Visibility.Hidden;
            botonPlanta1_3_Subir.Visibility = Visibility.Hidden;
            botonPlanta1_4_Bajar.Visibility = Visibility.Hidden;
            botonPlanta1_4_Subir.Visibility = Visibility.Hidden;
            botonPlanta1_5_Bajar.Visibility = Visibility.Hidden;
            botonPlanta1_5_Subir.Visibility = Visibility.Hidden;
            botonPlanta1_6_Bajar.Visibility = Visibility.Hidden;
            botonPlanta1_6_Subir.Visibility = Visibility.Hidden;
            botonPlanta2_1.Visibility = Visibility.Visible;
            botonPlanta2_2.Visibility = Visibility.Visible;
            botonPlanta2_3.Visibility = Visibility.Visible;
            botonPlanta2_4.Visibility = Visibility.Visible;
            botonPlanta2_5.Visibility = Visibility.Visible;
            botonPlanta2_6.Visibility = Visibility.Visible;
        }

        private void botonPlnata1_Bajar_Click(object sender, RoutedEventArgs e)
        {
            imagen0.Visibility = Visibility.Visible;
            imagen1.Visibility = Visibility.Hidden;
            imagen2.Visibility = Visibility.Hidden;
            canvas0.Visibility = Visibility.Visible;
            canvas1.Visibility = Visibility.Hidden;
            botonPlanta0_1.Visibility = Visibility.Visible;
            botonPlanta0_2.Visibility = Visibility.Visible;
            botonPlanta0_3.Visibility = Visibility.Visible;
            botonPlanta0_4.Visibility = Visibility.Visible;
            botonPlanta0_5.Visibility = Visibility.Visible;
            botonPlanta0_6.Visibility = Visibility.Visible;
            botonPlanta1_1_Bajar.Visibility = Visibility.Hidden;
            botonPlanta1_1_Subir.Visibility = Visibility.Hidden;
            botonPlanta1_2_Bajar.Visibility = Visibility.Hidden;
            botonPlanta1_2_Subir.Visibility = Visibility.Hidden;
            botonPlanta1_3_Bajar.Visibility = Visibility.Hidden;
            botonPlanta1_3_Subir.Visibility = Visibility.Hidden;
            botonPlanta1_4_Bajar.Visibility = Visibility.Hidden;
            botonPlanta1_4_Subir.Visibility = Visibility.Hidden;
            botonPlanta1_5_Bajar.Visibility = Visibility.Hidden;
            botonPlanta1_5_Subir.Visibility = Visibility.Hidden;
            botonPlanta1_6_Bajar.Visibility = Visibility.Hidden;
            botonPlanta1_6_Subir.Visibility = Visibility.Hidden;
            botonPlanta2_1.Visibility = Visibility.Hidden;
            botonPlanta2_2.Visibility = Visibility.Hidden;
            botonPlanta2_3.Visibility = Visibility.Hidden;
            botonPlanta2_4.Visibility = Visibility.Hidden;
            botonPlanta2_5.Visibility = Visibility.Hidden;
            botonPlanta2_6.Visibility = Visibility.Hidden;
        }

        private void botonPlanta2_Click(object sender, RoutedEventArgs e)
        {
            imagen0.Visibility = Visibility.Hidden;
            imagen1.Visibility = Visibility.Visible;
            imagen2.Visibility = Visibility.Hidden;
            canvas0.Visibility = Visibility.Hidden;
            canvas1.Visibility = Visibility.Visible;
            botonPlanta0_1.Visibility = Visibility.Hidden;
            botonPlanta0_2.Visibility = Visibility.Hidden;
            botonPlanta0_3.Visibility = Visibility.Hidden;
            botonPlanta0_4.Visibility = Visibility.Hidden;
            botonPlanta0_5.Visibility = Visibility.Hidden;
            botonPlanta0_6.Visibility = Visibility.Hidden;
            botonPlanta1_1_Bajar.Visibility = Visibility.Visible;
            botonPlanta1_1_Subir.Visibility = Visibility.Visible;
            botonPlanta1_2_Bajar.Visibility = Visibility.Visible;
            botonPlanta1_2_Subir.Visibility = Visibility.Visible;
            botonPlanta1_3_Bajar.Visibility = Visibility.Visible;
            botonPlanta1_3_Subir.Visibility = Visibility.Visible;
            botonPlanta1_4_Bajar.Visibility = Visibility.Visible;
            botonPlanta1_4_Subir.Visibility = Visibility.Visible;
            botonPlanta1_5_Bajar.Visibility = Visibility.Visible;
            botonPlanta1_5_Subir.Visibility = Visibility.Visible;
            botonPlanta1_6_Bajar.Visibility = Visibility.Visible;
            botonPlanta1_6_Subir.Visibility = Visibility.Visible;
            botonPlanta2_1.Visibility = Visibility.Hidden;
            botonPlanta2_2.Visibility = Visibility.Hidden;
            botonPlanta2_3.Visibility = Visibility.Hidden;
            botonPlanta2_4.Visibility = Visibility.Hidden;
            botonPlanta2_5.Visibility = Visibility.Hidden;
            botonPlanta2_6.Visibility = Visibility.Hidden;
        }
    }
}
