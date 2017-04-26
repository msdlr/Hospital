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
//-------------------------//
using System.IO;
using Microsoft.Win32;

namespace prototipo_hospital
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 

    public partial class medico : Window
    {
        public Button boton1 = new Button();
        public Button boton = new Button();
        
        public int IDPaciente = 111222333;
       


        public Boolean pacienteCargado = false;
        public Boolean datosGuardados = false;
        public medico()
        {
            

            InitializeComponent();
            datosMedico medico = new datosMedico();
            
            nombreMedico.Content = medico.nombre ;
            idMedico.Content = medico.ID;
            //if (pacienteCargado == true) { menuPaciente.Visibility = Visibility.Visible; }


        }

        private void BotonGestionpaciente_Click(object sender, RoutedEventArgs e)
        {
            if (pacienteCargado == false)
            {
                NumeroPaciente abrirPaciente = new NumeroPaciente();
                abrirPaciente.Owner = this;
                abrirPaciente.ShowDialog();
                if (abrirPaciente.pacienteCorrecto == true)
                {
                    pacienteCargado = true;
                    datosPaciente paciente = new datosPaciente();
                    medicacionPaciente medicacion = new medicacionPaciente();
                    datosPaciente.Visibility = Visibility.Visible;
                    Nombre.Text = paciente.nombre;
                    Apellidos.Text = paciente.apellidos;
                    Edad.Text = paciente.edad.ToString();
                    Observaciones.Text = paciente.observaciones;
                    BotonGestionpaciente.IsEnabled = false;
                    gestionarPaciente.IsEnabled = false;
                    fechaNacimiento.Content = String.Concat("Fecha de Nacimiento: ", paciente.fechaNacimiento);
                    Sexo.Text = paciente.sexo[0];
                    
                }

            }

        }



        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void botonGuardarCambios_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("¿Desea guardar los datos introducidos?");
            datosGuardados = true;
        }

        private void botonSalida_Click(object sender, RoutedEventArgs e)
        {
            datosPaciente.Visibility = Visibility.Hidden;
            BotonGestionpaciente.IsEnabled = true;
            gestionarPaciente.IsEnabled = true;
            pacienteCargado = false;
            Nombre.Text = null;
            Apellidos.Text = null;
            Edad.Text = null;
            Observaciones.Text = null;
        }

        private void gestionarPaciente_Click(object sender, RoutedEventArgs e)
        {
            if (pacienteCargado == false)
            {
                NumeroPaciente abrirPaciente = new NumeroPaciente();
                abrirPaciente.Owner = this;
                abrirPaciente.ShowDialog();
                if (abrirPaciente.pacienteCorrecto == true)
                {
                    pacienteCargado = true;
                    datosPaciente paciente = new datosPaciente();

                    datosPaciente.Visibility = Visibility.Visible;
                    Nombre.Text = paciente.nombre;
                    Apellidos.Text = paciente.apellidos;
                    Edad.Text = paciente.edad.ToString();
                    Observaciones.Text = paciente.observaciones;
                    BotonGestionpaciente.IsEnabled = false;
                    gestionarPaciente.IsEnabled = false;
                    fechaNacimiento.Content = String.Concat("Fecha de Nacimiento: ", paciente.fechaNacimiento);
                    Sexo.Text = paciente.sexo[0];

                }

            }
        }

        private void nuevaConsulta_Click(object sender, RoutedEventArgs e)
        {
            datosPaciente paciente2 = new datosPaciente();
            informedeConsulta nuevaConsulta = new informedeConsulta(paciente2);
            nuevaConsulta.ShowDialog();

        }
//borrar este metodo
        private void boton1_click(object sender, RoutedEventArgs e)
        {
            datosPaciente paciente2 = new datosPaciente();
            informedeConsulta nuevaConsulta = new informedeConsulta(paciente2);
            nuevaConsulta.ShowDialog();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listaMedicacion.ItemsSource = new medicacionPaciente[]
            {
                new medicacionPaciente{ Nombre = "Medicacion 1", Codigo= "1", Descripcion="medicacion 1", UltimaFecha= "21/3/2016"},
                new medicacionPaciente{ Nombre = "Medicacion 2", Codigo= "1", Descripcion="medicacion 2", UltimaFecha= "21/3/2016"},
                new medicacionPaciente{ Nombre = "Medicacion 3", Codigo= "1", Descripcion="medicacion 3", UltimaFecha= "21/3/2016"},
                new medicacionPaciente{ Nombre = "Medicacion 4", Codigo= "1", Descripcion="medicacion 4", UltimaFecha= "21/3/2016"},
                new medicacionPaciente{ Nombre = "Medicacion 5", Codigo= "1", Descripcion="medicacion 5", UltimaFecha= "21/3/2016"},
                new medicacionPaciente{ Nombre = "Medicacion 6", Codigo= "1", Descripcion="medicacion 6", UltimaFecha= "21/3/2016"},
                //boton1_click = boton.Click;
            };
        }
    }
}
