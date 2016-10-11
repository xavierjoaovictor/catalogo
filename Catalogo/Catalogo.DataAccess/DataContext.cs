using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Catalogo.DataAccess.Map;

namespace Catalogo.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ConnectionStringName")
        {
        }

        public DbSet<Anuncio> Anuncios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new AnuncioMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
        }

    }
}
