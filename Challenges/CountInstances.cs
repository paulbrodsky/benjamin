using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class CountInstances
    {
        [Fact]
        public void Run()
        {
            string input = "abacadaeaf";
            int instanceCount = this._CountInstances(intput, "a");
            Assert.Equal(5, instanceCount);
        }

        // your code goes here
    }
}



