using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Catalogo.DataAccess.Map
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");
            HasKey(x => x.UsuarioId);
            Property(x => x.Email).IsRequired().HasMaxLength(150);
            Property(u => u.Senha).HasMaxLength(20).IsRequired();
        }
    }
}
