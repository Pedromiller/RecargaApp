using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecargaApp.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecargaApp.Infra.Data.Mappings
{
    public class EstacaoRecargaMapping : IEntityTypeConfiguration<EstacaoRecarga>
    {
        public void Configure(EntityTypeBuilder<EstacaoRecarga> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)                
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.HasCheckConstraint("CK_EstacaoRecarga_Tipo", "([Tipo] = 'ESTACAOMOVEL' or [Tipo] = 'ESTACAOVEICULAR')")
                .Property(c => c.Tipo)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(c => c.Latitude)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(c => c.Longitude)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.ToTable("EstacaoRecarga");
        }
    }
}
