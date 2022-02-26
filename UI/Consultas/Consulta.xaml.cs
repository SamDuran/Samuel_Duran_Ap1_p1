using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Samuel_Duran_Ap1_p1_.BLL;
using Samuel_Duran_Ap1_p1_.Entidades;

namespace Samuel_Duran_Ap1_p1_.UI.Consultas
{
    public partial class Consulta : Window
    {

        public Consulta()
        {
            InitializeComponent();
        }
        private void BuscarBTN_Click(object sander, RoutedEventArgs e)
        {
            var lista = new List<Productos>();

            if(criterioTextBox.Text.Length>0)
            {
                switch(selComboBox.SelectedIndex)
                {
                    case 0:
                    {
                        lista = ProductosBLL.GetList(e => e.ProductoId == Convert.ToInt32(criterioTextBox.Text));
                        break;
                    }
                    case 1:
                    {
                        lista = ProductosBLL.GetList(e => e.Descripcion.Contains(criterioTextBox.Text, StringComparison.OrdinalIgnoreCase));
                        break;
                    }
                }
            }else
            {
                lista = ProductosBLL.GetList(e => true);
            }
            productosDataGrid.ItemsSource = null;
            productosDataGrid.ItemsSource = lista;
        }
    } 
}