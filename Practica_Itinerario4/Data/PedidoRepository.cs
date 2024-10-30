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
   public class PedidoRepository
   {
      private readonly string connectionString = "Data Source=LAPTOP-A3HABLR6\\SQLEXPRESS;Initial Catalog=GestiónPedidos;Integrated Security=True;";

      public int InsertarPedido(Pedido pedido)
      {
         int idPedido = 0;
         SqlConnection conn = new SqlConnection(connectionString);

         try
         {
            conn.Open();
            string query = "INSERT INTO Pedido (dni_cliente) OUTPUT INSERTED.id_pedido VALUES (@DniCliente)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
               cmd.Parameters.AddWithValue("@DniCliente", pedido.DniCliente);
               idPedido = (int)cmd.ExecuteScalar(); 
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

         return idPedido;
      }

      public List<Pedido> ObtenerPedidos()
      {
         List<Pedido> pedidos = new List<Pedido>();
         SqlConnection conn = new SqlConnection(connectionString);

         try
         {
            conn.Open();
            string query = "SELECT * FROM Pedido";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
               using (SqlDataReader reader = cmd.ExecuteReader())
               {
                  while (reader.Read())
                  {
                     pedidos.Add(new Pedido
                     {
                        IdPedido = (int)reader["id_pedido"],
                        DniCliente = (int)reader["dni_cliente"]
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

         return pedidos;
      }
   }
}
