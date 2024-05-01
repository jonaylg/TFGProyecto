using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFGProyecto
{
    public class ControladorUsuario
    {
        public static List<Usuario> listaUsuarios=new List<Usuario>();
        public static string construirCadenaConexión()
        {
            // Directorio del archivo de base de datos relativo al directorio de ejecución
            // A diferencia de la anterior version, forzamos a que coja la ruta relativa con el Path.GetFullPath
            string databaseFileName = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\DatabaseTFG.mdf"));
            // Cadena de conexión
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
            // Usar la cadena de conexión
            MessageBox.Show("Cadena de conexión: " + connectionString);
            return connectionString;
        }

        public static void insertarUsuario(Usuario u)
        {
            // Cadena de conexión a la base de datos
            // Ver método construirCadenaConexión más arriba
            string connectionString = construirCadenaConexión();
            // Query de inserción
            string query = "INSERT INTO Usuario VALUES(@nick,@clave,@preg)";
            // Valores para los parámetros
            String nick = u.Nick;
            String clave = u.Clave;
            String preg = u.PregPers;
            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();
                // Crear un objeto SqlCommand con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros y sus valores
                    // No se añade a la inserción el campo código proyecto porque es autonumérico, aunque se puede configurar para poder
                    // insertarlo a la fuerza.
                    command.Parameters.AddWithValue("@nick", nick);
                    command.Parameters.AddWithValue("@clave", clave);
                    command.Parameters.AddWithValue("@preg", preg);
                    try
                    {
                        // Ejecutar la consulta de inserción
                        int registrosAfectados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se insertó correctamente el registro. Registros afectados: {registrosAfectados}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al insertar el registro: {ex.Message}");
                    }
                }
            }


        }

        public static void CargarDatosEnListaUsuario()
        {
            string connectionString = construirCadenaConexión(); // Reemplaza con tu cadena de conexión
                                                                 // En este caso, solo realiza un select del campo CódigoProyecto y nombreProyecto
                                                                 // Sería necesario adaptarlo si queremos todos los campos de un proyecto.
            string query = "SELECT * FROM Usuario";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Usuario u;
                            while (reader.Read())
                            {
                                // Agregar una nueva fila al DataGridView con el código y el nombre del proyecto
                                u = new Usuario(reader["usuario"].ToString(), reader["clave"].ToString()
                                    , reader["pregPers"].ToString());
                                listaUsuarios.Add(u);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}\n{ex.StackTrace}");
                }
            }

        }
    }
}
