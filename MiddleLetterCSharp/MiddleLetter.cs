using System;

namespace MiddleLetterCSharp
{
    public class MiddleLetter
    {
        static void Main()
        {
            MiddleLetter middleLetter = new MiddleLetter();

            while (true)
            {
                Console.WriteLine("Enter a string");
                Console.WriteLine("This program will return the middle of the string");
                Console.WriteLine("To quit, type 'quit'");
                var input = Console.ReadLine();
                if (input == "quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(middleLetter.Run(input));
                }
            }
        }

        public string Run(string input)
        {
            if (input == "")
            {
                return "";
            }

            int half = input.Length / 2;

            if (input.Length % 2 == 1)
            {
                return "" + input[half];
            }
            else
            {
                return "" + input[half - 1] + input[half];
            }
        }
    }
}
