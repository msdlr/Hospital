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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //String departamento;
        public MainWindow()
        {
            InitializeComponent();


            Lavanderia ventana = new Lavanderia();
            ventana.ShowDialog();
            
        }
        public void mainLoading()
        {
            Loading loading = new Loading();    //Crea instancia de nueva ventana 
            loading.ShowDialog();               //Abre la instancia
        }

        private void mainAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (user.Text == "close" && pswd.Password == "close")
            {
                mainLoading();
               
            }
            else if (user.Text == "Med" && pswd.Password == "Med")
            {
                mainLoading();

                //this.Close();                       //Cierra la ventana anterior
            }
            else if (user.Text == "Lav" && pswd.Password == "Lav")
            {
                mainLoading();
                Lavanderia lavanderia = new Lavanderia();
                lavanderia.ShowDialog();
                this.Close();
            }
            /*else if (user.Text == "Med" && pswd.Password == "Med")
            {
                this.Close();
            }
            */ 
            // Repetir hasta el hartazgo

            else // Contraseña y usuario incorrectos
            {

            }
        }
    }



    }

