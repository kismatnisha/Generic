namespace FindMaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Value");
            float firstValue = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please Enter Second Value");
            float secondValue = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Please Enter Third Value");
            float thirdValue = Convert.ToSingle(Console.ReadLine());

            float output = MaximumNumber.MaximumFloatNum(firstValue, secondValue, thirdValue);
            Console.WriteLine("Maximum Float No is");
            Console.WriteLine(output);

        }

    }
}