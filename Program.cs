using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_5_practica_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numero;

            numero = new int[3, 3];
            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.WriteLine("Digite un numero");
                    numero[fila, col] = Convert.ToInt32(Console.ReadLine());

                }

            }
            Console.Clear();

            for (int fila = 0; fila  < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(" " + numero[fila, col]);

                }
                Console.WriteLine();

            }



            Console.ReadLine();

        }
    }
}
