using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTFG
{
    partial class FrmInicioSesion
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
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.buttonOlvClave = new System.Windows.Forms.Button();
            this.buttonRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(338, 101);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(125, 22);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(338, 165);
            this.textBoxClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.Size = new System.Drawing.Size(125, 22);
            this.textBoxClave.TabIndex = 3;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(353, 274);
            this.buttonEntrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(94, 23);
            this.buttonEntrar.TabIndex = 4;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click_1);
            // 
            // buttonOlvClave
            // 
            this.buttonOlvClave.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOlvClave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOlvClave.Location = new System.Drawing.Point(303, 211);
            this.buttonOlvClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOlvClave.Name = "buttonOlvClave";
            this.buttonOlvClave.Size = new System.Drawing.Size(208, 23);
            this.buttonOlvClave.TabIndex = 5;
            this.buttonOlvClave.Text = "¿Has olvidado la clave?";
            this.buttonOlvClave.UseVisualStyleBackColor = false;
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.Location = new System.Drawing.Point(652, 33);
            this.buttonRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegistro.Name = "buttonRegistro";
            this.buttonRegistro.Size = new System.Drawing.Size(94, 46);
            this.buttonRegistro.TabIndex = 6;
            this.buttonRegistro.Text = "Registrarse";
            this.buttonRegistro.UseVisualStyleBackColor = true;
            this.buttonRegistro.Click += new System.EventHandler(this.buttonRegistro_Click_1);
            // 
            // FrmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.buttonRegistro);
            this.Controls.Add(this.buttonOlvClave);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmInicioSesion";
            this.Text = "FrmInicioSesion";
            this.Load += new System.EventHandler(this.FrmInicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUsuario;
        private TextBox textBoxClave;
        private Button buttonEntrar;
        private Button buttonOlvClave;
        private Button buttonRegistro;
    }
}