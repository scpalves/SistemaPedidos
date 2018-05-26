using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedidos.Dominio
{
    class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public List<ItemPedido> itens { get; set; }
        public List<Pagamento> pagamento { get; set; }
        public Cliente Cliente { get; set; }
        public Pagamento Pagamento { get; set; }



        public Pedido(int IdPedido, int dia, int mes, int ano, Cliente Cliente)
        {
            this.IdPedido = IdPedido;
            this.DataPedido = new DateTime(ano, mes, dia);
            this.Cliente = Cliente;
            this.itens = new List<ItemPedido>();
            this.pagamento = new List<Pagamento>();

        }

        public Pedido(int IdPedido, int dia, int mes, int ano, Cliente Cliente, Pagamento Pagamento)
        {
            this.IdPedido = IdPedido;
            this.DataPedido = new DateTime(ano, mes, dia);
            this.Cliente = Cliente;
            this.itens = new List<ItemPedido>();
            //this.pagamento = new List<Pagamento>();
            this.Pagamento = Pagamento;
        }

        public double valorTotal()
        {

            double soma = 0.0;

            for (int i = 0; i < itens.Count; i++)
            {
                soma = soma + itens[i].subTotal();
            }
            return soma;
        }



        public override string ToString()
        {

            string s = "Pedido: " + IdPedido + "\n"
                + "Nome Cliente: "
                + Cliente.NomeCliente + "\n"
                + "Email Cliente: "
                + Cliente.Email + "\n"
                 + "Rua Cliente: "
                + Cliente.Morada.Rua + "\n"
                + "Localidade Cliente: "
                + Cliente.Morada.Localidade + "\n"
                + "Data: " + DataPedido.Day + "/" + DataPedido.Month + "/" + DataPedido.Year + "\n"
                + "Estado Pagamento: "
                + Pagamento.EstadoPagamento + "\n"
                + "Itens: ";

            for (int i = 0; i < itens.Count; i++)
            {
                s = s + itens[i] + "\n";
            }

            s = s + "Total do Pedido: " + valorTotal().ToString("F2", CultureInfo.InvariantCulture);
            return s;
        }

    }

}

