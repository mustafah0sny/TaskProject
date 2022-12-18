using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  sum;
          



            Console.WriteLine("Input  number  one");
           int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input  number  Two");
          int  numTwo = Convert.ToInt32(Console.ReadLine());
            for (int n = numOne; n <= numTwo; n++)
            {
               int i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine("{0} ", n);
            }
            Console.WriteLine("\n");
        }
    }
}
