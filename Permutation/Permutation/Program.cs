using System;
using System.Collections.Generic;
using System.Linq;

namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPermutation = false;
            Console.WriteLine("Input integer values in the first array:");
            string[] firstArray = Console.ReadLine().Split(' ');
            Console.WriteLine("Input integer values in the second array:");
            string[] secondArray = Console.ReadLine().Split(' ');
            
            List<int> firstList = new List<int>();
            List<int> secondList = new List<int>();

            foreach (var number in firstArray)
            {
                firstList.Add(int.Parse(number));
            }
            
            foreach (var number in secondArray)
            {
                secondList.Add(int.Parse(number));
            }

            firstList.Sort();
            secondList.Sort();

            isPermutation = secondList.SequenceEqual(firstList);

            if (isPermutation)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}
