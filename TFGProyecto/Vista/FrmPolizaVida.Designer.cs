namespace TFGProyecto.Vista
{
    partial class FrmPolizaVida
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
            this.components = new System.ComponentModel.Container();
            this.tbcntrlVida = new System.Windows.Forms.TabControl();
            this.tbpgCaracteristicas = new System.Windows.Forms.TabPage();
            this.nudAlt = new System.Windows.Forms.NumericUpDown();
            this.nudPeso = new System.Windows.Forms.NumericUpDown();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.cmbxOcu = new System.Windows.Forms.ComboBox();
            this.trabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseTFGDataSet1 = new TFGProyecto.DatabaseTFGDataSet1();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.cmbxSexo = new System.Windows.Forms.ComboBox();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.tbpgSalud = new System.Windows.Forms.TabPage();
            this.chkbxHema = new System.Windows.Forms.CheckBox();
            this.chkbxGastro = new System.Windows.Forms.CheckBox();
            this.chkbxEndo = new System.Windows.Forms.CheckBox();
            this.chkbxInfec = new System.Windows.Forms.CheckBox();
            this.chkbxAuto = new System.Windows.Forms.CheckBox();
            this.chkbxNeu = new System.Windows.Forms.CheckBox();
            this.chkbxRen = new System.Windows.Forms.CheckBox();
            this.chkbxHepa = new System.Windows.Forms.CheckBox();
            this.chkbxDia = new System.Windows.Forms.CheckBox();
            this.chkbxCan = new System.Windows.Forms.CheckBox();
            this.chkbxResp = new System.Windows.Forms.CheckBox();
            this.chkbxCard = new System.Windows.Forms.CheckBox();
            this.tbpgEstilo = new System.Windows.Forms.TabPage();
            this.grbbxAct = new System.Windows.Forms.GroupBox();
            this.rdbttnBaja = new System.Windows.Forms.RadioButton();
            this.rdbttnMed = new System.Windows.Forms.RadioButton();
            this.rdbttnAlta = new System.Windows.Forms.RadioButton();
            this.grpbxDieta = new System.Windows.Forms.GroupBox();
            this.rdbttnHipo = new System.Windows.Forms.RadioButton();
            this.rdbttnHiper = new System.Windows.Forms.RadioButton();
            this.rdbttnEqui = new System.Windows.Forms.RadioButton();
            this.grpbxMal = new System.Windows.Forms.GroupBox();
            this.chkbxTabaco = new System.Windows.Forms.CheckBox();
            this.chkbxDrogas = new System.Windows.Forms.CheckBox();
            this.chkbxAlcohol = new System.Windows.Forms.CheckBox();
            this.tbpgCoberturas = new System.Windows.Forms.TabPage();
            this.nudCap = new System.Windows.Forms.NumericUpDown();
            this.chkbxCap = new System.Windows.Forms.CheckBox();
            this.chkbxTerm = new System.Windows.Forms.CheckBox();
            this.chkbxITP = new System.Windows.Forms.CheckBox();
            this.chkbxAcc = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.msktxtbxDNI = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrecio = new System.Windows.Forms.Button();
            this.trabajoTableAdapter = new TFGProyecto.DatabaseTFGDataSet1TableAdapters.TrabajoTableAdapter();
            this.tableAdapterManager = new TFGProyecto.DatabaseTFGDataSet1TableAdapters.TableAdapterManager();
            this.tbcntrlVida.SuspendLayout();
            this.tbpgCaracteristicas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTFGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.tbpgSalud.SuspendLayout();
            this.tbpgEstilo.SuspendLayout();
            this.grbbxAct.SuspendLayout();
            this.grpbxDieta.SuspendLayout();
            this.grpbxMal.SuspendLayout();
            this.tbpgCoberturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcntrlVida
            // 
            this.tbcntrlVida.Controls.Add(this.tbpgCaracteristicas);
            this.tbcntrlVida.Controls.Add(this.tbpgSalud);
            this.tbcntrlVida.Controls.Add(this.tbpgEstilo);
            this.tbcntrlVida.Controls.Add(this.tbpgCoberturas);
            this.tbcntrlVida.Location = new System.Drawing.Point(49, 55);
            this.tbcntrlVida.Margin = new System.Windows.Forms.Padding(2);
            this.tbcntrlVida.Name = "tbcntrlVida";
            this.tbcntrlVida.SelectedIndex = 0;
            this.tbcntrlVida.Size = new System.Drawing.Size(513, 253);
            this.tbcntrlVida.TabIndex = 0;
            // 
            // tbpgCaracteristicas
            // 
            this.tbpgCaracteristicas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tbpgCaracteristicas.Controls.Add(this.nudAlt);
            this.tbpgCaracteristicas.Controls.Add(this.nudPeso);
            this.tbpgCaracteristicas.Controls.Add(this.lblAlt);
            this.tbpgCaracteristicas.Controls.Add(this.lblPeso);
            this.tbpgCaracteristicas.Controls.Add(this.cmbxOcu);
            this.tbpgCaracteristicas.Controls.Add(this.nudEdad);
            this.tbpgCaracteristicas.Controls.Add(this.cmbxSexo);
            this.tbpgCaracteristicas.Controls.Add(this.lblOcupacion);
            this.tbpgCaracteristicas.Controls.Add(this.lblSexo);
            this.tbpgCaracteristicas.Controls.Add(this.lblEdad);
            this.tbpgCaracteristicas.Location = new System.Drawing.Point(4, 22);
            this.tbpgCaracteristicas.Margin = new System.Windows.Forms.Padding(2);
            this.tbpgCaracteristicas.Name = "tbpgCaracteristicas";
            this.tbpgCaracteristicas.Padding = new System.Windows.Forms.Padding(2);
            this.tbpgCaracteristicas.Size = new System.Drawing.Size(505, 227);
            this.tbpgCaracteristicas.TabIndex = 0;
            this.tbpgCaracteristicas.Text = "Datos";
            // 
            // nudAlt
            // 
            this.nudAlt.Location = new System.Drawing.Point(362, 115);
            this.nudAlt.Margin = new System.Windows.Forms.Padding(2);
            this.nudAlt.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudAlt.Name = "nudAlt";
            this.nudAlt.Size = new System.Drawing.Size(90, 20);
            this.nudAlt.TabIndex = 25;
            this.nudAlt.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudPeso
            // 
            this.nudPeso.Location = new System.Drawing.Point(362, 68);
            this.nudPeso.Margin = new System.Windows.Forms.Padding(2);
            this.nudPeso.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudPeso.Name = "nudPeso";
            this.nudPeso.Size = new System.Drawing.Size(90, 20);
            this.nudPeso.TabIndex = 24;
            this.nudPeso.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.Location = new System.Drawing.Point(283, 122);
            this.lblAlt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(34, 13);
            this.lblAlt.TabIndex = 23;
            this.lblAlt.Text = "Altura";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(283, 75);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 22;
            this.lblPeso.Text = "Peso";
            // 
            // cmbxOcu
            // 
            this.cmbxOcu.DataSource = this.trabajoBindingSource;
            this.cmbxOcu.DisplayMember = "Nombre";
            this.cmbxOcu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxOcu.FormattingEnabled = true;
            this.cmbxOcu.Location = new System.Drawing.Point(147, 140);
            this.cmbxOcu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxOcu.Name = "cmbxOcu";
            this.cmbxOcu.Size = new System.Drawing.Size(92, 21);
            this.cmbxOcu.TabIndex = 21;
            this.cmbxOcu.ValueMember = "ID";
            // 
            // trabajoBindingSource
            // 
            this.trabajoBindingSource.DataMember = "Trabajo";
            this.trabajoBindingSource.DataSource = this.databaseTFGDataSet1;
            // 
            // databaseTFGDataSet1
            // 
            this.databaseTFGDataSet1.DataSetName = "DatabaseTFGDataSet1";
            this.databaseTFGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(147, 50);
            this.nudEdad.Margin = new System.Windows.Forms.Padding(2);
            this.nudEdad.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.nudEdad.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(90, 20);
            this.nudEdad.TabIndex = 20;
            this.nudEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // cmbxSexo
            // 
            this.cmbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSexo.FormattingEnabled = true;
            this.cmbxSexo.Items.AddRange(new object[] {
            "H",
            "M"});
            this.cmbxSexo.Location = new System.Drawing.Point(147, 91);
            this.cmbxSexo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxSexo.Name = "cmbxSexo";
            this.cmbxSexo.Size = new System.Drawing.Size(92, 21);
            this.cmbxSexo.TabIndex = 12;
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Location = new System.Drawing.Point(63, 148);
            this.lblOcupacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(59, 13);
            this.lblOcupacion.TabIndex = 2;
            this.lblOcupacion.Text = "Ocupación";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(61, 102);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 1;
            this.lblSexo.Text = "Sexo";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(59, 55);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 0;
            this.lblEdad.Text = "Edad";
            // 
            // tbpgSalud
            // 
            this.tbpgSalud.Controls.Add(this.chkbxHema);
            this.tbpgSalud.Controls.Add(this.chkbxGastro);
            this.tbpgSalud.Controls.Add(this.chkbxEndo);
            this.tbpgSalud.Controls.Add(this.chkbxInfec);
            this.tbpgSalud.Controls.Add(this.chkbxAuto);
            this.tbpgSalud.Controls.Add(this.chkbxNeu);
            this.tbpgSalud.Controls.Add(this.chkbxRen);
            this.tbpgSalud.Controls.Add(this.chkbxHepa);
            this.tbpgSalud.Controls.Add(this.chkbxDia);
            this.tbpgSalud.Controls.Add(this.chkbxCan);
            this.tbpgSalud.Controls.Add(this.chkbxResp);
            this.tbpgSalud.Controls.Add(this.chkbxCard);
            this.tbpgSalud.Location = new System.Drawing.Point(4, 22);
            this.tbpgSalud.Margin = new System.Windows.Forms.Padding(2);
            this.tbpgSalud.Name = "tbpgSalud";
            this.tbpgSalud.Padding = new System.Windows.Forms.Padding(2);
            this.tbpgSalud.Size = new System.Drawing.Size(505, 227);
            this.tbpgSalud.TabIndex = 1;
            this.tbpgSalud.Text = "Historial Salud";
            this.tbpgSalud.UseVisualStyleBackColor = true;
            // 
            // chkbxHema
            // 
            this.chkbxHema.AutoSize = true;
            this.chkbxHema.Location = new System.Drawing.Point(272, 202);
            this.chkbxHema.Name = "chkbxHema";
            this.chkbxHema.Size = new System.Drawing.Size(149, 17);
            this.chkbxHema.TabIndex = 11;
            this.chkbxHema.Text = "Trastornos Hematologicos";
            this.chkbxHema.UseVisualStyleBackColor = true;
            // 
            // chkbxGastro
            // 
            this.chkbxGastro.AutoSize = true;
            this.chkbxGastro.Location = new System.Drawing.Point(44, 25);
            this.chkbxGastro.Name = "chkbxGastro";
            this.chkbxGastro.Size = new System.Drawing.Size(180, 17);
            this.chkbxGastro.TabIndex = 10;
            this.chkbxGastro.Text = "Enfermedades Gastrointestinales";
            this.chkbxGastro.UseVisualStyleBackColor = true;
            // 
            // chkbxEndo
            // 
            this.chkbxEndo.AutoSize = true;
            this.chkbxEndo.Location = new System.Drawing.Point(44, 132);
            this.chkbxEndo.Name = "chkbxEndo";
            this.chkbxEndo.Size = new System.Drawing.Size(132, 17);
            this.chkbxEndo.TabIndex = 9;
            this.chkbxEndo.Text = "Trastornos Endocrinos";
            this.chkbxEndo.UseVisualStyleBackColor = true;
            // 
            // chkbxInfec
            // 
            this.chkbxInfec.AutoSize = true;
            this.chkbxInfec.Location = new System.Drawing.Point(44, 100);
            this.chkbxInfec.Name = "chkbxInfec";
            this.chkbxInfec.Size = new System.Drawing.Size(195, 17);
            this.chkbxInfec.TabIndex = 8;
            this.chkbxInfec.Text = "Enfermedades Infecciosas Crónicas";
            this.chkbxInfec.UseVisualStyleBackColor = true;
            // 
            // chkbxAuto
            // 
            this.chkbxAuto.AutoSize = true;
            this.chkbxAuto.Location = new System.Drawing.Point(272, 52);
            this.chkbxAuto.Name = "chkbxAuto";
            this.chkbxAuto.Size = new System.Drawing.Size(158, 17);
            this.chkbxAuto.TabIndex = 7;
            this.chkbxAuto.Text = "Enfermedades Autoinmunes";
            this.chkbxAuto.UseVisualStyleBackColor = true;
            // 
            // chkbxNeu
            // 
            this.chkbxNeu.AutoSize = true;
            this.chkbxNeu.Location = new System.Drawing.Point(272, 20);
            this.chkbxNeu.Name = "chkbxNeu";
            this.chkbxNeu.Size = new System.Drawing.Size(141, 17);
            this.chkbxNeu.TabIndex = 6;
            this.chkbxNeu.Text = "Trastornos Neurologicos";
            this.chkbxNeu.UseVisualStyleBackColor = true;
            // 
            // chkbxRen
            // 
            this.chkbxRen.AutoSize = true;
            this.chkbxRen.Location = new System.Drawing.Point(272, 130);
            this.chkbxRen.Name = "chkbxRen";
            this.chkbxRen.Size = new System.Drawing.Size(136, 17);
            this.chkbxRen.TabIndex = 5;
            this.chkbxRen.Text = "Enfermedades Renales";
            this.chkbxRen.UseVisualStyleBackColor = true;
            // 
            // chkbxHepa
            // 
            this.chkbxHepa.AutoSize = true;
            this.chkbxHepa.Location = new System.Drawing.Point(44, 167);
            this.chkbxHepa.Name = "chkbxHepa";
            this.chkbxHepa.Size = new System.Drawing.Size(145, 17);
            this.chkbxHepa.TabIndex = 4;
            this.chkbxHepa.Text = "Enfermedades Hépaticas";
            this.chkbxHepa.UseVisualStyleBackColor = true;
            // 
            // chkbxDia
            // 
            this.chkbxDia.AutoSize = true;
            this.chkbxDia.Location = new System.Drawing.Point(44, 202);
            this.chkbxDia.Name = "chkbxDia";
            this.chkbxDia.Size = new System.Drawing.Size(68, 17);
            this.chkbxDia.TabIndex = 3;
            this.chkbxDia.Text = "Diabetes";
            this.chkbxDia.UseVisualStyleBackColor = true;
            // 
            // chkbxCan
            // 
            this.chkbxCan.AutoSize = true;
            this.chkbxCan.Location = new System.Drawing.Point(272, 95);
            this.chkbxCan.Name = "chkbxCan";
            this.chkbxCan.Size = new System.Drawing.Size(60, 17);
            this.chkbxCan.TabIndex = 2;
            this.chkbxCan.Text = "Cancer";
            this.chkbxCan.UseVisualStyleBackColor = true;
            // 
            // chkbxResp
            // 
            this.chkbxResp.AutoSize = true;
            this.chkbxResp.Location = new System.Drawing.Point(44, 60);
            this.chkbxResp.Name = "chkbxResp";
            this.chkbxResp.Size = new System.Drawing.Size(158, 17);
            this.chkbxResp.TabIndex = 1;
            this.chkbxResp.Text = "Enfermedades Respiratorias";
            this.chkbxResp.UseVisualStyleBackColor = true;
            // 
            // chkbxCard
            // 
            this.chkbxCard.AutoSize = true;
            this.chkbxCard.Location = new System.Drawing.Point(272, 170);
            this.chkbxCard.Name = "chkbxCard";
            this.chkbxCard.Size = new System.Drawing.Size(144, 17);
            this.chkbxCard.TabIndex = 0;
            this.chkbxCard.Text = "Enfermedades Cardiacas";
            this.chkbxCard.UseVisualStyleBackColor = true;
            // 
            // tbpgEstilo
            // 
            this.tbpgEstilo.Controls.Add(this.grbbxAct);
            this.tbpgEstilo.Controls.Add(this.grpbxDieta);
            this.tbpgEstilo.Controls.Add(this.grpbxMal);
            this.tbpgEstilo.Location = new System.Drawing.Point(4, 22);
            this.tbpgEstilo.Margin = new System.Windows.Forms.Padding(2);
            this.tbpgEstilo.Name = "tbpgEstilo";
            this.tbpgEstilo.Padding = new System.Windows.Forms.Padding(2);
            this.tbpgEstilo.Size = new System.Drawing.Size(505, 227);
            this.tbpgEstilo.TabIndex = 2;
            this.tbpgEstilo.Text = "Estilo de Vida";
            this.tbpgEstilo.UseVisualStyleBackColor = true;
            // 
            // grbbxAct
            // 
            this.grbbxAct.Controls.Add(this.rdbttnBaja);
            this.grbbxAct.Controls.Add(this.rdbttnMed);
            this.grbbxAct.Controls.Add(this.rdbttnAlta);
            this.grbbxAct.Location = new System.Drawing.Point(357, 16);
            this.grbbxAct.Name = "grbbxAct";
            this.grbbxAct.Size = new System.Drawing.Size(109, 100);
            this.grbbxAct.TabIndex = 9;
            this.grbbxAct.TabStop = false;
            this.grbbxAct.Text = "Nivel de Actividad";
            // 
            // rdbttnBaja
            // 
            this.rdbttnBaja.AutoSize = true;
            this.rdbttnBaja.Location = new System.Drawing.Point(21, 72);
            this.rdbttnBaja.Name = "rdbttnBaja";
            this.rdbttnBaja.Size = new System.Drawing.Size(46, 17);
            this.rdbttnBaja.TabIndex = 3;
            this.rdbttnBaja.TabStop = true;
            this.rdbttnBaja.Text = "Baja";
            this.rdbttnBaja.UseVisualStyleBackColor = true;
            // 
            // rdbttnMed
            // 
            this.rdbttnMed.AutoSize = true;
            this.rdbttnMed.Location = new System.Drawing.Point(21, 46);
            this.rdbttnMed.Name = "rdbttnMed";
            this.rdbttnMed.Size = new System.Drawing.Size(54, 17);
            this.rdbttnMed.TabIndex = 2;
            this.rdbttnMed.TabStop = true;
            this.rdbttnMed.Text = "Media";
            this.rdbttnMed.UseVisualStyleBackColor = true;
            // 
            // rdbttnAlta
            // 
            this.rdbttnAlta.AutoSize = true;
            this.rdbttnAlta.Location = new System.Drawing.Point(21, 23);
            this.rdbttnAlta.Name = "rdbttnAlta";
            this.rdbttnAlta.Size = new System.Drawing.Size(43, 17);
            this.rdbttnAlta.TabIndex = 1;
            this.rdbttnAlta.TabStop = true;
            this.rdbttnAlta.Text = "Alta";
            this.rdbttnAlta.UseVisualStyleBackColor = true;
            // 
            // grpbxDieta
            // 
            this.grpbxDieta.Controls.Add(this.rdbttnHipo);
            this.grpbxDieta.Controls.Add(this.rdbttnHiper);
            this.grpbxDieta.Controls.Add(this.rdbttnEqui);
            this.grpbxDieta.Location = new System.Drawing.Point(14, 20);
            this.grpbxDieta.Name = "grpbxDieta";
            this.grpbxDieta.Size = new System.Drawing.Size(200, 96);
            this.grpbxDieta.TabIndex = 8;
            this.grpbxDieta.TabStop = false;
            this.grpbxDieta.Text = "Dieta";
            // 
            // rdbttnHipo
            // 
            this.rdbttnHipo.AutoSize = true;
            this.rdbttnHipo.Location = new System.Drawing.Point(28, 68);
            this.rdbttnHipo.Name = "rdbttnHipo";
            this.rdbttnHipo.Size = new System.Drawing.Size(84, 17);
            this.rdbttnHipo.TabIndex = 2;
            this.rdbttnHipo.TabStop = true;
            this.rdbttnHipo.Text = "Hipocalorica";
            this.rdbttnHipo.UseVisualStyleBackColor = true;
            // 
            // rdbttnHiper
            // 
            this.rdbttnHiper.AutoSize = true;
            this.rdbttnHiper.Location = new System.Drawing.Point(28, 45);
            this.rdbttnHiper.Name = "rdbttnHiper";
            this.rdbttnHiper.Size = new System.Drawing.Size(87, 17);
            this.rdbttnHiper.TabIndex = 1;
            this.rdbttnHiper.TabStop = true;
            this.rdbttnHiper.Text = "Hipercalorica";
            this.rdbttnHiper.UseVisualStyleBackColor = true;
            // 
            // rdbttnEqui
            // 
            this.rdbttnEqui.AutoSize = true;
            this.rdbttnEqui.Location = new System.Drawing.Point(28, 22);
            this.rdbttnEqui.Name = "rdbttnEqui";
            this.rdbttnEqui.Size = new System.Drawing.Size(77, 17);
            this.rdbttnEqui.TabIndex = 0;
            this.rdbttnEqui.TabStop = true;
            this.rdbttnEqui.Text = "Equilibrada";
            this.rdbttnEqui.UseVisualStyleBackColor = true;
            // 
            // grpbxMal
            // 
            this.grpbxMal.Controls.Add(this.chkbxTabaco);
            this.grpbxMal.Controls.Add(this.chkbxDrogas);
            this.grpbxMal.Controls.Add(this.chkbxAlcohol);
            this.grpbxMal.Location = new System.Drawing.Point(266, 122);
            this.grpbxMal.Name = "grpbxMal";
            this.grpbxMal.Size = new System.Drawing.Size(200, 100);
            this.grpbxMal.TabIndex = 7;
            this.grpbxMal.TabStop = false;
            this.grpbxMal.Text = "Malos Habitos";
            // 
            // chkbxTabaco
            // 
            this.chkbxTabaco.AutoSize = true;
            this.chkbxTabaco.Location = new System.Drawing.Point(19, 19);
            this.chkbxTabaco.Name = "chkbxTabaco";
            this.chkbxTabaco.Size = new System.Drawing.Size(63, 17);
            this.chkbxTabaco.TabIndex = 4;
            this.chkbxTabaco.Text = "Tabaco";
            this.chkbxTabaco.UseVisualStyleBackColor = true;
            // 
            // chkbxDrogas
            // 
            this.chkbxDrogas.AutoSize = true;
            this.chkbxDrogas.Location = new System.Drawing.Point(19, 65);
            this.chkbxDrogas.Name = "chkbxDrogas";
            this.chkbxDrogas.Size = new System.Drawing.Size(60, 17);
            this.chkbxDrogas.TabIndex = 6;
            this.chkbxDrogas.Text = "Drogas";
            this.chkbxDrogas.UseVisualStyleBackColor = true;
            // 
            // chkbxAlcohol
            // 
            this.chkbxAlcohol.AutoSize = true;
            this.chkbxAlcohol.Location = new System.Drawing.Point(19, 42);
            this.chkbxAlcohol.Name = "chkbxAlcohol";
            this.chkbxAlcohol.Size = new System.Drawing.Size(61, 17);
            this.chkbxAlcohol.TabIndex = 5;
            this.chkbxAlcohol.Text = "Alcohol";
            this.chkbxAlcohol.UseVisualStyleBackColor = true;
            // 
            // tbpgCoberturas
            // 
            this.tbpgCoberturas.Controls.Add(this.nudCap);
            this.tbpgCoberturas.Controls.Add(this.chkbxCap);
            this.tbpgCoberturas.Controls.Add(this.chkbxTerm);
            this.tbpgCoberturas.Controls.Add(this.chkbxITP);
            this.tbpgCoberturas.Controls.Add(this.chkbxAcc);
            this.tbpgCoberturas.Location = new System.Drawing.Point(4, 22);
            this.tbpgCoberturas.Margin = new System.Windows.Forms.Padding(2);
            this.tbpgCoberturas.Name = "tbpgCoberturas";
            this.tbpgCoberturas.Padding = new System.Windows.Forms.Padding(2);
            this.tbpgCoberturas.Size = new System.Drawing.Size(505, 227);
            this.tbpgCoberturas.TabIndex = 3;
            this.tbpgCoberturas.Text = "Suplementos";
            this.tbpgCoberturas.UseVisualStyleBackColor = true;
            // 
            // nudCap
            // 
            this.nudCap.Enabled = false;
            this.nudCap.Location = new System.Drawing.Point(338, 114);
            this.nudCap.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.nudCap.Minimum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.nudCap.Name = "nudCap";
            this.nudCap.ReadOnly = true;
            this.nudCap.Size = new System.Drawing.Size(120, 20);
            this.nudCap.TabIndex = 5;
            this.nudCap.Value = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            // 
            // chkbxCap
            // 
            this.chkbxCap.AutoSize = true;
            this.chkbxCap.Location = new System.Drawing.Point(338, 65);
            this.chkbxCap.Margin = new System.Windows.Forms.Padding(2);
            this.chkbxCap.Name = "chkbxCap";
            this.chkbxCap.Size = new System.Drawing.Size(58, 17);
            this.chkbxCap.TabIndex = 4;
            this.chkbxCap.Text = "Capital";
            this.chkbxCap.UseVisualStyleBackColor = true;
            this.chkbxCap.CheckedChanged += new System.EventHandler(this.chkbxCap_CheckedChanged);
            // 
            // chkbxTerm
            // 
            this.chkbxTerm.AutoSize = true;
            this.chkbxTerm.Location = new System.Drawing.Point(69, 90);
            this.chkbxTerm.Margin = new System.Windows.Forms.Padding(2);
            this.chkbxTerm.Name = "chkbxTerm";
            this.chkbxTerm.Size = new System.Drawing.Size(219, 17);
            this.chkbxTerm.TabIndex = 3;
            this.chkbxTerm.Text = "Pago anticipado por enfermedad terminal";
            this.chkbxTerm.UseVisualStyleBackColor = true;
            // 
            // chkbxITP
            // 
            this.chkbxITP.AutoSize = true;
            this.chkbxITP.Location = new System.Drawing.Point(69, 137);
            this.chkbxITP.Margin = new System.Windows.Forms.Padding(2);
            this.chkbxITP.Name = "chkbxITP";
            this.chkbxITP.Size = new System.Drawing.Size(166, 17);
            this.chkbxITP.TabIndex = 2;
            this.chkbxITP.Text = "Incapazidad total permanente";
            this.chkbxITP.UseVisualStyleBackColor = true;
            // 
            // chkbxAcc
            // 
            this.chkbxAcc.AutoSize = true;
            this.chkbxAcc.Location = new System.Drawing.Point(69, 41);
            this.chkbxAcc.Margin = new System.Windows.Forms.Padding(2);
            this.chkbxAcc.Name = "chkbxAcc";
            this.chkbxAcc.Size = new System.Drawing.Size(155, 17);
            this.chkbxAcc.TabIndex = 0;
            this.chkbxAcc.Text = "Fallecimiento por accidente";
            this.chkbxAcc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 33);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alta Poliza Hogar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TFGProyecto.Properties.Resources.Diseño_sin_título__1_;
            this.pictureBox1.Location = new System.Drawing.Point(507, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 54);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(411, 323);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 24);
            this.button1.TabIndex = 12;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msktxtbxDNI
            // 
            this.msktxtbxDNI.Location = new System.Drawing.Point(119, 323);
            this.msktxtbxDNI.Margin = new System.Windows.Forms.Padding(2);
            this.msktxtbxDNI.Mask = "00000000L";
            this.msktxtbxDNI.Name = "msktxtbxDNI";
            this.msktxtbxDNI.Size = new System.Drawing.Size(76, 20);
            this.msktxtbxDNI.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "DNI:";
            // 
            // buttonPrecio
            // 
            this.buttonPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonPrecio.Location = new System.Drawing.Point(273, 323);
            this.buttonPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrecio.Name = "buttonPrecio";
            this.buttonPrecio.Size = new System.Drawing.Size(110, 24);
            this.buttonPrecio.TabIndex = 9;
            this.buttonPrecio.Text = "Calcular Precio";
            this.buttonPrecio.UseVisualStyleBackColor = false;
            this.buttonPrecio.Click += new System.EventHandler(this.buttonPrecio_Click);
            // 
            // trabajoTableAdapter
            // 
            this.trabajoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.PolizaHogarTableAdapter = null;
            this.tableAdapterManager.TrabajoTableAdapter = this.trabajoTableAdapter;
            this.tableAdapterManager.UpdateOrder = TFGProyecto.DatabaseTFGDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // FrmPolizaVida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msktxtbxDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrecio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbcntrlVida);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPolizaVida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPolizaVida";
            this.Load += new System.EventHandler(this.FrmPolizaVida_Load);
            this.tbcntrlVida.ResumeLayout(false);
            this.tbpgCaracteristicas.ResumeLayout(false);
            this.tbpgCaracteristicas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTFGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.tbpgSalud.ResumeLayout(false);
            this.tbpgSalud.PerformLayout();
            this.tbpgEstilo.ResumeLayout(false);
            this.grbbxAct.ResumeLayout(false);
            this.grbbxAct.PerformLayout();
            this.grpbxDieta.ResumeLayout(false);
            this.grpbxDieta.PerformLayout();
            this.grpbxMal.ResumeLayout(false);
            this.grpbxMal.PerformLayout();
            this.tbpgCoberturas.ResumeLayout(false);
            this.tbpgCoberturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcntrlVida;
        private System.Windows.Forms.TabPage tbpgCaracteristicas;
        private System.Windows.Forms.TabPage tbpgSalud;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.ComboBox cmbxSexo;
        private System.Windows.Forms.TabPage tbpgEstilo;
        private System.Windows.Forms.TabPage tbpgCoberturas;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.NumericUpDown nudAlt;
        private System.Windows.Forms.NumericUpDown nudPeso;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.ComboBox cmbxOcu;
        private System.Windows.Forms.CheckBox chkbxDrogas;
        private System.Windows.Forms.CheckBox chkbxAlcohol;
        private System.Windows.Forms.CheckBox chkbxTabaco;
        private System.Windows.Forms.GroupBox grbbxAct;
        private System.Windows.Forms.GroupBox grpbxDieta;
        private System.Windows.Forms.GroupBox grpbxMal;
        private System.Windows.Forms.RadioButton rdbttnHipo;
        private System.Windows.Forms.RadioButton rdbttnHiper;
        private System.Windows.Forms.RadioButton rdbttnEqui;
        private System.Windows.Forms.RadioButton rdbttnAlta;
        private System.Windows.Forms.RadioButton rdbttnBaja;
        private System.Windows.Forms.RadioButton rdbttnMed;
        private System.Windows.Forms.CheckBox chkbxTerm;
        private System.Windows.Forms.CheckBox chkbxITP;
        private System.Windows.Forms.CheckBox chkbxAcc;
        private System.Windows.Forms.NumericUpDown nudCap;
        private System.Windows.Forms.CheckBox chkbxCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox msktxtbxDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrecio;
        private DatabaseTFGDataSet1 databaseTFGDataSet1;
        private System.Windows.Forms.BindingSource trabajoBindingSource;
        private DatabaseTFGDataSet1TableAdapters.TrabajoTableAdapter trabajoTableAdapter;
        private DatabaseTFGDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.CheckBox chkbxHema;
        private System.Windows.Forms.CheckBox chkbxGastro;
        private System.Windows.Forms.CheckBox chkbxEndo;
        private System.Windows.Forms.CheckBox chkbxInfec;
        private System.Windows.Forms.CheckBox chkbxAuto;
        private System.Windows.Forms.CheckBox chkbxNeu;
        private System.Windows.Forms.CheckBox chkbxRen;
        private System.Windows.Forms.CheckBox chkbxHepa;
        private System.Windows.Forms.CheckBox chkbxDia;
        private System.Windows.Forms.CheckBox chkbxCan;
        private System.Windows.Forms.CheckBox chkbxResp;
        private System.Windows.Forms.CheckBox chkbxCard;
    }
}