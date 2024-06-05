using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFGProyecto.Controlador;
using TFGProyecto.Modelo;

namespace TFGProyecto.Vista
{
    public partial class FrmPolizaHogar : Form
    {
        public FrmPolizaHogar()
        {
            InitializeComponent();
        }

        public FrmPolizaHogar(PolizaHogar ph)
        {
            InitializeComponent();
            obtenerDatosPoliza(ph);
        }

        private List<String> complementos1= new List<String>();
        private List<String> complementos2 = new List<String>();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
        private double calcularPrecioDetalles()
        {
            double precio=0;
            switch (comboBoxTipo.SelectedItem.ToString())//revisarSystem.NullReferenceException: 'Referencia a objeto no establecida como instancia de un objeto.'
            {
                case "Piso":
                    precio += 25;
                    break;
                case "Chalet":
                    precio += 50;
                    break;
                case "Adosado":
                    precio += 35;
                    break;
            }

            complementos1.Add("Tipo Vivienda:"+ comboBoxTipo.SelectedItem.ToString());

            switch (comboBoxZona.SelectedItem.ToString())
            {
                case "Urbana":
                    if (comboBoxTipo.SelectedItem.ToString()== "Piso")
                    {
                        precio *= 2;
                    }else if (comboBoxTipo.SelectedItem.ToString()== "Adosado")
                    {
                        precio *=1.25;
                    }
                    else
                    {
                        precio *= 1.25;
                    }
                    break;
                case "Rural":
                    if (comboBoxTipo.SelectedItem.ToString() == "Piso")
                    {
                        precio *= 1.5;
                    }
                    else if (comboBoxTipo.SelectedItem.ToString() == "Adosado")
                    {
                        precio *= 1.5;
                    }
                    else
                    {
                        precio *= 2;
                    }
                    break;
                case "Costera":
                    if (comboBoxTipo.SelectedItem.ToString() == "Piso")
                    {
                        precio *= 1.25;
                    }
                    else if (comboBoxTipo.SelectedItem.ToString() == "Adosado")
                    {
                        precio *= 1.5;
                    }
                    else
                    {
                        precio *= 2;
                    }
                    break;
            }

            complementos1.Add("Zona Vivienda:" + comboBoxZona.SelectedItem.ToString());

            if (numericUpDownAnho.Value<1950)
            {
                precio *= 2;
            }else if (numericUpDownAnho.Value>=1950 && numericUpDownAnho.Value <1980)
            {
                precio *= 1.75;
            }else if (numericUpDownAnho.Value >= 1980 && numericUpDownAnho.Value < 2000)
            {
                precio *= 1.5;
            }

            complementos1.Add(labelAnhoCon.Text +": "+numericUpDownAnho.Value.ToString());

            precio += ((double)numericUpDownCons.Value * 0.5);
            complementos1.Add(labelm2Cons.Text + ": " + numericUpDownCons.Value.ToString());

            precio += ((double)numericUpDownTot.Value * 0.4);
            complementos1.Add(labelm2Tot.Text + ": " + numericUpDownTot.Value.ToString());

            precio += Double.Parse(maskedTextBoxValor.Text) / 10000;
            complementos1.Add(labelValorV.Text + ": " + maskedTextBoxValor.Text);

            precio += Double.Parse(maskedTextBoxContenido.Text) / 1000;
            complementos1.Add("Valor del Contenido: " + maskedTextBoxContenido.Text);

            precio += ((double)numericUpDownHab.Value*2.5);
            complementos1.Add(labelNHab.Text + ": " + numericUpDownHab.Value.ToString());

            foreach (var item in checkedListBox1.Items)
            {
                if (checkedListBox1.CheckedItems.Contains(item))
                {
                    complementos1.Add(item.ToString());
                    precio += 20;
                }
            }


            return precio;
        }

        private double calcularPrecioMasDetalles()
        {
            Double precio=0;

            foreach (Control item in groupBoxSS.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;
                    if (cb.Text== "Personal de Seguridad")
                    {
                        precio -= 30;
                    }
                    else if (cb.Text == "Camaras")
                    {
                        precio -= 20;
                    }
                    else if (cb.Text == "Caja Fuerte")
                    {
                        precio -= 15;
                    }
                    else if (cb.Text == "Alarma")
                    {
                        precio -= 20;
                    }
                    else {
                        precio -= 15;
                    }
                }
            }

