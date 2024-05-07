using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFGProyecto.Controlador
{
    public class ControladorBBDD
    {
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
        public static SqlDataReader getRegistros(string query)
        {
            string conexion = construirCadenaConexión();
            SqlConnection connection = new SqlConnection(conexion);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public static bool ejecutarQueryParams(string query, List<string> datos)
        {
            string conexion = construirCadenaConexión();
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    string patron = @"@\w+";

                    MatchCollection coincidencias = Regex.Matches(query, patron);

                    int i = 0;
                    foreach (Match match in coincidencias)
                    {
                        command.Parameters.AddWithValue(match.Value, datos[i]);
                        i++;
                    }
                    try
                    {
                        int registrosAfectados = command.ExecuteNonQuery();
                        MessageBox.Show($"Se ejecutó correctamente el query. Registros afectados: {registrosAfectados}");
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al ejecutar el query: {ex.Message}");
                        return false;
                    }
                }
            }
        }
    }
}
