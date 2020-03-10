﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder
                .HasKey(f => f.id);

            builder
                .Property(f => f.nome)
                .IsRequired();

            builder
                .Property(f => f.descricao)
                .IsRequired()
                .HasMaxLength(100);
               


        }
    }
}
