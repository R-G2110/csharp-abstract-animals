namespace csharp_abstract_animals
{
    public class Cane : Animale
    {
        // Sovrascrizione del metodo Verso nella classe Cane
        public override void Verso()
        {
            Console.WriteLine("Bau! Bau!");
        }
        // Sovrascrizione del metodo Mangia nella classe Cane
        public override void Mangia()
        {
            Console.WriteLine("Mangia carne.");
        }
    }
}
