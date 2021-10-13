using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArraysAndStrringsProblems.Problem3;
using Xunit;

namespace ArraysAndStringsTest
{
    
    public class Problem3Test
    {
        [Fact]
        public void Test10()
        {
            string s = "hello world   ";
            var b = Problem3Solution.Urlify(s, 11);
            Assert.Equal("hello%20world\0", b);
        }
        
        [Fact]
        public void Test11()
        {
            string s = "hello world im     ";
            var b = Problem3Solution.Urlify(s, 14);
            Assert.Equal("hello%20world%20im\0", b);
        }
      
    }
}
