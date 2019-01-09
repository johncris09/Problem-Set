using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS06_MIA
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  A program that reads 2 Number and prints the greater of them  
             *  without using conditional statement
             *  Ex. x=1,y=2 then print y
             *  
             */
            double fnum, snum, greater_num;

            Console.Write("Enter number First Number: ");
            fnum = double.Parse(Console.ReadLine());
            Console.Write("Enter number Secon Number:");
            snum = double.Parse(Console.ReadLine());

            // Finding the greater number of 2 numbers
            greater_num = Math.Max(fnum, snum);
            
            // Print the larger number
            Console.WriteLine("Greater Number: {0}", greater_num);
            
            Console.ReadLine();
        }
    }
}
