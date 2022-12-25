using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int usttop = 0, alttop = 0;
            int enk = 100, enb = 0; 
            Random rastgele = new Random();
            int[,] dizi = new int[4, 4];

            //matrise rastgele eleman eklemek için:
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dizi[i, j] = rastgele.Next(10,90);
                }
            }

            //matrisi ekrana yazdırmak için:
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}", dizi[i, j]);
                    Console.Write("    "); //elemanlar arasında boşluk bırakmak için:
                }
                Console.WriteLine();
            }

            //üst üçgensel matris toplamını buldurmak için:
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i <= j) 
                    {
                        usttop = usttop + dizi[i, j];
                    }
                }
            }

            //alt üçgensel matris toplamını buldurmak için:
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i >= j)
                    {
                        alttop = alttop + dizi[i, j];
                    }
                }
            }
                
            //en küçük ve en büyük elamanları buldurmak için:
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (dizi[i, j] >= enb)
                    {
                        enb = dizi[i, j];
                    }
                    else if(dizi[i, j] <= enk)
                    {
                        enk = dizi[i, j];
                    }
                }
            }


            Console.WriteLine();
            Console.WriteLine("üst üçgensel matris toplamı: {0}", usttop);
            Console.WriteLine("alt üçgensel matris toplamı: {0}", alttop);
            Console.WriteLine("matrisin en büyük elemanı: {0}", enb);
            Console.WriteLine("matrisin en küçük elemanı: {0}", enk);


        }
    }
}
