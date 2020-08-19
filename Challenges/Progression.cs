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
            int[] input = new int[] { 1, 3, 10, 12 };

            bool output = this.CanMakeArithmeticProgression(input);

            Assert.False(output);

        }

        public bool CanMakeArithmeticProgression(int[] input)
        {
            bool output = false;

            this.Sort(input);

            int difference = input[1] - input[0];

            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 1)
                {
                    int temp = input[i] - input[i - 1];

                    if (temp == difference)
                    {
                        output = true;
                    }
                    else
                    {
                        output = false;
                        break;
                    }
                }
                else
                {
                    int temp = input[i + 1] - input[i];

                    if (temp == difference)
                    {
                        output = true;
                    }
                    else
                    {
                        output = false;
                        break;
                    }
                }
            }

            return output;
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


