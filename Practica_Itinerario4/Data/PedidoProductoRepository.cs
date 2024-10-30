using Practica_Itinerario4.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Itinerario4.Data
{
   public class PedidoProductoRepository
   {
      private readonly string connectionString = "Data Source=LAPTOP-A3HABLR6\\SQLEXPRESS;Initial Catalog=GestiónPedidos;Integrated Security=True;";

      public void InsertarPedidoProducto(PedidoProducto pedidoProducto)
      {
         SqlConnection conn = new SqlConnection(connectionString);

         try
         {
            conn.Open();
            string query = "INSERT INTO Productos_Pedidos (id_pedido, id_producto, cantidad, subtotal) VALUES (@IdPedido, @IdProducto, @Cantidad, @Subtotal)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
               cmd.Parameters.AddWithValue("@IdPedido", pedidoProducto.IdPedido);
               cmd.Parameters.AddWithValue("@IdProducto", pedidoProducto.IdProducto);
               cmd.Parameters.AddWithValue("@Cantidad", pedidoProducto.Cantidad);
               cmd.Parameters.AddWithValue("@Subtotal", pedidoProducto.Subtotal);

               cmd.ExecuteNonQuery();
            }
         }
         catch (SqlException ex)
         {
            Console.WriteLine($"Error en la base de datos: {ex.Message}");
            throw; 
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error general: {ex.Message}");
            throw; 
         }
         finally
         {
            if (conn != null && conn.State == ConnectionState.Open)
            {
               conn.Close(); 
            }
         }
      }

      public List<PedidoProducto> ObtenerDetallesPedido(int idPedido)
      {
         List<PedidoProducto> detalles = new List<PedidoProducto>();
         SqlConnection conn = new SqlConnection(connectionString);

         try
         {
            conn.Open();
            string query = "SELECT * FROM Productos_Pedidos WHERE id_pedido = @IdPedido";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
               cmd.Parameters.AddWithValue("@IdPedido", idPedido);

               using (SqlDataReader reader = cmd.ExecuteReader())
               {
                  while (reader.Read())
                  {
                     detalles.Add(new PedidoProducto
                     {
                        IdPedido = (int)reader["id_pedido"],
                        IdProducto = (int)reader["id_producto"],
                        Cantidad = (int)reader["cantidad"],
                        Subtotal = (decimal)reader["subtotal"]
                     });
                  }
               }
            }
         }
         catch (SqlException ex)
         {
            Console.WriteLine($"Error en la base de datos: {ex.Message}");
            throw;
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error general: {ex.Message}");
            throw;
         }
         finally
         {
            if (conn != null && conn.State == ConnectionState.Open)
            {
               conn.Close();
            }
         }

         return detalles;
      }
   }

}
