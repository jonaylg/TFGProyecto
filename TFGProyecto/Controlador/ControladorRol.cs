using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGProyecto.Modelo;
using System.Data.SqlClient;

namespace TFGProyecto.Controlador
{
    public class ControladorRol
    {
        public static List<Rol> listaRoles = new List<Rol>();
        public static int idRolActivo = ultimoRol();

        public static bool insertarRol(Rol r)
        {
            string query = "INSERT INTO Rol VALUES(@nombre,@descripcion)";
            string nombre = r.Nombre;
            string descripcion = r.Descripcion;
            List<string> datos = new List<string>();
            datos.Add(nombre);
            datos.Add(descripcion);
            return ControladorBBDD.ejecutarQueryParams(query, datos);
        }
        public static Rol obtenerRol(string id)
        {
            Rol rol = null;
            string query = $"SELECT * FROM Rol WHERE id = {id}";
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                if (reader.Read())
                {
                    rol = new Rol(
                        reader["nombre"].ToString(),
                        reader["descripcion"].ToString(),
                        ControladorPrivilegios.ObtenerPrivilegiosPorRol(Convert.ToInt32(reader["id"]))
                    );
                }
            }
            return rol;
        }
        public static bool modificarRol(List<string> atributos, List<string> datos)
        {
            string query = "UPDATE Rol SET ";
            foreach (string atributo in atributos)
            {
                query += $"{atributo} = @{atributo},";
            }
            query = query.Remove(query.Length - 1);
            query += " WHERE id = @id";
            return ControladorBBDD.ejecutarQueryParams(query, datos);
        }
        public static bool eliminarRol(int id)
        {
            string query = "DELETE FROM Rol WHERE id = @id";
            List<string> datos = new List<string>();
            datos.Add(id.ToString());
            return ControladorBBDD.ejecutarQueryParams(query, datos);
        }
        public static void CargarListaRoles()
        {
            string query = "SELECT * FROM Rol";
            SqlDataReader reader = ControladorBBDD.getRegistros(query);
            while (reader.Read())
            {
                Rol r = new Rol(reader["nombre"].ToString(), reader["descripcion"].ToString(), new List<Privilegio>());
                listaRoles.Add(r);
            }
        }
        public static int ultimoRol()
        {
            string query = "SELECT MAX(id) FROM Rol";
            SqlDataReader reader = ControladorBBDD.getRegistros(query);
            reader.Read();
            return reader.GetInt32(0);
        }
    }
}
