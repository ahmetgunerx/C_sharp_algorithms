using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*9. 6x6 lık bir A matrisi girildiğinde
            a)matrisin üst üçgenindeki elemanların en küçüğünü
            b)matrisin her bir satırındaki elemanların en büyüğünü ve 
            hangi satır sütun indisinden elde edildiğini bulup yazdıran bir programı yazınız.
            */
            Random rand = new Random();
            int[,] matris = new int[6, 6];
            int i, j, enk;
            int hangisat, hangisut;
            int enb = 0;

            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    matris[i, j] = rand.Next(0, 20);
                }
            }
            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    Console.Write(matris[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------------");

            enk = matris[0, 0];
            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    if (i >= j)
                    {
                        if (matris[i, j] < enk) enk = matris[i, j];
                    }
                }
            }

            for (i = 0; i < 6; i++)
            {
                enb = 0;
                hangisat = 0;
                hangisut = 0;
                for (j = 0; j < 6; j++)
                {
                    if (matris[j, i] > enb)
                    {
                        enb = matris[j, i];
                        hangisat = j + 1;
                        hangisut = i + 1;
                    }
                }
                Console.WriteLine("{0}. sutunun en buyuk elemani = {1} olur ve {2}. satir {3}. sutundadir.", i + 1, enb, hangisat, hangisut);
            }

            Console.WriteLine("-----------------------------------");

            for (i = 0; i < 6; i++)
            {
                enb = 0;
                hangisat = 0;
                hangisut = 0;
                for (j = 0; j < 6; j++)
                {
                    if (matris[i, j] > enb)
                    {
                        enb = matris[i, j];
                        hangisat = i + 1;
                        hangisut = j + 1;
                    }
                }
                Console.WriteLine("{0}. satirin en buyuk elemani = {1} olur ve {2}. satir {3}. sutundadir.", i + 1, enb, hangisat, hangisut);
            }

            Console.WriteLine("-----------------------------------");

            enb = 0;
            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 6; j++)
                {
                    if(matris[i, j] > enb)
                    {
                        enb = matris[i, j];
                    }
                }
            }
            Console.WriteLine("sutunun en buyuk elemani={0}", enb);

            Console.WriteLine("-----------------------------------");

            Console.WriteLine("alt ucgendeki en kucuk eleman={0}", enk);
        }
    }
}