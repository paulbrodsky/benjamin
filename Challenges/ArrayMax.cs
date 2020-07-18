using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class ArrayMax
    {
        [Fact]
        public void Run()
        {
            var numbers = new int[] { 3, 7, 2, 9, 8, 6, 1, 5, 4 };

            int maximum = this.GetMaximum(numbers);

            Assert.Equal(9, maximum);
        }

        // your code goes here
    }
}



