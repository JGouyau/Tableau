using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableau_multidimentionnel
{
    class Program
    {
        static void Main(string[] args)

            //declare uniforme array
            {
            int[,] tableauUniforme = new int[3, 3]{{ 1,2,3},{2,3,4} ,{ 3,4,5}};

            //declare irregulare array
            int[][] tableauIrregulier = new int[3][];
            for (int i = 0; i < tableauIrregulier.Length; i++)
            {
                tableauIrregulier[i] = new int[3-i];
            }


            for(int j = 0; j < tableauIrregulier.Length; j++){


                for (int i = 0; i < tableauIrregulier[j].Length; i++)
                {

                    tableauIrregulier[j][i] = tableauUniforme[j, j+i];
                }
            }

            //affichage du tableau irregulier

            for (int j = 0; j < tableauIrregulier.Length; j++)
            {
                for (int i = 0; i < tableauIrregulier[j].Length; i++)
                {

                    Console.Write(tableauIrregulier[j][i] + " ; "); 
                }
                Console.WriteLine();
            }

            Console.ReadKey();

            }
        }
    }
