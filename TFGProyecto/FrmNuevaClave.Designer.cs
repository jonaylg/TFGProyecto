using System.Drawing;
using System.Windows.Forms;

namespace ProyectoTFG
{
    partial class FrmNuevaClave
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
            label3 = new Label();
            label4 = new Label();
            textBoxRespuesta = new TextBox();
            textBoxClave = new TextBox();
            textBoxClave2 = new TextBox();
            buttonCambiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(285, 114);
            label1.Name = "label1";
            label1.Size = new Size(205, 20);
            label1.TabIndex = 0;
            label1.Text = "Label que llevara la respuesta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 182);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Respuesta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 292);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Repetir Clave";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 235);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 3;
            label4.Text = "Nueva Clave";
            // 
            // textBoxRespuesta
            // 
            textBoxRespuesta.Location = new Point(321, 179);
            textBoxRespuesta.Name = "textBoxRespuesta";
            textBoxRespuesta.Size = new Size(125, 27);
            textBoxRespuesta.TabIndex = 4;
            // 
            // textBoxClave
            // 
            textBoxClave.Location = new Point(321, 232);
            textBoxClave.Name = "textBoxClave";
            textBoxClave.Size = new Size(125, 27);
            textBoxClave.TabIndex = 5;
            // 
            // textBoxClave2
            // 
            textBoxClave2.Location = new Point(321, 289);
            textBoxClave2.Name = "textBoxClave2";
            textBoxClave2.Size = new Size(125, 27);
            textBoxClave2.TabIndex = 6;
            // 
            // buttonCambiar
            // 
            buttonCambiar.Location = new Point(595, 235);
            buttonCambiar.Name = "buttonCambiar";
            buttonCambiar.Size = new Size(94, 29);
            buttonCambiar.TabIndex = 7;
            buttonCambiar.Text = "Cambiar";
            buttonCambiar.UseVisualStyleBackColor = true;
            buttonCambiar.Click += buttonCambiar_Click;
            // 
            // FrmNuevaClave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCambiar);
            Controls.Add(textBoxClave2);
            Controls.Add(textBoxClave);
            Controls.Add(textBoxRespuesta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmNuevaClave";
            Text = "FrmNuevaClave";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxRespuesta;
        private TextBox textBoxClave;
        private TextBox textBoxClave2;
        private Button buttonCambiar;
    }
}