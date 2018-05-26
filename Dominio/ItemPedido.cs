using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedidos.Dominio
{
    class ItemPedido
    {
        public double Desconto { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }

        public ItemPedido(double Desconto, int Quantidade, double Preco, Pedido Pedido, Produto Produto)
        {
            this.Desconto = Desconto;
            this.Quantidade = Quantidade;
            this.Preco = Preco;
            this.Pedido = Pedido;
            this.Produto = Produto;

        }


        public double subTotal()
        {

            double desconto = Produto.Preco * Desconto / 100;

            return (Produto.Preco - desconto) * Quantidade;

        }

        public override string ToString()
        {
            return  "Desconto: " + Desconto + "\n"
            + "Quantidade: "
            + Quantidade + "\n"
            + "Nome Produto: "
            + Produto.NomeProduto + "\n"
            +"Categoria: "
            + Produto.categoria.NomeCategoria + "\n"
            + "Preço: "
            + Preco + "\n"
            + "SubTotal "
            + subTotal().ToString("F2", CultureInfo.InvariantCulture);


        }
    }
}
