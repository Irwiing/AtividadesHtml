using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyComposite
{
    public class CientComposite
    {
        public static void Main()
        {
            ArvoreGenealogica arvore = new ArvoreGenealogica();

            Pai mae1 = new Pai() { Nome = "Romilda" };
            Pai mae2 = new Pai() { Nome = "Izabel" };
            Pai mae3 = new Pai() { Nome = "Ivone" };
            mae1.Add(mae2);
            mae1.Add(mae3);

            mae2.Add(new Filho { Nome = "Irwing" });

            mae3.Add(new Filho { Nome = "Julia" });
            mae3.Add(new Filho { Nome = "Zelia" });
            mae3.Add(new Filho { Nome = "Montaury" });

            arvore.ArvoreFamilia(mae1);

            Pai pai1 = new Pai() { Nome = "Luiz" };
            Pai pai2 = new Pai() { Nome = "Edson" };
            Pai pai3 = new Pai() { Nome = "Tobias" };
            pai1.Add(pai2);
            pai1.Add(pai3);

            pai2.Add(new Filho { Nome = "Irwing" });

            pai3.Add(new Filho { Nome = "Carol" });
            pai3.Add(new Filho { Nome = "Bianca" });
            pai3.Add(new Filho { Nome = "Giovana" });

            arvore.ArvoreFamilia(pai1);
            arvore.ArvoreFamilia2(mae1, pai1);

            Console.ReadKey();
        }
    }
}
