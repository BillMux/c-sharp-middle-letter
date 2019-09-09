using System;

namespace MiddleLetterCSharp
{
    public class MiddleLetter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string Run(string input)
        {
            int halfLength = input.Length / 2;

            if (input.Length % 2 == 1)
            {
                return "" + input[halfLength];
            }
            else
            {
                return "" + input[halfLength - 1] + input[halfLength];
            }
        }
    }
}
