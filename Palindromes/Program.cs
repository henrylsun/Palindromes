using System;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Palindromes! The Funnest game in the world!");
            Console.WriteLine("What is your name? ");
            var name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("You don't want to tell me but that's ok. Lets get down to business.");
            }
            else { Console.WriteLine("Hi {0}!", name); }
            
            Console.WriteLine("Please enter a string. I will tell you if it is a palindrome ：)");
            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter a string.");
                }
                else
                {
                    Console.WriteLine(input.IsPalindrome() ? "Yes" : "No");
                }                
            }
        }
    }
}
