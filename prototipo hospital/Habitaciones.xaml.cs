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
    public partial class Habitaciones : Window
    {
        //Constantes, atributos

        const int MAX = 500;
        public int habInt = 0;     //Número de habitación en entero (Para leer el textbox)
        public String[] Alas = { "Norte", "Sur", "Este", "Oeste" };
        Random rnd = new Random();
        int[] todashabitaciones = new int[MAX];
        int[] habPrioritarias = new int[6];
        //int anteriorHab;
        //Checkboxes
        //Las checkboxes del formulario son visuales, trabajaremos también con arrays
        Boolean[] ocupada = new Boolean[MAX];
        Boolean[] ropaRecogida = new Boolean[MAX];
        Boolean[] ropaCamaLista = new Boolean[MAX];
        Boolean[] ropaPlanchada = new Boolean[MAX];
        //Booleano para ver si es la primera vez que se usa el botón buscar

        //Constructor(es)

        public Habitaciones(int[] prioritarias)         //USANDO ESTE CONTRUCTOR
        {

            InitializeComponent();
            habPrioritarias = prioritarias;     //Asigna el array de habitaciones prioritarias (parámetro) al array atributo de la clase
            generarDatos(todashabitaciones);

        }

        //Funciones

        private void guardarCambios_Click(object sender, RoutedEventArgs e)
        {
            if (ocupada_.IsChecked == true)      //Tengo que ir condición a condición porque hay 1049 tipos de booleanos
            {
                ocupada[habInt] = true;
            }
            else if (ocupada_.IsChecked == false)
            {
                ocupada[habInt] = false;
            }
            /*      */
            if (ropaRecogida_.IsChecked == true)
            {
                ropaRecogida[habInt] = true;
            }
            else if (ropaRecogida_.IsChecked == false)
            {
                ropaRecogida[habInt] = false;
            }/*      */
            if (ropaCamaLista_.IsChecked == true)
            {
                ropaCamaLista[habInt] = true;
            }
            else if (ropaCamaLista_.IsChecked == false)
            {
                ropaCamaLista[habInt] = false;
            }/*      */
            if (ropaPlanchada_.IsChecked == true)
            {
                ropaPlanchada[habInt] = true;
            }
            else if (ropaPlanchada_.IsChecked == false)
            {
                ropaPlanchada[habInt] = false;
            }
            for (int i = 0; i < MAX; i++)
            {
                
            }
        }


        private void datos_Click_1(object sender, RoutedEventArgs e)
        {
            datos_Click(todashabitaciones, habPrioritarias);         //Invoca la función por defecto (Así no da problemas)
        }
        private void datos_Click(int[] habitacion, int[] prioritarias)
        {

            if (hab.Text.Length != 0)                   //Procedemos si la cadena no está vacía
            {
                habInt = Convert.ToInt32(hab.Text);     //Número del textbox en integer
                mostrarDatos(habPrioritarias);
            }
            else if (habInt > (MAX - 1) || habInt < 0)        //Caso habitación con número no válido
            {
                infoHab.Content = "Por favor, introduzca un número (1-499)";
                System.ComponentModel.CancelEventArgs nnovalido = new System.ComponentModel.CancelEventArgs();
                //Instancia de error
                MessageBoxResult key = MessageBox.Show(
                "Número no válido",
                "Error",
                MessageBoxButton.OK,
                MessageBoxImage.Error,
                MessageBoxResult.OK);
                nnovalido.Cancel = (key == MessageBoxResult.OK);
                habInt = 0;
            }
            mostrarDatos(habPrioritarias);
        }


        public void generarDatos(int[] habitacion)
        {
            Boolean first = true;
            //Generación de datos aleatorios(solo la primera vez)
            if (first == false)
            {
                for (int i = 0; i < habitacion.Length; i++)             //Recorremos índices
                {
                    if (rnd.Next(1, 10) % 2 == 1)
                    {
                        ocupada_.IsChecked = false;                 //Libre
                    }
                    else
                    {
                        ocupada_.IsChecked = true;                  //Ocupada
                    }
                }
                first = false;                                        //Ya no es la primera vez, no se actualizan los datos
            }



        }
        //Actualización de checkboxes según la habitación
        public void mostrarDatos(int[] prioritarias)
        {
            ropaRecogida_.IsChecked = ropaRecogida[habInt];
            ocupada_.IsChecked = ocupada[habInt];
            ropaPlanchada_.IsChecked = ropaPlanchada[habInt];
            ropaCamaLista_.IsChecked = ropaCamaLista[habInt];
            //actualización de etiqueta bajo la textbox
            if (habInt > 0 && habInt < MAX)
            {
                infoHab.Content = "Planta " + (habInt / 100) +
                    ", ala " + Alas[(habInt / 100) / 25] + ".";
                ropaRecogida_.IsEnabled = true;
                ropaCamaLista_.IsEnabled = true;
                ropaPlanchada_.IsEnabled = false;               //Esta checkbox siempre está desactivada hasta que se active la de ropa recogida
                //Actualización de checkboxes según la habitación
                ropaRecogida_.IsChecked = ropaRecogida[habInt];
                ocupada_.IsChecked = ocupada[habInt];
                ropaPlanchada_.IsChecked = ropaCamaLista[habInt];
            }
            else
            {
                infoHab.Content = "Por favor, introduzca un número (1-499)";
                ropaRecogida_.IsEnabled = false;
                ropaCamaLista_.IsEnabled = false;
                ropaPlanchada_.IsEnabled = false;
            }

            //Imprime planta y ala (En un principiom imprimía cyka bliad por defecto pero you know)

            for (int i = 0; i < prioritarias.Length; i++)
            {
                if (habInt == prioritarias[i])
                {
                    infoHab.Content = infoHab.Content + "PRIORITARIA";
                    break;                      //Añade si la habitación es prioritaria a la label
                }
            }
        }

        private void ropaRecogida__Checked(object sender, RoutedEventArgs e)
        {
            if (ropaRecogida_.IsChecked == true)
            {
                ropaPlanchada_.IsEnabled = true;        //Activa el campo de ropa planchada solo si se activa la ropa recogida
                ropaPlanchada_.IsChecked = false;       //Lo establece por defecto a false
                ropaRecogida[habInt] = true;
            }
            else if (ropaRecogida_.IsChecked == false)
            {
                ropaPlanchada_.IsChecked = false;           //La pone a 0
                ropaPlanchada_.IsEnabled = false;           //La desactiva
                ropaRecogida[habInt] = false;               //Si quitamos el tick en Ropa recogidase desactiva la ropa planchada y se pone a 0
            }
        }
    }
}
