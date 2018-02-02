using System;

namespace Primzahl
{
    class Program
    {
        static void Main(string[] args)
        {
            int aktuelleZahl = 1, n = 1;
            while (true)
            {
                aktuelleZahl += 2;
                var m = (int)Math.Ceiling(Math.Sqrt(aktuelleZahl));
                bool isPrim = true;
                for (var d = 2; d <= m; d++)
                {
                    if (aktuelleZahl % d == 0)
                    {
                        isPrim = false;
                        break;
                    }
                }
                if (isPrim)
                {
                    n++;
                    Console.WriteLine($"{n}: {aktuelleZahl}");
                    if (n == 10001)
                        Console.ReadLine();
                }
            }
        }
    }
}
