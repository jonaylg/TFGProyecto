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
using TFGProyecto.DatabaseTFGDataSet1TableAdapters;

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

        private List<String> complementos1 = new List<String>();
        private List<String> complementos2 = new List<String>();

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
                double imc = calcularIMC((int)nudAlt.Value, (int)nudPeso.Value);
                if (cmbxSexo.SelectedItem == "H")
                {
                    if (nudAlt.Value<140 || nudAlt.Value>220)
                    {
                        ok = false;
                    } else if (imc>35 || imc<18.5)
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
                    else if (imc > 35 || imc < 18.5)
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
            if (msktxtbxDNI.Text.Length != 9)
            {
                ok = false;
                MessageBox.Show("DNI incorrecto");
            }
            if (ok)
            {
                complementos1.Add("Sexo: " + cmbxSexo.SelectedItem.ToString());
                complementos1.Add("Altura: " + nudAlt.Value.ToString());
                complementos1.Add("Peso: " + nudPeso.Value.ToString());
                complementos1.Add("Ocupación: " + cmbxOcu.SelectedValue.ToString());
                complementos1.Add("Dieta: " + grpbxDieta.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
                complementos1.Add("Actividad: " + grbbxAct.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
                complementos1.Add("Alcohol: " + chkbxAlcohol.Checked.ToString());
                complementos1.Add("Tabaco: " + chkbxTabaco.Checked.ToString());
                complementos1.Add("Drogas: " + chkbxDrogas.Checked.ToString());
                complementos1.Add("Cáncer: " + chkbxCan.Checked.ToString());
                complementos1.Add("Diabetes: " + chkbxDia.Checked.ToString());
                complementos1.Add("Endocrinas: " + chkbxEndo.Checked.ToString());
                complementos1.Add("Gastrointestinales: " + chkbxGastro.Checked.ToString());
                complementos1.Add("Hematológicas: " + chkbxHema.Checked.ToString());
                complementos1.Add("Infecciosas: " + chkbxInfec.Checked.ToString());
                complementos1.Add("Neurológicas: " + chkbxNeu.Checked.ToString());
                complementos1.Add("Renales: " + chkbxRen.Checked.ToString());
                complementos1.Add("Respiratorias: " + chkbxResp.Checked.ToString());
                complementos1.Add("Cardíacas: " + chkbxCard.Checked.ToString());
                complementos1.Add("Hepáticas: " + chkbxHepa.Checked.ToString());
                complementos1.Add("Autoinmunes: " + chkbxAuto.Checked.ToString());
                complementos2.Add("Capital asegurado: " + nudCap.Value.ToString());
                complementos2.Add("Terminación anticipada: " + chkbxTerm.Checked.ToString());
                complementos2.Add("Incapacidad temporal: " + chkbxITP.Checked.ToString());
                complementos2.Add("Accidentes: " + chkbxAcc.Checked.ToString());
            }
            return ok;
        }
        public double calcularIMC(int altura, int peso)
        {
            return ((double)peso)/Math.Pow((double)altura/100,2);
        }
        public bool trabajoPeligroso()
        {
            bool peligroso = false;
            string query = "SELECT Peligroso FROM Trabajo WHERE Id = " + cmbxOcu.SelectedValue.ToString();
            using (SqlDataReader reader = ControladorBBDD.getRegistros(query))
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader[0].ToString() == "1")
                    {
                        peligroso = true;
                    }
                }
                return peligroso;
            }
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
            double capital = (double)nudCap.Value;

            if (capital > 100000 && capital <= 200000)
            {
                coeficienteCapital = 1.1;
            }
            else if (capital > 200000 && capital <= 500000)
            {
                coeficienteCapital = 1.2;
            }
            else if (capital > 500000 && capital <= 1000000)
            {
                coeficienteCapital = 1.3;
            }
            else if (capital > 1000000 && capital <= 2000000)
            {
                coeficienteCapital = 1.4;
            }
            else if (capital > 2000000 && capital <= 3000000)
            {
                coeficienteCapital = 1.5;
            }
            return coeficienteCapital;
        }


        private void buttonPrecio_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            }
            double coeficienteEdad = calcularCoeficienteEdad();
            double coeficienteSexo = calcularCoeficienteSexo();
            double coeficienteSalud = calcularCoeficienteSalud();
            double coeficienteCoberturas = calcularCoeficienteCoberturas();
            double coeficienteCapital = calcularCoeficienteCapital();
            
            double precioBaseMensual = 50;
            double precioMensualTotal = precioBaseMensual * coeficienteEdad * coeficienteSexo * coeficienteSalud * coeficienteCoberturas * coeficienteCapital;
            MessageBox.Show("El precio mensual de la póliza es de " + precioMensualTotal + "€");
            PolizaVida pv = construirPolizaVida(precioMensualTotal);
            if (ControladorPolizaVida.insertarPolVida(pv)) {
                FrmConfirmarPrecio frmConfirmarPrecio = new FrmConfirmarPrecio(precioMensualTotal, complementos1, complementos2, ControladorPolizaVida.obtenerUltCod(), pv);
                frmConfirmarPrecio.Show();
            }
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
        public PolizaVida construirPolizaVida(double precio)
        {
            PolizaVida pv = new PolizaVida();
            pv.Dni = msktxtbxDNI.Text;
            pv.Edad = (int)nudEdad.Value;
            pv.Altura = (int)nudAlt.Value;
            pv.Peso = (int)nudPeso.Value;
            pv.Sexo = cmbxSexo.SelectedItem.ToString();
            pv.Ocupacion = (int)cmbxOcu.SelectedValue;
            pv.ConsumeAlcohol = chkbxAlcohol.Checked;
            pv.ConsumeTabaco = chkbxTabaco.Checked;
            pv.ConsumeDrogas = chkbxDrogas.Checked;
            pv.TieneTerminacionAnticipada = chkbxTerm.Checked;
            pv.TieneIncapacidadTemporal = chkbxITP.Checked;
            pv.TieneAccidentes = chkbxAcc.Checked;
            pv.CapitalAsegurado = (int)nudCap.Value;
            pv.Dieta = ControladorPolizaVida.obtenerDieta(
                grpbxDieta.Controls.OfType<RadioButton>().FirstOrDefault(
                    r => r.Checked).Text);
            pv.Actividad = ControladorPolizaVida.obtenerActividad(
                grbbxAct.Controls.OfType<RadioButton>().FirstOrDefault(
                    r => r.Checked).Text);
            pv.Cancer = chkbxCan.Checked;
            pv.Diabetes = chkbxDia.Checked;
            pv.Endocrinas = chkbxEndo.Checked;
            pv.Gastrointestinales = chkbxGastro.Checked;
            pv.Hematologicas = chkbxHema.Checked;
            pv.Infecciosas = chkbxInfec.Checked;
            pv.Neurologicas = chkbxNeu.Checked;
            pv.Renales = chkbxRen.Checked;
            pv.Respiratorias = chkbxResp.Checked;
            pv.Cardiacas = chkbxCard.Checked;
            pv.Hépaticas = chkbxHepa.Checked;
            pv.Autoinmunes = chkbxAuto.Checked;
            pv.Precio = precio;
            return pv;
        }

        private void cmbxSexo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbxSexo.SelectedItem.ToString() == "H")
            {
                nudAlt.Minimum = 140;
                nudAlt.Maximum = 220;
                nudAlt.Value = 140;
                nudPeso.Minimum = 50;
                nudPeso.Maximum = 150;
                nudPeso.Value = 50;
            }
            else
            {
                nudAlt.Minimum = 130;
                nudAlt.Maximum = 200;
                nudAlt.Value = 130;
                nudPeso.Minimum = 40;
                nudPeso.Maximum = 120;
                nudPeso.Value = 40;
            }
        }
    }
}
