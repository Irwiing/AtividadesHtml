using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFramewokMVC.Models
{
    public class Periferico
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Tipo { get; set; }
        public decimal Preco { get; set; }
    }
}