using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedidos.Dominio
{
    class Cliente
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string Email { get; set; }
        public TipoCliente TipoCliente { get; set; }
        public List<Pedido> Pedido { get; set; }
        public Morada Morada { get; set; }

        public Cliente(int IdCliente, string NomeCliente, string Email, Morada Morada)
        {
            this.IdCliente = IdCliente;
            this.NomeCliente = NomeCliente;
            this.Email = Email;
            this.Morada = Morada;
            this.Pedido = new List<Pedido>();
        }


        public override string ToString()
        {
            return IdCliente
            + "Nome Cliente "
            + NomeCliente
             + "Email "
            + Email;
        }
        
    }

}
