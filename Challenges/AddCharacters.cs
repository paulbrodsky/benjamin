using System;
using System.IO;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace Challanges
{
    public class AddCharactersChallenge
    {
        [Fact]
        public void Run()
        {
            string input = "321";
            int output = this.AddCharacters(input);
            Assert.Equal(6, output);
        }

        public int AddCharacters(string input)
        {
            var output = 0;

            for (int i = 0; i < input.Length; i++)
            {
                output += int.Parse(input[i].ToString());
            }

            return output;
        }
    }
}



