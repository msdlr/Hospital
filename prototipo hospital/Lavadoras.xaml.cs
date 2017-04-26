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
    /// Lógica de interacción para Lavadoras.xaml
    /// </summary>
    public partial class Lavadoras : Window
    {
        //Atributos
        Random rnd = new Random();
        int[] blanca = new int[4];
        int[] color = new int[4];
        int[] negra = new int[4];
        TextBox[] blancaDescargada = new TextBox[4];
        TextBox[] colorDescargada = new TextBox[4];
        TextBox[] negraDescargada = new TextBox[4];
        Boolean first = true;

        //Constructores
        public Lavadoras(int[] porcentaje)
        {
            InitializeComponent();
            int[] procesoLavadoras = porcentaje;
            //Actualización de las etiquetas de porcentaje de cada lavadora en cada pestaña
            carga1.Content = String.Concat(carga1.Content, porcentaje[0], " %");
            carga2.Content = String.Concat(carga2.Content, porcentaje[1], " %");
            carga3.Content = String.Concat(carga3.Content, porcentaje[2], " %");
            carga4.Content = String.Concat(carga4.Content, porcentaje[3], " %");
            
            colorRopa(blanca, color, negra); //Crea los valores de ropa blanca, de color y negra


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

            //Ropa blanca
            blanca1Texto.Content = String.Concat("Ropa blanca: ", " ", blanca[0], " Kg");
            blanca2Texto.Content = String.Concat("Ropa blanca: ", " ", blanca[1], " Kg");
            blanca3Texto.Content = String.Concat("Ropa blanca: ", " ", blanca[2], " Kg");
            blanca4Texto.Content = String.Concat("Ropa blanca: ", " ", blanca[3], " Kg");
            
            //Ropa de color
            color1Texto.Content = String.Concat("Ropa de color: ", color[0], " Kg");
            color2Texto.Content = String.Concat("Ropa de color: ", color[1], " Kg");
            color3Texto.Content = String.Concat("Ropa de color: ", color[2], " Kg");
            color4Texto.Content = String.Concat("Ropa de color: ", color[3], " Kg");
            
            //Ropa negra
            negra1Texto.Content = String.Concat("Ropa negra: ", negra[0], " Kg");
            negra2Texto.Content = String.Concat("Ropa negra: ", negra[1], " Kg");
            negra3Texto.Content = String.Concat("Ropa negra: ", negra[2], " Kg");
            negra4Texto.Content = String.Concat("Ropa negra: ", negra[3], " Kg");

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            blanca[0] -= Convert.ToInt32(blanca1Descargada.Text);
            blanca[1] -= Convert.ToInt32(blanca2Descargada.Text);
            blanca[2] -= Convert.ToInt32(blanca3Descargada.Text);
            blanca[3] -= Convert.ToInt32(blanca4Descargada.Text);
            //
            color[0] -= Convert.ToInt32(color1Descargada.Text);
            color[1] -= Convert.ToInt32(color2Descargada.Text);
            color[2] -= Convert.ToInt32(color3Descargada.Text);
            color[3] -= Convert.ToInt32(color4Descargada.Text);
            //
            negra[0] -= Convert.ToInt32(negra1Descargada.Text);
            negra[1] -= Convert.ToInt32(negra2Descargada.Text);
            negra[2] -= Convert.ToInt32(negra3Descargada.Text);
            negra[3] -= Convert.ToInt32(negra4Descargada.Text);
            //
            for (int i = 0; i < 4; i += 1)      //Si se pone que se ha descargado más del peso que hay el peso pasa a 0
            {
                if (blanca[i] < 0)
                {
                    blanca[i] = 0;
                }
                if (color[i] < 0)
                {
                    color[i] = 0;
                }
                if (negra[i] < 0)
                {
                    negra[i] = 0;
                }
                colorRopa(blanca, color, negra);
            }
        }
    }
}
