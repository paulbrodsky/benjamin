using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class DefangIP
    {
        [Fact]
        public void Run()
        {
            string input = "1.1.1.1";

            string output = this.DefangIPaddr(input);

            Assert.Equal("1[.]1[.]1[.]1", output);

        }

        public string DefangIPaddr(string input)
        {
            string output = string.Empty;

            foreach (char c in input)
            {
                if (c == '.')
                {
                    output += "[.]";
                }

                else
                {
                    output += c;
                }
            }
            return output;
        }
    }
}



