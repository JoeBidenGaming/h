using System;
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
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Random random = new Random();
            string letter = "";
            for (int i = 0; i < 100000; i++)
            {
                if (random.Next(1, 4) == 1)
                {
                    letter = "a";
                }
                else if (random.Next(1, 4)== 2)
                {
                    letter="b";
                }
                else if(random.Next(1,4) == 3)
                {
                    letter = "c";
                }
                else if ((random.Next(1, 4) > 4))
                {
                    letter = "high";
                }
                else if (((random.Next(1, 4))< 1))
                {
                    letter = "low";
                }
                Console.Write(letter);
            }
            Console.ReadKey();
        }
    }
}
