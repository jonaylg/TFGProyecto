using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFGProyecto;

namespace ProyectoTFG
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void buttonOlvClave_Click(object sender, EventArgs e)
        {
            FrmNuevaClave formu = new FrmNuevaClave();
            formu.ShowDialog();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {

        }       
        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {
            ControladorUsuario.CargarDatosEnListaUsuario();
        }

        private void buttonEntrar_Click_1(object sender, EventArgs e)
        {
            Boolean encontrado = false;
            if (textBoxClave.Text!=""&&textBoxUsuario.Text!="")
            {
                foreach (Usuario u in ControladorUsuario.listaUsuarios)
                {
                    if (u.Clave==textBoxClave.Text&&u.Nick==textBoxUsuario.Text)
                    {
                        MessageBox.Show("bienvenido "+u.Nick);
                        encontrado = true;
                    }
                }
                if (!encontrado) {
                    MessageBox.Show("no existe");
                }
            }
            else
            {
                MessageBox.Show("campos vacios");
            }
        }

        private void buttonRegistro_Click_1(object sender, EventArgs e)
        {
            FrmRegistroUsuario formu = new FrmRegistroUsuario();
            formu.ShowDialog();
        }
    }
}
