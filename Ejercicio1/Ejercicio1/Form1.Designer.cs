namespace Ejercicio1
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
            this.label1.Location = new System.Drawing.Point(50, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la operacion a realizar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el Primer Numero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 20);
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
            this.cmbOperacion.Location = new System.Drawing.Point(304, 20);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(86, 28);
            this.cmbOperacion.TabIndex = 3;
            // 
            // tbPrimerNumero
            // 
            this.tbPrimerNumero.Location = new System.Drawing.Point(260, 92);
            this.tbPrimerNumero.Name = "tbPrimerNumero";
            this.tbPrimerNumero.Size = new System.Drawing.Size(100, 26);
            this.tbPrimerNumero.TabIndex = 4;
            // 
            // tbSegundoNumero
            // 
            this.tbSegundoNumero.Location = new System.Drawing.Point(279, 146);
            this.tbSegundoNumero.Name = "tbSegundoNumero";
            this.tbSegundoNumero.Size = new System.Drawing.Size(100, 26);
            this.tbSegundoNumero.TabIndex = 5;
            // 
            // btnRealizar
            // 
            this.btnRealizar.Location = new System.Drawing.Point(27, 212);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(150, 48);
            this.btnRealizar.TabIndex = 6;
            this.btnRealizar.Text = "Realizar Operacion";
            this.btnRealizar.UseVisualStyleBackColor = true;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(219, 234);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(215, 26);
            this.tbResultado.TabIndex = 7;
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 348);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(this.tbSegundoNumero);
            this.Controls.Add(this.tbPrimerNumero);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Operaciones";
            this.Text = "Form1";
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

