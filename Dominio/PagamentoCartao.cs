using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedidos.Dominio
{
    class PagamentoCartao:Pagamento
    {
        public  int numeroParcelas { get; set; }


        public  PagamentoCartao(int numeroParcelas, EstadoPagamento EstadoPagamento)
            : base( EstadoPagamento) 
        {
            this.numeroParcelas = numeroParcelas;
            this.EstadoPagamento = EstadoPagamento;
        }


       public override string ToString()
       {
           return numeroParcelas + "\n"
           + "Estado Pagamento: "
           + EstadoPagamento;
       }
    }
}

