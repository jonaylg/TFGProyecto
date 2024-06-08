using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFGProyecto.Controlador;

namespace TFGProyecto.Vista
{
    public partial class FrmMenuEmpleado : Form
    {
        public FrmMenuEmpleado()
        {
            InitializeComponent();
        }

        private void buttonFilt_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmMenuCliente_Load(object sender, EventArgs e)
        {
            this.empleadoTableAdapter.Fill(this.databaseTFGDataSet1.Empleado);
        }

        private void dataGridViewPolizas_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (comboBoxTipo.SelectedIndex!=-1)
            {
                if (comboBoxTipo.SelectedItem == "Modificar")
                {
                    FrmDetallesEmpleado formu = new FrmDetallesEmpleado(ControladorEmpleado.obtenerEmpleado(dataGridViewEmpleados.CurrentRow.Cells[0].Value.ToString()));
                    formu.ShowDialog();
                }
                else
                {
                    FrmMenuPrincipal formu = new FrmMenuPrincipal(dataGridViewEmpleados.CurrentRow.Cells[0].Value.ToString());
                    formu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("selecciona el tipo de accion");
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            buttonMenu.Visible = false;
            menuStrip1.Visible = true;
        }

        private void altaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmPolizaVida formu = new FrmPolizaVida();
            formu.ShowDialog();
        }

        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPolizaHogar formu = new FrmPolizaHogar();
            formu.ShowDialog();
        }

        private void menuToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal formu=new FrmMenuPrincipal();
            formu.ShowDialog();
        }

        private void altaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmDetallesCliente formu=new FrmDetallesCliente();
            formu.ShowDialog();
        }

        private void menuToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmMenuCliente formu=new FrmMenuCliente();
            formu.ShowDialog();
        }

        private void buttonAct_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxRB_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            e.Graphics.Clear(Color.LightSkyBlue); // Cambia este color según tu diseño
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, box.Width - 1, box.Height - 1);
            e.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 10, 1);
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmDetallesEmpleado formu = new FrmDetallesEmpleado();
            formu.ShowDialog();
        }
    }
}
