namespace TFGProyecto.Vista
{
    partial class FrmMenuEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuEmpleado));
            this.buttonFilt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxMay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxRB = new System.Windows.Forms.GroupBox();
            this.rdbttnSalario = new System.Windows.Forms.RadioButton();
            this.rdbttnPuesto = new System.Windows.Forms.RadioButton();
            this.radioButtonNom = new System.Windows.Forms.RadioButton();
            this.rdbttnApellido1 = new System.Windows.Forms.RadioButton();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarionickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaContrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseTFGDataSet1 = new TFGProyecto.DatabaseTFGDataSet1();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.polizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vidaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.hogarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizaHogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbxFiltro = new System.Windows.Forms.GroupBox();
            this.cmbxPuesto = new System.Windows.Forms.ComboBox();
            this.puestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nudSal = new System.Windows.Forms.NumericUpDown();
            this.txtbxGen = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new TFGProyecto.DatabaseTFGDataSet1TableAdapters.TableAdapterManager();
            this.puestosTableAdapter = new TFGProyecto.DatabaseTFGDataSet1TableAdapters.PuestosTableAdapter();
            this.empleadoTableAdapter = new TFGProyecto.DatabaseTFGDataSet1TableAdapters.EmpleadoTableAdapter();
            this.groupBoxRB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTFGDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSal)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFilt
            // 
            this.buttonFilt.Location = new System.Drawing.Point(206, 331);
            this.buttonFilt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFilt.Name = "buttonFilt";
            this.buttonFilt.Size = new System.Drawing.Size(56, 19);
            this.buttonFilt.TabIndex = 13;
            this.buttonFilt.Text = "Filtrar";
            this.buttonFilt.UseVisualStyleBackColor = true;
            this.buttonFilt.Click += new System.EventHandler(this.buttonFilt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(466, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Numerico:";
            // 
            // cmbxMay
            // 
            this.cmbxMay.FormattingEnabled = true;
            this.cmbxMay.Items.AddRange(new object[] {
            "Mayor",
            "Igual",
            "Menor"});
            this.cmbxMay.Location = new System.Drawing.Point(468, 92);
            this.cmbxMay.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxMay.Name = "cmbxMay";
            this.cmbxMay.Size = new System.Drawing.Size(92, 21);
            this.cmbxMay.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(197, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar:";
            // 
            // groupBoxRB
            // 
            this.groupBoxRB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBoxRB.Controls.Add(this.rdbttnSalario);
            this.groupBoxRB.Controls.Add(this.rdbttnPuesto);
            this.groupBoxRB.Controls.Add(this.radioButtonNom);
            this.groupBoxRB.Controls.Add(this.rdbttnApellido1);
            this.groupBoxRB.Location = new System.Drawing.Point(160, 58);
            this.groupBoxRB.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxRB.Name = "groupBoxRB";
            this.groupBoxRB.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxRB.Size = new System.Drawing.Size(281, 53);
            this.groupBoxRB.TabIndex = 8;
            this.groupBoxRB.TabStop = false;
            this.groupBoxRB.Text = "Tipo de Filtrado";
            this.groupBoxRB.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxRB_Paint);
            // 
            // rdbttnSalario
            // 
            this.rdbttnSalario.AutoSize = true;
            this.rdbttnSalario.Location = new System.Drawing.Point(200, 31);
            this.rdbttnSalario.Margin = new System.Windows.Forms.Padding(2);
            this.rdbttnSalario.Name = "rdbttnSalario";
            this.rdbttnSalario.Size = new System.Drawing.Size(57, 17);
            this.rdbttnSalario.TabIndex = 4;
            this.rdbttnSalario.TabStop = true;
            this.rdbttnSalario.Text = "Salario";
            this.rdbttnSalario.UseVisualStyleBackColor = true;
            this.rdbttnSalario.CheckedChanged += new System.EventHandler(this.rdbttnSalario_CheckedChanged);
            // 
            // rdbttnPuesto
            // 
            this.rdbttnPuesto.AutoSize = true;
            this.rdbttnPuesto.Location = new System.Drawing.Point(46, 31);
            this.rdbttnPuesto.Margin = new System.Windows.Forms.Padding(2);
            this.rdbttnPuesto.Name = "rdbttnPuesto";
            this.rdbttnPuesto.Size = new System.Drawing.Size(58, 17);
            this.rdbttnPuesto.TabIndex = 3;
            this.rdbttnPuesto.TabStop = true;
            this.rdbttnPuesto.Text = "Puesto";
            this.rdbttnPuesto.UseVisualStyleBackColor = true;
            this.rdbttnPuesto.CheckedChanged += new System.EventHandler(this.rdbttnPuesto_CheckedChanged);
            // 
            // radioButtonNom
            // 
            this.radioButtonNom.AutoSize = true;
            this.radioButtonNom.Location = new System.Drawing.Point(95, 10);
            this.radioButtonNom.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNom.Name = "radioButtonNom";
            this.radioButtonNom.Size = new System.Drawing.Size(62, 17);
            this.radioButtonNom.TabIndex = 1;
            this.radioButtonNom.TabStop = true;
            this.radioButtonNom.Text = "Nombre";
            this.radioButtonNom.UseVisualStyleBackColor = true;
            this.radioButtonNom.CheckedChanged += new System.EventHandler(this.radioButtonNom_CheckedChanged);
            // 
            // rdbttnApellido1
            // 
            this.rdbttnApellido1.AutoSize = true;
            this.rdbttnApellido1.Location = new System.Drawing.Point(183, 10);
            this.rdbttnApellido1.Margin = new System.Windows.Forms.Padding(2);
            this.rdbttnApellido1.Name = "rdbttnApellido1";
            this.rdbttnApellido1.Size = new System.Drawing.Size(94, 17);
            this.rdbttnApellido1.TabIndex = 0;
            this.rdbttnApellido1.TabStop = true;
            this.rdbttnApellido1.Text = "Primer Apellido";
            this.rdbttnApellido1.UseVisualStyleBackColor = true;
            this.rdbttnApellido1.CheckedChanged += new System.EventHandler(this.rdbttnApellido1_CheckedChanged);
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.AllowUserToAddRows = false;
            this.dataGridViewEmpleados.AllowUserToDeleteRows = false;
            this.dataGridViewEmpleados.AutoGenerateColumns = false;
            this.dataGridViewEmpleados.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usuarionickDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellido1DataGridViewTextBoxColumn,
            this.apellido2DataGridViewTextBoxColumn,
            this.fechaNacDataGridViewTextBoxColumn,
            this.fechaContrDataGridViewTextBoxColumn,
            this.puestoDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dataGridViewEmpleados.DataSource = this.empleadoBindingSource;
            this.dataGridViewEmpleados.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(44, 152);
            this.dataGridViewEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.RowHeadersWidth = 51;
            this.dataGridViewEmpleados.RowTemplate.Height = 24;
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(515, 162);
            this.dataGridViewEmpleados.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // usuarionickDataGridViewTextBoxColumn
            // 
            this.usuarionickDataGridViewTextBoxColumn.DataPropertyName = "usuario_nick";
            this.usuarionickDataGridViewTextBoxColumn.HeaderText = "usuario_nick";
            this.usuarionickDataGridViewTextBoxColumn.Name = "usuarionickDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellido1DataGridViewTextBoxColumn
            // 
            this.apellido1DataGridViewTextBoxColumn.DataPropertyName = "apellido1";
            this.apellido1DataGridViewTextBoxColumn.HeaderText = "apellido1";
            this.apellido1DataGridViewTextBoxColumn.Name = "apellido1DataGridViewTextBoxColumn";
            // 
            // apellido2DataGridViewTextBoxColumn
            // 
            this.apellido2DataGridViewTextBoxColumn.DataPropertyName = "apellido2";
            this.apellido2DataGridViewTextBoxColumn.HeaderText = "apellido2";
            this.apellido2DataGridViewTextBoxColumn.Name = "apellido2DataGridViewTextBoxColumn";
            // 
            // fechaNacDataGridViewTextBoxColumn
            // 
            this.fechaNacDataGridViewTextBoxColumn.DataPropertyName = "fechaNac";
            this.fechaNacDataGridViewTextBoxColumn.HeaderText = "fechaNac";
            this.fechaNacDataGridViewTextBoxColumn.Name = "fechaNacDataGridViewTextBoxColumn";
            // 
            // fechaContrDataGridViewTextBoxColumn
            // 
            this.fechaContrDataGridViewTextBoxColumn.DataPropertyName = "fechaContr";
            this.fechaContrDataGridViewTextBoxColumn.HeaderText = "fechaContr";
            this.fechaContrDataGridViewTextBoxColumn.Name = "fechaContrDataGridViewTextBoxColumn";
            // 
            // puestoDataGridViewTextBoxColumn
            // 
            this.puestoDataGridViewTextBoxColumn.DataPropertyName = "puesto";
            this.puestoDataGridViewTextBoxColumn.HeaderText = "puesto";
            this.puestoDataGridViewTextBoxColumn.Name = "puestoDataGridViewTextBoxColumn";
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "salario";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.databaseTFGDataSet1;
            // 
            // databaseTFGDataSet1
            // 
            this.databaseTFGDataSet1.DataSetName = "DatabaseTFGDataSet1";
            this.databaseTFGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(2, 4);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(55, 59);
            this.buttonMenu.TabIndex = 15;
            this.buttonMenu.Text = "________________________";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem1,
            this.polizasToolStripMenuItem,
            this.clientesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem2});
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            // 
            // altaToolStripMenuItem2
            // 
            this.altaToolStripMenuItem2.Name = "altaToolStripMenuItem2";
            this.altaToolStripMenuItem2.Size = new System.Drawing.Size(95, 22);
            this.altaToolStripMenuItem2.Text = "Alta";
            this.altaToolStripMenuItem2.Click += new System.EventHandler(this.altaToolStripMenuItem2_Click);
            // 
            // polizasToolStripMenuItem
            // 
            this.polizasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vidaToolStripMenuItem1,
            this.hogarToolStripMenuItem1});
            this.polizasToolStripMenuItem.Name = "polizasToolStripMenuItem";
            this.polizasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.polizasToolStripMenuItem.Text = "Polizas";
            // 
            // vidaToolStripMenuItem1
            // 
            this.vidaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem4,
            this.menuToolStripMenuItem4});
            this.vidaToolStripMenuItem1.Name = "vidaToolStripMenuItem1";
            this.vidaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.vidaToolStripMenuItem1.Text = "Vida";
            // 
            // altaToolStripMenuItem4
            // 
            this.altaToolStripMenuItem4.Name = "altaToolStripMenuItem4";
            this.altaToolStripMenuItem4.Size = new System.Drawing.Size(105, 22);
            this.altaToolStripMenuItem4.Text = "Alta";
            this.altaToolStripMenuItem4.Click += new System.EventHandler(this.altaToolStripMenuItem4_Click);
            // 
            // menuToolStripMenuItem4
            // 
            this.menuToolStripMenuItem4.Name = "menuToolStripMenuItem4";
            this.menuToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.menuToolStripMenuItem4.Text = "Menu";
            this.menuToolStripMenuItem4.Click += new System.EventHandler(this.menuToolStripMenuItem4_Click);
            // 
            // hogarToolStripMenuItem1
            // 
            this.hogarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem3,
            this.menuToolStripMenuItem3});
            this.hogarToolStripMenuItem1.Name = "hogarToolStripMenuItem1";
            this.hogarToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.hogarToolStripMenuItem1.Text = "Hogar";
            // 
            // altaToolStripMenuItem3
            // 
            this.altaToolStripMenuItem3.Name = "altaToolStripMenuItem3";
            this.altaToolStripMenuItem3.Size = new System.Drawing.Size(105, 22);
            this.altaToolStripMenuItem3.Text = "Alta";
            this.altaToolStripMenuItem3.Click += new System.EventHandler(this.altaToolStripMenuItem3_Click);
            // 
            // menuToolStripMenuItem3
            // 
            this.menuToolStripMenuItem3.Name = "menuToolStripMenuItem3";
            this.menuToolStripMenuItem3.Size = new System.Drawing.Size(105, 22);
            this.menuToolStripMenuItem3.Text = "Menu";
            this.menuToolStripMenuItem3.Click += new System.EventHandler(this.menuToolStripMenuItem3_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem5});
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // menuToolStripMenuItem5
            // 
            this.menuToolStripMenuItem5.Name = "menuToolStripMenuItem5";
            this.menuToolStripMenuItem5.Size = new System.Drawing.Size(105, 22);
            this.menuToolStripMenuItem5.Text = "Menu";
            this.menuToolStripMenuItem5.Click += new System.EventHandler(this.menuToolStripMenuItem5_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // polizaHogarToolStripMenuItem
            // 
            this.polizaHogarToolStripMenuItem.Name = "polizaHogarToolStripMenuItem";
            this.polizaHogarToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.polizaHogarToolStripMenuItem.Text = "Polizas";
            // 
            // vidaToolStripMenuItem
            // 
            this.vidaToolStripMenuItem.Name = "vidaToolStripMenuItem";
            this.vidaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vidaToolStripMenuItem.Text = "Vida";
            // 
            // hogarToolStripMenuItem
            // 
            this.hogarToolStripMenuItem.Name = "hogarToolStripMenuItem";
            this.hogarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hogarToolStripMenuItem.Text = "Hogar";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.altaToolStripMenuItem.Text = "Alta";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // altaToolStripMenuItem1
            // 
            this.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            this.altaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.altaToolStripMenuItem1.Text = "Alta";
            // 
            // menuToolStripMenuItem1
            // 
            this.menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            this.menuToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.menuToolStripMenuItem1.Text = "Menu";
            // 
            // buttonAct
            // 
            this.buttonAct.Location = new System.Drawing.Point(328, 331);
            this.buttonAct.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAct.Name = "buttonAct";
            this.buttonAct.Size = new System.Drawing.Size(56, 19);
            this.buttonAct.TabIndex = 17;
            this.buttonAct.Text = "Actualizar";
            this.buttonAct.UseVisualStyleBackColor = true;
            this.buttonAct.Click += new System.EventHandler(this.buttonAct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Menu Empleado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // grbxFiltro
            // 
            this.grbxFiltro.Controls.Add(this.cmbxPuesto);
            this.grbxFiltro.Controls.Add(this.nudSal);
            this.grbxFiltro.Controls.Add(this.txtbxGen);
            this.grbxFiltro.Location = new System.Drawing.Point(245, 116);
            this.grbxFiltro.Name = "grbxFiltro";
            this.grbxFiltro.Size = new System.Drawing.Size(203, 34);
            this.grbxFiltro.TabIndex = 19;
            this.grbxFiltro.TabStop = false;
            // 
            // cmbxPuesto
            // 
            this.cmbxPuesto.DataSource = this.puestosBindingSource;
            this.cmbxPuesto.DisplayMember = "PuestoNombre";
            this.cmbxPuesto.FormattingEnabled = true;
            this.cmbxPuesto.Location = new System.Drawing.Point(3, 8);
            this.cmbxPuesto.Name = "cmbxPuesto";
            this.cmbxPuesto.Size = new System.Drawing.Size(121, 21);
            this.cmbxPuesto.TabIndex = 23;
            this.cmbxPuesto.ValueMember = "PuestoId";
            // 
            // puestosBindingSource
            // 
            this.puestosBindingSource.DataMember = "Puestos";
            this.puestosBindingSource.DataSource = this.databaseTFGDataSet1;
            // 
            // nudSal
            // 
            this.nudSal.Location = new System.Drawing.Point(6, 7);
            this.nudSal.Name = "nudSal";
            this.nudSal.Size = new System.Drawing.Size(120, 20);
            this.nudSal.TabIndex = 21;
            // 
            // txtbxGen
            // 
            this.txtbxGen.Location = new System.Drawing.Point(6, 8);
            this.txtbxGen.Name = "txtbxGen";
            this.txtbxGen.Size = new System.Drawing.Size(100, 20);
            this.txtbxGen.TabIndex = 20;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DietaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.PolizaHogarTableAdapter = null;
            this.tableAdapterManager.PolizaVidaTableAdapter = null;
            this.tableAdapterManager.PuestosTableAdapter = null;
            this.tableAdapterManager.TrabajoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TFGProyecto.DatabaseTFGDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // puestosTableAdapter
            // 
            this.puestosTableAdapter.ClearBeforeFill = true;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.grbxFiltro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAct);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonFilt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxMay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxRB);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMenuEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuEmpleado";
            this.Load += new System.EventHandler(this.FrmMenuCliente_Load);
            this.groupBoxRB.ResumeLayout(false);
            this.groupBoxRB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTFGDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbxFiltro.ResumeLayout(false);
            this.grbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFilt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxMay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxRB;
        private System.Windows.Forms.RadioButton rdbttnPuesto;
        private System.Windows.Forms.RadioButton radioButtonNom;
        private System.Windows.Forms.RadioButton rdbttnApellido1;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polizaHogarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hogarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem polizasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vidaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem hogarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem5;
        private System.Windows.Forms.Button buttonAct;
        private System.Windows.Forms.Label label3;
        private DatabaseTFGDataSet1 databaseTFGDataSet1;
        private DatabaseTFGDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RadioButton rdbttnSalario;
        private System.Windows.Forms.GroupBox grbxFiltro;
        private System.Windows.Forms.ComboBox cmbxPuesto;
        private System.Windows.Forms.NumericUpDown nudSal;
        private System.Windows.Forms.TextBox txtbxGen;
        private System.Windows.Forms.BindingSource puestosBindingSource;
        private DatabaseTFGDataSet1TableAdapters.PuestosTableAdapter puestosTableAdapter;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private DatabaseTFGDataSet1TableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarionickDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaContrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
    }
}