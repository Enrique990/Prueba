using Ejercicio1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Operaciones : Form
    {
        Calculadora calculadora = new Calculadora();
        public Operaciones()
        {
            InitializeComponent();
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbOperacion.SelectedItem == null)
                {
                    MessageBox.Show("Please select an operation.", "Error");
                    return;
                }
                string operacion = cmbOperacion.SelectedItem.ToString();
                double resultado = 0;

                double numero1 = Convert.ToInt32(tbPrimerNumero.Text);
                double numero2 = Convert.ToInt32(tbSegundoNumero.Text);

                switch (operacion)
                {
                    case "+":
                        resultado = calculadora.Sumar(numero1, numero2);
                        break;
                    case "-":
                        resultado = calculadora.Restar(numero1, numero2);
                        break;
                    case "x":
                        resultado = calculadora.Multiplicar(numero1, numero2);
                        break;
                    case "/":
                        resultado = calculadora.Dividir(numero1, numero2);
                        break;
                }
                tbPrimerNumero.Clear();
                tbSegundoNumero.Clear();
                cmbOperacion.SelectedIndex = -1;


                tbResultado.Text = "El resultado es: " + resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
                return;
            }
        }
    }
}
