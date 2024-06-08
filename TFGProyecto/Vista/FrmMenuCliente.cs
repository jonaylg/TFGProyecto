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
    public partial class FrmMenuCliente : Form
    {
        public FrmMenuCliente()
        {
            InitializeComponent();
        }

        private void buttonFilt_Click(object sender, EventArgs e)
        {
            rellenarDataGridXFiltro(tipoFiltrado(textBox1.Text));
        }

        private void FrmMenuCliente_Load(object sender, EventArgs e)
        {
            rellenarDataGrid();
        }

        private void rellenarDataGrid()
        {
            string connectionString = ControladorBBDD.getCadenaConexión(); // Reemplaza con tu cadena de conexión
                                                                           // En este caso, solo realiza un select del campo CódigoProyecto y nombreProyecto
                                                                           // Sería necesario adaptarlo si queremos todos los campos de un proyecto.
            string query = "SELECT DNI, Nombre, Apellido, Telefono, Ciudad, CorreoElectronico FROM Cliente";
            dataGridViewCLientes.Columns.Clear();
            dataGridViewCLientes.Columns.Add("DNI", "DNI");
            dataGridViewCLientes.Columns.Add("Nombre", "Nombre");
            dataGridViewCLientes.Columns.Add("Apellido", "Apellido");
            dataGridViewCLientes.Columns.Add("Telefono", "Telefono");
            dataGridViewCLientes.Columns.Add("Ciudad", "Ciudad");
            dataGridViewCLientes.Columns.Add("CorreoElectronico", "CorreoElectronico");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Agregar una nueva fila al DataGridView con el código y el nombre del proyecto
                                dataGridViewCLientes.Rows.Add(reader["DNI"].ToString(),
                                    reader["Nombre"].ToString(), reader["Apellido"].ToString(),
                                    reader["Telefono"].ToString(), reader["Ciudad"].ToString(), reader["CorreoElectronico"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos: {ex.Message}\n{ex.StackTrace}");
                }
            }
        }

        private String tipoFiltrado(String filtro)
        {
            string query = "";
            foreach (Control c in groupBoxRB.Controls)
            {
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    if (rb.Checked)
                    {
                        switch (rb.Text)
                        {
                            case "Dni":
                                query = $"SELECT DNI, Nombre, Apellido, Telefono, Ciudad, CorreoElectronico FROM Cliente where DNI='{filtro}'";
                                break;
                            case "Nombre":
                                query = $"SELECT DNI, Nombre, Apellido, Telefono, Ciudad, CorreoElectronico FROM Cliente where Nombre='{filtro}'";
                                break;
                            case "Ciudad":
                                query = $"SELECT DNI, Nombre, Apellido, Telefono, Ciudad, CorreoElectronico FROM Cliente where Ciudad='{filtro}'";
                                break;
                            case "Telefono":
                                query = $"SELECT DNI, Nombre, Apellido, Telefono, Ciudad, CorreoElectronico FROM Cliente where Telefono='{filtro}'";
                                break;
                        }
                    }
                }
            }
            return query;
        }

        private void rellenarDataGridXFiltro(String peticion)
        {
            if (peticion != "")
            {
                string connectionString = ControladorBBDD.getCadenaConexión(); // Reemplaza con tu cadena de conexión
                                                                               // En este caso, solo realiza un select del campo CódigoProyecto y nombreProyecto
                                                                               // Sería necesario adaptarlo si queremos todos los campos de un proyecto.
                string query = peticion;
                dataGridViewCLientes.Columns.Clear();
                dataGridViewCLientes.Columns.Add("DNI", "DNI");
                dataGridViewCLientes.Columns.Add("Nombre", "Nombre");
                dataGridViewCLientes.Columns.Add("Apellido", "Apellido");
                dataGridViewCLientes.Columns.Add("Telefono", "Telefono");
                dataGridViewCLientes.Columns.Add("Ciudad", "Ciudad");
                dataGridViewCLientes.Columns.Add("CorreoElectronico", "CorreoElectronico");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    // Agregar una nueva fila al DataGridView con el código y el nombre del proyecto
                                    dataGridViewCLientes.Rows.Add(reader["DNI"].ToString(),
                                        reader["Nombre"].ToString(), reader["Apellido"].ToString(),
                                        reader["Telefono"].ToString(), reader["Ciudad"].ToString(), reader["CorreoElectronico"].ToString());
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar datos: {ex.Message}\n{ex.StackTrace}");
                    }
                }
            }
            else
            {
                MessageBox.Show("se ha producido un error");
            }
        }

        private void dataGridViewPolizas_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (comboBoxTipo.SelectedIndex!=-1)
            {
                if (comboBoxTipo.SelectedItem == "Modificar")
                {
                    FrmDetallesCliente formu = new FrmDetallesCliente(ControladorCliente.obtenerCliente(dataGridViewCLientes.CurrentRow.Cells[0].Value.ToString()));
                    formu.ShowDialog();
                }
                else
                {
                    FrmMenuPrincipal formu = new FrmMenuPrincipal(dataGridViewCLientes.CurrentRow.Cells[0].Value.ToString());
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
            MessageBox.Show("para dar de alta un cliente tienes que crear una poliza");
        }

        private void menuToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmMenuCliente formu=new FrmMenuCliente();
            formu.ShowDialog();
        }

        private void buttonAct_Click(object sender, EventArgs e)
        {
            rellenarDataGrid();
        }

        private void groupBoxRB_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            e.Graphics.Clear(Color.LightSkyBlue); // Cambia este color según tu diseño
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, box.Width - 1, box.Height - 1);
            e.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 10, 1);
        }
    }
}
