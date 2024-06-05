using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFGProyecto.Modelo
{
    public class PolizaHogar
    {
        private string tipoVivienda;
        private string zonaVivienda;
        private int anhoConstruccion;
        private int metrosConstruidos;
        private int metrosTotales;
        private double valorVivienda;
        private double valorContenido;
        private int habitaciones;
        private bool mascota;
        private bool piscina;
        private bool garaje;
        private bool personalSeguridad;
        private bool camaras;
        private bool cajaFuerte;
        private bool verja;
        private bool alarma;
        private string tipoMaterial;
        private string usoVivienda;
        private bool roboEnCasa;
        private bool incendio;
        private bool fenomenosAtmosfericos;
        private bool responsabilidadDaniosEstructurales;
        private bool roturaCristales;
        private bool aguaElectricidad;
        private bool inhabitabilidad;
        private bool defensaJuridica;
        private bool roturaTuberias;
        private bool derrumbe;
        private bool asistenciaInformacion;
        private bool asistenciaViaje;
        private bool actosVandalicos;
        private bool promociones;
        private bool reparacion24Horas;
        private bool vehiculoEnGaraje;
        private bool juridicaAvanzada;
        private string dni;
        private double precio;
        private DateTime fechaComienzo;
        private DateTime fechaExpiracion;

        // Propiedades
        public string TipoVivienda { get => tipoVivienda; set => tipoVivienda = value; }
        public string ZonaVivienda { get => zonaVivienda; set => zonaVivienda = value; }
        public int AnhoConstruccion { get => anhoConstruccion; set => anhoConstruccion = value; }
        public int MetrosConstruidos { get => metrosConstruidos; set => metrosConstruidos = value; }
        public int MetrosTotales { get => metrosTotales; set => metrosTotales = value; }
        public double ValorVivienda { get => valorVivienda; set => valorVivienda = value; }
        public double ValorContenido { get => valorContenido; set => valorContenido = value; }
        public int Habitaciones { get => habitaciones; set => habitaciones = value; }
        public bool Mascota { get => mascota; set => mascota = value; }
        public bool Piscina { get => piscina; set => piscina = value; }
        public bool Garaje { get => garaje; set => garaje = value; }
        public bool PersonalSeguridad { get => personalSeguridad; set => personalSeguridad = value; }
        public bool Camaras { get => camaras; set => camaras = value; }
        public bool CajaFuerte { get => cajaFuerte; set => cajaFuerte = value; }
        public bool Verja { get => verja; set => verja = value; }
        public bool Alarma { get => alarma; set => alarma = value; }
        public string TipoMaterial { get => tipoMaterial; set => tipoMaterial = value; }
        public string UsoVivienda { get => usoVivienda; set => usoVivienda = value; }
        public bool RoboEnCasa { get => roboEnCasa; set => roboEnCasa = value; }
        public bool Incendio { get => incendio; set => incendio = value; }
        public bool FenomenosAtmosfericos { get => fenomenosAtmosfericos; set => fenomenosAtmosfericos = value; }
        public bool ResponsabilidadDaniosEstructurales { get => responsabilidadDaniosEstructurales; set => responsabilidadDaniosEstructurales = value; }
        public bool RoturaCristales { get => roturaCristales; set => roturaCristales = value; }
        public bool AguaElectricidad { get => aguaElectricidad; set => aguaElectricidad = value; }
        public bool Inhabitabilidad { get => inhabitabilidad; set => inhabitabilidad = value; }
        public bool DefensaJuridica { get => defensaJuridica; set => defensaJuridica = value; }
        public bool RoturaTuberias { get => roturaTuberias; set => roturaTuberias = value; }
        public bool Derrumbe { get => derrumbe; set => derrumbe = value; }
        public bool AsistenciaInformacion { get => asistenciaInformacion; set => asistenciaInformacion = value; }
        public bool AsistenciaViaje { get => asistenciaViaje; set => asistenciaViaje = value; }
        public bool ActosVandalicos { get => actosVandalicos; set => actosVandalicos = value; }
        public bool Promociones { get => promociones; set => promociones = value; }
        public bool Reparacion24Horas { get => reparacion24Horas; set => reparacion24Horas = value; }
        public bool VehiculoEnGaraje { get => vehiculoEnGaraje; set => vehiculoEnGaraje = value; }
        public bool JuridicaAvanzada { get => juridicaAvanzada; set => juridicaAvanzada = value; }
        public string Dni { get => dni; set => dni = value; }
        public double Precio { get => precio; set => precio = value; }
        public DateTime FechaComienzo { get => fechaComienzo; set => fechaComienzo = value; }
        public DateTime FechaExpiracion { get => fechaExpiracion; set => fechaExpiracion = value; }

        // Constructores
        public PolizaHogar()
        {
        }

        public PolizaHogar(string tipoVivienda, string zonaVivienda, int anhoConstruccion, int metrosConstruidos, int metrosTotales,
                    double valorVivienda, double valorContenido, int habitaciones, bool mascota, bool piscina, bool garaje,
                    bool personalSeguridad, bool camaras, bool cajaFuerte, bool verja, bool alarma, string tipoMaterial,
                    string usoVivienda, bool roboEnCasa, bool incendio, bool fenomenosAtmosfericos, bool responsabilidadDaniosEstructurales,
                    bool roturaCristales, bool aguaElectricidad, bool inhabitabilidad, bool defensaJuridica, bool roturaTuberias,
                    bool derrumbe, bool asistenciaInformacion, bool asistenciaViaje, bool actosVandalicos, bool promociones,
                    bool reparacion24Horas, bool vehiculoEnGaraje, bool juridicaAvanzada, string dni, double precio)
        {
            this.tipoVivienda = tipoVivienda;
            this.zonaVivienda = zonaVivienda;
            this.anhoConstruccion = anhoConstruccion;
            this.metrosConstruidos = metrosConstruidos;
            this.metrosTotales = metrosTotales;
            this.valorVivienda = valorVivienda;
            this.valorContenido = valorContenido;
            this.habitaciones = habitaciones;
            this.mascota = mascota;
            this.piscina = piscina;
            this.garaje = garaje;
            this.personalSeguridad = personalSeguridad;
            this.camaras = camaras;
            this.cajaFuerte = cajaFuerte;
            this.verja = verja;
            this.alarma = alarma;
            this.tipoMaterial = tipoMaterial;
            this.usoVivienda = usoVivienda;
            this.roboEnCasa = roboEnCasa;
            this.incendio = incendio;
            this.fenomenosAtmosfericos = fenomenosAtmosfericos;
            this.responsabilidadDaniosEstructurales = responsabilidadDaniosEstructurales;
            this.roturaCristales = roturaCristales;
            this.aguaElectricidad = aguaElectricidad;
            this.inhabitabilidad = inhabitabilidad;
            this.defensaJuridica = defensaJuridica;
            this.roturaTuberias = roturaTuberias;
            this.derrumbe = derrumbe;
            this.asistenciaInformacion = asistenciaInformacion;
            this.asistenciaViaje = asistenciaViaje;
            this.actosVandalicos = actosVandalicos;
            this.promociones = promociones;
            this.reparacion24Horas = reparacion24Horas;
            this.vehiculoEnGaraje = vehiculoEnGaraje;
            this.juridicaAvanzada = juridicaAvanzada;
            this.dni = dni;
            this.precio = precio;
        }

        public PolizaHogar(string tipoVivienda, string zonaVivienda, int anhoConstruccion, int metrosConstruidos, int metrosTotales, double valorVivienda, double valorContenido, int habitaciones, bool mascota, bool piscina, bool garaje, bool personalSeguridad, bool camaras, bool cajaFuerte, bool verja, bool alarma, string tipoMaterial, string usoVivienda, bool roboEnCasa, bool incendio, bool fenomenosAtmosfericos, bool responsabilidadDaniosEstructurales, bool roturaCristales, bool aguaElectricidad, bool inhabitabilidad, bool defensaJuridica, bool roturaTuberias, bool derrumbe, bool asistenciaInformacion, bool asistenciaViaje, bool actosVandalicos, bool promociones, bool reparacion24Horas, bool vehiculoEnGaraje, bool juridicaAvanzada, string dni, double precio, DateTime fechaComienzo, DateTime fechaExpiracion)
        {
            this.tipoVivienda = tipoVivienda;
            this.zonaVivienda = zonaVivienda;
            this.anhoConstruccion = anhoConstruccion;
            this.metrosConstruidos = metrosConstruidos;
            this.metrosTotales = metrosTotales;
            this.valorVivienda = valorVivienda;
            this.valorContenido = valorContenido;
            this.habitaciones = habitaciones;
            this.mascota = mascota;
            this.piscina = piscina;
            this.garaje = garaje;
            this.personalSeguridad = personalSeguridad;
            this.camaras = camaras;
            this.cajaFuerte = cajaFuerte;
            this.verja = verja;
            this.alarma = alarma;
            this.tipoMaterial = tipoMaterial;
            this.usoVivienda = usoVivienda;
            this.roboEnCasa = roboEnCasa;
            this.incendio = incendio;
            this.fenomenosAtmosfericos = fenomenosAtmosfericos;
            this.responsabilidadDaniosEstructurales = responsabilidadDaniosEstructurales;
            this.roturaCristales = roturaCristales;
            this.aguaElectricidad = aguaElectricidad;
            this.inhabitabilidad = inhabitabilidad;
            this.defensaJuridica = defensaJuridica;
            this.roturaTuberias = roturaTuberias;
            this.derrumbe = derrumbe;
            this.asistenciaInformacion = asistenciaInformacion;
            this.asistenciaViaje = asistenciaViaje;
            this.actosVandalicos = actosVandalicos;
            this.promociones = promociones;
            this.reparacion24Horas = reparacion24Horas;
            this.vehiculoEnGaraje = vehiculoEnGaraje;
            this.juridicaAvanzada = juridicaAvanzada;
            this.dni = dni;
            this.precio = precio;
            this.fechaComienzo = fechaComienzo;
            this.fechaExpiracion = fechaExpiracion;
        }

        public string MostrarDatos()
{
    return $"Tipo de vivienda: {tipoVivienda}\n" +
           $"Zona de vivienda: {zonaVivienda}\n" +
           $"Año de construcción: {anhoConstruccion}\n" +
           $"Metros construidos: {metrosConstruidos}\n" +
           $"Metros totales: {metrosTotales}\n" +
           $"Valor de la vivienda: {valorVivienda}\n" +
           $"Valor del contenido: {valorContenido}\n" +
           $"Número de habitaciones: {habitaciones}\n" +
           $"¿Tiene mascota?: {(mascota ? "Sí" : "No")}\n" +
           $"¿Tiene piscina?: {(piscina ? "Sí" : "No")}\n" +
           $"¿Tiene garaje?: {(garaje ? "Sí" : "No")}\n" +
           $"¿Tiene personal de seguridad?: {(personalSeguridad ? "Sí" : "No")}\n" +
           $"¿Tiene cámaras de seguridad?: {(camaras ? "Sí" : "No")}\n" +
           $"¿Tiene caja fuerte?: {(cajaFuerte ? "Sí" : "No")}\n" +
           $"¿Tiene verja?: {(verja ? "Sí" : "No")}\n" +
           $"¿Tiene alarma?: {(alarma ? "Sí" : "No")}\n" +
           $"Tipo de material: {tipoMaterial}\n" +
           $"Uso de la vivienda: {usoVivienda}\n" +
           $"¿Robo en casa cubierto?: {(roboEnCasa ? "Sí" : "No")}\n" +
           $"¿Incendio cubierto?: {(incendio ? "Sí" : "No")}\n" +
           $"¿Fenómenos atmosféricos cubiertos?: {(fenomenosAtmosfericos ? "Sí" : "No")}\n" +
           $"¿Responsabilidad por daños estructurales cubierta?: {(responsabilidadDaniosEstructurales ? "Sí" : "No")}\n" +
           $"¿Rotura de cristales cubierta?: {(roturaCristales ? "Sí" : "No")}\n" +
           $"¿Daños por agua y electricidad cubiertos?: {(aguaElectricidad ? "Sí" : "No")}\n" +
           $"¿Inhabitabilidad cubierta?: {(inhabitabilidad ? "Sí" : "No")}\n" +
           $"¿Defensa jurídica cubierta?: {(defensaJuridica ? "Sí" : "No")}\n" +
           $"¿Rotura de tuberías cubierta?: {(roturaTuberias ? "Sí" : "No")}\n" +
           $"¿Derrumbe cubierto?: {(derrumbe ? "Sí" : "No")}\n" +
           $"¿Asistencia e información cubierta?: {(asistenciaInformacion ? "Sí" : "No")}\n" +
           $"¿Asistencia en viaje cubierta?: {(asistenciaViaje ? "Sí" : "No")}\n" +
           $"¿Actos vandálicos cubiertos?: {(actosVandalicos ? "Sí" : "No")}\n" +
           $"¿Ofertas y promociones?: {(promociones ? "Sí" : "No")}\n" +
           $"¿Reparación 24 horas?: {(reparacion24Horas ? "Sí" : "No")}\n" +
           $"¿Vehículo en garaje cubierto?: {(vehiculoEnGaraje ? "Sí" : "No")}\n" +
           $"¿Defensa jurídica avanzada?: {(juridicaAvanzada ? "Sí" : "No")}\n" +
           $"DNI: {dni}\n" +
           $"Precio: {precio}\n"+
           $"Fecha Comienzo: {fechaComienzo}\n" +
           $"Fecha Expiracion: {fechaExpiracion}";
}

    }
}
