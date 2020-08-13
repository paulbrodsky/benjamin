using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class Rubiks
    {
        [Fact]
        public void Run()
        {
            var isSolved = this.IsRubiksSolved("GGGGGGGGGRRRRRRRRRBBBBBBBBBOOOOOOOOOWWWWWWWWWYYYYYYYYY");
            Assert.True(isSolved);

            var c1 = this.TurnFaceClockwise("GGGGGGGGGRRRRRRRRRBBBBBBBBBOOOOOOOOOWWWWWWWWWYYYYYYYYY");
            Assert.Equal("GGGGGGGGGWRRWRRWRRBBBBBBBBBOOYOOYOOYWWWWWWOOORRRYYYYYY", c1);
        }

        // your code goes here
    }
}