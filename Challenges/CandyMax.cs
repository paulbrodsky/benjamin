using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class CandyMax
    {
        [Fact]
        public void Run()
        {
            var candyAmount = new int[] { 3, 4, 1 };

            int candyExtra = 1;

            bool[] candyMax = this.GetMax(candyAmount, candyExtra);

            Assert.Equal(new bool[] { false, true, false }, candyMax);
        }

        public bool[] GetMax(int[] candyAmount, int candyExtra)
        {
            int maximum = 0;

            foreach (int n in candyAmount)
            {
                if (n > maximum)
                {
                    maximum = n;
                }
            }

            bool[] greaterThanMaximum = new bool[candyAmount.Length];

            var i = 0;

            foreach (int n in candyAmount)
            {
                greaterThanMaximum[i] = n + candyExtra > maximum;

                i = i + 1;

            }



            return greaterThanMaximum;
        }
    }
}



