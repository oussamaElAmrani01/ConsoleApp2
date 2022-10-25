using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {
            var tab = new int[] { 1, 2, 6, 8, 10 };
            const int c = 5;

            InsertionValeur(c, ref tab);

            foreach (var num in tab)
            {
                Console.WriteLine(num);
            }
        }


        public static void InsertionValeur(int nb, ref int[] tab)
        {
            Array.Resize(ref tab, tab.Length + 1);
            for (var i = tab.Length - 1; i >= 0; i--)
            {
                if (nb > tab[i - 1])
                {
                    tab[i] = nb;
                    return;
                }
                else
                {
                    tab[i] = tab[i - 1];
                }
            }
        }

    }
}
