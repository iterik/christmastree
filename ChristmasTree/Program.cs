using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int space = 10;
            int asterix = 1;

            for(int i = 0; i < 10; i++)
            {
                for(int ii = 0; ii < space; ii++)
                {
                    Console.Write(" ");
                }

                for(int ii = 0; ii < asterix; ii++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
                asterix++;
                space--;
            }

            Console.WriteLine("         |||");
            Console.WriteLine("         |||");

            Console.ReadLine();
        }
    }
}
