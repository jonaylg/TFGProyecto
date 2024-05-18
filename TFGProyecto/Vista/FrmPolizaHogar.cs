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

namespace TFGProyecto.Vista
{
    public partial class FrmPolizaHogar : Form
    {
        public FrmPolizaHogar()
        {
            InitializeComponent();
        }

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

            precio += ((double)numericUpDownCons.Value * 0.5);

            precio += ((double)numericUpDownTot.Value * 0.4);

            precio += Double.Parse(textBoxValor.Text) / 10000;

            precio += Double.Parse(textBoxContenido.Text) / 1000;

            precio += ((double)numericUpDownHab.Value*2.5);

            foreach (Control item in checkedListBox1.Controls)
            {
                CheckBox cb = (CheckBox)item;
                if (cb.Checked)
                {
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
                        }
                    }

                }
            }


            return precio;
        }

        private void buttonPrecio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("este es el precio de la poliza " + (calcularPrecioCoberturas()+ calcularPrecioCoberturasAmp()+ calcularPrecioDetalles()+ calcularPrecioMasDetalles()));
        }

        private void FrmPolizaHogar_Load(object sender, EventArgs e)
        {

        }
    }
}
