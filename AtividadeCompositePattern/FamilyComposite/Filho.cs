using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyComposite
{
    public class Filho : Familia
    {
        
        public override string Operation()
        {
            return Nome;
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
