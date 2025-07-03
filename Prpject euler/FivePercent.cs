using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prpject_euler
{
    public class FivePercent
    {
        public static void SequencesOf3Or5()
        {
            int factor =0;
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (factor % 3 == 0 || factor % 5 == 0)
                {
                    sum = sum + factor;
                }

                factor++;
            }
            Console.WriteLine("The sum is " + sum);
        }
        public static void EvenFibonacciNumbers()
        {
            int previous = 1;
            int current = 2;
            int temp = 0;
            int sum = 0;

            while (previous <= 4000000 && previous <= 4000000)
            {
                if (current % 2 == 0)
                {
                    sum = sum + current;
                }
                
                temp = current; /// THIS INCREMENTS THE FIBOINNACI SERIES 
                current = current + previous;
                previous = temp;

            }
            Console.WriteLine("The sum is " + sum);
        }
    }
}
