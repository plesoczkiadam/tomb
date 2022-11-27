using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plesoczki_Á_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, dbpoz, dbneg;
            Console.WriteLine("Hány elemű a tömb?");
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] szam = new int[n];
            dbneg = 0;
            dbpoz = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}.elem: ", i + 1);
                szam[i] = Convert.ToInt32(Console.ReadLine());
                if (szam[i] >= 0)
                    dbpoz++;
                else
                    dbneg++;
            }
            Console.WriteLine("A pozitivak száma: {0}", dbpoz);
            Console.WriteLine("A negatívak száma: {0}", dbneg);
            Console.ReadLine();
        }
    }
}
