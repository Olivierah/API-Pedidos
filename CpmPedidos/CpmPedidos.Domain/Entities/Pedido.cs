using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Domain.Entities
{
    public class Pedido : BaseDomain
    {
        public string  Numero { get; set; }
        public decimal ValorTotal { get; set; }
        public TimeSpan Entrega { get; set; }

        public List<ProdutoPedido> ProdutosPedidos { get; set; }
        
        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
