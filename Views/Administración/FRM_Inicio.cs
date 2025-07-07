using Hidrobo_T1S6.Controller;
using Hidrobo_T1S6.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hidrobo_T1S6.Views.Administración
{
    public partial class FRM_Inicio : Form
    {
        private ProductoController controller = new ProductoController();
        private int productoIdSeleccionado = 0;
        private List<ProductoModel> listaProductos = new List<ProductoModel>();

        public FRM_Inicio()
        {
            InitializeComponent();
        }

        private void FRM_Inicio_Load(object sender, EventArgs e)
        {
            MostrarTodosEnLista();
        }

        private void MostrarTodosEnLista()
        {
            listaProductos = controller.ObtenerTodos();
            lst_Datos.Items.Clear();

            foreach (var p in listaProductos)
            {
                lst_Datos.Items.Add(
                    $"Producto: {p.Nombre} | Lote: {p.Lote} | Ingreso: {p.FechaIngreso.ToShortDateString()} | Caduca: {p.FechaCaducidad.ToShortDateString()} | Proveedor: {p.Proveedor} | Stock: {p.Stock} | Precio: {p.PrecioUnitario:C}"
                );
            }
        }

        private void lst_Datos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Datos.SelectedIndex >= 0)
            {
                var producto = listaProductos[lst_Datos.SelectedIndex];
                productoIdSeleccionado = producto.ProductoId;

                txt_NombreProducto.Text = producto.Nombre;
                txt_Lote.Text = producto.Lote;
                time_Ingreso.Value = producto.FechaIngreso;
                time_Caducidad.Value = producto.FechaCaducidad;
                txt_Proveedor.Text = producto.Proveedor;
                txt_Stock.Text = producto.Stock.ToString();
                txt_PrecioUnitario.Text = producto.PrecioUnitario.ToString();
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_NombreProducto.Text) ||
                string.IsNullOrWhiteSpace(txt_Lote.Text) ||
                string.IsNullOrWhiteSpace(txt_Proveedor.Text) ||
                string.IsNullOrWhiteSpace(txt_Stock.Text) ||
                string.IsNullOrWhiteSpace(txt_PrecioUnitario.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            if (!int.TryParse(txt_Stock.Text, out int stock))
            {
                MessageBox.Show("Stock debe ser un número entero válido.");
                return;
            }

            if (!decimal.TryParse(txt_PrecioUnitario.Text, out decimal precio))
            {
                MessageBox.Show("Precio Unitario debe ser un número válido.");
                return;
            }

            ProductoModel producto = new ProductoModel
            {
                Nombre = txt_NombreProducto.Text,
                Lote = txt_Lote.Text,
                FechaIngreso = time_Ingreso.Value,
                FechaCaducidad = time_Caducidad.Value,
                Proveedor = txt_Proveedor.Text,
                Stock = stock,
                PrecioUnitario = precio
            };

            string resultado;
            if (productoIdSeleccionado == 0)
            {
                resultado = controller.Insertar(producto);
            }
            else
            {
                producto.ProductoId = productoIdSeleccionado;
                resultado = controller.Actualizar(producto);
            }

            MessageBox.Show(resultado == "ok" ? "Guardado correctamente" : resultado);
            LimpiarCampos();
            MostrarTodosEnLista();
        }

        private void btn_Editor_Click(object sender, EventArgs e)
        {
            if (productoIdSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista para editar.");
                return;
            }
            MessageBox.Show("Ahora puede editar los campos y presionar Guardar para actualizar.");
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (productoIdSeleccionado == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
                return;
            }

            var confirm = MessageBox.Show("¿Está seguro que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                string resultado = controller.Eliminar(productoIdSeleccionado);
                MessageBox.Show(resultado == "ok" ? "Producto eliminado correctamente" : resultado);
                LimpiarCampos();
                MostrarTodosEnLista();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txt_NombreProducto.Text = "";
            txt_Lote.Text = "";
            txt_Proveedor.Text = "";
            txt_Stock.Text = "";
            txt_PrecioUnitario.Text = "";
            time_Ingreso.Value = DateTime.Now;
            time_Caducidad.Value = DateTime.Now;
            productoIdSeleccionado = 0;
            lst_Datos.ClearSelected();
        }

        // Los demás eventos vacíos los puedes eliminar o dejar sin código si no se usan
    }
}
