using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

// namespace Challanges
// {
//     public class SingleNumberTest
//     {
//         [Fact]
//         public void Run()
//         {
//             int[] nums = new int[] { 2, 3, 2, 1, 3 };

//             int[] output = this.SingleNumber(nums);

//             Assert.Equal(output, new int[] { 2, 2, 2, 1, 2 });

//         }

//         public int[] SingleNumber(int[] nums)
//         {
//             int[] output = new int[nums.Length];


//             for (int i = 0; i < nums.Length; i++)
//             {
//                 foreach (int y in nums)
//                 {
//                     if (y == nums[i])
//                     {
//                         output[i] += 1;

//                     }
//                 }
//             }
//             return output;
//         }
//     }
// }

namespace Challanges
{
    public class SingleNumberTest
    {
        [Fact]
        public void Run()
        {
            int[] nums = new int[] { 2, 2, 1 };

            int output = this.SingleNumber(nums);

            Assert.Equal(output, 1);

        }

        // var numberAmount = 0;

        // foreach (int x in nums)
        // {
        //     if (x == nums[i])
        //     {
        //         numberAmount += 1;
        //     }
        // }

        // if (numberAmount == 1)
        // {
        //     output = nums[i];
        // }

        public int SingleNumber(int[] nums)
        {

            Dictionary<int, int> numberDictionary = new Dictionary<int, int>();

            int output = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (numberDictionary.ContainsKey(nums[i]))
                {
                    numberDictionary[nums[i]] += 1;
                }

                else
                {
                    numberDictionary.Add(nums[i], 1);
                }

            }

            foreach (var kv in numberDictionary)
            {
                if (kv.Value == 1)
                {
                    output = kv.Key;
                }
            }

            return output;
        }
    }
}



