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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InicializarDataGridViews()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = 4;
            dataGridView2.ColumnCount = 4;
            dataGridView2.RowCount = 4;
            dataGridViewResult.ColumnCount = 4;
            dataGridViewResult.RowCount = 4;
        }

        private int[,] LeerMatriz(DataGridView dataGridView)
        {
            int[,] matriz = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = Convert.ToInt32(dataGridView[j, i].Value);
                }
            }
            return matriz;
        }

        private void MostrarMatriz(int[,] matriz, DataGridView dataGridView)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dataGridView[j, i].Value = matriz[i, j];
                }
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int[,] matriz1 = LeerMatriz(dataGridView1);
            int[,] matriz2 = LeerMatriz(dataGridView2);
            int[,] resultado = Operacion.SumarMatrices(matriz1, matriz2);
            MostrarMatriz(resultado, dataGridViewResult);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int[,] matriz1 = LeerMatriz(dataGridView1);
            int[,] matriz2 = LeerMatriz(dataGridView2);
            int[,] resultado = Operacion.MultiplicarMatrices(matriz1, matriz2);
            MostrarMatriz(resultado, dataGridViewResult);
        }
    }
}
