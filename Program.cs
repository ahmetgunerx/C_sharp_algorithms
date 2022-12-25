using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class calvin_plein
    {
        public static void durum3()
        {
            Console.WriteLine("farklı class içinde ve static var (durum3)");
        }

        public void durum4()
        {
            Console.WriteLine("farklı class içinde ve static olmadan (durum4)");
        }

    }


    internal class Program
    {
        static void durum1()
        {
            Console.WriteLine("aynı class içinde ve static var (durum1)");
        }

        void durum2()
        {
            Console.WriteLine("aynı class içinde ve static olmadan (durum2)");
        }
        

        static void Main(string[] args)
        {
            // durum1 için:
            durum1();


            // durum2 için:
            Program ikincidurum = new Program();
            ikincidurum.durum2();


            // durum3 için:
            calvin_plein.durum3();


            // durum4 için:
            calvin_plein dorduncudurum = new calvin_plein();
            dorduncudurum.durum4();
 
        }
    }
}
