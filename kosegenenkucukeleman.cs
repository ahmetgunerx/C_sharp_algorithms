using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosegenenkucukeleman
{
    internal class kosegenenkucukeleman
    {
        static void Main(string[] args)
        {
            int[,] matris = new int[5, 5];
            int i, j;
            Random rand = new Random();


            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    matris[i, j] = rand.Next(0, 101);
                    
                }
            }

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write(matris[i, j]);
                    Console.Write("\t");

                }
                Console.WriteLine();
            }


            int enk=matris[0,0];
            

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                       if( matris[i,j]<enk) enk= matris[i,j];
                    }
                }
            }
            Console.WriteLine("en kucuk elemann={0}", enk);
        }
    }
}
