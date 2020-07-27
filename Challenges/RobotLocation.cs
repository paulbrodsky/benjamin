using System;
using System.IO;
using Xunit;
using System.Collections.Generic;

namespace Challanges
{
    public class RobotLocation
    {
        [Fact]
        public void Run()
        {
            var moves = "UD";

            bool ifBack = this.JudgeCircle(moves);

            Assert.True(ifBack);
        }

        [Fact]
        public void Run2()
        {
            var moves = "LD";

            bool ifBack = this.JudgeCircle(moves);

            Assert.False(ifBack);
        }

        [Fact]
        public void Run3()
        {
            var moves = "LDDRUULR";

            bool ifBack = this.JudgeCircle(moves);

            Assert.True(ifBack);
        }


        public bool JudgeCircle(string moves)
        {
            int[] origin = new int[] { 0, 0 };

            foreach (char c in moves)
            {
                if (c == 'U')
                {
                    origin[1] += 1;
                }

                else if (c == 'D')
                {
                    origin[1] -= 1;
                }

                else if (c == 'L')
                {
                    origin[0] -= 1;
                }

                else if (c == 'R')
                {
                    origin[0] += 1;
                }
            }

            if (origin[0] == 0 && origin[1] == 0)
            {
                return true;
            }

            return false;
        }
    }
}



