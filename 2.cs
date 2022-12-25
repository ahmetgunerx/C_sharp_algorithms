using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, 7, 43, 100 };

            // dizideki 3'e bölünen sayıları alt alta ekrana yazdırma:
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 3 == 0)
                {
                    Console.WriteLine(sayilar[i]);
                }
            }

            Console.WriteLine("------------------------------------------------");

            // dizideki elemanları tersten alt alta ekrana yazdırma:
            for (int i = sayilar.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.WriteLine("------------------------------------------------");

            // dizideki elemanlardan kaçtanesi çift , kaçtanesi tek sayı olduğunu ekrana yazdırma:
            int teksayac = 0, ciftsayac = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (i % 2 == 0)
                {
                    ciftsayac++;
                }
                else
                {
                    teksayac++;
                }
            }
            Console.WriteLine("cift sayisi = {0}", ciftsayac);
            Console.WriteLine("tek sayisi = {0}", teksayac);

            Console.WriteLine("------------------------------------------------");


            // dizideki en büyük sayıyı ekrana yazdırma:
            int sayilarenb = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > sayilarenb)
                {
                    sayilarenb = sayilar[i];
                }
            }
            Console.WriteLine("en buyuk sayi = {0}", sayilarenb);

            Console.WriteLine("------------------------------------------------");

            // dizideki en büyük negatif sayıyı ekrana yazdırma:
            int negsayac = 0;
            for (int i = 1; i < sayilar.Length; i++)
            {
                if (sayilar[i] < 0)
                {
                    negsayac++;
                }
            }
            int[] negsayilar = new int[negsayac];
            int sayac = 0;
            for(int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] < 0)
                {
                    negsayilar[sayac] = sayilar[i];
                    sayac++;
                }
            }
            int sayilarenbneg = negsayilar[0];
            for (int i = 1; i < negsayilar.Length; i++)
            {
                if (sayilarenbneg < negsayilar[i])
                {
                    sayilarenbneg = negsayilar[i];
                }
            }
            Console.WriteLine("en buyuk negatif sayi = {0}", sayilarenbneg);

            Console.WriteLine("------------------------------------------------");

            // diziyi küçükten büyüğe sıralayarak ekrana yazdırma:
            int temp = sayilar[0];
            for(int i = 0; i < sayilar.Length -1; i++)
            {
                for(int j = i+1; j < sayilar.Length; j++)
                {
                    if (sayilar[j] < sayilar[i])
                    {
                        temp = sayilar[j];
                        sayilar[j] = sayilar[i];
                        sayilar[i] = temp;
                    }
                }
            }
            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
        }
    }
}
