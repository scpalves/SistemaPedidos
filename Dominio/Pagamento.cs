using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedidos.Dominio
{
    abstract class Pagamento
    {

        public  EstadoPagamento EstadoPagamento { get; set; }

        public  Pagamento(EstadoPagamento EstadoPagamento)
        {
            this.EstadoPagamento = EstadoPagamento;
        }


    }
}