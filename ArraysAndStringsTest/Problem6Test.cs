using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArraysAndStrringsProblems.Problem6;
using Xunit;

namespace ArraysAndStringsTest
{
    
    public class Problem6Test
    {
        [Fact]
        public void Test0()
        {
            string f = "aaaaaaabbbaaaacccc";
            var b = Problem6Solution.compressJuan(f);
            Assert.Equal("a7b3a4c4", b);
        }
        
        [Fact]
        public void Test1()
        {
            string f = "aaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaacccc";
            var b = Problem6Solution.compressJuan(f);
            Assert.Equal("a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4", b);
        }
        [Fact]
        public void Test2()
        {
            string f = "aaaaaaabbbaaaacccc";
            var b = Problem6Solution.compressCCI(f);
            Assert.Equal("a7b3a4c4", b);
        }
        
        [Fact]
        public void Test3()
        {
            string f = "aaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaaccccaaaaaaabbbaaaacccc";
            var b = Problem6Solution.compressCCI(f);
            Assert.Equal("a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4a7b3a4c4", b);
        }
    }
}
