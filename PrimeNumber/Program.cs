using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag;

            Console.WriteLine("Enter NUmber one ");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number two ");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPrime numbers between " +
                              "{0} and {1} are: ", num1, num2);


            for (int i = num1; i <= num2; i++)
            {
                if (i == 1 || i == 0)
                    continue;

                flag = true;

                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag == true)
                    Console.WriteLine(i);
            }
        }
    }
}