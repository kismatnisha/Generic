namespace FindMaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Value");
            string firstValue = Console.ReadLine();

            Console.WriteLine("Please Enter Second Value");
            string secondValue = Console.ReadLine();

            Console.WriteLine("Please Enter Third Value");
            string thirdValue = Console.ReadLine();

            string output = MaximumNumber.MaximumStringNum(firstValue, secondValue, thirdValue);
            Console.WriteLine("Maxmimum string value is:");
            Console.WriteLine(output);

        }

    }
}