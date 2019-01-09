using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS11_MIA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100,prev = 0, current = 1,tmp;
            Console.Write("First 100 of Fibonacci Sequence");
            Console.Write("{0} {1}", prev, current);
            // Fibonacci Process
            for (int i = 2; i < n; i++)
            {
                tmp = prev + current;
                Console.Write(" {0} ", tmp);
                prev = current;
                current= tmp;
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
