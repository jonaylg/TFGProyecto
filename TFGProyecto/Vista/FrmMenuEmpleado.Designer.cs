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
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxRB = new System.Windows.Forms.GroupBox();
            this.radioButtonCiudad = new System.Windows.Forms.RadioButton();
            this.radioButtonTel = new System.Windows.Forms.RadioButton();
            this.radioButtonNom = new System.Windows.Forms.RadioButton();
            this.radioButtonDni = new System.Windows.Forms.RadioButton();
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
            this.altaToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.empleadoTableAdapter = new TFGProyecto.DatabaseTFGDataSet1TableAdapters.EmpleadoTableAdapter();
            this.tableAdapterManager = new TFGProyecto.DatabaseTFGDataSet1TableAdapters.TableAdapterManager();
            this.groupBoxRB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTFGDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Seleccione tipo de accion\r\n";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Polizas",
            "Modificar"});
            this.comboBoxTipo.Location = new System.Drawing.Point(468, 92);
            this.comboBoxTipo.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTipo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(197, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 116);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 9;
            // 
            // groupBoxRB
            // 
            this.groupBoxRB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBoxRB.Controls.Add(this.radioButtonCiudad);
            this.groupBoxRB.Controls.Add(this.radioButtonTel);
            this.groupBoxRB.Controls.Add(this.radioButtonNom);
            this.groupBoxRB.Controls.Add(this.radioButtonDni);
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
            // radioButtonCiudad
            // 
            this.radioButtonCiudad.AutoSize = true;
            this.radioButtonCiudad.Location = new System.Drawing.Point(138, 31);
            this.radioButtonCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCiudad.Name = "radioButtonCiudad";
            this.radioButtonCiudad.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCiudad.TabIndex = 3;
            this.radioButtonCiudad.TabStop = true;
            this.radioButtonCiudad.Text = "Ciudad";
            this.radioButtonCiudad.UseVisualStyleBackColor = true;
            // 
            // radioButtonTel
            // 
            this.radioButtonTel.AutoSize = true;
            this.radioButtonTel.Location = new System.Drawing.Point(20, 31);
            this.radioButtonTel.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonTel.Name = "radioButtonTel";
            this.radioButtonTel.Size = new System.Drawing.Size(67, 17);
            this.radioButtonTel.TabIndex = 2;
            this.radioButtonTel.TabStop = true;
            this.radioButtonTel.Text = "Telefono";
            this.radioButtonTel.UseVisualStyleBackColor = true;
            // 
            // radioButtonNom
            // 
            this.radioButtonNom.AutoSize = true;
            this.radioButtonNom.Location = new System.Drawing.Point(190, 11);
            this.radioButtonNom.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNom.Name = "radioButtonNom";
            this.radioButtonNom.Size = new System.Drawing.Size(62, 17);
            this.radioButtonNom.TabIndex = 1;
            this.radioButtonNom.TabStop = true;
            this.radioButtonNom.Text = "Nombre";
            this.radioButtonNom.UseVisualStyleBackColor = true;
            // 
            // radioButtonDni
            // 
            this.radioButtonDni.AutoSize = true;
            this.radioButtonDni.Location = new System.Drawing.Point(98, 10);
            this.radioButtonDni.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDni.Name = "radioButtonDni";
            this.radioButtonDni.Size = new System.Drawing.Size(41, 17);
            this.radioButtonDni.TabIndex = 0;
            this.radioButtonDni.TabStop = true;
            this.radioButtonDni.Text = "Dni";
            this.radioButtonDni.UseVisualStyleBackColor = true;
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
            this.dataGridViewEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPolizas_CellClick);
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
            this.altaToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
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
            this.vidaToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
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
            this.menuToolStripMenuItem4.Size = new System.Drawing.Size(105, 22);
            this.menuToolStripMenuItem4.Text = "Menu";
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
            this.altaToolStripMenuItem5,
            this.menuToolStripMenuItem5});
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // altaToolStripMenuItem5
            // 
            this.altaToolStripMenuItem5.Name = "altaToolStripMenuItem5";
            this.altaToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.altaToolStripMenuItem5.Text = "Alta";
            this.altaToolStripMenuItem5.Click += new System.EventHandler(this.altaToolStripMenuItem5_Click);
            // 
            // menuToolStripMenuItem5
            // 
            this.menuToolStripMenuItem5.Name = "menuToolStripMenuItem5";
            this.menuToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
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
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.DietaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = this.empleadoTableAdapter;
            this.tableAdapterManager.PolizaHogarTableAdapter = null;
            this.tableAdapterManager.PolizaVidaTableAdapter = null;
            this.tableAdapterManager.TrabajoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TFGProyecto.DatabaseTFGDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // FrmMenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAct);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonFilt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFilt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxRB;
        private System.Windows.Forms.RadioButton radioButtonCiudad;
        private System.Windows.Forms.RadioButton radioButtonTel;
        private System.Windows.Forms.RadioButton radioButtonNom;
        private System.Windows.Forms.RadioButton radioButtonDni;
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
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem5;
        private System.Windows.Forms.Button buttonAct;
        private System.Windows.Forms.Label label3;
        private DatabaseTFGDataSet1 databaseTFGDataSet1;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private DatabaseTFGDataSet1TableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private DatabaseTFGDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
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