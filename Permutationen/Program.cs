using System;
using System.Collections.Generic;
using System.Linq;

namespace Permutationen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Eigentlich auf einem Blatt Papier gelöst! Hier aber nochmal die Herangehensweise:

            var gesuchtePermutation = 999999; // inkl. 0
            var zahlen = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            while (zahlen.Any())
            {
                // Berechne Anzahl der Permutationen der restlichen Zahlen abzüglich der gesuchten Zahl = (n-1)!
                var fact = 1;
                for (var i = 1; i <= zahlen.Count - 1; i++)
                {
                    fact *= i;
                }

                // Ganzzahlige Division mit gesuchtePermutation=Rest
                var idx = gesuchtePermutation / fact;
                gesuchtePermutation = gesuchtePermutation - idx * fact;

                var ziffer = zahlen[idx];
                zahlen.RemoveAt(idx);

                Console.Write(ziffer);
            }

            Console.WriteLine();
        }
    }
}
