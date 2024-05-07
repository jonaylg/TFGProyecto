﻿using System;
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
        private String nick;
        private String clave;
        private String pregPers;
        private String respuesta;
        private Rol rol;

        public string Nick { get => nick; set => nick = value; }
        public string Clave { get => clave; set => clave = value; }
        public string PregPers { get => pregPers; set => pregPers = value; }
        public string Respuesta { get => respuesta; set => respuesta = value; }
        public Rol Rol { get => rol; set => rol = value; }

        public Usuario(string nick, string clave, string pregPers, String respuesta, Rol rol)
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