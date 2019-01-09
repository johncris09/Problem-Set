using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS05_MIA
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  A program that that reads from the console 2 integer and how many numbers between them exist.
             *  Example: in the range(12,25) there are 3 such number: 15,20,25
             */
            
            int start, end,between=0;
            double x;
            Console.Write("Start: ");
            start = int.Parse(Console.ReadLine());
            Console.Write("End: ");
            end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    between++;
                }
            }


            Console.WriteLine("Number of between " + start + " and " + end + " exist: " + between);
            Console.ReadLine();
        }
    }
}
