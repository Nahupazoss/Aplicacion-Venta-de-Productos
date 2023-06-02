using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pazos
{
    public class BaseDeDatosVentas
    {
        #region Atributos

        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        #endregion

        #region Constructores

        static BaseDeDatosVentas()
        {
            BaseDeDatosVentas.cadena_conexion = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=pruebademo;Data Source=DESKTOP-45ITKTF";
        }

        public BaseDeDatosVentas()
        {
            // CREO UN OBJETO SQLCONECTION
            this.conexion = new SqlConnection(BaseDeDatosVentas.cadena_conexion);
        }

        #endregion

        #region Métodos

        #region Probar conexión

        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                this.conexion.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Select

        public List<Venta> ObtenerListaVentas()
        {
            List<Venta> lista = new List<Venta>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM dbo.ventas";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Venta item = new Venta();

                    // ACCEDO POR NOMBRE, POR INDICE O POR GETTER (SEGUN TIPO DE DATO)

                    item.Id = (int)lector["id"];
                    int clienteID = (int)lector["IDcliente"];
                    item.Fecha = DateTime.Parse(lector["fecha"].ToString());
                    item.Total = (float)lector["total"];

                    // Obtener el objeto Cliente asociado al IDCliente
                    Cliente cliente = ObtenerClientePorID(clienteID);
                    item.Cliente = cliente;

                    lista.Add(item);
                }

                lector.Close();

            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }

        private Cliente ObtenerClientePorID(int clienteID)
        {
            string query = "SELECT * FROM dbo.clientes WHERE id = @ClienteID";

            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@ClienteID", clienteID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Cliente cliente = new Cliente();

                        cliente.Id = (int)reader["id"];
                        cliente.Nombre = reader["nombre"].ToString();
                        cliente.Telefono= (int)reader["telefono"];
                        cliente.Correo = reader["correo"].ToString();

                        return cliente;
                    }
                }
            }

            return null;
        }

        #endregion

        #region Insert

        public bool AgregarVenta(Venta param)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO dbo.ventas (IDCliente, Fecha, Total) VALUES(";
                sql = sql + "'" + param.Cliente + "'," + param.Fecha + ",'" + param.Total + "')";

                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Update

        public bool ModificarVenta(Venta param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", param.Id);
                this.comando.Parameters.AddWithValue("@idcliente", param.Cliente);
                this.comando.Parameters.AddWithValue("@fecha", param.Fecha);
                this.comando.Parameters.AddWithValue("@total", param.Total);

                string sql = "UPDATE dbo.ventas ";
                sql += "SET idcliente = @idcliente, fecha = @fecha, total = @total ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return rta;
        }

        #endregion

        #region Delete

        public bool EliminarVenta(int id)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM dbo.ventas ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #endregion


    }
}
