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
    public partial class FrmMenuInicio : Form
    {
        public FrmMenuInicio(String nick)
        {
            InitializeComponent();
            labelNom.Text += " "+nick;
        }

        private void buttonCli_Click(object sender, EventArgs e)
        {
            FrmMenuCliente formu=new FrmMenuCliente();
            formu.ShowDialog();
        }

        private void buttonAEmp_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonMPV_Click(object sender, EventArgs e)
        {
            FrmMenuVida formu = new FrmMenuVida();
            formu.ShowDialog();
        }

        private void buttonMPH_Click(object sender, EventArgs e)
        {
            FrmPolizaHogar formu=new FrmPolizaHogar();
            formu.ShowDialog();
        }

        private void buttonAPH_Click(object sender, EventArgs e)
        {
            FrmPolizaHogar formu = new FrmPolizaHogar();
            formu.ShowDialog();
        }

        private void buttonEmp_Click(object sender, EventArgs e)
        {
            buttonAEmp.Visible = true;
            buttonMenuEmp.Visible = true;
        }

        private void buttonPH_Click(object sender, EventArgs e)
        {
            buttonAPH.Visible = true;
            buttonMPH.Visible = true;
        }

        private void buttonPV_Click(object sender, EventArgs e)
        {
            buttonAPolV.Visible = true;
            buttonMPV.Visible = true;
        }

        private void FrmMenuInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAPolV_Click(object sender, EventArgs e)
        {
            FrmPolizaVida formu = new FrmPolizaVida();
            formu.ShowDialog();
        }
    }
}
