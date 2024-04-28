using System;

namespace csharp_abstract_animals
{
    class Aquila : Animale, IVolante
    {
        public override void Verso()
        {
            Console.Write("screeek");
        }

        public override void Mangia()
        {
            Console.Write("carne e pesce");
        }

        public void Vola()
        {
            Console.Write("volo veloce!!!");
        }
    }
}
