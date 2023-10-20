using System;
namespace Upgift4_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bestäm kvadraternas sidlängd");
            byte sidlängd = byte.Parse(Console.ReadLine());

            Console.WriteLine("Bestäm rutnätets bredd");
            byte bredd = byte.Parse(Console.ReadLine());

            Console.WriteLine("Bestäm rutnätets höjd");
            byte höjd = byte.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < höjd; i++)
            {
                for(int j = 0; j < sidlängd; j++)
                {
                    for (int k = 0; k < bredd; k++)
                    {
                        for (int l = 0; l < sidlängd; l++)
                        {
                            Console.Write('*');
                        }
                        Console.Write(' ');
                    }
                    Console.WriteLine();
                }
            Console.WriteLine();
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}