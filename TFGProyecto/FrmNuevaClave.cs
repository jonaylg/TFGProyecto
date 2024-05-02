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
    public partial class FrmNuevaClave : Form
    {
        public FrmNuevaClave()
        {
            InitializeComponent();
        }
        private void buttonCambiar_Click_1(object sender, EventArgs e)
        {
            string respuesta = "";
            foreach (Usuario item in ControladorUsuario.listaUsuarios)
            {
                if (item.Nick==ControladorUsuario.usuarioActivo.Nick) {
                    labelRespuesta.Text = item.PregPers.ToString();
                    respuesta = item.Respuesta;
                }
            }

            if (textBoxRespuesta.Text.ToString()==respuesta)
            {
                if (textBoxClave.Text == textBoxClave2.Text)
                {
                    ControladorUsuario.modificarClave(ControladorUsuario.usuarioActivo.Nick,textBoxClave.Text);
                    MessageBox.Show("se modifico la clave");
                    FrmInicioSesion formu = new FrmInicioSesion();
                    formu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("las claves son distintas");
                }
            }
            else
            {
                MessageBox.Show("la respuesta es incorrecta ["+respuesta+"] -"+ textBoxRespuesta.Text + "-");
            }
            
        }

        private void FrmNuevaClave_Load(object sender, EventArgs e)
        {
            foreach (Usuario item in ControladorUsuario.listaUsuarios)
            {
                if (item.Nick == ControladorUsuario.usuarioActivo.Nick)
                {
                    labelRespuesta.Text = item.PregPers;
                }
            }
        }
    }
}
