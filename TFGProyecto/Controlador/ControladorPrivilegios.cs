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
            bool ok = ControladorBBDD.ejecutarQueryParams(query, datos);
            if (ok)
            {
                privilegio.Id = ultimoId();
                listaPrivilegios.Add(privilegio);
            }
            return ok;
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
        public static bool modificarPrivilegio(List<string> atributos, List<string> datos)
        {
            string query = "UPDATE Privilegio SET ";
            foreach (string atributo in atributos)
            {
                query += $"{atributo} = @{atributo},";
            }
            query = query.Remove(query.Length - 1);
            query += " WHERE id = @id";
            bool ok = ControladorBBDD.ejecutarQueryParams(query, datos);
            if (ok)
            {
                int id = Convert.ToInt32(datos[datos.Count - 1]);
                if (atributos.Contains("nombre"))
                {
                    listaPrivilegios.Find(p => p.Id == id).Nombre = datos[0];
                }
                if (atributos.Contains("descripcion"))
                {
                    listaPrivilegios.Find(p => p.Id == id).Descripcion = datos[1];
                }
            }
            return ok;
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
        public static int ultimoId()
        {
            string query = "SELECT MAX(id) FROM Privilegio";
            SqlDataReader reader = ControladorBBDD.getRegistros(query);
            if (reader.Read())
            {
                return Convert.ToInt32(reader[0]);
            }
            return 0;
        }
    }
}
