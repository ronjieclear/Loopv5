using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopv5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int ulit;
            Console.WriteLine("      ======= Welcome to Loop Program ====== ");
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("How many times do you want to display your name: ");
            ulit = int.Parse(Console.ReadLine()); // Paul
            //Iteration = Ulit - isang ikot. 1 iteration - 1 ulit

            //do while loop
            int i = 1;
            do
            {
                Console.WriteLine(name);
                i++;
                if (i == 3)
                {
                    //break;
                    goto endpart;
                }

            } while (i<=ulit);

            part1:
            Console.WriteLine("Part 1");

            part2:
            Console.WriteLine("Part 2");

            endpart:
            Console.WriteLine("END Part");


            /*            //for loop
                        for (int i =1; i<=ulit;i++)
                        {
                            Console.WriteLine(name);
                            for (int j =1; j<=ulit;j++)
                            {
                                Console.WriteLine(j);
                            }
                        }*/


            /*            //while loop
                        int i = 1;
                        int x = 1;
                        while (i <= ulit)
                        {
                            Console.WriteLine(name);
                            i++;  // i = i +1; or // i+=1;
                            while (x <=i)
                            {
                                Console.WriteLine(x);
                                x++;
                            }
                        }*/




            Console.ReadLine();
        }
    }
}

