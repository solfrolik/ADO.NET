using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Itinerario4.Entity
{
   public class PedidoProducto
   {
      public int IdPedido { get; set; }
      public int IdProducto { get; set; }
      public int Cantidad { get; set; }
      public decimal Subtotal { get; set; }
   }
}
