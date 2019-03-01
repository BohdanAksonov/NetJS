using System;
using System.Collections.Generic;
using System.Linq;

namespace Finding_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input T: ");
            int numberOfTests = Convert.ToInt32(Console.ReadLine());
            
            for (int i=1; i<=numberOfTests; i++)
            {
                int[] numbers = InputMandN();
                int firstNumber = numbers[0];
                int secondNumber = numbers[1];

                if (secondNumber < firstNumber || firstNumber <= 1 || secondNumber > Math.Pow(10, 9) || (firstNumber - secondNumber) > Math.Pow(10, 5))
                {
                    Console.Clear();
                    Console.WriteLine("M and N (1 <= m <= n <= 10^9, n – m <= 10^5)");
                    break;
                }
                else
                {
                    List<int> listOfIntegers = new List<int>();
                    for(int a=firstNumber; a<=secondNumber; a++)
                    {
                        listOfIntegers.Add(a);
                    }
                    int primeNumber = 2;
                    int maxValueInListOfIntegers = listOfIntegers.Max();
                    List<int> listToRemove = new List<int>();
                    while(Math.Pow(primeNumber, 2)<maxValueInListOfIntegers)
                    {
                        foreach (int number in listOfIntegers)
                        {
                            if (number % primeNumber == 0 && number>=Math.Pow(primeNumber,2))
                            {
                                listToRemove.Add(number);
                            }
                            
                        }
                        foreach(int number in listToRemove)
                        {
                            listOfIntegers.Remove(number);
                        }
                        primeNumber++;
                    }
                    Console.WriteLine($"Count of prime numbers:{listOfIntegers.Count}");
                    Console.WriteLine("----------------------------------------------");
                }
                    
            }
            Console.ReadKey();
        }

        static int[] InputMandN()
        {
            Console.WriteLine("Input M:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input N:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            return new int[] { firstNumber, secondNumber };
        }
    }
}
