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
    /// Lógica de interacción para Agenda_Personal.xaml
    /// </summary>
    public partial class Agenda_Personal : Window
    {
        public Agenda_Personal()
        {
            InitializeComponent();
            actividades.FontSize = 18 ;
            actividades.Content = string.Concat("Actividades para hoy: ", DateTime.Today.ToShortDateString());

        }

       


    }
}
