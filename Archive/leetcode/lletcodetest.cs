using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace leetcode
{
    public class LeetCodeTests
    {
        [Fact]
        public void RemoveDuplicate()
        {
            var originalList = "3231214321";

            var emptyList = string.Empty;

            foreach (char c in originalList)
            {
                if (!emptyList.Contains(c))
                {
                    emptyList = emptyList + c;
                }
            }

            Assert.Equal("3214", emptyList);
        }

        int[] arr = { 10, 324, 45, 90, 9808 };

        // Method to find maximum in arr[] 
        [Fact]
        static int largest()
        {
            int i;

            // Initialize maximum element 
            int max = arr[0];

            // Traverse array elements from second and 
            // compare every element with current max  
            for (i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];

            Assert.Equal("9808", largest());

            return max;
        }
    }
}



