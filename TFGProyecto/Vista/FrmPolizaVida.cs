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
using System.Data.SqlClient;
using TFGProyecto.Modelo;

namespace TFGProyecto.Vista
{
    public partial class FrmPolizaVida : Form
    {
        PolizaVida polizaVida = null;
        int idPoliza;
        public FrmPolizaVida()
        {
            InitializeComponent();
        }
        public FrmPolizaVida(PolizaVida pv, int idPoliza)
        {
            InitializeComponent();
            cargarDatos(pv);
            polizaVida = pv;
            this.idPoliza = idPoliza;
        }
        public bool validarCampos()
        {
            bool ok = true;
            if (cmbxSexo.SelectedIndex == -1)
            {
                ok = false;
                MessageBox.Show("Sexo no seleccionado");
            }
            else
            {
                if (cmbxSexo.SelectedItem == "H")
                {
                    if (nudAlt.Value<140 || nudAlt.Value>220)
                    {
                        ok = false;
                    } else if (calcularIMC((int)nudAlt.Value, (int)nudPeso.Value)>35 
                        || calcularIMC((int)nudAlt.Value, (int)nudPeso.Value)<18.5)
                    {
                        ok = false;
                        MessageBox.Show("IMC fuera de rango");
                    }
                } else
                {
                    if (nudAlt.Value < 130 || nudAlt.Value > 200)
                    {
                        ok = false;
                    }
                    else if (calcularIMC((int)nudAlt.Value, (int)nudPeso.Value) > 35
                        || calcularIMC((int)nudAlt.Value, (int)nudPeso.Value) < 18.5)
                    {
                        ok = false;
                        MessageBox.Show("IMC fuera de rango");
                    }
                }
            }
            if (cmbxOcu.SelectedIndex == -1)
            {
                ok = false;
                MessageBox.Show("Ocupación no seleccionada");
            }
            if (trabajoPeligroso())
            {
                ok = false;
                MessageBox.Show("Trabajo peligroso");
            }
            if (validarHistorial())
            {
                ok = false;
                MessageBox.Show("Historial grave");
            }
            if (validarDieta())
            {
                ok = false;
                MessageBox.Show("Dieta no seleccionada");
            }
            if (validarActividad())
            {
                ok = false;
                MessageBox.Show("Actividad no seleccionada");
            }
            return ok;
        }
        public double calcularIMC(int altura, int peso)
        {
            return peso/Math.Pow(altura/100,2);
        }
        public bool trabajoPeligroso()
        {
            bool peligroso = false;
            string query = "SELECT * FROM Trabajo WHERE ID = " + cmbxOcu.SelectedValue;
            SqlDataReader reader = Controlador.ControladorBBDD.getRegistros(query);
            if (reader.HasRows)
            {
                if (reader["Peligroso"].ToString() == "1")
                {
                    peligroso = true;
                }
            }
            return peligroso;
        }
        public bool validarDieta()
        {
            bool ok = true;
            foreach (Control control in grpbxDieta.Controls)
            {
                if (control is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        return false;
                    }
                }
            }
            return ok;
        }
        public bool validarActividad()
        {
            bool ok = true;
            foreach (Control control in grbbxAct.Controls)
            {
                if (control is RadioButton rb)
                {
                    if (rb.Checked)
                    {
                        return false;
                    }
                }
            }
            return ok;
        }
        public bool validarHistorial()
        {
            bool validar = false;
            int checks = 0;
            foreach (Control control in tbpgSalud.Controls)
            {
                if (control is CheckBox cb)
                {
                    if (cb.Checked)
                    { 
                        checks++; 
                    }
                    if (checks == 4)
                    {
                        validar = true;
                        break;
                    }
                }
            }
            return validar;
        }
        private void FrmPolizaVida_Load(object sender, EventArgs e)
        {
            this.trabajoTableAdapter.Fill(this.databaseTFGDataSet1.Trabajo);
        }

