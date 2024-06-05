using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFGProyecto.Modelo;

namespace TFGProyecto.Controlador
{
    public class ControladorPolHog
    {
        public static List<PolizaHogar> listaPolHog = new List<PolizaHogar>();
        public static PolizaHogar polizaHogActiva = new PolizaHogar();

        public static bool insertarPolHog(PolizaHogar ph)
        {
            string query = "INSERT INTO PolizaHogar VALUES(@tipoVivienda, @zonaVivienda, @anhoConstruccion, " +
                "@metrosConstruidos, @metrosTotales, @valorVivienda, @valorContenido, " +
                "@habitaciones, @mascota, @piscina, @garaje, @personalSeguridad, @camaras, " +
                "@cajaFuerte, @verja, @alarma, @tipoMaterial, @usoVivienda, @roboEnCasa, " +
                "@incendio, @fenomenosAtmosfericos, @responsabilidadDaniosEstructurales, " +
                "@roturaCristales, @aguaElectricidad, @inhabitabilidad, @defensaJuridica, " +
                "@roturaTuberias, @derrumbe, @asistenciaInformacion, @asistenciaViaje, " +
                "@actosVandalicos, @promociones, @reparacion24Horas, @vehiculoEnGaraje, " +
                "@juridicaAvanzada, @dni, @precio, @fechaComienzo, @fechaExpiracion)";
            string tipoVivienda = ph.TipoVivienda;
            string zonaVivienda = ph.ZonaVivienda;
            string anhoConstruccion = ph.AnhoConstruccion.ToString();
            string metrosConstruidos = ph.MetrosConstruidos.ToString();
            string metrosTotales = ph.MetrosTotales.ToString();
            string valorVivienda = ph.ValorVivienda.ToString();
            string valorContenido = ph.ValorContenido.ToString();
            string habitaciones = ph.Habitaciones.ToString();
            string mascota = ph.Mascota ? "1" : "0";
            string piscina = ph.Piscina ? "1" : "0";
            string garaje = ph.Garaje ? "1" : "0";
            string personalSeguridad = ph.PersonalSeguridad ? "1" : "0";
            string camaras = ph.Camaras ? "1" : "0";
            string cajaFuerte = ph.CajaFuerte ? "1" : "0";
            string verja = ph.Verja ? "1" : "0";
            string alarma = ph.Alarma ? "1" : "0";
            string tipoMaterial = ph.TipoMaterial;
            string usoVivienda = ph.UsoVivienda;
            string roboEnCasa = ph.RoboEnCasa ? "1" : "0";
            string incendio = ph.Incendio ? "1" : "0";
            string fenomenosAtmosfericos = ph.FenomenosAtmosfericos ? "1" : "0";
            string responsabilidadDaniosEstructurales = ph.ResponsabilidadDaniosEstructurales ? "1" : "0";
            string roturaCristales = ph.RoturaCristales ? "1" : "0";
            string aguaElectricidad = ph.AguaElectricidad ? "1" : "0";
            string inhabitabilidad = ph.Inhabitabilidad ? "1" : "0";
            string defensaJuridica = ph.DefensaJuridica ? "1" : "0";
            string roturaTuberias = ph.RoturaTuberias ? "1" : "0";
            string derrumbe = ph.Derrumbe ? "1" : "0";
            string asistenciaInformacion = ph.AsistenciaInformacion ? "1" : "0";
            string asistenciaViaje = ph.AsistenciaViaje ? "1" : "0";
            string actosVandalicos = ph.ActosVandalicos ? "1" : "0";
            string promociones = ph.Promociones ? "1" : "0";
            string reparacion24Horas = ph.Reparacion24Horas ? "1" : "0";
            string vehiculoEnGaraje = ph.VehiculoEnGaraje ? "1" : "0";
            string juridicaAvanzada = ph.JuridicaAvanzada ? "1" : "0";
            string dni = ph.Dni;
            string precio = ph.Precio.ToString();
            string fechaComienzo=ph.FechaComienzo.ToString();
            string fechaExpiracion = ph.FechaExpiracion.ToString();

            // Agregar los valores a la lista de datos
            List<string> datos = new List<string>
            {
                tipoVivienda, zonaVivienda, anhoConstruccion, metrosConstruidos, metrosTotales,
                valorVivienda, valorContenido, habitaciones, mascota, piscina, garaje,
                personalSeguridad, camaras, cajaFuerte, verja, alarma, tipoMaterial,
                usoVivienda, roboEnCasa, incendio, fenomenosAtmosfericos,
                responsabilidadDaniosEstructurales, roturaCristales, aguaElectricidad,
                inhabitabilidad, defensaJuridica, roturaTuberias, derrumbe,
                asistenciaInformacion, asistenciaViaje, actosVandalicos, promociones,
                reparacion24Horas, vehiculoEnGaraje, juridicaAvanzada, dni, precio, fechaComienzo, fechaExpiracion
            };
            bool ok = ControladorBBDD.ejecutarQueryParams(query, datos);
            
            return ok;
            
        }

