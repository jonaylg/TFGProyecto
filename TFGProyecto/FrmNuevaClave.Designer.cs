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
            this.labelRespuesta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRespuesta = new System.Windows.Forms.TextBox();
            this.textBoxClave = new System.Windows.Forms.TextBox();
            this.textBoxClave2 = new System.Windows.Forms.TextBox();
            this.buttonCambiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRespuesta
            // 
            this.labelRespuesta.AutoSize = true;
            this.labelRespuesta.Location = new System.Drawing.Point(285, 91);
            this.labelRespuesta.Name = "labelRespuesta";
            this.labelRespuesta.Size = new System.Drawing.Size(188, 16);
            this.labelRespuesta.TabIndex = 0;
            this.labelRespuesta.Text = "Label que llevara la respuesta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Respuesta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetir Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nueva Clave";
            // 
            // textBoxRespuesta
            // 
            this.textBoxRespuesta.Location = new System.Drawing.Point(321, 143);
            this.textBoxRespuesta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRespuesta.Name = "textBoxRespuesta";
            this.textBoxRespuesta.Size = new System.Drawing.Size(125, 22);
            this.textBoxRespuesta.TabIndex = 4;
            // 
            // textBoxClave
            // 
            this.textBoxClave.Location = new System.Drawing.Point(321, 186);
            this.textBoxClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClave.Name = "textBoxClave";
            this.textBoxClave.Size = new System.Drawing.Size(125, 22);
            this.textBoxClave.TabIndex = 5;
            // 
            // textBoxClave2
            // 
            this.textBoxClave2.Location = new System.Drawing.Point(321, 231);
            this.textBoxClave2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxClave2.Name = "textBoxClave2";
            this.textBoxClave2.Size = new System.Drawing.Size(125, 22);
            this.textBoxClave2.TabIndex = 6;
            // 
            // buttonCambiar
            // 
            this.buttonCambiar.Location = new System.Drawing.Point(595, 188);
            this.buttonCambiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCambiar.Name = "buttonCambiar";
            this.buttonCambiar.Size = new System.Drawing.Size(94, 23);
            this.buttonCambiar.TabIndex = 7;
            this.buttonCambiar.Text = "Cambiar";
            this.buttonCambiar.UseVisualStyleBackColor = true;
            this.buttonCambiar.Click += new System.EventHandler(this.buttonCambiar_Click_1);
            // 
            // FrmNuevaClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.buttonCambiar);
            this.Controls.Add(this.textBoxClave2);
            this.Controls.Add(this.textBoxClave);
            this.Controls.Add(this.textBoxRespuesta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRespuesta);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmNuevaClave";
            this.Text = "FrmNuevaClave";
            this.Load += new System.EventHandler(this.FrmNuevaClave_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelRespuesta;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxRespuesta;
        private TextBox textBoxClave;
        private TextBox textBoxClave2;
        private Button buttonCambiar;
    }
}