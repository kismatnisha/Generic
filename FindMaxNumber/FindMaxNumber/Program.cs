using System;

namespace FindMaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 12, 35, 45, 85 };
            MaximumNumber<int> generic = new MaximumNumber<int>(array);
            generic.PrintMaxValue();
        }

    }
}