using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notes_question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 20 kişinin 0-100 arası notlarını rastgele şekilde ogrnot dizisine ekleme ve ogrnot'u yazdırma:
            Random ras = new Random();
            int[] ogrnot = new int[20];
            for (int i = 0; i < ogrnot.Length; i++)
            {
                ogrnot[i] = ras.Next(0, 101);
            }
            for (int i = 0; i < ogrnot.Length; i++)
            {
                Console.WriteLine("{0}. not = {1}", i+1, ogrnot[i]);
            }


            Console.WriteLine("---------------------------------------------------------------");


            // geçen sayısını ekrana yazdırma (geçme notu=50):
            int gecensay = 0;
            for (int i = 0; i < ogrnot.Length; i++)
            {
                if (ogrnot[i] >= 50)
                {
                    gecensay++;
                }
            }
            Console.WriteLine("gecen sayisi = {0}", gecensay);


            Console.WriteLine("---------------------------------------------------------------");


            // kalan sayısını ekrana yazdırma (geçme notu=50):
            int kalansay = 0;
            for (int i = 0; i < ogrnot.Length; i++)
            {
                if (ogrnot[i] < 50)
                {
                    kalansay++;
                }
            }
            Console.WriteLine("kalan sayisi = {0}", kalansay);


            Console.WriteLine("---------------------------------------------------------------");


            // notu 5 olan öğrenci sayısını ekrana yazdırma (85 üstü):
            int bessay = 0;
            for (int i = 0; i < ogrnot.Length; i++)
            {
                if (ogrnot[i] >= 85)
                {
                    bessay++;
                }
            }
            Console.WriteLine("notu 5 olan ogrenci sayisi = {0}", bessay);


            Console.WriteLine("---------------------------------------------------------------");


            // notu 5 olan öğrenci sayısını ekrana yazdırma (60-70):
            int ucsay = 0;
            for (int i = 0; i < ogrnot.Length; i++)
            {
                if ((ogrnot[i] > 60) && (ogrnot[i] < 70))
                {
                    ucsay++;
                }
            }
            Console.WriteLine("notu 3 olan ogrenci sayisi = {0}", ucsay);


            Console.WriteLine("---------------------------------------------------------------");


            // en yüksek notu ekrana yazdırma:
            int enbnot = 0;
            for(int i = 0; i < ogrnot.Length; i++)
            {
                if(ogrnot[i] > enbnot)
                {
                    enbnot = ogrnot[i];
                }
            }
            Console.WriteLine("en buyuk not = {0}", enbnot);


            Console.WriteLine("---------------------------------------------------------------");
            // en dusuk notu ekrana yazdırma:
            int enknot = 101;
            for (int i = 0; i < ogrnot.Length; i++)
            {
                if (ogrnot[i] < enknot)
                {
                    enknot = ogrnot[i];
                }
            }
            Console.WriteLine("en kucuk not = {0}", enknot);


            Console.WriteLine("---------------------------------------------------------------");


            // en düşük puan alan öğrencinin 2. sınavda alması gereken puanı ekrana yazdırma:
            int enkiki = 100 - enknot;
            Console.WriteLine("en dusuk not alan kisinin ikinci sinavda almasi gerekn not = {0}", enkiki);


            Console.WriteLine("---------------------------------------------------------------");


            // sınıf ortalamasını ekrana yazdırma:
            float ort;
            float toplam = 0;
            for (int i = 0; i < ogrnot.Length; i++)
            {
                toplam += ogrnot[i];
            }
            ort = toplam / 20;
            Console.WriteLine("sinif ortalamasi = {0}", ort);


            Console.WriteLine("---------------------------------------------------------------");


            // sınıf ortalamasının altında not alan kişi sayısını ekrana yazdırma:
            int ortalti = 0;
            for (int i = 0; i < ogrnot.Length; i++)
            {
                if (ogrnot[i] < ort)
                {
                    ortalti++;
                }
            }
            Console.WriteLine("ortalamanin altinda not alan kisi sayisi = {0}", ortalti);


            Console.WriteLine("---------------------------------------------------------------");


            // sınıf ortalamasının altında not alanların notlarının ortalamasını ekrana yazdırma:
            float ortaltiort;
            int ortaltitop = 0;
            for (int i = 0; i < ogrnot.Length; i++)
            {
                if (ogrnot[i] < ort)
                {
                    ortaltitop += ogrnot[i];
                }
            }
            ortaltiort = ortaltitop / ortalti;
            Console.WriteLine("ortalamanin altinda not alanlarin notlarinin ortalamasi = {0}", ortaltiort);
        }
    }
}