            if (comboBoxTipMat.SelectedItem.ToString()=="Otros")
            {
                precio += 25;
            }
            complementos1.Add(labelTipoMa.Text + ": " + comboBoxTipMat.SelectedItem.ToString());

            switch (comboBoxUsoVivi.SelectedItem.ToString())
            {
                case "Total":
                    precio += 25;
                    break;
                case "Vacacional":
                    precio += 20;
                    break;
                case "Alquiler Vacacional":
                    precio += 25;
                    break;
                case "Alquiler":
                    precio += 50;
                    break;
            }
            complementos1.Add(labelUsoViv.Text + ": " + comboBoxUsoVivi.SelectedItem.ToString());
            return precio;
        }

        private double calcularPrecioCoberturas()
        {
            double precio=0;

            Dictionary<CheckBox, Double> coberturas = new Dictionary<CheckBox, Double>();
            coberturas.Add(checkBoxFuego, 20);
            coberturas.Add(checkBoxFenAtm, 20);
            coberturas.Add(checkBoxRotoCris, 10);
            coberturas.Add(checkBoxAguaYElec, 15);
            coberturas.Add(checkBoxDefJur, 20);
            coberturas.Add(checkBoxInhDelInm, 15);
            coberturas.Add(checkBoxDerrAcc, 15);
            coberturas.Add(checkBoxRobEnCas, 20);
            coberturas.Add(checkBoxRotTub, 15);
            coberturas.Add(checkBox11ReposDDEE, 15);

            foreach (Control item in groupBoxCob.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox cb=(CheckBox)item;

                    foreach (KeyValuePair<CheckBox, Double> cobertura in coberturas)
                    {
                        if (cb.Text == cobertura.Key.Text && cb.Checked)
                        {
                            precio += cobertura.Value;
                            complementos2.Add(item.Text);
                        }
                    }

                }
            }


