using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class AddCharactersChallenge
    {
        [Fact]
        public void Run()
        {
            string input = "123";
            int output = this.AddCharacters(input);
            Assert.Equal(6, output);
        }

        // your code goes here
    }
}



