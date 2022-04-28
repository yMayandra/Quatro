
namespace Quatro
{
    partial class main
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
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.tnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(256, 68);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(100, 23);
            this.tbxNumero.TabIndex = 0;
            // 
            // tnCalcular
            // 
            this.tnCalcular.Location = new System.Drawing.Point(379, 68);
            this.tnCalcular.Name = "tnCalcular";
            this.tnCalcular.Size = new System.Drawing.Size(75, 23);
            this.tnCalcular.TabIndex = 3;
            this.tnCalcular.Text = "Clacular";
            this.tnCalcular.UseVisualStyleBackColor = true;
            this.tnCalcular.Click += new System.EventHandler(this.tnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite um número";
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblResultado.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(256, 118);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(198, 65);
            this.lblResultado.TabIndex = 5;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tnCalcular);
            this.Controls.Add(this.tbxNumero);
            this.KeyPreview = true;
            this.Name = "main";
            this.Text = "main";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.main_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.Button tnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
    }
}