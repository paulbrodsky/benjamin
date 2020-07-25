using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class HowManyNums
    {
        [Fact]
        public void Run()
        {
            var numbers = new int[] { 3, 5, 1, 11 };

            var test = new int[] { 1, 2, 0, 3 };

            var final = this.SmallerNumbersThanCurrent(numbers);

            Assert.Equal(test, final);
        }

        public int[] SmallerNumbersThanCurrent(int[] numbers)
        {
            int[] numbersLessThan = new int[numbers.Length];

            for (int x = 0; x < numbers.Length; x++)
            {
                int numbersLessThanN = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[x] > numbers[i])
                    {
                        numbersLessThanN += 1;

                    }
                }
                numbersLessThan[x] = numbersLessThanN;
            }

            return numbersLessThan;
        }
    }
}




