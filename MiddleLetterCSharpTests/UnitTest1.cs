using MiddleLetterCSharp;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [TestCase("A", "A")]
        [TestCase("AB", "AB")]
        [TestCase("ABC", "B")]
        [TestCase("ABCD", "BC")]

        public void TestIOFormat(string input, string expect)
        {
            MiddleLetter middle = new MiddleLetter();
            string result = middle.Run(input);
            Assert.AreEqual(result, expect);
        }
    }
}