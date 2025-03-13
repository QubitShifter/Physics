using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class GaussSum : Calculator
    {
        public override void CalculateSum()
        {
            int firstNumber = 2;
            int delta = 2;
            int lastNumber = 2048;

            int terms = (lastNumber - firstNumber) / delta + 1;

            int sum = terms * (firstNumber + lastNumber) / 2;

            Console.WriteLine("number of positive terms from 2 to 2048 is:" + terms);
            Console.WriteLine("the sum of positive only numbers from 2 to 2048 is:" + sum);
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
