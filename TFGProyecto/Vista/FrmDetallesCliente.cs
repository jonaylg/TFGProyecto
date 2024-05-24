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
using TFGProyecto.Modelo;

namespace TFGProyecto.Vista
{
    public partial class FrmDetallesCliente : Form
    {
        public FrmDetallesCliente()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedItem.ToString() == "Tarjeta de Credito")
            {
                labelFV.Visible = true;
            }
        }

        private Cliente crearCliente()
        {
            Cliente c = new Cliente();
            if (maskedTextBoxDni.Text == "" || maskedTextBoxCVV.Text=="" || maskedTextBoxFV.Text=="" || maskedTextBoxTel.Text=="" || textBoxProv.Text=="" || textBoxNomTit.Text == "" || textBoxNombre.Text == "" || textBoxDirFac.Text == "" || textBoxDir.Text == "" || textBoxCorreo.Text == "" || textBoxCiu.Text == "" || textBoxApe.Text=="")
            {
                MessageBox.Show("Revise que no se hayan quedado campos sin rellenar");
            }
            else if (textBoxNombre.Text!=textBoxNomTit.Text)
            {
                MessageBox.Show(textBoxNombre.Text+"el nombre del titular "+ textBoxNomTit.Text);
            }
            else
            {
                c.Provincia=textBoxProv.Text;
                c.NombreTitular = textBoxNomTit.Text;
                c.Nombre = textBoxNombre.Text;
                c.Apellido=textBoxApe.Text;
                c.DireccionFacturacion = textBoxDirFac.Text;
                c.Direccion = textBoxDir.Text;
                c.CorreoElectronico = textBoxCorreo.Text;
                c.Ciudad=textBoxCiu.Text;
                c.Cvv = Int32.Parse(maskedTextBoxCVV.Text);
                c.FechaVencimiento = maskedTextBoxFV.Text;
                c.Telefono = maskedTextBoxTel.Text;
                c.Dni=maskedTextBoxDni.Text;
            }

            c.FechaNacimiento = dateTimePickerFN.Value;

            if (comboBoxFrecPag.SelectedIndex==-1 || comboBoxMetPag.SelectedIndex == -1 || comboBoxTipo.SelectedIndex == -1)
            {
                MessageBox.Show("por favor seleccione algun valor de las diferentes listas");
            }
            else
            {
                c.MetodoPago=comboBoxMetPag.SelectedItem.ToString();
                c.FrecuenciaPago=comboBoxFrecPag.SelectedItem.ToString();
                c.Tipo=comboBoxTipo.SelectedItem.ToString();
            }

            MessageBox.Show(c.MostrarDatos());

            return c;
        }

        private void buttonInserClien_Click(object sender, EventArgs e)
        {
            ControladorCliente.insertarCliente(crearCliente());
        }
    }
}
