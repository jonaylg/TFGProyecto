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
        public static string leerArchivoBinarioCadenadeConexion()
        {
            string ruta = "../../BBDD/conexion/cadenaConexion.dat";
            string cadena = "";
            try
            {
                using (FileStream fs = new FileStream(ruta, FileMode.Open))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        cadena = br.ReadString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
            }
            return cadena;
        }
        public static string getCadenaConexión()
        {

            string connectionString = leerArchivoBinarioCadenadeConexion();
            return connectionString;
        }
        public static SqlDataReader getRegistros(string query)
        {
            string conexion = getCadenaConexión();
            SqlConnection connection = new SqlConnection(conexion);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public static bool ejecutarQuery(string query)
        {
            string conexion = getCadenaConexión();
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
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
        public static bool ejecutarQueryParams(string query, List<string> datos)
        {
            string conexion = getCadenaConexión();
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
