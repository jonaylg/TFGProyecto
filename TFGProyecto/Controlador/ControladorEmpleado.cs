using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGProyecto.Modelo;

namespace TFGProyecto.Controlador
{
    public class ControladorEmpleado
    {

        public static bool insertarEmpleado(Empleado e)
        {
            string query = "INSERT INTO Empleado VALUES(@usuario_nick, @nombre, @apellido1, @apellido2, @fechaNac, @fechaContr, @puesto, @salario, @email, @telefono, @direccion, @dni)";
            string usuario = e.Usuario.Nick;
            string nombre = e.Nombre;
            string apellido1 = e.Apellido1;
            string apellido2 = e.Apellido2;
            string fechaNac = e.FechaNac.ToString();
            string fechaContr = e.FechaContr.ToString();
            string puesto = e.Puesto.ToString();
            string salario = e.Salario.ToString();
            string email = e.Email;
            string telefono = e.Telefono.ToString();
            string direccion = e.Direccion;
            string dni = e.Dni;
            List<string> datos = new List<string>();
            datos.Add(usuario);
            datos.Add(nombre);
            datos.Add(apellido1);
            datos.Add(apellido2);
            datos.Add(fechaNac);
            datos.Add(fechaContr);
            datos.Add(puesto);
            datos.Add(salario);
            datos.Add(email);
            datos.Add(telefono);
            datos.Add(direccion);
            datos.Add(dni);
            return ControladorBBDD.ejecutarQueryParams(query, datos);
        }
        public static Empleado obtenerEmpleado(string dni)
        {
            Empleado empleado = null;
            string query = $"SELECT * FROM Empleado WHERE dni = {dni}";
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                if (reader.Read())
                {
                    empleado = new Empleado(
                        ControladorUsuario.obtenerUsuario(reader["usuario_nick"].ToString()),
                        reader["nombre"].ToString(),
                        reader["apellido1"].ToString(),
                        reader["apellido2"].ToString(),
                        Convert.ToDateTime(reader["fechaNac"]),
                        Convert.ToDateTime(reader["fechaContr"]),
                        (Puesto)Enum.Parse(typeof(Puesto), reader["puesto"].ToString()),
                        Convert.ToDouble(reader["salario"]),
                        reader["email"].ToString(),
                        Convert.ToInt32(reader["telefono"]),
                        reader["direccion"].ToString(),
                        reader["dni"].ToString()
                    );
                }
            }
            return empleado;
        }
        public static bool ModificarEmpleado(List<string> atributos, List<string> datos,Empleado e)
        {
            string query = "UPDATE Empleado SET ";
            foreach (string atributo in atributos)
            {                
                query += $"{atributo} = @{atributo},";
            }
            query = query.Remove(query.Length - 1);
            query += $" WHERE dni = '{e.Dni}'";
            return ControladorBBDD.ejecutarQueryParams(query, datos);
        }
        public static bool EliminarEmpleado(string dni)
        {
            string query = $"DELETE FROM Empleado WHERE dni = '{dni}'";
            return ControladorBBDD.ejecutarQuery(query);
        }
    }
}
