using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    internal class Program
    {

        static bool IsPrime(int number)
        {            
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)                
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int count=0;
            Console.WriteLine("Ввведите число n");
            int n = Convert.ToInt32(Console.ReadLine());  
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine($"{i} ");
                    count++;
                }
            }
            Console.WriteLine($"Найдено {count} простых чисел");
            Console.ReadKey();
        }
    }
}
