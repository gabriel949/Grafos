using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafo
{
    class Program
    {




        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de vértices : ");
            int vertice = int.Parse(Console.ReadLine());
            grafos matriz = new grafos(vertice);

            int opcao = 0;


            while (opcao != 4)
            {
                Console.Clear();
                Console.WriteLine("1 - Criar arestas.");
                Console.WriteLine("2 - Remover aresta.");
                Console.WriteLine("3 - Mostrar Grafo.");
                Console.WriteLine("4 - Sair.");
                Console.Write("Escolha uma opção : ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {

                    case 1:

                        Console.Clear();
                        Console.WriteLine(" Digite as vertices que terão arestas");
                        Console.WriteLine(" ====================================");
                        Console.Write("\n\n Vertice 1 : ");
                        int vertice1 = int.Parse(Console.ReadLine());
                        Console.Write("\n\n Vertice 2 : ");
                        int vertice2 = int.Parse(Console.ReadLine());


                        matriz.arestas(vertice1, vertice2);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine(" Digite as vertices que terão arestas removidas");
                        Console.WriteLine(" ==============================================");
                        Console.Write("\n\n Vertice 1 : ");
                        int verticeRemover1 = int.Parse(Console.ReadLine());
                        Console.Write("\n\n Vertice 2 : ");
                        int verticeRemover2 = int.Parse(Console.ReadLine());


                        matriz.removerAresstas(verticeRemover1, verticeRemover2);

                        break;

                    case 3:
                        Console.Clear();
                        matriz.mostrar(vertice);
                        break;


                }

            }



        }
    }


}
