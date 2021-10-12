using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrringsProblems.Problem2
{
    public static class Problem2Solution
    {
        public static bool isPermutationJuan(string a, string b)
        {
            if (a.Length != b.Length) return false;
            var charDict = new Dictionary<char, int>();
            for(var i = 0; i < a.Length; i++)
            {
                if (charDict.ContainsKey(a[i]))
                {
                    charDict[a[i]] += 1;
                }
                else
                {
                    charDict[a[i]] = 1;
                }
            }

            for(var j = 0; j < b.Length; j++)
            {
                if (charDict.ContainsKey(b[j]))
                {
                    if(charDict[b[j]] - 1 < 0)
                    {
                        return false;
                    }
                    else
                    {
                        charDict[b[j]]--;
                    }
                }
                else
                {
                    return false; //its a new key
                }
            }

            return true;
        }
    }
}
