﻿namespace Ejercicio1
{
    partial class Operaciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.tbPrimerNumero = new System.Windows.Forms.TextBox();
            this.tbSegundoNumero = new System.Windows.Forms.TextBox();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la operacion a realizar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el Primer Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese el Segundo Numero:";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.cmbOperacion.Location = new System.Drawing.Point(386, 20);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(95, 28);
            this.cmbOperacion.TabIndex = 3;
            // 
            // tbPrimerNumero
            // 
            this.tbPrimerNumero.Location = new System.Drawing.Point(322, 92);
            this.tbPrimerNumero.Name = "tbPrimerNumero";
            this.tbPrimerNumero.Size = new System.Drawing.Size(111, 31);
            this.tbPrimerNumero.TabIndex = 4;
            // 
            // tbSegundoNumero
            // 
            this.tbSegundoNumero.Location = new System.Drawing.Point(338, 146);
            this.tbSegundoNumero.Name = "tbSegundoNumero";
            this.tbSegundoNumero.Size = new System.Drawing.Size(111, 31);
            this.tbSegundoNumero.TabIndex = 5;
            // 
            // btnRealizar
            // 
            this.btnRealizar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRealizar.Location = new System.Drawing.Point(30, 212);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(174, 75);
            this.btnRealizar.TabIndex = 6;
            this.btnRealizar.Text = "Realizar Operacion";
            this.btnRealizar.UseVisualStyleBackColor = false;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(243, 234);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(238, 31);
            this.tbResultado.TabIndex = 7;
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(522, 348);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(this.tbSegundoNumero);
            this.Controls.Add(this.tbPrimerNumero);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MingLiU-ExtB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Operaciones";
            this.Text = "Operaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.TextBox tbPrimerNumero;
        private System.Windows.Forms.TextBox tbSegundoNumero;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.TextBox tbResultado;
    }
}

