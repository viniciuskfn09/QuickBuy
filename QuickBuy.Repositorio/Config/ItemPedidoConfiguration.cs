using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<itemPedido>
    {
        public void Configure(EntityTypeBuilder<itemPedido> builder)
        {
            builder.HasKey(i => i.ID);
            builder
                .Property(i => i.ProdutoID)
                .IsRequired();

            builder
                .Property(i => i.Quantidade)
                .IsRequired();

            
                 


                
               


        }
    }
}
