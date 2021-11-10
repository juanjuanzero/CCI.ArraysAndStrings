using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArraysAndStrringsProblems.Problem8;
using Xunit;

namespace ArraysAndStringsTest
{
    
    public class Problem8Test
    {
        [Fact]
        public void Test0()
        {
            var loL = new List<List<int>>()
            {
                new List<int>(){1,2,3,4,5},
                new List<int>(){1,2,3,4,5},
                new List<int>(){1,2,0,4,5},
                new List<int>(){1,2,3,4,5},
                new List<int>(){1,2,3,4,5}
            };

            var rotated = Problem8Solution.ZeroMatrix(loL);

            var rotatedList = new List<List<int>>()
            {
                new List<int>(){1,2,0,4,5},
                new List<int>(){1,2,0,4,5},
                new List<int>(){0,0,0,0,0},
                new List<int>(){1,2,0,4,5},
                new List<int>(){1,2,0,4,5}
            };

            Assert.Equal(rotatedList, rotated);
        }
    }
}
