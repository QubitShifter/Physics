using System;

namespace HW_1
{
    class SumNumbers : Calculator
    {
        public override void CalculateSum()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("The sum of numbers from 1 to 100 is: " + sum);
            Console.WriteLine("-------------------------------------------");
        }
    }
}
