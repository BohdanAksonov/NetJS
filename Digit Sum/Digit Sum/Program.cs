using System;
using System.Linq;
using System.Collections.Generic;

namespace Digit_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input N: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Input {arraySize} numbers:");
            string[] arrayOfNumbers = Console.ReadLine().Split(' ');
            int[] arrayOfDigit = new int[arraySize];
            for (int i=0; i<arrayOfNumbers.Length; i++)
            {
                arrayOfDigit[i] = int.Parse(arrayOfNumbers[i]);
            }
            List<double> findPosition = new List<double>();
            foreach(var number in arrayOfDigit)
            {
                char[] digitSumArray = number.ToString().ToCharArray();
                double digitSum = 0;
                foreach (char digit in digitSumArray)
                {
                    digitSum += char.GetNumericValue(digit);
                }
                findPosition.Add(digitSum);
            }
            double max = findPosition.Max();
            Console.WriteLine($"{findPosition.IndexOf(max)}");
            Console.ReadKey();
        }
    }
}