        public static PolizaHogar obtenerPolizaHogar(int id)
        {
            PolizaHogar PolizaHogar = null;
            string query = $"SELECT * FROM PolizaHogar WHERE id = {id}";
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                if (reader.Read())
                {
                    PolizaHogar = new PolizaHogar(
                        reader["tipoVivienda"].ToString(),
                        reader["zonaVivienda"].ToString(),
                        Int32.Parse(reader["anhoConstruccion"].ToString()),
                        Int32.Parse(reader["metrosConstruidos"].ToString()),
                        Int32.Parse(reader["metrosTotales"].ToString()),
                        Double.Parse(reader["valorVivienda"].ToString()),
                        Double.Parse(reader["valorContenido"].ToString()),
                        Int32.Parse(reader["habitaciones"].ToString()),
                        (reader["mascota"].ToString() == "1"),
                        (reader["piscina"].ToString() == "1"),
                        (reader["garaje"].ToString() == "1"),
                        (reader["personalSeguridad"].ToString() == "1"),
                        (reader["camaras"].ToString() == "1"),
                        (reader["cajaFuerte"].ToString() == "1"),
                        (reader["verja"].ToString() == "1"),
                        (reader["alarma"].ToString() == "1"),
                        reader["tipoMaterial"].ToString(),
                        reader["usoVivienda"].ToString(),
                        (reader["roboEnCasa"].ToString() == "1"),
                        (reader["incendio"].ToString() == "1"),
                        (reader["fenomenosAtmosfericos"].ToString() == "1"),
                        (reader["responsabilidadDaniosEstructurales"].ToString() == "1"),
                        (reader["roturaCristales"].ToString() == "1"),
                        (reader["aguaElectricidad"].ToString() == "1"),
                        (reader["inhabitabilidad"].ToString() == "1"),
                        (reader["defensaJuridica"].ToString() == "1"),
                        (reader["roturaTuberias"].ToString() == "1"),
                        (reader["derrumbe"].ToString() == "1"),
                        (reader["asistenciaInformacion"].ToString() == "1"),
                        (reader["asistenciaViaje"].ToString() == "1"),
                        (reader["actosVandalicos"].ToString() == "1"),
                        (reader["promociones"].ToString() == "1"),
                        (reader["reparacion24Horas"].ToString() == "1"),
                        (reader["vehiculoEnGaraje"].ToString() == "1"),
                        (reader["juridicaAvanzada"].ToString() == "1"),
                        reader["dni"].ToString(),
                        Double.Parse(reader["precio"].ToString()),
                        DateTime.Parse(reader["fechaComienzo"].ToString()),
                        DateTime.Parse(reader["fechaExpiracion"].ToString())
                    ); ;
                }
            }
            return PolizaHogar;
        }

    }
}
