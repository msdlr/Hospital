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
             lavadora1.Value = rnd.Next(0,100);
             lavadora2.Value = rnd.Next(0,100);
             lavadora3.Value = rnd.Next(0,100);
             lavadora4.Value = rnd.Next(0,100);
            //Generador de etiquetas con porcentaje
            Lavlab1.Content = lavadora1.Value + "%";
            Lavlab2.Content = lavadora2.Value + "%";
            Lavlab3.Content = lavadora3.Value + "%";
            Lavlab4.Content = lavadora4.Value + "%";

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
    }
}