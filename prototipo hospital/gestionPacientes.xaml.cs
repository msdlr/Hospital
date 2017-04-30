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
    /// Lógica de interacción para gestionPacientes.xaml
    /// </summary>
    public partial class gestionPacientes : Window
    {
        public Boolean esp = false;
         
        public Boolean pacienteCargado = false;

        public string textoEspecialista = null;
        public gestionPacientes()
        {
            InitializeComponent();
        }

        private void citarPaciente_Click(object sender, RoutedEventArgs e)
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
                    gridPaciente.Visibility = Visibility.Visible;


                    Nombre.Text = paciente.nombre;
                    Apellidos.Text = paciente.apellidos;
                    Edad.Text = paciente.edad.ToString();
                    
                    direccion.Text = paciente.direccion;
                    telefono.Text = paciente.telefono.ToString();
                    
                    gestionarPaciente.IsEnabled = false;
                    fechaNacimiento.Content = String.Concat("Fecha de Nacimiento: ", paciente.fechaNacimiento);
                    Sexo.Text = paciente.sexo[0];
                    salirPaciente.Visibility = Visibility.Visible;
                    volanteEspecialista.Visibility = Visibility.Visible;

                }

            }
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void salirPaciente_Click(object sender, RoutedEventArgs e)
        {
            gridPaciente.Visibility = Visibility.Hidden;
            Nombre.Text = null;
            Apellidos.Text = null;
            Edad.Text = null;

            direccion.Text = null;
            telefono.Text = null;

            gestionarPaciente.IsEnabled = true;
            fechaNacimiento.Content = null;
            Sexo.Text = null;
            salirPaciente.Visibility = Visibility.Hidden;
            volanteEspecialista.Visibility = Visibility.Hidden;
            pacienteCargado = false;
        }

        private void confirmarCita_Click(object sender, RoutedEventArgs e)
        {
            if(fechaDisponible.SelectedDate == null || horario.Text == null)
            {
                MessageBox.Show("Por favor, seleccione la hora y el dia");
            }
            else {
                MessageBox.Show(string.Concat("Cita expedida para el dia " + fechaDisponible.SelectedDate.Value.Date.ToShortDateString() + "a las " + horario.Text));
                especialista_grid.Visibility = Visibility.Hidden;
                Nombre.Text = null;
                Apellidos.Text = null;
                Edad.Text = null;

                direccion.Text = null;
                telefono.Text = null;

                gestionarPaciente.IsEnabled = true;
                fechaNacimiento.Content = null;
                Sexo.Text = null;
                salirPaciente.Visibility = Visibility.Hidden;
                volanteEspecialista.Visibility = Visibility.Hidden;
                pacienteCargado = false;
                gridPaciente.Visibility = Visibility.Hidden;

            }
            
        }


        RadioButton[] especialidades = new RadioButton[15];
        private void Especialista_Checked(object sender, RoutedEventArgs e)
        {

            especialidades[0] = Especialista;
            especialidades[1] = Especialista_Copy;
            especialidades[2] = Especialista_Copy1;
            especialidades[3] = Especialista_Copy2;
            especialidades[4] = Especialista_Copy3;
            especialidades[5] = Especialista_Copy4;
            especialidades[6] = Especialista_Copy5;
            especialidades[7] = Especialista_Copy6;
            especialidades[8] = Especialista_Copy7;
            especialidades[9] = Especialista_Copy8;

            especialidades[10] = Especialista_Copy9;
            especialidades[11] = Especialista_Copy10;
            especialidades[12] = Especialista_Copy11;
            especialidades[13] = Especialista_Copy12;
            especialidades[14] = Especialista_Copy13;
            if (especialidades[14].IsChecked == true)
            {
                listaCirugía.Visibility = Visibility.Visible;
            }

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            especialidades[0] = Especialista;
            especialidades[1] = Especialista_Copy;
            especialidades[2] = Especialista_Copy1;
            especialidades[3] = Especialista_Copy2;
            especialidades[4] = Especialista_Copy3;
            especialidades[5] = Especialista_Copy4;
            especialidades[6] = Especialista_Copy5;
            especialidades[7] = Especialista_Copy6;
            especialidades[8] = Especialista_Copy7;
            especialidades[9] = Especialista_Copy8;

            especialidades[10] = Especialista_Copy9;
            especialidades[11] = Especialista_Copy10;
            especialidades[12] = Especialista_Copy11;
            especialidades[13] = Especialista_Copy12;
            especialidades[14] = Especialista_Copy13;



            if (especialidades[14].IsChecked == true)
            {
                RadioButton[] cirujanos = new RadioButton[6];
                cirujanos[0] = cirugia0;
                cirujanos[1] = cirugia1;
                cirujanos[2] = cirugia2;
                cirujanos[3] = cirugia3;
                cirujanos[4] = cirugia4;
                cirujanos[5] = cirugia5;



            }



        }
        private void volante_especialista_Click(object sender, RoutedEventArgs e)
        {
            especialista_grid.Visibility = Visibility.Visible;
        }

    }
}
