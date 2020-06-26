using System;
using Xunit;
using lib;
using System.Collections.Generic;

namespace tests
{
    public class SubcipherMapTest
    {
        [Fact]
        public void Baseline()
        {
            var sut = new SubcipherMap();

            var map = "A=Z\r\nB=Y\r\nC=X";

            Dictionary<char, char> result = sut.GetMap(map);
            Assert.Equal(3, result.Keys.Count);

            Assert.True(result.ContainsKey('A'));
            Assert.Equal('Z', result['A']);

            Assert.True(result.ContainsKey('B'));
            Assert.Equal('Y', result['B']);

            Assert.True(result.ContainsKey('C'));
            Assert.Equal('X', result['C']);
        }
    }
}
