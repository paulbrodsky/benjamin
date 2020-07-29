using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class NumberString
    {
        [Fact]
        public void Run()
        {
            string result = this.GetNumberString(5);
            Assert.Equal("1,2,3,4,5", result);
        }

        public string GetNumberString(int number)
        {
            var output = string.Empty;

            for (int i = 1; i < number + 1; i++)
            {
                output += i + ",";

                if (i == number)
                {
                    output = output.TrimEnd(',');
                }
            }
            return output;
        }
    }
}



