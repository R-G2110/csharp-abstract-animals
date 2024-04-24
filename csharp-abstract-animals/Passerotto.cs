using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale
    {
        // Sovrascrizione del metodo Verso nella classe Passerotto
        public override void Verso()
        {
            Console.WriteLine("Tweet!");
        }
        // Sovrascrizione del metodo Mangia nella classe Passerotto
        public override void Mangia()
        {
            Console.WriteLine("Mangia semi.");
        }
    }
}
