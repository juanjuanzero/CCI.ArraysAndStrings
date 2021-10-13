using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArraysAndStrringsProblems.Problem4;
using Xunit;

namespace ArraysAndStringsTest
{
    
    public class Problem4Test
    {
        [Fact]
        public void Test10()
        {
            string s = "taco cat";
            var b = Problem4Solution.isPalindromePermutation(s);
            Assert.True(b);
        }
        
        [Fact]
        public void Test11()
        {
            string s = "taco cats";
            var b = Problem4Solution.isPalindromePermutation(s);
            Assert.False(b);
        }
      
    }
}
