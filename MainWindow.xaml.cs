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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Samuel_Duran_Ap1_p1_.UI.Consultas;
using Samuel_Duran_Ap1_p1_.UI.Registros;

namespace Samuel_Duran_Ap1_p1_
{
    /// <summary>
    /// Programa de gestion de productos de colmado
    /// </summary>
    //Primer parcial aplicada 1. Samuel Duran 2019-0793 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void rMenuItem_Click(object sander, RoutedEventArgs e){
            Registro registro = new Registro();
            registro.Show();
        }
        private void cMenuItem_Click(object sander, RoutedEventArgs e){
            Consulta consulta = new Consulta();
            consulta.Show();
        }
    }
}
