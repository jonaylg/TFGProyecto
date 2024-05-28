using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGProyecto.Modelo;

namespace TFGProyecto
{
    public class Usuario
    {
        private int id;
        private string nick;
        private string clave;
        private string pregPers;
        private string respuesta;
        private Rol rol;

        public int Id { get => id; set => id = value; }
        public string Nick { get => nick; set => nick = value; }
        public string Clave { get => clave; set => clave = value; }
        public string PregPers { get => pregPers; set => pregPers = value; }
        public string Respuesta { get => respuesta; set => respuesta = value; }
        public Rol Rol { get => rol; set => rol = value; }

        public Usuario(string nick, string clave, string pregPers, string respuesta, Rol rol)
        {
            this.Nick = nick;
            this.Clave = clave;
            this.PregPers = pregPers;
            this.respuesta = respuesta;
            this.Rol = rol;
        }

        public Usuario()
        {
        }

        public string verUsuario()
        {
            return nick+" "+clave+" "+pregPers+" "+respuesta;
        }

    }
}
