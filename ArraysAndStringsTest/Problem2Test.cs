using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArraysAndStrringsProblems.Problem2;
using Xunit;

namespace ArraysAndStringsTest
{
    
    public class Problem2Test
    {
        [Fact]
        public void Test10()
        {
            string s = "hello";
            var b = Problem2Solution.isPermutationJuan(s, "olleh");
            Assert.True(b);
        }
        [Fact]
        public void Test11()
        {
            string s = "hellos";
            var b = Problem2Solution.isPermutationJuan(s, "olleh");
            Assert.False(b);
        }
    }
}
