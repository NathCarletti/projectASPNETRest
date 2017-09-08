namespace projectASPNET.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using projectASPNET.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<projectASPNET.Models.projectASPNETContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(projectASPNET.Models.projectASPNETContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Products.AddOrUpdate(
                p => p.Id,
                new Product
                {
                    Id = 1,
                    Nome = "produto 1",
                    Descricao = "descri��o produto 1",
                    Color = "azul",
                    Modelo = "ford fiesta",
                    Codigo = "COD1",
                    Preco = 10,
                    URLimagem = "http://www.itavema.com.br/admin/dir_fotos/21/new-fiesta-2014.jpg" 
                },
                new Product
                {
                    Id = 2,
                    Nome = "produto 2",
                    Descricao = "descri��o produto 1",
                    Color = "verde",
                    Modelo = "honda civic",
                    Codigo = "COD2",
                    Preco = 20
                },
                new Product
                {
                    Id = 3,
                    Nome = "produto 3",
                    Descricao = "descri��o produto 1",
                    Color = "vemelho",
                    Modelo = "agile",
                    Codigo = "COD3",
                    Preco = 30
                }
                );
        }
    }
}
