namespace TFGProyecto.Vista
{
    partial class FrmConfirmarPrecio
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
            this.buttonAccpt = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelComp1 = new System.Windows.Forms.Label();
            this.labelComp2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAccpt
            // 
            this.buttonAccpt.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonAccpt.Location = new System.Drawing.Point(431, 389);
            this.buttonAccpt.Name = "buttonAccpt";
            this.buttonAccpt.Size = new System.Drawing.Size(99, 49);
            this.buttonAccpt.TabIndex = 0;
            this.buttonAccpt.Text = "Aceptar";
            this.buttonAccpt.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightPink;
            this.button2.Location = new System.Drawing.Point(269, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Location = new System.Drawing.Point(85, 81);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelComp1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelComp2);
            this.splitContainer1.Size = new System.Drawing.Size(643, 273);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 2;
            // 
            // labelComp1
            // 
            this.labelComp1.AutoSize = true;
            this.labelComp1.Location = new System.Drawing.Point(35, 16);
            this.labelComp1.Name = "labelComp1";
            this.labelComp1.Size = new System.Drawing.Size(44, 16);
            this.labelComp1.TabIndex = 0;
            this.labelComp1.Text = "label2";
            // 
            // labelComp2
            // 
            this.labelComp2.AutoSize = true;
            this.labelComp2.Location = new System.Drawing.Point(67, 16);
            this.labelComp2.Name = "labelComp2";
            this.labelComp2.Size = new System.Drawing.Size(44, 16);
            this.labelComp2.TabIndex = 1;
            this.labelComp2.Text = "label2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(242, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // FrmConfirmarPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAccpt);
            this.Name = "FrmConfirmarPrecio";
            this.Text = "FrmConfirmarPrecio";
            this.Load += new System.EventHandler(this.FrmConfirmarPrecio_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAccpt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelComp1;
        private System.Windows.Forms.Label labelComp2;
    }
}