using Practica_Itinerario4.Business;
using Practica_Itinerario4.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Itinerario4
{
   public partial class Form1 : Form
   {
      private readonly List<PedidoProducto> productosEnPedido = new List<PedidoProducto>();
      private readonly PedidoService pedidoService = new PedidoService();
      private readonly ProductoService productoService = new ProductoService();
      private int idPedidoActual;
      public Form1()
      {
         InitializeComponent();
         CargarProductos();
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      private void btnAltaPedido_Click(object sender, EventArgs e)
      {
         try
         {
            int dniCliente = int.Parse(txtDNI.Text);
            idPedidoActual = pedidoService.CrearPedido(dniCliente);
            MessageBox.Show($"Pedido creado con ID: {idPedidoActual}");
            txtDNI.Text = dniCliente.ToString();
            dgvDetallesPedidos.Rows.Clear(); 
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error al crear pedido: {ex.Message}");
         }
      }
      private void btnAgregarItem_Click(object sender, EventArgs e)
      {
         try
         {
            if (idPedidoActual == 0)
            {
               MessageBox.Show("Primero debes crear un pedido.");
               return;
            }

            int idProducto = int.Parse(BoxProducto.SelectedValue.ToString());
            int cantidad = int.Parse(txtCantidad.Text);
            decimal precio = ObtenerPrecioProducto(idProducto);  
            decimal subtotal = cantidad * precio;

            pedidoService.AgregarItem(idPedidoActual, idProducto, cantidad, subtotal);
            CargarDetallesPedido(idPedidoActual);
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error al agregar item: {ex.Message}");
         }
      }
      private void btnAgregarProd_Click(object sender, EventArgs e)
      {
         try
         {
            string descripcion = txtDescripcionProd.Text;
            decimal precio = decimal.Parse(txtPrecio.Text);

            productoService.CrearProducto(descripcion, precio);
            MessageBox.Show("Producto agregado correctamente");

            CargarProductos();
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error al agregar producto: {ex.Message}");
         }
      }

      private void btnModificarPrecio_Click(object sender, EventArgs e)
      {
         try
         {
            int idProducto = Convert.ToInt32(BoxSelectProd.SelectedValue);
            decimal nuevoPrecio = decimal.Parse(txtNuevoPrecio.Text);

            productoService.ModificarPrecio(idProducto, nuevoPrecio);
            MessageBox.Show("Precio modificado correctamente");

            CargarProductos();
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error al modificar el precio: {ex.Message}");
         }
      }

      private void btnMostrarPedidos_Click(object sender, EventArgs e)
      {
         try
         {
            List<Pedido> pedidos = pedidoService.ObtenerPedidos();
            dgvMostrarPedidos.DataSource = pedidos;
            dgvMostrarPedidos.Refresh();
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error al mostrar pedidos: {ex.Message}");
         }
      }
      private void CargarProductos()
      {
         try
         {
            var productos = productoService.ObtenerProductos();
            BoxProducto.DataSource = productos;
            BoxProducto.DisplayMember = "Descripcion";
            BoxProducto.ValueMember = "IdProducto";

            BoxSelectProd.DataSource = new List<Producto>(productos); 
            BoxSelectProd.DisplayMember = "Descripcion";
            BoxSelectProd.ValueMember = "IdProducto";
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error al cargar productos: {ex.Message}");
         }
      }

      private void CargarDetallesPedido(int idPedido)
      {
         try
         {
            var detalles = pedidoService.ObtenerDetallesPedido(idPedido); 
            dgvDetallesPedidos.DataSource = detalles.Select(d => new
            {
               Producto = d.IdProducto,
               Cantidad = d.Cantidad,
               Subtotal = d.Subtotal
            }).ToList();
            dgvDetallesPedidos.Refresh();
         }
         catch (Exception ex)
         {
            MessageBox.Show($"Error al cargar detalles del pedido: {ex.Message}");
         }
      }
      private decimal ObtenerPrecioProducto(int idProducto)
      {
         var producto = productoService.ObtenerProductos().FirstOrDefault(p => p.IdProducto == idProducto);
         return producto?.Precio ?? 0;
      }
   }
   
}


