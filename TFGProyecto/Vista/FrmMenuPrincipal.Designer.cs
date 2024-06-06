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
            this.radioButtonAC = new System.Windows.Forms.RadioButton();
            this.radioButtonVV = new System.Windows.Forms.RadioButton();
            this.radioButtonZV = new System.Windows.Forms.RadioButton();
            this.radioButtonTV = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMayMenIgu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFilt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizaHogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizaVidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolizas)).BeginInit();
            this.groupBoxRB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPolizas
            // 
            this.dataGridViewPolizas.AllowUserToAddRows = false;
            this.dataGridViewPolizas.AllowUserToDeleteRows = false;
            this.dataGridViewPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPolizas.Location = new System.Drawing.Point(58, 172);
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
            this.groupBoxRB.Location = new System.Drawing.Point(201, 59);
            this.groupBoxRB.Name = "groupBoxRB";
            this.groupBoxRB.Size = new System.Drawing.Size(375, 65);
            this.groupBoxRB.TabIndex = 1;
            this.groupBoxRB.TabStop = false;
            this.groupBoxRB.Text = "Tipo de Filtrado";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar:";
            // 
            // comboBoxMayMenIgu
            // 
            this.comboBoxMayMenIgu.FormattingEnabled = true;
            this.comboBoxMayMenIgu.Items.AddRange(new object[] {
            "Mayor",
            "Menor",
            "Igual"});
            this.comboBoxMayMenIgu.Location = new System.Drawing.Point(612, 100);
            this.comboBoxMayMenIgu.Name = "comboBoxMayMenIgu";
            this.comboBoxMayMenIgu.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMayMenIgu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "En caso numerico\r\nseleccionar:";
            // 
            // buttonFilt
            // 
            this.buttonFilt.Location = new System.Drawing.Point(371, 388);
            this.buttonFilt.Name = "buttonFilt";
            this.buttonFilt.Size = new System.Drawing.Size(75, 23);
            this.buttonFilt.TabIndex = 6;
            this.buttonFilt.Text = "Filtrar";
            this.buttonFilt.UseVisualStyleBackColor = true;
            this.buttonFilt.Click += new System.EventHandler(this.buttonFilt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TFGProyecto.Properties.Resources.Diseño_sin_título__1_;
            this.pictureBox1.Location = new System.Drawing.Point(79, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(0, 0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(73, 73);
            this.buttonMenu.TabIndex = 8;
            this.buttonMenu.Text = "________________________";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.polizaHogarToolStripMenuItem,
            this.polizaVidaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 9;
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
            this.polizaHogarToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.polizaHogarToolStripMenuItem.Text = "Poliza Hogar";
            // 
            // polizaVidaToolStripMenuItem
            // 
            this.polizaVidaToolStripMenuItem.Name = "polizaVidaToolStripMenuItem";
            this.polizaVidaToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.polizaVidaToolStripMenuItem.Text = "Poliza Vida";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonFilt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMayMenIgu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBoxRB);
            this.Controls.Add(this.dataGridViewPolizas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuPrincipal";
            this.Text = "FrmMenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPolizas)).EndInit();
            this.groupBoxRB.ResumeLayout(false);
            this.groupBoxRB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polizaHogarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polizaVidaToolStripMenuItem;
    }
}