using System;

namespace Reverse_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize;
            Console.WriteLine("Input array size:");
            arraySize = int.Parse(Console.ReadLine());
            int[] reverseArray = new int[arraySize];
            Console.WriteLine($"Input {arraySize} integer values to array, example: 1 2 3 5 6");
            string[] arrayForReverse = Console.ReadLine().Split(' ');

            for (int index=0; index< reverseArray.Length; index++)
            {
                reverseArray[reverseArray.Length-1-index] = int.Parse(arrayForReverse[index]);
            }

            Console.WriteLine("Reverse array: ");
            Console.WriteLine($"{string.Join(' ', reverseArray)}");
            Console.ReadKey();
        }
    }
}
