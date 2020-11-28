using System;

namespace kol._2
{
    class Program
    {
        static void zamiana(double M, double N)
        {
            double pom;
            pom = M;
            M = N;
            N = pom;

            Console.WriteLine("Po zmianie: ");
            Console.WriteLine("M = {0}, N = {1}.", M, N);

        }
        static void Main(string[] args)
        {
            double M, N;
            Console.WriteLine("Podaj M: ");
            M = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj N: ");
            N = double.Parse(Console.ReadLine());

            Console.WriteLine("Przed zmianą: ");
            Console.WriteLine("M = {0}, N = {1}.", M, N);

            zamiana(M, N);
        }
    }
}
