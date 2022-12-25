using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enkucukcift
{
    internal class Program
    {
        // 30 elemanlı A ve B dizileri verilsin. her dizi için en küçük çift sayıyı bulan programı yazınız.

        public static int Enkucukcift(int[] X)
        {
            int enkucuk = X[0];

            for (int i = 0; i < X.Length; i++)
            {
                if((X[i] < enkucuk) && (X[i]%2 == 0))
                {
                    enkucuk = X[i];
                }
            }
            return enkucuk;

        }
        static void Main(string[] args)
        {
            int[] A = new int[30];
            int[] B = new int[30];
            Random ras = new Random();
            for (int i = 0; i < 30; i++)
            {
                A[i] = ras.Next(100, 201);
                B[i] = ras.Next(0, 101);
            }

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("{0}. A = {1}", i, A[i]);
            }

            Console.WriteLine("--------------------------------------------");

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("{0}. B = {1}", i, B[i]);
            }

            int enkucukA = Enkucukcift(A);
            int enkucukB = Enkucukcift(B);

            Console.WriteLine("A icindeki en kucuk cift sayi = {0}", enkucukA);
            Console.WriteLine("B içindeki en kucuk cift sayi = {0}", enkucukB);
        }
    }
}
