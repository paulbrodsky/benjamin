using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class InsertionSort
    {
        [Fact]
        public void Run()
        {
            var input = new[] { 4, 3, 5, 6, 9, 1, 8, 2, 7 };
            this.Sort(input);
            Assert.Equal(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, input);

        }

        public void Sort(int[] input)
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


