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
    /// Lógica de interacción para Lavanderia.xaml
    /// </summary>
    public partial class Lavanderia : Window
    {
        //Constantes, atributos
        const int MAX = 500;                            //Número máximo de habitaciones
        int[] habitacion = new int[MAX];                // Vector de habitaciones
        int[] prioritarias = new int[6];                //Generador aleatorio de Habitaciones con proridad
        public int[] lavadora = new int[4];
        Random rnd = new Random();                      //Generador de números aleatorios
        int[] blanca = new int[4];
        int[] color = new int[4];
        int[] negra = new int[4];
        Boolean first;
        //Contructor
        public Lavanderia()
        {
            InitializeComponent();
            generarHabitaciones();
            generarLavadoras();
            fechaTexto.Content = DateTime.Today;       //Pone la fecha de hoy
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
            //Puesto a 100 y a 0 para mostrar funciones cuando están a estos valores
            lavadora3.Value = 100;      //lavadora[2];
            lavadora4.Value = 0;        //lavadora[3];
            //Generador de etiquetas con porcentaje
            Lavlab1.Content = lavadora[0] + "%";
            Lavlab2.Content = lavadora[1] + "%";
            Lavlab3.Content = lavadora[2] + "%";
            Lavlab4.Content = lavadora[3] + "%";

            colorRopa(blanca, color, negra);

        }
        void colorRopa(int[] blanca, int[] color, int[] negra) //Establece y cambia el valor de las etiquetas, inicialmente y al descarglas
        {

            //Suponiendo que la carga máxima son 150kg (No pensé que dependiendo del color se lavaban separadas o juntas lmao)
            //Creación aleatoria de la ropa de distintos colores
            if (first)
            {
                for (int i = 0; i < 4; i++)
                {

                    blanca[i] = rnd.Next(0, 50);
                    color[i] = rnd.Next(0, 50);
                    negra[i] = 150 - blanca[i] - color[i];
                }
                first = false;
            }
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
            Habitaciones todasHabs = new Habitaciones(prioritarias); //Solo necesitamos mandar las habitaciones prioritarias
            todasHabs.Show();                       //Conserva la ventana anterior detrás
        }

        private void Lavadoras_Click(object sender, RoutedEventArgs e)
        {
            Lavadoras ventanaLavadoras = new Lavadoras(lavadora);
            ventanaLavadoras.Show();
        }

        //Botones de cada lavadora
        private void detalles_Click(int porcentaje,int blanca,int color,int negra)                         //Este función no está asociada con ningún botón
        {
            ventanaLavadora lavadoraVentana = new ventanaLavadora(porcentaje, blanca ,color,negra);
            lavadoraVentana.ShowDialog();
        }
        private void detalles1_Click(object sender, RoutedEventArgs e)
        {
            detalles_Click(lavadora[0], blanca[0], color[0], negra[0]);                                    //1
        }

        private void detalles2_Click(object sender, RoutedEventArgs e)
        {
            detalles_Click(lavadora[1], blanca[1], color[1], negra[1]);                                    //2
        }

        private void detalles3_Click(object sender, RoutedEventArgs e)
        {
            detalles_Click(lavadora[2], blanca[2], color[2], negra[2]);                                    //3
        }

        private void detalles4_Click(object sender, RoutedEventArgs e)
        {
            detalles_Click(lavadora[3],blanca[3], color[3], negra[3]);                                    //4
        }
    }
}