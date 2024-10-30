using Practica_Itinerario4.Data;
using Practica_Itinerario4.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Itinerario4.Business
{
   public class PedidoService
   {
      private readonly PedidoRepository pedidoRepository = new PedidoRepository();
      private readonly PedidoProductoRepository pedidoProductoRepository = new PedidoProductoRepository();

      public int CrearPedido(int dniCliente)
      {
         Pedido nuevoPedido = new Pedido
         {
            DniCliente = dniCliente
         };

        
         return pedidoRepository.InsertarPedido(nuevoPedido);
      }

      public void AgregarItem(int idPedido, int idProducto, int cantidad, decimal subtotal)
      {
         var pedidoProducto = new PedidoProducto
         {
            IdPedido = idPedido,
            IdProducto = idProducto,
            Cantidad = cantidad,
            Subtotal = subtotal
         };
         pedidoProductoRepository.InsertarPedidoProducto(pedidoProducto);
      }

      public List<Pedido> ObtenerPedidos()
      {
         return pedidoRepository.ObtenerPedidos();
      }
      public List<PedidoProducto> ObtenerDetallesPedido(int idPedido)
      {
         return pedidoProductoRepository.ObtenerDetallesPedido(idPedido); 
      }

      public decimal CalcularTotalPedido(int idPedido)
      {
         var detalles = pedidoProductoRepository.ObtenerDetallesPedido(idPedido);
         return detalles.Sum(p => p.Subtotal); 
      }
   }
}
