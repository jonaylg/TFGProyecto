using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGProyecto.Modelo;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TFGProyecto.Controlador
{
    public class ControladorPolizaVida
    {
        public static bool insertarPolVida(PolizaVida pv) {
            bool ok = true;
            string query = "INSERT INTO PolizaVida (" +
                "Edad,Sexo,OcupacionId,Peso,Altura,DietaId," +
                "ActividadId,ConsumeAlcohol,ConsumeTabaco," +
                "ConsumeDrogas,Hematologicas,Gastrointestinales," +
                "Endocrinas,Infecciosas,Autoinmunes,Neurologicas," +
                "Renales,Hepaticas,Diabetes,Cancer,Respiratorias," +
                "Cardiacas,TieneTerminacionAnticipada," +
                "TieneIncapacidadTemporal,TieneAccidentes," +
                "CapitalAsegurado,Precio,Dni" +
                ") VALUES (" +
                "@Edad,@Sexo,@OcupacionId,@Peso,@Altura,@DietaId," +
                "@ActividadId,@ConsumeAlcohol,@ConsumeTabaco,@ConsumeDrogas," +
                "@Hematologicas,@Gastrointestinales,@Endocrinas,@Infecciosas," +
                "@Autoinmunes,@Neurologicas,@Renales,@Hepaticas,@Diabetes," +
                "@Cancer,@Respiratorias,@Cardiacas,@TieneTerminacionAnticipada," +
                "@TieneIncapacidadTemporal,@TieneAccidentes," +
                "@CapitalAsegurado,@Precio,@Dni)";
            string edad = pv.Edad.ToString();
            string sexo = pv.Sexo;
            string ocupacion = pv.Ocupacion.ToString();
            string peso = pv.Peso.ToString();
            string altura = pv.Altura.ToString();
            string dietaId = obtenerIdDieta(pv.Dieta.ToString()).ToString();
            string actividadId = obtenerIdActividad(pv.Actividad.ToString()).ToString();
            string consumeAlcohol = pv.ConsumeAlcohol.ToString();
            string consumeTabaco = pv.ConsumeTabaco.ToString();
            string consumeDrogas = pv.ConsumeDrogas.ToString();
            string hematologicas = pv.Hematologicas.ToString();
            string gastrointestinales = pv.Gastrointestinales.ToString();
            string endocrinas = pv.Endocrinas.ToString();
            string infecciosas = pv.Infecciosas.ToString();
            string autoinmunes = pv.Autoinmunes.ToString();
            string neurologicas = pv.Neurologicas.ToString();
            string renales = pv.Renales.ToString();
            string hepaticas = pv.Hépaticas.ToString();
            string diabetes = pv.Diabetes.ToString();
            string cancer = pv.Cancer.ToString();
            string respiratorias = pv.Respiratorias.ToString();
            string cardiacas = pv.Cardiacas.ToString();
            string tieneTerminacionAnticipada = pv.TieneTerminacionAnticipada.ToString();
            string tieneIncapacidadTemporal = pv.TieneIncapacidadTemporal.ToString();
            string tieneAccidentes = pv.TieneAccidentes.ToString();
            string capitalAsegurado = pv.CapitalAsegurado.ToString();
            string precio = pv.Precio.ToString();
            string dni = pv.Dni;
            List<string> datos = new List<string>
            {
                edad,sexo,ocupacion,peso,altura,dietaId,
                actividadId,consumeAlcohol,consumeTabaco,consumeDrogas,
                hematologicas,gastrointestinales,endocrinas,infecciosas,
                autoinmunes,neurologicas,renales,hepaticas,diabetes,
                cancer,respiratorias,cardiacas,tieneTerminacionAnticipada,
                tieneIncapacidadTemporal,tieneAccidentes,capitalAsegurado,precio,dni
            };
            return ControladorBBDD.ejecutarQueryParams(query, datos);
        }
        public static Dietas obtenerDieta(string Nombre)
        {
            string query = "SELECT * FROM Dieta WHERE Nombre = '" + Nombre + "'";
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                reader.Read();
                return (Dietas)Enum.Parse(typeof(Dietas), reader["Nombre"].ToString());
            }
        }
        public static Dietas obtenerDieta(int id)
        {
            string query = "SELECT * FROM Dieta WHERE Id = " + id;
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                reader.Read();
                string nombre = reader["Nombre"].ToString();
                return (Dietas)Enum.Parse(typeof(Dietas),nombre);                
            }
        }
        public static int obtenerIdDieta(string Nombre)
        {
            string query = "SELECT * FROM Dieta WHERE Nombre = '" + Nombre + "'";
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                reader.Read();
                return Convert.ToInt32(reader["Id"]);
            }
        }
        public static Actividades obtenerActividad(string Nombre)
        {
            string query = "SELECT * FROM Actividad WHERE Nombre = '" + Nombre + "'";
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                reader.Read();
                return (Actividades)Enum.Parse(typeof(Actividades), reader["Nombre"].ToString());
            }
        }
        public static Actividades obtenerActividad(int id)
        {
            string query = "SELECT * FROM Actividad WHERE Id = " + id;
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                reader.Read();
                string nombre = reader["Nombre"].ToString();
                return (Actividades)Enum.Parse(typeof(Actividades), nombre);
            }
        }
        public static int obtenerIdActividad(string Nombre)
        {
            string query = "SELECT * FROM Actividad WHERE Nombre = '" + Nombre + "'";
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                reader.Read();
                return Convert.ToInt32(reader["Id"]);
            }
        }
        public static PolizaVida obtenerPolizaVida(int id)
        {
            string query = "SELECT * FROM PolizaVida WHERE Id = " + id;
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    PolizaVida pv = new PolizaVida(
                        Convert.ToInt32(reader["Edad"]),
                        reader["Sexo"].ToString(),
                        Convert.ToInt32(reader["Ocupacion"]),
                        Convert.ToDouble(reader["Peso"]),
                        Convert.ToDouble(reader["Altura"]),
                        obtenerDieta(Convert.ToInt32(reader["DietaId"])),
                        obtenerActividad(Convert.ToInt32(reader["ActividadId"])),
                        Convert.ToBoolean(reader["ConsumeAlcohol"]),
                        Convert.ToBoolean(reader["ConsumeTabaco"]),
                        Convert.ToBoolean(reader["ConsumeDrogas"]),
                        Convert.ToBoolean(reader["Hematologicas"]),
                        Convert.ToBoolean(reader["Gastrointestinales"]),
                        Convert.ToBoolean(reader["Endocrinas"]),
                        Convert.ToBoolean(reader["Infecciosas"]),
                        Convert.ToBoolean(reader["Autoinmunes"]),
                        Convert.ToBoolean(reader["Neurologicas"]),
                        Convert.ToBoolean(reader["Renales"]),
                        Convert.ToBoolean(reader["Hepaticas"]),
                        Convert.ToBoolean(reader["Diabetes"]),
                        Convert.ToBoolean(reader["Cancer"]),
                        Convert.ToBoolean(reader["Respiratorias"]),
                        Convert.ToBoolean(reader["Cardiacas"]),
                        Convert.ToBoolean(reader["TieneTerminacionAnticipada"]),
                        Convert.ToBoolean(reader["TieneIncapacidadTemporal"]),
                        Convert.ToBoolean(reader["TieneAccidentes"]),
                        Convert.ToDouble(reader["CapitalAsegurado"]),
                        Convert.ToDouble(reader["Precio"]),
                        reader["Dni"].ToString()
                        );
                    return pv;
                }
                else
                {
                    return null;
                }
            }
        }
        public static int obtenerUltCod()
        {
            string query = "SELECT MAX(Id) FROM PolizaVida";
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                reader.Read();
                return Convert.ToInt32(reader[0]);
            }
        }
        public static int numPolizasCliente(string dni)
        {
            string query = "SELECT COUNT(*) FROM PolizaVida WHERE Dni = '" + dni + "'";
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                reader.Read();
                return Convert.ToInt32(reader[0]);
            }
        }
        public static bool eliminarPolizaVida(int id)
        {
            string query = "DELETE FROM PolizaVida WHERE Id = " + id;
            return ControladorBBDD.ejecutarQuery(query);
        }
    }
}
