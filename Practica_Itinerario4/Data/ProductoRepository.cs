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
   public class ProductoRepository
   {
      private readonly string connectionString = "Data Source=LAPTOP-A3HABLR6\\SQLEXPRESS;Initial Catalog=GestiónPedidos;Integrated Security=True;";

      public void InsertarProducto(Producto producto)
      {
         SqlConnection conn = new SqlConnection(connectionString);

         try
         {
            conn.Open();
            string query = "INSERT INTO Producto (Descripcion, Precio) VALUES (@Descripcion, @Precio)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
               cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
               cmd.Parameters.AddWithValue("@Precio", producto.Precio);
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

      public List<Producto> ObtenerProductos()
      {
         List<Producto> productos = new List<Producto>();
         SqlConnection conn = new SqlConnection(connectionString);

         try
         {
            conn.Open();
            string query = "SELECT * FROM Producto";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
               using (SqlDataReader reader = cmd.ExecuteReader())
               {
                  while (reader.Read())
                  {
                     productos.Add(new Producto
                     {
                        IdProducto = (int)reader["id_producto"],
                        Descripcion = reader["descripcion"].ToString(),
                        Precio = (decimal)reader["precio"]
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

         return productos;
      }

      public void ModificarPrecio(int idProducto, decimal nuevoPrecio)
      {
         SqlConnection conn = new SqlConnection(connectionString);

         try
         {
            conn.Open();
            string query = "UPDATE Producto SET Precio = @Precio WHERE id_producto = @IdProducto";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
               cmd.Parameters.AddWithValue("@Precio", nuevoPrecio);
               cmd.Parameters.AddWithValue("@IdProducto", idProducto);
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
   }
}
