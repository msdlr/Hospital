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
        int porcentajeLocal;
        
        Random cyka = new Random();
        public ventanaLavadora()
        {
            InitializeComponent();
        }
        public ventanaLavadora(int porcentaje)
        {
            porcentajeLocal = porcentaje;
            InitializeComponent();
            generarRopa();
            ActualizarLabels();
            ajuste();
        }
        
        public void generarRopa()
        {
            blancaLocal = cyka.Next(0, 50);
            colorLocal = cyka.Next(0, 50);
            negraLocal = 150 - blancaLocal - colorLocal;    
        }
        private void Actualizar_Click(object sender, RoutedEventArgs e)
        {
            blancaLocal = blancaLocal - Convert.ToInt32(blancaDescargar.Text) + Convert.ToInt32(blancaCargar.Text);
            colorLocal = colorLocal - Convert.ToInt32(colorDescargar.Text) + Convert.ToInt32(colorCargar.Text);
            negraLocal = negraLocal - Convert.ToInt32(negraDescargar.Text) + Convert.ToInt32(negraCargar.Text);
            if(blancaLocal < 0)
            {
                blancaLocal = 0;
            }
            if(colorLocal < 0){
                colorLocal = 0;
            }
            if(negraLocal < 0)
            {
                negraLocal = 0;
            }
            ActualizarLabels();
        }
        private void ActualizarLabels()
        {
            if(porcentajeLocal == 0)
            {

                estado.Content = String.Concat("Estado de la lavadora: ", porcentajeLocal, " %", " LISTA PARA CARGAR");
            }
            else if (porcentajeLocal == 100)
            {

                estado.Content = String.Concat("Estado de la lavadora: ", porcentajeLocal, " %", " LISTA PARA DESCARGAR");
            }
            else
            {

                estado.Content = String.Concat("Estado de la lavadora: ", porcentajeLocal, " %", " EN PROCESO");
            }
            blancaTexto.Content = String.Concat("Ropa blanca: ", " ", blancaLocal, " Kg");
            colorTexto.Content = String.Concat("Ropa de color: ", " ", colorLocal, " Kg");
            negraTexto.Content = String.Concat("Ropa negra: ", " ", negraLocal, " Kg");
        }
        public void ajuste() //activa o desactiva la carga o descarga dependiendo del porcentaje
        {
            blancaCargar.Text = "0"; blancaDescargar.Text = "0";
            colorCargar.Text = "0"; colorCargar.Text = "0";
            negraCargar.Text = "0"; negraCargar.Text = "0";
            //Todas las textbox a 0 para que no haya excepciones

            if( porcentajeLocal != 0 && porcentajeLocal != 100  ) //En marcha, no se puede cambiar la carga
            {
                blancaCargar.IsEnabled = false;
                blancaDescargar.IsEnabled = false;
                colorCargar.IsEnabled = false;
                colorDescargar.IsEnabled = false;
                negraCargar.IsEnabled = false;
                negraDescargar.IsEnabled = false;
                Actualizar.IsEnabled = false;
            }
            else if (porcentajeLocal == 0)
            {
                blancaCargar.IsEnabled = true;
                blancaDescargar.IsEnabled = false;
                colorCargar.IsEnabled = true;
                colorDescargar.IsEnabled = false;
                negraCargar.IsEnabled = true;
                negraDescargar.IsEnabled = false;

            }
            else if (porcentajeLocal == 100)
            {
                blancaCargar.IsEnabled = false;
                blancaDescargar.IsEnabled = true;
                colorCargar.IsEnabled = false;
                colorDescargar.IsEnabled = true;
                negraCargar.IsEnabled = false;
                negraDescargar.IsEnabled = true;
            }
        }

    }
}
