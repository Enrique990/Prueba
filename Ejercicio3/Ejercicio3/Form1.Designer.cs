namespace Ejercicio3
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbValor1 = new System.Windows.Forms.TextBox();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.lblOperacion2 = new System.Windows.Forms.Label();
            this.tbValor2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(47, 196);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(113, 55);
            this.btnSumar.TabIndex = 3;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Location = new System.Drawing.Point(385, 196);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(113, 59);
            this.btnMultiplicar.TabIndex = 4;
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese los valores de la matriz";
            // 
            // tbValor1
            // 
            this.tbValor1.Location = new System.Drawing.Point(47, 129);
            this.tbValor1.Name = "tbValor1";
            this.tbValor1.Size = new System.Drawing.Size(142, 30);
            this.tbValor1.TabIndex = 7;
            this.tbValor1.TextChanged += new System.EventHandler(this.tbValor1_TextChanged);
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(42, 83);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(0, 25);
            this.lblPosicion.TabIndex = 8;
            // 
            // lblOperacion2
            // 
            this.lblOperacion2.AutoSize = true;
            this.lblOperacion2.Location = new System.Drawing.Point(380, 83);
            this.lblOperacion2.Name = "lblOperacion2";
            this.lblOperacion2.Size = new System.Drawing.Size(0, 25);
            this.lblOperacion2.TabIndex = 10;
            // 
            // tbValor2
            // 
            this.tbValor2.Location = new System.Drawing.Point(385, 129);
            this.tbValor2.Name = "tbValor2";
            this.tbValor2.Size = new System.Drawing.Size(142, 30);
            this.tbValor2.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(47, 276);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 204);
            this.listBox1.TabIndex = 11;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(363, 276);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(164, 204);
            this.listBox2.TabIndex = 12;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 25;
            this.listBox3.Location = new System.Drawing.Point(634, 95);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(288, 354);
            this.listBox3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Resultado";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(221, 119);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(115, 51);
            this.btnIngresar.TabIndex = 15;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(986, 494);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblOperacion2);
            this.Controls.Add(this.tbValor2);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.tbValor1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSumar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Operaciones con Matrices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbValor1;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label lblOperacion2;
        private System.Windows.Forms.TextBox tbValor2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIngresar;
    }

    #endregion
}

