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
using System.Xml;
using System.Xml.Linq;
using System.Windows.Xps.Packaging;

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
            nombreMedico.Content = medico.nombre;
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
                    direccion.Text = paciente.direccion;
                    telefono.Text = paciente.telefono.ToString();
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
                    direccion.Text = paciente.direccion;
                    telefono.Text = paciente.telefono.ToString();
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




        private void botonCitas_Click(object sender, RoutedEventArgs e)
        {
            Agenda_Personal agenda = new Agenda_Personal();
            agenda.ShowDialog();
        }

        private void imagen_radiografia(object sender, RoutedEventArgs e){

            if (radio1.IsChecked == true)
            {
                imagendePrueba.Source = new BitmapImage(new Uri(@"/planta_craneo.jpg", UriKind.Relative));
                visorDocumentos.Visibility = Visibility.Hidden;
            }
            if (radio2.IsChecked == true)
            {
                imagendePrueba.Source = new BitmapImage(new Uri(@"/perfil_craneo.jpg", UriKind.Relative));
                visorDocumentos.Visibility = Visibility.Hidden;
            }
            if (radio3.IsChecked == true)
            {
                imagendePrueba.Source = new BitmapImage(new Uri(@"/frente_craneo.jpg", UriKind.Relative));
                visorDocumentos.Visibility = Visibility.Hidden;
            }


        }

        private void verAnalitica_Click(object sender, RoutedEventArgs e)
        {


            visorDocumentos.Visibility = Visibility.Visible;
            XpsDocument document1 = new XpsDocument(Environment.CurrentDirectory+@"/analitica.xps", System.IO.FileAccess.Read);
            visorDocumentos.Document = document1.GetFixedDocumentSequence();
        }

        private void verConsulta_Click(object sender, RoutedEventArgs e)
        {
            Boolean tratamiento = new Boolean();
            tratamiento = true;
            datosPaciente paciente3 = new datosPaciente();
            informedeConsulta nuevaConsulta2 = new informedeConsulta(paciente3, tratamiento);
           
            nuevaConsulta2.ShowDialog();
        }

        private void imprimir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Receta Impresa");
        }

        private void enviarSalir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Enviado");
            receta.Visibility = Visibility.Hidden;
        }

        private void nuevaReceta_Click(object sender, RoutedEventArgs e)
        {
            datosMedico medico2 = new datosMedico();
            prescripcion.Text = "Ej: Senioral 20 comprimidos";
            unidades.Text = "Ej:1";
            fechareceta = null;
            intervalo.Text = "12 Horas";
            duradion.Text = "Ej:3";
            nombreMedico2.Content = medico2.nombre;
            idMedico2.Content = medico2.ID;
            receta.Visibility = Visibility.Visible;
        }

        private void imagen_cirugia(object sender, RoutedEventArgs e)
        {

            if (radiocirugia.IsChecked == true)
            {
                 imagenCirugia.Source = new BitmapImage(new Uri(@"/timpanoplastia.jpg", UriKind.Relative));
            }

        }

        private void verEcografia_Click(object sender, RoutedEventArgs e)
        {
            radiocirugia.IsChecked = false;
            imagenCirugia.Source = new BitmapImage(new Uri(@"/litotricia.jpg", UriKind.Relative));
        }

        private void ingreso_Checked(object sender, RoutedEventArgs e)
        {
            if (checkIngreso.IsChecked == true)
            {
                fechaIngreso.IsEnabled = true;
                fechaAlta.IsEnabled = true;
                Habitacion.IsEnabled = true;
            }

            if (checkIngreso.IsChecked == false)
            {
                fechaIngreso.IsEnabled = false;
                fechaAlta.IsEnabled = false;
                Habitacion.IsEnabled = false;
            }
        }

        private void checkcirugia_Click(object sender, RoutedEventArgs e)
        {
            if (checkcirugia.IsChecked == true)
            {
                listacuras.Visibility = Visibility.Visible;
            }

            if (checkcirugia.IsChecked == false)
            {
                listacuras.Visibility = Visibility.Hidden;
            }
        }

        private void cura1_Click(object sender, RoutedEventArgs e)
        {
            if(cura1.IsChecked == true)
            {
                MessageBox.Show("En la primera sesión se limpió la cicatriz de la operación.");
            }


        }


        private void cura2_Click(object sender, RoutedEventArgs e)
        {
            if (cura1.IsChecked == true)
            {
                MessageBox.Show("En la segunda sesión se procede a quitar el algodon incrustado en el conducto auditivo.");
            }


        }

        private void cura3_Click(object sender, RoutedEventArgs e)
        {
            if (cura1.IsChecked == true)
            {
                MessageBox.Show("Ultima limpieza del conducto auditivo y examen del cerumen.");
            }


        }
        private void rehab_click(object sender, RoutedEventArgs e)
        {
            if (rehabilitacion.IsChecked == true) {
                web.Visibility = Visibility.Visible;
                web.Navigate("https://www.google.es/search?q=clinica+de+rehabilitacion&oq=clinica+de+rehabilitacion&aqs=chrome..69i57j0l5.4000j0j7&sourceid=chrome&ie=UTF-8#q=clinica+de+rehabilitacion&rflfq=1&rlha=0&rllag=38992869,-1854415,803&tbm=lcl&tbs=lrf:!2m1!1e2!2m1!1e3!3sEAE,lf:1,lf_ui:2&rlfi=hd:;si:;mv:!1m3!1d30883.80366436429!2d-1.8470641263671723!3d38.98559288095868!3m2!1i604!2i478!4f13.1;tbs:lrf:!2m1!1e2!2m1!1e3!3sEAE,lf:1,lf_ui:2");

                }

            if (rehabilitacion.IsChecked == false)
            {
                web.Visibility = Visibility.Hidden;
            }
        }

        private void leeme_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Haga click en todos los check box o radiobuttons" +Environment.NewLine + "para ver todas las acciones del prototipo");
        }

    }
}
