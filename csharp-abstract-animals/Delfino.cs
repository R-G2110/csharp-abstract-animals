using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale
    {
        // Implementazione del metodo Verso specifico per il Delfino
        public override void Verso()
        {
            Console.WriteLine("ee-ee-ee-ee-ee!");
        }

        // Implementazione del metodo Mangia specifico per il Delfino
        public override void Mangia()
        {
            Console.WriteLine("Mangia pesce.");
        }
    }
}
