using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGProyecto.Controlador;

namespace TFGProyecto.Modelo
{
    public class Rol
    {
        private int id;
        private string nombre;
        private string descripcion;
        private List<Privilegio> privilegios;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public List<Privilegio> Privilegios { get => privilegios; set => privilegios = value; }

        public Rol()
        {
            this.Id = ControladorRol.idRolActivo;
            ControladorRol.idRolActivo++;
        }

        public Rol(string nombre, string descripcion, List<Privilegio> privilegios)
        {
            this.Id = ControladorRol.idRolActivo;
            ControladorRol.idRolActivo++;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Privilegios = privilegios;
        }

        public bool addPrivilegio(Privilegio privilegio)
        {
            if (privilegios.Contains(privilegio))
            {
                return false;
            }
            else
            {
                privilegios.Add(privilegio);
                return true;
            }
        }

        public bool delPrivilegio(Privilegio privilegio)
        {
            if (privilegios.Contains(privilegio))
            {
                privilegios.Remove(privilegio);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
