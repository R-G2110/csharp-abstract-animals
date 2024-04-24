using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    class Delfino : Animale
    {
        public override void Verso()
        {
            Console.Write("ee-ee-ee-ee-ee");
        }

        public override void Mangia()
        {
            Console.Write("pesce");
        }
    }

}
