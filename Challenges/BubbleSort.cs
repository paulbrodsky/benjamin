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

        public void Sort(int[] input)
        {

            bool hasSwapped = true;

            do
            {
                hasSwapped = false;

                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        var temp = input[i];

                        input[i] = input[i + 1];

                        input[i + 1] = temp;

                        hasSwapped = true;

                    }

                }
            } while (hasSwapped);
        }
    }
}


