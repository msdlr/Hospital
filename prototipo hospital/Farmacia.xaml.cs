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
            this.Urgente();
            datosFarmacia farmaceutico = new datosFarmacia();
            nombreFarmaceutico.Content = farmaceutico.nombre;
            idFarmaceutico.Content = farmaceutico.ID;
        }

        public void Urgente()
        {
            listaUrgencias.Items.Clear();
            CheckBox listaU = null;
            foreach (string listaUr in MedicinaUrgente)
            {
                listaU = new CheckBox();
                listaU.Margin = new Thickness(0, 0, 0, 10);
                listaU.Content = listaUr;
                listaUrgencias.Items.Add(listaU);
            }
        }
        private string[] MedicinaUrgente = { "Formoterol", "Abasaglar" };

        public class AlmacenMedicamentos : Object
        {
            public string NombreMedicamento { get; set; }
            public string Descripcion { get; set; }
            public double Codigo { get; set; }
            public double Existencias { get; set; }
        }


        //Valores fijos
        private string[] S_NombreMed = { "Formoterol", "Abasaglar", "Loxapina" };
        private string[] S_Descrpcion = { "Para el aparato respiratorio, administrado por vía inhalatoria", "Insulina, glargina", "Para el aparato respiratorio, administrado por vía inhalatoria" };
        private double[] S_Codigo = { 0123456789, 9876543210, 0246813579 };
        //private double[] S_Existencias = { 1000, 1000, 1000};

        public class AlmacenPedidos : Object
        {
            public Boolean Recibido { get; set; }
            public string NombrePedido { get; set; }
            public string FechaDePedida { get; set; }
            public string EstimacionDeLlegada { get; set; }
        }



        public class Habitaciones : Object
        {
            public double NumeroHabitacion { get; set; }
            public double NumeroPacientes { get; set; }
            public double Urgencias { get; set; }
        }

        private double[] S_NumHabitacion = { 000, 100, 200 };           //Valor fijo
        private double[] S_NumPacientes = { 4, 5, 2 };                  //Valor no fijo
        private double[] S_Urgencias = { 0, 1, 1 };                     //Valor no fijo

        public class Datos : Object
        {
            public string Nombre { get; set; }
            public string Medicamentos { get; set; }
            public Sexo Sexo { get; set; }
            public string DNI { get; set; }
        }

        //Valores no fijos


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            datosPedidos.ItemsSource = new AlmacenPedidos[]
            {
                new AlmacenPedidos{ Recibido = true, NombrePedido = S_NombreMed[0], FechaDePedida = "18/04/2017", EstimacionDeLlegada = "20/04/2017" },
                new AlmacenPedidos{ Recibido = false, NombrePedido = S_NombreMed[1], FechaDePedida = "19/04/2017", EstimacionDeLlegada = "21/04/2017" },
                new AlmacenPedidos{ Recibido = false, NombrePedido = S_NombreMed[2], FechaDePedida = "20/04/2017", EstimacionDeLlegada = "23/04/2017" }
            };

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
                new Habitaciones{NumeroHabitacion = S_NumHabitacion[0], NumeroPacientes = S_NumPacientes[0], Urgencias = S_Urgencias[0]},
                new Habitaciones{NumeroHabitacion = S_NumHabitacion[1], NumeroPacientes = S_NumPacientes[1], Urgencias = S_Urgencias[1]},
                new Habitaciones{NumeroHabitacion = S_NumHabitacion[2], NumeroPacientes = S_NumPacientes[2], Urgencias = S_Urgencias[2]}
            };

            medicamentos.ItemsSource = new AlmacenMedicamentos[]
            {
                new AlmacenMedicamentos{NombreMedicamento = S_NombreMed[0], Descripcion = S_Descrpcion[0], Existencias = 1000, Codigo = S_Codigo[0] },
                new AlmacenMedicamentos{NombreMedicamento = S_NombreMed[1], Descripcion = S_Descrpcion[1], Existencias = 800, Codigo = S_Codigo[1] },
                new AlmacenMedicamentos{NombreMedicamento = S_NombreMed[2], Descripcion = S_Descrpcion[2], Existencias = 500, Codigo = S_Codigo[2] },
            };


            habitacion0.ItemsSource = new Datos[]
            {
                new Datos{Nombre = "Gomez Escudero, Jose", Medicamentos = S_NombreMed[0], Sexo = Sexo.Hombre, DNI = "45682635L" },
                new Datos{Nombre = "Sanchez Pedregal, Laura", Medicamentos = S_NombreMed[1], Sexo = Sexo.Mujer, DNI = "25639856G" }
            };

            habitacion1.ItemsSource = new Datos[]
            {
                new Datos{Nombre = "Pete Petrola, Pablo", Medicamentos = S_NombreMed[0], Sexo = Sexo.Hombre, DNI = "45652451P" },
                new Datos{Nombre = "Gomariz Saelices, Rosa", Medicamentos = S_NombreMed[2], Sexo = Sexo.Mujer , DNI = "78963254F" }
            };

            habitacion2.ItemsSource = new Datos[]
            {
                new Datos{Nombre = "Hidalgo Diestro, Pedro", Medicamentos = S_NombreMed[2], Sexo = Sexo.Hombre },
                new Datos{Nombre = "Gonzalez Madrigal, Ester", Medicamentos = S_NombreMed[1], Sexo = Sexo.Mujer }
            };
        }

        public enum Sexo
        {
            Hombre,
            Mujer
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult key = MessageBox.Show("¿Seguro que quieres salir?", "Aceptar", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            e.Cancel = (key == MessageBoxResult.No);
        }
        private void botonSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void pedido_Click(object sender, RoutedEventArgs e)
        {
            Pedidos hacerPedido = new Pedidos();
            hacerPedido.ShowDialog();
        }

        private void ver_Click(object sender, RoutedEventArgs e)
        {
            if (habitacion1.Visibility == Visibility.Visible)
            {
                habitacion1.Visibility = Visibility.Hidden;
                habitacion0.Visibility = Visibility.Visible;
            }
            habitacion1.Visibility = Visibility.Visible;
        }
        private void mapa_Click(object sender, RoutedEventArgs e)
        {
            Mapa mapahabitacion = new Mapa();
            mapahabitacion.ShowDialog();
        }
    }
}


