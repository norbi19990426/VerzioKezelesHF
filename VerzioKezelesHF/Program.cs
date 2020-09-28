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
            int[] tomb = new int[hossz];
            int max, min;

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("Kérek {0} db számot: ",hossz);
                int szamok = Convert.ToInt32(Console.ReadLine());

                tomb[i] = szamok;
            }

            max = tomb[0];
            min = tomb[0];

            for (int i = 0; i < tomb.Length; i++)
            {
               
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }

                ossz += tomb[i];
            }

            Console.WriteLine("A számok átlaga: {0} \n" +
                "Legnagyobb szám: {1} \n" +
                "Legkisebb szám: {2}",ossz/hossz, max, min);


        }
    }
}

