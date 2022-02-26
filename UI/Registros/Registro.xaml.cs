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
using Samuel_Duran_Ap1_p1_.Entidades;
using Samuel_Duran_Ap1_p1_.BLL;

namespace Samuel_Duran_Ap1_p1_.UI.Registros
{
    public partial class Registro : Window{
        Productos producto = new Productos();
        public Registro()
        {
            InitializeComponent();
            this.DataContext = producto;
        }
        private void Limpiar(){
            this.producto = new Productos();
            this.DataContext = producto;
        }

        private bool Validar(){
            bool esValido = false;
            Productos aBuscar = ProductosBLL.Buscar(Convert.ToInt32(productoIDTextBox.Text));
            if((productoIDTextBox.Text.Length != 0 && !ProductosBLL.Existe(descripcionTextBox.Text)) ||(aBuscar.Descripcion.Equals(producto.Descripcion) && aBuscar.ProductoId.Equals(producto.ProductoId)))
            {
                esValido = true;
            }
            return esValido;
        }
        private void Cargar(){
            this.DataContext=producto;
        }
        private void buscarBtn_Click(object sander, RoutedEventArgs e){
            var productos = ProductosBLL.Buscar(Convert.ToInt32(productoIDTextBox.Text));
            if(productos!=null)
            {
                this.producto=productos;
                Cargar(); //Solo faltaba cargar :c
            }
            else
            {
                this.producto = new Productos();
                MessageBox.Show("No fue encontrado","Error");
            }
        }
        private void guardarBtn_Click(object sander, RoutedEventArgs e){
            if(!Validar())
            {
                MessageBox.Show("No se puede guardar. Verifique los datos.", "Error");
                return;
            }

            var paso = ProductosBLL.Guardar(this.producto);

            if(paso)
            {
                ValorInventarioTextBox.Text=(producto.Costo* producto.Existencia).ToString();
                MessageBox.Show("¡Se guardó el producto exitosamente!", "Aviso");
                Limpiar();
            }else
            {
                MessageBox.Show("No se pudo guardar el producto :c", "Error");
            }
        }
        private void eliminarBtn_Click(object sander, RoutedEventArgs e){
            if(ProductosBLL.Eliminar(Convert.ToInt32(productoIDTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Producto eliminado!","Aviso");
            }else
            {
                MessageBox.Show("El Producto no pudo ser eliminado","Aviso");
            }
        }
        private void nuevoBtn_Click(object sander, RoutedEventArgs e){
            Limpiar();
        }
    }
}