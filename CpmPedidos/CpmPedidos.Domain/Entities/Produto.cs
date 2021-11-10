using CpmPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Domain.Entities
{
    public class Produto : BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public int IdCategoriaProduto { get; set; }
        public virtual CategoriaProduto CategoriaProduto { get; set; }

        public List<Imagem> Imagens { get; set; }

        public bool Ativo { get; set; }
    }
}
