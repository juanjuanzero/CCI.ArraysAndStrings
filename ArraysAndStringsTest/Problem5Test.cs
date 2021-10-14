using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArraysAndStrringsProblems.Problem5;
using Xunit;

namespace ArraysAndStringsTest
{
    
    public class Problem5Test
    {
        [Fact]
        public void Test10()
        {
            string f = "taca";
            string s = "taco";
            var b = Problem5Solution.oneEditAway(f,s);
            Assert.True(b);
        }
        
        [Fact]
        public void Test11()
        {
            string f = "tacos";
            string s = "taco";
            var b = Problem5Solution.oneEditAway(f,s);
            Assert.True(b);
        }
        [Fact]
        public void Test12()
        {
            string f = "pale";
            string s = "bale";
            var b = Problem5Solution.oneEditAway(f,s);
            Assert.True(b);
        }
        [Fact]
        public void Test13()
        {
            string f = "pale";
            string s = "bale";
            var b = Problem5Solution.oneEditAway(f,s);
            Assert.True(b);
        }
        [Fact]
        public void Test14()
        {
            string f = "pale";
            string s = "bae";
            var b = Problem5Solution.oneEditAway(f,s);
            Assert.False(b);
        }
      
    }
}
