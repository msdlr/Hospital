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
using System.Windows.Threading;

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
        //consulta anterior
        public string motivoconsulta = "Refiere dolor torácico, presion en el pecho y falta de respiración";
        public string antecedentesPersonales = "No fumador, sin cardiopatía ni neumonía conocída, en tratamiento por rinitis alergica. HErnia de hiato, Tratamiento actual:" +
            "Atorvastina, Ebastina. Cirugias previas: Colesteatoma y timpanoplastia.";
        public string enfermedadActual = "Acude a consulta por malestar general y opresion percordial de varios dias de evolución";
        public string exploracionFisica = "AC tonos ritmicos, AP normal";
        public string diagnostico = "Posible pericarditis aguda o crisis hipertensiva. Tratamiento: buprofeno 600 cada 12 horas durante una semana, Colchicina 1mg, 1 comprimido diario.";

    }
    public class medicacionPaciente : Object
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string UltimaFecha { get; set; }
        public Image imagen { get; set; }
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
            startclock();


        }

        private void startclock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();
        }

        private void tickevent(object sender, EventArgs e)
        {
            reloj.Text = DateTime.Now.ToString();
        }

        private void mainAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (user.Text != pswd.Password)
            {
                MessageBox.Show("Los datos introducidos son incorrectos");
            }

            if (user.Text.Length == 0 && pswd.Password.Length == 0)
            {
                MessageBox.Show("Los datos introducidos son incorrectos");
            }

            if (user.Text.Length != pswd.Password.Length )
            {
                MessageBox.Show("Los datos introducidos son incorrectos");
            }


            if (user.Text == "medico" && pswd.Password == "medico")
            {

                medico gestionPaciente = new medico();
                this.Hide();
                gestionPaciente.ShowDialog();
                this.Show();
                user.Text = null;
                pswd.Password = null;

            }

            else if (user.Text == "farmaceutico" && pswd.Password == "farmaceutico")
            {

                Farmacia farmacia = new Farmacia();
                this.Hide();
                farmacia.ShowDialog();
                this.Show();
                user.Text = null;
                pswd.Password = null;

            }

            else if (user.Text == "lavanderia" && pswd.Password == "lavanderia")
            {
                Lavanderia lavanderia = new Lavanderia();
                this.Hide();
                lavanderia.ShowDialog();
                this.Show();
                user.Text = null;
                pswd.Password = null;
            }

            else if (user.Text == "cocina" && pswd.Password == "cocina")
            {
                Cocina cocina = new Cocina();
                this.Hide();
                cocina.ShowDialog();
                this.Show();
                user.Text = null;
                pswd.Password = null;

            }

            else if (user.Text == "gestionpersonal" && pswd.Password == "gestionpersonal")
            {
                gestionPersonal gestion_personal = new gestionPersonal();
                this.Hide();
                gestion_personal.ShowDialog();
                this.Show();
                user.Text = null;
                pswd.Password = null;

            }
            else if (user.Text == "gestionpacientes" && pswd.Password == "gestionpacientes")
            {
                gestionPacientes gestion_pacientes = new gestionPacientes();
                this.Hide();
                gestion_pacientes.ShowDialog();
                this.Show();
                user.Text = null;
                pswd.Password = null;

            }




        }

        private void autores_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Miguel Sanchez de la Rosa: Lavanderia y pantalla de login."+ Environment.NewLine +"Pablo Gomariz Martinez: Medico y Gestion de Citas." + Environment.NewLine +
                "Jesús Gonzalez Cebrián: Farmacia y Gestion de personal."+ Environment.NewLine + "David Parra Horcajada: Cocina.");
        }

        public void manual_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Usuario y contraseña para acceder a las ventanas:" + Environment.NewLine + " Lavanderia: lavanderia" + Environment.NewLine +
                "Medico: medico" + Environment.NewLine + " Farmacia: farmaceutico" + Environment.NewLine + "Gestion de Citas: gestionpacientes" + Environment.NewLine + "Gestion de personal: gestionpersonal"
                + Environment.NewLine + "Cocina: cocina" + Environment.NewLine + "El numero de paciente de ejemplo para cargar es: 111222333");
        }
    }
}

