using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class SubtractNumbers
    {
        public void SubtractOnes()
        {
            Console.WriteLine("Enter a set of numbers separated by spaces:");
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int totalSum = SubtractOnesAndSum(numbers);
            Console.WriteLine($"Sum after subtracting 1 from each number: {totalSum}");
            Console.WriteLine("-----------------------------------------------------");
        }

        private int SubtractOnesAndSum(int[] numbers)
        {
            int totalSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    numbers[i] -= 1;
                }
                totalSum += numbers[i];
            }
            return totalSum;
        }
    }
}
