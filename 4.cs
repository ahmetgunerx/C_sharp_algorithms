using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_question
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Random ras=new Random();
            int[,] matris = new int[10, 10];
            int i, j;
            


            for (i = 0; i < 10; i++)
            {
                for(j=0; j < 10; j++)
                {
                    matris[i, j] = ras.Next(10);
                }
            }
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    Console.Write(matris[i, j]);
                    Console.Write("   ");

                }
                Console.WriteLine();
            }
            for(i=0;i<10; i++)
            {
                int topsatir = 0;
                for(j=0; j < 10; j++)
                {
                    topsatir+=matris[i, j];    
                }
                Console.WriteLine("{0}. satirin toplami={1}", i, topsatir);
            }

            Console.WriteLine("------------------------------------------------");

            for (j = 0; j < 10; j++)
            {
                int topsutun = 0;
                for (i = 0; i < 10; i++)
                {
                    topsutun += matris[i, j];
                }
                Console.WriteLine("{0}. sutunun toplami={1}", j, topsutun);
            }

        }
    }
}
