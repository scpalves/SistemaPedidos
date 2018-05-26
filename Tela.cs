using SistemaPedidos.Dominio;
using StandAutomoveis.Dominio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedidos
{
    class Tela
    {
        public static void Menu()
        {

            System.Console.WriteLine("1 - Listar Categorias");
            System.Console.WriteLine("2 - Listar Produtos ordenadamente p/ categoria");
            System.Console.WriteLine("3 - Registar Pedidos");
            System.Console.WriteLine("4 - Mostrar Pedidos");
            System.Console.WriteLine("5 - Registar matricula");
            System.Console.WriteLine("6 - Listar matriculas/Alunos");
            System.Console.WriteLine("7 - Inserir Notas");
            System.Console.WriteLine("8 - Mostrar Notas Alunos");
            System.Console.WriteLine("9 - Sair");
            System.Console.WriteLine("Selcecione uma opção: ");


        }
        public static void mostrarCategorias()
        {
            Console.WriteLine("Listagem de Categorias: ");

            for (int i = 0; i < Program.categoria.Count(); i++)
            {
                Console.WriteLine(Program.categoria[i]);
            }
        }

        public static void mostrarProdutos()
        {
            Console.Write("Insira codigo da categoria: ");
            int IdCatego = int.Parse(Console.ReadLine());
            int pos = Program.categoria.FindIndex(x => x.IdCategoria == IdCatego);
            if (pos == -1)
            {
                throw new ModelExpecetion("Código do curso não encontrado " + IdCatego);
            }

            Console.WriteLine("Produtos " + Program.categoria[pos].NomeCategoria + ":");
            List<Produto> lista = Program.categoria[pos].Produto;
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine();
        }

        public static void RegistarPedidos()
        {




            Console.WriteLine("Registe a morada do cliente: ");

            Console.Write("Código morada: ");
            int IdMorada = int.Parse(Console.ReadLine());

            Console.Write("Rua: ");
            string rua = Console.ReadLine();

            Console.Write("Localidade: ");
            string localidade = Console.ReadLine();


            Morada morada = new Morada(IdMorada, rua, localidade);



            Console.WriteLine("Registe os dados do cliente: ");

            Console.Write("Código Cliente: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Nome Cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Email Cliente: ");
            string email = Console.ReadLine();


            Cliente cliente = new Cliente(codigo, nome, email, morada);



            Console.Write("Quantos pedidos?: ");
            int P = int.Parse(Console.ReadLine());


            for (int i = 1; i <= P; i++)
            {
                Console.Write("Digite os dados do " + i + "º item:");

                Console.Write("Código: ");
                int codigoPedido = int.Parse(Console.ReadLine());

                Console.Write("Dia: ");
                int dia = int.Parse(Console.ReadLine());

                Console.Write("Mês: ");
                int mes = int.Parse(Console.ReadLine());

                Console.Write("Ano: ");
                int ano = int.Parse(Console.ReadLine());


                Pedido pedido = new Pedido(codigoPedido, dia, mes, ano, cliente);


                Console.Write("Quantos itens tem o pedido?: ");
                int N = int.Parse(Console.ReadLine());


                for (int e = 1; e <= N; e++)
                {
                    Console.Write("Digite os dados do " + e + "º item:");
                    Console.Write("produto (codigo): ");
                    int CodProduto = int.Parse(Console.ReadLine());
                    int pos = Program.produto.FindIndex(x => x.IdProduto == CodProduto);
                    if (pos == -1)
                    {
                        throw new ModelExpecetion("Código de produto não encontrado " + CodProduto);
                    }
                    Console.Write("Quantidade: ");
                    int qte = int.Parse(Console.ReadLine());

                    Console.Write("Percentagem de desconto: ");
                    double desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                    ItemPedido itemPedido = new ItemPedido(desconto, qte, Program.produto[pos].Preco, pedido, Program.produto[pos]);
                    pedido.itens.Add(itemPedido);


                    Console.Write("Pagamento será feito em cartão ou referência (C/R)? ");
                    char ch = char.Parse(Console.ReadLine());
                    if (ch == 'c')
                    {
                        Console.Write("Referência ");
                        int parcela = int.Parse(Console.ReadLine());


                        Pagamento c = new PagamentoCartao(parcela, EstadoPagamento.Aceite);

                        pedido.pagamento.Add(c);

                        Console.WriteLine(c);
                    }
                    else
                    {
                        Console.Write("Dia: ");
                        int day = int.Parse(Console.ReadLine());

                        Console.Write("Mês: ");
                        int mon = int.Parse(Console.ReadLine());

                        Console.Write("Ano: ");
                        int year = int.Parse(Console.ReadLine());


                        Pagamento r = new PagamentoReferencia(day, mon, year, EstadoPagamento.Aceite);

                        pedido.pagamento.Add(r);

                        Console.WriteLine(r);



                    }

                    Program.Pedido.Add(pedido);

                }


            }
        }
        public static void MostrarPedidos()
        {
            Console.Write("Insira codigo do pedido?: ");
            int codPedido = int.Parse(Console.ReadLine());
            int pos = Program.Pedido.FindIndex(x => x.IdPedido == codPedido);
            if (pos == -1)
            {
                throw new ModelExpecetion("Código de pedido não encontrado " + codPedido);
            }
            Console.WriteLine(Program.Pedido[pos]);

            Console.WriteLine();
        }



    }


}
