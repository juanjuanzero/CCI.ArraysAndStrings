using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArraysAndStrringsProblems.Problem1;
using Xunit;

namespace ArraysAndStringsTest
{
    
    public class Problem1Test
    {
        [Fact]
        public void Test10()
        {
            string s = "hello";
            var b = Problem1Solution.isUniqueCharsASCII(s);
            Assert.False(b);
        }
        [Fact]
        public void Test11()
        {
            string s = "hello";
            var b = Problem1Solution.isUniqueCharsJuan(s);
            Assert.False(b);
        }
        [Fact]
        public void Test20()
        {
            string s = "World";
            var b = Problem1Solution.isUniqueCharsASCII(s);
            Assert.True(b);
        }
        [Fact]
        public void Test21()
        {
            string s = "World";
            var b = Problem1Solution.isUniqueCharsJuan(s);
            Assert.True(b);
        }
    }
}
