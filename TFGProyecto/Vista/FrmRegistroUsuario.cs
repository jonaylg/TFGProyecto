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
using TFGProyecto.Controlador;
using TFGProyecto.Modelo;

namespace ProyectoTFG
{
    public partial class FrmRegistroUsuario : Form
    {
        public FrmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void buttonAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta pregunta sirve de " +
                "modo que, en el caso de olvidar la " +
                "clave, puedas volver a recuperar la cuenta");
        }
        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {
            cmbxRol.DataSource = ControladorRol.listaRoles;
            cmbxRol.DisplayMember = "Nombre";
        }

        private void buttonCrear_Click_1(object sender, EventArgs e)
        {
            if (textBoxClave.Text!="" && textBoxClave2.Text!="" && textBoxPregPers.Text != "" && textBoxRespuesta.Text != "" && textBoxRespuesta2.Text != "" && textBoxUsuario.Text != "")
            {//comprueba que los campos no esten vacios
                if (textBoxClave.Text==textBoxClave2.Text && textBoxRespuesta.Text==textBoxRespuesta2.Text)
                {
                    Usuario u = new Usuario(textBoxUsuario.Text, textBoxClave.Text, textBoxPregPers.Text, textBoxRespuesta.Text, (Rol)cmbxRol.SelectedItem);
                    ControladorUsuario.insertarUsuario(u);
                    ControladorUsuario.listaUsuarios.Add(u);
                    FrmInicioSesion formu = new FrmInicioSesion();
                    formu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("las claves o respuestas no coinciden");
                }
            }
        }
    }
}
