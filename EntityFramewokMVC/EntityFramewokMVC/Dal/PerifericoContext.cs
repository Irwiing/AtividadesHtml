using EntityFramewokMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFramewokMVC.Dal
{
    public class PerifericoContext : DbContext
    {
        public PerifericoContext() : base("PerifericoContext")
        {
        }

        public DbSet<Periferico> Perifericos { set; get; }
    }
}