using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS12_MIA
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            double sum = 1;
            sum += (1 / 2);
            for (int i = 0; i < 100; i++ )
            {
                if (i % 2 == 0)
                {
                    sum += sum/(num+i+1);
                    Console.WriteLine("{0:0.00}", sum);
                   
                }
                else 
                {
                    sum -= sum / (num + i + 1);
                    Console.WriteLine("{0:0.00}", sum);
                }


            }
            Console.WriteLine("{0:0.00}",sum);
            Console.ReadLine();
        }
    }
}
