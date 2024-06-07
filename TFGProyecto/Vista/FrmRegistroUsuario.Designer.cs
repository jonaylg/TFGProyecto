using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTFG
{
    partial class FrmRegistroUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxClave2 = new System.Windows.Forms.TextBox();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.textBoxPregPers = new System.Windows.Forms.TextBox();
            this.textBoxRespuesta = new System.Windows.Forms.TextBox();
            this.textBoxRespuesta2 = new System.Windows.Forms.TextBox();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonAyuda = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetir Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pregunta Personal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Respuesta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Repetir Respuesta";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(318, 81);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(125, 22);
            this.textBoxUsuario.TabIndex = 6;
            // 
            // textBoxClave2
            // 
            this.textBoxClave2.Location = new System.Drawing.Point(318, 160);
            this.textBoxClave2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClave2.Name = "textBoxClave2";
            this.textBoxClave2.Size = new System.Drawing.Size(125, 22);
            this.textBoxClave2.TabIndex = 7;
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(318, 121);
            this.textBoxClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.Size = new System.Drawing.Size(125, 22);
            this.textBoxClave.TabIndex = 8;
            // 
            // textBoxPregPers
            // 
            this.textBoxPregPers.Location = new System.Drawing.Point(318, 199);
            this.textBoxPregPers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPregPers.Name = "textBoxPregPers";
            this.textBoxPregPers.Size = new System.Drawing.Size(316, 22);
            this.textBoxPregPers.TabIndex = 9;
            // 
            // textBoxRespuesta
            // 
            this.textBoxRespuesta.Location = new System.Drawing.Point(318, 239);
            this.textBoxRespuesta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRespuesta.Name = "textBoxRespuesta";
            this.textBoxRespuesta.Size = new System.Drawing.Size(125, 22);
            this.textBoxRespuesta.TabIndex = 10;
            // 
            // textBoxRespuesta2
            // 
            this.textBoxRespuesta2.Location = new System.Drawing.Point(318, 281);
            this.textBoxRespuesta2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRespuesta2.Name = "textBoxRespuesta2";
            this.textBoxRespuesta2.Size = new System.Drawing.Size(125, 22);
            this.textBoxRespuesta2.TabIndex = 11;
            // 
            // buttonCrear
            // 
            this.buttonCrear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.Location = new System.Drawing.Point(556, 261);
            this.buttonCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(99, 42);
            this.buttonCrear.TabIndex = 12;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = false;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click_1);
            // 
            // buttonAyuda
            // 
            this.buttonAyuda.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonAyuda.Location = new System.Drawing.Point(278, 198);
            this.buttonAyuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAyuda.Name = "buttonAyuda";
            this.buttonAyuda.Size = new System.Drawing.Size(28, 32);
            this.buttonAyuda.TabIndex = 13;
            this.buttonAyuda.Text = "?";
            this.buttonAyuda.UseVisualStyleBackColor = false;
            this.buttonAyuda.Click += new System.EventHandler(this.buttonAyuda_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 41);
            this.label7.TabIndex = 14;
            this.label7.Text = "Crea Un Nuevo Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TFGProyecto.Properties.Resources.Diseño_sin_título__1_;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonAyuda);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.textBoxRespuesta2);
            this.Controls.Add(this.textBoxRespuesta);
            this.Controls.Add(this.textBoxPregPers);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.textBoxClave2);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistroUsuario";
            this.Load += new System.EventHandler(this.FrmRegistroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxUsuario;
        private TextBox textBoxClave2;
        private TextBox textBoxClave;
        private TextBox textBoxPregPers;
        private TextBox textBoxRespuesta;
        private TextBox textBoxRespuesta2;
        private Button buttonCrear;
        private Button buttonAyuda;
        private Label label7;
        private PictureBox pictureBox1;
    }
}