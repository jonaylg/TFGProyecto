using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFGProyecto
{
    public class Usuario
    {
        private String nick;
        private String clave;
        private String pregPers;

        public string Nick { get => nick; set => nick = value; }
        public string Clave { get => clave; set => clave = value; }
        public string PregPers { get => pregPers; set => pregPers = value; }

        public Usuario(string nick, string clave, string pregPers)
        {
            this.Nick = nick;
            this.Clave = clave;
            this.PregPers = pregPers;
        }

        public Usuario()
        {
        }

        public string verUsuario()
        {
            return nick+" "+clave+" "+pregPers;
        }

    }
}
