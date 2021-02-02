using System;
using System.Linq;

namespace Arrange_ArrayAscending
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)  // inittialize an  array; // 5 2 4 3
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                // int currElement = numbers[i]; // we take the first number of the numbers[]

                for (int j = i + 1; j < numbers.Length; j++)  // We rotate from second number to end number
                {
                    if (numbers[i] > numbers[j])  // if this is true
                    {
                        int tempNumb = numbers[i];
                        numbers[i] = numbers[j]; // we change their places; ---second number become first
                        numbers[j] = tempNumb; // first number becomes second 
                                               // we have a new first number--minNumber so we reinitialize the currNumber
                    }
                }
            }

            Console.WriteLine();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }



        }
    }
}
