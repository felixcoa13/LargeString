using System;

namespace LargeString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Utils.ReadInputFile("Input.txt");
            Utils.Print(input);
            var result = Logic.GetMaxRecurringLetter(input);
            Console.WriteLine($"\nResult: {result}");
        }
    }
}
