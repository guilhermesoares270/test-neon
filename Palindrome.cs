using System.Linq;

namespace Test
{
    public class Palindrome
    {
        public readonly string[] palindromes = new string[]
            {
                "asa",
                "assas",
                "ovo",
                "ana",
            };

        public static bool IsPalindrome(string str)
        {
            var reversedString = str.Reverse();

            return str.SequenceEqual(reversedString);
        }

        public static bool IsPalindrome2(string str)
        {
            var reversedString = string.Empty;

            for(var i = str.Length - 1; i >= 0; i--)
            {
                reversedString += str[i];
            }

            return str == reversedString;
        }
    }
}