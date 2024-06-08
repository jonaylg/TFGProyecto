using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFGProyecto.Controlador;

namespace TFGProyecto
{
    public class ControladorUsuario
    {
        public static List<Usuario> listaUsuarios=new List<Usuario>();
        public static Usuario usuarioActivo=new Usuario();
        

        public static bool insertarUsuario(Usuario u)
        {
            string query = "INSERT INTO Usuario VALUES(@nick,@clave,@preg,@respuesta)";
            string nick = u.Nick;
            string clave = u.Clave;
            string preg = u.PregPers;
            string respuesta = u.Respuesta;
            List<string> datos = new List<string>();
            datos.Add(nick);
            datos.Add(clave);
            datos.Add(preg);
            datos.Add(respuesta);
            bool ok = ControladorBBDD.ejecutarQueryParams(query, datos);
            return ok;
        }
        public static Usuario obtenerUsuario(string nick)
        {
            Usuario usuario = null;
            string query = $"SELECT * FROM Usuario WHERE usuario = {nick}";
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                if (reader.Read())
                {
                    usuario = new Usuario(
                        reader["usuario"].ToString(),
                        reader["clave"].ToString(),
                        reader["pregunta"].ToString(),
                        reader["respuesta"].ToString()
                    );
                }
            }
            return usuario;
        }
        public static bool modificarClave(string nick, string clave)
        {
            string query = "UPDATE Usuario SET clave = @clave WHERE nick = @nick";
            List<string> datos = new List<string>();
            datos.Add(clave);
            datos.Add(nick);
            bool ok = ControladorBBDD.ejecutarQueryParams(query, datos);
            if (ok)
            {
                listaUsuarios.Find(u => u.Nick == nick).Clave = clave;
            }
            return ok;
        }
        public static bool eliminarUsuario(string nick)
        {
            string query = "DELETE FROM Usuario WHERE usuario = @nick";
            List<string> datos = new List<string>();
            datos.Add(nick);
            bool ok = ControladorBBDD.ejecutarQueryParams(query, datos);
            if (ok)
            {
                listaUsuarios.Remove(listaUsuarios.Find(u => u.Nick == nick));
            }
            return ok;
        }
        public static void CargarDatosEnListaUsuario()
        {
            string query = "SELECT * FROM Usuario";
            SqlDataReader reader = ControladorBBDD.getRegistros(query);
            while (reader.Read())
            {
                Usuario u = new Usuario(reader["nick"].ToString(),
                    reader["clave"].ToString(), reader["pregPers"].ToString(),
                    reader["respuesta"].ToString());
                listaUsuarios.Add(u);
            }
        }
    }
}
