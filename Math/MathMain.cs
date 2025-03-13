using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1
{
    class MathMain
    {
        static void Main()
        {
            Calculator sumNumbers = new SumNumbers();
            sumNumbers.CalculateSum();

            Calculator gaussSum = new GaussSum();
            gaussSum.CalculateSum();

            SubtractNumbers subtractNumbers = new SubtractNumbers();
            subtractNumbers.SubtractOnes();
        }
    }
}
