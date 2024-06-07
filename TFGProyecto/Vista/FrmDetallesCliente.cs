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
        private String dni;
        public FrmDetallesCliente()
        {
            InitializeComponent();
        }

        public FrmDetallesCliente(Cliente c)
        {
            InitializeComponent();
            rellenarCampos(c);
            this.dni = c.Dni;
        }

        public FrmDetallesCliente(String dni)
        {
            InitializeComponent();
            this.dni = dni;
            maskedTextBoxDni.Text = dni;
        }

        private void rellenarCampos(Cliente c)
        {
            maskedTextBoxDni.Text = c.Dni;
            textBoxNombre.Text = c.Nombre;
            textBoxApe.Text = c.Apellido;
            textBoxDir.Text=c.Direccion;
            dateTimePickerFN.Value = c.FechaNacimiento;
            maskedTextBoxTel.Text = c.Telefono;
            textBoxCorreo.Text = c.CorreoElectronico;
            textBoxProv.Text = c.Provincia;
            textBoxCiu.Text = c.Ciudad;
            comboBoxTipo.SelectedItem = c.Tipo;
            textBoxDirFac.Text = c.DireccionFacturacion;
            maskedTextBoxCVV.Text = c.Cvv.ToString();
            maskedTextBoxFV.Text = c.FechaVencimiento;
            textBoxNomTit.Text = c.NombreTitular;
            comboBoxFrecPag.SelectedItem = c.FrecuenciaPago;
            comboBoxMetPag.SelectedItem = c.MetodoPago;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedItem.ToString() == "Tarjeta de Credito")
            {
                labelFV.Visible = true;
                maskedTextBoxFV.Visible = true;
            }
            else
            {
                labelFV.Visible = false;
                maskedTextBoxFV.Visible = false;
            }
        }

        private Cliente crearCliente()
        {
            Cliente c = new Cliente();
            if (maskedTextBoxDni.Text==this.dni)
            {
                if (maskedTextBoxDni.Text == "" || maskedTextBoxCVV.Text == "" || maskedTextBoxTel.Text == "" || textBoxProv.Text == "" || textBoxNomTit.Text == "" || textBoxNombre.Text == "" || textBoxDirFac.Text == "" || textBoxDir.Text == "" || textBoxCorreo.Text == "" || textBoxCiu.Text == "" || textBoxApe.Text == "")
                {
                    MessageBox.Show("Revise que no se hayan quedado campos sin rellenar");
                }
                else
                {
                    c.Provincia = textBoxProv.Text;
                    c.NombreTitular = textBoxNomTit.Text;
                    c.Nombre = textBoxNombre.Text;
                    c.Apellido = textBoxApe.Text;
                    c.DireccionFacturacion = textBoxDirFac.Text;
                    c.Direccion = textBoxDir.Text;
                    c.CorreoElectronico = textBoxCorreo.Text;
                    c.Ciudad = textBoxCiu.Text;
                    c.Cvv = Int32.Parse(maskedTextBoxCVV.Text);
                    if (maskedTextBoxFV.Text=="" || maskedTextBoxFV.Text==null)
                    {
                        maskedTextBoxFV.Text = "00/00";
                    }
                    else
                    {
                        c.FechaVencimiento = maskedTextBoxFV.Text;
                    }
                    c.Telefono = maskedTextBoxTel.Text;
                    c.Dni = maskedTextBoxDni.Text;
                }

                c.FechaNacimiento = dateTimePickerFN.Value;

                if (comboBoxFrecPag.SelectedIndex == -1 || comboBoxMetPag.SelectedIndex == -1 || comboBoxTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("por favor seleccione algun valor de las diferentes listas");
                }
                else
                {
                    c.MetodoPago = comboBoxMetPag.SelectedItem.ToString();
                    c.FrecuenciaPago = comboBoxFrecPag.SelectedItem.ToString();
                    c.Tipo = comboBoxTipo.SelectedItem.ToString();
                }

                MessageBox.Show(c.MostrarDatos());
            }
            else
            {
                MessageBox.Show("el dni es diferente al guardado en la poliza");
            }

            return c;
        }

        private void buttonInserClien_Click(object sender, EventArgs e)
        {
            if (infoCorrecta())
            {
                ControladorCliente.insertarCliente(crearCliente());
                FrmMenuCliente formu=new FrmMenuCliente();
                formu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hay informacion erronea asegurese de que ha rellenado los campos correctamente");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxDni.Text!="" || maskedTextBoxDni.Text != null)
            {
                ControladorCliente.eliminarCliente(maskedTextBoxDni.Text);
            }
        }

        private Boolean infoCorrecta()
        {
            Boolean b=true;
            foreach (Control item in tabPagePers.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = (TextBox)item;
                    if (tb.Text=="" || tb.Text==null)
                    {
                        tb.BackColor=Color.Red;
                        b = false;
                    }
                }
            }

            if ((DateTime.Today.Year - dateTimePickerFN.Value.Year) < 18)
            {
                MessageBox.Show("tienes que ser mayor de edad");
                dateTimePickerFN.BackColor = Color.Red;
                b = false;
            }
            else
            {
                labelFN.BackColor = Color.Green;
            }

            foreach (Control item in tabPageBan.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = (TextBox)item;
                    if (tb.Text == "" || tb.Text == null)
                    {
                        tb.BackColor = Color.Red;
                        b = false;
                    }
                }else if(item is MaskedTextBox){
                    MaskedTextBox mtb=(MaskedTextBox)item;
                    if (mtb.Text == "" || mtb.Text == null)
                    {
                        mtb.BackColor = Color.Red;
                        b = false;
                    }
                }else if (item is ComboBox)
                {
                    ComboBox cb = (ComboBox)item;
                    if (cb.SelectedIndex == -1)
                    {
                        cb.BackColor = Color.Red;
                        b = false;
                    }
                }
            }
            return b;
        }
    }
}
