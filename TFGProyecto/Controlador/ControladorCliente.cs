using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGProyecto.Modelo;

namespace TFGProyecto.Controlador
{
    public class ControladorCliente
    {
        public static List<Cliente> listaClientes = new List<Cliente>();
        public static Cliente clienteActivo = new Cliente();


        public static bool insertarCliente(Cliente c)
        {
            string query = "INSERT INTO Cliente VALUES(@dni,@nombre,@apellido,@direccion," +
                "@fechaNac,@telefono,@correo,@provincia,@ciudad,@tipo,@direccionFac,@cvv," +
                "@FechaVen,@nomTit,@frecPag,@metPag)";
            string dni = c.Dni;
            string nombre = c.Nombre;
            string apellido = c.Apellido;
            string direccion = c.Direccion;
            DateTime fechaNac = c.FechaNacimiento;
            string telefono = c.Telefono;
            string correo = c.CorreoElectronico;
            string provincia = c.Provincia;
            string ciudad = c.Ciudad;
            string tipo = c.Tipo;
            string direccionFac = c.DireccionFacturacion;
            int cvv = c.Cvv;
            string FechaVen = c.FechaVencimiento;
            string nomTit = c.NombreTitular;
            string frecPag = c.FrecuenciaPago;
            string metPag = c.MetodoPago;

            List<string> datos = new List<string>();
            datos.Add(dni);
            datos.Add(nombre);
            datos.Add(apellido);
            datos.Add(direccion);
            datos.Add(fechaNac.ToLongDateString());
            datos.Add(telefono);
            datos.Add(correo);
            datos.Add(provincia);
            datos.Add(ciudad);
            datos.Add(tipo);
            datos.Add(direccionFac);
            datos.Add(cvv.ToString());
            datos.Add(FechaVen);
            datos.Add(nomTit);
            datos.Add(frecPag);
            datos.Add(metPag);
            return ControladorBBDD.ejecutarQueryParams(query, datos);
        }
        public static Cliente obtenerCliente(string dni)
        {
            Cliente Cliente = null;
            string query = $"SELECT * FROM Cliente WHERE DNI = '{dni}'";
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                if (reader.Read())
                {
                    Cliente = new Cliente(
                        reader["Nombre"].ToString(),
                        reader["Apellido"].ToString(),
                        reader["Direccion"].ToString(),
                        DateTime.Parse(reader["FechaNacimiento"].ToString()),
                        reader["Telefono"].ToString(),
                        reader["CorreoElectronico"].ToString(),
                        reader["Provincia"].ToString(),
                        reader["Ciudad"].ToString(),
                        reader["Tipo"].ToString(),
                        reader["DireccionFacturacion"].ToString(),
                        Int32.Parse(reader["CVV"].ToString()),
                        reader["FechaVencimiento"].ToString(),
                        reader["NombreTitular"].ToString(),
                        reader["FrecuenciaPago"].ToString(),
                        reader["MetodoPago"].ToString(),
                        reader["DNI"].ToString()
                    );
                }
            }
            return Cliente;
        }
        public static bool modificarClave(string nick, string clave)
        {
            string query = "UPDATE Cliente SET clave = @clave WHERE nick = @nick";
            List<string> datos = new List<string>();
            datos.Add(clave);
            datos.Add(nick);
            return ControladorBBDD.ejecutarQueryParams(query, datos);
        }
        public static bool eliminarCliente(string dni)
        {
            string query = "DELETE FROM Cliente WHERE DNI = @dni";
            List<string> datos = new List<string>();
            datos.Add(dni);
            return ControladorBBDD.ejecutarQueryParams(query, datos);
        }

        public static int existeCliente(String dni)
        {
            int numero = -1;
            string query = $"SELECT count(DNI) as numero FROM Cliente where DNI='{dni}'";
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                if (reader.Read())
                {
                    numero = Int32.Parse(reader["numero"].ToString());
                }
            }
            return numero;
        }
        public static void CargarDatosEnListaCliente()
        {
            string query = "SELECT * FROM Cliente";
            SqlDataReader reader = ControladorBBDD.getRegistros(query);
            while (reader.Read())
            {
                Cliente c = new Cliente(
                    reader["Nombre"].ToString(),
                    reader["Apellido"].ToString(),
                    reader["Direccion"].ToString(),
                    DateTime.Parse(reader["FechaNacimiento"].ToString()),
                    reader["Telefono"].ToString(),
                    reader["CorreoElectronico"].ToString(),
                    reader["Provincia"].ToString(),
                    reader["Ciudad"].ToString(),
                    reader["Tipo"].ToString(),
                    reader["DireccionFacturacion"].ToString(),
                    Int32.Parse(reader["CVV"].ToString()),
                    reader["FechaVencimiento"].ToString(),
                    reader["NombreTitular"].ToString(),
                    reader["FrecuenciaPago"].ToString(),
                    reader["MetodoPago"].ToString(),
                    reader["DNI"].ToString()
                    );
                listaClientes.Add(c);
            }
        }
    }
}
