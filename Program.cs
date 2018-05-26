using SistemaPedidos.Dominio;
using StandAutomoveis.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedidos
{
    class Program
    {


        public static List<Categoria> categoria = new List<Categoria>();

        public static List<Produto> produto = new List<Produto>();

        public static List<Pedido> Pedido = new List<Pedido>();


        public static List<Cliente> Cliente = new List<Cliente>();


        static void Main(string[] args)
        {
            int opcao = 0;


            Categoria c1 = new Categoria(1, "Europoupança");
            Categoria c2 = new Categoria(2, "Regular");
            Categoria c3 = new Categoria(3, "Groumet");

          

            //produto.Sort();


            Produto p1 = new Produto(1001, "Cheese", 1.00, c1);
            c1.addProduto(p1);
            Produto p2 = new Produto(1002, "Big Mac", 3.50, c2);
            c2.addProduto(p2);
            Produto p3 = new Produto(1003, "Double", 2.00, c2);
            c2.addProduto(p3);
            Produto p4 = new Produto(1004, "Nuggets4", 1.50, c1);
            c1.addProduto(p4);
            Produto p5 = new Produto(1005, "Big Tasty", 4.00, c3);
            c3.addProduto(p5);

            categoria.Add(c1);
            categoria.Add(c2);
            categoria.Add(c3);

            produto.Add(p1);
            produto.Add(p2);
            produto.Add(p3);
            produto.Add(p4);
            produto.Add(p5);
 


            while (opcao != 9)
            {
                Console.Clear();
                Tela.Menu();
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }
                Console.WriteLine();

                if (opcao == 1)
                {
                    Tela.mostrarCategorias();
                }
                else if (opcao == 2)
                {
                    Tela.mostrarProdutos();
                }
                else if (opcao == 3)
                {
                    try
                    {
                        Tela.RegistarPedidos();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 4)
                {
                    try
                    {
                        Tela.MostrarPedidos();
                    }
                    catch (ModelExpecetion e)
                    {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 5)
                {
                    try
                    {
                        //Tela.RegistarMatriculas();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 6)
                {
                    try
                    {
                        //Tela.mostrarMatriculas();
                    }
                    catch (ModelExpecetion e)
                    {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 7)
                {
                    try
                    {
                        //Tela.RegistarNotas();
                    }
                    catch (ModelExpecetion e)
                    {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 8)
                {
                    try
                    {
                        //Tela.mostrarNotas();
                    }
                    catch (ModelExpecetion e)
                    {
                        Console.WriteLine("Erro de negócio: " + e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado: " + e.Message);
                    }
                }
                else if (opcao == 9)
                {
                    Console.WriteLine("Fim do programa!");
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
