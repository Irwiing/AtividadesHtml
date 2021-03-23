using EntityFramewokMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFramewokMVC.Dal
{
    public class PerifericoInitializer : DropCreateDatabaseIfModelChanges<PerifericoContext>
    {
        protected override void Seed(PerifericoContext context)
        {
            var Perifericos = new List<Periferico>
            {
                new Periferico{ Id = 1, Marca = "hyperX", Modelo = "Fury 4GB", Tipo = "Memoria ram", Preco = 250.00M},
                new Periferico{ Id = 2, Marca = "hyperX", Modelo = "Fury 8GB", Tipo = "Memoria ram", Preco = 300.00M}
            };

            Perifericos.ForEach(periferico => context.Perifericos.Add(periferico));
            context.SaveChanges();
        }
    }
}