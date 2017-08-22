using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafo
{
    class grafos
    {
        public int[,] matriz;

        public grafos(int tamanho)
        {
            matriz = new int[tamanho, tamanho];
        }


        public void arestas(int a, int b)
        {
            matriz[a - 1, b - 1] = 1;
            matriz[b - 1, a - 1] = 1;

        }

        public void removerAresstas(int a,int b)
        {
            matriz[a - 1, b - 1] = 0;
            matriz[b - 1, a - 1] = 0;
        }

        public void mostrar(int a)
        {
            int cont = 0;

            Console.WriteLine();
            Console.WriteLine();
            

            for (int i = 1; i < a+1; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("  "+i+" ");
                
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                cont++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(cont);

                for (int j = 0; j < a; j++)
                {
                    
                    Console.ForegroundColor = ConsoleColor.White;
                    if (matriz[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write("  " + matriz[i, j] + " ");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }



    }
}
