using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class RemoveVowels
    {
        [Fact]
        public void Run()
        {
            var vowels = new string[] { "a", "e", "i", "o", "u" };

            string message = "hello world";

            var editedMessage = this.VowelRemove(vowels, message);

            Assert.Equal("hll wrld", editedMessage);
        }

        public string VowelRemove(string[] vowels, string message)
        {
            string output = string.Empty;

            for (int i = 0; i < vowels.Length; i++)
            {
                message = message.Replace(vowels[i], string.Empty);
            }

            return message;
        }

    }
}



