using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale
    {
        // Sovrascrizione del metodo Verso nella classe l'Aquila
        public override void Verso()
        {
            Console.WriteLine("Screech!");
        }
        // Sovrascrizione del metodo Mangia nella classe l'Aquila
        public override void Mangia()
        {
            Console.WriteLine("Mangia carne.");
        }
    }
}
