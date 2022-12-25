using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödevsorusu
{
    internal class Program
    {
        static void olustur(int a, int b)
        {
            Random random = new Random();
            int[,] mat = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    mat[i, j] = random.Next(0, 10);
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(mat[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            int gecici;
            int enk = mat[0, 0];
            for (int i = 0; i < a; i++)
            {
                for (int j=0; j < b; j++)
                {
                    if (mat[0, j] < enk)
                    {
                        enk = mat[0, j];
                    }
                }
            }
            Console.WriteLine("en kucuk eleman={0}", enk);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("matrisin satir sayisini giriniz:");
            int satir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("matrisin sutun sayisini giriniz:");
            int sutun = Convert.ToInt32(Console.ReadLine());

            olustur(satir, sutun);


        }

    }
}
