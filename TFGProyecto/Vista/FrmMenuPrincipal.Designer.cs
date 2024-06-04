namespace TFGProyecto.Vista
{
    partial class FrmMenuPrincipal
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
            this.dataGridViewPolizas = new System.Windows.Forms.DataGridView();
            this.groupBoxRB = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonTV = new System.Windows.Forms.RadioButton();
            this.radioButtonZV = new System.Windows.Forms.RadioButton();
            this.radioButtonVV = new System.Windows.Forms.RadioButton();
            this.radioButtonAC = new System.Windows.Forms.RadioButton();
            this.comboBoxMayMenIgu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFilt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolizas)).BeginInit();
            this.groupBoxRB.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPolizas
            // 
            this.dataGridViewPolizas.AllowUserToAddRows = false;
            this.dataGridViewPolizas.AllowUserToDeleteRows = false;
            this.dataGridViewPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPolizas.Location = new System.Drawing.Point(58, 143);
            this.dataGridViewPolizas.Name = "dataGridViewPolizas";
            this.dataGridViewPolizas.RowHeadersWidth = 51;
            this.dataGridViewPolizas.RowTemplate.Height = 24;
            this.dataGridViewPolizas.Size = new System.Drawing.Size(687, 199);
            this.dataGridViewPolizas.TabIndex = 0;
            this.dataGridViewPolizas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPolizas_CellClick);
            // 
            // groupBoxRB
            // 
            this.groupBoxRB.Controls.Add(this.radioButtonAC);
            this.groupBoxRB.Controls.Add(this.radioButtonVV);
            this.groupBoxRB.Controls.Add(this.radioButtonZV);
            this.groupBoxRB.Controls.Add(this.radioButtonTV);
            this.groupBoxRB.Location = new System.Drawing.Point(213, 28);
            this.groupBoxRB.Name = "groupBoxRB";
            this.groupBoxRB.Size = new System.Drawing.Size(375, 65);
            this.groupBoxRB.TabIndex = 1;
            this.groupBoxRB.TabStop = false;
            this.groupBoxRB.Text = "Tipo de Filtrado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(340, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar:";
            // 
            // radioButtonTV
            // 
            this.radioButtonTV.AutoSize = true;
            this.radioButtonTV.Location = new System.Drawing.Point(130, 12);
            this.radioButtonTV.Name = "radioButtonTV";
            this.radioButtonTV.Size = new System.Drawing.Size(112, 20);
            this.radioButtonTV.TabIndex = 0;
            this.radioButtonTV.TabStop = true;
            this.radioButtonTV.Text = "Tipo Vivienda";
            this.radioButtonTV.UseVisualStyleBackColor = true;
            // 
            // radioButtonZV
            // 
            this.radioButtonZV.AutoSize = true;
            this.radioButtonZV.Location = new System.Drawing.Point(253, 13);
            this.radioButtonZV.Name = "radioButtonZV";
            this.radioButtonZV.Size = new System.Drawing.Size(115, 20);
            this.radioButtonZV.TabIndex = 1;
            this.radioButtonZV.TabStop = true;
            this.radioButtonZV.Text = "Zona Vivienda";
            this.radioButtonZV.UseVisualStyleBackColor = true;
            // 
            // radioButtonVV
            // 
            this.radioButtonVV.AutoSize = true;
            this.radioButtonVV.Location = new System.Drawing.Point(27, 38);
            this.radioButtonVV.Name = "radioButtonVV";
            this.radioButtonVV.Size = new System.Drawing.Size(116, 20);
            this.radioButtonVV.TabIndex = 2;
            this.radioButtonVV.TabStop = true;
            this.radioButtonVV.Text = "Valor Vivienda";
            this.radioButtonVV.UseVisualStyleBackColor = true;
            // 
            // radioButtonAC
            // 
            this.radioButtonAC.AutoSize = true;
            this.radioButtonAC.Location = new System.Drawing.Point(184, 38);
            this.radioButtonAC.Name = "radioButtonAC";
            this.radioButtonAC.Size = new System.Drawing.Size(119, 20);
            this.radioButtonAC.TabIndex = 3;
            this.radioButtonAC.TabStop = true;
            this.radioButtonAC.Text = "Año Construido";
            this.radioButtonAC.UseVisualStyleBackColor = true;
            // 
            // comboBoxMayMenIgu
            // 
            this.comboBoxMayMenIgu.FormattingEnabled = true;
            this.comboBoxMayMenIgu.Items.AddRange(new object[] {
            "Mayor",
            "Menor",
            "Igual"});
            this.comboBoxMayMenIgu.Location = new System.Drawing.Point(624, 69);
            this.comboBoxMayMenIgu.Name = "comboBoxMayMenIgu";
            this.comboBoxMayMenIgu.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMayMenIgu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "En caso numerico\r\nseleccionar:";
            // 
            // buttonFilt
            // 
            this.buttonFilt.Location = new System.Drawing.Point(368, 363);
            this.buttonFilt.Name = "buttonFilt";
            this.buttonFilt.Size = new System.Drawing.Size(75, 23);
            this.buttonFilt.TabIndex = 6;
            this.buttonFilt.Text = "Filtrar";
            this.buttonFilt.UseVisualStyleBackColor = true;
            this.buttonFilt.Click += new System.EventHandler(this.buttonFilt_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFilt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMayMenIgu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBoxRB);
            this.Controls.Add(this.dataGridViewPolizas);
            this.Name = "FrmMenuPrincipal";
            this.Text = "FrmMenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolizas)).EndInit();
            this.groupBoxRB.ResumeLayout(false);
            this.groupBoxRB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPolizas;
        private System.Windows.Forms.GroupBox groupBoxRB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonAC;
        private System.Windows.Forms.RadioButton radioButtonVV;
        private System.Windows.Forms.RadioButton radioButtonZV;
        private System.Windows.Forms.RadioButton radioButtonTV;
        private System.Windows.Forms.ComboBox comboBoxMayMenIgu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFilt;
    }
}