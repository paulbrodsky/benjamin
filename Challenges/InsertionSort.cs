using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class InsertionSort
    {
        [Theory]
        [InlineData(new int[] { 4, 3, 5, 6, 9, 1, 8, 2, 7 })]
        public void Run(int[] input)
        {
            this.Sort(input);
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, input);
        }

        private void Sort(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                for (int x = i - 1; x >= 0; x--)
                {
                    if (input[i] < input[x])
                    {
                        var temp = input[i];

                        input[i] = input[x];

                        input[x] = temp;

                        i--;


                    }
                }
            }
        }
    }
}


