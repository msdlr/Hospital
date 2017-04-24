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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prototipo_hospital
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 
    

    public class datosMedico : Object
    {
        public string nombre = "Jose Manuel Martinez";
        public string ID = "589654DE";
        public string usuario = "medico";
        public string password = "medico";
    }
    public class datosFarmacia : Object
    {
        public string nombre = "Leopoldo Torres";
        public string ID = "557954DE";
        public string usuario = "farmaceutico";
        public string password = "farmaceutico";

    }

    public class datosPaciente : Object
    {
        public string nombre = "Virginia";
        public string apellidos = "Romero Lopez";
        public int edad = 25;
        public string[] sexo = { "Mujer", "Hombre" };

        public string numeroSS = "986458497H";
        public string alergias = "lista de alergias";
        public string observaciones = "observaciones";
        public string fechaNacimiento = "24/07/1992";
        public string direccion = "Melchor de Macanaz 27, 1ºD, Albacete";
        public int telefono = 685757853;

    }
	public class datosLavanderia : Object
	{
		public string nombre = "Jose Martinez ";
        public string ID = "34516887H";
        public string usuario = "lavanderia";
        public string password = "lavanderia";
	}

    public partial class MainWindow : Window
        {



            public MainWindow()
            {
                InitializeComponent();
            

            }

            private void mainAceptar_Click(object sender, RoutedEventArgs e)
            {
                if (user.Text == "medico" && pswd.Password == "medico")
                {
                    medico gestionPaciente = new medico();
                    gestionPaciente.ShowDialog();
                    user.Text = null;
                    pswd.Password = null;
                }

                else if (user.Text == "farmaceutico" && pswd.Password == "farmaceutico")
                {

                Farmacia farmacia = new Farmacia();
                farmacia.ShowDialog();
                user.Text = null;
                pswd.Password = null;

                }
                
				else if (user.Text == "lavanderia" && pswd.Password == "lavanderia")
				{
                Lavanderia lavanderia = new Lavanderia();
				lavanderia.ShowDialog();
				user.Text = null;
                pswd.Password = null;
				}
                
            }
    }

    }

