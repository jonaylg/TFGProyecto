using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFGProyecto.Controlador;
using TFGProyecto.Modelo;

namespace TFGProyecto.Vista
{
    public partial class FrmConfirmarPrecio : Form
    {
        public FrmConfirmarPrecio()
        {
            InitializeComponent();
        }
        private double precio;
        private List<String> complementos1;
        private List<String> complementos2;
        private int codPoliza;
        private PolizaHogar ph;
        private PolizaVida pv;

        public FrmConfirmarPrecio(double precio, List<String> complementos1, List<String> complementos2, int codPoliza, PolizaHogar ph)
        {
            InitializeComponent();
            this.precio = precio;
            this.complementos1 = complementos1; 
            this.complementos2 = complementos2;
            this.codPoliza=codPoliza;
            this.ph= ph;
        }
        public FrmConfirmarPrecio(double precio, List<String> complementos1, List<String> complementos2, int codPoliza, PolizaVida pv)
        {
            InitializeComponent();
            this.precio = precio;
            this.complementos1 = complementos1;
            this.complementos2 = complementos2;
            this.codPoliza = codPoliza;
            this.pv = pv;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmConfirmarPrecio_Load(object sender, EventArgs e)
        {
            label1.Text = "El precio con los complementos seleccionados en la parte inferior sería de " +this.precio+ "€";

            labelComp1.Text = "Detalles seleccionados:";

            labelComp2.Text = "Coberturas seleccionadas:";

            foreach (String s in complementos1)
            {
                labelComp1.Text += "\n-" + s;
            }

            foreach (String s in complementos2)
            {
                labelComp2.Text += "\n-" + s;
            }

        }

        private void buttonAccpt_Click(object sender, EventArgs e)
        {
            Boolean resultado = true;
            try
            {
                string connectionString = ControladorBBDD.getCadenaConexión();
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    SqlCommand comando = cnn.CreateCommand();
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "UPDATE PolizaHogar SET aceptada='1' WHERE id = " + this.codPoliza + "";
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.UpdateCommand = comando;
                    if (adaptador.UpdateCommand.ExecuteNonQuery() == 0)
                    {
                        resultado = false;
                    }
                    else
                    {
                        MessageBox.Show("se modifico el registro");
                    }
                    adaptador.Dispose();
                    comando.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("si esta saltando este error prueba a volver a seleccionar el datos en el datagrid y presionar el boton de nuevo");
                MessageBox.Show(ex.ToString());
                Console.WriteLine("Error al actualizar " + ex.Message);
                resultado = false;
            }

            if (comboBox1.SelectedIndex!=-1)
            {
                if (resultado && comboBox1.SelectedItem.ToString() == "Existente")
                {
                    if (ControladorCliente.existeCliente(ph.Dni)!=0 && ControladorCliente.existeCliente(ph.Dni) != -1)
                    {
                        FrmMenuPrincipal formu = new FrmMenuPrincipal();
                        formu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("el dni proporcionado no coincide con ninguno de los guardados en la base de datos, seleccione nuevo o cambie el dni en el anterior formulario");
                    }
                }
                else if (resultado && comboBox1.SelectedItem.ToString() == "Nuevo")
                {
                    FrmDetallesCliente formu = new FrmDetallesCliente(ph.Dni);
                    formu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ha ocurrido un problema en la modificacion del registro");
                }
            }
            else
            {
                MessageBox.Show("selecciona el tipo de cliente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPolizaHogar formu= new FrmPolizaHogar(ph);
            formu.ShowDialog();
        }
    }
}
