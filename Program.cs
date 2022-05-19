using System;

namespace Test
{
    class Program
    {
        public static readonly string[] palindromes = new string[]
            {
                "asa",
                "assa",
                "ovo",
                "ana",
            };

        static void Main(string[] args)
        {
            var res = Cedula.Process(149);

            foreach(var item in res)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine();

            foreach(var item in Program.palindromes)
            {
                Console.WriteLine(Palindrome.IsPalindrome2(item));
            }
        }
    }
}
