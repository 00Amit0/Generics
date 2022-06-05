using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class IntegerComparison
    {
        public static void MaximumIntegerNumber()
        {
            Console.WriteLine("Enter first value");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second value");
            int secondValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third value");
            int thirdValue = Convert.ToInt32(Console.ReadLine());

            if(firstValue.CompareTo(secondValue)>0 && firstValue.CompareTo(thirdValue)>0 ||
                firstValue.CompareTo(secondValue)>=0 && firstValue.CompareTo(thirdValue)>=0 ||
                firstValue.CompareTo(secondValue)>0 && firstValue.CompareTo(thirdValue)>=0
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
