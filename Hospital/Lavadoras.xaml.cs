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


        //Constructores
        public Lavadoras(int[] Cargas)
        {
            InitializeComponent();
            int[] cargaLavadoras = Cargas;
            //Actualización de las etiquetas de cargas de cada lavadora en cada pestaña
            carga1.Content = String.Concat(carga1.Content, Cargas[0], " %");
            //2
            //3
            //4

            colorRopa(blanca, color, negra); //Crea los valores de ropa blanca, de color y negra

            
        }



        void colorRopa(int[] blanca, int[] color, int[] negra) //Establece y cambia el valor de las etiquetas, inicialmente y al descarglas
        {
            //Suponiendo que la carga máxima son 150kg (No pensé que dependiendo del color se lavaban separadas o juntas lmao)
            //Creación aleatoria de la ropa de distintos colores
            for (int i = 0; i < 4; i++)
            {
                blanca[i] = rnd.Next(0, 50);
                color[i] = rnd.Next(0, 50);
                negra[i] = 150 - (blanca[i] + color[i]);
            }

            
            //Ropa blanca
            blanca1Texto.Content = String.Concat(blanca1Texto.Content," ",blanca[0] , " Kg");
            


            //Ropa de color
            color1Texto.Content = String.Concat(color1Texto.Content, " ", negra[0], " Kg");
           


            //Ropa negra
            negra1Texto.Content = String.Concat(negra1Texto.Content, " ", negra[0], " Kg");

        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            blanca[0] -= Convert.ToInt32(blanca1Descargada);
            //
            color[0] -= Convert.ToInt32(color1Descargada);
            //
            negra[0] -= Convert.ToInt32(negra1Descargada);
            //
        }
    }
}
