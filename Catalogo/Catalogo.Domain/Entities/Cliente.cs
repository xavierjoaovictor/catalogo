using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Entities
{
    public class Cliente : Usuario
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public virtual ICollection<Anuncio> Anuncios { get; set; } = new List<Anuncio>();

    }
}
