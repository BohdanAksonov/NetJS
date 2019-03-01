using System;
using System.Collections.Generic;
using System.Linq;

namespace Common_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = inputArraySize();
            if(arraySize<2 || arraySize>20)
            {
                Console.Clear();
                Console.WriteLine("Error! N must be between 2 and 20 inclusive");
                arraySize = inputArraySize();
            }
            Console.WriteLine($"Input {arraySize} numbers: ");
            string[] arrayOfNumbers = Console.ReadLine().Split(' ');

            List<char> listOfDigits = new List<char>();
            foreach(string number in arrayOfNumbers)
            {
                listOfDigits.AddRange(number);
            }
            listOfDigits.Sort();

            int count = 1;
            Dictionary<double, int> digitDictionary = new Dictionary<double, int>();
            for(int i = listOfDigits.Count-1; i>0; i--)
            {
                
                if(listOfDigits[i]==listOfDigits[i-1])
                {
                    count++;
                }
                else
                {
                    digitDictionary.Add(char.GetNumericValue(listOfDigits[i]), count);
                    count = 1;
                }
                if(i==1)
                {
                    digitDictionary.Add(char.GetNumericValue(listOfDigits[0]), count);
                }
            }
            
            double commonDigit = digitDictionary.First(p => p.Value == digitDictionary.Values.Max()).Key;

            Console.WriteLine($"Common digit is {commonDigit}");
            Console.ReadKey();
        }

        static int inputArraySize()
        {
            Console.WriteLine("Input N:");
            return int.Parse(Console.ReadLine());
        }
    }
}
