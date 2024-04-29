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
            label1 = new Label();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            textBoxClave = new TextBox();
            buttonEntrar = new Button();
            buttonOlvClave = new Button();
            buttonRegistro = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 129);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 209);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 1;
            label2.Text = "Clave";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(338, 126);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(125, 27);
            textBoxUsuario.TabIndex = 2;
            // 
            // textBoxClave
            // 
            textBoxClave.Location = new Point(338, 206);
            textBoxClave.Name = "textBoxClave";
            textBoxClave.Size = new Size(125, 27);
            textBoxClave.TabIndex = 3;
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(353, 343);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(94, 29);
            buttonEntrar.TabIndex = 4;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // buttonOlvClave
            // 
            buttonOlvClave.BackColor = SystemColors.Highlight;
            buttonOlvClave.ForeColor = SystemColors.ControlLightLight;
            buttonOlvClave.Location = new Point(303, 264);
            buttonOlvClave.Name = "buttonOlvClave";
            buttonOlvClave.Size = new Size(208, 29);
            buttonOlvClave.TabIndex = 5;
            buttonOlvClave.Text = "¿Has olvidado la clave?";
            buttonOlvClave.UseVisualStyleBackColor = false;
            buttonOlvClave.Click += buttonOlvClave_Click;
            // 
            // buttonRegistro
            // 
            buttonRegistro.Location = new Point(652, 41);
            buttonRegistro.Name = "buttonRegistro";
            buttonRegistro.Size = new Size(94, 57);
            buttonRegistro.TabIndex = 6;
            buttonRegistro.Text = "Registrarse";
            buttonRegistro.UseVisualStyleBackColor = true;
            buttonRegistro.Click += buttonRegistro_Click;
            // 
            // FrmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegistro);
            Controls.Add(buttonOlvClave);
            Controls.Add(buttonEntrar);
            Controls.Add(textBoxClave);
            Controls.Add(textBoxUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmInicioSesion";
            Text = "FrmInicioSesion";
            ResumeLayout(false);
            PerformLayout();
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