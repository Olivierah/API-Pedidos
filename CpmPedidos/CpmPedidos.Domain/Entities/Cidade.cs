using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CpmPedidos.Domain.Interfaces;

namespace CpmPedidos.Domain.Entities
{
    public class Cidade : BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public string UF { get; set; }

        public bool Ativo { get; set; }
    }
}
