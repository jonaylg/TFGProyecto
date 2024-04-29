using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            FrmInicioSesion formu =new FrmInicioSesion();
            formu.ShowDialog();
        }

        private void FrmRegistroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
