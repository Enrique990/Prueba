using Ejercicio3.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        Operacion operacion = new Operacion();
        int[,] matriz1 = new int[4, 4];
        int[,] matriz2 = new int[4, 4];
        public Form1()
        {
            InitializeComponent();
            tbValor1.Clear();
            leerMatriz1();
    

        }
        

        private void leerMatriz1()
        {
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (int.TryParse(tbValor1.Text, out int numero))
                    {
                        matriz1[i, j] = numero;
                        tbValor1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un número válido.");
                        return;
                    }
                    tbValor1.Clear();
                }
            }
            
            

        }

        private void leerMatriz2()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    lblOperacion2.Text = $"Ingrese el valor de la posición {i + 1}, {j + 1}";
                    matriz2[i, j] = Convert.ToInt32(tbValor1.Text);
                    tbValor2.Clear();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



      

       

        private void btnSumar_Click(object sender, EventArgs e)
        {
           
            int[,] resultado = operacion.SumarMatrices(matriz1, matriz2);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    listBox1.Items.Add(matriz1[i, j]);
                    listBox2.Items.Add(matriz2[i, j]);
                    listBox3.Items.Add(resultado[i, j]);
                }
            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            leerMatriz1();
            leerMatriz2();
        }

        private void tbValor1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
