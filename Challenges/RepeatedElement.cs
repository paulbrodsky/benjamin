using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class RepeatedElement
    {
        [Fact]
        public void Run()
        {
            int[] input = { 5, 1, 5, 2, 5, 3, 5, 4 };

            int output = this.RepeatedNTimes(input);

            Assert.Equal(5, output);


        }

        public int RepeatedNTimes(int[] input)
        {
            int n = input.Length / 2;

            for (int x = 0; x < input.Length; x++)
            {
                int temp = 0;

                for (int y = 0; y < input.Length; y++)
                {
                    if (input[x] == input[y])
                    {
                        temp++;
                    }

                }

                if (temp == n)
                {
                    return input[x];
                }

            }

            return 0;
        }
    }
}




