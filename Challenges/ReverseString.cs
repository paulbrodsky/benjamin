using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class ReverseString
    {
        [Fact]
        public void Run()
        {
            string input = "!boj taerg";

            string output = this.ReverseMessage(input);

            Assert.Equal("great job!", output);
        }

        public string ReverseMessage(string input)
        {
            var output = string.Empty;

            for (int i = input.Length - 1; i > -1; i--)
            {
                output = output + input[i];
            }

            return output;
        }
    }
}



