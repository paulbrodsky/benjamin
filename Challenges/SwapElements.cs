using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace SwapElements
{
    public class Template
    {
        [Fact]
        public void Run()
        {
            var input = new int[] { 1, 2 };
            this._SwapElements(input);
            Assert.Equal(new int[] { 2, 1 }, input);
        }

        // your code goes here
    }
}



