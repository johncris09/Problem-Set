using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS02_MIA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Area and Perimeter of a Circle

            double r, area, perimeter;

            Console.WriteLine("A Program that will calculate the Area and Perimeter of a Circle");
            Console.Write("Enter Radius: ");
            r = double.Parse(Console.ReadLine());

            // Area = πR^2
            area = Math.PI * (r * r);

            // Perimeter (P) = 2πR
            perimeter = 2 * Math.PI * r;

            Console.WriteLine("The Area of your circle is: {0:0.00} ", area);
            Console.WriteLine("The Perimeter of your circle is: {0:0.00} ", perimeter);

            Console.ReadLine();
        }
    }
}
