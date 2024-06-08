namespace TFGProyecto.Vista
{
    partial class FrmDetallesEmpleado
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonInserClien = new System.Windows.Forms.Button();
            this.buttonModi = new System.Windows.Forms.Button();
            this.databaseTFGDataSet1 = new TFGProyecto.DatabaseTFGDataSet1();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new TFGProyecto.DatabaseTFGDataSet1TableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new TFGProyecto.DatabaseTFGDataSet1TableAdapters.TableAdapterManager();
            this.puestosTableAdapter = new TFGProyecto.DatabaseTFGDataSet1TableAdapters.PuestosTableAdapter();
            this.puestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPagePers = new System.Windows.Forms.TabPage();
            this.msktxtbxDni = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbxPuesto = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudSal = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbxUser = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbxApellido2 = new System.Windows.Forms.TextBox();
            this.txtbxDir = new System.Windows.Forms.TextBox();
            this.txtbxApellido1 = new System.Windows.Forms.TextBox();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.mtbTel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlGen = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTFGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).BeginInit();
            this.tabPagePers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSal)).BeginInit();
            this.tabControlGen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TFGProyecto.Properties.Resources.Diseño_sin_título__1_;
            this.pictureBox1.Location = new System.Drawing.Point(506, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 62);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Alta Empleado";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(177, 333);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonInserClien
            // 
            this.buttonInserClien.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonInserClien.Location = new System.Drawing.Point(269, 333);
            this.buttonInserClien.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInserClien.Name = "buttonInserClien";
            this.buttonInserClien.Size = new System.Drawing.Size(62, 23);
            this.buttonInserClien.TabIndex = 7;
            this.buttonInserClien.Text = "Crear";
            this.buttonInserClien.UseVisualStyleBackColor = false;
            this.buttonInserClien.Click += new System.EventHandler(this.buttonInserClien_Click);
            // 
            // buttonModi
            // 
            this.buttonModi.BackColor = System.Drawing.Color.Aqua;
            this.buttonModi.Location = new System.Drawing.Point(355, 333);
            this.buttonModi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModi.Name = "buttonModi";
            this.buttonModi.Size = new System.Drawing.Size(65, 23);
            this.buttonModi.TabIndex = 11;
            this.buttonModi.Text = "Modificar";
            this.buttonModi.UseVisualStyleBackColor = false;
            this.buttonModi.Click += new System.EventHandler(this.buttonModi_Click);
            // 
            // databaseTFGDataSet1
            // 
            this.databaseTFGDataSet1.DataSetName = "DatabaseTFGDataSet1";
            this.databaseTFGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.databaseTFGDataSet1;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActividadTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.DietaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.PolizaHogarTableAdapter = null;
            this.tableAdapterManager.PolizaVidaTableAdapter = null;
            this.tableAdapterManager.PuestosTableAdapter = this.puestosTableAdapter;
            this.tableAdapterManager.TrabajoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TFGProyecto.DatabaseTFGDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // puestosTableAdapter
            // 
            this.puestosTableAdapter.ClearBeforeFill = true;
            // 
            // puestosBindingSource
            // 
            this.puestosBindingSource.DataMember = "Puestos";
            this.puestosBindingSource.DataSource = this.databaseTFGDataSet1;
            // 
            // tabPagePers
            // 
            this.tabPagePers.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPagePers.Controls.Add(this.msktxtbxDni);
            this.tabPagePers.Controls.Add(this.label9);
            this.tabPagePers.Controls.Add(this.cmbxPuesto);
            this.tabPagePers.Controls.Add(this.label10);
            this.tabPagePers.Controls.Add(this.nudSal);
            this.tabPagePers.Controls.Add(this.label8);
            this.tabPagePers.Controls.Add(this.cmbxUser);
            this.tabPagePers.Controls.Add(this.label7);
            this.tabPagePers.Controls.Add(this.txtbxApellido2);
            this.tabPagePers.Controls.Add(this.txtbxDir);
            this.tabPagePers.Controls.Add(this.txtbxApellido1);
            this.tabPagePers.Controls.Add(this.txtbxEmail);
            this.tabPagePers.Controls.Add(this.txtNombre);
            this.tabPagePers.Controls.Add(this.label16);
            this.tabPagePers.Controls.Add(this.dtpFechaNac);
            this.tabPagePers.Controls.Add(this.mtbTel);
            this.tabPagePers.Controls.Add(this.label6);
            this.tabPagePers.Controls.Add(this.label5);
            this.tabPagePers.Controls.Add(this.label4);
            this.tabPagePers.Controls.Add(this.labelFN);
            this.tabPagePers.Controls.Add(this.label2);
            this.tabPagePers.Controls.Add(this.label1);
            this.tabPagePers.Location = new System.Drawing.Point(4, 22);
            this.tabPagePers.Margin = new System.Windows.Forms.Padding(2);
            this.tabPagePers.Name = "tabPagePers";
            this.tabPagePers.Padding = new System.Windows.Forms.Padding(2);
            this.tabPagePers.Size = new System.Drawing.Size(488, 236);
            this.tabPagePers.TabIndex = 0;
            this.tabPagePers.Text = "Datos";
            this.tabPagePers.Click += new System.EventHandler(this.tabPagePers_Click);
            // 
            // msktxtbxDni
            // 
            this.msktxtbxDni.Location = new System.Drawing.Point(146, 132);
            this.msktxtbxDni.Margin = new System.Windows.Forms.Padding(2);
            this.msktxtbxDni.Mask = "00000000L";
            this.msktxtbxDni.Name = "msktxtbxDni";
            this.msktxtbxDni.Size = new System.Drawing.Size(76, 20);
            this.msktxtbxDni.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Dni";
            // 
            // cmbxPuesto
            // 
            this.cmbxPuesto.DataSource = this.puestosBindingSource;
            this.cmbxPuesto.DisplayMember = "PuestoNombre";
            this.cmbxPuesto.FormattingEnabled = true;
            this.cmbxPuesto.Location = new System.Drawing.Point(339, 202);
            this.cmbxPuesto.Name = "cmbxPuesto";
            this.cmbxPuesto.Size = new System.Drawing.Size(121, 21);
            this.cmbxPuesto.TabIndex = 25;
            this.cmbxPuesto.ValueMember = "PuestoId";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 205);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Puesto";
            // 
            // nudSal
            // 
            this.nudSal.Location = new System.Drawing.Point(137, 203);
            this.nudSal.Name = "nudSal";
            this.nudSal.Size = new System.Drawing.Size(120, 20);
            this.nudSal.TabIndex = 23;
            this.nudSal.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Salario";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmbxUser
            // 
            this.cmbxUser.DataSource = this.usuarioBindingSource;
            this.cmbxUser.DisplayMember = "clave";
            this.cmbxUser.FormattingEnabled = true;
            this.cmbxUser.Location = new System.Drawing.Point(339, 139);
            this.cmbxUser.Name = "cmbxUser";
            this.cmbxUser.Size = new System.Drawing.Size(121, 21);
            this.cmbxUser.TabIndex = 21;
            this.cmbxUser.ValueMember = "nick";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Usuario";
            // 
            // txtbxApellido2
            // 
            this.txtbxApellido2.Location = new System.Drawing.Point(146, 96);
            this.txtbxApellido2.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxApellido2.Name = "txtbxApellido2";
            this.txtbxApellido2.Size = new System.Drawing.Size(76, 20);
            this.txtbxApellido2.TabIndex = 19;
            // 
            // txtbxDir
            // 
            this.txtbxDir.Location = new System.Drawing.Point(372, 103);
            this.txtbxDir.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxDir.Name = "txtbxDir";
            this.txtbxDir.Size = new System.Drawing.Size(76, 20);
            this.txtbxDir.TabIndex = 12;
            // 
            // txtbxApellido1
            // 
            this.txtbxApellido1.Location = new System.Drawing.Point(146, 60);
            this.txtbxApellido1.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxApellido1.Name = "txtbxApellido1";
            this.txtbxApellido1.Size = new System.Drawing.Size(76, 20);
            this.txtbxApellido1.TabIndex = 11;
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Location = new System.Drawing.Point(372, 64);
            this.txtbxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(76, 20);
            this.txtbxEmail.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 24);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(76, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 99);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Apellido2";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(141, 166);
            this.dtpFechaNac.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(151, 20);
            this.dtpFechaNac.TabIndex = 15;
            // 
            // mtbTel
            // 
            this.mtbTel.Location = new System.Drawing.Point(372, 28);
            this.mtbTel.Margin = new System.Windows.Forms.Padding(2);
            this.mtbTel.Mask = "000000000";
            this.mtbTel.Name = "mtbTel";
            this.mtbTel.Size = new System.Drawing.Size(76, 20);
            this.mtbTel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo electrónico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección";
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Location = new System.Drawing.Point(35, 170);
            this.labelFN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(108, 13);
            this.labelFN.TabIndex = 2;
            this.labelFN.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tabControlGen
            // 
            this.tabControlGen.Controls.Add(this.tabPagePers);
            this.tabControlGen.Location = new System.Drawing.Point(34, 70);
            this.tabControlGen.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlGen.Name = "tabControlGen";
            this.tabControlGen.SelectedIndex = 0;
            this.tabControlGen.Size = new System.Drawing.Size(496, 262);
            this.tabControlGen.TabIndex = 6;
            // 
            // FrmDetallesEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonInserClien);
            this.Controls.Add(this.tabControlGen);
            this.Controls.Add(this.buttonModi);
            this.Name = "FrmDetallesEmpleado";
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTFGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puestosBindingSource)).EndInit();
            this.tabPagePers.ResumeLayout(false);
            this.tabPagePers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSal)).EndInit();
            this.tabControlGen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonInserClien;
        private System.Windows.Forms.Button buttonModi;
        private DatabaseTFGDataSet1 databaseTFGDataSet1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DatabaseTFGDataSet1TableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private DatabaseTFGDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DatabaseTFGDataSet1TableAdapters.PuestosTableAdapter puestosTableAdapter;
        private System.Windows.Forms.BindingSource puestosBindingSource;
        private System.Windows.Forms.TabPage tabPagePers;
        private System.Windows.Forms.ComboBox cmbxPuesto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudSal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbxUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbxApellido2;
        private System.Windows.Forms.TextBox txtbxDir;
        private System.Windows.Forms.TextBox txtbxApellido1;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.MaskedTextBox mtbTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlGen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox msktxtbxDni;
    }
}