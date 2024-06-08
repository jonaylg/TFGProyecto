using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFGProyecto.Modelo;

namespace TFGProyecto.Vista
{
    public partial class FrmDetallesEmpleado : Form
    {
        public FrmDetallesEmpleado()
        {
            InitializeComponent();
        }
        public FrmDetallesEmpleado(Empleado e)
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
