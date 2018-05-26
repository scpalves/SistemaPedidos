using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPedidos.Dominio
{
    class Morada
    {
        public int IdMorada { get; set; }

        public string Rua { get; set; }

        public string Localidade { get; set; }

        

        public Morada(int IdMorada, string Rua, string Localidade)
        {
            this.IdMorada = IdMorada;
            this.Rua = Rua;
            this.Localidade = Localidade;
         
        }


        public override string ToString()
        {
            return IdMorada
            + "Rua "
            + Rua
            +"Localidade "
            + Localidade;
        }

    }
}
