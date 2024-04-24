namespace csharp_abstract_animals
{
    class Cane : Animale
    {
        public override void Verso()
        {
            Console.Write("bau-bau");
        }

        public override void Mangia()
        {
            Console.Write("carne");
        }
    }
}
