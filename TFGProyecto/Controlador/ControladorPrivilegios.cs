using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TFGProyecto.Modelo;

namespace TFGProyecto.Controlador
{
    public class ControladorPrivilegios
    {
        public static List<Privilegio> listaPrivilegios = new List<Privilegio>();
        public static bool insertarPrivilegio(Privilegio privilegio)
        {
            string query = "INSERT INTO Privilegio VALUES(@nombre, @descripcion)";
            List<string> datos = new List<string>();
            datos.Add(privilegio.Nombre);
            datos.Add(privilegio.Descripcion);
            return ControladorBBDD.ejecutarQueryParams(query, datos);
        }
        public static Privilegio obtenerPrivilegio(int id)
        {
            Privilegio privilegio = null;
            string query = $"SELECT * FROM Privilegio WHERE id = {id}";
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                if (reader.Read())
                {
                    privilegio = new Privilegio(
                        Convert.ToInt32(reader["id"]),
                        reader["nombre"].ToString(),
                        reader["descripcion"].ToString()
                    );
                }
            }
            return privilegio;
        }
        public static bool modificarPrivilegio(Privilegio privilegio)
        {
            string query = "UPDATE Privilegio SET nombre = @nombre, descripcion = @descripcion WHERE id = @id";
            List<string> datos = new List<string>();
            datos.Add(privilegio.Nombre);
            datos.Add(privilegio.Descripcion);
            datos.Add(privilegio.Id.ToString());
            return ControladorBBDD.ejecutarQueryParams(query, datos);
        }
        public static bool eliminarPrivilegio(int id)
        {
            string query = "DELETE FROM Privilegio WHERE id = @id";
            List<string> datos = new List<string>();
            datos.Add(id.ToString());
            return ControladorBBDD.ejecutarQueryParams(query, datos);
        }        public static void CargarListaPrivilegios()
        {
            string query = "SELECT * FROM Privilegio";
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                while (reader.Read())
                {
                    Privilegio privilegio = new Privilegio(
                    Convert.ToInt32(reader["id"]),
                        reader["nombre"].ToString(),
                        reader["descripcion"].ToString()
                    );
                    listaPrivilegios.Add(privilegio);
                }
            }
        }
        public static List<Privilegio> ObtenerPrivilegiosPorRol(int idRol)
        {
            List<Privilegio> privilegios = new List<Privilegio>();
            string query = $"SELECT * FROM Privilegio WHERE id IN (SELECT idPrivilegio FROM PrivilegiosPorRol WHERE idRol = {idRol})";
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                while (reader.Read())
                {
                    Privilegio privilegio = new Privilegio(
                        Convert.ToInt32(reader["id"]),
                        reader["nombre"].ToString(),
                        reader["descripcion"].ToString()
                    );
                    privilegios.Add(privilegio);
                }
            }
            return privilegios;
        }
    }
}
