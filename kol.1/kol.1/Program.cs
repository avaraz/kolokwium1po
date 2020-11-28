using System;

namespace kol._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, c, delta;
            Console.WriteLine("Obliczanie delty.");

            Console.WriteLine("Podaj a: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj c:");
            c = double.Parse(Console.ReadLine());

            delta = (2 * 2) - (4 * a * (3 * c));
            Console.WriteLine("Delta wynosi: ");
            Console.WriteLine(Math.Round(delta, 2));

            if ( delta > 0)
            {
                double x1 = ((-2 - Math.Sqrt(delta)) / (2 * a));
                double x2 = ((-2 + Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("Miejsca zerowe to {0} i {1}: ", Math.Round(x1, 2), Math.Round(x2, 2));
            }
            else if (delta == 0) 
            {
                double x = (-2) / (2 * a);
                Console.WriteLine("Miejsce zerowe to {0}: ", Math.Round(x, 2));
            }
            else
            {
                Console.WriteLine("Delta nie ma rozwiązania.");
            }

            Console.ReadKey();

        }
    }
}
