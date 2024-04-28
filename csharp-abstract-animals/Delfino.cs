using System;

namespace csharp_abstract_animals
{
    class Delfino : Animale, INuotante
    {
        public override void Verso()
        {
            Console.Write("ee-ee-ee-ee-ee");
        }

        public override void Mangia()
        {
            Console.Write("pesce");
        }

        public void Nuota()
        {
            Console.Write("nuoto veloce!!!");
        }
    }
}
