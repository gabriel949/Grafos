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


            while (opcao != 8)
            {
                Console.Clear();
                Console.WriteLine("1 - Criar arestas.");
                Console.WriteLine("2 - Remover aresta.");
                Console.WriteLine("3 - Mostrar Grafo.");
                Console.WriteLine("4 - Grafo Completo.");
                Console.WriteLine("5 - Totalmente desconexo.");
                Console.WriteLine("6 - Gerar grafo completo");
                Console.WriteLine("7 - Euleriano.");
                Console.WriteLine("8 - Sair");
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

                    case 4:
                        Console.Clear();

                        if (matriz.Completo(vertice))
                        {
                            Console.WriteLine("O grafo é completo");
                        }
                        else
                        {
                            Console.WriteLine("O grafo não é completo");
                        }

                        Console.ReadLine();
                        break;

                    case 5:
                        Console.Clear();

                        if (matriz.desconexo(vertice))
                        {
                            Console.WriteLine("O grafo não é desconexo");
                        }
                        else
                        {
                            Console.WriteLine("O grafo é desconexo");
                        }

                        Console.ReadLine();
                        break;

                    case 6:
                        Console.Clear();
                        matriz.grafoCompleto(vertice);


                        break;

                    case 7:
                        Console.Clear();

                        if (matriz.desconexo(vertice))
                        {
                            Console.WriteLine("O grafo não é euleriano");
                        }
                        else
                        {
                            Console.WriteLine("O grafo é euleriano");
                        }

                        Console.ReadLine();
                        break;


                }

            }



        }
    }


}
