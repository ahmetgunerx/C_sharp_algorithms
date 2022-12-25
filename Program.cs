using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veri_yapıları
{
    internal class Program
    {
        // yığına eleman eklemek için yazılan fonksiyon:
        public static void ekleme(int eleman, int[] yigin, int n, int mik)
        {
            if (mik >= n)
            {
                System.Console.WriteLine("yigin dolu");
                return;
            }
            else
            {
                mik = mik + 1;
                yigin[mik] = eleman;
            }
            return;
        }

        // yığından eleman çıkarmak için yazılan fonksiyon:
        public static int cikarma(int eleman, int[] yigin, int mik)
        {
            if (mik < 0)
            {
                System.Console.WriteLine("yigin bos");
                return 0;
            }
            else
            {
                eleman = yigin[mik];
            }
            return eleman;
        }


        static void Main(string[] args)
        {
            int[] yigin = new int[20];
            for (int i = 0; i < 10; i++)
            {
                // yığına eleman ekleme işlemleri:
                int y = 0;
                int a = 0, b = 0, c = 0;
                Console.Write("{0}. a: ", i);
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("{0}. b: ", i);
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("{0}. c: ", i);
                c = Convert.ToInt32(Console.ReadLine());
                y = a + b + c;

                ekleme(y, yigin, 9, i-1);
            }

            Console.WriteLine();
            Console.Write("-------yığın içindeki elemanların normal sırası-------");
            Console.WriteLine();

            // yığına elemanları ekledikten sonra yığını ekrana yazdırma:
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} indeksli yığın içindeki eleman: {1}", i, yigin[i]);
            }


            Console.WriteLine();
            Console.Write("-------yığın içindeki elemanların ters sırası-------");
            Console.WriteLine();

            // yığından elemanları son giren ilk çıkar mantığıyla sırayla çıkarıp ekrana yazdırma:
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine("{0} indeksli yığın içindeki eleman: {1}", i, cikarma(yigin[i], yigin, i));
            }


            Console.WriteLine();
            Console.Write("-------yığın içindeki elemanların asal kontrol-------");
            Console.WriteLine();



            // yığın içindeki elemanları son giren ilk çıkar mantığıyla sırayla çıkarıp asallığını kontrol etme:
            for (int i = 9; i >= 0; i--)
            {
                int q = cikarma(yigin[i], yigin, i);
                int asalsay = 0;
                for (int j = 1; j <= q; j++)
                {
                    if (q % j == 0)
                    {
                        asalsay++;
                    }
                }
                if (asalsay == 2)
                {
                    Console.WriteLine("{0} indeksli y = {1} asaldir", i, q);
                }
                else
                {
                    Console.WriteLine("{0} indeksli y = {1} asal degildir.", i, q);
                }
            }
        }
    }
}