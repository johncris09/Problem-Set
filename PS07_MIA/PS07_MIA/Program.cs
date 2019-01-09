using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS07_MIA
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  A program that reads 5 integer and prints their sum.
             *  If the invalid number is entered then program should prompt the user to enter another number
             */
            double num,sum = 0;
            Console.WriteLine("Sum of Five Numbers\n");
            for (int i = 0; i < 5;i++ )
            {
                Console.Write("Enter " + (i+1) + " Number: ");
                num = double.Parse(Console.ReadLine());

                // Calculate the sum in every iterate
                sum += num;

            }

            Console.WriteLine("Sum: {0:0.00}", sum);

            Console.ReadLine();
        }
    }
}
