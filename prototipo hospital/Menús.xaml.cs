﻿using System;
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
    /// Lógica de interacción para Menús.xaml
    /// </summary>
    public partial class Menús : Window
    {
        public Menús()
        {
            InitializeComponent();
        }

        private void Cerrar(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
    }
}
