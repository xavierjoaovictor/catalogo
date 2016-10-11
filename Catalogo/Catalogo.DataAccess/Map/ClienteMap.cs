using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Catalogo.DataAccess.Map
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");

            HasKey(x => x.ClienteId);

            HasMany(x => x.Anuncios);

            Property(x => x.Nome).IsRequired();
            
        }
    }
}
