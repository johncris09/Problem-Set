using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS10_MIA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter an integer:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
