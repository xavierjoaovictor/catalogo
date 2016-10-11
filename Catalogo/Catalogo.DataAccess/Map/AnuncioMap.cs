using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Catalogo.DataAccess.Map
{
    public class AnuncioMap : EntityTypeConfiguration<Anuncio>
    {
        public AnuncioMap()
        {
            ToTable("Anuncio");

            //Definida a propriedade AnuncioId como chave primária
            HasKey(x => x.AnuncioId);

            //Descricao terá no máximo 200 caracteres e será um campo "NOT NULL"
            Property(x => x.Descricao).HasMaxLength(200).IsRequired();
            
            //Data inicial deve ser diferente de null
            Property(x => x.DataInicial).IsRequired();

            //Anuncio deve ter um cliente
            HasRequired(x => x.Cliente).WithMany(x => x.Anuncios).Map(m => m.MapKey("ClienteId"));
        }
    }
}
