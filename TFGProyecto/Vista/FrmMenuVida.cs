using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFGProyecto.Controlador;

namespace TFGProyecto.Vista
{
    public partial class FrmMenuVida : Form
    {
        public FrmMenuVida()
        {
            InitializeComponent();
        }

        private void rdbttnSexo_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var control in grpbxFiltro.Controls)
            {
                if (control is MaskedTextBox mascara)
                {
                    mascara.Visible = false;
                }
                if (control is ComboBox combo)
                {
                    combo.Visible = true;
                    combo.DataSource = null;
                    combo.DisplayMember = null;
                    combo.Items.Clear();
                    combo.Items.Add("H");
                    combo.Items.Add("M");
                    combo.SelectedIndex = 0;
                }
                if (control is NumericUpDown nud)
                {
                    nud.Visible = false;
                }
            }
        }

        private void rdbttnOcupacion_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var control in grpbxFiltro.Controls)
            {
                if (control is MaskedTextBox mascara)
                {
                    mascara.Visible = false;
                }
                if (control is ComboBox combo)
                {
                    combo.Visible = true;
                    combo.Items.Clear();
                    combo.DataSource = trabajoBindingSource;
                    combo.DisplayMember = "Nombre";
                    combo.SelectedIndex = 0;
                }
                if (control is NumericUpDown nud)
                {
                    nud.Visible = false;
                }
            }
        }

        private void rdbttnEdad_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var control in grpbxFiltro.Controls)
            {
                if (control is MaskedTextBox mascara)
                {
                    mascara.Visible = false;
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

        private void rdbttnCapital_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var control in grpbxFiltro.Controls)
            {
                if (control is MaskedTextBox mascara)
                {
                    mascara.Visible = false;
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

        private void radioButtonDni_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var control in grpbxFiltro.Controls)
            {
                if (control is MaskedTextBox mascara)
                {
                    mascara.Visible = true;
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

        private void trabajoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trabajoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseTFGDataSet1);

        }

        private void FrmMenuVida_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'databaseTFGDataSet1.PolizaVida' Puede moverla o quitarla según sea necesario.
            this.polizaVidaTableAdapter.Fill(this.databaseTFGDataSet1.PolizaVida);
            this.trabajoTableAdapter.Fill(this.databaseTFGDataSet1.Trabajo);

        }

        private void buttonFilt_Click(object sender, EventArgs e)
        {
            string filtro = "";
            DataView dv = new DataView(databaseTFGDataSet1.PolizaVida);
            foreach (var control in groupBoxRB.Controls)
            {
                if (control is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        string texto = rb.Text;
                        string orden = "=";
                        if (comboBoxMayMenIgu.SelectedIndex != -1)
                        {
                            switch (comboBoxMayMenIgu.SelectedItem.ToString())
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
                            case "DNI":
                                filtro += "DNI = '" + msktxtbxDni.Text + "'";
                                break;
                            case "Sexo":
                                filtro += "Sexo = '" + cmbxGen.Text + "'";
                                break;
                            case "Ocupación":
                                filtro += "Ocupacion = '" + cmbxGen.Text + "'";
                                break;
                            case "Edad":
                                filtro += $"Edad {orden} " + nudGen.Value;
                                break;
                            case "Capital":
                                filtro += $"Capital {orden} " + nudGen.Value;
                                break;
                        }
                    }
                }
            }
            dv.RowFilter = filtro;
            dataGridViewPolizas.DataSource = dv;
        }
    }
}
