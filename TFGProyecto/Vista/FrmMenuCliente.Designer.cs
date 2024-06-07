namespace TFGProyecto.Vista
{
    partial class FrmMenuCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuCliente));
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
            this.dataGridViewCLientes = new System.Windows.Forms.DataGridView();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizaHogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.polizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vidaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hogarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAct = new System.Windows.Forms.Button();
            this.groupBoxRB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCLientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFilt
            // 
            this.buttonFilt.Location = new System.Drawing.Point(274, 382);
            this.buttonFilt.Name = "buttonFilt";
            this.buttonFilt.Size = new System.Drawing.Size(75, 23);
            this.buttonFilt.TabIndex = 13;
            this.buttonFilt.Text = "Filtrar";
            this.buttonFilt.UseVisualStyleBackColor = true;
            this.buttonFilt.Click += new System.EventHandler(this.buttonFilt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Seleccione tipo de accion\r\n";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Polizas",
            "Modificar"});
            this.comboBoxTipo.Location = new System.Drawing.Point(623, 88);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTipo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 22);
            this.textBox1.TabIndex = 9;
            // 
            // groupBoxRB
            // 
            this.groupBoxRB.Controls.Add(this.radioButtonCiudad);
            this.groupBoxRB.Controls.Add(this.radioButtonTel);
            this.groupBoxRB.Controls.Add(this.radioButtonNom);
            this.groupBoxRB.Controls.Add(this.radioButtonDni);
            this.groupBoxRB.Location = new System.Drawing.Point(212, 47);
            this.groupBoxRB.Name = "groupBoxRB";
            this.groupBoxRB.Size = new System.Drawing.Size(375, 65);
            this.groupBoxRB.TabIndex = 8;
            this.groupBoxRB.TabStop = false;
            this.groupBoxRB.Text = "Tipo de Filtrado";
            // 
            // radioButtonCiudad
            // 
            this.radioButtonCiudad.AutoSize = true;
            this.radioButtonCiudad.Location = new System.Drawing.Point(184, 38);
            this.radioButtonCiudad.Name = "radioButtonCiudad";
            this.radioButtonCiudad.Size = new System.Drawing.Size(71, 20);
            this.radioButtonCiudad.TabIndex = 3;
            this.radioButtonCiudad.TabStop = true;
            this.radioButtonCiudad.Text = "Ciudad";
            this.radioButtonCiudad.UseVisualStyleBackColor = true;
            // 
            // radioButtonTel
            // 
            this.radioButtonTel.AutoSize = true;
            this.radioButtonTel.Location = new System.Drawing.Point(27, 38);
            this.radioButtonTel.Name = "radioButtonTel";
            this.radioButtonTel.Size = new System.Drawing.Size(82, 20);
            this.radioButtonTel.TabIndex = 2;
            this.radioButtonTel.TabStop = true;
            this.radioButtonTel.Text = "Telefono";
            this.radioButtonTel.UseVisualStyleBackColor = true;
            // 
            // radioButtonNom
            // 
            this.radioButtonNom.AutoSize = true;
            this.radioButtonNom.Location = new System.Drawing.Point(253, 13);
            this.radioButtonNom.Name = "radioButtonNom";
            this.radioButtonNom.Size = new System.Drawing.Size(77, 20);
            this.radioButtonNom.TabIndex = 1;
            this.radioButtonNom.TabStop = true;
            this.radioButtonNom.Text = "Nombre";
            this.radioButtonNom.UseVisualStyleBackColor = true;
            // 
            // radioButtonDni
            // 
            this.radioButtonDni.AutoSize = true;
            this.radioButtonDni.Location = new System.Drawing.Point(130, 12);
            this.radioButtonDni.Name = "radioButtonDni";
            this.radioButtonDni.Size = new System.Drawing.Size(48, 20);
            this.radioButtonDni.TabIndex = 0;
            this.radioButtonDni.TabStop = true;
            this.radioButtonDni.Text = "Dni";
            this.radioButtonDni.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCLientes
            // 
            this.dataGridViewCLientes.AllowUserToAddRows = false;
            this.dataGridViewCLientes.AllowUserToDeleteRows = false;
            this.dataGridViewCLientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCLientes.Location = new System.Drawing.Point(57, 162);
            this.dataGridViewCLientes.Name = "dataGridViewCLientes";
            this.dataGridViewCLientes.RowHeadersWidth = 51;
            this.dataGridViewCLientes.RowTemplate.Height = 24;
            this.dataGridViewCLientes.Size = new System.Drawing.Size(687, 199);
            this.dataGridViewCLientes.TabIndex = 7;
            this.dataGridViewCLientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPolizas_CellClick);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(1, 6);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(73, 73);
            this.buttonMenu.TabIndex = 15;
            this.buttonMenu.Text = "________________________";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
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
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem2,
            this.menuToolStripMenuItem2});
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(97, 26);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            // 
            // altaToolStripMenuItem2
            // 
            this.altaToolStripMenuItem2.Name = "altaToolStripMenuItem2";
            this.altaToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.altaToolStripMenuItem2.Text = "Alta";
            // 
            // menuToolStripMenuItem2
            // 
            this.menuToolStripMenuItem2.Name = "menuToolStripMenuItem2";
            this.menuToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.menuToolStripMenuItem2.Text = "Menu";
            // 
            // polizasToolStripMenuItem
            // 
            this.polizasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vidaToolStripMenuItem1,
            this.hogarToolStripMenuItem1});
            this.polizasToolStripMenuItem.Name = "polizasToolStripMenuItem";
            this.polizasToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.polizasToolStripMenuItem.Text = "Polizas";
            // 
            // vidaToolStripMenuItem1
            // 
            this.vidaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem4,
            this.menuToolStripMenuItem4});
            this.vidaToolStripMenuItem1.Name = "vidaToolStripMenuItem1";
            this.vidaToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.vidaToolStripMenuItem1.Text = "Vida";
            // 
            // hogarToolStripMenuItem1
            // 
            this.hogarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem3,
            this.menuToolStripMenuItem3});
            this.hogarToolStripMenuItem1.Name = "hogarToolStripMenuItem1";
            this.hogarToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.hogarToolStripMenuItem1.Text = "Hogar";
            // 
            // altaToolStripMenuItem3
            // 
            this.altaToolStripMenuItem3.Name = "altaToolStripMenuItem3";
            this.altaToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.altaToolStripMenuItem3.Text = "Alta";
            this.altaToolStripMenuItem3.Click += new System.EventHandler(this.altaToolStripMenuItem3_Click);
            // 
            // menuToolStripMenuItem3
            // 
            this.menuToolStripMenuItem3.Name = "menuToolStripMenuItem3";
            this.menuToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.menuToolStripMenuItem3.Text = "Menu";
            this.menuToolStripMenuItem3.Click += new System.EventHandler(this.menuToolStripMenuItem3_Click);
            // 
            // altaToolStripMenuItem4
            // 
            this.altaToolStripMenuItem4.Name = "altaToolStripMenuItem4";
            this.altaToolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.altaToolStripMenuItem4.Text = "Alta";
            this.altaToolStripMenuItem4.Click += new System.EventHandler(this.altaToolStripMenuItem4_Click);
            // 
            // menuToolStripMenuItem4
            // 
            this.menuToolStripMenuItem4.Name = "menuToolStripMenuItem4";
            this.menuToolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.menuToolStripMenuItem4.Text = "Menu";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem5,
            this.menuToolStripMenuItem5});
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(75, 26);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // altaToolStripMenuItem5
            // 
            this.altaToolStripMenuItem5.Name = "altaToolStripMenuItem5";
            this.altaToolStripMenuItem5.Size = new System.Drawing.Size(224, 26);
            this.altaToolStripMenuItem5.Text = "Alta";
            this.altaToolStripMenuItem5.Click += new System.EventHandler(this.altaToolStripMenuItem5_Click);
            // 
            // menuToolStripMenuItem5
            // 
            this.menuToolStripMenuItem5.Name = "menuToolStripMenuItem5";
            this.menuToolStripMenuItem5.Size = new System.Drawing.Size(224, 26);
            this.menuToolStripMenuItem5.Text = "Menu";
            this.menuToolStripMenuItem5.Click += new System.EventHandler(this.menuToolStripMenuItem5_Click);
            // 
            // buttonAct
            // 
            this.buttonAct.Location = new System.Drawing.Point(436, 382);
            this.buttonAct.Name = "buttonAct";
            this.buttonAct.Size = new System.Drawing.Size(75, 23);
            this.buttonAct.TabIndex = 17;
            this.buttonAct.Text = "Actualizar";
            this.buttonAct.UseVisualStyleBackColor = true;
            this.buttonAct.Click += new System.EventHandler(this.buttonAct_Click);
            // 
            // FrmMenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAct);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonFilt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBoxRB);
            this.Controls.Add(this.dataGridViewCLientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuCliente";
            this.Text = "FrmMenuCliente";
            this.Load += new System.EventHandler(this.FrmMenuCliente_Load);
            this.groupBoxRB.ResumeLayout(false);
            this.groupBoxRB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCLientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridViewCLientes;
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
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem2;
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
    }
}