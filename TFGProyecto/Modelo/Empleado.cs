using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFGProyecto.Modelo
{
    public enum Puesto
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
    public class Empleado
    {
        private Usuario usuario;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private DateTime fechaNac;
        private DateTime fechaContr;
        private Puesto puesto;
        private double salario;
        private string email;
        private int telefono;
        private string direccion;
        private string dni;

        public Usuario Usuario { get => usuario; set => usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public DateTime FechaContr { get => fechaContr; set => fechaContr = value; }
        public Puesto Puesto { get => puesto; set => puesto = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Dni { get => dni; set => dni = value; }

        public Empleado(Usuario usuario, string nombre, string apellido1, string apellido2, DateTime fechaNac, DateTime fechaContr, Puesto puesto, double salario, string email, int telefono, string direccion, string dni)
        {
            this.Usuario = usuario;
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.FechaNac = fechaNac;
            this.FechaContr = fechaContr;
            this.Puesto = puesto;
            this.Salario = salario;
            this.Email = email;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Dni = dni;
        }
        public Empleado() { }
    }
}
