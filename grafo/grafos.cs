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

        public void removerAresstas(int a, int b)
        {
            matriz[a - 1, b - 1] = 0;
            matriz[b - 1, a - 1] = 0;
        }

        public void mostrar(int a)
        {
            int cont = 0;

            Console.WriteLine();
            Console.WriteLine();


            for (int i = 1; i < a + 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t " + i );

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
                    Console.Write("\t " + matriz[i, j] );
                    Console.ForegroundColor = ConsoleColor.White;

                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public bool Completo(int a)
        {
            for (int i = 0; i < a; i++)

                for (int l = 0; l < a; l++)

                    if ((i != l) && (matriz[i, l] == 0))

                        return (false);



            return (true);

        }

        public bool desconexo(int a)
        {
            for (int i = 0; i < a; i++)

                for (int l = 0; l < a; l++)

                    if ((matriz[i, l] == 1))

                        return (true);

            return (false);

        }

        public void grafoCompleto(int a)
        {
            int[,] matriz2 = new int[a, a];
            
            int cont = 0;

            Console.WriteLine();
            Console.WriteLine();


            for (int i = 1; i < a + 1; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t " + i);

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
                        matriz2[i, j] = 0;

                    }
                    else
                    {
                        matriz2[i, j] = 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write("\t " + matriz2[i, j]);
                    Console.ForegroundColor = ConsoleColor.White;

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public bool euleriano(int a)
        {
            int cont;

            for (int i = 0; i < a; i++)
            {
                cont = 0;
                for (int l = 0; l < a; l++)
                    if ((matriz[i, l] == 1))

                        cont++;

                if ((cont % 2) == 1);
                    return (false);
            }
            return (true);
        }
    }
}
