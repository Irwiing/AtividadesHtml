using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyComposite
{
    public abstract class Familia
    {
        public Familia() { }

        public string Nome { get; set; }

        public abstract string Operation();

        public virtual void Add(Familia familia)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Familia familia)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
