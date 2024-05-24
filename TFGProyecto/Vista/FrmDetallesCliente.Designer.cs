namespace TFGProyecto.Vista
{
    partial class FrmDetallesCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePickerFN = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.textBoxProv = new System.Windows.Forms.TextBox();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.textBoxApe = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxCiu = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxNomTit = new System.Windows.Forms.TextBox();
            this.textBoxDirFac = new System.Windows.Forms.TextBox();
            this.comboBoxMetPag = new System.Windows.Forms.ComboBox();
            this.comboBoxFrecPag = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxCVV = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxFV = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelFV = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonInserClien = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBoxDni = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(72, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 365);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.maskedTextBoxDni);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.dateTimePickerFN);
            this.tabPage1.Controls.Add(this.maskedTextBoxTel);
            this.tabPage1.Controls.Add(this.textBoxProv);
            this.tabPage1.Controls.Add(this.textBoxDir);
            this.tabPage1.Controls.Add(this.textBoxApe);
            this.tabPage1.Controls.Add(this.textBoxCorreo);
            this.tabPage1.Controls.Add(this.textBoxCiu);
            this.tabPage1.Controls.Add(this.textBoxNombre);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(649, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFN
            // 
            this.dateTimePickerFN.Location = new System.Drawing.Point(193, 252);
            this.dateTimePickerFN.Name = "dateTimePickerFN";
            this.dateTimePickerFN.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFN.TabIndex = 15;
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(501, 79);
            this.maskedTextBoxTel.Mask = "(999)000-0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxTel.TabIndex = 14;
            // 
            // textBoxProv
            // 
            this.textBoxProv.Location = new System.Drawing.Point(501, 211);
            this.textBoxProv.Name = "textBoxProv";
            this.textBoxProv.Size = new System.Drawing.Size(100, 22);
            this.textBoxProv.TabIndex = 13;
            // 
            // textBoxDir
            // 
            this.textBoxDir.Location = new System.Drawing.Point(193, 181);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(100, 22);
            this.textBoxDir.TabIndex = 12;
            // 
            // textBoxApe
            // 
            this.textBoxApe.Location = new System.Drawing.Point(193, 111);
            this.textBoxApe.Name = "textBoxApe";
            this.textBoxApe.Size = new System.Drawing.Size(100, 22);
            this.textBoxApe.TabIndex = 11;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(501, 141);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(100, 22);
            this.textBoxCorreo.TabIndex = 10;
            // 
            // textBoxCiu
            // 
            this.textBoxCiu.Location = new System.Drawing.Point(501, 281);
            this.textBoxCiu.Name = "textBoxCiu";
            this.textBoxCiu.Size = new System.Drawing.Size(100, 22);
            this.textBoxCiu.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(193, 43);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombre.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Provincia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo electrónico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxNomTit);
            this.tabPage2.Controls.Add(this.textBoxDirFac);
            this.tabPage2.Controls.Add(this.comboBoxMetPag);
            this.tabPage2.Controls.Add(this.comboBoxFrecPag);
            this.tabPage2.Controls.Add(this.maskedTextBoxCVV);
            this.tabPage2.Controls.Add(this.maskedTextBoxFV);
            this.tabPage2.Controls.Add(this.comboBoxTipo);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.labelFV);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(649, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bancarios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxNomTit
            // 
            this.textBoxNomTit.Location = new System.Drawing.Point(522, 64);
            this.textBoxNomTit.Name = "textBoxNomTit";
            this.textBoxNomTit.Size = new System.Drawing.Size(100, 22);
            this.textBoxNomTit.TabIndex = 13;
            // 
            // textBoxDirFac
            // 
            this.textBoxDirFac.Location = new System.Drawing.Point(211, 127);
            this.textBoxDirFac.Name = "textBoxDirFac";
            this.textBoxDirFac.Size = new System.Drawing.Size(100, 22);
            this.textBoxDirFac.TabIndex = 12;
            // 
            // comboBoxMetPag
            // 
            this.comboBoxMetPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMetPag.FormattingEnabled = true;
            this.comboBoxMetPag.Items.AddRange(new object[] {
            "Débito",
            "Tarjeta de credito",
            "Transferencia bancaria",
            "Pago en linea"});
            this.comboBoxMetPag.Location = new System.Drawing.Point(522, 194);
            this.comboBoxMetPag.Name = "comboBoxMetPag";
            this.comboBoxMetPag.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMetPag.TabIndex = 11;
            // 
            // comboBoxFrecPag
            // 
            this.comboBoxFrecPag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrecPag.FormattingEnabled = true;
            this.comboBoxFrecPag.Items.AddRange(new object[] {
            "Mensual",
            "Trimestral",
            "Semestral",
            "Anual"});
            this.comboBoxFrecPag.Location = new System.Drawing.Point(522, 127);
            this.comboBoxFrecPag.Name = "comboBoxFrecPag";
            this.comboBoxFrecPag.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFrecPag.TabIndex = 10;
            // 
            // maskedTextBoxCVV
            // 
            this.maskedTextBoxCVV.Location = new System.Drawing.Point(211, 194);
            this.maskedTextBoxCVV.Mask = "000";
            this.maskedTextBoxCVV.Name = "maskedTextBoxCVV";
            this.maskedTextBoxCVV.Size = new System.Drawing.Size(39, 22);
            this.maskedTextBoxCVV.TabIndex = 9;
            // 
            // maskedTextBoxFV
            // 
            this.maskedTextBoxFV.Location = new System.Drawing.Point(211, 263);
            this.maskedTextBoxFV.Mask = "00/00";
            this.maskedTextBoxFV.Name = "maskedTextBoxFV";
            this.maskedTextBoxFV.Size = new System.Drawing.Size(46, 22);
            this.maskedTextBoxFV.TabIndex = 8;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Cuenta Bancaria",
            "Tarjeta de Credito"});
            this.comboBoxTipo.Location = new System.Drawing.Point(211, 64);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTipo.TabIndex = 7;
            this.comboBoxTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(373, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "Frecuencia de Pago";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(373, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "Método de Pago";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Dirección de Facturación";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(373, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Nombre del Titular";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 197);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "CVV";
            // 
            // labelFV
            // 
            this.labelFV.AutoSize = true;
            this.labelFV.Location = new System.Drawing.Point(38, 266);
            this.labelFV.Name = "labelFV";
            this.labelFV.Size = new System.Drawing.Size(141, 16);
            this.labelFV.TabIndex = 1;
            this.labelFV.Text = "Fecha de Vencimiento";
            this.labelFV.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // buttonInserClien
            // 
            this.buttonInserClien.Location = new System.Drawing.Point(376, 406);
            this.buttonInserClien.Name = "buttonInserClien";
            this.buttonInserClien.Size = new System.Drawing.Size(75, 23);
            this.buttonInserClien.TabIndex = 1;
            this.buttonInserClien.Text = "crear";
            this.buttonInserClien.UseVisualStyleBackColor = true;
            this.buttonInserClien.Click += new System.EventHandler(this.buttonInserClien_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(368, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "DNI";
            // 
            // maskedTextBoxDni
            // 
            this.maskedTextBoxDni.Location = new System.Drawing.Point(501, 22);
            this.maskedTextBoxDni.Mask = "00000000L";
            this.maskedTextBoxDni.Name = "maskedTextBoxDni";
            this.maskedTextBoxDni.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxDni.TabIndex = 17;
            // 
            // FrmDetallesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInserClien);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDetallesCliente";
            this.Text = "FrmDetallesCliente";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxProv;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.TextBox textBoxApe;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxCiu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelFV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFN;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.TextBox textBoxNomTit;
        private System.Windows.Forms.TextBox textBoxDirFac;
        private System.Windows.Forms.ComboBox comboBoxMetPag;
        private System.Windows.Forms.ComboBox comboBoxFrecPag;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCVV;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFV;
        private System.Windows.Forms.Button buttonInserClien;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDni;
        private System.Windows.Forms.Label label10;
    }
}