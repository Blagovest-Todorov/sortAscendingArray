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

            Array.Sort(numbers);

            Console.WriteLine();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }



        }
    }
}
