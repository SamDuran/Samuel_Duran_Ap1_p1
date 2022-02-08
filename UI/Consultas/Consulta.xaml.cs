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
            switch(selComboBox.SelectedIndex)
            {
                case 0:
                lista = ProductosBLL.GetList();
                break;
            }

            productosDataGrid.ItemsSource = null;
            productosDataGrid.ItemsSource = lista;

        }
    } 
}