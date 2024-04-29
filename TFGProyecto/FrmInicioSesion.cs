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

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuario formu=new FrmRegistroUsuario();
            formu.ShowDialog();
        }
    }
}
