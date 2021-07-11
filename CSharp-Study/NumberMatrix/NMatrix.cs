using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thermal_Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int[,] numeros = new int[3, 4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j % 2 == 0)
                    {
                        numeros[i, j] = 'p';
                    }
                    else
                    {
                        numeros[i, j] = 'i';
                    }
                    valor = numeros[i, j] ==  'p' ? "Par" : "Impar";
                    Console.Write($"Linha {i} , Coluna {j} é {valor}\n");
                }
            }
            Console.ReadKey();
        }
    }
}