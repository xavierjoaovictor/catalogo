namespace Catalogo.DataAccess.Migrations
{
    using Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Catalogo.DataAccess.DataContext>
    {
        protected override void Seed(Catalogo.DataAccess.DataContext context)
        {
            Anuncio anun1 = new Anuncio();
            anun1.Descricao = "Anuncio 1";
            anun1.DataInicial = DateTime.Now;
            

            //Anuncio anun2 = new Anuncio();
            //anun2.Descricao = "Anuncio 2";
            //anun2.DataInicial = DateTime.Now;

            //Anuncio anun3 = new Anuncio();
            //anun3.Descricao = "Anuncio 3";
            //anun3.DataInicial = DateTime.Now;

            //Anuncio anun4 = new Anuncio();
            //anun4.Descricao = "Anuncio 4";
            //anun4.DataInicial = DateTime.Now;

            Cliente cli1 = new Cliente();
            cli1.Nome = "Cliente 1";
            cli1.Telefone = "98769898";
            //cli1.Anuncios.Add(anun1);
            //cli1.Anuncios.Add(anun2);
            cli1.Anuncios = new List<Anuncio>() { anun1 };

            //Cliente cli2 = new Cliente();
            //cli2.Nome = "Cliente 2";
            //cli2.Telefone = "98769899";
            //cli1.Anuncios.Add(anun3);
            //cli1.Anuncios.Add(anun4);

            context.Clientes.Add(cli1);
            //context.Clientes.Add(cli2);
            context.SaveChanges();
        }
    }
}
