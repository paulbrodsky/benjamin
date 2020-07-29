using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class CountInstances
    {
        [Fact]
        public void Run()
        {
            string x = "abacadaeaf";
            int instanceCount = this._CountInstances(x, "a");
            Assert.Equal(5, instanceCount);
        }

        public int _CountInstances(string input, string letter)
        {
            int output = 0;

            foreach (char c in input)
            {
                if (c.ToString() == letter)
                {
                    output++;
                }
            }
            return output;
        }
    }
}



