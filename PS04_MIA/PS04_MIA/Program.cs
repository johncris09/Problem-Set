using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS04_MIA
{
    class Program
    {
        static void Main(string[] args)
        {
            int fnum, index;
            double snum, tnum;
            string bin;
            Console.Write("Enter a first number: ");
            fnum = int.Parse(Console.ReadLine());
            if (fnum < 0)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            Console.Write("Enter a floating-point for second Nuber: ");
            snum = double.Parse(Console.ReadLine());
            Console.Write("Enter a floating-point for third number: ");
            tnum = double.Parse(Console.ReadLine());
            Console.Write("|{0,-10}", Convert.ToString(fnum, 16).ToUpper());
            Console.Write("|{0,10}|",
            Convert.ToString(fnum, 2).PadLeft(10, '0'));
            bin = snum.ToString();
            index = bin.IndexOf(".");
            if (index == -1)
            {
                Console.Write("{0,10}|", snum);
            }
            else
            {
                Console.Write("{0,10:F2}|", snum);
            }
            bin = tnum.ToString();
            index = bin.IndexOf(".");
            if (index == -1)
            {
                Console.Write("{0,-10}|", tnum);
            }
            else
            {
                Console.Write("{0,-10:F3}|", tnum);
            }


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
