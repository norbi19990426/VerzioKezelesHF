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
            Console.WriteLine("Hány számot szeretne megadni?: ");
            int hossz = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < hossz; i++)
            {
                Console.WriteLine("Kérek {0} db számot: ",hossz);
                int szamok = Convert.ToInt32(Console.ReadLine());
                ossz += szamok;
            }

            Console.WriteLine("A számok átlaga: {0}",ossz/hossz);


        }
    }
}
