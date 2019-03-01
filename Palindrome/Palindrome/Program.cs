using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPalidrome = false;
            Console.WriteLine("Input word for check:");
            char[] array =  Console.ReadLine().ToLower().ToCharArray();
            for(int index=0; index<array.Length/2; index++)
            {
                if (array[index] != array[array.Length - 1 - index])
                    isPalidrome = false;
                else
                    isPalidrome = true;
            }
            if (isPalidrome)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}
