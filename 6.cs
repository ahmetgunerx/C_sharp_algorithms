using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizefinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 30 kişilik bir sınıfta Matematik dersine ait vize notları ve öğrenci isimleri verilsin.
            // Öğrencileri vize notlarına göre isimleriyle birlikte küçükten büyüğe sıralayınız.
            string[,] ogrnot = new string[10, 3];
            Random r = new Random();
            for(int i = 0; i < ogrnot.GetLength(0); i++)
            {
                Console.Write("enter the {0}. students name: ", i);
                ogrnot[i,0] = Console.ReadLine();
                ogrnot[i, 1] = Convert.ToString(r.Next(0, 101));
                ogrnot[i, 2] = Convert.ToString(r.Next(0, 101));
            }

            for (int i = 0; i < ogrnot.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < ogrnot.GetLength(1); j++)
                {
                    Console.Write(ogrnot[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }

            string temp0;
            int temp1;
            int temp2;
            for(int i = 0; i < ogrnot.GetLength(0) - 1; i++)
            {
                for(int j = i+1; j < ogrnot.GetLength(0); j++)
                {
                    if(Convert.ToInt32(ogrnot[j, 1]) < Convert.ToInt32(ogrnot[i, 1]))
                    {
                        temp1 = Convert.ToInt32(ogrnot[i, 1]);
                        ogrnot[i, 1] = ogrnot[j, 1];
                        ogrnot[j, 1] = temp1;
                    }
                }
            }
        }
    }
}
