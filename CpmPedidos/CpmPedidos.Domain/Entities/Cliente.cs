using CpmPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Domain.Entities
{
    public class Cliente : BaseDomain, IExibivel
    {
        public int Nome { get; set; }
        public string Cpf { get; set; }

        public int IdEndereco { get; set; }
        public virtual Endereco Endereco { get; set; }

        public bool Ativo { get; set; }
    }
}
