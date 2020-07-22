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

            string output = this.ReverseString(input);

            Assert.Equal("great job!", output);
        }

        // your code goes here
    }
}



