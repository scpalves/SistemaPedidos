using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedidos.Dominio
{
    class Categoria
    {
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public List<Produto> Produto { get; set; }


        public Categoria(int IdCategoria, string NomeCategoria)
        {
            this.IdCategoria = IdCategoria;
            this.NomeCategoria = NomeCategoria;
            this.Produto = new List<Produto>();
        }



        public void addProduto(Produto p)
        {
            Produto.Add(p);
            //turma.Sort();
        }

        public override string ToString()
        {
            return IdCategoria
            + "-Caregoria "
            + NomeCategoria;
        }
    
    }
}
