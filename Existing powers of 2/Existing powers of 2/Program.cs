using System;
using System.Collections.Generic;
using System.Linq;

namespace Existing_powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> randomList = new List<int>();
            Random random = new Random();
            for(int i=0; i<random.Next(2, 10); i++)
            {
                randomList.Add(random.Next(10));
            }
            randomList.Sort();
            Console.WriteLine($"Input list: {string.Join(',', randomList)}");
            int maxValue=0;
            for(int index=randomList.Count-1; index>=0; index--)
            {
                if(randomList[index]%2==0)
                {
                    maxValue = randomList[index];
                    break;
                }
            }
            List<int> outputList = new List<int>();
            if (maxValue == 0)
                Console.WriteLine("NA");
            else
            {
                while(maxValue%2==0 && maxValue>=1)
                {
                    outputList.Add(maxValue);
                    maxValue /= 2;
                }
                outputList.Add(maxValue);
                Console.WriteLine($"Output list:{string.Join(',', outputList)}");
            }
            Console.ReadKey();
        }
    }
}
