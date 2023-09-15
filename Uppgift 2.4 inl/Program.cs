using System;

namespace Uppgift_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är person 1 s lön?");
            int pers1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Vad är person 2 s lön?");
            int pers2= int.Parse(Console.ReadLine());
            Console.WriteLine("Vad är person 3 s lön?");
            int pers3= int.Parse(Console.ReadLine());

            Console.WriteLine("medel lönen är " + ((pers1 + pers2 + pers3)/3) + " mellan de 3 anställda");

        }
    }
}