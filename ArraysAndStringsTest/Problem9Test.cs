using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArraysAndStrringsProblems.Problem9;
using Xunit;

namespace ArraysAndStringsTest
{
    
    public class Problem9Test
    {
        [Fact]
        public void Test0()
        {
            var b = Problem9Solution.IsRotation("erbottlewat", "waterbottle");
            Assert.True(b);
        }
    }
}
