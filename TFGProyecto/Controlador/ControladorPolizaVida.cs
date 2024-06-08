using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGProyecto.Modelo;
using System.Data.SqlClient;

namespace TFGProyecto.Controlador
{
    public class ControladorPolizaVida
    {
        public static bool insertarPolVid(PolizaVida pv) {
            bool ok = true;
            string query = "INSERT INTO PolizaVida (" +
                "Edad,Sexo,Ocupacion,Peso,Altura,DietaId," +
                "ActividadId,ConsumeAlcohol,ConsumeTabaco," +
                "ConsumeDrogas,Hematologicas,Gastrointestinales," +
                "Endocrinas,Infecciosas,Autoinmunes,Neurologicas," +
                "Renales,Hepaticas,Diabetes,Cancer,Respiratorias," +
                "Cardiacas,TieneTerminacionAnticipada," +
                "TieneIncapacidadTemporal,TieneAccidentes," +
                "CapitalAsegurado,Dni" +
                ") VALUES (" +
                "@Edad,@Sexo,@Ocupacion,@Peso,@Altura,@DietaId," +
                "@ActividadId,@ConsumeAlcohol,@ConsumeTabaco,@ConsumeDrogas," +
                "@Hematologicas,@Gastrointestinales,@Endocrinas,@Infecciosas," +
                "@Autoinmunes,@Neurologicas,@Renales,@Hepaticas,@Diabetes," +
                "@Cancer,@Respiratorias,@Cardiacas,@TieneTerminacionAnticipada," +
                "@TieneIncapacidadTemporal,@TieneAccidentes," +
                "@CapitalAsegurado,@Dni";
            string edad = pv.Edad.ToString();
            string sexo = pv.Sexo;
            string ocupacion = pv.Ocupacion;
            string peso = pv.Peso.ToString();
            string altura = pv.Altura.ToString();
            string dietaId = pv.Dieta.ToString();
            string actividadId = pv.Actividad.ToString();
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
            string dni = pv.Dni;
            List<string> datos = new List<string>
            {
                edad,sexo,ocupacion,peso,altura,dietaId,
                actividadId,consumeAlcohol,consumeTabaco,consumeDrogas,
                hematologicas,gastrointestinales,endocrinas,infecciosas,
                autoinmunes,neurologicas,renales,hepaticas,diabetes,
                cancer,respiratorias,cardiacas,tieneTerminacionAnticipada,
                tieneIncapacidadTemporal,tieneAccidentes,capitalAsegurado,dni
            };
            return ControladorBBDD.ejecutarQueryParams(query, datos);
        }
        public static Dietas obtenerDieta(int id)
        {
            string query = "SELECT * FROM Dietas WHERE Id = " + id;
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                reader.Read();
                string nombre = reader["Nombre"].ToString();
                return (Dietas)Enum.Parse(typeof(Dietas),nombre);                
            }
        }
        public static Actividades obtenerActividad(int id)
        {
            string query = "SELECT * FROM Actividades WHERE Id = " + id;
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                reader.Read();
                string nombre = reader["Nombre"].ToString();
                return (Actividades)Enum.Parse(typeof(Actividades), nombre);
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
                        reader["Ocupacion"].ToString(),
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
