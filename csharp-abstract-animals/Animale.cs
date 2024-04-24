namespace csharp_abstract_animals
{
    public abstract class Animale
    {
        // Metodo Dormi implementato nella classe Animale
        public void Dormi()
        {
            Console.WriteLine("Zzz");
        }
        // Metodo Verso da implementare nelle classi derivate
        public abstract void Verso();
        // Metodo Mangia da implementare nelle classi derivate
        public abstract void Mangia();
    }
}