            return precio;
        }

        private double calcularPrecioCoberturasAmp()
        {
            double precio = 0;

            Dictionary<CheckBox, Double> coberturas = new Dictionary<CheckBox, Double>();
            coberturas.Add(checkBoxVehEnGar, 25);
            coberturas.Add(checkBoxRep24h, 20);
            coberturas.Add(checkBoxJuriAmp, 20);
            coberturas.Add(checkBoxAsisEnViaj, 20);
            coberturas.Add(checkBoxProm, 5);
            coberturas.Add(checkBoxVandalicos, 15);
            coberturas.Add(checkBoxAsisInf, 15);

            foreach (Control item in tabPageCA.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;

                    foreach (KeyValuePair<CheckBox, Double> cobertura in coberturas)
                    {
                        if (cb.Text == cobertura.Key.Text && cb.Checked)
                        {
                            precio += cobertura.Value;
                            complementos2.Add(item.Text);
                        }
                    }

                }
            }


            return precio;
        }

        private void buttonPrecio_Click(object sender, EventArgs e)
        {
            if (infoCorrecta())
            {
                ControladorPolHog.insertarPolHog(construirPoliza());
                MessageBox.Show(construirPoliza().MostrarDatos());
                MessageBox.Show("este es el precio de la poliza " + construirPoliza().Precio);
                FrmConfirmarPrecio formu = new FrmConfirmarPrecio(construirPoliza().Precio, complementos1, complementos2);
                formu.ShowDialog();
            }
            else
            {
                MessageBox.Show("revise los controles en rojo y rellenelos correctamente");
            }
        }

        private Boolean infoCorrecta()
        {
            Boolean b = true;

            foreach (Control item in tabPageDH.Controls)
            {
                if (item is ComboBox) {
                    ComboBox cb = (ComboBox)item;
                    if (cb.SelectedIndex == -1)
                    {
                        cb.BackColor = Color.Red;
                        b=false;
                    }
                    else
                    {
                        cb.BackColor= Color.Green;
                    }
                }
                else if (item is MaskedTextBox)
                {
                    MaskedTextBox mtb = (MaskedTextBox)item;
                    if (mtb.Text=="")
                    {
                        mtb.BackColor = Color.Red;
                        b = false;
                    }
                    else
                    {
                        mtb.BackColor = Color.Green;
                    }
                }
            }

            foreach (Control item in tabPageMD.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox cb = (ComboBox)item;
                    if (cb.SelectedIndex == -1)
                    {
                        cb.BackColor = Color.Red;
                        b = false;
                    }
                    else
                    {
                        cb.BackColor = Color.Green;
                    }
                }
            }

            if (maskedTextBox1.Text=="" || maskedTextBox1.Text.Length!=9) { 
                maskedTextBox1.BackColor = Color.Red;
                b = false;
                MessageBox.Show("el dni esta vacio o no tiene el numero de caracteres correctos");
            }

            if (dateTimePickerFC.Value<DateTime.Now || dateTimePickerFC.Value>dateTimePickerFE.Value)
            {
                dateTimePickerFC.BackColor = Color.Red;
                dateTimePickerFE.BackColor = Color.Red;
                b = false;
                MessageBox.Show(dateTimePickerFC.Value+ DateTime.Now.ToString()+ dateTimePickerFE.Value + "la fecha de comienzo es anterior a la fecha actual o es mayor a la fecha expiracion");
            }
            else
            {
                dateTimePickerFC.BackColor = Color.Green;
                dateTimePickerFE.BackColor = Color.Green;
            }

            return b;
        }

        private PolizaHogar construirPoliza()
        {
            PolizaHogar pol=new PolizaHogar();

            pol.AnhoConstruccion=Int32.Parse(numericUpDownAnho.Value.ToString());
            pol.MetrosConstruidos = Int32.Parse(numericUpDownCons.Value.ToString());
            pol.MetrosTotales = Int32.Parse(numericUpDownTot.Value.ToString());
            pol.Habitaciones = Int32.Parse(numericUpDownHab.Value.ToString());
            pol.Dni = maskedTextBox1.Text;
            pol.ValorContenido = Double.Parse(maskedTextBoxContenido.Text);
            pol.ValorVivienda = Double.Parse(maskedTextBoxValor.Text);
            pol.ZonaVivienda = comboBoxZona.SelectedItem.ToString();
            pol.TipoMaterial = comboBoxTipMat.SelectedItem.ToString();
            pol.TipoVivienda = comboBoxTipo.SelectedItem.ToString();
            pol.UsoVivienda = comboBoxUsoVivi.SelectedItem.ToString();

            Dictionary<CheckBox, String> coberturas = new Dictionary<CheckBox, String>();
            coberturas.Add(checkBoxVehEnGar, "VehiculoEnGaraje");
            coberturas.Add(checkBoxRep24h, "Reparacion24Horas");
            coberturas.Add(checkBoxJuriAmp, "JuridicaAvanzada");
            coberturas.Add(checkBoxAsisEnViaj, "AsistenciaViaje");
            coberturas.Add(checkBoxProm, "Promociones");
            coberturas.Add(checkBoxVandalicos, "ActosVandalicos");
            coberturas.Add(checkBoxAsisInf, "AsistenciaInformacion");
            coberturas.Add(checkBoxRobEnCas, "RoboEnCasa");
            coberturas.Add(checkBoxFuego, "Incendio");
            coberturas.Add(checkBoxFenAtm, "FenomenosAtmosfericos");
            coberturas.Add(checkBox11ReposDDEE, "ResponsabilidadDaniosEstructurales");
            coberturas.Add(checkBoxRotoCris, "RoturaCristales");
            coberturas.Add(checkBoxRotTub, "RoturaTuberias");
            coberturas.Add(checkBoxAguaYElec, "AguaElectricidad");
            coberturas.Add(checkBoxInhDelInm, "Inhabitabilidad");
            coberturas.Add(checkBoxDefJur, "DefensaJuridica");
            coberturas.Add(checkBoxDerrAcc, "Derrumbe");
            coberturas.Add(checkBoxAlarma, "Alarma");
            coberturas.Add(checkBoxVerja, "Verja");
            coberturas.Add(checkBoxPSegur, "PersonalSeguridad");
            coberturas.Add(checkBoxCajaF, "CajaFuerte");
            coberturas.Add(checkBoxCamaras, "Camaras");

            foreach (Control item in tabPageCA.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;

                    foreach (KeyValuePair<CheckBox, String> cobertura in coberturas)
                    {
                        if (cb.Text == cobertura.Key.Text && cb.Checked)
                        {
                            typeof(PolizaHogar).GetProperty(cobertura.Value).SetValue(pol, true);
                        }
                    }

                }
            }

            foreach (Control item in groupBoxCob.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;

                    foreach (KeyValuePair<CheckBox, String> cobertura in coberturas)
                    {
                        if (cb.Text == cobertura.Key.Text && cb.Checked)
                        {
                            typeof(PolizaHogar).GetProperty(cobertura.Value).SetValue(pol, true);
                        }
                    }

                }
            }

            foreach (Control item in groupBoxSS.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;

                    foreach (KeyValuePair<CheckBox, String> cobertura in coberturas)
                    {
                        if (cb.Text == cobertura.Key.Text && cb.Checked)
                        {
                            typeof(PolizaHogar).GetProperty(cobertura.Value).SetValue(pol, true);
                        }
                    }

                }
            }

            foreach (var item in checkedListBox1.Items)
            {
                if (checkedListBox1.CheckedItems.Contains(item))
                {
                    switch (item.ToString())
                    {
                        case "Mascotas":
                            pol.Mascota = true;
                            break;
                        case "Piscina":
                            pol.Piscina = true;
                            break;
                        case "Garaje":
                            pol.Garaje = true;
                            break;
                    }
                }
            }
            double precio = (calcularPrecioCoberturas() + calcularPrecioCoberturasAmp() + calcularPrecioDetalles() + calcularPrecioMasDetalles());
            pol.Precio = precio;


            pol.FechaComienzo = dateTimePickerFC.Value;
            pol.FechaExpiracion = dateTimePickerFE.Value;

            return pol;
        }

        private void obtenerDatosPoliza(PolizaHogar ph)
        {
            maskedTextBox1.Text = ph.Dni;
            comboBoxTipo.SelectedItem = ph.TipoVivienda;
            comboBoxZona.SelectedItem = ph.ZonaVivienda;
            numericUpDownAnho.Value = ph.AnhoConstruccion;
            numericUpDownCons.Value = ph.MetrosConstruidos;
            numericUpDownTot.Value = ph.MetrosTotales;
            maskedTextBoxValor.Text = ph.ValorVivienda.ToString();
            maskedTextBoxContenido.Text=ph.ValorContenido.ToString();
            numericUpDownHab.Value = ph.Habitaciones;
            checkBoxCamaras.Checked = ph.Camaras;
            checkBoxPSegur.Checked = ph.PersonalSeguridad;
            checkBoxCajaF.Checked = ph.PersonalSeguridad;
            checkBoxVerja.Checked = ph.PersonalSeguridad;
            checkBoxAlarma.Checked = ph.PersonalSeguridad;
            comboBoxTipMat.SelectedItem = ph.TipoMaterial;
            comboBoxUsoVivi.SelectedItem = ph.UsoVivienda;
            checkBoxRobEnCas.Checked = ph.RoboEnCasa;
            checkBoxFuego.Checked = ph.Incendio;
            checkBoxFenAtm.Checked = ph.FenomenosAtmosfericos;
            checkBox11ReposDDEE.Checked = ph.ResponsabilidadDaniosEstructurales;
            checkBoxRotoCris.Checked = ph.RoturaCristales;
            checkBoxAguaYElec.Checked = ph.AguaElectricidad;
            checkBoxInhDelInm.Checked = ph.Inhabitabilidad;
            checkBoxDefJur.Checked = ph.DefensaJuridica;
            checkBoxRotTub.Checked = ph.RoturaTuberias;
            checkBoxDerrAcc.Checked = ph.Derrumbe;
            checkBoxAsisEnViaj.Checked = ph.AsistenciaViaje;
            checkBoxAsisInf.Checked = ph.AsistenciaInformacion;
            checkBoxVandalicos.Checked = ph.ActosVandalicos;
            checkBoxProm.Checked = ph.Promociones;
            checkBoxRep24h.Checked = ph.Reparacion24Horas;
            checkBoxJuriAmp.Checked = ph.JuridicaAvanzada;
            checkBoxVehEnGar.Checked = ph.VehiculoEnGaraje;
            checkedListBox1.SetItemChecked(0,ph.Mascota);
            checkedListBox1.SetItemChecked(1, ph.Piscina);
            checkedListBox1.SetItemChecked(2, ph.Garaje);
            dateTimePickerFC.Value = ph.FechaComienzo;
            dateTimePickerFE.Value = ph.FechaExpiracion;
        }

        private void FrmPolizaHogar_Load(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
