using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedidos.Dominio
{
    class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public double Preco { get; set; }
        public Categoria categoria { get; set; }


        public Produto(int IdProduto, string NomeProduto, double Preco, Categoria categoria)
        {
            this.IdProduto = IdProduto;
            this.NomeProduto = NomeProduto;
            this.Preco = Preco;
            this.categoria = categoria;
        }



        public override string ToString()
        {
            return IdProduto
            + ", Produto: "
            + NomeProduto
            +", Preço "
            + Preco
            +", Categoria "
            + categoria.NomeCategoria;
        }
    
    
    }
}
