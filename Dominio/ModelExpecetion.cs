using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandAutomoveis.Dominio
{
    class ModelExpecetion:Exception
    {
        public ModelExpecetion(string msg)
            : base(msg)
        {

        }
    }
}
