using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public FrmConfirmarPrecio(double precio, List<String> complementos1, List<String> complementos2)
        {
            InitializeComponent();
            this.precio = precio;
            this.complementos1 = complementos1; 
            this.complementos2 = complementos2;
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

        
    }
}
