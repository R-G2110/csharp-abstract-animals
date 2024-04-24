namespace csharp_abstract_animals
{
    public abstract class Animale
    {
        // Metodo Dormi da implementare nella classe astratta
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
