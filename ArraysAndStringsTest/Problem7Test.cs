using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArraysAndStrringsProblems.Problem7;
using Xunit;

namespace ArraysAndStringsTest
{
    
    public class Problem7Test
    {
        [Fact]
        public void Test0()
        {
            var loL = new List<List<int>>()
            {
                new List<int>(){1,2,3,4,5},
                new List<int>(){1,2,3,4,5},
                new List<int>(){1,2,3,4,5},
                new List<int>(){1,2,3,4,5},
                new List<int>(){1,2,3,4,5}
            };

            var rotated = Problem7Solution.Rotate90Degrees(loL);

            var rotatedList = new List<List<int>>()
            {
                new List<int>(){5,5,5,5,5},
                new List<int>(){4,4,4,4,4},
                new List<int>(){3,3,3,3,3},
                new List<int>(){2,2,2,2,2},
                new List<int>(){1,1,1,1,1}
            };

            Assert.Equal(rotatedList, rotated);
        }
        [Fact]
        public void Test1()
        {
            var loL = new List<List<int>>()
            {
                new List<int>(){1,2,3,4,5},
                new List<int>(){1,2,3,4,5},
                new List<int>(){1,2,3,4,5},
                new List<int>(){1,2,3,4,5},
                new List<int>(){1,2,3,4,5}
            };

            var rotated = Problem7Solution.RotateInplaceCci(loL);

            var rotatedList = new List<List<int>>()
            {
                new List<int>(){1,1,1,1,1},
                new List<int>(){2,2,2,2,2},
                new List<int>(){3,3,3,3,3},
                new List<int>(){4,4,4,4,4},
                new List<int>(){5,5,5,5,5}
            };

            Assert.Equal(rotatedList, rotated);
        }
        
        
    }
}
