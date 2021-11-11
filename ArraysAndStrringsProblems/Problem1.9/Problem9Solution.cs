using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrringsProblems.Problem9
{
    public static class Problem9Solution
    {
        public static bool IsRotation(string s1, string s2)
        {
            var concated = s1 + s1;
            if (concated.Contains(s2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
