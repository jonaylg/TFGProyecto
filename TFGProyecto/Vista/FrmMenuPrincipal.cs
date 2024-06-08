using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFGProyecto.Controlador;

namespace TFGProyecto.Vista
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            rellenarDataGrid();
        }

        public FrmMenuPrincipal(String dni)
        {
            InitializeComponent();
            textBox1.Text = dni;
            radioButtonDni.Checked = true;
            rellenarDataGridXFiltro(tipoFiltrado(dni));
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al menu de poliza hogar");
        }

        private String tipoFiltrado(String filtro)
        {
            String operando="";
            if (comboBoxMayMenIgu.SelectedIndex!=-1) {
                switch (comboBoxMayMenIgu.SelectedItem.ToString().ToLower())
                {
                    case "mayor":
                        operando = ">";
                        break;
                    case "menor":
                        operando = "<";
                        break;
                    case "igual":
                        operando = "=";
                        break;

                }
            }
            string query = "";
            foreach (Control c in groupBoxRB.Controls) {
                if (c is RadioButton) {
                    RadioButton rb = (RadioButton)c;
                    if (rb.Checked)
                    {
                        switch (rb.Text)
                        {
                            case "Tipo Vivienda":
                                query = $"SELECT id, dni, tipoVivienda, zonaVivienda, valorVivienda, precio FROM PolizaHogar where tipoVivienda='{filtro}'";
                                break;
                            case "Zona Vivienda":
                                query = $"SELECT id, dni, tipoVivienda, zonaVivienda, valorVivienda, precio FROM PolizaHogar where zonaVivienda='{filtro}'";
                                break;
                            case "Valor Vivienda":
                                if (operando=="<"|| operando == ">" || operando == "=")
                                {
                                    query = $"SELECT id, dni, tipoVivienda, zonaVivienda, valorVivienda, precio FROM PolizaHogar where valorVivienda{operando}{filtro}";
                                }
                                else
                                {
                                    MessageBox.Show("debes seleccionar el tipo de operando"+operando);
                                    query = "error";
                                }
                                break;
                            case "Año Construido":
                                if (operando == "<" || operando == ">" || operando == "=")
                                {
                                    query = $"SELECT id, dni, tipoVivienda, zonaVivienda, valorVivienda, precio FROM PolizaHogar where anhoConstruccion{operando}{filtro}";
                                }
                                else
                                {
                                    MessageBox.Show("debes seleccionar el tipo de operando");
                                    query = "error";
                                }
                                break;
                            case "Dni":
                                query = $"SELECT id, dni, tipoVivienda, zonaVivienda, valorVivienda, precio FROM PolizaHogar where dni='{filtro}'";
                                break;
                            case "Usuario":
                                query = $"SELECT id, dni, tipoVivienda, zonaVivienda, valorVivienda, precio FROM PolizaHogar where usuario='{filtro}'";
                                break;
                        }
                    }
                }
            }
            return query;
        }

        private void rellenarDataGrid()
        {
            string connectionString = ControladorBBDD.getCadenaConexión(); // Reemplaza con tu cadena de conexión
                                                       // En este caso, solo realiza un select del campo CódigoProyecto y nombreProyecto
                                                       // Sería necesario adaptarlo si queremos todos los campos de un proyecto.
            string query = "SELECT id, dni, tipoVivienda, zonaVivienda, valorVivienda, precio FROM PolizaHogar";
            dataGridViewPolizas.Columns.Clear();
            dataGridViewPolizas.Columns.Add("id", "id");
            dataGridViewPolizas.Columns.Add("dni", "dni");
            dataGridViewPolizas.Columns.Add("tipoVivienda", "tipoVivienda");
            dataGridViewPolizas.Columns.Add("zonaVivienda", "zonaVivienda");
            dataGridViewPolizas.Columns.Add("valorVivienda", "valorVivienda");
            dataGridViewPolizas.Columns.Add("precio", "precio");
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
                                dataGridViewPolizas.Rows.Add(reader["id"].ToString(),
                                    reader["dni"].ToString(), reader["tipoVivienda"].ToString(),
                                    reader["zonaVivienda"].ToString(), reader["valorVivienda"].ToString(), reader["precio"].ToString());
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

        private void rellenarDataGridXFiltro(String peticion)
        {
            if (peticion!="error")
            {
                string connectionString = ControladorBBDD.getCadenaConexión(); // Reemplaza con tu cadena de conexión
                                                                               // En este caso, solo realiza un select del campo CódigoProyecto y nombreProyecto
                                                                               // Sería necesario adaptarlo si queremos todos los campos de un proyecto.
                string query = peticion;
                dataGridViewPolizas.Columns.Clear();
                dataGridViewPolizas.Columns.Add("id", "id");
                dataGridViewPolizas.Columns.Add("dni", "dni");
                dataGridViewPolizas.Columns.Add("tipoVivienda", "tipoVivienda");
                dataGridViewPolizas.Columns.Add("zonaVivienda", "zonaVivienda");
                dataGridViewPolizas.Columns.Add("valorVivienda", "valorVivienda");
                dataGridViewPolizas.Columns.Add("precio", "precio");
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
                                    dataGridViewPolizas.Rows.Add(reader["id"].ToString(),
                                        reader["dni"].ToString(), reader["tipoVivienda"].ToString(),
                                        reader["zonaVivienda"].ToString(), reader["valorVivienda"].ToString(), reader["precio"].ToString());
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
            FrmPolizaHogar formu=new FrmPolizaHogar(ControladorPolHog.obtenerPolizaHogar(Int32.Parse(dataGridViewPolizas.CurrentRow.Cells[0].Value.ToString())), Int32.Parse(dataGridViewPolizas.CurrentRow.Cells[0].Value.ToString()));
            formu.ShowDialog();
        }

        private void buttonFilt_Click(object sender, EventArgs e)
        {
            rellenarDataGridXFiltro(tipoFiltrado(textBox1.Text));
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible=false;
            buttonMenu.Visible=false;
            menuStrip1.Visible=true;
        }

        private void polizaVidaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("para crear un cliente tienes que crear una poliza");
        }

        private void menuToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmMenuCliente formu= new FrmMenuCliente();
            formu.ShowDialog();
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmPolizaHogar formu=new FrmPolizaHogar();
            formu.ShowDialog();
        }

        private void menuToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ya estas en la ventana seleccionada");
        }

        private void buttonAct_Click(object sender, EventArgs e)
        {
            rellenarDataGrid();
        }

        private void FrmMenuPrincipal_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void groupBoxRB_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = (GroupBox)sender;
            e.Graphics.Clear(Color.LightSkyBlue); // Cambia este color según tu diseño
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, box.Width - 1, box.Height - 1);
            e.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 10, 1);
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetallesEmpleado formu=new FrmDetallesEmpleado();
            formu.ShowDialog();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenuEmpleado formu=new FrmMenuEmpleado();
            formu.ShowDialog();
        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMenuVida formu=new FrmMenuVida();
            formu.ShowDialog();
        }
    }
}
