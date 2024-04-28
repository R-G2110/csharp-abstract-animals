using System;
using System.Collections.Generic;

namespace csharp_abstract_animals
{
    internal class Program 
    { 
        static void FaiVolare(IVolante animale)
        {
            animale.Vola();
        }

        static void FaiNuotare(INuotante animale)
        {
            animale.Nuota();
        }

        static void Main(string[] args)
        {
            //ESERCIZIO 1
            List<Animale> animali = new List<Animale>();

            animali.Add(new Cane());
            animali.Add(new Passerotto());
            animali.Add(new Aquila());
            animali.Add(new Delfino());

            
            Console.WriteLine("Esercizio 1:");
            foreach (Animale animale in animali)
            {
                Console.Write($"\nSono un {animale.GetType().Name} e faccio ");
                animale.Verso(); 
                Console.Write($", mangio ");
                animale.Mangia();
                Console.Write($", e quando dormo faccio ");
                animale.Dormi();
                Console.Write(".");
                Console.WriteLine();
            }
            Utility.Divider();

            //ESERCIZIO 2
            //static void FaiVolare(IVolante animale)
            //{
            //    animale.Vola();
            //}

            //static void FaiNuotare(INuotante animale)
            //{
            //    animale.Nuota();
            //}
            Console.WriteLine("Esercizio 2:");
            //IVolante uccello = new Uccello();
            //Console.Write($"\nSono un {uccello.GetType().Name} e ");
            //FaiVolare(uccello);

            //INuotante pesce = new Pesce();
            //Console.Write($"\nSono un {pesce.GetType().Name} e ");
            //FaiNuotare(pesce);
            //Utility.Divider();

            //Aquila aquila = new Aquila();
            //Delfino delfino = new Delfino();
            //Cane cane = new Cane();
            //Passerotto passerotto = new Passerotto();
            //FaiVolare(passerotto);
            //FaiVolare(aquila);
            //FaiNuotare(cane);
            //FaiNuotare(delfino);

            foreach (Animale animale in animali)
            {
                Type[] interfaces = animale.GetType().GetInterfaces();
                Console.Write($"\nSono un {animale.GetType().Name} e implemento l'interfaccia di ");
                foreach (Type interfaccia in interfaces)
                {
                    Console.Write(interfaccia.Name + ", e quindi ");
                    if (interfaccia == typeof(IVolante))
                    {
                        FaiVolare((IVolante)animale);
                    }
                    else if (interfaccia == typeof(INuotante))
                    {
                        FaiNuotare((INuotante)animale);
                    }
                }
                Console.WriteLine();
            }
        }
    }

}
