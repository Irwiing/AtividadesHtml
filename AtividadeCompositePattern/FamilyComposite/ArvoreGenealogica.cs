using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyComposite
{
    public class ArvoreGenealogica
    {
        public void ArvoreFamilia(Familia filho)
        {
            Console.WriteLine($"RESULT: {filho.Operation()}\n");
        }

        // Thanks to the fact that the child-management operations are declared
        // in the base Component class, the client code can work with any
        // component, simple or complex, without depending on their concrete
        // classes.
        public void ArvoreFamilia2(Familia familia1, Familia familia2)
        {
            Console.WriteLine($"RESULT: {familia1.Operation()} + {familia2.Operation()}");
        }
    }
}
