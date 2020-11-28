using System;

namespace kol._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Podaj liczbę z przedziału <1,150>.");
            n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];

            if (n >= 1 && n <= 150)
            {
                for (int i = 0; i < n; i++)
                {
                    Random r = new Random();
                    tab[i]= r.Next(-1109, 1109);
                    Console.WriteLine(tab[i]);
                }
            }
            else
            {
                Console.WriteLine("Liczba spoza przedziału.");
            }

            int max = tab[0];

            foreach (int i in tab)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine("Największa Liczba z tabeli to: {0}.", max);

            int powtorka = 0;

            for (int j = 0; j < tab.Length; j++)
            {

                if (tab[j] == max)
                {
                    powtorka += 1;
                }
            }
            Console.WriteLine("Liczba {0} występuje w tabeli {1}.", max, powtorka);
        }
    }
}
