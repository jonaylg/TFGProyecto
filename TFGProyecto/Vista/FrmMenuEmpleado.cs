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
            string filtro = "";
            DataView vista = new DataView(databaseTFGDataSet1.Empleado);
            foreach (var control in groupBoxRB.Controls)
            {
                if (control is RadioButton radio)
                {
                    if (radio.Checked)
                    {
                        string texto = radio.Text;
                        string orden = "=";
                        if (cmbxMay.SelectedIndex != -1)
                        {
                            switch (cmbxMay.SelectedItem.ToString())
                            {
                                case "Mayor":
                                    orden = ">";
                                    break;
                                case "Menor":
                                    orden = "<";
                                    break;
                                case "Igual":
                                    orden = "=";
                                    break;
                            }
                        }
                        switch (texto)
                        {
                            case "Nombre":
                                filtro = "Nombre = '" + txtbxGen.Text + "'";
                                break;
                            case "Primer Apellido":
                                filtro = "Apellido1 = '" + txtbxGen.Text + "'";
                                break;
                            case "Puesto":
                                filtro = "Puesto = '" + cmbxPuesto.Text.ToString() + "'";
                                break;
                            case "Salario":
                                filtro = $"Salario {orden} " + nudSal.Value.ToString();
                                break;
                        }
                    }
                }
            }
            vista.RowFilter = filtro;
            dataGridViewEmpleados.DataSource = vista;
        }

        private void FrmMenuCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'databaseTFGDataSet1.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.databaseTFGDataSet1.Empleado);
            // TODO: esta línea de código carga datos en la tabla 'databaseTFGDataSet1.Puestos' Puede moverla o quitarla según sea necesario.
            this.puestosTableAdapter.Fill(this.databaseTFGDataSet1.Puestos);
            this.empleadoTableAdapter.Fill(this.databaseTFGDataSet1.Empleado);
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
            txtbxGen.Text = "";
            nudSal.Minimum = 0;
            nudSal.Maximum = 0;
            nudSal.Value = 0;
            cmbxMay.SelectedIndex = -1;
            cmbxPuesto.SelectedIndex = -1;
            dataGridViewEmpleados.DataSource = databaseTFGDataSet1.Empleado;
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

        private void radioButtonNom_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var control in grbxFiltro.Controls)
            {
                if (control is TextBox caja)
                {
                    caja.Visible = true;
                }
                if (control is ComboBox combo)
                {
                    combo.Visible = false;
                }
                if (control is NumericUpDown nud)
                {
                    nud.Visible = false;
                }
            }
        }

        private void rdbttnApellido1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var control in grbxFiltro.Controls)
            {
                if (control is TextBox caja)
                {
                    caja.Visible = true;
                }
                if (control is ComboBox combo)
                {
                    combo.Visible = false;
                }
                if (control is NumericUpDown nud)
                {
                    nud.Visible = false;
                }
            }
        }

        private void rdbttnPuesto_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var control in grbxFiltro.Controls)
            {
                if (control is TextBox caja)
                {
                    caja.Visible = false;
                }
                if (control is ComboBox combo)
                {
                    combo.Visible = true;
                }
                if (control is NumericUpDown nud)
                {
                    nud.Visible = false;
                }
            }
        }

        private void rdbttnSalario_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var control in grbxFiltro.Controls)
            {
                if (control is TextBox caja)
                {
                    caja.Visible = false;
                }
                if (control is ComboBox combo)
                {
                    combo.Visible = false;
                }
                if (control is NumericUpDown nud)
                {
                    nud.Visible = true;
                }
            }
        }

        private void menuToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmMenuEmpleado frmMenuEmpleado = new FrmMenuEmpleado();
            frmMenuEmpleado.ShowDialog();
        }
    }
}
