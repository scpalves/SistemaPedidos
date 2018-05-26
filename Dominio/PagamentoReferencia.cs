using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedidos.Dominio
{
    class PagamentoReferencia:Pagamento
    {
        public  DateTime DateVencimento { get; set; }
        public  DateTime DataPagamento { get; set; }

        public  PagamentoReferencia(int dia, int mes, int ano, EstadoPagamento EstadoPagamento) 
            : base (EstadoPagamento) 
        {
            this.DateVencimento = new DateTime(ano, mes, dia);
            this.DataPagamento = new DateTime(ano, mes, dia);
            this.EstadoPagamento = EstadoPagamento;
        }

        public override string ToString()
        {
            return DateVencimento + "\n"
            + "Data Pagamento: "
            + DataPagamento + "\n"
            + "Estado Pagamento: "
            + EstadoPagamento;
        }
    }
}
