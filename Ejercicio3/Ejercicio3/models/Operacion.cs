using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.models
{
    internal class Operacion
    {
        public static int[,] SumarMatrices(int[,] matriz1, int[,] matriz2)
        {
            int[,] resultado = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    resultado[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            return resultado;
        }

        public static int[,] MultiplicarMatrices(int[,] matriz1, int[,] matriz2)
        {
            int[,] resultado = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    resultado[i, j] = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        resultado[i, j] += matriz1[i, k] * matriz2[k, j];
                    }
                }
            }
            return resultado;
        }
    }
}