        private void chkbxCap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxCap.Checked)
            {
                nudCap.Enabled = true;
            }
            else
            {
                nudCap.Enabled = false;
            }
        }
        private double calcularCoeficienteEdad()
        {
            double coeficienteEdad = 1.0;
            if (nudEdad.Value >= 18 && nudEdad.Value <= 30)
            {
                coeficienteEdad = 0.8;
            }
            else if (nudEdad.Value > 30 && nudEdad.Value <= 50)
            {
                coeficienteEdad = 1.0;
            }
            else if (nudEdad.Value > 50 && nudEdad.Value <= 70)
            {
                coeficienteEdad = 1.2;
            }
            return coeficienteEdad;
        }
        private double calcularCoeficienteSexo()
        {
            double coeficienteSexo = 1.0;
            if (cmbxSexo.SelectedItem.ToString() == "M")
            {
                coeficienteSexo = 0.9;
            }
            return coeficienteSexo;
        }
        private double calcularCoeficienteSalud()
        {
            double coeficienteSalud = 1.0;
            if (chkbxAlcohol.Checked || chkbxTabaco.Checked || chkbxDrogas.Checked)
            {
                coeficienteSalud += 0.5;
            }
            double imc = calcularIMC((int)nudAlt.Value, (int)nudPeso.Value);
            if (imc <25)
            {
                coeficienteSalud += 0.5;
            }
            foreach (Control control in tbpgSalud.Controls)
            {
                if (control is CheckBox cb)
                {
                    if (cb.Checked)
                    {
                        coeficienteSalud += 0.3;
                    }                    
                }
            }
            if (rdbttnHipo.Checked)
            {
                coeficienteSalud += 0.2;
            }
            else if (rdbttnHiper.Checked)
            {
                coeficienteSalud += 0.3;
            }
            if (rdbttnBaja.Checked)
            {
                coeficienteSalud += 0.3;
            }
            else if (rdbttnAlta.Checked)
            {
                coeficienteSalud += 0.2;
            }
            return coeficienteSalud;
        }
        private double calcularCoeficienteCoberturas()
        {
            double coeficienteCoberturas = 1.0;
            if (chkbxTerm.Checked)
            {
                coeficienteCoberturas += 0.2;
            }
            if (chkbxITP.Checked)
            {
                coeficienteCoberturas += 0.3;
            }
            if (chkbxAcc.Checked)
            {
                coeficienteCoberturas += 0.4;
            }
            return coeficienteCoberturas;
        }
        private double calcularCoeficienteCapital()
        {
            double coeficienteCapital = 1.0;
            if (nudCap.Value > 100000)
            {
                coeficienteCapital = 1.2;
            }
            return coeficienteCapital;
        }

        private void buttonPrecio_Click(object sender, EventArgs e)
        {
            double coeficienteEdad = calcularCoeficienteEdad();
            double coeficienteSexo = calcularCoeficienteSexo();
            double coeficienteSalud = calcularCoeficienteSalud();
            double coeficienteCoberturas = calcularCoeficienteCoberturas();
            double coeficienteCapital = calcularCoeficienteCapital();
            
            double precioBaseMensual = 50;
            double precioMensualTotal = precioBaseMensual * coeficienteEdad * coeficienteSexo * coeficienteSalud * coeficienteCoberturas * coeficienteCapital;
            MessageBox.Show("El precio mensual de la póliza es de " + precioMensualTotal + "€");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (polizaVida != null)
            {
                ControladorPolizaVida.eliminarPolizaVida(idPoliza);
            }
        }
        private void cargarDatos(PolizaVida pv)
        {
            nudEdad.Value = pv.Edad;
            nudAlt.Value = (decimal)pv.Altura;
            nudPeso.Value = (decimal)pv.Peso;
            cmbxSexo.SelectedItem = pv.Sexo;
            cmbxOcu.SelectedValue = pv.Ocupacion;
            chkbxAlcohol.Checked = pv.ConsumeAlcohol;
            chkbxTabaco.Checked = pv.ConsumeTabaco;
            chkbxDrogas.Checked = pv.ConsumeDrogas;
            chkbxTerm.Checked = pv.TieneTerminacionAnticipada;
            chkbxITP.Checked = pv.TieneIncapacidadTemporal;
            chkbxAcc.Checked = pv.TieneAccidentes;
            nudCap.Value = (decimal)pv.CapitalAsegurado;
            if (pv.Dieta.ToString() == "hipercalorica")
            {
                rdbttnHiper.Checked = true;
            }
            else if (pv.Dieta.ToString() == "hipocalorica")
            {
                rdbttnHipo.Checked = true;
            } else
            {
                rdbttnEqui.Checked = true;
            }
            if (pv.Actividad.ToString() == "sedentaria")
            {
                rdbttnBaja.Checked = true;
            }
            else if (pv.Actividad.ToString() == "moderada")
            {
                rdbttnMed.Checked = true;
            }
            else
            {
                rdbttnAlta.Checked = true;
            }
            chkbxCan.Checked = pv.Cancer;
            chkbxDia.Checked = pv.Diabetes;
            chkbxEndo.Checked = pv.Endocrinas;
            chkbxGastro.Checked = pv.Gastrointestinales;
            chkbxHema.Checked = pv.Hematologicas;
            chkbxInfec.Checked = pv.Infecciosas;
            chkbxNeu.Checked = pv.Neurologicas;
            chkbxRen.Checked = pv.Renales;
            chkbxResp.Checked = pv.Respiratorias;
            chkbxCard.Checked = pv.Cardiacas;
            chkbxHepa.Checked = pv.Hépaticas;
            chkbxAuto.Checked = pv.Autoinmunes;
        }
    }
}
