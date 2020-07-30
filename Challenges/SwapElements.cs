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

        public void _SwapElements(int[] input)
        {
            var output = new int[] { 0, 0 };

            output[0] += input[1];

            output[1] += input[0];

            input[0] = output[0];

            input[1] = output[1];

        }
    }
}



