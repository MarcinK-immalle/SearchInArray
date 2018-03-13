using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchin_in_array
{
    class Program
    {
        const int aantalGetallen = 100;
        static int[] getallen = new int[aantalGetallen];
        static Random rndgen = new Random();

        static void Main(string[] args)
        {
            VulGetallnArray();
            ZoekGetal(5);
        }

        static void VulGetallnArray()
        {
            for (int i = 0; i < aantalGetallen; i++)
            {
                getallen[i] = rndgen.Next(1, 100000);
            }
        }

        static int? ZoekGetal(int x)
        {
            for (int i = 0 ; i < aantalGetallen ; i++)
            {
                Console.WriteLine($"{getallen[i]}");
                if (getallen[i] == x)
                {
                    Console.WriteLine($"{x} gevonden op {i}");
                    return i;
                }
                else if (i + 1 == aantalGetallen)
                {
                    Console.WriteLine($"{x} niet gevonden");
                    return null;
                }
            }return null;
        }

        enum SearchState
        {
            StillSearching,
            NotFound,
            Found
        }
    }
}
