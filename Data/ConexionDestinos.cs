using ExamenFInalDB.Data.Model;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenFInalDB.Data
{
    internal class ConexionDestinos
    {
        string connectionString = "server=localhost;database=ExamenFinal;user=root;password=Mijlu30";

        //Probar conexión
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }




        //CREATE: Insertar un registro con una clase model
        public bool CrearDestino(Destino dest)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string consulta = "INSERT INTO destinos_turisticos (nombre, pais, tipo_destino, fecha_llegada, fecha_salida, presupuesto_promedio, puntuacion, favorito) VALUES (@Nombre, @Pais, @TipoDestino, @FechaLlegada, @FechaSalida, @PresupuestoPromedio, @Puntuacion, @Favorito)";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", dest.Nombre);
                        cmd.Parameters.AddWithValue("@Pais", dest.Pais);
                        cmd.Parameters.AddWithValue("@TipoDestino", dest.TipoDestino);
                        cmd.Parameters.AddWithValue("@FechaLlegada", dest.FechaLlegada);
                        cmd.Parameters.AddWithValue("@FechaSalida", dest.FechaSalida);
                        cmd.Parameters.AddWithValue("@PresupuestoPromedio", dest.PresupuestoPromedio);
                        cmd.Parameters.AddWithValue("@Puntuacion", dest.Puntuacion);
                        cmd.Parameters.AddWithValue("@Favorito", dest.Favorito);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el registro: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }




        //READ: Seleccionar todos los registros usando List
        public List<Destino> ObtenerTodosLosRegistros()
        {
            List<Destino> destinos = new List<Destino>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM destinos_turisticos";
                MySqlCommand cmd = new MySqlCommand(consulta, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Destino destino = new Destino
                        (
                            id: reader.GetInt32("id"),
                            nombre: reader.GetString("nombre"),
                            pais: reader.GetString("pais"),
                            tipo_destino: reader.GetString("tipo_destino"),
                            fecha_llegada: reader.GetDateTime("fecha_llegada"),
                            fecha_salida: reader.GetDateTime("fecha_salida"),
                            presupuesto_promedio: reader.GetDecimal("presupuesto_promedio"),
                            puntuacion: reader.GetInt32("puntuacion"),
                            favorito: reader.GetBoolean("favorito")
                        );

                        destinos.Add(destino);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al leer los registros: " + ex.Message);
                }
            }

            return destinos;
        }


        //Seleccionar todos los destinos favoritos
        public List<Destino> ObtenerRegistosFavoritos()
        {
            List<Destino> destinos = new List<Destino>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM destinos_turisticos WHERE favorito = 1";
                MySqlCommand cmd = new MySqlCommand(consulta, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Destino destino = new Destino
                        (
                            id: reader.GetInt32("id"),
                            nombre: reader.GetString("nombre"),
                            pais: reader.GetString("pais"),
                            tipo_destino: reader.GetString("tipo_destino"),
                            fecha_llegada: reader.GetDateTime("fecha_llegada"),
                            fecha_salida: reader.GetDateTime("fecha_salida"),
                            presupuesto_promedio: reader.GetDecimal("presupuesto_promedio"),
                            puntuacion: reader.GetInt32("puntuacion"),
                            favorito: reader.GetBoolean("favorito")
                        );

                        destinos.Add(destino);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al leer los registros: " + ex.Message);
                }
            }

            return destinos;
        }



        public DataRow BuscarRegistroporID(int id)
        {
            DataTable data = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string consulta = "SELECT * FROM destinos_turisticos WHERE id = @ID";
                    MySqlCommand cmd = new MySqlCommand(consulta, connection);
                    cmd.Parameters.AddWithValue("@ID", id);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    connection.Open();
                    adapter.Fill(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el registro: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return data.Rows[0];
        }



        //UPDATE: Actualizar un registro
        public bool Actualizar(Destino dest)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string consulta = "UPDATE destinos_turisticos SET nombre = @Nombre, pais = @Pais, tipo_destino = @TipoDestino, fecha_llegada = @FechaLlegada, fecha_salida = @FechaSalida, presupuesto_promedio = @PresupuestoPromedio, puntuacion = @Puntuacion, favorito = @Favorito WHERE id = @ID";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", dest.ID);
                        cmd.Parameters.AddWithValue("@Nombre", dest.Nombre);
                        cmd.Parameters.AddWithValue("@Pais", dest.Pais);
                        cmd.Parameters.AddWithValue("@TipoDestino", dest.TipoDestino);
                        cmd.Parameters.AddWithValue("@FechaLlegada", dest.FechaLlegada);
                        cmd.Parameters.AddWithValue("@FechaSalida", dest.FechaSalida);
                        cmd.Parameters.AddWithValue("@PresupuestoPromedio", dest.PresupuestoPromedio);
                        cmd.Parameters.AddWithValue("@Puntuacion", dest.Puntuacion);
                        cmd.Parameters.AddWithValue("@Favorito", dest.Favorito);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }




        //DELETE: Eliminar un registro
        public bool Eliminar(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    string consulta = "DELETE FROM destinos_turisticos WHERE id = @ID";
                    using (MySqlCommand cmd = new MySqlCommand(consulta, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
