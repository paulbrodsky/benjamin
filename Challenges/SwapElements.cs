using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace SwapElements
{
    public class Template
    {
        [Theory]
        [InlineData(new int[] { 1, 2 })]
        public void Run(int[] input)
        {
            this._SwapElements(input);
            Assert.Equal(new int[] { 2, 1 }, input);
        }

        private void _SwapElements(int[] input)
        {
            var output = 0;

            output = input[0];

            input[0] = input[1];

            input[1] = output;

        }
    }
}



