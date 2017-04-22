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
    /// <summary>
    /// Lógica de interacción para Lavanderia.xaml
    /// </summary>
    public partial class LavanderiaVieja : Window
    {

        //Constantes, atributos
        const int MAX = 500; //Número máximo de habitaciones
        int[] habitacion = new int[MAX];                 // Vector de habitaciones
        int[] prioritarias = new int[6];



        //enum ala {Norte = 0, Sur, Este, Oeste };

        public int Value { get; set; }
        public Lavanderia()
        {
            InitializeComponent();
            Fecha();
            generarHabitacion();
            generarLavadoras();
        }

        public void Fecha()
        {
            //DateTime fechaPicker = DateTime.Now;

            fechaTexto.Content = DateTime.Now.Day + "/" +
            DateTime.Now.Month + "/" + DateTime.Now.Year;

            /*habitaciones.Items.Clear();
            
            habitaciones.Text = habitaciones.Items[0] as string;*/

        }


        public void generarHabitacion()
        {
            Random rnd = new Random();

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
            //6 habitaciones prioritarias




            /*
                    F1C1.Content = "Hab." + habitacion[0] + "; piso " + (habitacion[0]/100) ;
                    F1C2.Content = hab1.Content;
                    F1C3.Content = hab2.Content;
                    F2C1.Content = hab3.Content;
                    F2C2.Content = hab4.Content;
                    F2C3.Content = hab5.Content;
                    */

            //Checkboxes de ropa recogida
            CheckBox[] ropaRecogida = new CheckBox[6];
            for (int i = 0; i < MAX; i++)
            {
                rnd.Next(0, MAX);
                if (habitacion[i] % 2 == 0 && rnd.Next(0, MAX) == 0)
                {
                    ropaRecogida[i].Content = true;     //La ropa estará recogida si la hab es par
                }
                else
                {
                    ropaRecogida[i].Content = false;    //La ropa no estará recogida si la hab es impar
                }
            }

            //Asignación de checkboxes según n de habitación
            /*
          F1C1recogida.Content = ropaRecogida[0].Content;

          F1C2recogida.Content = ropaRecogida[1].Content;
          F1C3recogida.Content = ropaRecogida[2].Content;
          F2C1recogida.Content = ropaRecogida[3].Content;
          F2C2recogida.Content = ropaRecogida[4].Content;
          F2C3recogida.Content = ropaRecogida[5].Content;
          */
        }
        public void generarLavadoras()
        {
            Random rnd = new Random();
            lavadora1.Maximum = rnd.Next(100, MAX);
            lavadora2.Maximum = rnd.Next(100, MAX);
            lavadora3.Maximum = rnd.Next(100, MAX);
            lavadora4.Maximum = rnd.Next(100, MAX);
            /*
            litlav1.Content = Math.Round(lavadora1.Maximum / 100) + "%";
            litlav2.Content = Math.Truncate(lavadora2.Maximum / 100) + "%";
            litlav3.Content = Math.Truncate(lavadora3.Maximum / 100) + "%";
            litlav4.Content = Math.Truncate(lavadora4.Maximum / 100) + "%";
            
            litlav1.Content = (Math.Truncate(100 * lavadora1.Maximum )/100)/10 + "%";
            litlav2.Content =  (float) Math.Round(lavadora2.Maximum) + "%";
            litlav3.Content = Math.Truncate(lavadora3.Maximum) / 100 + "%";
            litlav4.Content = Math.Truncate(lavadora4.Maximum) / 100 + "%";
            */
        }

        private void sb_Completed(object sender, EventArgs e)
        {

        }

        private void Habitaciones_Click(object sender, RoutedEventArgs e)
        {
            Habitaciones habitaciones = new Habitaciones(habitacion);
            habitaciones.ShowDialog();

        }
    }
}
