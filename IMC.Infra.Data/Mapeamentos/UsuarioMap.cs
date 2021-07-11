using IMC.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IMC.Infra.Data.Mapeamentos
{
public class UsuarioMap : MapBase<Usuario>
{
        public override void Configure(EntityTypeBuilder<Usuario> builder)
        {
            base.Configure(builder);
            builder.ToTable("Usuario");
            builder.Property(c => c.Nome).IsRequired().HasColumnName("Nome").HasMaxLength(100);
            builder.Property(c => c.Peso).IsRequired().HasColumnName("Peso");
            builder.Property(c => c.Altura).IsRequired().HasColumnName("Altura");
        }
    }
}
