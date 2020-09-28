using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            double ossz = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kérek 10 db számot: ");
                int szamok = Convert.ToInt32(Console.ReadLine());
                ossz += szamok;
            }

            Console.WriteLine("A számok átlaga: {0}",ossz/10);


        }
    }
}
