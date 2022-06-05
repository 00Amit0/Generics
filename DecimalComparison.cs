using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class DecimalComparison
    {
        public static void MaximumFloatNumber()
        {
            Console.WriteLine("Enter first value");
            double firstValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second value");
            double secondValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third value");
            double thirdValue = Convert.ToDouble(Console.ReadLine());

            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) >= 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0
                )
            {
                Console.WriteLine("The first value is greater : " + firstValue);
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) >= 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0
                )
            {
                Console.WriteLine("The second value is greater : " + secondValue);
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) >= 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0
                )
            {
                Console.WriteLine("The third value is greater : " + thirdValue);
            }


        }
    }
}
