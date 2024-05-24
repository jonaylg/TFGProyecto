using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFGProyecto.Modelo
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string direccion;
        private DateTime fechaNacimiento;
        private string telefono;
        private string correoElectronico;
        private string provincia;
        private string ciudad;
        private string tipo;
        private string direccionFacturacion;
        private int cvv;
        private string fechaVencimiento;
        private string nombreTitular;
        private string frecuenciaPago;
        private string metodoPago;
        private string dni;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string DireccionFacturacion { get => direccionFacturacion; set => direccionFacturacion = value; }
        public int Cvv { get => cvv; set => cvv = value; }
        public string FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public string NombreTitular { get => nombreTitular; set => nombreTitular = value; }
        public string FrecuenciaPago { get => frecuenciaPago; set => frecuenciaPago = value; }
        public string MetodoPago { get => metodoPago; set => metodoPago = value; }
        public string Dni { get => dni; set => dni = value; }

        public Cliente(string nombre, string apellido, string direccion, DateTime fechaNacimiento, string telefono, string correoElectronico, string provincia, string ciudad, string tipo, string direccionFacturacion, int cvv, string fechaVencimiento, string nombreTitular, string frecuenciaPago, string metodoPago)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.FechaNacimiento = fechaNacimiento;
            this.Telefono = telefono;
            this.CorreoElectronico = correoElectronico;
            this.Provincia = provincia;
            this.Ciudad = ciudad;
            this.Tipo = tipo;
            this.DireccionFacturacion = direccionFacturacion;
            this.Cvv = cvv;
            this.FechaVencimiento = fechaVencimiento;
            this.NombreTitular = nombreTitular;
            this.FrecuenciaPago = frecuenciaPago;
            this.MetodoPago = metodoPago;
        }

        public Cliente()
        {
        }

        public Cliente(string nombre, string apellido, string direccion, DateTime fechaNacimiento, string telefono, string correoElectronico, string provincia, string ciudad, string tipo, string direccionFacturacion, int cvv, string fechaVencimiento, string nombreTitular, string frecuenciaPago, string metodoPago, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.fechaNacimiento = fechaNacimiento;
            this.telefono = telefono;
            this.correoElectronico = correoElectronico;
            this.provincia = provincia;
            this.ciudad = ciudad;
            this.tipo = tipo;
            this.direccionFacturacion = direccionFacturacion;
            this.cvv = cvv;
            this.fechaVencimiento = fechaVencimiento;
            this.nombreTitular = nombreTitular;
            this.frecuenciaPago = frecuenciaPago;
            this.metodoPago = metodoPago;
            this.dni = dni;
        }

        public string VerCliente()
        {
            return $"{Nombre} {Apellido} - {Direccion}, {Ciudad}, {Provincia} - Teléfono: {Telefono} - Email: {CorreoElectronico}";
        }
    }
}
