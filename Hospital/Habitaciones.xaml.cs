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
    public partial class Habitaciones : Window
    {
//Constantes, atributos
        public int habInt = 0;     //Número de habitación en entero (Para leer el textbox)
        public String[] Alas = { "Norte", "Sur", "Este", "Oeste" };
        Random rnd = new Random();

        //Constructor(es)
        public Habitaciones(int[] habitacion, int[] prioritarias) //
        {
            InitializeComponent();
            //buscarDatos(habitacion, prioritarias);

            

            //Generador de datos aleatorios
            for (int i = 0; i < habitacion.Length; i++)
            {

            }
        }
//Funciones
        private void ropaRecogida__Click(object sender, RoutedEventArgs e)
        {

        }

        private void datos_Click(int[] habitacion,int[] prioritarias)
        {
            habInt = Convert.ToInt32(hab.Text);     //Número del textbox en integer
            infoHab.Content = "Planta " + (habInt / 100) + ", ala " + Alas[(habInt / 100)/25]+".";
            //Imprime planta y ala (En lugar de cyka bliad)

                for (int i = 0; i < prioritarias.Length; i++)
                {
                    if ( habInt == prioritarias[i])
                    {
                        infoHab.Content = infoHab.Content + "PRIORITARIA";     
                        break;                      //Añade si la habitación es prioritaria a la label
                    }
                }
            //break;

            //Checkboxes
            //Las checkboxes del formulario son visuales, trabajaremos también con arrays
            CheckBox[] ocupada = new CheckBox[habitacion.Length];
            CheckBox[] ropaRecogida = new CheckBox[habitacion.Length];
            CheckBox[] ropaCamaLista = new CheckBox[habitacion.Length];

            //Generación de datos aleatorios(solo la primera vez)
            for (int i = 0; i < habitacion.Length; i++)             //Recorremos índices
            {
                if(ocupada[i] == null)                              //Solo va  aser null la primera vez
                {
                    if( rnd.Next(0,1) == 0)
                    {
                        ocupada[i].Content = false;                 //Libre
                    }
                    else
                    {
                        ocupada[i].Content = false;                 //Ocupada
                    }

                }
                
            }
        }

    }
}
