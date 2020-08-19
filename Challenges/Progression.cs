using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class Progression
    {
        [Fact]
        public void Run()
        {
            int[] input = new int[] { 1, 2, 4 };

            bool output = this.CanMakeArithmeticProgression(input);

            Assert.False(output);

        }

        public bool CanMakeArithmeticProgression(int[] input)
        {
            this.Sort(input);

            int? lastDifference = null;

            for (int i = 1; i < input.Length; i++)
            {
                int thisDifference = input[i] - input[i - 1];

                if (lastDifference != null && lastDifference != thisDifference)
                {
                    return false;
                }

                lastDifference = thisDifference;
            }

            return true;
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


