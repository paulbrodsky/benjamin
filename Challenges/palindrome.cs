using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class Palindrome
    {
        [Fact]
        public void Run()
        {
            int input = 121;

            bool output = this.IsPalindrome(input);

            Assert.True(output);

        }

        public bool IsPalindrome(int input)
        {
            bool output = false;

            string inputString = input.ToString();

            var tempString = string.Empty;

            for (int i = inputString.Length - 1; i > -1; i--)
            {
                tempString = tempString + inputString[i];
            }

            if (tempString == inputString)
            {
                output = true;
            }
            return output;
        }
    }
}



