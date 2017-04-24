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
    /// Lógica de interacción para Farmacia.xaml
    /// </summary>
    public partial class Farmacia : Window
    {
        public Farmacia()
        {
            InitializeComponent();
            datosFarmacia farmaceutico = new datosFarmacia();
            nombreFarmaceutico.Content = farmaceutico.nombre;
            idFarmaceutico.Content = farmaceutico.ID;
        }

        public class AlmacenMedicamentos : Object
        {
            public string NombreMed { get; set; }
            public string Descripcion { get; set; }
            public double Codigo { get; set; }
            public double Existencias { get; set; }
        }

        //Valores fijos
        private string[] S_NombreMed = { "Formoterol", "Abasaglar", "Loxapina" };
        private string[] S_Descrpcion = { "Para el aparato respiratorio, administrado por vía inhalatoria", "Insulina, glargina", "Para el aparato respiratorio, administrado por vía inhalatoria" };
        private double[] S_Codigo = { 0123456789, 9876543210, 0246813579 };
        //private double[] S_Existencias = { 100, 100, 100};

        public class Habitaciones : Object
        {
            public double NumHabitacion { get; set; }
            public double NumPacientes { get; set; }
        }

        private double[] S_NumHabitacion = { 1, 2, 3 };             //Valor fijo
        private double[] S_NumPacientes = { 4, 5, 2 };              //Valor no fijo

        public class Datos : Object
        {
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public string Medicamentos { get; set; }
            public Sexo Sexo { get; set; }
        }

        //Valores no fijos


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            /*
            int i;

            for (i = 0; i < S_NumHabitacion.Length; i++)
            {
                medicamentos.ItemsSource = new Habitaciones[i];
                {
                    new Habitaciones {NumHabitacion = S_NumHabitacion[i], NumPacientes = S_NumPacientes[i] };
                }
            }

            for (i = 0; i < S_NombreMed.Length; i++)
            {
                habitaciones.ItemsSource = new AlmacenMedicamentos[i];
                {
                    new AlmacenMedicamentos { NombreMed = S_NombreMed[i], Descripcion = S_Descrpcion[i], Existencias = 100, Codigo = S_Codigo[i] };
                }
            }
            */
            //Deja de funcionar cuando entras a farmacia

            habitaciones.ItemsSource = new Habitaciones[]
            {
                new Habitaciones{NumHabitacion = S_NumHabitacion[0], NumPacientes = S_NumPacientes[0]},
                new Habitaciones{NumHabitacion = S_NumHabitacion[1], NumPacientes = S_NumPacientes[1]},
            };

            medicamentos.ItemsSource = new AlmacenMedicamentos[]
            {
                new AlmacenMedicamentos{NombreMed = S_NombreMed[0], Descripcion = S_Descrpcion[0], Existencias = 100, Codigo = S_Codigo[0] },
                new AlmacenMedicamentos{NombreMed = S_NombreMed[1], Descripcion = S_Descrpcion[1], Existencias = 100, Codigo = S_Codigo[1] },
                new AlmacenMedicamentos{NombreMed = S_NombreMed[2], Descripcion = S_Descrpcion[2], Existencias = 100, Codigo = S_Codigo[2] },
            };


            datosPacientes.ItemsSource = new Datos[]
            {
                new Datos{Nombre = "Jose", Apellidos = "Gomez Escudero", Medicamentos = S_NombreMed[0], Sexo = Sexo.Hombre },
                new Datos{Nombre = "Laura", Apellidos = "Sanchez Pedregal", Medicamentos = S_NombreMed[1], Sexo = Sexo.Mujer }
            };
        }

        public enum Sexo
        {
            Hombre,
            Mujer
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult key = MessageBox.Show("Are your sure you want to quit", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            e.Cancel = (key == MessageBoxResult.No);
        }
        private void botonSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}


