namespace csharp_abstract_animals
{
    class Cane : Animale, INuotante
    {
        public override void Verso()
        {
            Console.Write("bau-bau");
        }

        public override void Mangia()
        {
            Console.Write("carne");
        }
        public void Nuota()
        {
            Console.Write("nuoto!!!");
        }
    }
}
