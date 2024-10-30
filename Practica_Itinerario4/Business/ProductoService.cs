using Practica_Itinerario4.Data;
using Practica_Itinerario4.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Itinerario4.Business
{
   public class ProductoService
   {
      private readonly ProductoRepository productoRepository = new ProductoRepository();

      public List<Producto> ObtenerProductos()
      {
         return productoRepository.ObtenerProductos();
      }

      public void CrearProducto(string descripcion, decimal precio)
      {
         if (string.IsNullOrEmpty(descripcion))
            throw new Exception("La descripción no puede estar vacía.");

         if (precio <= 0)
            throw new Exception("El precio debe ser mayor que cero.");

         var producto = new Producto
         {
            Descripcion = descripcion,
            Precio = precio
         };

         productoRepository.InsertarProducto(producto);
      }

      public void ModificarPrecio(int idProducto, decimal nuevoPrecio)
      {
         if (nuevoPrecio <= 0)
            throw new Exception("El precio debe ser mayor que cero.");

         productoRepository.ModificarPrecio(idProducto, nuevoPrecio);
      }
   }

}
