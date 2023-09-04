using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_divisibility
{
    public class NumberFunction
    {
        public void Number(ulong StartingNumber)
        {
            double DoubledNumber = Math.Sqrt(StartingNumber);
            ulong EstimatedNumber = Convert.ToUInt64(DoubledNumber);
            ulong i;
            for (i = EstimatedNumber; i >= 1; i--)
            {

                if (StartingNumber % i == 0)
                {

                    if (i == (StartingNumber / i))
                    {
                        Console.WriteLine($" {i} is numberator");
                    }
                    else
                    {
                        Console.WriteLine($" {i} is numberator");
                        Console.WriteLine($" {StartingNumber / i} is numberator");
                    }

                }
            }
        }
    }
}
