using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class BubbleSort
    {
        [Fact]
        public void Run()
        {
            var input = new[] { 4, 3, 5, 6, 9, 1, 8, 2, 7 };
            this.Sort(input);
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, input);
        }

        // your code goes here
    }
}



