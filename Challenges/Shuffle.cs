using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class Shuffle
    {
        [Fact]
        public void Run()
        {

            int[] indices = new int[] { 4, 5, 6, 7, 0, 2, 1, 3 };

            string s = "codeleet";

            var output = this.RestoreString(s, indices);

            Assert.Equal("leetcode", output);

        }

        public string RestoreString(string s, int[] indices)
        {

            var output = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                for (int x = 0; x < indices.Length; x++)
                {
                    if (i == indices[x])
                    {
                        output += s[x];

                        break;
                    }
                }
            }


            return output;

        }
    }
}



