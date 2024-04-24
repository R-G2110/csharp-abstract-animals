using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    class Pesce : INuotante
    {
        public void Nuota()
        {
            Console.Write("sto nuotando!!!");
        }
    }
}
