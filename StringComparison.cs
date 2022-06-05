using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class StringComparison
    {
        public static void MaximumString()
        {
            Console.WriteLine("Enter first string");
            string firstString = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter second string");
            string secondString = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter third string");
            string thirdString = Convert.ToString(Console.ReadLine());

            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) >= 0 ||
                firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0
                )
            {
                Console.WriteLine("The first string is greater : " + firstString);
            }
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) >= 0 ||
                secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0
                )
            {
                Console.WriteLine("The second string is greater : " + secondString);
            }
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) >= 0 ||
                thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0
                )
            {
                Console.WriteLine("The third string is greater : " + thirdString);
            }


        }
    }
}
