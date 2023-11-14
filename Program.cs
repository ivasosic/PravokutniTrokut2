using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravokutniTrokut_IvaSosic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite 1. vrijednost/stranicu: ");
        strx: int x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("Vrijednost mora biti veća od nule: ");
                goto strx;
            }

            Console.WriteLine("Unesite 2. vrijednost/stranicu: ");
        stry: int y = Convert.ToInt32(Console.ReadLine());
            if (y == 0)
            {
                Console.WriteLine("Vrijednost mora biti veća od nule: ");
                goto stry;
            }

            Console.WriteLine("Unesite 3. vrijednost/stranicu: ");
        strz: int z = Convert.ToInt32(Console.ReadLine());
            if (z == 0)
            {
                Console.WriteLine("Vrijednost mora biti veća od nule: ");
                goto strz;
            }

            if (x * x + y * y == z * z)
            {
                Console.WriteLine("Unesene vrijednosti stranice su pravokutnog trokuta.");
            }
            else
            {
                Console.WriteLine("Unesene vrijednosti nisu stranice pravokutnog trokuta.");
            }


            Console.ReadKey();
        }
    }
}
