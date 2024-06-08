using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFGProyecto.Modelo
{
    public enum Dietas
    {
        hipocalorica,
        hipercalorica,
        equilibrada
    }
    public enum Actividades
    {
        sedentaria,
        moderada,
        intensa
    }
    public class PolizaVida
    {
        private int edad;
        private string sexo;
        private string ocupacion;
        private double peso;
        private double altura;
        private Dietas dieta;
        private Actividades actividad;
        private bool consumeAlcohol;
        private bool consumeTabaco;
        private bool consumeDrogas;
        private bool hematologicas;
        private bool gastrointestinales;
        private bool endocrinas;
        private bool infecciosas;
        private bool autoinmunes;
        private bool neurologicas;
        private bool renales;
        private bool hépaticas;
        private bool diabetes;
        private bool cancer;
        private bool respiratorias;
        private bool cardiacas;
        private bool tieneTerminacionAnticipada;
        private bool tieneIncapacidadTemporal;
        private bool tieneAccidentes;
        private double capitalAsegurado;
        private string dni;

        public PolizaVida(int edad, string sexo, string ocupacion, 
            double peso, double altura, Dietas dieta, Actividades actividad, 
            bool consumeAlcohol, bool consumeTabaco, bool consumeDrogas, 
            bool hematologicas, bool gastrointestinales, bool endocrinas, 
            bool infecciosas, bool autoinmunes, bool neurologicas, 
            bool renales, bool hépaticas, bool diabetes, bool cancer, 
            bool respiratorias, bool cardiacas, 
            bool tieneTerminacionAnticipada, bool tieneIncapacidadTemporal, 
            bool tieneAccidentes, double capitalAsegurado, string dni)
        {
            Edad = edad;
            Sexo = sexo;
            Ocupacion = ocupacion;
            Peso = peso;
            Altura = altura;
            Dieta = dieta;
            Actividad = actividad;
            ConsumeAlcohol = consumeAlcohol;
            ConsumeTabaco = consumeTabaco;
            ConsumeDrogas = consumeDrogas;
            Hematologicas = hematologicas;
            Gastrointestinales = gastrointestinales;
            Endocrinas = endocrinas;
            Infecciosas = infecciosas;
            Autoinmunes = autoinmunes;
            Neurologicas = neurologicas;
            Renales = renales;
            Hépaticas = hépaticas;
            Diabetes = diabetes;
            Cancer = cancer;
            Respiratorias = respiratorias;
            Cardiacas = cardiacas;
            TieneTerminacionAnticipada = tieneTerminacionAnticipada;
            TieneIncapacidadTemporal = tieneIncapacidadTemporal;
            TieneAccidentes = tieneAccidentes;
            CapitalAsegurado = capitalAsegurado;
            Dni = dni;
        }

        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Ocupacion { get => ocupacion; set => ocupacion = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }
        public Dietas Dieta { get => dieta; set => dieta = value; }
        public Actividades Actividad { get => actividad; set => actividad = value; }
        public bool ConsumeAlcohol { get => consumeAlcohol; set => consumeAlcohol = value; }
        public bool ConsumeTabaco { get => consumeTabaco; set => consumeTabaco = value; }
        public bool ConsumeDrogas { get => consumeDrogas; set => consumeDrogas = value; }
        public bool Hematologicas { get => hematologicas; set => hematologicas = value; }
        public bool Gastrointestinales { get => gastrointestinales; set => gastrointestinales = value; }
        public bool Endocrinas { get => endocrinas; set => endocrinas = value; }
        public bool Infecciosas { get => infecciosas; set => infecciosas = value; }
        public bool Autoinmunes { get => autoinmunes; set => autoinmunes = value; }
        public bool Neurologicas { get => neurologicas; set => neurologicas = value; }
        public bool Renales { get => renales; set => renales = value; }
        public bool Hépaticas { get => hépaticas; set => hépaticas = value; }
        public bool Diabetes { get => diabetes; set => diabetes = value; }
        public bool Cancer { get => cancer; set => cancer = value; }
        public bool Respiratorias { get => respiratorias; set => respiratorias = value; }
        public bool Cardiacas { get => cardiacas; set => cardiacas = value; }
        public bool TieneTerminacionAnticipada { get => tieneTerminacionAnticipada; set => tieneTerminacionAnticipada = value; }
        public bool TieneIncapacidadTemporal { get => tieneIncapacidadTemporal; set => tieneIncapacidadTemporal = value; }
        public bool TieneAccidentes { get => tieneAccidentes; set => tieneAccidentes = value; }
        public double CapitalAsegurado { get => capitalAsegurado; set => capitalAsegurado = value; }
        public string Dni { get => dni; set => dni = value; }
    }
}
