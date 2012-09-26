using System;
using System.Text.RegularExpressions;

namespace Palindromes
{
    public static class StringExtension
    {
        public static string Clean(this string input)
        {
            if (input == null) return null;
            if (input.Replace(" ", String.Empty).Equals(String.Empty))
                return String.Empty;
            var result = Regex.Replace(input, @"[^a-zA-Z0-9]", "");
            return result;
        }

        public static string Reverse(this string input)
        {
            if (input == null)
            {
                return null;
            }
            var charArray = input.ToCharArray();
            Array.Reverse(charArray);
            var reversed = new string(charArray);
            return reversed;
        }

        public static bool IsPalindrome(this string input)
        {
            if (input == null)
            {
                return false;
            }

            var source = input.Clean();
            var resversed = source.Reverse();

            return source.Equals(resversed, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}