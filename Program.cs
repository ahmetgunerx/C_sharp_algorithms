using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chec = 1;
            int x, y;
            ArrayList x_div = new ArrayList();
            ArrayList y_div = new ArrayList();


            while (chec == 1)
            {
                int x_div_sum = 0;
                int y_div_sum = 0;
                x_div.Clear();
                y_div.Clear();

                Console.Write("enter the first number: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter the second number: ");
                y = Convert.ToInt32(Console.ReadLine());


                // finding the dividing numbers and assigning to dynamic ar:
                for (int i = 1; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        x_div.Add(i);
                    }
                }
                for (int i = 1; i < y; i++)
                {
                    if (y % i == 0)
                    {
                        y_div.Add(i);
                    }
                }


                // writing of dividing numbers:
                //for (int i = 0; i < x_div.Count; i++)
                //{
                //    Console.WriteLine(x_div[i]);

                //}
                //Console.WriteLine("---------");
                //for (int i = 0; i < y_div.Count; i++)
                //{
                //    Console.WriteLine(y_div[i]);

                //}


                // sum of dividing numbers:
                for (int i = 0; i < x_div.Count; i++)
                {
                    x_div_sum += Convert.ToInt32(x_div[i]);
                }
                for (int i = 0; i < y_div.Count; i++)
                {
                    y_div_sum += Convert.ToInt32(y_div[i]);
                }


                // check result:
                if (x == y_div_sum || y == x_div_sum)
                {
                    Console.WriteLine("sum of divisors of y equals to x");
                }
                else
                {
                    Console.WriteLine("there is no desired relationship between x and y divisors");
                }
                Console.WriteLine("another check? -- type '1'");
                chec = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
