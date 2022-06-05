namespace GenericDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //IntegerComparison.MaximumIntegerNumber();
            //DecimalComparison.MaximumFloatNumber();
            //StringComparison.MaximumString();
            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "Heyyy", "Hello", "Heyya", "Bye", "Why" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            //GenericMaximum<Employee> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
            Console.ReadKey();
        }
    }
}
