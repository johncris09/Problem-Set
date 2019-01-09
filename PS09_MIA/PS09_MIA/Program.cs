using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS09_MIA
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * A program that reads an integer number n from the console.
             * After that reads n numbers from the  console and print their sum.
             */

            int n;
            double num, sum=0;

            Console.Write("Enter the number of Numbers:  ");
            n = Convert.ToInt32(Console.ReadLine());
           
            for (int i = 0; i < n;i++ )
            {
                Console.Write("Enter the "+ (i+1) +" Number: ");
                num = double.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine("The Total of All Numbers: {0:0.00}", sum);
            Console.ReadLine();
        }
    }
}
