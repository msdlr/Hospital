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


    }
}
