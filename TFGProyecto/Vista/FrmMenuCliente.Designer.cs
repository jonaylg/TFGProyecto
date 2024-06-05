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
            this.groupBoxRB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCLientes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFilt
            // 
            this.buttonFilt.Location = new System.Drawing.Point(367, 382);
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
            // FrmMenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFilt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBoxRB);
            this.Controls.Add(this.dataGridViewCLientes);
            this.Name = "FrmMenuCliente";
            this.Text = "FrmMenuCliente";
            this.Load += new System.EventHandler(this.FrmMenuCliente_Load);
            this.groupBoxRB.ResumeLayout(false);
            this.groupBoxRB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCLientes)).EndInit();
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
    }
}