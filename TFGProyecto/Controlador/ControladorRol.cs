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

        public static bool insertarRol(Rol r)
        {
            string query = "INSERT INTO Rol VALUES(@nombre,@descripcion)";
            string nombre = r.Nombre;
            string descripcion = r.Descripcion;
            List<string> datos = new List<string>();
            datos.Add(nombre);
            datos.Add(descripcion);
            bool ok = ControladorBBDD.ejecutarQueryParams(query, datos);
            if (ok)
            {
                r.Id = ultimoRol();
                listaRoles.Add(r);
            }
            return ok;
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
            bool ok = ControladorBBDD.ejecutarQueryParams(query, datos);
            if (ok)
            {
                if (atributos.Contains("nombre"))
                {
                    listaRoles.Find(r => r.Id == Convert.ToInt32(datos[atributos.IndexOf("id")])).Nombre = datos[atributos.IndexOf("nombre")];
                }
                if (atributos.Contains("descripcion"))
                {
                    listaRoles.Find(r => r.Id == Convert.ToInt32(datos[atributos.IndexOf("id")])).Descripcion = datos[atributos.IndexOf("descripcion")];
                }
            }
            return ok;
        }
        public static bool eliminarRol(int id)
        {
            string query = "DELETE FROM Rol WHERE id = @id";
            List<string> datos = new List<string>();
            datos.Add(id.ToString());
            bool ok = ControladorBBDD.ejecutarQueryParams(query, datos);
            if (ok)
            {
                listaRoles.Remove(listaRoles.Find(r => r.Id == id));
            }
            return ok;
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
        public static int ultimoId()
        {
            string query = "SELECT MAX(id) FROM Rol";
            SqlDataReader reader = ControladorBBDD.getRegistros(query);
            reader.Read();
            return reader.GetInt32(0);
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
