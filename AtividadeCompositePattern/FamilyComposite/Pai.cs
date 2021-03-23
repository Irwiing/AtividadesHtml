using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyComposite
{
    public class Pai : Familia
    {
        protected List<Familia> _filho = new List<Familia>();

        public override void Add(Familia familia)
        {
            this._filho.Add(familia);
        }

        public override void Remove(Familia familia)
        {
            this._filho.Remove(familia);
        }

        public override string Operation()
        {
            int i = 0;
            string result = $"{Nome}(";

            foreach (Familia familia in this._filho)
            {
                result += familia.Operation();
                if (i != this._filho.Count - 1)
                {
                    result += "+";
                }
                i++;
            }

            return result + ")";
        }
    }
}
