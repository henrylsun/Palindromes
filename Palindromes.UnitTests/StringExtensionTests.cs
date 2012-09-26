using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Palindromes.UnitTests
{
    [TestClass]
    public class StringExtensionTests
    {        

        [TestMethod]
        public void Clean_WithNull_ReturnsNull()
        {
            var result = StringExtension.Clean(null);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void Clean_WithEmptyString_ReturnsEmptyString()
        {
            var input = String.Empty;

            var result = input.Clean();

            Assert.AreEqual(input, result);
        }

        [TestMethod]
        public void Clean_WithNumbersOnly_ReturnsAllNumbers()
        {
            const string input = "1234567890";

            var result = input.Clean();

            Assert.AreEqual(input, result);
        }

        [TestMethod]
        public void Clean_WithAllAlphabets_ReturnsAllAlphabets()
        {
            const string input = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var result = input.Clean();

            Assert.AreEqual(input, result);
        }

        [TestMethod]
        public void Clean_WithSpaces_RemovesAllSpaces()
        {
            const string input = "1  a ";

            var result = input.Clean();

            Assert.AreEqual("1a", result);
        }

        [TestMethod]
        public void Clean_WithNoneNumberNorAlphabet_RemoveThemOut()
        {
            const string input = "`~!@#$%^&*()-_=+[{]}\\|;:'\",<.>/?";

            var result = input.Clean();

            Assert.AreEqual(string.Empty,result);
        }

        [TestMethod]
        public void Reverse_WithNull_ReturnsNull()
        {
            var result = StringExtension.Reverse(null);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Reverse_WithEmptyString_ReturnsEmptyString()
        {
            var result = string.Empty.Reverse();
            Assert.AreEqual(string.Empty,result);
        }

        [TestMethod]
        public void Reverse_WithString_ReverseString()
        {
            const string input = "abcdefg";

            var result = input.Reverse();

            Assert.AreEqual("gfedcba", result);
        }

        [TestMethod]
        public void IsPalindrome_WithNull_ReturnsFalse()
        {
            var result = StringExtension.IsPalindrome(null);
            
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPalindrome_WithEmptyString_ReturnsTrue()
        {
            var input = string.Empty;
            
            var result = input.IsPalindrome();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_WithNonePalindromeNumericString_ReturnsFalse()
        {
            const string input = "12345";

            var result = input.IsPalindrome();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPalindrome_WithNonePalindromeAlphabetString_ReturnsFalse()
        {
            const string input = "abcdefg";

            var result = input.IsPalindrome();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsPalindrome_WithPalindromeNumericString_ReturnsTrue()
        {
            const string input = "123454321";

            var result = input.IsPalindrome();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_WithPalindromeAlphabetString_ReturnsTrue()
        {
            const string input = "abcdefggfedcba";

            var result = input.IsPalindrome();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_WithPalindromeStringContainsNoneAlphabetCharacters_ReturnsTrue()
        {
            const string input = "abc,de-dcba";

            var result = input.IsPalindrome();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_Always_IgnoresCase()
        {
            const string input = "Are we not drawn onward, we few, drawn onward to new era?";

            var result = input.IsPalindrome();

            Assert.IsTrue(result);
        }
    }
}
