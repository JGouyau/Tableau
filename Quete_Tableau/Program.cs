using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_Tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int tailleDuTableau = 3;
            int[] tableauUn = new int[tailleDuTableau];
            int[] tableauDeux = new int[tailleDuTableau];
            int[] grosTableau = new int[tailleDuTableau * 2];

            var random = new Random();
            for (int i = 0; i < tailleDuTableau; i++)
            {
                tableauUn[i] = random.Next(100);
                Console.Write(tableauUn[i] + " : ");
            }
            Console.WriteLine();
            for (int i = 0; i < tailleDuTableau; i++)
            {
                tableauDeux[i] = random.Next(100);
                Console.Write(tableauDeux[i] + " : ");
            }
            Console.WriteLine();
            for (int i = 0; i < tailleDuTableau; i++)
            {
                grosTableau[i] = tableauUn[i];
                grosTableau[i + tailleDuTableau] = tableauDeux[i];
            }
            foreach (int element in grosTableau)
            {
                Console.Write(element + " : ");
            }
            Console.ReadKey();
        } 
    }
}
