using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Carrinho
    {
        public int Id { get; set; }
        public DateTime DataCompra { get; set; }
        public List<Periferico> Perifericos  { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
