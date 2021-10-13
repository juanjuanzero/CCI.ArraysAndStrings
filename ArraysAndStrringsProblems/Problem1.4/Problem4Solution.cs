using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrringsProblems.Problem4
{
    public static class Problem4Solution
    {
        public static bool isPalindromePermutation(string s)
        {
            Dictionary<char, int> charDict = new();
            for(var i = 0; i < s.Length; i++)
            {
                if(s[i] != ' ')
                {
                    if (charDict.ContainsKey(s[i]))
                    {
                        charDict[s[i]] += 1;
                    }
                    else
                    {
                        charDict[s[i]] = 1;
                    }
                }
                
            }
            bool hasOneOdd = false;
            foreach(var c in charDict)
            {
                if(c.Value % 2 != 0 && !hasOneOdd) //its an even number
                {
                    hasOneOdd = true;
                }
                else if(c.Value % 2 != 0 && hasOneOdd)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
