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
    public partial class FrmDetallesEmpleado : Form
    {
        Empleado empleado = null;
        public FrmDetallesEmpleado()
        {
            InitializeComponent();
        }
        public FrmDetallesEmpleado(Empleado e)
        {
            InitializeComponent();
            empleado = e;
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'databaseTFGDataSet1.Puestos' Puede moverla o quitarla según sea necesario.
            this.puestosTableAdapter.Fill(this.databaseTFGDataSet1.Puestos);
            // TODO: esta línea de código carga datos en la tabla 'databaseTFGDataSet1.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.databaseTFGDataSet1.Usuario);
            if (empleado != null)
            {
                cmbxUser.Text = empleado.Usuario.Nick;
                txtNombre.Text = empleado.Nombre;
                txtbxApellido1.Text = empleado.Apellido1;
                txtbxApellido2.Text = empleado.Apellido2;
                dtpFechaNac.Text = empleado.FechaNac.ToString();
                cmbxPuesto.Text = empleado.Puesto.ToString();
                nudSal.Value = Convert.ToDecimal(empleado.Salario);
                txtbxEmail.Text = empleado.Email;
                mtbTel.Text = empleado.Telefono.ToString();
                txtbxDir.Text = empleado.Direccion;
                msktxtbxDni.Text = empleado.Dni;
            }
            cmbxUser.DisplayMember = "nick";
        }

        private void tabPagePers_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControladorEmpleado.EliminarEmpleado(msktxtbxDni.Text);
        }
        private bool validarCampos()
        {
            bool validar = true;
            if (txtNombre.Text == "")
            {
                validar = false;
            }
            if (txtbxApellido1.Text == "")
            {
                validar = false;
            }
            if (txtbxApellido2.Text == "")
            {
                validar = false;
            }
            if (cmbxPuesto.SelectedIndex == -1)
            {
                validar = false;
            }
            if (txtbxEmail.Text == "")
            {
                validar = false;
            }
            if (mtbTel.Text == "")
            {
                validar = false;
            }
            if (txtbxDir.Text == "")
            {
                validar = false;
            }
            if (msktxtbxDni.Text == "")
            {
                validar = false;
            }
            if (cmbxUser.SelectedIndex == -1)
            {
                validar = false;
            }
            return validar;
        }

        private void buttonInserClien_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                MessageBox.Show("Faltan campos por rellenar");
                return;
            }
            Empleado em = new Empleado();
            em.Usuario = ControladorUsuario.obtenerUsuario(cmbxUser.Text);
            em.Nombre = txtNombre.Text;
            em.Apellido1 = txtbxApellido1.Text;
            em.Apellido2 = txtbxApellido2.Text;
            em.FechaNac = Convert.ToDateTime(dtpFechaNac.Text);
            em.FechaContr = DateTime.Now;
            em.Puesto = (Puesto)Enum.Parse(typeof(Puesto), cmbxPuesto.Text);
            em.Salario = Convert.ToDouble(nudSal.Value);
            em.Email = txtbxEmail.Text;
            em.Telefono = Convert.ToInt32(mtbTel.Text.ToString());
            em.Direccion = txtbxDir.Text;
            em.Dni = msktxtbxDni.Text;
            ControladorEmpleado.insertarEmpleado(em);
        }

        private void buttonModi_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                MessageBox.Show("Faltan campos por rellenar");
                return;
            }
            Empleado em = new Empleado();
            em.Usuario = ControladorUsuario.obtenerUsuario(cmbxUser.Text);
            em.Nombre = txtNombre.Text;
            em.Apellido1 = txtbxApellido1.Text;
            em.Apellido2 = txtbxApellido2.Text;
            em.FechaNac = Convert.ToDateTime(dtpFechaNac.Text);
            em.FechaContr = DateTime.Now;
            em.Puesto = (Puesto)Enum.Parse(typeof(Puesto), cmbxPuesto.Text);
            em.Salario = Convert.ToDouble(nudSal.Value);
            em.Email = txtbxEmail.Text;
            em.Telefono = Convert.ToInt32(mtbTel.Text);
            em.Direccion = txtbxDir.Text;
            em.Dni = msktxtbxDni.Text;
            List<string> atributos = new List<string>();
            atributos.Add("usuario_nick");
            atributos.Add("nombre");
            atributos.Add("apellido1");
            atributos.Add("apellido2");
            atributos.Add("fechaNac");
            atributos.Add("fechaContr");
            atributos.Add("puesto");
            atributos.Add("salario");                
            atributos.Add("email");
            atributos.Add("telefono");
            atributos.Add("direccion");
            List<string> datos = new List<string>();
            datos.Add(em.Usuario.Nick);
            datos.Add(em.Nombre);
            datos.Add(em.Apellido1);
            datos.Add(em.Apellido2);
            datos.Add(em.FechaNac.ToString());
            datos.Add(em.FechaContr.ToString());
            datos.Add(em.Puesto.ToString());
            datos.Add(em.Salario.ToString());
            datos.Add(em.Email);
            datos.Add(em.Telefono.ToString());
            datos.Add(em.Direccion);
            ControladorEmpleado.ModificarEmpleado(atributos,datos,em);
        }
    }
}
