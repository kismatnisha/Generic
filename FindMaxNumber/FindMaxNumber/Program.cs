namespace FindMaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("maximum INT no is");
            int output = MaximumNumber.MaximumNum(11, 25, 33);
            Console.WriteLine(output);

            Console.WriteLine("Maximum Double no is");
            double output1 = MaximumNumber.MaximumNum(11.5, 22.5, 33.5);
            Console.WriteLine(output1);

            Console.WriteLine("Maximum String no is");
            string output2 = MaximumNumber.MaximumNum("abc", "xyz", "pqr");
            Console.WriteLine(output1);
        }

    }
}