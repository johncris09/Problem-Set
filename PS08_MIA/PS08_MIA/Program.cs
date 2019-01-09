using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS08_MIA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Size of an Array: ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            Console.WriteLine("Enter the values of the array:");
            for (int i = 0; i < numbers.Length; i++) {
                Console.Write("Enter the "+ (i+1) +" integer: ");
                numbers[i] = (int) int.Parse(Console.ReadLine());
            }

            
            // Sorting Process
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                // Loop operating over the unsorted part of the array   
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    // Swapping the values    
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            } // End of the sorting logic
            
            
            Console.WriteLine("Largest Number: " + numbers[numbers.Length-1]);
            
  

            Console.ReadLine();
        }

    }
}
