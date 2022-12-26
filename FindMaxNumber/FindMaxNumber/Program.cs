namespace FindMaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output = MaximumNumber.GetMaximum<int>(11, 22, 33);
            Console.WriteLine($"max={output}");
            float output1 = MaximumNumber.GetMaximum<float>(11.5f, 22.5f, 33.5f);
            Console.WriteLine($"max={output1}");
            string output2 = MaximumNumber.GetMaximum<string>("abc", "xyz", "pqr");
            Console.WriteLine($"max={output2}");
        }

    }
}