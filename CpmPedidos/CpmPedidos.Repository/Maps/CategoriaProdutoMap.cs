using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CpmPedidos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CpmPedidos.Repository.Maps
{
    public class CategoriaProdutoMap : BaseDomainMap<CategoriaProduto>
    {
        CategoriaProdutoMap() : base("tb_categoria_produto") { }
        public override void Configure(EntityTypeBuilder<CategoriaProduto> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo").IsRequired();
        }

    }
}
