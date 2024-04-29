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
    public partial class FrmNuevaClave : Form
    {
        public FrmNuevaClave()
        {
            InitializeComponent();
        }

        private void buttonCambiar_Click(object sender, EventArgs e)
        {
            FrmInicioSesion formu=new FrmInicioSesion();
            formu.ShowDialog();
        }
    }
}
