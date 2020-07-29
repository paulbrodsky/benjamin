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

        // your code goes here
    }
}



