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

namespace Hospital
    {
    public partial class Lavanderia : Window
    {
//Constantes, atributos
        const int MAX = 500;                            //Número máximo de habitaciones
        int[] habitacion = new int[MAX];                // Vector de habitaciones
        int[] prioritarias = new int[6];                //Generador aleatorio de Habitaciones con proridad
        public int[] lavadora = new int[4];
        Random rnd = new Random();                      //Generador de números aleatorios
//Contructor
        public Lavanderia()
        {
            InitializeComponent();
            generarHabitaciones();
            generarLavadoras();
            fechaTexto.Content = DateTime.Today ;       //Pone la fecha de hoy
        }
//Funciones
        void generarLavadoras()
        {
            //Generador de las Progressbars aleatorias
            for (int i = 0; i < lavadora.Length; i++)
            {
                lavadora[i] = rnd.Next(0, 100);
            }
            //Asignación individual a los progressbars (Me da pereza re-hacerlo con Arrays de progressbars)
            //                      ¯\_(ツ)_/¯
            lavadora1.Value = lavadora[0];
            lavadora2.Value = lavadora[1];
            lavadora3.Value = lavadora[2];
            lavadora4.Value = lavadora[3];
            //Generador de etiquetas con porcentaje
            Lavlab1.Content = lavadora[0] + "%";
            Lavlab2.Content = lavadora[1] + "%";
            Lavlab3.Content = lavadora[2] + "%";
            Lavlab4.Content = lavadora[3] + "%";

        }

        public void generarHabitaciones()
        {
            for (int i = 0; i < 6; i++)
            {
                prioritarias[i] = rnd.Next(1, MAX);
            }
            hab0.Content = "Habitación " + prioritarias[0];
            hab1.Content = "Habitación " + prioritarias[1];
            hab2.Content = "Habitación " + prioritarias[2];
            hab3.Content = "Habitación " + prioritarias[3];
            hab4.Content = "Habitación " + prioritarias[4];
            hab5.Content = "Habitación " + prioritarias[5];
        }

        private void todasHabitaciones_Click(object sender, RoutedEventArgs e)
        {
            Habitaciones todasHabs = new Habitaciones( prioritarias ); //Solo necesitamos mandar las habitaciones prioritarias
            todasHabs.Show();                       //Conserva la ventana anterior detrás
        }

        private void Lavadoras_Click(object sender, RoutedEventArgs e)
        {
            Lavadoras ventanaLavadoras = new Lavadoras(lavadora);
            ventanaLavadoras.Show();
        }
    }
}