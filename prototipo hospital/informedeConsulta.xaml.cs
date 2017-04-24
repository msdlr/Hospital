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
    /// Lógica de interacción para informedeConsulta.xaml
    /// </summary>
    public partial class informedeConsulta : Window
    {
        public informedeConsulta()
        {
            InitializeComponent();
        }

        public informedeConsulta(datosPaciente paciente)
        {
            InitializeComponent();
            Nombre.Text = paciente.nombre;
            Apellidos.Text = paciente.apellidos;
            Edad.Text = paciente.edad.ToString();
            fechaNacimiento.DisplayDate = paciente.fechaNacimiento;
            Sexo.Text = paciente.sexo[0];
            direccion.Text = paciente.direccion;
            telefono.Text = paciente.telefono.ToString();
        }


        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
