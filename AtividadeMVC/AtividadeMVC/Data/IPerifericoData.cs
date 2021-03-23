using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IPerifericoData
    {
        bool Insert(Periferico periferico);
        bool Update(Periferico periferico);
        bool Delete(int id);
        List<Periferico> Select();
        Periferico Select(int id);
    }
}
