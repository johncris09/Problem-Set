using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS01_MIA
{
    class Program
    {
        static void Main(string[] args)
        {
            double fnum, snum, tnum, sum;

            // Inputs
            Console.Write("Finding the sum of 3 numbers\n");
            Console.Write("Enter first number: ");
            fnum = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            snum = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            tnum = double.Parse(Console.ReadLine());

            // Process
            sum = fnum + snum + tnum;

            // Output

            Console.WriteLine("Total: {0} " , sum);

            Console.ReadLine();
        }
    }
}
