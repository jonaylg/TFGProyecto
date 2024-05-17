using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFGProyecto.Modelo
{
    public enum P
    {
        Administrativo,
        Directivo,
        RRHH,
        Analista,
        Gerente,
        Sistemas,
        BBDD,
        Desarrollador
    }
    public class ComisionVida
    { 
        private int id;
        private int edad;
        private string sexo;
        private string ocupacion;
        private double peso;
        private double altura;
        private bool enfermedadesGastrointestinales;
        private bool enfermedadesRespiratorias;
        private bool enfermedadesInfecciosasCronicas;
        private bool enfermedadesHepaticas;
        private bool enfermedadesAutoinmunes;
        private bool enfermedadesRenales;
        private bool enfermedadesCardiacas;
        private bool cancer;
        private bool diabetes;
        private bool trastornosEndocrinos;
        private bool enfermedadesNeurologicas;
        private bool enfermedadesHematologicas;
        private bool dietaEquilibrada;
        private bool dietaAltaEnAzucares;
        private bool dietaAltaEnGrasas;
        private bool dietaAltaEnAzucaresYGrasas;
        private bool actividadAlta;
        private bool actividadMedia;
        private bool actividadBaja;
        private bool tabaco;
        private bool alcohol;
        private bool drogas;
        private bool suplementoFallecimientoPorAccidente;
        private bool suplementoPagoAnticipadoPorEnfermedadTerminal;
        private bool suplementoIncapacidadTotalPermanente;
        private int capitalPoliza;        
    }
}
